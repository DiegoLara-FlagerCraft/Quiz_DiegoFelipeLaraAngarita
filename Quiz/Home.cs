using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            TxtBGuardado.Clear();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            RtxtResultados.Clear();
            string Genero = "";
            if (CkbMasculino.Checked == true)
                Genero = "Masculino";
            if (CkbFemenino.Checked == true)
                Genero = "Femenino";

            int Indice = CkLServicios.SelectedIndex;
            if (Indice == -1)
            {
                MessageBox.Show("LLENE TODA LA INFORMACIÓN Y SELECCIONE UN SERVICIO");
            }
            if (Indice != -1)
            {
        
                RtxtResultados.Text = "REGISTRO \n" + "FECHA DE REGISTRO: " + DtpFecha.Text + "\n" + "CIUDAD DE REGISTRO: " + CbCiudad.Text + "\n"
                + "NOMBRE: " + TxtNombre.Text + "\n" + "DOCUMENTO: " + TxtDocumento.Text + "\n" + "GENERO: " + Genero + "\n" + "SEVICIO: " + CkLServicios.Items[Indice].ToString() + "\n"
                + "------------------------------------------------------------------------------- \n" + TxtBGuardado.Text;
                Clipboard.SetText(RtxtResultados.Text);
            }
            TxtBGuardado.Text = Clipboard.GetText();

        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            String Report = RtxtResultados.Text;
            Form Formulario = new Reporte(Report);
            MessageBox.Show("EN ESTE FORMULARIO ENCONTRARA EL REPORTE DE TODOS LOS USUARIOS REGISTRADOS");
            Formulario.Show();
        }
    }
}
