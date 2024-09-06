using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_EjemploEnlaceDatos
{
    public partial class Form1 : Form
    {
        public string[] misCiudades = new string[] { "Sevilla", "Córdoba", "Granada" };
        public List<Ciudad> ciudades;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCiudades.DataSource = misCiudades;
            ciudades = new List<Ciudad>()
            {
                new Ciudad
                {
                    NombreCiudad = "Sevilla",
                    PoblacionCiudad = 150000,
                    PaisCiudad = "España"
                },
                  new Ciudad
                {
                    NombreCiudad = "Córdoba",
                    PoblacionCiudad = 300000,
                    PaisCiudad = "España"
                },
            };
            
            dgvCiudades.DataSource = ciudades;
        }
    }
}
