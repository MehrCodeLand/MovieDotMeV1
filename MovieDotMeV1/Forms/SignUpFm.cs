using MovieDotMeV1.RepositoryCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDotMeV1.Forms
{
    public partial class SignUpFm : Form
    {
        public SignUpFm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearText()
        {
            UsernameBox.Text = string.Empty;
            PasswordBox.Text = string.Empty;
            RePasswordBox.Text = string.Empty;
        }
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            var username = UsernameBox.Text;
            var password = PasswordBox.Text;
            var repassword = RePasswordBox.Text;

            if(password == repassword)
            {
                var IsUp = MyCore.SignUp(username, password);
                if(IsUp)
                {
                    this.Close();
                }
            }
            else
            {
                var message = "same pasword please";
                MessageBox.Show(message);
                ClearText();
            }
        }
    }
}
