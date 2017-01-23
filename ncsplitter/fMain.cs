using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ncsplitter
{
    public partial class fMain : Form
    {
        public List<string> col_nc_names;
        public List<string> col_nc_content;

        public fMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSelectPathSrc_Click(object sender, EventArgs e)
        {
            string file_types = string.Empty;
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Title = "Select source file";
            dlgOpen.Multiselect = false;

            file_types = "HAAS PGM files (*.pgm)|*.pgm|";
            file_types += "Fanuc Backup files (*.all)|*.all|";
            file_types += "Generic NC files (*.nc)|*.nc|";
            file_types += "All files (*.*)|*.*";
            dlgOpen.Filter = file_types;

            dlgOpen.DefaultExt = "*.*";

            dlgOpen.ShowDialog();

            if (File.Exists(dlgOpen.FileName))
            {
                textPathSrc.Text = dlgOpen.FileName;
            }
      
        }

        private void btnSelectPathDst_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlgDstFolder = new FolderBrowserDialog();
            dlgDstFolder.Description = "Select destination folder";
            dlgDstFolder.RootFolder = Environment.SpecialFolder.Desktop;

            dlgDstFolder.ShowDialog();

            if (Directory.Exists(dlgDstFolder.SelectedPath))
            {
                textPathDst.Text = dlgDstFolder.SelectedPath;
            }
        }

        private void textPathSrc_Click(object sender, EventArgs e)
        {
            btnSelectPathSrc.Focus();
        }

        private void textPathDst_Click(object sender, EventArgs e)
        {
            btnSelectPathDst.Focus();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            // Check empty fields
            if (textPathSrc.Text.Length == 0 || textPathDst.Text.Length == 0)
            {
                MessageBox.Show("You should select source file or/and destination folder!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Check source file exists
            if (!File.Exists(textPathSrc.Text))
            {
                MessageBox.Show(String.Format("Can't open file {0}", Path.GetFileName(textPathSrc.Text)), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddLog("ERR: Can't open source file!");
                return;
            }

            // Check destination folder exists
            if (!Directory.Exists(textPathDst.Text))
            {
                MessageBox.Show(String.Format("Can't open folder {0}", Path.GetDirectoryName(textPathDst.Text)), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddLog("ERR: Can't open destination folder!");
                return;
            }

            // Clear log
            textLog.Clear();

            // Lock button
            btnSplit.Enabled = false;

            // Init. Collections
            col_nc_names = new List<string>();
            col_nc_content = new List<string>();

            AddLog(String.Format("Opening file: {0}", Path.GetFileName(textPathSrc.Text)));

            using (StreamReader sr = new StreamReader(textPathSrc.Text, Encoding.ASCII))
            {
                string line = String.Empty;
                string buf = String.Empty;
                string nc_name = String.Empty;
                bool is_first_element = true;
                long line_pos = 0;

                AddLog("Scanning for NC headers ...");

                while ((line = sr.ReadLine()) != null)
                {
                    Application.DoEvents();

                    if (line.ToUpper().StartsWith("O"))
                    {
                        AddLog(String.Format("Found header at line #{0}", line_pos.ToString()));

                        if (!is_first_element)
                        {
                            // Add data and clear buffer
                            //MessageBox.Show(buf, nc_name);
                            col_nc_names.Add(nc_name);
                            col_nc_content.Add(buf);

                            buf = String.Empty;
                        }

                        is_first_element = false;

                        // Extract nc-program name
                        nc_name = GetName(line);
                    }

                    buf += line + "\r\n";
                    line_pos++;
                }

                col_nc_names.Add(nc_name);
                col_nc_content.Add(buf);
            }

            if (col_nc_names.Count != 0 && col_nc_content.Count != 0)
            {

                AddLog(String.Format("Total found: {0} header(s)", col_nc_names.Count.ToString()));

                fSelect frmSelect = new fSelect(this,
                    col_nc_names, col_nc_content);
                frmSelect.ShowDialog();
                Application.DoEvents();
            }
            else
            {
                MessageBox.Show("The file is empty or corrupted!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddLog("ERR: The file is empty or corrupted!");
                return;
            }

            btnSplit.Enabled = true;
        }

        private string GetName(string nc_line)
        {
            string buf_name = "O";

            for (int i=1; i<=(nc_line.Length-1); i++)
            {
                if (IsNumeric(nc_line[i]))
                {
                    buf_name += nc_line[i];
                }
                else
                {
                    break;
                }
            }

            return buf_name;
        }

        private bool IsNumeric(char letter)
        {
            int n = 0;
            bool is_num = int.TryParse(letter.ToString(), out n);
            return is_num;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            // Debug
            //textPathSrc.Text = @"C:\Users\Edge\Desktop\test.pgm";
            //textPathDst.Text = @"C:\Users\Edge\Desktop\folder";

            fAbout frmAbout = new fAbout();
            this.Text = String.Format("ncsplitter {0}", frmAbout.GetAppVersion());
        }

        public void AddLog(string data)
        {
            //string time_stamp = DateTime.Now.ToString("hh:mm:ss");
            textLog.Text += String.Format("{0}\r\n", data);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            fAbout frmAboutWnd = new fAbout();
            frmAboutWnd.ShowDialog();
        }

        private void textLog_TextChanged(object sender, EventArgs e)
        {
            textLog.SelectionStart = textLog.TextLength;
            textLog.ScrollToCaret();
        }

        private void textPathSrc_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects effects = DragDropEffects.None;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files_drag = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                effects = File.Exists(files_drag[0]) ? DragDropEffects.Link : DragDropEffects.None;
            }

            e.Effect = effects;
        }

        private void textPathSrc_DragDrop(object sender, DragEventArgs e)
        {
            string[] files_drag = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            textPathSrc.Text = files_drag[0];
        }

        private void textPathDst_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects effects = DragDropEffects.None;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] file_path = (string[])e.Data.GetData(DataFormats.FileDrop);
                effects = Directory.Exists(file_path[0]) ?
                    DragDropEffects.Link : DragDropEffects.None;
            }

            e.Effect = effects;
        }

        private void textPathDst_DragDrop(object sender, DragEventArgs e)
        {
            string[] files_drag = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            textPathDst.Text = files_drag[0];
        }

        
    }
}
