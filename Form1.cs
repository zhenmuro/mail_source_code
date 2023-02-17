using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace mail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ^ textBox1.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Введите адрес эл.почты", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (textBox2.Text == "" ^ textBox2.Text.Any(char.IsDigit))
                
                    MessageBox.Show("Введите пароль", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
      


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "Скрыть пароль";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Это не работает)))))))";
            notifyIcon1.BalloonTipTitle = "АШИПКА!!!!";
            notifyIcon1.ShowBalloonTip(3);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;

        }

        private void поддержкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void boostyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://boosty.to/artosik");
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("А вот это низя!", "АШИПКА!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void twichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("А вот это низя!", "АШИПКА!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void oBSStudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("А вот это низя!", "АШИПКА!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ютубКаналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com/@artosik");
        }

        private void задонатитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void appleIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("А вот это низя!", "АШИПКА!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void телегаАвтораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/windowsshindowsnet");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void вКонтактеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("А зачем ты сюда нажимал? Это же всеравно нерабочая функция!", "АШИПКА!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void перейтиВВКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com");
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void подробнееОРегистрацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
