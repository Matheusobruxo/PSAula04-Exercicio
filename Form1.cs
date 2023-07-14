using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSAula04_Exercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int clicadas;
        public static int multiplicador = 1;
        Random sorteador = new Random();

        private void btnBotaoVermelho_Click(object sender, EventArgs e)
        {
            clicadas = clicadas + (1 * multiplicador);
            lblClicadas.Text = $"Clicadas: {clicadas}";
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            multiplicador = sorteador.Next(0,1000);
            lblMultiplicador.Text = $"Multiplicador: {multiplicador}";
        }
    }
}
