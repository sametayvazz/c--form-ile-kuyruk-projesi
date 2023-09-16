using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuyrukProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class dugum
        {
            public int sayi;
            public string ad,ad1,ad2,ad3;
            public dugum baglanti;
            
        }
        dugum ilk_yigin_dugum;
        dugum on_kuyruk , arka_kuyruk;
      

        private void button1_Click(object sender, EventArgs e)
        {
            
            dugum yeni = new dugum();
            yeni.baglanti = ilk_yigin_dugum;
            yeni.ad = textBox1.Text;
            ilk_yigin_dugum = yeni;
            islemci.Start();
            

        }
        private void button2_Click(object sender, EventArgs e)
        {
            islemci.Stop();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dugum yeni = new dugum();
            yeni.ad = textBox1.Text;
            if (checkBox1.Checked==true)
            {
                for (int i = 0; i < yeni.ad.Length; i++)
                {
                    textBox5.Text += yeni.ad1;
                }
            }
            if (checkBox2.Checked==true)
            {

            }
            if (checkBox3.Checked==true)
            {

            }

            yiginGoster();
        }

        private void yiginGoster()
        {            
            textBox5.Text = null;
            if (ilk_yigin_dugum == null)
            {
                MessageBox.Show("İşlemciyi Başlatmadınız!!");
                return;
            }
            else
            {
                dugum gecici = ilk_yigin_dugum;
                while (gecici != null)
                {
                   
                    textBox5.Text += gecici.ad+ "\r\n";
                    gecici = gecici.baglanti;
                    textBox5.Text += "*****************************" + "\r\n";
                }
            }
        }
       
        private void kuyrukGoster()
        {            
           
            textBox1.Text = null;
            if (arka_kuyruk == null)
            {
                MessageBox.Show("Kuyrukta Gösterilecek Eleman Bulunamadı!");
                return;
            }
            else
            {
                dugum gecici = on_kuyruk;               
                while (gecici != null)
                {
                    
                    textBox1.Text += gecici.ad1+gecici.ad2+gecici.ad3;                
                    gecici = gecici.baglanti;
                    

                }
                
            }
        }
        private void islemci_Tick(object sender, EventArgs e)
        {
            dugum yeni = new dugum();
            
            if (on_kuyruk == null)
            {
                on_kuyruk = arka_kuyruk = yeni;
            }
            else
            {
                arka_kuyruk.baglanti = yeni;
                arka_kuyruk = yeni;
            }
            kuyrukGoster();
        }

        private void p1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();            
            txb_p1.Text += "P1-" +rnd.Next(1,6)+"-->" ;
            dugum yeni = new dugum();
            yeni.ad1 = txb_p1.Text;         
            
            if (on_kuyruk == null)
            {
                on_kuyruk = arka_kuyruk = yeni;
            }
            else
            {
                arka_kuyruk.baglanti = yeni;
                arka_kuyruk = yeni;
            }

        }
        private void p2_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();            
            txb_p2.Text ="P2-" + rnd.Next(1, 6)+ "-->" ;
            dugum yeni = new dugum();           
            yeni.ad2 = txb_p2.Text;            

            if (on_kuyruk == null)
            {
                on_kuyruk = arka_kuyruk = yeni;
            }
            else
            {
                arka_kuyruk.baglanti = yeni;
                arka_kuyruk = yeni;
            }
        }    

        private void p3_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();            
            txb_p3.Text = "P3-" + rnd.Next(1, 6)+ "-->" ;
            dugum yeni = new dugum();          
            yeni.ad3 = txb_p3.Text;

            if (on_kuyruk == null)
            {
                on_kuyruk = arka_kuyruk = yeni;
            }
            else
            {
                arka_kuyruk.baglanti = yeni;
                arka_kuyruk = yeni;
            }
        }
        private void islemci_kntrl_Scroll(object sender, EventArgs e)
        {
            int hiz = islemci_kntrl.Value;
            islemci.Interval = 1000 / hiz;

        }

        private void p1_kntrol_Scroll(object sender, EventArgs e)
        {

            int hiz = p1_kntrol.Value;
            p1.Interval = 1000 / hiz;


        }

        private void p2_kntrol_Scroll(object sender, EventArgs e)
        {
            int hiz = p2_kntrol.Value;
            p2.Interval = 1000 / hiz;
        }

        

        private void p3_kntrol_Scroll(object sender, EventArgs e)
        {
            int hiz = p3_kntrol.Value;
            p3.Interval = 1000 / hiz;
        }

    }
}
