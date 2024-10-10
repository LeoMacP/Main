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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label1 = new Label();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold);
            button1.Location = new Point(553, 52);
            button1.Name = "button1";
            button1.Size = new Size(149, 51);
            button1.TabIndex = 1;
            button1.Text = "Properties";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold);
            button2.Location = new Point(553, 127);
            button2.Name = "button2";
            button2.Size = new Size(149, 51);
            button2.TabIndex = 2;
            button2.Text = "New Game";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold);
            button3.Location = new Point(553, 194);
            button3.Name = "button3";
            button3.Size = new Size(149, 51);
            button3.TabIndex = 3;
            button3.Text = "Hint";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold);
            button4.Location = new Point(553, 273);
            button4.Name = "button4";
            button4.Size = new Size(149, 51);
            button4.TabIndex = 4;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold);
            button5.Location = new Point(553, 344);
            button5.Name = "button5";
            button5.Size = new Size(149, 51);
            button5.TabIndex = 5;
            button5.Text = "Load Game";
            button5.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold);
            checkBox1.Location = new Point(195, 414);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Level 0";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold);
            checkBox2.Location = new Point(295, 414);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(78, 24);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "Level 1";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold);
            checkBox3.Location = new Point(381, 414);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(81, 24);
            checkBox3.TabIndex = 8;
            checkBox3.Text = "Level 2";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 20F, FontStyle.Bold);
            label1.Location = new Point(125, 14);
            label1.Name = "label1";
            label1.Size = new Size(279, 35);
            label1.TabIndex = 9;
            label1.Text = "It's TicTacToe Time!!!";
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Tempus Sans ITC", 36F, FontStyle.Bold);
            button6.Location = new Point(279, 16);
            button6.Name = "button6";
            button6.Size = new Size(134, 104);
            button6.TabIndex = 9;
            button6.Text = "2";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Tempus Sans ITC", 36F, FontStyle.Bold);
            button7.Location = new Point(146, 16);
            button7.Name = "button7";
            button7.Size = new Size(127, 104);
            button7.TabIndex = 10;
            button7.Text = "1";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Cursor = Cursors.Hand;
            button8.Font = new Font("Tempus Sans ITC", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(6, 16);
            button8.Name = "button8";
            button8.Size = new Size(134, 104);
            button8.TabIndex = 11;
            button8.Text = "0";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Cursor = Cursors.Hand;
            button9.Font = new Font("Tempus Sans ITC", 36F, FontStyle.Bold);
            button9.Location = new Point(6, 126);
            button9.Name = "button9";
            button9.Size = new Size(134, 104);
            button9.TabIndex = 12;
            button9.Text = "3";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Cursor = Cursors.Hand;
            button10.Font = new Font("Tempus Sans ITC", 36F, FontStyle.Bold);
            button10.Location = new Point(146, 126);
            button10.Name = "button10";
            button10.Size = new Size(127, 104);
            button10.TabIndex = 13;
            button10.Text = "4";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Cursor = Cursors.Hand;
            button11.Font = new Font("Tempus Sans ITC", 36F, FontStyle.Bold);
            button11.Location = new Point(279, 126);
            button11.Name = "button11";
            button11.Size = new Size(134, 104);
            button11.TabIndex = 14;
            button11.Text = "5";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Cursor = Cursors.Hand;
            button12.Font = new Font("Tempus Sans ITC", 36F, FontStyle.Bold);
            button12.Location = new Point(6, 236);
            button12.Name = "button12";
            button12.Size = new Size(134, 101);
            button12.TabIndex = 15;
            button12.Text = "6";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Cursor = Cursors.Hand;
            button13.Font = new Font("Tempus Sans ITC", 36F, FontStyle.Bold);
            button13.Location = new Point(146, 236);
            button13.Name = "button13";
            button13.Size = new Size(127, 101);
            button13.TabIndex = 16;
            button13.Text = "7";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Cursor = Cursors.Hand;
            button14.Font = new Font("Tempus Sans ITC", 36F, FontStyle.Bold);
            button14.Location = new Point(279, 236);
            button14.Name = "button14";
            button14.Size = new Size(134, 101);
            button14.TabIndex = 17;
            button14.Text = "8";
            button14.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
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
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(420, 350);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tempus Sans ITC", 16F, FontStyle.Bold);
            label2.Location = new Point(55, 410);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 10;
            label2.Text = "Difficulty:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Tic Tac Toe";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label1;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private GroupBox groupBox1;
        private Label label2;
    }
}
