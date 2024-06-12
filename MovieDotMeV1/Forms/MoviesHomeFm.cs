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
    public partial class MoviesHomeFm : Form
    {
        public string username = "";
        public MoviesHomeFm(string username)
        {
            InitializeComponent();
            this.username = username;
            FillDataGrid();
            FillData();

            DataGridMovie.CellDoubleClick += dataGrid_cell;
        }
        private void FillData()
        {
            UsernameBox.Text = username;
        }
        private void FillDataGrid()
        {
            DataGridMovie.DataSource = MyCore.GetAllMovies();
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            var profile = new ProfileFm(username);
            profile.ShowDialog();
        }


        // event


        private void dataGrid_cell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridMovie.Rows[e.RowIndex].Selected = true;
                DataGridViewRow selectedRow = DataGridMovie.Rows[e.RowIndex];
                string movieTitle = (string)selectedRow.Cells[1].Value;

                // time to add
                var isResult = MyCore.AddFaveMovies(username, movieTitle);
                if(isResult == false)
                {
                    var message = "it is already added ";
                    MessageBox.Show(message);
                }
            }
        }
    }
}
