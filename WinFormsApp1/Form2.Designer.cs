namespace WinFormsApp1
{
    partial class Form2
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._63861a0f55eda1240198449848130673;
            pictureBox1.Location = new Point(-9, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(822, 89);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(306, 32);
            label1.Name = "label1";
            label1.Size = new Size(188, 41);
            label1.TabIndex = 3;
            label1.Text = "Регистрация";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HotTrack;
            textBox1.Font = new Font("Segoe UI", 18F);
            textBox1.Location = new Point(113, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 47);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.HotTrack;
            textBox2.Font = new Font("Segoe UI", 18F);
            textBox2.Location = new Point(528, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 47);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.HotTrack;
            textBox3.Font = new Font("Segoe UI", 18F);
            textBox3.Location = new Point(113, 279);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 47);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.HotTrack;
            textBox4.Font = new Font("Segoe UI", 18F);
            textBox4.Location = new Point(528, 279);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(158, 47);
            textBox4.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(113, 248);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 8;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(528, 248);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 9;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(113, 140);
            label4.Name = "label4";
            label4.Size = new Size(51, 28);
            label4.TabIndex = 10;
            label4.Text = "Имя";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(528, 140);
            label5.Name = "label5";
            label5.Size = new Size(96, 28);
            label5.TabIndex = 11;
            label5.Text = "Фамилия";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(294, 387);
            button2.Name = "button2";
            button2.Size = new Size(209, 39);
            button2.TabIndex = 13;
            button2.Text = "Зарегистрироваться";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
    }
}