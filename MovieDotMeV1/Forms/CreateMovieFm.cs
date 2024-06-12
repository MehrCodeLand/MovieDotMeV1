using MovieDotMeV1.Models;
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
    public partial class CreateMovieFm : Form
    {
        public CreateMovieFm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            var title = UsernameBox.Text;
            var director = PasswordBox.Text;
            var description = RePasswordBox.Text;

            var movie = new Movie()
            {
                Title = title,
                Director = director,
                Description = description,
            };

            MyCore.CreateMovie(movie);

        }
    }
}
