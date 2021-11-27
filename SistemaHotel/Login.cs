using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            pnlLogin.Visible = false;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            repositionPnlLoginOnResize();
            pnlLogin.Visible = true;
            edtUsuario.Text = "Admin";
            edtSenha.Text = "123";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ChamarLogin();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChamarLogin(); 
            }
        }

        private void ChamarLogin ()
        {
            if (edtUsuario.Text == "" || edtSenha.Text == "")
            {
                MessageBox.Show("Preencha os campos Usuário e Senha");
                edtUsuario.Focus();
                return;
            }

            // LoginCode
            frmMenu form = new frmMenu();
            Limpar();
            form.Show();
        }

        private void Limpar()
        {
            edtUsuario.Text = "";
            edtSenha.Text = "";
            edtUsuario.Focus();
        }

        private void repositionPnlLoginOnResize()
        {
            var width = this.Width / 2 - pnlLogin.Width / 2;
            var height = this.Height / 2 - pnlLogin.Height / 2;
            pnlLogin.Location = new Point(width, height);
        }

        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            repositionPnlLoginOnResize();
        }
    }
}
