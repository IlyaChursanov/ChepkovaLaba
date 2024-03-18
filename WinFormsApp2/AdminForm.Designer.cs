namespace WinFormsApp2
{
    partial class AdminForm
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
            this.dataGridViewRepairs = new System.Windows.Forms.DataGridView();
            this.txtEquipment = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtProblemDescription = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtFaultType = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepairs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRepairs
            // 
            this.dataGridViewRepairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRepairs.Location = new System.Drawing.Point(12, 32);
            this.dataGridViewRepairs.Name = "dataGridViewRepairs";
            this.dataGridViewRepairs.Size = new System.Drawing.Size(755, 406);
            this.dataGridViewRepairs.TabIndex = 0;
            // 
            // txtEquipment
            // 
            this.txtEquipment.Location = new System.Drawing.Point(783, 44);
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.Size = new System.Drawing.Size(209, 20);
            this.txtEquipment.TabIndex = 1;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(783, 224);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(209, 20);
            this.txtStatus.TabIndex = 3;
            // 
            // txtProblemDescription
            // 
            this.txtProblemDescription.Location = new System.Drawing.Point(783, 132);
            this.txtProblemDescription.Name = "txtProblemDescription";
            this.txtProblemDescription.Size = new System.Drawing.Size(209, 20);
            this.txtProblemDescription.TabIndex = 4;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(783, 177);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(209, 20);
            this.txtClient.TabIndex = 5;
            // 
            // txtFaultType
            // 
            this.txtFaultType.Location = new System.Drawing.Point(783, 86);
            this.txtFaultType.Name = "txtFaultType";
            this.txtFaultType.Size = new System.Drawing.Size(209, 20);
            this.txtFaultType.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(783, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Получить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(783, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Заявки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(780, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Устройство:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(780, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Неисправность:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(780, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Описание проблемы:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(780, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Клиет:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(780, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Статус:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(783, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 39);
            this.button3.TabIndex = 15;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFaultType);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.txtProblemDescription);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtEquipment);
            this.Controls.Add(this.dataGridViewRepairs);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepairs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRepairs;
        private System.Windows.Forms.TextBox txtEquipment;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtProblemDescription;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtFaultType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
    }
}