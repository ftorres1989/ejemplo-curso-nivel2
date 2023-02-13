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
    public partial class Frmprincipal : Form
    {
        public Frmprincipal()
        {
            InitializeComponent();
        }

        private void abuotToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // VALIDACION = VOY A VER LAS VENTANAS QUE ESTAN ABIERTAS Y SI HAY ALGUNA DE ESE TIPO NO DEJO QUE ABRA OTRA

            foreach (var item in Application.OpenForms)// Analizo una coleccion de FORMULARIOS
            {
                if (item.GetType() == typeof(Form1))  // SI EL TIPO DE FORMULARIO ES IGUAL AL DE FORM1 RETORNO 
                {
                    MessageBox.Show("Ya existe esta ventana abierta,termine de trabajar alli");
                    return;
                }
            }
            
            
            
            
            // NAVEGO A LA OTRA VENTANA, CREO INSTANCIA A UN OBJETO

            Form1 ventana = new Form1();
            ventana.MdiParent= this; // La ventan que voy a ir tiene esta ventana como padre
            ventana.Show();
            //ventana.ShowDialog(); // muestra la ventana pero captura interacion del momento no puedo seleccionr
                                   // la otra ventana sin cerrar la actual.ESTO FUNCIONA SINO TIENE PARENT

        }
    }
}
