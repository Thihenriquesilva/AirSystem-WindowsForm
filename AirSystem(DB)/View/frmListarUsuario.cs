using AirSystem.Database;
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
        Usuarios usuario = new Usuarios();


        public frmListarUsuario()
        {
            InitializeComponent();
        }
        
     
        
        private void frmListarUsuario_Load(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
            List<Usuarios> usuarios = repository.BuscarTodos();

            CarregaTodos();

           
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


                usuario.Tx_Nome = textBoxNome1.Text = rows.Cells[1].Value.ToString();
                usuario.Tx_Sobrenome = textBoxSobrenome1.Text = rows.Cells[2].Value.ToString();
                usuario.Tx_Logradouro = textBoxEndereco1.Text = rows.Cells[3].Value.ToString();
                usuario.Nr_Casa = Convert.ToInt32(textBoxEnderecoNum1.Text = rows.Cells[4].Value.ToString());
                usuario.Dt_Nascimento = dateTimePicker1.Value = Convert.ToDateTime(rows.Cells[5].Value.ToString());
                usuario.Tx_Usuario = textBoxUsuario1.Text = rows.Cells[6].Value.ToString();
                usuario.Tx_Senha = textBoxSenha1.Text = rows.Cells[7].Value.ToString();
                textBoxConfirmaSenha1.Text = rows.Cells[7].Value.ToString();
                usuario.Id = Convert.ToInt32(rows.Cells[0].Value.ToString());
                
                btnEditar.Enabled = true;
                btnDeletar.Enabled = true;

                CarregaTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            new frmCadastro(usuario).ShowDialog();
            CarregaTodos();
            
        }

        private void textBuscaNome_TextChanged(object sender, EventArgs e)
        { 
            
            dgvListaAluno.DataSource = null;

            dgvListaAluno.DataSource = repository.BuscarTodos().FindAll(x =>
            x.Tx_Nome.ToUpper().Contains(textBuscaNome.Text.ToUpper()));
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja realmente excluir", "Atenção",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                repository.Deletar(usuario.Id);
                CarregaTodos();
            }
            
        }

        private void CarregaTodos()
        {
            dgvListaAluno.DataSource = null;
            dgvListaAluno.DataSource = repository.BuscarTodos();

        }

        private void dgvListaAluno_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error:" + e.Context.ToString());
        }
    }
}
