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
    public partial class FrmCargos : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;

        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "Código";
            Grid.Columns[0].Visible = false;
            Grid.Columns[1].HeaderText = "Cargo";
            Grid.Columns[1].Width = 200;
        }

        private void Listar()
        {
            con.AbrirCon();
            sql = "SELECT * FROM cargos ORDER BY cargo asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
            con.FecharCon();
            FormatarDG();
        }

        public FrmCargos()
        {
            InitializeComponent();
        }

        private void FrmCargos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            EdtNome.Enabled = true;
            BtnSalvar.Enabled = true;
            BtnNovo.Enabled = false;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (EdtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o nome");
                EdtNome.Focus();
                return;
            }

            con.AbrirCon();
            sql = "INSERT INTO cargos (cargo) VALUES (@cargo)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@cargo", EdtNome.Text);
            cmd.ExecuteNonQuery();
            con.FecharCon();

            Listar();
            MessageBox.Show("Salvo com sucesso");
            BtnNovo.Enabled = true;
            BtnSalvar.Enabled = false;
            EdtNome.Text = "";
            EdtNome.Enabled = false;
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEditar.Enabled = true;
            BtnDeletar.Enabled = true;
            BtnSalvar.Enabled = false;
            EdtNome.Enabled = true;

            id = Grid.CurrentRow.Cells[0].Value.ToString();
            EdtNome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            con.AbrirCon();
            sql = "UPDATE cargos SET cargo = @cargo WHERE id = @id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@cargo", EdtNome.Text);
            cmd.ExecuteNonQuery();
            con.FecharCon();

            Listar();
            MessageBox.Show("Salvo com sucesso");
            BtnNovo.Enabled = true;
            BtnSalvar.Enabled = false;
            EdtNome.Text = "";
            EdtNome.Enabled = false;
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show("Deseja excluir?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(confirmacao == DialogResult.Yes)
            {
                con.AbrirCon();
                sql = "DELETE FROM cargos WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.FecharCon();

                Listar();
                MessageBox.Show("Excluído com sucesso");
                BtnNovo.Enabled = true;
                BtnSalvar.Enabled = false;
                EdtNome.Text = "";
                EdtNome.Enabled = false;
            }

        }
    }
}
