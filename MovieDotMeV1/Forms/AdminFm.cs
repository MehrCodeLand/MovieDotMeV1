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
    public partial class AdminFm : Form
    {
        public AdminFm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            var usernmae = UsernameBox.Text;
            var password = PasswordBox.Text;

            var IsAdmin = MyCore.LoginAdmin(usernmae, password);
            if (IsAdmin)
            {
                var ad = new AdminHomeFm();
                ad.ShowDialog();
            }
        }
    }
}
