using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Produtos
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void LimparFoto()
        {
            ImgProduto.Image = Properties.Resources.icon_photo;
        }
        private void habilitarCampos()
        {
            EdtNome.Enabled         = true;
            EdtDescricao.Enabled    = true;
            EdtValor.Enabled        = true;
            CboxFornecedor.Enabled  = true;
            EdtEstoque.Enabled      = true;
            BtnImgAnexa.Enabled     = true;
            BtnImgRemove.Enabled    = true;
        }
        private void desabilitarCampos()
        {
            EdtNome.Enabled         = false;
            EdtDescricao.Enabled    = false;
            EdtValor.Enabled        = false;
            CboxFornecedor.Enabled  = false;
            EdtEstoque.Enabled      = false;
            BtnImgAnexa.Enabled     = false;
            BtnImgRemove.Enabled    = false;
        }
        private void limparCampos()
        {
            EdtNome.Text        = "";
            EdtDescricao.Text   = "";
            EdtValor.Text       = "";
            EdtEstoque.Text     = "";
            LimparFoto();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            LimparFoto();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            BtnSalvar.Enabled = true;
            BtnNovo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnDeletar.Enabled = false;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (EdtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o nome");
                EdtNome.Focus();
                return;
            }

            MessageBox.Show("Salvo com sucesso");
            BtnNovo.Enabled = true;
            BtnSalvar.Enabled = false;
            limparCampos();
            desabilitarCampos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (EdtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o nome");
                EdtNome.Focus();
                return;
            }

            MessageBox.Show("Salvo com sucesso");
            BtnNovo.Enabled = true;
            BtnEditar.Enabled = false;
            BtnDeletar.Enabled = false;
            limparCampos();
            desabilitarCampos();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Confirma a exclusão do registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Excluído com sucesso");
            }
        }

        private void BtnImgAnexa_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Arquivos de imagens (*.jpg, *.png)|*.jpg;*.png";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                ImgProduto.ImageLocation = foto;
            }
        }
    }
}
