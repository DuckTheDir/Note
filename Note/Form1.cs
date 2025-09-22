namespace Note

{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        private string? cur_file_path = null;
        private bool mod = false;


        public Form1(string?filePath)
        {


            InitializeComponent();

            if (!string.IsNullOrEmpty(filePath) && System.IO.File.Exists(filePath))
            {
                try
                {
                    mainTextBox.Text = System.IO.File.ReadAllText(filePath);
                    cur_file_path = filePath;
                    this.Text = "note = " + '"' + Path.GetFileName(filePath) + '"';
                    Name_label.Text = this.Text;
                    mod = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("err: " + ex.Message);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!askForSomething()) return;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string contento_no = System.IO.File.ReadAllText(path, Encoding.UTF8);
                mainTextBox.Text = contento_no;
                cur_file_path = path;
                mod = false;
                this.Text = "note = " + '"' + Path.GetFileName(path) + '"';
                Name_label.Text = this.Text;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cur_file_path))
                save_as();
            else
                saveTo_filelele(cur_file_path);

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_as();
        }

        private void goAwayexeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!askForSomething()) return;
            mainTextBox.Clear();
            cur_file_path = null;
            mod = false;
            this.Text = "note = _?";
            Name_label.Text = this.Text;
        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            mod = true;
            this.Text = (cur_file_path == null ? "note = _?" : Path.GetFileName(cur_file_path)) + (mod ? " @" : "");
            Name_label.Text = this.Text;
        }


        // custom made functuiodfn ksadnmfksdnkfsdmkfl wow


        private void saveTo_filelele(string path)
        {
            System.IO.File.WriteAllText(path, mainTextBox.Text, Encoding.UTF8);
            cur_file_path = path;
            mod = false;
            this.Text = Path.GetFileName(path);
            Name_label.Text = this.Text;
        }

        private void save_as()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveTo_filelele(saveFileDialog1.FileName);
            }

        }


        private bool askForSomething()
        {
            if (!mod) return true;
            var dialog_w_u = MessageBox.Show("save_?", "save_txt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog_w_u == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(cur_file_path))
                    save_as();
                else
                    saveTo_filelele(cur_file_path);

                return !mod;
            }
            else if (dialog_w_u == DialogResult.No)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void ClosingNote(object sender, FormClosingEventArgs e)
        {
            if (!askForSomething())
            {
                e.Cancel = true;
            }
        }

  
        private void visualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }


        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void CLOSE_butn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HideButn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ScreenButn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            mainTextBox.Font = fontDialog1.Font;
        }

        private void zoomin(object? sender, MouseEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                float newSize = mainTextBox.Font.Size;

                if (e.Delta > 0)
                    newSize += 1;
                else if (e.Delta < 0)
                    newSize -= 1;

               
                newSize = Math.Max(6, Math.Min(72, newSize));

                mainTextBox.Font = new Font(mainTextBox.Font.FontFamily, newSize, mainTextBox.Font.Style);

               
                ((HandledMouseEventArgs)e).Handled = true;
            }
        }

        private void xnjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/K curl ascii.live/rick");

        }

    }
}

