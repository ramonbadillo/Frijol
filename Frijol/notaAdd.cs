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

    //Corregir los espacios en el ticket
    //Quitar el numero de costales
    //Agregar conexion con la base de datos
    public partial class notaAdd : Form
    {
        public notaAdd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checarCampos())
            {
                this.items.Rows.Add(txtBultos.Text, txtKilos.Text, getClase(),doFormat(double.Parse(txtPrecio.Text)), txtSub.Text);

                txtBultos.Text = "";
                txtKilos.Text = "";
                txtPrecio.Text = "";
                txtSub.Text = "";

                
                float total = 0;
                for (int i = 0; i < items.Rows.Count; i++)
                {
                    total += float.Parse(items.Rows[i].Cells[4].Value.ToString());
                }
                txtTotal.Text = "$" + total;
                
            }
            else {
                MessageBox.Show("Faltan Campos por llenar","Error");
            }

        }

        private string getClase() {
            string clase = "";

            if (radioButton1.Checked)
            {

                clase = radioButton1.Text;

            }
            else if (radioButton2.Checked)
            {

                clase = radioButton2.Text;

            }
            else if (radioButton3.Checked)
            {

                clase = radioButton3.Text;

            }
            else if (radioButton4.Checked)
            {

                clase = radioButton4.Text;

            }
            else if (radioButton5.Checked)
            {

                clase = radioButton5.Text;

            }
            else if (radioButton6.Checked)
            {

                clase = radioButton6.Text;

            }
            else if (radioButton7.Checked)
            {

                clase = radioButton7.Text;

            }
            else if (radioButton8.Checked)
            {

                clase = radioButton8.Text;

            }


            return clase;
        }

        

        private bool checarCampos() {
            bool campos = true;

            if (txtBultos.Text == "")
                campos = false;
            if (txtKilos.Text == "")
                campos = false;
            if (txtPrecio.Text == "")
                campos = false;
            
            if (getClase() == "")
                campos = false;

            return campos;
        }


        private void txtBultos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Return)
                txtKilos.Focus();
        }

        private void txtKilos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Return)
                txtPrecio.Focus();
        }

        

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtKilos.Text != "" && txtPrecio.Text != "") {
                int subTotal = (int)(float.Parse(txtKilos.Text) * float.Parse(txtPrecio.Text));
                txtSub.Text = " " + subTotal;
            }
                
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (items.Rows.Count != 0)
            {
                Ticket ticket = new Ticket();

                ticket.AddHeaderLine("COMPRA Y VENTA DE FRIJOL");
                ticket.AddHeaderLine("Folio: " + lblFolio.Text);


                ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
                ticket.AddFooterLine("");
                ticket.AddFooterLine("#COST  PESO CLASE PRECIO IMPORTE");
                ticket.AddFooterLine("===================================");

                for (int i = 0; i < items.Rows.Count; i++)
                {
                    //string Frijol = new string(' ', 32);
                    string Costales = items.Rows[i].Cells[0].Value.ToString().PadLeft(5, ' ')+" ";
                    string Peso = items.Rows[i].Cells[1].Value.ToString().PadLeft(5, ' ');
                    string Clase = " "+ items.Rows[i].Cells[2].Value.ToString().PadRight(6, ' ');
                    string Precio = items.Rows[i].Cells[3].Value.ToString().PadLeft(5, ' ');
                    string Importe = items.Rows[i].Cells[4].Value.ToString().PadLeft(8, ' ');
                    //string Costales = items.Rows[i].Cells[5].Value.ToString().PadLeft(6, ' ');
                    ticket.AddFooterLine(Costales+Peso+Clase+Precio+Importe);
                    ticket.AddFooterLine("");
                    //ticket.AddFooterLine(items.Rows[i].Cells[0].Value.ToString() + " " +items.Rows[i].Cells[1].Value.ToString() + " " +items.Rows[i].Cells[2].Value.ToString() + " " +items.Rows[i].Cells[3].Value.ToString() + " " +items.Rows[i].Cells[4].Value.ToString() );
                    //total += float.Parse(items.Rows[i].Cells[4].Value.ToString());
                }

                
                ticket.AddFooterLine("===================================");
                //ticket.AddFooterLine("123456789012345678901234567890123456789");
                string Totales = "Total    " + txtTotal.Text;
                ticket.AddFooterLine(Totales.PadLeft(32,' '));
                //ticket.AddItem("150Kg","Negro , $15.5","1170");
                ticket.AddFooterLine("");

                ticket.PrintTicket("EPSON TM-U220 Receipt");
            }
        }


        public static string doFormat(double myNumber)
        {
            var s = string.Format("{0:0.00}", myNumber);

            if (s.EndsWith("00"))
            {
                return ((int)myNumber).ToString();
            }
            else
            {
                return s;
            }
        }
    }
}
