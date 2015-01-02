using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frijol
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();

            //ticket.HeaderImage = "C:\imagen.jpg"; //esta propiedad no es obligatoria 

            ticket.AddHeaderLine("COMPRA DE FRIJOL");
            //ticket.AddHeaderLine("EXPEDIDO EN:");
            //ticket.AddHeaderLine("CUAUHTEMOC #3");
            //ticket.AddHeaderLine("RIO GRANDE ZACATECAS");
            //ticket.AddHeaderLine("RFC: BABR670105518");

            //El metodo AddSubHeaderLine es lo mismo al de AddHeaderLine con la diferencia 
            //de que al final de cada linea agrega una linea punteada "==========" 
            ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

           
            ticket.AddFooterLine("");
            ticket.AddFooterLine("#Cost.  Peso  Precio  Importe");
            ticket.AddFooterLine("===================================");
            ticket.AddFooterLine("===================================");
            ticket.AddFooterLine("===================================");
            ticket.AddFooterLine("12345678901234567890123456789012");

            //ticket.AddItem("150Kg","Negro , $15.5","1170");
            ticket.AddFooterLine("");

            //El metodo AddFooterLine funciona igual que la cabecera
            //ticket.AddFooterLine("LA HABITACION VENCE A LAS 13:00");
            //ticket.AddFooterLine("SI UD. DESEA PERMANECER MAS DIAS");
            //ticket.AddFooterLine("ES IMPORTRANTE QUE NOS LO ");
            //ticket.AddFooterLine("NOTIFIQUE LO MAS PRONTO POSIBLE");
            //ticket.AddFooterLine("GRACIAS");

            //Y por ultimo llamamos al metodo PrintTicket para imprimir el ticket, este metodo necesita un 
            //parametro de tipo string que debe de ser el nombre de la impresora. 
            ticket.PrintTicket("EPSON TM-U220 Receipt");


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main Principal = new main();
            Principal.Show();
            
        }

        

        
    }
}
