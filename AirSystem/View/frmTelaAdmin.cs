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
    public partial class frmTelaAdmin : Form
    {
        public frmTelaAdmin()
        {
            InitializeComponent();
        }

        private void btnListarUser_Click(object sender, EventArgs e)
        {
            try {
                
                new frmListarUsuario().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
