namespace MovieDotMeV1.Forms
{
    partial class AdminFm
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
            label2 = new Label();
            label1 = new Label();
            PasswordBox = new TextBox();
            UsernameBox = new TextBox();
            BackBtn = new Button();
            SignInBtn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 178);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 13;
            label2.Text = "password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 133);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 12;
            label1.Text = "username";
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(284, 170);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(263, 23);
            PasswordBox.TabIndex = 11;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(284, 130);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(263, 23);
            UsernameBox.TabIndex = 10;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(472, 199);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 15;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // SignInBtn
            // 
            SignInBtn.Location = new Point(284, 199);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(75, 23);
            SignInBtn.TabIndex = 14;
            SignInBtn.Text = "SignIn";
            SignInBtn.UseVisualStyleBackColor = true;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // AdminFm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackBtn);
            Controls.Add(SignInBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Name = "AdminFm";
            Text = "AdminFm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox PasswordBox;
        private TextBox UsernameBox;
        private Button BackBtn;
        private Button SignInBtn;
    }
}