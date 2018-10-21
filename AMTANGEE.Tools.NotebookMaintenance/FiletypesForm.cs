using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AMTANGEE.Tools.NotebookMaintenance
{
    public partial class FiletypesForm : Form
    {
        public FiletypesForm()
        {
            InitializeComponent();
        }

        private void btnCheckedAll_Click(object sender, EventArgs e)
        {
            var withBlock = clbFiletypes;
            for (int i = 0; i <= withBlock.Items.Count - 1; i++)
                withBlock.SetItemCheckState(i, CheckState.Checked);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            var withBlock = clbFiletypes;
            for (int i = 0; i <= withBlock.Items.Count - 1; i++)
            {
                if (withBlock.GetItemCheckState(i) == CheckState.Checked)
                    withBlock.SetItemCheckState(i, CheckState.Unchecked);
                else
                    withBlock.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void btnUncheckedAll_Click(object sender, EventArgs e)
        {
            var withBlock = clbFiletypes;
            for (int i = 0; i <= withBlock.Items.Count - 1; i++)
                withBlock.SetItemCheckState(i, CheckState.Unchecked);
        }
    }
}
