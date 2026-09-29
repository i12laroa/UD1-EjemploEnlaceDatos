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
        public Ciudad lucena = new Ciudad()
        {
            NombreCiudad = "Lucena",
            PoblacionCiudad = 60000,
            PaisCiudad = "España"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            cmbCiudades.DataSource = misCiudades;
            ciudades = new List<Ciudad>()
            {
                new Ciudad ()
                {
                    NombreCiudad = "Sevilla",
                    PoblacionCiudad = 150000,
                    PaisCiudad = "España"
                },
                  new Ciudad ()
                {
                    NombreCiudad = "Córdoba",
                    PoblacionCiudad = 300000,
                    PaisCiudad = "España"
                },
            };
            
          
            ciudadBindingSource.DataSource = ciudades;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!ciudades.Contains(lucena))
            {
                ciudades.Add(lucena);
                ciudadBindingSource.DataSource = null;
                ciudadBindingSource.DataSource = ciudades;
            }
               
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            //no se puede modificar una colección mientras la recorres con foreach.
            //Al llamar a ciudades.ToList() creas una copia de la lista.
            //El foreach recorre la copia, mientras que el Remove actúa sobre la original
            foreach (Ciudad c in ciudades.ToList())
            {
                if (c.NombreCiudad == "Sevilla")
                {
                    ciudades.Remove(c);
                    ciudadBindingSource.DataSource = null;
                    ciudadBindingSource.DataSource = ciudades;
                }
            }


        }
    }
}
