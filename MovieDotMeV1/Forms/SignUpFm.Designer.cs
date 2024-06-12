namespace MovieDotMeV1.Forms
{
    partial class SignUpFm
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
            PasswordBox = new TextBox();
            UsernameBox = new TextBox();
            RePasswordBox = new TextBox();
            SignUpBtn = new Button();
            BackBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(266, 148);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(263, 23);
            PasswordBox.TabIndex = 3;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(266, 108);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(263, 23);
            UsernameBox.TabIndex = 2;
            // 
            // RePasswordBox
            // 
            RePasswordBox.Location = new Point(266, 186);
            RePasswordBox.Name = "RePasswordBox";
            RePasswordBox.Size = new Size(263, 23);
            RePasswordBox.TabIndex = 5;
            // 
            // SignUpBtn
            // 
            SignUpBtn.Location = new Point(266, 215);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(75, 23);
            SignUpBtn.TabIndex = 6;
            SignUpBtn.Text = "SignUp";
            SignUpBtn.UseVisualStyleBackColor = true;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(454, 215);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 7;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 156);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 9;
            label2.Text = "password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 111);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 8;
            label1.Text = "username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 194);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 10;
            label3.Text = "password";
            // 
            // SignUpFm
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
            Name = "SignUpFm";
            Text = "SignUpFm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PasswordBox;
        private TextBox UsernameBox;
        private TextBox RePasswordBox;
        private Button SignUpBtn;
        private Button BackBtn;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}