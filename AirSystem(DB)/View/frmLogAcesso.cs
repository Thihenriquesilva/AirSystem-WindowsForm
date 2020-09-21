using AirSystem.Database;
using AirSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.View
{
    public partial class frmLogAcesso : Form
    {
        AcessoRepository _acessoRepository = new AcessoRepository();
        Acesso acesso = new Acesso();
        Usuarios usuario = new Usuarios();
        public frmLogAcesso()
        {
            InitializeComponent();
        }

        private void frmLogAcesso_Load(object sender, EventArgs e)
        {
            dgvAcesso.DataSource = null;
            dgvAcesso.DataSource = _acessoRepository.BuscarTodos();
            
        }
    }
}
