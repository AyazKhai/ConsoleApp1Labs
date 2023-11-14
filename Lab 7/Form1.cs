using Lab7;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace Lab_7
{
    public partial class Form1 : Form
    {
        int n;
        bool IsEmpty;
        bool IsSortChosen = false;
        public Form1()
        {
            InitializeComponent();
            domainUpDown1.SelectedIndex = 0;


        }


        queues objq = new queues(0);
        private void QueueNText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            // передаем ссылку на кнопку в форму Form2
            try { n = Convert.ToInt32(QueueNText.Text); } catch { MessageBox.Show("Введите значение"); }
            

            if (n == 0 || n > 30)
            {
                MessageBox.Show("Недопустимое значение");
            }
            else
            {
                richTextBox1.Clear();
                richTextBox2.Clear();
                objq = new queues(n);
                objq.GetRes(richTextBox1);
                IsEmpty = false;
            }
        }

        private void QueueNText_MouseClick(object sender, MouseEventArgs e)
        {
            QueueNText.Text = null;
        }
        ///
        private void DirectChooseId_CheckedChanged(object sender, EventArgs e)
        {

            Bubby.Checked = false;
            DirectConnection.Checked = false;
            Shaker.Checked = false;
            Shall.Checked = false;
            IsSortChosen = true;
        }
        private void Bubby_CheckedChanged(object sender, EventArgs e)
        {

            DirectChoose.Checked = false;
            DirectConnection.Checked = false;
            Shaker.Checked = false;
            Shall.Checked = false;
            IsSortChosen = true;
        }
        private void DirectConnection_CheckedChanged(object sender, EventArgs e)
        {
            Bubby.Checked = false;
            DirectChoose.Checked = false;
            Shaker.Checked = false;
            Shall.Checked = false;
            IsSortChosen = true;
        }
        private void Shaker_CheckedChanged(object sender, EventArgs e)
        {
            Bubby.Checked = false;
            DirectChoose.Checked = false;
            DirectConnection.Checked = false;
            Shall.Checked = false;
            IsSortChosen = true;
        }

        private void Shall_CheckedChanged(object sender, EventArgs e)
        {
            Bubby.Checked = false;
            DirectChoose.Checked = false;
            Shaker.Checked = false;
            DirectConnection.Checked = false;
            IsSortChosen = true;
        }
        ///

        private void sort_button_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            if (IsSortChosen)
            {
                if (DirectChoose.Checked == true && domainUpDown1.SelectedIndex == 0)
                {
                    Sorts.DirectChooseId(objq);
                    objq.GetRes(richTextBox2);
                    TimeLabel.Text = Sorts.Time.ToString();
                }
                else if (DirectChoose.Checked == true && domainUpDown1.SelectedIndex == 1)
                {
                    Sorts.DirectChooseFirm(objq);
                    objq.GetRes(richTextBox2);
                    TimeLabel.Text = Sorts.Time.ToString();
                }
                else if (Bubby.Checked == true && domainUpDown1.SelectedIndex == 0)
                {
                    Sorts.BubblyId(objq);
                    objq.GetRes(richTextBox2);
                    TimeLabel.Text = Sorts.Time.ToString();
                }
                else if (Bubby.Checked == true && domainUpDown1.SelectedIndex == 1)
                {
                    Sorts.BubblyFirm(objq);
                    objq.GetRes(richTextBox2);
                    TimeLabel.Text = Sorts.Time.ToString();
                }
                else if (DirectConnection.Checked == true && domainUpDown1.SelectedIndex == 0)
                {
                    Sorts.DirectConnectionId(objq);
                    objq.GetRes(richTextBox2);
                    TimeLabel.Text = Sorts.Time.ToString();
                }
                else if (DirectConnection.Checked == true && domainUpDown1.SelectedIndex == 1)
                {
                    Sorts.DirectConnectionFirm(objq);
                    objq.GetRes(richTextBox2);
                    TimeLabel.Text = Sorts.Time.ToString();
                }
                else if (Shaker.Checked == true && domainUpDown1.SelectedIndex == 0)
                {
                    Sorts.ShakerSortId(objq);
                    objq.GetRes(richTextBox2);
                    TimeLabel.Text = Sorts.Time.ToString();
                }
                else if (Shaker.Checked == true && domainUpDown1.SelectedIndex == 1)
                {
                    Sorts.ShakerSortFirm(objq);
                    objq.GetRes(richTextBox2);
                    TimeLabel.Text = Sorts.Time.ToString();
                }
                else if (Shall.Checked == true && domainUpDown1.SelectedIndex == 0)
                {
                    Sorts.ShallSortId(objq);
                    objq.GetRes(richTextBox2);
                    TimeLabel.Text = Sorts.Time.ToString();
                }
                else if (Shall.Checked == true && domainUpDown1.SelectedIndex == 1)
                {
                    Sorts.ShallSortFirm(objq);
                    objq.GetRes(richTextBox2);
                    TimeLabel.Text = Sorts.Time.ToString();
                }
            }
            else
            {
                MessageBox.Show("выберите метод сортировки");
            }
        }
        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void DirectChoose_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void DirectChoose_Click(object sender, EventArgs e)
        {

        }
        BinaryFormatter sw = new BinaryFormatter();
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
           ofd.Filter = "TXT (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                {

                    while (fs.Position < fs.Length)
                    {
                        objq = (queues)sw.Deserialize(fs);
                        n = (int)sw.Deserialize(fs);
                        IsEmpty = (bool)sw.Deserialize(fs);
                        IsSortChosen = (bool)sw.Deserialize(fs);


                    }
                }
            }
            QueueNText.Text = n.ToString();
            objq.GetRes(richTextBox1);
           
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            BinaryFormatter sw = new BinaryFormatter();
            SFD.Filter = "TXT (*.txt)|*.txt";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(SFD.FileName, FileMode.Create, FileAccess.Write))
                {
                    sw.Serialize(fs, objq);
                    sw.Serialize(fs, n);
                    sw.Serialize(fs, IsEmpty);
                    sw.Serialize(fs, IsSortChosen);

                }

            }


        }

        private void QueueNText_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}