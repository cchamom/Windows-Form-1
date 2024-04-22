using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraViajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butonCalcular_Click(object sender, EventArgs e)
        {
            double velocidad;
            string destino = txtPtDestino.Text;
            string origen = txtPtOrigen.Text;

            if (!double.TryParse(Vconstante.Text, out velocidad))
            {
                labelResultado.Text = "La velocidad no es valida";
                return;
            }

            double distancia = 100;
            double tiempo = distancia / velocidad;

            labelResultado.Text = $"El tiempo de viaje es desde el punto A {origen} al punto B {destino} es de: {tiempo} horas";

          }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

