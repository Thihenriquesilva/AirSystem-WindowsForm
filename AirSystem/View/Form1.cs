using AirSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Realmente quer sair","Confirmação",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public static int idioma;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            idioma = languageBox.SelectedIndex;
            if (textUsuario.Text.Trim().Length == 0 ||
                textSenha.Text.Trim().Length == 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Usuario ou senha invalidos", "Erro");
            }
            else
            {
                MessageBox.Show("Bem vindo");
            }


        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
        }

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            if(textUsuario.Text == "Digite seu usuário...")
            {
                textUsuario.Text = "";
                textUsuario.ForeColor = Color.Black;
            }
        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {
            if (textUsuario.Text == "")
            {
                textUsuario.Text = "Digite seu usuário...";
                textUsuario.ForeColor = Color.Silver;
            }
        }

        private void textSenha_Enter(object sender, EventArgs e)
        {
            if(textSenha.Text == "Digite sua senha...")
            {
                textSenha.Text = "";
                textSenha.ForeColor = Color.Black;
                textSenha.UseSystemPasswordChar = true;

            }
        }

        private void textSenha_Leave(object sender, EventArgs e)
        {
            if (textSenha.Text == "")
            {
                textSenha.Text = "Digite sua senha...";
                textSenha.ForeColor = Color.Silver;
                textSenha.UseSystemPasswordChar = false;
            }
        }
    }
}
