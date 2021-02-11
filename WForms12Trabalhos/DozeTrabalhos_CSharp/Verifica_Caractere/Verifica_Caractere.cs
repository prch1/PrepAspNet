using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verifica_Caractere
{
    public partial class Verifica_Caractere : Form
    {
        char entrada;
        int valor;
        
        public Verifica_Caractere()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            entrada = Convert.ToChar(txtCaractere.Text);
            valor = Convert.ToInt32(entrada);

            if(valor >=65 && valor <=90)
            {
                lblResultado.Text = "String Maiuscula";
            }

            if (valor >= 97 && valor <= 122)
            {
                lblResultado.Text = "String Minúscula";
            }

            if (valor >= 48 && valor <= 57)
            {
                lblResultado.Text = "Digito";
            }

            if (valor >= 0 && valor <= 47 || valor >=58 && valor <=64 || 
                valor >=91 && valor <=96 || valor >=123 && valor <=127 )
            {
                lblResultado.Text = "Simbolo Especial";
            }

            if (valor >= 127)
            {
                lblResultado.Text = "Caractere Especial";
            }
        }
    }
}
