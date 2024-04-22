using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaluladoradoraGalones
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCacular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDistancia.Text, out double distancia) ||
                !double.TryParse(txtRendimiento.Text, out double rendimiento))
            {
                MessageBox.Show("Los datos son erroneos");
                return;
            }

            // se divide los litoros de la gasolina entre los kilometros
            // para poder calcular el consumo total
            double Galones_Consumidos = distancia / rendimiento;

            Resultado.Text = $"La cantidad de galones que consumio es de: {Galones_Consumidos:F2}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }
    }
}

