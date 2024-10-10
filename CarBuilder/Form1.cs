namespace CarBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Group Box 1 - Color
        //Show color
        private void button1_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; if (clickedButton != null)
            {
                MessageBox.Show("You clicked " + clickedButton.Name);
            }
        }
        //Blue
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton; if (radioButton.Checked)
            {
                MessageBox.Show(radioButton.Text + " is selected.");
            }
        }
        //Red
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton; if (radioButton.Checked)
            {
                MessageBox.Show(radioButton.Text + " is selected.");
            }
        }


        //GroupBox 2 - Car
        //Tesla
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton; if (radioButton.Checked)
            {
                MessageBox.Show(radioButton.Text + " is selected.");
            }

        }
        //Honda
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton; if (radioButton.Checked)
            {
                MessageBox.Show(radioButton.Text + " is selected.");
            }
        }
        // Porche
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton; if (radioButton.Checked) { 
                MessageBox.Show(radioButton.Text + " is selected."); 
            }

        }
        //Show Car
        private void button3_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; if (clickedButton != null)
            {
                MessageBox.Show("You clicked " + clickedButton.Name);
            }
        }

        //Say Something About Car
        private void button2_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null) { 
                MessageBox.Show("You clicked " + clickedButton.Name);

                
            }

            switch (clickedButton)
            {
                case radioButton3.Text = "Tesla":
                    break;

                case "Honda":
                    break;

                case "Porche":
                    break;
            }

        }


        //Outside:
        //Sunroof
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; if (checkBox.Checked) {
                MessageBox.Show(checkBox.Text + " is checked.");
            }
        }

        //4WD
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; if (checkBox.Checked) 
            { MessageBox.Show(checkBox.Text + " is checked."); 
            }
        }
    }
}
