using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
              /// BOTON ATRAS
            webBrowser1.GoBack();
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Boton siguiente
            webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {    
             /// Navegar en URL
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ///Volver a cargar
            webBrowser1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            /// Boton detener busqueda
            webBrowser1.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        { 
            /// para volver a casa
            webBrowser1.GoHome();
        }
    }
}
