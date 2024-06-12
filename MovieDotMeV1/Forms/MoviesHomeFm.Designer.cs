namespace MovieDotMeV1.Forms
{
    partial class MoviesHomeFm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridMovie = new DataGridView();
            movieIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            directorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            movieBindingSource = new BindingSource(components);
            BackBtn = new Button();
            UsernameBox = new TextBox();
            ProfileBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridMovie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).BeginInit();
            SuspendLayout();
            // 
            // DataGridMovie
            // 
            DataGridMovie.AutoGenerateColumns = false;
            DataGridMovie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridMovie.Columns.AddRange(new DataGridViewColumn[] { movieIDDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, directorDataGridViewTextBoxColumn });
            DataGridMovie.DataSource = movieBindingSource;
            DataGridMovie.Location = new Point(197, 95);
            DataGridMovie.Name = "DataGridMovie";
            DataGridMovie.RowTemplate.Height = 25;
            DataGridMovie.Size = new Size(441, 150);
            DataGridMovie.TabIndex = 0;
            // 
            // movieIDDataGridViewTextBoxColumn
            // 
            movieIDDataGridViewTextBoxColumn.DataPropertyName = "MovieID";
            movieIDDataGridViewTextBoxColumn.HeaderText = "MovieID";
            movieIDDataGridViewTextBoxColumn.Name = "movieIDDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // directorDataGridViewTextBoxColumn
            // 
            directorDataGridViewTextBoxColumn.DataPropertyName = "Director";
            directorDataGridViewTextBoxColumn.HeaderText = "Director";
            directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            // 
            // movieBindingSource
            // 
            movieBindingSource.DataSource = typeof(Models.Movie);
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(563, 273);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 1;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(197, 66);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(178, 23);
            UsernameBox.TabIndex = 2;
            // 
            // ProfileBtn
            // 
            ProfileBtn.Location = new Point(393, 66);
            ProfileBtn.Name = "ProfileBtn";
            ProfileBtn.Size = new Size(75, 23);
            ProfileBtn.TabIndex = 3;
            ProfileBtn.Text = "Profile";
            ProfileBtn.UseVisualStyleBackColor = true;
            ProfileBtn.Click += ProfileBtn_Click;
            // 
            // MoviesHomeFm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProfileBtn);
            Controls.Add(UsernameBox);
            Controls.Add(BackBtn);
            Controls.Add(DataGridMovie);
            Name = "MoviesHomeFm";
            Text = "MoviesHomeFm";
            ((System.ComponentModel.ISupportInitialize)DataGridMovie).EndInit();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridMovie;
        private DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private BindingSource movieBindingSource;
        private Button BackBtn;
        private TextBox UsernameBox;
        private Button ProfileBtn;
    }
}