﻿namespace MovieDotMeV1.Forms
{
    partial class WelcomeFm
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
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            SignInBtn = new Button();
            ExitBtn = new Button();
            SignUpBtn = new Button();
            SuspendLayout();
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(288, 103);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(263, 23);
            UsernameBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(288, 143);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(263, 23);
            PasswordBox.TabIndex = 1;
            // 
            // SignInBtn
            // 
            SignInBtn.Location = new Point(288, 172);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(75, 23);
            SignInBtn.TabIndex = 2;
            SignInBtn.Text = "SignIn";
            SignInBtn.UseVisualStyleBackColor = true;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(476, 172);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(75, 23);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // SignUpBtn
            // 
            SignUpBtn.Location = new Point(381, 172);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(75, 23);
            SignUpBtn.TabIndex = 4;
            SignUpBtn.Text = "SignUp";
            SignUpBtn.UseVisualStyleBackColor = true;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // WelcomeFm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SignUpBtn);
            Controls.Add(ExitBtn);
            Controls.Add(SignInBtn);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Name = "WelcomeFm";
            Text = "WelcomeFm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Button SignInBtn;
        private Button ExitBtn;
        private Button SignUpBtn;
    }
}