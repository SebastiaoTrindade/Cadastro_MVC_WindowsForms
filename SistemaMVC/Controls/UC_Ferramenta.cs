using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMVC.Controls
{
    public partial class UC_Ferramenta : UserControl
    {
        public UC_Ferramenta()
        {
            InitializeComponent();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }
    }
}
