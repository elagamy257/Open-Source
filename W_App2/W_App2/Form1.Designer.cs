﻿namespace W_App2
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources._6;
            button1.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(566, 330);
            button1.Name = "button1";
            button1.Size = new Size(178, 82);
            button1.TabIndex = 0;
            button1.Text = "سبحان الله";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(645, 272);
            label1.Name = "label1";
            label1.Size = new Size(27, 29);
            label1.TabIndex = 1;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(420, 272);
            label2.Name = "label2";
            label2.Size = new Size(27, 29);
            label2.TabIndex = 3;
            label2.Text = "0";
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources._6;
            button2.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(341, 330);
            button2.Name = "button2";
            button2.Size = new Size(178, 82);
            button2.TabIndex = 2;
            button2.Text = "الحمد لله";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(184, 272);
            label3.Name = "label3";
            label3.Size = new Size(27, 29);
            label3.TabIndex = 5;
            label3.Text = "0";
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources._6;
            button3.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(106, 330);
            button3.Name = "button3";
            button3.Size = new Size(178, 82);
            button3.TabIndex = 4;
            button3.Text = "لا اله الا الله";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(566, 125);
            label4.Name = "label4";
            label4.Size = new Size(27, 29);
            label4.TabIndex = 6;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(645, 125);
            label5.Name = "label5";
            label5.Size = new Size(134, 29);
            label5.TabIndex = 7;
            label5.Text = ": اجمالي التسبيح";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._6;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "مسبحة";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Button button3;
        private Label label4;
        private Label label5;
    }
}
