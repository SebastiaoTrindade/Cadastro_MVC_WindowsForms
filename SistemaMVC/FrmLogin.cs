using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Entidades;
using Sistema.Model;

namespace SistemaMVC
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void LimparCampos()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Preencha o campo Usuário");
                    txtUsuario.Focus();
                    return;
                }

                if (txtSenha.Text == "") 
                {
                    MessageBox.Show("Preencha o campo Senha");
                    txtSenha.Focus();
                    return;
                }
                UsuarioEnt obj = new UsuarioEnt();
                obj.Usuario = txtUsuario.Text;
                obj.Senha = txtSenha.Text;

                obj = new UsuarioModel().Login(obj);

                if (obj.Usuario == null)
                {
                    lblMensagem.Text = "Usuário ou senha não encontrado!";
                    lblMensagem.ForeColor = Color.Red;
                    LimparCampos();
                    txtUsuario.Focus();
                    return;
                   
                }

                FrmDashboard form = new FrmDashboard();
                //this.Hide();
                form.ShowDialog();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dados incorretos" + ex.Message);                
            }

            
        }
    }
}
