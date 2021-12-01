using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Cadastros
{
    public partial class FrmFuncionarios : Form
    {
        Conexao connect = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;

        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void habilitarCampos()
        {
            EdtNome.Enabled = true;
            EdtCPF.Enabled = true;
            EdtEndereco.Enabled = true;
            CboxCargo.Enabled = true;
            EdtTelefone.Enabled = true;
        }
        private void desabilitarCampos()
        {
            EdtNome.Enabled = false;
            EdtCPF.Enabled = false;
            EdtEndereco.Enabled = false;
            CboxCargo.Enabled = false;
            EdtTelefone.Enabled = false;
        }
        private void limparCampos()
        {
            EdtNome.Text = "";
            EdtCPF.Text = "";
            EdtEndereco.Text = "";
            EdtTelefone.Text = "";
        }

        private void CarregarComboBox()
        {
            connect.AbrirCon();

            sql = "SELECT * FROM cargos ORDER BY cargo asc";
            cmd = new MySqlCommand(sql, connect.MySqlConnection);
            MySqlDataAdapter MyData = new MySqlDataAdapter();
            MyData.SelectCommand = cmd;
            DataTable MyDataTable = new DataTable();
            MyData.Fill(MyDataTable);
            CboxCargo.DataSource = MyDataTable;
            CboxCargo.ValueMember = "id";
            CboxCargo.DisplayMember = "cargo";            
            
            connect.FecharCon();
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
        }

        private void radioNome_CheckedChanged(object sender, EventArgs e)
        {
            EdtBuscaNome.Visible = true;
            EdtBuscaCPF.Visible = false;

            EdtBuscaNome.Text = "";
            EdtBuscaCPF.Text = "";
        }

        private void radioCPF_CheckedChanged(object sender, EventArgs e)
        {
            EdtBuscaNome.Visible = false;
            EdtBuscaCPF.Visible = true;

            EdtBuscaNome.Text = "";
            EdtBuscaCPF.Text = "";
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
            int digitosCPF = EdtCPF.Text.Length;
            if (EdtCPF.Text == "   .   .   -" || digitosCPF < 14)
            {
                MessageBox.Show("Preencha o CPF corretamente");
                EdtCPF.Focus();
                return;
            }
            if (CboxCargo.SelectedValue == null)
            {
                MessageBox.Show("Nenhum cargo cadastrado");
                return;
            }

            MessageBox.Show("Salvo com sucesso");
            BtnNovo.Enabled = true;
            BtnSalvar.Enabled = false;
            limparCampos();
            desabilitarCampos();
        }

        private void Grid_Click(object sender, EventArgs e)
        {
            BtnEditar.Enabled = true;
            BtnDeletar.Enabled = true;
            BtnSalvar.Enabled = false;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (EdtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o nome");
                EdtNome.Focus();
                return;
            }
            int digitosCPF = EdtCPF.Text.Length;
            if (EdtCPF.Text == "   .   .   -" || digitosCPF < 14)
            {
                MessageBox.Show("Preencha o CPF corretamente");
                EdtCPF.Focus();
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

    }
}
