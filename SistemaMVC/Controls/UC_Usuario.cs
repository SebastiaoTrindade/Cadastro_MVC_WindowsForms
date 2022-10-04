using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Entidades;
using Sistema.Model;

namespace SistemaMVC.Controls
{
    public partial class UC_Usuario : UserControl
    {
        UsuarioEnt objTabela = new UsuarioEnt();


        public UC_Usuario()
        {
            InitializeComponent();
        }

        public void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
        }

        public void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
        }

        public void LimparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        private string opc = "";
        private void iniciarOpc()
        {
            switch (opc)
            {
                case "Novo":
                    HabilitarCampos();
                    LimparCampos();
                    break;

                case "Salvar":
                    try
                    {
                        objTabela.Nome = txtNome.Text;
                        objTabela.Usuario = txtUsuario.Text;
                        objTabela.Senha = txtSenha.Text;

                        int x = UsuarioModel.Inserir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Usuário {0} foi cadastrado com sucesso!", txtNome.Text));
                        }
                        else 
                        {
                            MessageBox.Show("Registro não inserido!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao inserir dados!" + ex.Message);
                        
                    }
                    break;

                case "Editar":
                    try
                    {
                        objTabela.Id = Convert.ToInt32(txtCodigo.Text);
                        objTabela.Nome = txtNome.Text;
                        objTabela.Usuario = txtUsuario.Text;
                        objTabela.Senha = txtSenha.Text;

                        int x = UsuarioModel.Editar(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Usuário {0} foi editado com sucesso!", txtNome.Text));
                        }
                        else
                        {
                            MessageBox.Show("Registro não foi editado!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao editar dados!" + ex.Message);

                    }
                    break;

                case "Excluir":
                    try
                    {
                        objTabela.Id = Convert.ToInt32(txtCodigo.Text);
                        
                        int x = UsuarioModel.Excluir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Usuário {0} foi excluído com sucesso!", txtNome.Text));
                        }
                        else
                        {
                            MessageBox.Show("Registro não excluido!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir usuário!" + ex.Message);

                    }
                    break;

                case "Pesquisar":
                    try
                    {
                        objTabela.Nome = txtPesquisar.Text;
                        List<UsuarioEnt> lista = new List<UsuarioEnt>();
                        lista = new UsuarioModel().Pesquisar(objTabela);
                        dataGridViewUsuario.AutoGenerateColumns = false;
                        dataGridViewUsuario.DataSource = lista;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao apresentar os dados!" + ex.Message);
                    }
                    break;


                default:
                    break;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            opc = "Novo";
            iniciarOpc();            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            opc = "Salvar";
            iniciarOpc();
            ListarGrid();
            LimparCampos();
            DesabilitarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione um registro na Grid para editar");
                return;
            }
            opc = "Editar";
            iniciarOpc();
            ListarGrid();
            LimparCampos();
            DesabilitarCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione um registro na Grid para excluir");
                return;
            }
            opc = "Excluir";
            iniciarOpc();
            ListarGrid();
            LimparCampos();
            DesabilitarCampos();
        }

        private void ListarGrid()
        {
            try
            {
                List<UsuarioEnt> lista = new List<UsuarioEnt>();
                lista = new UsuarioModel().Lista();
                dataGridViewUsuario.AutoGenerateColumns = false;
                dataGridViewUsuario.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apresentar os dados!" + ex.Message);                
            }
        }

        private void UC_Usuario_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }

        private void dataGridViewUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dataGridViewUsuario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataGridViewUsuario.CurrentRow.Cells[1].Value.ToString();
            txtUsuario.Text = dataGridViewUsuario.CurrentRow.Cells[2].Value.ToString();
            txtSenha.Text = dataGridViewUsuario.CurrentRow.Cells[3].Value.ToString();
            HabilitarCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            opc = "Pesquisar";
            iniciarOpc();         
            
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == "")
            {
                ListarGrid();
                return;
            }

            opc = "Pesquisar";
            iniciarOpc();
        }
                
    }
}
