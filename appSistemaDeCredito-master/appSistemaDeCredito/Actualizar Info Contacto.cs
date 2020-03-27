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
    public partial class Actualizar_Info_Contacto : Form
    {
        //Dato del estudiante
        private Estudiante objEstudiante;

        public Actualizar_Info_Contacto(Estudiante prmEstudiante)
        {
            InitializeComponent();
            objEstudiante = prmEstudiante;
            llenarCampos(prmEstudiante);
        }

        private void llenarCampos(Estudiante prmEstudiante)
        {
            txtActEstDireccion.Text = prmEstudiante.getDireccionEst();
            txtActEstEmail.Text = prmEstudiante.getEmailEst();
            txtActEstTelefono.Text = ""+ prmEstudiante.getTelefonoEst();
           
        }

        private void btnActInfContacto_Click(object sender, EventArgs e)
        {
            //Variables 
            String email = "";
            String direccion = "";
            long telefono ;


            if (txtActEstEmail.Text != "" && txtActEstDireccion.Text != "" && txtActEstTelefono.Text.ToString() != "")
            {
                email = txtActEstEmail.Text.ToString();
                direccion = txtActEstDireccion.Text.ToString();
                telefono = long.Parse(txtActEstTelefono.Text.ToString());


                objEstudiante.setEmailEst(email);
                objEstudiante.setDireccionEst(direccion);
                objEstudiante.setTelefonoEst(telefono);

                DaoEstudianteGestion gestion = new DaoEstudianteGestion();
                gestion.actualizarInfoContacto(objEstudiante);
                MessageBox.Show("Se actualizo la informacion de contacto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form objFromCodeudor = new ActualizarEstudiante(objEstudiante);
                //Visible la ventana de Registro
                objFromCodeudor.Visible = true;
                //No mostrar la venta principal 
                Visible = false;
            }
            else
            {
                MessageBox.Show("Error no se digito todos los campos ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActInfConAtras_Click(object sender, EventArgs e)
        {
            Form objFromCodeudor = new ActualizarEstudiante(objEstudiante);
            //Visible la ventana de Registro
            objFromCodeudor.Visible = true;
            //No mostrar la venta principal 
            Visible = false;
        }

        private void validarActEstEmail(object sender, KeyPressEventArgs e)
        {

        }

        private void validarActEstDire(object sender, KeyPressEventArgs e)
        {

        }

        private void validarActEstTelefono(object sender, KeyPressEventArgs e)
        {
            // Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
