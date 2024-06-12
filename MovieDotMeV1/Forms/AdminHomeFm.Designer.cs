namespace MovieDotMeV1.Forms
{
    partial class AdminHomeFm
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
            CreateBtn = new Button();
            DataGridMovie = new DataGridView();
            movieIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            directorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            movieBindingSource = new BindingSource(components);
            closeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridMovie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).BeginInit();
            SuspendLayout();
            // 
            // CreateBtn
            // 
            CreateBtn.Location = new Point(550, 251);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(75, 23);
            CreateBtn.TabIndex = 6;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // DataGridMovie
            // 
            DataGridMovie.AutoGenerateColumns = false;
            DataGridMovie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridMovie.Columns.AddRange(new DataGridViewColumn[] { movieIDDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, directorDataGridViewTextBoxColumn });
            DataGridMovie.DataSource = movieBindingSource;
            DataGridMovie.Location = new Point(184, 95);
            DataGridMovie.Name = "DataGridMovie";
            DataGridMovie.RowTemplate.Height = 25;
            DataGridMovie.Size = new Size(441, 150);
            DataGridMovie.TabIndex = 4;
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
            // closeBtn
            // 
            closeBtn.Location = new Point(184, 251);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(75, 23);
            closeBtn.TabIndex = 7;
            closeBtn.Text = "close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // AdminHomeFm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeBtn);
            Controls.Add(CreateBtn);
            Controls.Add(DataGridMovie);
            Name = "AdminHomeFm";
            Text = "AdminHomeFm";
            ((System.ComponentModel.ISupportInitialize)DataGridMovie).EndInit();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CreateBtn;
        private DataGridView DataGridMovie;
        private DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private BindingSource movieBindingSource;
        private Button closeBtn;
    }
}