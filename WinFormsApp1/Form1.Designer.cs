namespace WinFormsApp1
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
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(button14);
            groupBox1.Controls.Add(button13);
            groupBox1.Controls.Add(button12);
            groupBox1.Controls.Add(button11);
            groupBox1.Controls.Add(button10);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Location = new Point(49, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 343);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "It's TicTacToe TIME!";
            // 
            // button8
            // 
            button8.Location = new Point(0, 16);
            button8.Name = "button8";
            button8.Size = new Size(134, 104);
            button8.TabIndex = 11;
            button8.Text = "1";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Cross;
            button7.Font = new Font("Impact", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(140, 16);
            button7.Name = "button7";
            button7.Size = new Size(140, 104);
            button7.TabIndex = 10;
            button7.Text = "2";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 8.25F);
            button6.Location = new Point(286, 16);
            button6.Name = "button6";
            button6.Size = new Size(134, 104);
            button6.TabIndex = 9;
            button6.Text = "3";
            button6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(553, 52);
            button1.Name = "button1";
            button1.Size = new Size(149, 51);
            button1.TabIndex = 1;
            button1.Text = "properties";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(553, 127);
            button2.Name = "button2";
            button2.Size = new Size(149, 51);
            button2.TabIndex = 2;
            button2.Text = "New Game";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(553, 194);
            button3.Name = "button3";
            button3.Size = new Size(149, 51);
            button3.TabIndex = 3;
            button3.Text = "Hint";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(553, 273);
            button4.Name = "button4";
            button4.Size = new Size(149, 51);
            button4.TabIndex = 4;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(553, 344);
            button5.Name = "button5";
            button5.Size = new Size(149, 51);
            button5.TabIndex = 5;
            button5.Text = "Open";
            button5.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(149, 419);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(62, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Level 0";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(233, 419);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(62, 19);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "Level 1";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(310, 419);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(62, 19);
            checkBox3.TabIndex = 8;
            checkBox3.Text = "Level 2";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Cursor = Cursors.Cross;
            button9.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button9.Location = new Point(140, 126);
            button9.Name = "button9";
            button9.Size = new Size(140, 104);
            button9.TabIndex = 12;
            button9.Text = "2";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Cursor = Cursors.Cross;
            button10.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button10.Location = new Point(140, 236);
            button10.Name = "button10";
            button10.Size = new Size(140, 104);
            button10.TabIndex = 13;
            button10.Text = "2";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Font = new Font("Microsoft Sans Serif", 8.25F);
            button11.Location = new Point(286, 126);
            button11.Name = "button11";
            button11.Size = new Size(134, 104);
            button11.TabIndex = 14;
            button11.Text = "3";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Font = new Font("Microsoft Sans Serif", 8.25F);
            button12.Location = new Point(286, 236);
            button12.Name = "button12";
            button12.Size = new Size(134, 104);
            button12.TabIndex = 15;
            button12.Text = "3";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(0, 126);
            button13.Name = "button13";
            button13.Size = new Size(134, 104);
            button13.TabIndex = 16;
            button13.Text = "1";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(0, 236);
            button14.Name = "button14";
            button14.Size = new Size(134, 104);
            button14.TabIndex = 17;
            button14.Text = "1";
            button14.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
    }
}
