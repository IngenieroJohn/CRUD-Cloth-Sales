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
    public partial class InterfazGestionUsuario : Form
    {
        public InterfazGestionUsuario()
        {
            InitializeComponent();
        }

        private void InterfazGestionUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            InterfazDeAdministracionDeStock adminStock =new InterfazDeAdministracionDeStock();
            adminStock.Show();
        }
    }
}
