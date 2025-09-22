using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Note
{
    partial class Form1
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
            
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            Name_label = new Label();
            HideButn = new Button();
            ScreenButn = new Button();
            CLOSE_butn = new Button();
            mainTextBox = new TextBox();
            fileMenuStrip = new MenuStrip();
            fToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            goAwayexeToolStripMenuItem = new ToolStripMenuItem();
            sToolStripMenuItem = new ToolStripMenuItem();
            visualToolStripMenuItem = new ToolStripMenuItem();
            xnjToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            fileMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.BackgroundImage = Properties.Resources.topbar1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Name_label);
            panel1.Controls.Add(HideButn);
            panel1.Controls.Add(ScreenButn);
            panel1.Controls.Add(CLOSE_butn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 32);
            panel1.TabIndex = 0;
            panel1.MouseDown += panelTop_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 28);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.BackColor = Color.Transparent;
            Name_label.ForeColor = Color.Snow;
            Name_label.Location = new Point(30, 9);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(65, 15);
            Name_label.TabIndex = 5;
            Name_label.Text = "note = null";
            // 
            // HideButn
            // 
            HideButn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HideButn.BackColor = SystemColors.ButtonHighlight;
            HideButn.Location = new Point(710, 1);
            HideButn.Name = "HideButn";
            HideButn.Padding = new Padding(0, 0, 0, 8);
            HideButn.Size = new Size(37, 30);
            HideButn.TabIndex = 4;
            HideButn.Text = "_";
            HideButn.UseVisualStyleBackColor = false;
            HideButn.Click += HideButn_Click;
            // 
            // ScreenButn
            // 
            ScreenButn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ScreenButn.Location = new Point(753, 1);
            ScreenButn.Name = "ScreenButn";
            ScreenButn.Size = new Size(37, 30);
            ScreenButn.TabIndex = 3;
            ScreenButn.Text = "[ ]";
            ScreenButn.UseVisualStyleBackColor = true;
            ScreenButn.Click += ScreenButn_Click;
            // 
            // CLOSE_butn
            // 
            CLOSE_butn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CLOSE_butn.Location = new Point(796, 1);
            CLOSE_butn.Name = "CLOSE_butn";
            CLOSE_butn.Size = new Size(37, 30);
            CLOSE_butn.TabIndex = 2;
            CLOSE_butn.Text = "X";
            CLOSE_butn.UseVisualStyleBackColor = true;
            CLOSE_butn.Click += CLOSE_butn_Click;
            // 
            // mainTextBox
            // 
            mainTextBox.AccessibleName = "";
            mainTextBox.BackColor = Color.Gainsboro;
            mainTextBox.BorderStyle = BorderStyle.FixedSingle;
            mainTextBox.Dock = DockStyle.Fill;
            mainTextBox.Location = new Point(0, 55);
            mainTextBox.Multiline = true;
            mainTextBox.Name = "mainTextBox";
            mainTextBox.PlaceholderText = "Print here...";
            mainTextBox.ScrollBars = ScrollBars.Both;
            mainTextBox.Size = new Size(838, 401);
            mainTextBox.TabIndex = 0;
            mainTextBox.TextChanged += mainTextBox_TextChanged;
            mainTextBox.MouseWheel += zoomin;
            // 
            // fileMenuStrip
            // 
            fileMenuStrip.BackColor = Color.DarkGray;
            fileMenuStrip.BackgroundImage = Properties.Resources.lowerbar;
            fileMenuStrip.BackgroundImageLayout = ImageLayout.Stretch;
            fileMenuStrip.Items.AddRange(new ToolStripItem[] { fToolStripMenuItem, sToolStripMenuItem });
            fileMenuStrip.LayoutStyle = ToolStripLayoutStyle.Flow;
            fileMenuStrip.Location = new Point(0, 32);
            fileMenuStrip.Name = "fileMenuStrip";
            fileMenuStrip.Size = new Size(838, 23);
            fileMenuStrip.TabIndex = 1;
            fileMenuStrip.Text = "fileMenuStrip";
            // 
            // fToolStripMenuItem
            // 
            fToolStripMenuItem.BackColor = Color.Transparent;
            fToolStripMenuItem.BackgroundImage = Properties.Resources.сonfig;
            fToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            fToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, goAwayexeToolStripMenuItem });
            fToolStripMenuItem.ImageTransparentColor = Color.Black;
            fToolStripMenuItem.Name = "fToolStripMenuItem";
            fToolStripMenuItem.Size = new Size(28, 19);
            fToolStripMenuItem.Text = ".F";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.BackColor = Color.Transparent;
            newToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(138, 22);
            newToolStripMenuItem.Text = "#New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.BackColor = Color.Transparent;
            openToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(138, 22);
            openToolStripMenuItem.Text = "#Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.BackColor = Color.Transparent;
            saveToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(138, 22);
            saveToolStripMenuItem.Text = "#Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.BackColor = Color.Transparent;
            saveAsToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(138, 22);
            saveAsToolStripMenuItem.Text = "#Save_as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // goAwayexeToolStripMenuItem
            // 
            goAwayexeToolStripMenuItem.BackColor = Color.Transparent;
            goAwayexeToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            goAwayexeToolStripMenuItem.Name = "goAwayexeToolStripMenuItem";
            goAwayexeToolStripMenuItem.Size = new Size(138, 22);
            goAwayexeToolStripMenuItem.Text = "go away.exe";
            goAwayexeToolStripMenuItem.Click += goAwayexeToolStripMenuItem_Click;
            // 
            // sToolStripMenuItem
            // 
            sToolStripMenuItem.BackColor = Color.Transparent;
            sToolStripMenuItem.BackgroundImage = Properties.Resources.сonfig;
            sToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            sToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visualToolStripMenuItem, xnjToolStripMenuItem });
            sToolStripMenuItem.Name = "sToolStripMenuItem";
            sToolStripMenuItem.Size = new Size(28, 19);
            sToolStripMenuItem.Text = ".S";
            // 
            // visualToolStripMenuItem
            // 
            visualToolStripMenuItem.Name = "visualToolStripMenuItem";
            visualToolStripMenuItem.Size = new Size(105, 22);
            visualToolStripMenuItem.Text = "#Font";
            visualToolStripMenuItem.Click += visualToolStripMenuItem_Click;
            // 
            // xnjToolStripMenuItem
            // 
            xnjToolStripMenuItem.Name = "xnjToolStripMenuItem";
            xnjToolStripMenuItem.Size = new Size(105, 22);
            xnjToolStripMenuItem.Text = "?xnj";
            xnjToolStripMenuItem.Click += xnjToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|JSON files (*.json)|*.json|File files (*.file)|*.file|All files (*.*)|*.*\"";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|JSON files (*.json)|*.json|File files (*.file)|*.file|All files (*.*)|*.*\"";
            // 
            // fontDialog1
            // 
            fontDialog1.ShowApply = true;
            fontDialog1.Apply += fontDialog1_Apply;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 456);
            Controls.Add(mainTextBox);
            Controls.Add(fileMenuStrip);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = fileMenuStrip;
            Name = "Form1";
            Text = "note = null";
            FormClosing += ClosingNote;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            fileMenuStrip.ResumeLayout(false);
            fileMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox mainTextBox;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem goAwayexeToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem visualToolStripMenuItem;
        private FontDialog fontDialog1;


#nullable enable
        public class MenuStripRenderer : ToolStripProfessionalRenderer
        {
            private readonly Image? _dropDownImage;
            private readonly Color? _dropDownColor;

            private readonly Image? _selectionImage;
            private readonly Color? _selectionColor;

            // Constructor for colors
            public MenuStripRenderer(Color? dropDownColor, Color? selectionColor)
                : base(new ProfessionalColorTable())
            {
                _dropDownColor = dropDownColor;
                _selectionColor = selectionColor;
            }

            // Constructor for images
            public MenuStripRenderer(Image? dropDownImage, Image? selectionImage)
                : base(new ProfessionalColorTable())
            {
                _dropDownImage = dropDownImage;
                _selectionImage = selectionImage;
            }

            protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
            {
                if (e.ToolStrip is ToolStripDropDownMenu)
                {
                    PaintDropDownBackground(e.Graphics, e.AffectedBounds);
                }
                else
                {
                    base.OnRenderToolStripBackground(e);
                }
            }

            protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
            {
                // Force the margin to use the same background as the dropdown
                PaintDropDownBackground(e.Graphics, e.AffectedBounds);
            }

            private void PaintDropDownBackground(Graphics g, Rectangle bounds)
            {
                if (_dropDownImage != null)
                {
                    g.DrawImage(_dropDownImage, bounds);
                }
                else if (_dropDownColor.HasValue)
                {
                    using (var brush = new SolidBrush(_dropDownColor.Value))
                        g.FillRectangle(brush, bounds);
                }
            }

            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                if (e.Item.Selected)
                {
                    if (_selectionImage != null)
                    {
                        e.Graphics.DrawImage(_selectionImage, e.Item.ContentRectangle);
                    }
                    else if (_selectionColor.HasValue)
                    {
                        using (var brush = new SolidBrush(_selectionColor.Value))
                            e.Graphics.FillRectangle(brush, e.Item.ContentRectangle);
                    }
                    else
                    {
                        base.OnRenderMenuItemBackground(e);
                    }
                }
                else
                {
                    base.OnRenderMenuItemBackground(e);
                }
            }
        }
        private Button HideButn = new Button();
        private Button ScreenButn = new Button();
        private Button CLOSE_butn = new Button();
        private Label Name_label = new Label();
        private PictureBox pictureBox1 = new PictureBox();
        private Panel panel1 = new Panel();
        private MenuStrip fileMenuStrip = new MenuStrip();
        private ToolStripMenuItem fToolStripMenuItem = new ToolStripMenuItem();
        private ToolStripMenuItem sToolStripMenuItem = new ToolStripMenuItem();
        private ToolStripMenuItem xnjToolStripMenuItem = new ToolStripMenuItem();
    }
}
