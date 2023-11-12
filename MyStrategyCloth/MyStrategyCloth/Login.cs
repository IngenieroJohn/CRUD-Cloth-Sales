using MyStrategyCloth.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStrategyCloth
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void GoToSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateUser createuser = new CreateUser();
            createuser.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InterfazDeAdministracionDeStock interfazAdmin = new InterfazDeAdministracionDeStock();
            interfazAdmin.Show();
        }
    }
}
