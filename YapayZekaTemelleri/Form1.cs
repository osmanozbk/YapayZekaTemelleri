using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;
using System.Speech.Recognition;

namespace YapayZekaTemelleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ProductList()
        {
            var products=db.TBLPRODUCT.ToList();
            dataGridView1.DataSource = products;
        }

        void enabled()
        {
            TxtBuyPrice.Enabled = false;
            TxtName.Enabled = false;
            TxtMark.Enabled = false;
            TxtStock.Enabled = false;
            TxtCategory.Enabled = false;
            TxtSellPrice.Enabled = false;
            maskedTextBox1.Enabled = false;
            comboBox1.Enabled = false;
        }

        void colormethod()
        {
            TxtBuyPrice.BackColor = Color.White;
            TxtName.BackColor = Color.White;
            TxtMark.BackColor = Color.White;
            TxtStock.BackColor = Color.White;
            TxtCategory.BackColor = Color.White;
            TxtSellPrice.BackColor = Color.White;
            maskedTextBox1.BackColor = Color.White;
            comboBox1.BackColor = Color.White;
        }

        DbProductArtEntities db = new DbProductArtEntities();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSpeak_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
            Grammar g = new DictationGrammar();
            sr.LoadGrammar(g);

            try
            {
                BtnSpeak.Text = "Please speak";
                sr.SetInputToDefaultAudioDevice();
                RecognitionResult res = sr.Recognize();
                richTextBox1.Text = res.Text;
            }
            catch (Exception) 
            {
                BtnSpeak.Text = "Error Try Again";
            }
        }

        private void BtnListen_Click(object sender, EventArgs e)
        {
            SpVoice ses = new SpVoice();
            ses.Speak(richTextBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "List all products" || richTextBox1.Text == "Products lits")
            {
                ProductList();

            }

            if(richTextBox1.Text=="Add" || richTextBox1.Text == "Add to")
            {
                TBLPRODUCT t = new TBLPRODUCT();
                t.NAME = TxtName.Text;
                t.BRAND = TxtMark.Text;
                t.SELLPRICE = decimal.Parse(TxtSellPrice.Text);
                t.BUYPRICE = decimal.Parse(TxtBuyPrice.Text);
                t.STOCK = short.Parse(TxtStock.Text);
                t.PRODUCTCASE = true;
                t.DATEADDPRO = DateTime.Parse(maskedTextBox1.Text);
                t.CATEGORY = TxtCategory.Text;
                db.TBLPRODUCT.Add(t);
                db.SaveChanges();
                label10.Text = "Products Saved in Database";
            }

            //sonrasında switch case ile düzenlenecek
            if (TxtName.BackColor == Color.Yellow && TxtName.Enabled == true)
            {
                TxtName.Text = richTextBox1.Text;
                enabled();
                colormethod();
            }

            if (TxtMark.BackColor == Color.Yellow && TxtMark.Enabled == true)
            {
                TxtMark.Text = richTextBox1.Text;
                enabled();
                colormethod();
            }

            if (TxtStock.BackColor == Color.Yellow && TxtStock.Enabled == true)
            {
                TxtStock.Text = richTextBox1.Text;
                enabled();
                colormethod();
            }

            if (TxtBuyPrice.BackColor == Color.Yellow && TxtBuyPrice.Enabled == true)
            {
                TxtBuyPrice.Text = richTextBox1.Text;
                enabled();
                colormethod();
            }

            if (TxtSellPrice.BackColor == Color.Yellow && TxtSellPrice.Enabled == true)
            {
                TxtSellPrice.Text = richTextBox1.Text;
                enabled();
                colormethod();
            }

            if (TxtCategory.BackColor == Color.Yellow && TxtCategory.Enabled == true)
            {
                TxtCategory.Text = richTextBox1.Text;
                enabled();
                colormethod();
            }

            if (maskedTextBox1.BackColor == Color.Yellow && maskedTextBox1.Enabled == true)
            {
                enabled();
                colormethod();
            }

            if (comboBox1.BackColor == Color.Yellow && comboBox1.Enabled == true)
            {
                comboBox1.Text = "Active";
                enabled();
                colormethod();
            }

            if (richTextBox1.Text == "Products name" || richTextBox1.Text == "Products" || richTextBox1.Text == "Product" 
                || richTextBox1.Text == "Name")
            {
                TxtName.Focus();
                TxtName.BackColor = Color.Yellow;
                TxtName.Enabled = true;
            }

            if (richTextBox1.Text == "Mark" || richTextBox1.Text == "Brand")
            {
                TxtMark.Focus();
                TxtMark.BackColor = Color.Yellow;
                TxtMark.Enabled = true;
            }

            if (richTextBox1.Text == "Stock" || richTextBox1.Text == "Stocks" || richTextBox1.Text == "Store")
            {
                TxtStock.Focus();
                TxtStock.BackColor = Color.Yellow;
                TxtStock.Enabled = true;
            }

            if (richTextBox1.Text == "Sell price" || richTextBox1.Text == "Sales" || richTextBox1.Text == "Sale")
            {
                TxtSellPrice.Focus();
                TxtSellPrice.BackColor = Color.Yellow;
                TxtSellPrice.Enabled = true;
            }

            if (richTextBox1.Text == "Buy price" || richTextBox1.Text == "Buy")
            {
                TxtBuyPrice.Focus();
                TxtBuyPrice.BackColor = Color.Yellow;
                TxtBuyPrice.Enabled = true;
            }

            if (richTextBox1.Text == "Category" || richTextBox1.Text == "Set" || richTextBox1.Text == "Group" || richTextBox1.Text == "Cluster")
            {
                TxtCategory.Focus();
                TxtCategory.BackColor = Color.Yellow;
                TxtCategory.Enabled = true;
            }

            if (richTextBox1.Text == "State")
            {
                comboBox1.Enabled = true;
                comboBox1.Focus();
                comboBox1.BackColor = Color.Yellow;
            }

            if (richTextBox1.Text == "Date" || richTextBox1.Text == "Date")
            {
                maskedTextBox1.Enabled = true;
                maskedTextBox1.Focus();
                maskedTextBox1.BackColor = Color.Yellow;
            }

            if (richTextBox1.Text == "Exit application" || richTextBox1.Text == "Exits application" || richTextBox1.Text == "Exit")
            {
                Application.Exit();
            }

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_load(object sender, EventArgs e)
        {
            enabled();
            colormethod();
        }

        private void maskedTextBox1_BackColorChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.BackColor == Color.Yellow)
            {
                maskedTextBox1.Text = DateTime.Now.ToString("dd.MM.yyyy");
            }
        }

        private void comboBox1_BackColorChanged(object sender, EventArgs e)
        {
            if (comboBox1.BackColor == Color.Yellow)
            {
                comboBox1.Text = "Active";
            }
        }

        private void label10_TextChanged(object sender, EventArgs e)
        {
            SpVoice ses = new SpVoice();
            ses.Speak(label10.Text);
        }
    }
}
