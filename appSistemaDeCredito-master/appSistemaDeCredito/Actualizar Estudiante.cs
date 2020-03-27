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
    public partial class ActualizarEstudiante : Form
    {
        //Dato del estudiante
        private Estudiante objEstudiante;

        public ActualizarEstudiante(Estudiante prmEstudiante)
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

        private void btnActEstGeneral_Click(object sender, EventArgs e)
        {
            Form objFromCodeudor = new Actualizar_Info_General(objEstudiante);
            //Visible la ventana de Registro
            objFromCodeudor.Visible = true;
            //No mostrar la venta principal 
            Visible = false;
        }

        private void btnActEstContacto_Click(object sender, EventArgs e)
        {
            Form objFromCodeudor = new Actualizar_Info_Contacto(objEstudiante);
            //Visible la ventana de Registro
            objFromCodeudor.Visible = true;
            //No mostrar la venta principal 
            Visible = false;
        }

        private void btnActEstContrasena_Click(object sender, EventArgs e)
        {
            Form objFromCodeudor = new Actualizar_Contraseña(objEstudiante);
            //Visible la ventana de Registro
            objFromCodeudor.Visible = true;
            //No mostrar la venta principal 
            Visible = false;
        }

        private void btnActEstAtras_Click(object sender, EventArgs e)
        {
            opciones objFromOpciones = new opciones(objEstudiante);
            if (objEstudiante.getobjCodeudor() == null)
            {
                objFromOpciones.activarBtnSolicitar(false);
            }
            else
            {
                
                objFromOpciones.activarBtnCodeudor(false);
            }
            //Visible la ventana de Registro
            objFromOpciones.Visible = true;
            //No mostrar la venta principal 
            Visible = false;
        }
    }
}
