using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görsel_sınav_soru
{
    public partial class Form1 : Form
    {
        public static int ya = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(textBox1.Text);
            int j = Convert.ToInt16(textBox2.Text);
            int toplam = 0;
            int sayi = i;
            for (int deger = i; deger <= j; deger++)
            {
                sayi = deger;
                while (sayi > 0)
                {
                    toplam = sayi % 10 + toplam;
                    sayi = sayi / 10;

                }

                if (deger % toplam == 0)
                {
                    listBox1.Items.Add(deger.ToString());
                }
                toplam = 0;

            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox3.Text);
            int deger;
            int mete_sayisini = sayi;
            int kontrol = sayi;
            int toplam = 0;

            while (sayi > 0)
            {
                deger = sayi % 8;
                toplam = deger+toplam;
                textBox4.Text = deger.ToString() + textBox4.Text;
                sayi = sayi / 8;
            }
            if (toplam == 13)
            {
                MessageBox.Show(kontrol.ToString() + " mete sayısıdır :)");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Random().Next(0, 10);
            int[] dizi = new int[10];
            for(int i = 0; i < 10; i++)
            {
                textBox1.Text = textBox1.Text + dizi[i];
                textBox2.Text
            }
        }
    }
}




