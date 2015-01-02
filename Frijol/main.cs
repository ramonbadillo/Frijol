using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frijol
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show(this, "Estas seguro de que quieres salir", "Cerrar Sistema",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (res != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notaAdd nota = new notaAdd();
            nota.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dineroRecibo recibo = new dineroRecibo();
            recibo.Show();
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            dineroEntrega entrega = new dineroEntrega();
            entrega.Show();
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            totalesRevisar totales = new totalesRevisar();
            totales.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleados turno = new Empleados();
            turno.Show();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            turnoTerminar turno = new turnoTerminar();
            turno.Show();
        }
    }
}
