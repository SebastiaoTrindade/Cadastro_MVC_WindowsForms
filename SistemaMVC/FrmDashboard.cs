using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using SistemaMVC.Controls;

namespace SistemaMVC
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
            UC_Dashboard dashboard = new UC_Dashboard();
            AdicionarFormControl(dashboard);
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        // Método para inserir data e hora
        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("dd-MM-yyyy");
            labelTime2.Text = DateTime.Now.ToString(" hh:mm:ss tt");
        }

        // Método para mover o Side do Botão
        private void MoverPanel(Guna2Button btn)
        {
            panelMovel.Top = btn.Top;
            panelMovel.Height = btn.Height;
        }

        // Método para inserir um formulário Control
        private void AdicionarFormControl(Control control)
        {
            control.Dock = DockStyle.Fill;
            panelConteudo.Controls.Clear();
            panelConteudo.Controls.Add(control);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MoverPanel(btnDashboard);
            UC_Dashboard dashboard = new UC_Dashboard();
            AdicionarFormControl(dashboard);
            
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            MoverPanel(btnUsuario);
            UC_Usuario usuario = new UC_Usuario();
            AdicionarFormControl(usuario);
        }        

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            MoverPanel(btnProduto);
            UC_Produto produto = new UC_Produto();
            AdicionarFormControl(produto);
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            MoverPanel(btnConfiguracao);
            UC_Ferramenta configuracao = new UC_Ferramenta();
            AdicionarFormControl(configuracao);

        }
    }
}
