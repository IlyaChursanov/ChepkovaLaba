namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(89, 193);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(134, 23);
            txtPassword.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(89, 127);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(134, 23);
            txtUsername.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(322, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(26, 127);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(26, 193);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = Properties.Resources._1669151029166658958;
            ClientSize = new Size(719, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.Black;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}