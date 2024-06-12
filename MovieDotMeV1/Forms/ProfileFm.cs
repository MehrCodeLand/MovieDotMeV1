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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MovieDotMeV1.Forms
{
    public partial class ProfileFm : Form
    {
        public User user;
        public ProfileFm(string username)
        {
            InitializeComponent();
            user = MyCore.GetUser(username);
            FilData();
            DataGridMovie.CellDoubleClick += dataGrid_cell;
        }
        private void FilData()
        {
            UsernameBox.Text = user.Username;
            DataGridMovie.DataSource = MyCore.GetMovieUser(user.UserID);
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // events 
        private void dataGrid_cell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridMovie.Rows[e.RowIndex].Selected = true;
                DataGridViewRow selectedRow = DataGridMovie.Rows[e.RowIndex];
                string movieTitle = (string)selectedRow.Cells[1].Value;

                // time to remove
                MyCore.RemoveFaveMovies(user.Username, movieTitle);
                FilData();
            }
        }
    }
}
