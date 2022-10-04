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
    public partial class UC_Produto : UserControl
    {
        ProdutoEnt objTabela = new ProdutoEnt();

        public UC_Produto()
        {
            InitializeComponent();
        }

        private void UC_Produto_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }

        public void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
        }

        public void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
        }

        public void LimparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtValor.Text = "";
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
                        objTabela.Descricao = txtDescricao.Text;
                        objTabela.Valor = Convert.ToDecimal(txtValor.Text);

                        int x = ProdutoModel.Inserir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Produto {0} foi cadastrado com sucesso!", txtNome.Text));
                        }
                        else
                        {
                            MessageBox.Show("Produto não inserido!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao inserir o produto!" + ex.Message);

                    }
                    break;

                case "Editar":
                    try
                    {
                        objTabela.Id = Convert.ToInt32(txtCodigo.Text);
                        objTabela.Nome = txtNome.Text;
                        objTabela.Descricao = txtDescricao.Text;
                        objTabela.Valor = Convert.ToDecimal(txtValor.Text);

                        int x = ProdutoModel.Editar(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Produto {0} foi editado com sucesso!", txtNome.Text));
                        }
                        else
                        {
                            MessageBox.Show("O produto não foi editado!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao editar o produto!" + ex.Message);

                    }
                    break;

                case "Excluir":
                    try
                    {
                        objTabela.Id = Convert.ToInt32(txtCodigo.Text);

                        int x = ProdutoModel.Excluir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Produto {0} foi excluído com sucesso!", txtNome.Text));
                        }
                        else
                        {
                            MessageBox.Show("Produto não excluido!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir o produto!" + ex.Message);

                    }
                    break;

                case "Pesquisar":
                    try
                    {
                        objTabela.Nome = txtPesquisar.Text;
                        List<ProdutoEnt> lista = new List<ProdutoEnt>();
                        lista = new ProdutoModel().Pesquisar(objTabela);
                        dataGridViewProduto.AutoGenerateColumns = false;
                        dataGridViewProduto.DataSource = lista;
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

        private void ListarGrid()
        {
            try
            {
                List<ProdutoEnt> lista = new List<ProdutoEnt>();
                lista = new ProdutoModel().Lista();
                dataGridViewProduto.AutoGenerateColumns = false;
                dataGridViewProduto.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apresentar os dados!" + ex.Message);
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
                MessageBox.Show("Selecione um produto na Grid para editar");
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
                MessageBox.Show("Selecione um produto na Grid para excluir");
                return;
            }
            opc = "Excluir";
            iniciarOpc();
            ListarGrid();
            LimparCampos();
            DesabilitarCampos();
        }

        private void dataGridViewProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dataGridViewProduto.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataGridViewProduto.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = dataGridViewProduto.CurrentRow.Cells[2].Value.ToString();
            txtValor.Text = dataGridViewProduto.CurrentRow.Cells[3].Value.ToString();
            HabilitarCampos();
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
