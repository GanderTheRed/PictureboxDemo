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
            picBestGame1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picAverageGame1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            picWorstGame1.Visible = true;
        }
    }
}