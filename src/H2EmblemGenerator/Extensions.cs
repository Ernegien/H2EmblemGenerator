using ImageMagick;

namespace H2EmblemGenerator
{
    internal static class Extensions
    {
        public static MagickColor ToMagickColor(this EmblemColor color)
        {
            return color switch
            {
                EmblemColor.White => new MagickColor(204, 204, 204),
                EmblemColor.Steel => new MagickColor(85, 85, 85),
                EmblemColor.Red => new MagickColor(170, 34, 34),
                EmblemColor.Orange => new MagickColor(221, 102, 34),
                EmblemColor.Gold => new MagickColor(187, 153, 0),
                EmblemColor.Olive => new MagickColor(119, 170, 0),
                EmblemColor.Green => new MagickColor(34, 136, 68),
                EmblemColor.Sage => new MagickColor(0, 68, 51),
                EmblemColor.Cyan => new MagickColor(17, 170, 170),
                EmblemColor.Teal => new MagickColor(51, 119, 119),
                EmblemColor.Cobalt => new MagickColor(17, 102, 170),
                EmblemColor.Blue => new MagickColor(34, 68, 170),
                EmblemColor.Violet => new MagickColor(68, 51, 119),
                EmblemColor.Purple => new MagickColor(153, 68, 153),
                EmblemColor.Pink => new MagickColor(221, 136, 221),
                EmblemColor.Crimson => new MagickColor(153, 34, 85),
                EmblemColor.Brown => new MagickColor(119, 68, 34),
                EmblemColor.Tan => new MagickColor(187, 153, 119),
                _ => MagickColors.Black,
            };
        }

        public static Color ToColor(this MagickColor color)
        {
            return Color.FromArgb(color.A, color.R, color.G, color.B);
        }
    }
}
