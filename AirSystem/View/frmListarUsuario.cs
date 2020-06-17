using AirSystem.Models;
using AirSystem.Repositories;
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

namespace AirSystem.View
{
    public partial class frmListarUsuario : Form
    {
        UsuarioRepository repository = new UsuarioRepository();
        public frmListarUsuario()
        {
            InitializeComponent();
        }
        
     
        
        private void frmListarUsuario_Load(object sender, EventArgs e)
        {

            dgvListaAluno.DataSource = repository.BuscarTodos();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureUsuario1.Load(ofd.FileName);
            }
        }

        private void btnDeletar1_Click(object sender, EventArgs e)
        {

            if (pictureUsuario1.Image != null)
            {
                pictureUsuario1.Image = null;
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Nenhuma imagem selecionada, por favor adicione uma.!", "Alerta");
            }
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();

            dgvListaAluno.DataSource = null;
            dgvListaAluno.DataSource = repository.BuscarTodos();
        }

        private void dgvListaAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rows = dgvListaAluno.Rows[e.RowIndex];

                string nome = textBoxNome1.Text = rows.Cells[1].Value.ToString();
                string sobreNome = textBoxSobrenome1.Text = rows.Cells[2].Value.ToString();
                string endereco =textBoxEndereco1.Text = rows.Cells[3].Value.ToString();
                string enderecoNum = textBoxEnderecoNum1.Text = rows.Cells[4].Value.ToString();
                string userName =textBoxUsuario1.Text = rows.Cells[6].Value.ToString();
                string senha = textBoxSenha1.Text = rows.Cells[7].Value.ToString();
                string confirmasenha = textBoxConfirmaSenha1.Text = rows.Cells[7].Value.ToString();
                int codigo = Convert.ToInt32(rows.Cells[0].Value.ToString());

                Usuario usuario = new Usuario
                {
                    codigo = codigo,
                    nome = nome,
                    sobrenome = sobreNome,
                    endereco = endereco,
                    numeroEnd = enderecoNum,
                    usuario = userName,
                    senha = senha
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
            
        }

        private void textBuscaNome_TextChanged(object sender, EventArgs e)
        { 
            
            dgvListaAluno.DataSource = null;

            dgvListaAluno.DataSource = repository.BuscarTodos().FindAll(x =>
            x.nome.ToUpper().Contains(textBuscaNome.Text.ToUpper()));
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
