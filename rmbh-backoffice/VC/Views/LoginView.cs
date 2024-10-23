using rmbh_backoffice.VC;
using rmbh_backoffice.VC.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rmbh_backoffice.VC.Views
{
    public partial class LoginView : Form, IView
    {
        public LoginView()
        {
            InitializeComponent();
        }


        // Make sure each IView should have a Form
        public Form Form
        {
            get
            {
                return this;
            }
        }

        public string Title
        {
            get
            {
                return Text;
            }

            set
            {
                Text = value;
            }
        }

        private void button_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_Passwordshow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Passwordshow.Checked == true)
            {
                textBox_Password.UseSystemPasswordChar = false;
                return;
            }
            textBox_Password.UseSystemPasswordChar = true;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {

        }
    }
}
