using ImageMagick;
using System.IO.Compression;
using System.Reflection;

namespace H2EmblemGenerator
{
    internal class Emblem
    {
        public const int Width = 128;
        public const int Height = 128;

        public EmblemBackground Background { get; set; }
        public EmblemColor BackgroundPrimaryColor { get; set; }
        public EmblemColor BackgroundSecondaryColor { get; set; }
        public EmblemForeground Foreground { get; set; }
        public EmblemColor ForegroundPrimaryColor { get; set; }
        public EmblemColor ForegroundSecondaryColor { get; set; }
        public EmblemToggle Toggle { get; set; }

        private static Bitmap InvalidBitmap
        {
            get
            {
                using MagickImage invalid = new(MagickColors.Transparent, Width, Height);
                using var ms = new MemoryStream();
                invalid.Write(ms, MagickFormat.Bmp3);
                return new Bitmap(ms);
            }
        }

        public Emblem()
        {
            Random();
        }

        public void Random()
        {
            Background = (EmblemBackground)System.Random.Shared.Next(0, 32);
            BackgroundPrimaryColor = (EmblemColor)System.Random.Shared.Next(0, 18);
            BackgroundSecondaryColor = (EmblemColor)System.Random.Shared.Next(0, 18);
            Foreground = (EmblemForeground)System.Random.Shared.Next(0, 64);
            ForegroundPrimaryColor = (EmblemColor)System.Random.Shared.Next(0, 18);
            ForegroundSecondaryColor = (EmblemColor)System.Random.Shared.Next(0, 18);
            Toggle = (EmblemToggle)System.Random.Shared.Next(2, 4);
        }

        public Bitmap ToBitmap()
        {
            try
            {
                // get streaming access to the emblem resources
                var assembly = Assembly.GetExecutingAssembly().GetName();
                using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"{assembly.Name}.resources.emblems.zip")!;
                using var zip = new ZipArchive(stream, ZipArchiveMode.Read);

                // load the background mask image
                var backgroundEntry = zip.GetEntry($"background/{(int)Background}.tif");
                if (backgroundEntry == null) return InvalidBitmap;
                using var backgroundMaskStream = backgroundEntry.Open();
                using var backgroundMaskImage = new MagickImage(backgroundMaskStream);
                var bps = backgroundMaskImage.GetPixels();
                var bpc = BackgroundPrimaryColor.ToMagickColor();
                var bsc = BackgroundSecondaryColor.ToMagickColor();

                // load the foreground mask image
                var foregroundEntry = zip.GetEntry($"foreground/{(int)Foreground}.tif");
                if (foregroundEntry == null) return InvalidBitmap;
                using var foregroundMaskStream = foregroundEntry.Open();
                using var foregroundMaskImage = new MagickImage(foregroundMaskStream);
                var fps = foregroundMaskImage.GetPixels();
                var fpc = ForegroundPrimaryColor.ToMagickColor();
                var fsc = ForegroundSecondaryColor.ToMagickColor();

                // interprets mask values greater than or equal to this as solid
                float solidThreshold = 240.0f;

                // loop through each mask pixel
                var pixelBytes = new byte[3];
                for (int y = 0; y < Height; y++)
                {
                    for (int x = 0; x < Width; x++)
                    {
                        // get the mask pixel info
                        var bmp = bps.GetPixel(x, y).ToColor();
                        var fmp = fps.GetPixel(x, y).ToColor();
                        double backgroundPrimaryMask = Math.Min(bmp.G / solidThreshold, 1.0f);
                        double backgroundSecondaryMask = Math.Min(bmp.B / solidThreshold, 1.0f);

                        // set the background color according to the primary/secondary mask values
                        // NOTE: the combined masks don't overflow so there's no real need to do any scaling
                        pixelBytes[0] = (byte)(bpc.R * backgroundPrimaryMask + bsc.R * backgroundSecondaryMask);
                        pixelBytes[1] = (byte)(bpc.G * backgroundPrimaryMask + bsc.G * backgroundSecondaryMask);
                        pixelBytes[2] = (byte)(bpc.B * backgroundPrimaryMask + bsc.B * backgroundSecondaryMask);

                        // blend secondary foreground with background
                        if (fmp.B > 16)
                        {
                            double foregroundSecondaryMask = Math.Min(fmp.B / solidThreshold, 1.0f);
                            pixelBytes[0] = (byte)(pixelBytes[0] * (1.0f - foregroundSecondaryMask) + fsc.R * foregroundSecondaryMask);
                            pixelBytes[1] = (byte)(pixelBytes[1] * (1.0f - foregroundSecondaryMask) + fsc.G * foregroundSecondaryMask);
                            pixelBytes[2] = (byte)(pixelBytes[2] * (1.0f - foregroundSecondaryMask) + fsc.B * foregroundSecondaryMask);
                        }

                        // blend primary foreground with any existing background and secondary foreground
                        if (fmp.G > 16 && Toggle == EmblemToggle.Default)
                        {
                            double foregroundPrimaryMask = Math.Min(fmp.G / solidThreshold, 1.0f);
                            pixelBytes[0] = (byte)(pixelBytes[0] * (1.0f - foregroundPrimaryMask) + fpc.R * foregroundPrimaryMask);
                            pixelBytes[1] = (byte)(pixelBytes[1] * (1.0f - foregroundPrimaryMask) + fpc.G * foregroundPrimaryMask);
                            pixelBytes[2] = (byte)(pixelBytes[2] * (1.0f - foregroundPrimaryMask) + fpc.B * foregroundPrimaryMask);
                        }

                        bps.SetPixel(x, y, pixelBytes);
                    }
                }

                // return the bitmap
                using var ms = new MemoryStream();
                backgroundMaskImage.Write(ms, MagickFormat.Bmp3);
                return new Bitmap(ms);
            }
            catch
            {
                return InvalidBitmap;
            }
        }
    }
}
