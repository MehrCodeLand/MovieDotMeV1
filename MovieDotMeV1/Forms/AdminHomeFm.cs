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
    public partial class AdminHomeFm : Form
    {
        public AdminHomeFm()
        {
            InitializeComponent();
            DataGridMovie.CellDoubleClick += dataGrid_cell;
            FillData();
        }
        private void FillData()
        {
            DataGridMovie.DataSource = MyCore.GetAllMovies();
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            // create page
            var create = new CreateMovieFm();
            create.ShowDialog();
        }


        // events 
        private void dataGrid_cell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridMovie.Rows[e.RowIndex].Selected = true;
                DataGridViewRow selectedRow = DataGridMovie.Rows[e.RowIndex];
                string movieTitle = (string)selectedRow.Cells[1].Value;

                MyCore.RemoveMovieAll(movieTitle);
                FillData();
            }
        }
    }
}
