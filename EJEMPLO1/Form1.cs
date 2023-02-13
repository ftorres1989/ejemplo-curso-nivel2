using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJEMPLO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AGREGAR_Click(object sender, EventArgs e)
        {
            string elem = TXTNOMBRE.Text;
            lwELEMENTOS.Items.Add(elem);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbocolorfavorito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbocolorfavorito.Items.Add("Rojo");
            cbocolorfavorito.Items.Add("Verde");
            cbocolorfavorito.Items.Add("Naranja");
        }

        private void btverperfil_Click(object sender, EventArgs e)
        {
            string nombre = TXTNOMBRE.Text;
            DateTime fecha = fechadenacimiento.Value;
            // OPERADOR TERNARIO
            string chocolate = ckbchocolate.Checked == true ? "Le gusta el Chocolate" : "No le gusta";

            string tipo;
            if (rbmuggle.Checked)
            {
                tipo = "Muggle";
            }
            else if (rbwizard.Checked)
            {
                tipo = "Wizard";

            }
            else
            {
                tipo = "Squibs";
            }
            string colorfavorito = cbocolorfavorito.SelectedItem.ToString(); // El combobox admite cualquier tipo de objetos
                                                                             // SelectedItem me devuelve un objeto
                                                                             // como yo se que tiene un string  y lo transformo en string

            string NumeroFavorito = numnumerofavorito.Value.ToString();

            string mensaje = chocolate + ", es " + tipo + "Su color es " + colorfavorito + "su nro es :" + NumeroFavorito;
            MessageBox.Show("Nombre" + nombre + "Fecha" + fecha + "," + mensaje);





        }
    }
}
