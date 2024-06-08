namespace H2EmblemGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuStrip = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            mnuAbout = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            groupBox1 = new GroupBox();
            btnRandomize = new Button();
            label6 = new Label();
            label5 = new Label();
            picSecondaryEmblemColor = new PictureBox();
            picPrimaryEmblemColor = new PictureBox();
            picSecondaryPlayerColor = new PictureBox();
            picPrimaryPlayerColor = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            chkDisablePrimaryEmblem = new CheckBox();
            cmbEmblemBackground = new ComboBox();
            cmbEmblemForeground = new ComboBox();
            cmbSecondaryEmblemColor = new ComboBox();
            cmbPrimaryEmblemColor = new ComboBox();
            cmbSecondaryPlayerColor = new ComboBox();
            cmbPrimaryPlayerColor = new ComboBox();
            label1 = new Label();
            picEmblem = new PictureBox();
            grpEmblem = new GroupBox();
            btnSave = new Button();
            mnuStrip.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSecondaryEmblemColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPrimaryEmblemColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSecondaryPlayerColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPrimaryPlayerColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEmblem).BeginInit();
            grpEmblem.SuspendLayout();
            SuspendLayout();
            // 
            // mnuStrip
            // 
            mnuStrip.Items.AddRange(new ToolStripItem[] { mnuFile, mnuAbout });
            mnuStrip.Location = new Point(0, 0);
            mnuStrip.Name = "mnuStrip";
            mnuStrip.Size = new Size(501, 24);
            mnuStrip.TabIndex = 0;
            mnuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(37, 20);
            mnuFile.Text = "File";
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(180, 22);
            mnuExit.Text = "Exit";
            mnuExit.Click += this.mnuExit_Click;
            // 
            // mnuAbout
            // 
            mnuAbout.Name = "mnuAbout";
            mnuAbout.Size = new Size(52, 20);
            mnuAbout.Text = "About";
            mnuAbout.Click += mnuAbout_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 258);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(501, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(btnRandomize);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(picSecondaryEmblemColor);
            groupBox1.Controls.Add(picPrimaryEmblemColor);
            groupBox1.Controls.Add(picSecondaryPlayerColor);
            groupBox1.Controls.Add(picPrimaryPlayerColor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(chkDisablePrimaryEmblem);
            groupBox1.Controls.Add(cmbEmblemBackground);
            groupBox1.Controls.Add(cmbEmblemForeground);
            groupBox1.Controls.Add(cmbSecondaryEmblemColor);
            groupBox1.Controls.Add(cmbPrimaryEmblemColor);
            groupBox1.Controls.Add(cmbSecondaryPlayerColor);
            groupBox1.Controls.Add(cmbPrimaryPlayerColor);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 228);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Options";
            // 
            // btnRandomize
            // 
            btnRandomize.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRandomize.Location = new Point(198, 196);
            btnRandomize.Name = "btnRandomize";
            btnRandomize.Size = new Size(126, 23);
            btnRandomize.TabIndex = 4;
            btnRandomize.Text = "Randomize";
            btnRandomize.UseVisualStyleBackColor = true;
            btnRandomize.Click += btnRandomize_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 170);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 15;
            label6.Text = "Emblem Background";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 141);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 14;
            label5.Text = "Emblem Foreground";
            // 
            // picSecondaryEmblemColor
            // 
            picSecondaryEmblemColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picSecondaryEmblemColor.BorderStyle = BorderStyle.Fixed3D;
            picSecondaryEmblemColor.Location = new Point(279, 109);
            picSecondaryEmblemColor.Name = "picSecondaryEmblemColor";
            picSecondaryEmblemColor.Size = new Size(45, 23);
            picSecondaryEmblemColor.TabIndex = 13;
            picSecondaryEmblemColor.TabStop = false;
            picSecondaryEmblemColor.MouseDown += picSecondaryEmblemColor_Click;
            // 
            // picPrimaryEmblemColor
            // 
            picPrimaryEmblemColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picPrimaryEmblemColor.BorderStyle = BorderStyle.Fixed3D;
            picPrimaryEmblemColor.Location = new Point(279, 80);
            picPrimaryEmblemColor.Name = "picPrimaryEmblemColor";
            picPrimaryEmblemColor.Size = new Size(45, 23);
            picPrimaryEmblemColor.TabIndex = 12;
            picPrimaryEmblemColor.TabStop = false;
            picPrimaryEmblemColor.MouseDown += picPrimaryEmblemColor_Click;
            // 
            // picSecondaryPlayerColor
            // 
            picSecondaryPlayerColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picSecondaryPlayerColor.BorderStyle = BorderStyle.Fixed3D;
            picSecondaryPlayerColor.Location = new Point(279, 51);
            picSecondaryPlayerColor.Name = "picSecondaryPlayerColor";
            picSecondaryPlayerColor.Size = new Size(45, 23);
            picSecondaryPlayerColor.TabIndex = 11;
            picSecondaryPlayerColor.TabStop = false;
            picSecondaryPlayerColor.MouseDown += picSecondaryPlayerColor_Click;
            // 
            // picPrimaryPlayerColor
            // 
            picPrimaryPlayerColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picPrimaryPlayerColor.BorderStyle = BorderStyle.Fixed3D;
            picPrimaryPlayerColor.Location = new Point(279, 22);
            picPrimaryPlayerColor.Name = "picPrimaryPlayerColor";
            picPrimaryPlayerColor.Size = new Size(45, 23);
            picPrimaryPlayerColor.TabIndex = 10;
            picPrimaryPlayerColor.TabStop = false;
            picPrimaryPlayerColor.MouseDown += picPrimaryPlayerColor_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 112);
            label4.Name = "label4";
            label4.Size = new Size(141, 15);
            label4.TabIndex = 9;
            label4.Text = "Secondary Emblem Color";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 8;
            label3.Text = "Primary Emblem Color";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 7;
            label2.Text = "Secondary Player Color";
            // 
            // chkDisablePrimaryEmblem
            // 
            chkDisablePrimaryEmblem.AutoSize = true;
            chkDisablePrimaryEmblem.Location = new Point(5, 199);
            chkDisablePrimaryEmblem.Name = "chkDisablePrimaryEmblem";
            chkDisablePrimaryEmblem.RightToLeft = RightToLeft.Yes;
            chkDisablePrimaryEmblem.Size = new Size(187, 19);
            chkDisablePrimaryEmblem.TabIndex = 6;
            chkDisablePrimaryEmblem.Text = "Disable Primary Emblem Color";
            chkDisablePrimaryEmblem.UseVisualStyleBackColor = true;
            chkDisablePrimaryEmblem.CheckedChanged += chkDisablePrimaryEmblem_CheckedChanged;
            // 
            // cmbEmblemBackground
            // 
            cmbEmblemBackground.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbEmblemBackground.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmblemBackground.FormattingEnabled = true;
            cmbEmblemBackground.Location = new Point(152, 167);
            cmbEmblemBackground.Name = "cmbEmblemBackground";
            cmbEmblemBackground.Size = new Size(172, 23);
            cmbEmblemBackground.TabIndex = 5;
            // 
            // cmbEmblemForeground
            // 
            cmbEmblemForeground.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbEmblemForeground.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmblemForeground.FormattingEnabled = true;
            cmbEmblemForeground.Location = new Point(152, 138);
            cmbEmblemForeground.Name = "cmbEmblemForeground";
            cmbEmblemForeground.Size = new Size(172, 23);
            cmbEmblemForeground.TabIndex = 5;
            // 
            // cmbSecondaryEmblemColor
            // 
            cmbSecondaryEmblemColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbSecondaryEmblemColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSecondaryEmblemColor.FormattingEnabled = true;
            cmbSecondaryEmblemColor.Location = new Point(152, 109);
            cmbSecondaryEmblemColor.Name = "cmbSecondaryEmblemColor";
            cmbSecondaryEmblemColor.Size = new Size(121, 23);
            cmbSecondaryEmblemColor.TabIndex = 4;
            // 
            // cmbPrimaryEmblemColor
            // 
            cmbPrimaryEmblemColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbPrimaryEmblemColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrimaryEmblemColor.FormattingEnabled = true;
            cmbPrimaryEmblemColor.Location = new Point(152, 80);
            cmbPrimaryEmblemColor.Name = "cmbPrimaryEmblemColor";
            cmbPrimaryEmblemColor.Size = new Size(121, 23);
            cmbPrimaryEmblemColor.TabIndex = 3;
            // 
            // cmbSecondaryPlayerColor
            // 
            cmbSecondaryPlayerColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbSecondaryPlayerColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSecondaryPlayerColor.FormattingEnabled = true;
            cmbSecondaryPlayerColor.Location = new Point(152, 51);
            cmbSecondaryPlayerColor.Name = "cmbSecondaryPlayerColor";
            cmbSecondaryPlayerColor.Size = new Size(121, 23);
            cmbSecondaryPlayerColor.TabIndex = 2;
            // 
            // cmbPrimaryPlayerColor
            // 
            cmbPrimaryPlayerColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbPrimaryPlayerColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrimaryPlayerColor.FormattingEnabled = true;
            cmbPrimaryPlayerColor.Location = new Point(152, 22);
            cmbPrimaryPlayerColor.Name = "cmbPrimaryPlayerColor";
            cmbPrimaryPlayerColor.Size = new Size(121, 23);
            cmbPrimaryPlayerColor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Primary Player Color";
            // 
            // picEmblem
            // 
            picEmblem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picEmblem.Location = new Point(7, 22);
            picEmblem.Name = "picEmblem";
            picEmblem.Size = new Size(128, 128);
            picEmblem.TabIndex = 3;
            picEmblem.TabStop = false;
            // 
            // grpEmblem
            // 
            grpEmblem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpEmblem.Controls.Add(btnSave);
            grpEmblem.Controls.Add(picEmblem);
            grpEmblem.Location = new Point(348, 27);
            grpEmblem.Name = "grpEmblem";
            grpEmblem.Size = new Size(141, 228);
            grpEmblem.TabIndex = 4;
            grpEmblem.TabStop = false;
            grpEmblem.Text = "Emblem";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.Location = new Point(7, 156);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 63);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 280);
            Controls.Add(grpEmblem);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(mnuStrip);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = mnuStrip;
            Name = "MainForm";
            ShowIcon = false;
            Text = "Halo 2 Emblem Generator";
            Load += Form1_Load;
            mnuStrip.ResumeLayout(false);
            mnuStrip.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSecondaryEmblemColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPrimaryEmblemColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSecondaryPlayerColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPrimaryPlayerColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEmblem).EndInit();
            grpEmblem.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuStrip;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuAbout;
        private StatusStrip statusStrip1;
        private GroupBox groupBox1;
        private PictureBox picEmblem;
        private CheckBox chkDisablePrimaryEmblem;
        private ComboBox cmbEmblemBackground;
        private ComboBox cmbEmblemForeground;
        private ComboBox cmbSecondaryEmblemColor;
        private ComboBox cmbPrimaryEmblemColor;
        private ComboBox cmbSecondaryPlayerColor;
        private ComboBox cmbPrimaryPlayerColor;
        private Label label1;
        private Label label6;
        private Label label5;
        private PictureBox picSecondaryEmblemColor;
        private PictureBox picPrimaryEmblemColor;
        private PictureBox picSecondaryPlayerColor;
        private PictureBox picPrimaryPlayerColor;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox grpEmblem;
        private Button btnRandomize;
        private ToolStripMenuItem mnuExit;
        private Button btnSave;
    }
}
