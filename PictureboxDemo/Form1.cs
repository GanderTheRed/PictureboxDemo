namespace PictureboxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Code to allow a hidden picture box to show itself and hide others
            picBestGame1.Visible = true;
            picAverageGame1.Visible = false;
            picWorstGame1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Allows a value to switch
            // picAverageGame1.Visible = !picAverageGame1.Visible;
            picBestGame1.Visible = false;
            picAverageGame1.Visible = true;
            picWorstGame1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            picBestGame1.Visible = false;
            picAverageGame1.Visible = false;
            picWorstGame1.Visible = true;
        }

    }
}