namespace CarBuilder
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
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            button3 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(55, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 306);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color GroupBox";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(44, 166);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(45, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Red";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(44, 129);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(48, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Blue";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(23, 38);
            button1.Name = "button1";
            button1.Size = new Size(202, 59);
            button1.TabIndex = 0;
            button1.Text = "Show Color";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(55, 379);
            button2.Name = "button2";
            button2.Size = new Size(707, 59);
            button2.TabIndex = 1;
            button2.Text = "Say Something About Car";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(333, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(252, 306);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Car GroupBox";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(40, 118);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(62, 19);
            radioButton5.TabIndex = 5;
            radioButton5.TabStop = true;
            radioButton5.Text = "Porche";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(40, 78);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(61, 19);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "Honda";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(40, 38);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(50, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Tesla";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // button3
            // 
            button3.Location = new Point(27, 194);
            button3.Name = "button3";
            button3.Size = new Size(198, 59);
            button3.TabIndex = 0;
            button3.Text = "Show Car";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(634, 72);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(96, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "With Sunroof";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(634, 113);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(51, 19);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "4WD";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "My Car Builder";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox2;
        private Button button3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}
