using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStrategyCloth.Views
{
    public partial class InterfazDeAdministracionDeStock : Form
    {
        public InterfazDeAdministracionDeStock()
        {
            InitializeComponent();
        }

        private void InterfazDeAdministracionDeStock_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            InterfazGestionUsuario gestionUser = new InterfazGestionUsuario();
            gestionUser.Show();
        }
    }
}
