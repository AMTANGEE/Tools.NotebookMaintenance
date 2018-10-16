namespace AMTANGEE.Tools.NotebookMaintenance
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edtSQLDatabase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.chkUseIntegratedSecurity = new System.Windows.Forms.CheckBox();
            this.edtSQLPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edtSQLUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtSQLServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtSizeAttachments = new System.Windows.Forms.TextBox();
            this.chkAttachmentsSize = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateAttachments = new System.Windows.Forms.DateTimePicker();
            this.chkAttachmentsDate = new System.Windows.Forms.CheckBox();
            this.btnDoUpdate = new System.Windows.Forms.Button();
            this.btnPreviewSize = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbSavingDBSize = new System.Windows.Forms.Label();
            this.lbEstimatedDBSize = new System.Windows.Forms.Label();
            this.lbCurrentDBSize = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.edtSizeDocuments = new System.Windows.Forms.TextBox();
            this.chkDocumentsSize = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpDateDocuments = new System.Windows.Forms.DateTimePicker();
            this.chkDocumentsDate = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edtSQLDatabase);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.chkUseIntegratedSecurity);
            this.groupBox1.Controls.Add(this.edtSQLPassword);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.edtSQLUser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.edtSQLServer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datenbankverbindung";
            // 
            // edtSQLDatabase
            // 
            this.edtSQLDatabase.Location = new System.Drawing.Point(9, 102);
            this.edtSQLDatabase.Name = "edtSQLDatabase";
            this.edtSQLDatabase.Size = new System.Drawing.Size(120, 20);
            this.edtSQLDatabase.TabIndex = 9;
            this.edtSQLDatabase.Text = "AMTANGEE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Datenbank";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(336, 102);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Verbinden";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button3_Click);
            // 
            // chkUseIntegratedSecurity
            // 
            this.chkUseIntegratedSecurity.AutoSize = true;
            this.chkUseIntegratedSecurity.Location = new System.Drawing.Point(9, 60);
            this.chkUseIntegratedSecurity.Name = "chkUseIntegratedSecurity";
            this.chkUseIntegratedSecurity.Size = new System.Drawing.Size(182, 17);
            this.chkUseIntegratedSecurity.TabIndex = 6;
            this.chkUseIntegratedSecurity.Text = "Windows-Anmeldung verwenden";
            this.chkUseIntegratedSecurity.UseVisualStyleBackColor = true;
            this.chkUseIntegratedSecurity.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // edtSQLPassword
            // 
            this.edtSQLPassword.Location = new System.Drawing.Point(261, 33);
            this.edtSQLPassword.Name = "edtSQLPassword";
            this.edtSQLPassword.PasswordChar = '*';
            this.edtSQLPassword.Size = new System.Drawing.Size(120, 20);
            this.edtSQLPassword.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Passwort";
            // 
            // edtSQLUser
            // 
            this.edtSQLUser.Location = new System.Drawing.Point(135, 33);
            this.edtSQLUser.Name = "edtSQLUser";
            this.edtSQLUser.Size = new System.Drawing.Size(120, 20);
            this.edtSQLUser.TabIndex = 3;
            this.edtSQLUser.Text = "sa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Benutzer";
            // 
            // edtSQLServer
            // 
            this.edtSQLServer.Location = new System.Drawing.Point(9, 33);
            this.edtSQLServer.Name = "edtSQLServer";
            this.edtSQLServer.Size = new System.Drawing.Size(120, 20);
            this.edtSQLServer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "SQL-Server";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.edtSizeAttachments);
            this.groupBox2.Controls.Add(this.chkAttachmentsSize);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpDateAttachments);
            this.groupBox2.Controls.Add(this.chkAttachmentsDate);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(13, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dateianhänge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "KB zurücksetzen";
            // 
            // edtSizeAttachments
            // 
            this.edtSizeAttachments.Enabled = false;
            this.edtSizeAttachments.Location = new System.Drawing.Point(147, 56);
            this.edtSizeAttachments.Name = "edtSizeAttachments";
            this.edtSizeAttachments.Size = new System.Drawing.Size(70, 20);
            this.edtSizeAttachments.TabIndex = 4;
            this.edtSizeAttachments.Text = "1024";
            this.edtSizeAttachments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edtSizeAttachments.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.edtSizeAttachments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // chkAttachmentsSize
            // 
            this.chkAttachmentsSize.AutoSize = true;
            this.chkAttachmentsSize.Location = new System.Drawing.Point(6, 58);
            this.chkAttachmentsSize.Name = "chkAttachmentsSize";
            this.chkAttachmentsSize.Size = new System.Drawing.Size(145, 17);
            this.chkAttachmentsSize.TabIndex = 3;
            this.chkAttachmentsSize.Text = "Dateianhänge größer als ";
            this.chkAttachmentsSize.UseVisualStyleBackColor = true;
            this.chkAttachmentsSize.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "zurücksetzen";
            // 
            // dtpDateAttachments
            // 
            this.dtpDateAttachments.Enabled = false;
            this.dtpDateAttachments.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAttachments.Location = new System.Drawing.Point(198, 17);
            this.dtpDateAttachments.Name = "dtpDateAttachments";
            this.dtpDateAttachments.Size = new System.Drawing.Size(94, 20);
            this.dtpDateAttachments.TabIndex = 1;
            this.dtpDateAttachments.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // chkAttachmentsDate
            // 
            this.chkAttachmentsDate.AutoSize = true;
            this.chkAttachmentsDate.Location = new System.Drawing.Point(6, 19);
            this.chkAttachmentsDate.Name = "chkAttachmentsDate";
            this.chkAttachmentsDate.Size = new System.Drawing.Size(196, 17);
            this.chkAttachmentsDate.TabIndex = 0;
            this.chkAttachmentsDate.Text = "Dateianhänge von Nachrichten vor ";
            this.chkAttachmentsDate.UseVisualStyleBackColor = true;
            this.chkAttachmentsDate.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // btnDoUpdate
            // 
            this.btnDoUpdate.Enabled = false;
            this.btnDoUpdate.Location = new System.Drawing.Point(355, 532);
            this.btnDoUpdate.Name = "btnDoUpdate";
            this.btnDoUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnDoUpdate.TabIndex = 2;
            this.btnDoUpdate.Text = "Durchführen";
            this.btnDoUpdate.UseVisualStyleBackColor = true;
            this.btnDoUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPreviewSize
            // 
            this.btnPreviewSize.Enabled = false;
            this.btnPreviewSize.Location = new System.Drawing.Point(13, 532);
            this.btnPreviewSize.Name = "btnPreviewSize";
            this.btnPreviewSize.Size = new System.Drawing.Size(75, 23);
            this.btnPreviewSize.TabIndex = 3;
            this.btnPreviewSize.Text = "Vorschau";
            this.btnPreviewSize.UseVisualStyleBackColor = true;
            this.btnPreviewSize.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbSavingDBSize);
            this.groupBox3.Controls.Add(this.lbEstimatedDBSize);
            this.groupBox3.Controls.Add(this.lbCurrentDBSize);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(13, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informationen";
            // 
            // lbSavingDBSize
            // 
            this.lbSavingDBSize.Location = new System.Drawing.Point(158, 66);
            this.lbSavingDBSize.Name = "lbSavingDBSize";
            this.lbSavingDBSize.Size = new System.Drawing.Size(100, 14);
            this.lbSavingDBSize.TabIndex = 5;
            this.lbSavingDBSize.Text = "\"Vorschau\" klicken";
            this.lbSavingDBSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbEstimatedDBSize
            // 
            this.lbEstimatedDBSize.Location = new System.Drawing.Point(158, 43);
            this.lbEstimatedDBSize.Name = "lbEstimatedDBSize";
            this.lbEstimatedDBSize.Size = new System.Drawing.Size(100, 14);
            this.lbEstimatedDBSize.TabIndex = 4;
            this.lbEstimatedDBSize.Text = "\"Vorschau\" klicken";
            this.lbEstimatedDBSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbCurrentDBSize
            // 
            this.lbCurrentDBSize.Location = new System.Drawing.Point(158, 20);
            this.lbCurrentDBSize.Name = "lbCurrentDBSize";
            this.lbCurrentDBSize.Size = new System.Drawing.Size(100, 14);
            this.lbCurrentDBSize.TabIndex = 3;
            this.lbCurrentDBSize.Text = "unbekannt";
            this.lbCurrentDBSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(9, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ersparnis:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(9, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nach Durchführung:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Aktuelle Datenbankgröße:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 481);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(417, 15);
            this.progressBar1.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(13, 499);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(417, 23);
            this.label13.TabIndex = 6;
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.edtSizeDocuments);
            this.groupBox4.Controls.Add(this.chkDocumentsSize);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.dtpDateDocuments);
            this.groupBox4.Controls.Add(this.chkDocumentsDate);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(13, 256);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 100);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dokumente";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(223, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "KB zurücksetzen";
            // 
            // edtSizeDocuments
            // 
            this.edtSizeDocuments.Enabled = false;
            this.edtSizeDocuments.Location = new System.Drawing.Point(147, 56);
            this.edtSizeDocuments.Name = "edtSizeDocuments";
            this.edtSizeDocuments.Size = new System.Drawing.Size(70, 20);
            this.edtSizeDocuments.TabIndex = 4;
            this.edtSizeDocuments.Text = "1024";
            this.edtSizeDocuments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkDocumentsSize
            // 
            this.chkDocumentsSize.AutoSize = true;
            this.chkDocumentsSize.Location = new System.Drawing.Point(6, 58);
            this.chkDocumentsSize.Name = "chkDocumentsSize";
            this.chkDocumentsSize.Size = new System.Drawing.Size(133, 17);
            this.chkDocumentsSize.TabIndex = 3;
            this.chkDocumentsSize.Text = "Dokumente größer als ";
            this.chkDocumentsSize.UseVisualStyleBackColor = true;
            this.chkDocumentsSize.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(298, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "zurücksetzen";
            // 
            // dtpDateDocuments
            // 
            this.dtpDateDocuments.Enabled = false;
            this.dtpDateDocuments.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDocuments.Location = new System.Drawing.Point(198, 17);
            this.dtpDateDocuments.Name = "dtpDateDocuments";
            this.dtpDateDocuments.Size = new System.Drawing.Size(94, 20);
            this.dtpDateDocuments.TabIndex = 1;
            // 
            // chkDocumentsDate
            // 
            this.chkDocumentsDate.AutoSize = true;
            this.chkDocumentsDate.Location = new System.Drawing.Point(6, 19);
            this.chkDocumentsDate.Name = "chkDocumentsDate";
            this.chkDocumentsDate.Size = new System.Drawing.Size(99, 17);
            this.chkDocumentsDate.TabIndex = 0;
            this.chkDocumentsDate.Text = "Dokumente vor";
            this.chkDocumentsDate.UseVisualStyleBackColor = true;
            this.chkDocumentsDate.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 567);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnPreviewSize);
            this.Controls.Add(this.btnDoUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "AMTANGEE® Replikation Wartung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDoUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateAttachments;
        private System.Windows.Forms.CheckBox chkAttachmentsDate;
        private System.Windows.Forms.CheckBox chkAttachmentsSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtSizeAttachments;
        private System.Windows.Forms.Button btnPreviewSize;
        private System.Windows.Forms.TextBox edtSQLServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtSQLUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtSQLPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkUseIntegratedSecurity;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox edtSQLDatabase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSavingDBSize;
        private System.Windows.Forms.Label lbEstimatedDBSize;
        private System.Windows.Forms.Label lbCurrentDBSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox edtSizeDocuments;
        private System.Windows.Forms.CheckBox chkDocumentsSize;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpDateDocuments;
        private System.Windows.Forms.CheckBox chkDocumentsDate;
    }
}

