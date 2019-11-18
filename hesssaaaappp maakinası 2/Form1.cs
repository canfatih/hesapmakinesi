using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        int islem = 0;
        double sayi1 = 0, sayi2 = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";// başlangıçta ekrana sıfır yazdıralım.
            textBox1.Text = "0";
        }
        


        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
        }
       
        // çıkarma buttonun click olayı
        private void button19_Click(object sender, EventArgs e)
        {
            islem = 2;
            sayi1 = double.Parse(richTextBox1.Text);
            sifirla();
        }
        // çarpma buttonun click olayı
        private void button14_Click(object sender, EventArgs e)
        {
            islem = 3;
            sayi1 = double.Parse(richTextBox1.Text);
            sifirla();
        }
        // bölme buttonun click olayı
        private void button15_Click(object sender, EventArgs e)
        {
            islem = 4;
            sayi1 = double.Parse(richTextBox1.Text);
            sifirla();
        }
        // eşittir buttonun click olayı
        private void button16_Click(object sender, EventArgs e)
        {
            sayi2 = double.Parse(richTextBox1.Text);
            richTextBox1.Text = hesapla().ToString("#,#.00");
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
                richTextBox1.Text = "";
            richTextBox1.Text += "1";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
                richTextBox1.Text = "";
            richTextBox1.Text += "2";
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
                richTextBox1.Text = "";
            richTextBox1.Text += "3";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "0")
                richTextBox1.Text = "";
            richTextBox1.Text += "4";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "0")
                richTextBox1.Text = "";
            richTextBox1.Text += "5";
        }
        
        private void button8_Click_1(object sender, EventArgs e)
        {
           
            giris_oku("6");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            giris_oku("7");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            giris_oku("8");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            giris_oku("9");
        }
            private void button6_Click_1(object sender, EventArgs e)
        {

            giris_oku("0");
        }

        private void button11_Click_1(object sender, EventArgs e)
        {

            giris_oku(".");
        }
        // toplama buttonun click olayı
        private void button12_Click_1(object sender, EventArgs e)
        {
            islem = 1;
            sayi1 = double.Parse(richTextBox1.Text);
            sifirla();
        }
        public void sifirla()
        {
            richTextBox1.Text = "0";
        }
        //cıkarma
        private void button11_Click(object sender, EventArgs e)
        {
            islem = 2;
            sayi1 = double.Parse(richTextBox1.Text);
            sifirla();
        }
        //çarpma 
        private void button13_Click(object sender, EventArgs e)
        {
            islem = 3;
            sayi1 = double.Parse(richTextBox1.Text);
            sifirla();
        }
        //bölme
        private void button18_Click_1(object sender, EventArgs e)
        {

            islem = 4;
            sayi1 = double.Parse(richTextBox1.Text);
            sifirla();
        }
        //eşittir
        private void button17_Click_1(object sender, EventArgs e)
        {
            sayi2 = double.Parse(richTextBox1.Text);
            richTextBox1.Text = hesapla().ToString("#,#.00");
        }

        private void giris_oku(string buton)
        {
            if (richTextBox1.Text == "0")
                richTextBox1.Text = "";
            richTextBox1.Text += buton;
        }

        public double hesapla()
        {
            double sonuc = 0;

            if (islem == 1)
                sonuc = sayi1 + sayi2;
            else if (islem == 2)
                sonuc = sayi1 - sayi2;
            else if (islem == 3)
                sonuc = sayi1 * sayi2;
            else if (islem == 4)
                sonuc = sayi1 / sayi2;
            else
                sonuc = 0;

            return sonuc;

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            string veri = richTextBox1.Text;
            richTextBox1.Text = "";
            int i;
            for (i = 0; i < veri.Length - 1; i++)
            {
                richTextBox1.Text += veri[i].ToString();
            }
        }

        // en son yazılan rakamı silme butonunun click olayı
        private void button17_Click(object sender, EventArgs e)
        {
            string veri = richTextBox1.Text;
            richTextBox1.Text = "";
            int i;
            for (i = 0; i < veri.Length - 1; i++)
            {
                richTextBox1.Text += veri[i].ToString();
            }
        }
    }
}