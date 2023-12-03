using System.Security.Cryptography.X509Certificates;

namespace Lab7
{
    public partial class Form1 : Form
    {
        queues obj = new();
        int n;
        
        public Form1()
        {

            InitializeComponent();
            //сделать фиксированный размер окна формы

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


            // richTextBox1.AppendText("deded");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj = new queues(n);
            obj.GetRes(richTextBox1);
            //richTextBox1.AppendText


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            n = trackBar1.Value;
            label1.Text = Convert.ToString((int)n);
        }

        private void DirectChooseId_CheckedChanged(object sender, EventArgs e)
        {
            Sorts.DirectChooseId(obj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.GetRes(richTextBox2);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}