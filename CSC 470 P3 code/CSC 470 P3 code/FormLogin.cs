using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC_470_P3_code
{
    public partial class Login : Form
    {
        private IAppUser AppUserDatabase;

        public Login()
        {
            InitializeComponent();
            AppUserDatabase = new FakeAppUserRepository();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (AppUserDatabase.Login(UserNameTextBox.Text, PasswordTextBox.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void CancelLoginButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }


    }
}
