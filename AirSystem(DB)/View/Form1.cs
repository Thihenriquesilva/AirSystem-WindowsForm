using AirSystem.Database;
using AirSystem.Repositories;
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
        UsuarioRepository repository = new UsuarioRepository();
        //Usuarios usuarioLogado = new Usuarios();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortTimeString();
            repository.BuscarTodos();
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
            if ((textUsuario.Text == "Digite seu usuário...") ||
               ( textSenha.Text == "Digite sua senha..."))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Usuario ou senha invalidos", "Erro");
                return;
            }

            try
            {

                string usuario = textUsuario.Text;
                string password = textSenha.Text;
                Usuarios usuarioLogado = repository.BuscarUsuarioPorLogin(usuario, password);
                //usuarioLogado.Tx_Usuario= textUsuario.Text;
                //usuarioLogado.Tx_Senha = textSenha.Text;
                if (usuarioLogado != null)
                {
                    
                    if (usuarioLogado.IsAdmin == true)
                    {
                        this.Hide();
                        new frmTelaAdmin().ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Bem vindo");
                        this.Hide();
                        new frmTelaComun().ShowDialog();
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Usuário ou senha invalidos","Atenção");
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }




            //new frmTelaAdmin().ShowDialog();
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
