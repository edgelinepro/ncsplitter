using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ncsplitter
{
    public partial class fSelect : Form
    {
        private fMain fMainInstance;
        private List<string> nc_names;
        private List<string> nc_content;

        public fSelect(fMain handle, List<string> cl_nc_names, 
            List<string> cl_nc_content)
        {
            fMainInstance = handle;
            InitializeComponent();
            nc_names = cl_nc_names;
            nc_content = cl_nc_content;

            btnOK.Select();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fSelect_Load(object sender, EventArgs e)
        {
            int i = 0;

            foreach (string line in nc_names)
            {
                ListViewItem lstItem = new ListViewItem("");
                lstItem.Checked = true;
                lstItem.SubItems.Add(line);

                StringReader sReader = new StringReader(nc_content[i]);

                string sline = String.Empty;
                string nc_comment = String.Empty;

                while ((sline = sReader.ReadLine()) != null)
                {
                    if (sline.IndexOf('(') != -1 && sline.IndexOf(')') != -1 &&
                        GetProgramName(sline) != "-1")
                    {
                        nc_comment = GetProgramName(sline);
                        break;
                    }
                }

                if (nc_comment == "-1" || nc_comment == String.Empty)
                    nc_comment = "(n/a)";

                lstItem.SubItems.Add(nc_comment);
                listContent.Items.Add(lstItem);

                i++;
            }
        }

        private string GetProgramName(string nc_line)
        {
            string prog_name = string.Empty;

            try
            {
                int idx_start = nc_line.IndexOf('(');
                int idx_end = nc_line.IndexOf(')');

                if (idx_start == -1 || idx_end == -1 ||
                    idx_end == (idx_start + 1) || idx_end < idx_start)
                    return "-1";

                prog_name = nc_line.Substring(idx_start+1, idx_end - idx_start-1);
                prog_name.ToUpper();
            }
            catch
            {
                prog_name = "-1";
            }

            return prog_name;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            ChangeItemsState(true);
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            ChangeItemsState(false);
        }

        private void ChangeItemsState(bool is_checked)
        {
            if (listContent.Items.Count != 0)
            {
                foreach (ListViewItem lstCurrent in listContent.Items)
                    lstCurrent.Checked = is_checked;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Check for selected items
            bool itm_selected = false;
            foreach (ListViewItem lstCurrent in listContent.Items)
            {
                if (lstCurrent.Checked)
                {
                    itm_selected = true;
                    break;
                }
            }

            if (!itm_selected)
            {
                MessageBox.Show("Nothing is selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.Hide();

            try
            {
                int nc_extracted_count = 0;

                foreach (ListViewItem lstCurrent in listContent.Items)
                {
                    if (lstCurrent.Checked)
                    {
                        foreach (string nc_element in nc_names)
                        {
                            Application.DoEvents();

                            if (nc_element == lstCurrent.SubItems[1].Text)
                            {
                                // Retrieve nc-code
                                int e_index = lstCurrent.Index;
                                string nc_code = nc_content[e_index];
                                string filepath = fMainInstance.textPathDst.Text;

                                filepath = filepath.EndsWith(@"\") ? 
                                    filepath + nc_element : String.Format(@"{0}\{1}", filepath, nc_element);

                                // Create file
                                fMainInstance.AddLog(String.Format("Creating file {0}", nc_element));

                                using (StreamWriter sw = new StreamWriter(filepath, false))
                                {
                                    StringReader srt = new StringReader(nc_code);
                                    string srt_line = String.Empty;

                                    // Write start marker [20.10.16]
                                    sw.WriteLine("%");

                                    while ((srt_line = srt.ReadLine()) != null)
                                        if (srt_line != "%")
                                            sw.WriteLine(srt_line);

                                    // Write end marker [20.10.16]
                                    sw.WriteLine("%");
                                }

                                nc_extracted_count++;
                            }
                        }
                    }
                }

                fMainInstance.AddLog("-------------");
                fMainInstance.AddLog("");
                fMainInstance.AddLog(String.Format("Extracted: {0} file(s)", nc_extracted_count.ToString()));
                fMainInstance.AddLog("Complete.");

                this.Close();
            }
            catch (Exception gen_e)
            {
                fMainInstance.AddLog(String.Format("ERR: Exception - {0}", gen_e.Message));
                this.Show();
                return;
            }
        }
    }
}
