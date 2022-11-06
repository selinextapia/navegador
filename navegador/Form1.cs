using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace navegador
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void navegador_Click(object sender, EventArgs e)
        {
            
        }

        private void ir_Click(object sender, EventArgs e)
        {
            browser.Navigate(navegador.Text);
        }

        private void atras_Click(object sender, EventArgs e)
        {
            browser.GoBack();
        }

        private void alante_Click(object sender, EventArgs e)
        {
            browser.GoForward();
        }

        private void house_Click(object sender, EventArgs e)
        {
            browser.GoHome();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            browser.Refresh();

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            browser.Stop();
        }

       
    }
}
