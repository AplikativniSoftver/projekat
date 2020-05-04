using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAOOPP;

namespace v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Obim_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            try{
               
                a = Convert.ToDouble(Velicina_stranica.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Neispravan broj");
                return;
            }
            PravilnaFigura f;
            string s = Unos.Text;
            if(s == "Krug")
            {
                f = new Krug(a);
            }else if(s == "Kvadrat")
            {
                f = new Kvadrat(a);
            } else if(s == "JKSTrougao")
            {
                f = new JKSTrougao(a);
            } else
            {
                MessageBox.Show("Nepostojeca figura");
                return;
            }
            Povrsina.Text = "Povrsina: " + f.Povrsina().ToString();
            Obim.Text = "Obim: " + f.Obim().ToString();


        }
    }
}
