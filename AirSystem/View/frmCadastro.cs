﻿using AirSystem.Models;
using AirSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.View
{
    public partial class frmCadastro : Form
    {
        private Usuario usuario = null;
        public frmCadastro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public frmCadastro(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

            if(usuario != null)
            {
                textNome.Text = usuario.nome;
                textSobrenome.Text = usuario.sobrenome;
                textEndereco.Text = usuario.endereco;
                textNum.Text = usuario.numeroEnd;
                dateTimePicker1.Value = usuario.nascimento;
                textUsuarioC.Text = usuario.usuario;
                textSenhaC.Text = usuario.senha;
                checkBoxAdmin.Checked = usuario.tipousuario;

                btnCadastro.Text = "Salvar";
            }

            if (frmLogin.idioma == 0)
            {
                MessageBox.Show("Portugues");
            }
            else
            {
                MessageBox.Show("Inglês");
            }


        }
        // ********************* Literalmente repetidos **********************
        private void textNome_Enter(object sender, EventArgs e)
        {   
            if (textNome.Text == "Digite seu nome...")
            {
                textNome.Text = "";
                textNome.ForeColor = Color.Black;
            }
            textNome.BackColor = Color.FromArgb(255, 255, 192);
        }

        private void textNome_Leave(object sender, EventArgs e)
        {
            if (textNome.Text == "")
            {
                textNome.Text = "Digite seu nome...";
                textNome.ForeColor = Color.Silver;
            }

            textNome.BackColor = Color.White;
        }

        private void textSobrenome_Enter(object sender, EventArgs e)
        {
            if (textSobrenome.Text == "Digite seu sobrenome...")
            {
                textSobrenome.Text = "";
                textSobrenome.ForeColor = Color.Black;
            }
            textSobrenome.BackColor = Color.FromArgb(255, 255, 192);
        }

        private void textSobrenome_Leave(object sender, EventArgs e)
        {
            if(textSobrenome.Text == "")
            {
                textSobrenome.Text = "Digite seu sobrenome...";
                textSobrenome.ForeColor = Color.Silver;
            }

            textSobrenome.BackColor = Color.White;
        }

        private void textEndereco_Enter(object sender, EventArgs e)
        {
            if(textEndereco.Text == "Digite seu Endereço...")
            {
                textEndereco.Text = "";
                textEndereco.ForeColor = Color.Black;
            }

            textEndereco.BackColor = Color.FromArgb(255, 255, 192);
        }

        private void textEndereco_Leave(object sender, EventArgs e)
        {
            if (textEndereco.Text == "")
            {
                textEndereco.Text = "Digite seu Endereço...";
                textEndereco.ForeColor = Color.Silver;
            }

            textEndereco.BackColor = Color.White;
        }

        private void textNum_Enter(object sender, EventArgs e)
        {
            if (textNum.Text == "Nº")
            {
                textNum.Text = "";
                textNum.ForeColor = Color.Black;
            }
            textNum.BackColor = Color.FromArgb(255,255,192);
        }

        private void textNum_Leave(object sender, EventArgs e)
        {
            if (textNum.Text == "")
            {
                textNum.Text = "Nº";
                textNum.ForeColor = Color.Silver;
            }
            textNum.BackColor = Color.White;
        }

        private void textUsuarioC_Enter(object sender, EventArgs e)
        {
            if (textUsuarioC.Text == "Insira seu usuário...")
            {
                textUsuarioC.Text = "";
                textUsuarioC.ForeColor = Color.Black;
            }
            textUsuarioC.BackColor = Color.FromArgb(255, 255, 192);
        }

        private void textUsuarioC_Leave(object sender, EventArgs e)
        {
            if (textUsuarioC.Text == "")
            {
                textUsuarioC.Text = "Insira seu usuário...";
                textUsuarioC.ForeColor = Color.Silver;
            }
            textUsuarioC.BackColor = Color.White;
        }

        private void textSenhaC_Enter(object sender, EventArgs e)
        {
            if (textSenhaC.Text == "Insira sua senha...")
            {
                textSenhaC.Text = "";
                textSenhaC.ForeColor = Color.Black;

                textSenhaC.UseSystemPasswordChar = true;

            }
            textSenhaC.BackColor = Color.FromArgb(255, 255, 192);
        }

        private void textSenhaC_Leave(object sender, EventArgs e)
        {
            if (textSenhaC.Text == "")
            {

                textSenhaC.Text = "Insira sua senha...";
                textSenhaC.ForeColor = Color.Silver;
                textSenhaC.UseSystemPasswordChar = false;
            }

            textSenhaC.BackColor = Color.White;
        }

        private void textConfirmaSenha_Enter(object sender, EventArgs e)
        {
            if (textConfirmaSenha.Text == "Confirme sua senha...")
            {
                textConfirmaSenha.Text = "";
                textConfirmaSenha.ForeColor = Color.Black;
                textConfirmaSenha.UseSystemPasswordChar = true;

            }

            textConfirmaSenha.BackColor = Color.FromArgb(255, 255, 192);
        }

        private void textConfirmaSenha_Leave(object sender, EventArgs e)
        {
            if (textConfirmaSenha.Text == "")
            {
                textConfirmaSenha.Text = "Confirme sua senha...";
                textConfirmaSenha.ForeColor = Color.Silver;
                textConfirmaSenha.UseSystemPasswordChar = false;

            }
            textConfirmaSenha.BackColor = Color.White;


        }

        // *************** FIM ********************

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureUsuario.Load(ofd.FileName);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (pictureUsuario.Image != null)
            {
                pictureUsuario.Image = null;
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Nenhuma imagem selecionada, por favor adicione uma.!","Alerta");
            }
        }



        private void btnCadastro_Click(object sender, EventArgs e)
        {   

            if ((textNome.Text != "Digite seu nome...")
                && (textSobrenome.Text != "Digite seu sobrenome...") && (textUsuarioC.Text != "Insira seu usuário...")
                && (textSenhaC.Text != "Insira sua senha...") && (textConfirmaSenha.Text != "Confirme sua senha..."))
                {

                UsuarioRepository repository = new UsuarioRepository();
                if (this.usuario == null)
                {
                    Usuario usuario = new Usuario
                    {
                        nome = textNome.Text,
                        sobrenome = textSobrenome.Text,
                        endereco = textEndereco.Text,
                        numeroEnd = textNum.Text,
                        nascimento = dateTimePicker1.Value,
                        usuario = textUsuarioC.Text,
                        senha = textSenhaC.Text,
                        //TODO: talvez precise de correção
                        tipousuario = Convert.ToBoolean(checkBoxAdmin.Checked)

                    };
                    if(repository.UsuarioExiste(textUsuarioC.Text))
                    {
                        repository.Adicionar(usuario);

                        MessageBox.Show("Cadastro realizado com sucesso.", "Parabéns");
                    }
                    else
                    {
                        MessageBox.Show("Usuário já existente");
                        textUsuarioC.Text = "";
                        
                    }
                }
                else
                {
                    

                    usuario.nome = textNome.Text;
                    usuario.sobrenome = textSobrenome.Text;
                    usuario.endereco = textEndereco.Text;
                    usuario.numeroEnd = textNum.Text;
                    usuario.nascimento = dateTimePicker1.Value;
                    usuario.usuario = textUsuarioC.Text;
                    usuario.senha = textSenhaC.Text;
                    usuario.senha = textConfirmaSenha.Text;
                    usuario.tipousuario = Convert.ToBoolean(checkBoxAdmin.Checked);

                    repository.Editar(usuario);
                    
                }
                this.Close();
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Preencha os espaços.");
            }
        }

        bool isValidSenha;
        private void textSenhaC_TextChanged(object sender, EventArgs e)
        {
            string pattern = "([a - z, A - Z, 0 - 9]{ 1,}){ 8,}";

            isValidSenha = Regex.IsMatch(textSenhaC.Text,pattern);

            lblErro1.Visible = false;
        }


        private void textConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
            if (textSenhaC.Text != textConfirmaSenha.Text)
            {
                SystemSounds.Beep.Play();
                lblErro.Visible = true;
            }
            else
            {
                lblErro.Visible = false;
            }
        }

        private void frmCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer fechar?","Confirmação",
                MessageBoxButtons.YesNo) == DialogResult.No) 
            {
                e.Cancel = true;
            }
        }
    }
}
