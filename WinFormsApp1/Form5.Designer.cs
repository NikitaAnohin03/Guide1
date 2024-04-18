namespace WinFormsApp1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._63861a0f55eda1240198449848130673;
            pictureBox1.Location = new Point(-14, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(822, 89);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(275, 37);
            label1.Name = "label1";
            label1.Size = new Size(305, 41);
            label1.TabIndex = 6;
            label1.Text = "Полная информация";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(691, 12);
            button2.Name = "button2";
            button2.Size = new Size(97, 37);
            button2.TabIndex = 15;
            button2.Text = "Выход";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Пенза;
            pictureBox2.Location = new Point(3, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(302, 169);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(339, 91);
            label2.Name = "label2";
            label2.Size = new Size(100, 41);
            label2.TabIndex = 17;
            label2.Text = "Пенза";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(339, 132);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 18;
            label3.Text = "Описание:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(339, 163);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(264, 158);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(47, 390);
            button1.Name = "button1";
            button1.Size = new Size(110, 39);
            button1.TabIndex = 20;
            button1.Text = "Досуг";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(511, 390);
            button3.Name = "button3";
            button3.Size = new Size(254, 39);
            button3.TabIndex = 21;
            button3.Text = "Достопримечательности";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button2;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox3;
        private Button button1;
        private Button button3;
    }
}