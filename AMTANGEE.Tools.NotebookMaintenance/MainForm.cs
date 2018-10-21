using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AMTANGEE.Tools.NotebookMaintenance
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void checkBoxes_CheckedChanged(object sender, EventArgs e)
        {
            if (sender as CheckBox == chkAttachmentsFiletypes)
            {
                if (chkAttachmentsFiletypes.Checked)
                {
                    btnAttachmentsFiletypes.Enabled = true;
                    btnAttachmentsFiletypes.PerformClick();
                }
                else
                    btnAttachmentsFiletypes.Enabled = false;
            }
            if (sender as CheckBox == chkDocumentsFiletypes)
            {
                if (chkDocumentsFiletypes.Checked)
                {
                    btnDocumentsFiletypes.Enabled = true;
                    btnDocumentsFiletypes.PerformClick();
                }
                else
                    btnDocumentsFiletypes.Enabled = false;
            }
            dtpDateAttachments.Enabled = chkAttachmentsDate.Checked;
            edtSizeAttachments.Enabled = chkAttachmentsSize.Checked;
            btnAttachmentsFiletypes.Enabled = chkAttachmentsFiletypes.Checked;
            dtpDateDocuments.Enabled = chkDocumentsDate.Checked;
            edtSizeDocuments.Enabled = chkDocumentsSize.Checked;
            btnDocumentsFiletypes.Enabled = chkDocumentsFiletypes.Checked;
            btnDoUpdate.Enabled = (chkAttachmentsDate.Checked || chkAttachmentsSize.Checked || chkAttachmentsFiletypes.Checked || chkDocumentsDate.Checked || chkDocumentsSize.Checked ||chkDocumentsFiletypes.Checked);
            btnPreviewSize.Enabled = btnDoUpdate.Enabled;
            lbEstimatedDBSize.Text = "\"Vorschau\" klicken";
            lbSavingDBSize.Text = "\"Vorschau\" klicken";
        }



       

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            edtSQLUser.Enabled = !chkUseIntegratedSecurity.Checked;
            edtSQLPassword.Enabled = !chkUseIntegratedSecurity.Checked;
        }

        MSSQL mssql = null;
        System.Data.SqlClient.SqlConnection con = null;
        private void button3_Click(object sender, EventArgs e)
        {
            mssql = new MSSQL();
            System.Data.SqlClient.SqlConnectionStringBuilder scb = new System.Data.SqlClient.SqlConnectionStringBuilder();

            scb.PersistSecurityInfo = false;
            scb.DataSource = edtSQLServer.Text;
            scb.UserID = edtSQLUser.Text;
            scb.Password = edtSQLPassword.Text;
            scb.InitialCatalog = edtSQLDatabase.Text;
            scb.IntegratedSecurity = chkUseIntegratedSecurity.Checked;
            scb.ApplicationName = "abc3b074-9d29-4ae9-97f9-763d8abf3c83";
            //dsfdsfdsf
            con = new System.Data.SqlClient.SqlConnection(scb.ConnectionString);

            try
            {
                con.Open();

                con.Close();

                if (!mssql.SQLExists("select * from replicationlocations where ISOWNLOCATION = 1 and IsMobile = 1",con))
                {
                    MessageBox.Show("Dieses Tool kann nur bei einer AMTANGEE® Mobile for Notebook oder AMTANGEE® Branch Office Datenbank verwendet werden!");
                    return;
                }


                //DataSet ds = mssql.SQLSelect(" EXEC sp_helpdb @dbname= '" + textBox5.Text + "'", con);
                //string sizeCurrent = "";
                //if (ds != null)
                //{
                //    foreach (DataRow row in ds.Tables[1].Rows)
                //    {
                //        if (row["filegroup"].ToString() == "PRIMARY")
                //        {
                //            sizeCurrent = row["size"].ToString();
                //            break;
                //        }
                //    }
                //}

                //if (sizeCurrent.Trim().Length > 0)
                //{
                //    sizeCurrent = sizeCurrent.ToUpper().Replace("KB", "").Replace("MB", "").Replace("GB", "");
                //    string[] sizes = { "Bytes", "KB", "MB" };
                //    double len = Convert.ToDouble(sizeCurrent) * 1024;
                //    sizeCurrentDouble = len;
                //    int order = 0;
                //    while (len >= 1024 && order + 1 < sizes.Length)
                //    {
                //        order++;
                //        len = len / 1024;
                //    }

                //    // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
                //    // show a single decimal place, and no space.
                //    string result = String.Format("{0:0. } {1}", len, sizes[order]);
                //    label10.Text = result;
                //}

                lbCurrentDBSize.Text = GetDbSize(edtSQLDatabase.Text);
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
                groupBox4.Enabled = true;
               
            }
            catch(Exception exc)
            {
                MessageBox.Show("Fehler beim Verbinden: \r\n\r\n" + exc.Message);
                return;
            }

        }

        double sizeCurrentDouble = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            btnDoUpdate.Enabled = false;
            btnPreviewSize.Enabled = false;
            groupBox2.Enabled = false;
            groupBox4.Enabled = false;
            string sql = "";
            double len = 0;
            double len2 = 0;
            string temp = "";
            if (chkAttachmentsDate.Checked || chkAttachmentsSize.Checked || chkAttachmentsFiletypes.Checked)
            {
                sql += "select isnull(sum(convert(bigint,isnull([size],0))),0) from MessagesAttachments (nolock) where Location <> dbo.OwnLocation() and [ATTACHMENT] is not null  and len(isnull(contentid,'')) = 0";

                if (chkAttachmentsSize.Checked)
                    sql += "and Isnull([Size],0) > " + Convert.ToInt32(edtSizeAttachments.Text) * 1024 + " ";

                if (chkAttachmentsDate.Checked)
                    sql += " and [Message] in (Select GUID from Messages (nolock) where Location <> dbo.OwnLocation() and [Datetime] < Convert(Datetime,'" + dtpDateAttachments.Value.Date.Day.ToString().PadLeft(2, '0') + "." + dtpDateAttachments.Value.Date.Month.ToString().PadLeft(2, '0') + "." + dtpDateAttachments.Value.Date.Year.ToString() + " 00:00:00',104)) ";

                if (chkAttachmentsFiletypes.Checked)
                {
                    string where = "";
                    foreach (string value in AttachmentsFiletypes)
                    {
                        if (where.Length == 0)
                            where = "Upper(FILENAME) like '%." + value + "'";
                        else
                            where += "OR Upper(FILENAME) like '%." + value + "'";
                    }
                    if (AttachmentsFiletypes.Count == 1)
                        where = " and " + where;
                    else
                        where = " and (" + where + ")";
                    sql += where;
                }

                temp = mssql.SQLExecuteScalar(sql, con);
                temp = temp.Replace(",", ".");
               
                try
                {
                    len = Convert.ToDouble(temp);
                    len2 = len;
                }
                catch
                {
                    MessageBox.Show("Fehler bei Konvertieren (1): " + temp);
                }
            }

            if (chkDocumentsSize.Checked || chkDocumentsDate.Checked || chkDocumentsFiletypes.Checked)
            {
                sql = "";
                sql += "select isnull(sum(convert(bigint,isnull([size],0))),0) from Documents (nolock) where Location <> dbo.OwnLocation() and [DOCUMENT] is not null";

                if (chkDocumentsSize.Checked)
                    sql += "and Isnull([Size],0) > " + Convert.ToInt32(edtSizeDocuments.Text) * 1024 + " ";

                if (chkDocumentsDate.Checked)
                    sql += "and [Datetime] < Convert(Datetime,'" + dtpDateDocuments.Value.Date.Day.ToString().PadLeft(2, '0') + "." + dtpDateDocuments.Value.Date.Month.ToString().PadLeft(2, '0') + "." + dtpDateDocuments.Value.Date.Year.ToString() + " 00:00:00',104) ";

                if (chkDocumentsFiletypes.Checked)
                {
                    string where = "";
                    foreach (string value in DocumentFiletypes)
                    {
                        if (where.Length == 0)
                            where = "Upper(Filetype) = '" + value + "'";
                        else
                            where += "OR Upper(Filetype) = '" + value + "'";
                    }
                    if (DocumentFiletypes.Count == 1)
                        where = " and " + where;
                    else
                        where = " and (" + where + ")";
                    sql += where;
                }
                temp = mssql.SQLExecuteScalar(sql, con);
                temp = temp.Replace(",", ".");

                try
                {
                    double len3 = Convert.ToDouble(temp);
                    len += len3;
                    len2 = len;
                }
                catch
                {
                    MessageBox.Show("Fehler bei Konvertieren (2): " + temp);
                }

            }


            string[] sizes = { "Bytes", "KB", "MB" };
          

           
            int order = 0;
            while (len >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                len = len / 1024;
            }

            // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            // show a single decimal place, and no space.
            string result = String.Format("{0:0.00} {1}", len, sizes[order]);
            lbSavingDBSize.Text = result;

            len = sizeCurrentDouble - len2;
            //sizeCurrentDouble = len;
             order = 0;
            while (len >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                len = len / 1024;
            }

            // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            // show a single decimal place, and no space.



            lbEstimatedDBSize.Text = String.Format("{0:0.00} {1}", len, sizes[order]);



            btnDoUpdate.Enabled = true;
            btnPreviewSize.Enabled = true;
            groupBox4.Enabled = true;
            groupBox2.Enabled = true;


        }


        string GetDbSize(string name)
        {
            string result = "";
            string sql = "";

            sql += "  SELECT ";

            sql += " CONVERT(DECIMAL(18,2), SUM(a.total_pages)*8/1024.0) AS [SpaceUsed] ";
            sql += " FROM sys.partitions p join sys.allocation_units a  ";
            sql += " on p.partition_id = a.container_id; ";

            string sizeCurrent = mssql.SQLExecuteScalar(sql, con);
            if (sizeCurrent.Trim().Length > 0)
            {
                sizeCurrent = sizeCurrent.ToUpper().Replace("KB", "").Replace("MB", "").Replace("GB", "");
                string[] sizes = { "Bytes", "KB", "MB" };
                double len = Convert.ToDouble(sizeCurrent) * 1024 * 1024;
                sizeCurrentDouble = len;
                int order = 0;
                while (len >= 1024 && order + 1 < sizes.Length)
                {
                    order++;
                    len = len / 1024;
                }

                // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
                // show a single decimal place, and no space.
                result = String.Format("{0:0.00} {1}", len, sizes[order]);
              
            }

            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btnDoUpdate.Enabled = false;
            btnPreviewSize.Enabled = false;
            groupBox2.Enabled = false;
            groupBox4.Enabled = false;
            bool resetAttachments = false;
            bool resetDocuments = false;
            string sql = "";

            if (chkAttachmentsDate.Checked || chkAttachmentsSize.Checked || chkAttachmentsFiletypes.Checked)
            {
                sql += "Select GUID from MessagesAttachments (nolock) where Location <> dbo.OwnLocation() and [ATTACHMENT] is not null  and len(isnull(contentid,'')) = 0";

                if (chkAttachmentsSize.Checked)
                    sql += " and Isnull([Size],0) > " + Convert.ToInt32(edtSizeAttachments.Text) * 1024 + " ";


                if (chkAttachmentsDate.Checked)
                    sql += " and  [Message] in (Select GUID from Messages (nolock) where [Datetime] < Convert(Datetime,'" + dtpDateAttachments.Value.Date.Day.ToString().PadLeft(2, '0') + "." + dtpDateAttachments.Value.Date.Month.ToString().PadLeft(2, '0') + "." + dtpDateAttachments.Value.Date.Year.ToString() + " 00:00:00',104)) ";

                if (chkAttachmentsFiletypes.Checked)
                {
                    string where = "";
                    foreach (string value in AttachmentsFiletypes)
                    {
                        if (where.Length == 0)
                            where = "Upper(FILENAME) like '%." + value + "'";
                        else
                            where += "OR Upper(FILENAME) like '%." + value + "'";
                    }
                    if (AttachmentsFiletypes.Count == 1)
                        where = " and " + where;
                    else
                        where = " and (" + where + ")";
                    sql += where;
                }

                DataSet ds = mssql.SQLSelect(sql, con);

                if (ds != null)
                {
                    progressBar1.Value = 0;
                    progressBar1.Maximum = ds.Tables[0].Rows.Count;

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        mssql.SQLExecute("Update MessagesAttachments set [ATTACHMENT] = null where GUID = '" + row[0].ToString() + "'", con);

                        progressBar1.Value++;
                        label13.Text = "Anhang " + progressBar1.Value.ToString() + " / " + progressBar1.Maximum;
                        Application.DoEvents();

                    }
                }

                resetAttachments = true;

            }
            progressBar1.Value = 0;
            label13.Text = "";
            
            Application.DoEvents();
            if (chkDocumentsDate.Checked || chkDocumentsSize.Checked || chkDocumentsFiletypes.Checked)
            {
                sql += "Select GUID from Documents (nolock) where Location <> dbo.OwnLocation() and [DOCUMENT] is not null";

                if (chkDocumentsSize.Checked)
                    sql += " and Isnull([Size],0) > " + Convert.ToInt32(edtSizeAttachments.Text) * 1024 + " ";

                if (chkDocumentsDate.Checked)
                    sql += " and  [Datetime] < Convert(Datetime,'" + dtpDateDocuments.Value.Date.Day.ToString().PadLeft(2, '0') + "." + dtpDateDocuments.Value.Date.Month.ToString().PadLeft(2, '0') + "." + dtpDateDocuments.Value.Date.Year.ToString() + " 00:00:00',104) ";

                if (chkDocumentsFiletypes.Checked)
                {
                    string where = "";
                    foreach (string value in DocumentFiletypes)
                    {
                        if (where.Length == 0)
                            where = "Upper(Filetype) = '" + value + "'";
                        else
                            where += "OR Upper(Filetype) = '" + value + "'";
                    }
                    if (DocumentFiletypes.Count == 1)
                        where = " and " + where;
                    else
                        where = " and (" + where + ")";
                    sql += where;
                }

                DataSet ds = mssql.SQLSelect(sql, con);

                if (ds != null)
                {
                    progressBar1.Value = 0;
                    progressBar1.Maximum = ds.Tables[0].Rows.Count;

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        mssql.SQLExecute("Update Documents set [DOCUMENT] = null where GUID = '" + row[0].ToString() + "'", con);

                        progressBar1.Value++;
                        label13.Text = "Dokument " + progressBar1.Value.ToString() + " / " + progressBar1.Maximum;
                        Application.DoEvents();

                    }
                }
                resetDocuments = true;
            }


            progressBar1.Value = 0;
            label13.Text = "";



            Application.DoEvents();
            if(resetAttachments && resetDocuments)
            {
                MessageBox.Show("Anhänge und Dokumente wurden zurückgesetzt!");
            }
            else
            {
                if(resetAttachments)
                    MessageBox.Show("Anhänge wurden zurückgesetzt!");
                else
                    MessageBox.Show("Dokumente wurden zurückgesetzt!");

            }
           




                lbEstimatedDBSize.Text = "\"Vorschau\" klicken";
                lbSavingDBSize.Text = "\"Vorschau\" klicken";



                groupBox2.Enabled = true;
            groupBox4.Enabled = true;
                btnDoUpdate.Enabled = true;
                btnPreviewSize.Enabled = true;
            
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lbEstimatedDBSize.Text = "\"Vorschau\" klicken";
            lbSavingDBSize.Text = "\"Vorschau\" klicken";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbEstimatedDBSize.Text = "\"Vorschau\" klicken";
            lbSavingDBSize.Text = "\"Vorschau\" klicken";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        List<string> AttachmentsFiletypes = new List<string>();
        List<string> DocumentFiletypes = new List<string>();
       
       
        private void btnAttachmentsFiletypes_Click(object sender, EventArgs e)
        {
            FiletypesForm NewFiletypesForm = new FiletypesForm();
            string sql = "select DISTINCT RIGHT(UPPER(FILENAME),PATINDEX('%.%', REVERSE(UPPER(FILENAME)))-1) from MessagesAttachments (nolock) where Location <> dbo.OwnLocation() and [ATTACHMENT] is not null and len(isnull(contentid,'')) = 0";
            {
                var withBlock = NewFiletypesForm.clbFiletypes;
                withBlock.Items.Clear();
                foreach (DataRow value in mssql.SQLSelect(sql, con).Tables[0].Rows)
                    withBlock.Items.Add(value.ItemArray[0]);
                foreach (string value in AttachmentsFiletypes)
                {
                    for (var i = 0; i <= withBlock.Items.Count - 1; i++)
                    {
                        if (withBlock.Items[i].Equals(value))
                            withBlock.SetItemChecked(i, true);
                    }
                }
                if (withBlock.Items.Count == 0)
                {
                    MessageBox.Show("Es wurden keine Dateiendung in der Datenbank gefunden.Die Option wird jetzt autoamtisch deaktivert.");
                    btnAttachmentsFiletypes.Enabled = false;
                    chkAttachmentsFiletypes.Checked = false;
                }
                else
                {
                    if (AttachmentsFiletypes.Count == 0)
                    {
                        for (int i = 0; i <= withBlock.Items.Count - 1; i++)
                            withBlock.SetItemCheckState(i, CheckState.Checked);
                    }
                    if (NewFiletypesForm.ShowDialog(this) == DialogResult.OK)
                    {
                        AttachmentsFiletypes.Clear();
                        foreach (string value in withBlock.CheckedItems)
                            AttachmentsFiletypes.Add(value);
                    }
                    if (AttachmentsFiletypes.Count == 0)
                    {
                        btnAttachmentsFiletypes.Enabled = false;
                        chkAttachmentsFiletypes.Checked = false;
                    }
                }
            }
        }

        private void btnDocumentsFiletypes_Click(object sender, EventArgs e)
        {
            FiletypesForm NewFiletypesForm = new FiletypesForm();
            string sql = "select DISTINCT(Filetype) from Documents (nolock) where Location <> dbo.OwnLocation() and [DOCUMENT] is not null";
            {
                var withBlock = NewFiletypesForm.clbFiletypes;
                withBlock.Items.Clear();
                foreach (DataRow value in mssql.SQLSelect(sql, con).Tables[0].Rows)
                    withBlock.Items.Add(value.ItemArray[0]);
                foreach (string value in DocumentFiletypes)
                {
                    for (var i = 0; i <= withBlock.Items.Count - 1; i++)
                    {
                        if (withBlock.Items[i].Equals(value))
                            withBlock.SetItemChecked(i, true);
                    }
                }
                if (withBlock.Items.Count == 0)
                {
                    MessageBox.Show("Es wurden keine Dateiendung in der Datenbank gefunden. Die Option wird jetzt autoamtisch deaktivert.");
                    btnDocumentsFiletypes.Enabled = false;
                    chkDocumentsFiletypes.Checked = false;
                }
                else

                if (DocumentFiletypes.Count == 0)
                {
                    for (int i = 0; i <= withBlock.Items.Count - 1; i++)
                        withBlock.SetItemCheckState(i, CheckState.Checked);
                }
                if (NewFiletypesForm.ShowDialog(this) == DialogResult.OK)
                {
                    DocumentFiletypes.Clear();
                    foreach (string value in withBlock.CheckedItems)
                        DocumentFiletypes.Add(value);
                    if (DocumentFiletypes.Count == 0)
                    {
                        btnDocumentsFiletypes.Enabled = false;
                        chkDocumentsFiletypes.Checked = false;
                    }
                }
            }
        }
    }
}
