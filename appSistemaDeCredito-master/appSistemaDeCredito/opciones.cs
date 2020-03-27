using appSistemaDeCredito.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSistemaDeCredito
{
    public partial class opciones : Form
    {
        //Dato del estudiante
        private Estudiante objEstudiante;

        public opciones(Estudiante prmEstudiante)
        {
            InitializeComponent();
            objEstudiante = prmEstudiante;
        }
        #region set y get
        public Estudiante getEstudiante()
        {
            return objEstudiante;
        }

        public void setEstudiante(Estudiante prmEstudiante)
        {
            objEstudiante = prmEstudiante;
        }
        #endregion

        #region activar botones
        public void activarBtnSolicitar(bool estado)
        {
            btnSolicitaprestamo.Enabled = estado;
        }
        public void activarBtnCodeudor(bool estado)
        {
            btnOpcRegCode.Enabled = estado;
        }
        #endregion

        private void btnOpcRegCode_Click(object sender, EventArgs e)
        {

            Form objFromCodeudor = new RegistroCodeudor(objEstudiante);
            //Visible la ventana de Registro
            objFromCodeudor.Visible = true;
            //No mostrar la venta principal 
            Visible = false;
        }



    

        private void btnSolicitaprestamo_Click_1(object sender, EventArgs e)
        {

            Form objFromCodeudor = new RegistrarPrestamo(objEstudiante);
            //Visible la ventana de Registro
            objFromCodeudor.Visible = true;
            //No mostrar la venta principal 
            Visible = false;
        }

        private void btnOpcActDatos_Click(object sender, EventArgs e)
        {

            Form objFromCodeudor = new ActualizarEstudiante(objEstudiante);
            //Visible la ventana de Registro
            objFromCodeudor.Visible = true;
            //No mostrar la venta principal 
            Visible = false;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Form objFromCodeudor = new HistorialPrestamo(objEstudiante);
            //Visible la ventana de Registro
            objFromCodeudor.Visible = true;
            //No mostrar la venta principal 
            Visible = false;
        }

        private void btnOcpEliminar_Click(object sender, EventArgs e)
        {
            Form objFromCodeudor = new EliminarPrestamo(objEstudiante);
            //Visible la ventana de Registro
            objFromCodeudor.Visible = true;
            //No mostrar la venta principal 
            Visible = false;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta seguro que quiere cerrar sesion ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form objFromCodeudor = new VistaPrincipal();
            //Visible la ventana de Registro
            objFromCodeudor.Visible = true;
            //No mostrar la venta principal 
            Visible = false;
        }
    }
}