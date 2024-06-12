namespace MovieDotMeV1.Forms
{
    partial class CreateMovieFm
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BackBtn = new Button();
            SignUpBtn = new Button();
            RePasswordBox = new TextBox();
            PasswordBox = new TextBox();
            UsernameBox = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 202);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 18;
            label3.Text = "description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 164);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 17;
            label2.Text = "director";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 124);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 16;
            label1.Text = "title";
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(469, 276);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 15;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // SignUpBtn
            // 
            SignUpBtn.Location = new Point(281, 276);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(75, 23);
            SignUpBtn.TabIndex = 14;
            SignUpBtn.Text = "Create";
            SignUpBtn.UseVisualStyleBackColor = true;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // RePasswordBox
            // 
            RePasswordBox.Location = new Point(281, 199);
            RePasswordBox.Multiline = true;
            RePasswordBox.Name = "RePasswordBox";
            RePasswordBox.Size = new Size(263, 71);
            RePasswordBox.TabIndex = 13;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(281, 161);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(263, 23);
            PasswordBox.TabIndex = 12;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(281, 121);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(263, 23);
            UsernameBox.TabIndex = 11;
            // 
            // CreateMovieFm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BackBtn);
            Controls.Add(SignUpBtn);
            Controls.Add(RePasswordBox);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Name = "CreateMovieFm";
            Text = "CreateMovieFm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button BackBtn;
        private Button SignUpBtn;
        private TextBox RePasswordBox;
        private TextBox PasswordBox;
        private TextBox UsernameBox;
    }
}