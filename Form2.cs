using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mail
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для того, чтобы создать аккаунт в ВК или другой соцсети, необходимо вписать данные своей кредитной карты и пароль(хаххахахахахахахаха)", "Очень нужная инфа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("А никуда!!! Это приложение нерабочее!!!", "Очень нужная инфа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для этого зайдите в пункт 'Регистрация' в верхней части, дальше раздел 'Тип' и выбираем нужную соцсеть. Правда, выбор невелик, да и наша программа просто пошлет тебя на три веселые буквы) ", "Очень нужная инфа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("А ничего ни надо делать!\n1.Данная прога не работает\n2. Мы написали программу так, что когда ты вводишь пароль или почту с цифрами, то она не будет принимать тебя", "Очень нужная инфа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
