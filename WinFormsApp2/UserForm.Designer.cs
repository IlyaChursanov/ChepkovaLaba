namespace WinFormsApp2
{
    partial class UserForm
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
            textbox1 = new TextBox();
            textbox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textbox1
            // 
            textbox1.Location = new Point(58, 66);
            textbox1.Name = "textbox1";
            textbox1.Size = new Size(100, 23);
            textbox1.TabIndex = 0;
            // 
            // textbox2
            // 
            textbox2.Location = new Point(28, 131);
            textbox2.Multiline = true;
            textbox2.Name = "textbox2";
            textbox2.Size = new Size(170, 298);
            textbox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(320, 66);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(320, 110);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Заявки";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(320, 150);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Выход";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textbox2);
            Controls.Add(textbox1);
            Name = "UserForm";
            Text = "UserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textbox1;
        private TextBox textbox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}