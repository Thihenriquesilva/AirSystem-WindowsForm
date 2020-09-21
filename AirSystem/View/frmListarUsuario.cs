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
        Usuario usuario = new Usuario();
        public frmListarUsuario()
        {
            InitializeComponent();
            
        }
        
     
        
        private void frmListarUsuario_Load(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
            List<Usuario> usuarios = repository.BuscarTodos();
            CarregarTodos();

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

            CarregarTodos();
        }

        private void dgvListaAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rows = dgvListaAluno.Rows[e.RowIndex];

                usuario.nome = textBoxNome1.Text = rows.Cells[1].Value.ToString();
                usuario.sobrenome =textBoxSobrenome1.Text = rows.Cells[2].Value.ToString();
                usuario.endereco=textBoxEndereco1.Text = rows.Cells[3].Value.ToString();
                usuario.numeroEnd=textBoxEnderecoNum1.Text = rows.Cells[4].Value.ToString();
                usuario.nascimento = dateTimePicker1.Value = Convert.ToDateTime(rows.Cells[5].Value.ToString());
                usuario.usuario=textBoxUsuario1.Text = rows.Cells[6].Value.ToString();
                usuario.senha=textBoxSenha1.Text = rows.Cells[7].Value.ToString();
                textBoxConfirmaSenha1.Text = rows.Cells[7].Value.ToString();
                usuario.codigo=Convert.ToInt32(rows.Cells[0].Value.ToString());

               

                btnEditar.Enabled = true;
                btnDeletar.Enabled = true;

                CarregarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            new frmCadastro(usuario).ShowDialog();
            CarregarTodos();

        }

        private void textBuscaNome_TextChanged(object sender, EventArgs e)
        { 
            
            dgvListaAluno.DataSource = null;

            dgvListaAluno.DataSource = repository.BuscarTodos().FindAll(x =>
            x.nome.ToUpper().Contains(textBuscaNome.Text.ToUpper()));
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja realmente excluir", "Atenção",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if(dr == DialogResult.Yes)
            {
                repository.Deletar(usuario.codigo);
                CarregarTodos();
            }
        }


        private void CarregarTodos()
        {
            dgvListaAluno.DataSource = null;
            dgvListaAluno.DataSource = repository.BuscarTodos();
        }
    }
}
