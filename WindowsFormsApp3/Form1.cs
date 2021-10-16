using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        public Persona[] Personas { get; set; } = new Persona[3];
        public int pos = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            Persona personas = new Persona();

            personas.nombre = txtnombre.Text;
            pos = pos + 1; 
            Personas[pos] = personas;
           
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            lbllista.Text = "Lista \r\n";
            foreach (Persona item in Personas)
            {
                lbllista.Text = lbllista.Text + item.nombre + "\r\n";
            }
        }
    }
}
