using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace INPUTBOX_GİRİS_PENCERESİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // INPUTBOX = veri girişi amacı ile kullanılan giriş pencereleridir.bir değişkene atanarak kullanılırlar.
            // kullanım şekli = inputbox("görüntülenecek olan mesaj","pencere başlığı","varsayılan mesaj",x pozisyonu,y pozisyou)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte notu;
            notu = Convert.ToByte(Interaction.InputBox("notu girin", "not girişi", "100", 30, 10));
            label2.Text = notu.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // girilen 2 değerin ortalamasını aldık 

            byte not1 = Convert.ToByte(Interaction.InputBox("notu girin", "not girişi", "100", 150, 150));
            byte not2 = Convert.ToByte(Interaction.InputBox("notu girin", "not girişi", "100", 20, 10));

            label3.Text = not1.ToString();
            label6.Text = not2.ToString();

            int ortalama=(not1 + not2) / 2;

            label7.Text = ortalama.ToString();
        }

       
    }
}
