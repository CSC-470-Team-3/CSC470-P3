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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            //upon initialization, a login dialog will require the user to log in
            Login Login = new Login();
            DialogResult result = Login.ShowDialog();

            //If user selects to close the form and not log in, close the main form as well
            if (result == DialogResult.Cancel)
                Close();
        }

    }
}
