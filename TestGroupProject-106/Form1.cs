namespace TestGroupProject_106
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int b = 100;
        private void button1_Click(object sender, EventArgs e)
        {
            Shushkanov S = new Shushkanov();
            S.explode(69,panel1);
        }
    }
}