using System.Diagnostics;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

// TODO: error-handling, custom color pickers
namespace H2EmblemGenerator
{
    public partial class MainForm : Form
    {
        private readonly Emblem _emblem = new();
        private bool _formBulkUpdate = false;

        public MainForm()
        {
            InitializeComponent();
            BindBackgroundBox();
            BindForegroundBox();
            BindColorBox(cmbPrimaryPlayerColor);
            BindColorBox(cmbSecondaryPlayerColor);
            BindColorBox(cmbPrimaryEmblemColor);
            BindColorBox(cmbSecondaryEmblemColor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateFormFromEmblem();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png";
            sfd.FileName = "emblem.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // can't save the image directly while it's bound to a picturebox due to GDI fuckery so create a copy first
                using var bmp = new Bitmap(picEmblem.Image);
                bmp.Save(sfd.FileName, ImageFormat.Png);
            }
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            _emblem.Random();
            UpdateFormFromEmblem();
        }

        private void UpdateFormFromEmblem()
        {
            _formBulkUpdate = true;

            // update the configurable form options
            cmbPrimaryPlayerColor.SelectedValue = _emblem.BackgroundPrimaryColor;
            cmbSecondaryPlayerColor.SelectedValue = _emblem.BackgroundSecondaryColor;
            cmbPrimaryEmblemColor.SelectedValue = _emblem.ForegroundPrimaryColor;
            cmbSecondaryEmblemColor.SelectedValue = _emblem.ForegroundSecondaryColor;
            cmbEmblemBackground.SelectedValue = _emblem.Background;
            cmbEmblemForeground.SelectedValue = _emblem.Foreground;
            chkDisablePrimaryEmblem.Checked = _emblem.Toggle == EmblemToggle.PrimaryDisabled;

            UpdateColors();
            UpdateEmblem();

            _formBulkUpdate = false;
        }

        private void UpdateEmblemFromForm()
        {
            // don't do anything if we're bulk-updating the form contents elsewhere
            if (_formBulkUpdate) return;

            // update the emblem from the configurable form options
            _emblem.BackgroundPrimaryColor = (EmblemColor)cmbPrimaryPlayerColor.SelectedValue!;
            _emblem.BackgroundSecondaryColor = (EmblemColor)cmbSecondaryPlayerColor.SelectedValue!;
            _emblem.ForegroundPrimaryColor = (EmblemColor)cmbPrimaryEmblemColor.SelectedValue!;
            _emblem.ForegroundSecondaryColor = (EmblemColor)cmbSecondaryEmblemColor.SelectedValue!;
            _emblem.Background = (EmblemBackground)cmbEmblemBackground.SelectedValue!;
            _emblem.Foreground = (EmblemForeground)cmbEmblemForeground.SelectedValue!;
            _emblem.Toggle = chkDisablePrimaryEmblem.Checked ? EmblemToggle.PrimaryDisabled : EmblemToggle.Default;

            UpdateColors();
            UpdateEmblem();
        }

        private void UpdateColors()
        {
            picPrimaryPlayerColor.BackColor = _emblem.BackgroundPrimaryColor.ToMagickColor().ToColor();
            picSecondaryPlayerColor.BackColor = _emblem.BackgroundSecondaryColor.ToMagickColor().ToColor();
            picPrimaryEmblemColor.BackColor = _emblem.ForegroundPrimaryColor.ToMagickColor().ToColor();
            picSecondaryEmblemColor.BackColor = _emblem.ForegroundSecondaryColor.ToMagickColor().ToColor();
        }

        private void UpdateEmblem()
        {
            picEmblem.Image?.Dispose();
            picEmblem.Image = _emblem.ToBitmap();
        }

        private void FormChanged(object sender, EventArgs e)
        {
            UpdateEmblemFromForm();
        }

        private void chkDisablePrimaryEmblem_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEmblemFromForm();
        }

        private void BindColorBox(ComboBox box)
        {
            var items = new Dictionary<EmblemColor, string>();
            for (int i = 0; i < 18; i++)
            {
                items.Add((EmblemColor)i, ((EmblemColor)i).ToString());
            }

            box.DataSource = new BindingSource(items, null);
            box.DisplayMember = "Value";
            box.ValueMember = "Key";
            box.SelectedIndex = 0;
            box.SelectedIndexChanged += new EventHandler(FormChanged!);
        }

        private void BindForegroundBox()
        {
            var items = new Dictionary<EmblemForeground, string>();
            for (int i = 0; i < 64; i++)
            {
                items.Add((EmblemForeground)i, ((EmblemForeground)i).ToString());
            }

            cmbEmblemForeground.DataSource = new BindingSource(items, null);
            cmbEmblemForeground.DisplayMember = "Value";
            cmbEmblemForeground.ValueMember = "Key";
            cmbEmblemForeground.SelectedIndex = 0;
            cmbEmblemForeground.SelectedIndexChanged += new EventHandler(FormChanged!);
        }

        private void BindBackgroundBox()
        {
            var items = new Dictionary<EmblemBackground, string>();
            for (int i = 0; i < 32; i++)
            {
                items.Add((EmblemBackground)i, ((EmblemBackground)i).ToString());
            }

            cmbEmblemBackground.DataSource = new BindingSource(items, null);
            cmbEmblemBackground.DisplayMember = "Value";
            cmbEmblemBackground.ValueMember = "Key";
            cmbEmblemBackground.SelectedIndex = 0;
            cmbEmblemBackground.SelectedIndexChanged += new EventHandler(FormChanged!);
        }

        private void picPrimaryPlayerColor_Click(object sender, MouseEventArgs e)
        {
            CycleColor(cmbPrimaryPlayerColor, e);
        }
        
        private void picSecondaryPlayerColor_Click(object sender, MouseEventArgs e)
        {
            CycleColor(cmbSecondaryPlayerColor, e);
        }

        private void picPrimaryEmblemColor_Click(object sender, MouseEventArgs e)
        {
            CycleColor(cmbPrimaryEmblemColor, e);
        }

        private void picSecondaryEmblemColor_Click(object sender, MouseEventArgs e)
        {
            CycleColor(cmbSecondaryEmblemColor, e);
        }

        private void CycleColor(ComboBox combo, MouseEventArgs e)
        {
            int index = combo.SelectedIndex;
            switch (e.Button)
            {
                // previous color
                case MouseButtons.Left:
                    index--;
                    break;

                // next color
                case MouseButtons.Right:
                    index++;
                    break;

                // do nothing
                default:
                    break;
            }

            // set the new selected index, allowing it to wrap around in both directions
            combo.SelectedIndex = (index % combo.Items.Count + combo.Items.Count) % combo.Items.Count;
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            OpenWebPage("https://github.com/Ernegien/H2EmblemGenerator");
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenWebPage(string url)
        {
            try
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    Process.Start(url);
                }
            }
            catch
            {
                MessageBox.Show(url, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
