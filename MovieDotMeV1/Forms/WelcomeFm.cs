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
    public partial class WelcomeFm : Form
    {
        public WelcomeFm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ClearData()
        {
            PasswordBox.Clear();
            UsernameBox.Clear();
        }
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            var username = UsernameBox.Text;
            var password = PasswordBox.Text;

            var IsUser = MyCore.SignIn(username, password);
            if (IsUser)
            {
                var movieHome = new MoviesHomeFm(username.ToLower());
                movieHome.ShowDialog();
            }
            else
            {
                var message = "incorect password or username";
                MessageBox.Show(message);

                ClearData();
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            var signUp = new SignUpFm();
            signUp.ShowDialog();
        }
    }
}
