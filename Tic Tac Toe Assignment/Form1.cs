namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // Board Buttons -----------------------------------------------------\
        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }





        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }




        public void Form1_Paint(object sender, PaintEventArgs e)
        {

            // Use this part to draw the winnning line

            Graphics g = e.Graphics;
            //System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush;
            g.DrawLine(Pens.Red, 10,10,400,400 );


        }

    }
}
