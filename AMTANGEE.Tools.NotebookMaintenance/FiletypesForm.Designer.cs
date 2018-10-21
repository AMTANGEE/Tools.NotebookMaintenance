namespace AMTANGEE.Tools.NotebookMaintenance
{
    partial class FiletypesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.clbFiletypes = new System.Windows.Forms.CheckedListBox();
            this.btnCheckedAll = new System.Windows.Forms.Button();
            this.btnUncheckedAll = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(145, 415);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(105, 23);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Übernehmen";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(145, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // clbFiletypes
            // 
            this.clbFiletypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbFiletypes.CheckOnClick = true;
            this.clbFiletypes.FormattingEnabled = true;
            this.clbFiletypes.Location = new System.Drawing.Point(12, 12);
            this.clbFiletypes.Name = "clbFiletypes";
            this.clbFiletypes.Size = new System.Drawing.Size(127, 424);
            this.clbFiletypes.Sorted = true;
            this.clbFiletypes.TabIndex = 2;
            // 
            // btnCheckedAll
            // 
            this.btnCheckedAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckedAll.Location = new System.Drawing.Point(145, 12);
            this.btnCheckedAll.Name = "btnCheckedAll";
            this.btnCheckedAll.Size = new System.Drawing.Size(105, 23);
            this.btnCheckedAll.TabIndex = 2;
            this.btnCheckedAll.Text = "Alles auswählen";
            this.btnCheckedAll.UseVisualStyleBackColor = true;
            this.btnCheckedAll.Click += new System.EventHandler(this.btnCheckedAll_Click);
            // 
            // btnUncheckedAll
            // 
            this.btnUncheckedAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUncheckedAll.Location = new System.Drawing.Point(145, 70);
            this.btnUncheckedAll.Name = "btnUncheckedAll";
            this.btnUncheckedAll.Size = new System.Drawing.Size(105, 23);
            this.btnUncheckedAll.TabIndex = 3;
            this.btnUncheckedAll.Text = "Nichts auswählen";
            this.btnUncheckedAll.UseVisualStyleBackColor = true;
            this.btnUncheckedAll.Click += new System.EventHandler(this.btnUncheckedAll_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReverse.Location = new System.Drawing.Point(145, 41);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(105, 23);
            this.btnReverse.TabIndex = 4;
            this.btnReverse.Text = "Auswahl umkehren";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // FiletypesForm
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(262, 450);
            this.Controls.Add(this.clbFiletypes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCheckedAll);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnUncheckedAll);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FiletypesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FiletypesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCheckedAll;
        private System.Windows.Forms.Button btnUncheckedAll;
        private System.Windows.Forms.Button btnReverse;
        internal System.Windows.Forms.CheckedListBox clbFiletypes;
    }
}