using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Vista
{
    public partial class Menu : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Menu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        public void metodo()
        {

            Class1 nomree = new Class1();


        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void SubmenuReportes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            /* pictureBox1.ImageLocation = Login.imagen;
             label1.Text = Login.usuario;
             label3.Text = Login.cargo2;
             clsCargo objN = new clsCargo();
             int i = 0;
             foreach (DataRow row in objN.MtdBuscarBotones2(label3.Text).Rows)
             {
                 if (Login.cargo2 == row[i].ToString())
                 {
                     // ----------------------------------------------------
                     if (Convert.ToInt32(row[i + 1]) == 1)
                     {
                         btnproductos.Enabled = true;
                     }
                     else if (Convert.ToInt32(row[i + 1]) == 0)
                     {
                         btnproductos.Enabled = false;
                     }
                     // ----------------------------------------------------
                     if (Convert.ToInt32(row[i + 2]) == 1)
                     {
                         btnCompra.Enabled = true;
                     }
                     else if (Convert.ToInt32(row[i + 2]) == 0)
                     {
                         btnCompra.Enabled = false;
                     }
                     // ----------------------------------------------------
                     if (Convert.ToInt32(row[i + 3]) == 1)
                     {
                         BTNventas.Enabled = true;
                     }
                     else if (Convert.ToInt32(row[i + 3]) == 0)
                     {
                         BTNventas.Enabled = false;
                     }
                     // ----------------------------------------------------
                     if (Convert.ToInt32(row[i + 4]) == 1)
                     {
                         btnempleados.Enabled = true;
                     }
                     else if (Convert.ToInt32(row[i + 4]) == 0)
                     {
                         btnempleados.Enabled = false;
                     }
                     // ----------------------------------------------------
                     if (Convert.ToInt32(row[i + 5]) == 1)
                     {
                         btnclientes.Enabled = true;
                     }
                     else if (Convert.ToInt32(row[i + 5]) == 0)
                     {
                         btnclientes.Enabled = false;
                     }
                     // ----------------------------------------------------
                     if (Convert.ToInt32(row[i + 6]) == 1)
                     {
                         btnReportes.Enabled = true;
                     }
                     else if (Convert.ToInt32(row[i + 6]) == 0)
                     {
                         btnReportes.Enabled = false;
                     }
                     //-----------------------------------------------

                 }
             }
         }*/
        }

        private void btnCandidatos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Candidato());
        }

        private void btnVotacion_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Votacion());
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Resultados());
        }

        private void btnBasededatos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new BasedeDatos());
        }

        private void btnOtras_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Partido());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
        }
    }
}
