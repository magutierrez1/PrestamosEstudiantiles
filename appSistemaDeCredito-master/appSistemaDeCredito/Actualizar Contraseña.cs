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
    public partial class Actualizar_Contraseña : Form
    {
        //Dato del estudiante
        private Estudiante objEstudiante;

        public Actualizar_Contraseña(Estudiante prmEstudiante)
        {
            InitializeComponent();
            objEstudiante = prmEstudiante;
        }

        private void btnActContrasema_Click(object sender, EventArgs e)
        {
            //Variable
            String contrasemaActual = "";
            String contrasemaNueva = "";
            String contrasemaConfirmar = "";

            contrasemaActual = txtActEstConActual.Text.ToString();
            contrasemaNueva = txtActEstConNueva.Text.ToString();
            contrasemaConfirmar = txtActEstConConfirmar.Text.ToString();

            if (estaVacio(contrasemaActual) == false && estaVacio(contrasemaNueva) == false && estaVacio(contrasemaConfirmar) == false)
            {
                DaoEstudianteGestion gestion = new DaoEstudianteGestion();


                if (objEstudiante.getContrasemaEst().Equals(contrasemaActual))
                {
                    if (contrasemaNueva.Equals(contrasemaConfirmar))
                    {
                        objEstudiante.setContrasemaEst(contrasemaNueva);
                        gestion.actualizarContasema(objEstudiante);
                        MessageBox.Show("Se actualizo la contraseña ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form objFromCodeudor = new ActualizarEstudiante(objEstudiante);
                        //Visible la ventana de Registro
                        objFromCodeudor.Visible = true;
                        //No mostrar la venta principal 
                        Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No coincide la contraseña nueva con la contraseña de verificacion, intente de nuevo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtActEstConNueva.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("No coincide la contraseña actual , intente de nuevo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtActEstConActual.Text = "";
                }

                
            }
            else
            {
                MessageBox.Show("Error no se digito todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool estaVacio(String cadena)
        {
            if (cadena.Length != 0)
            {
                return false;
            }
            else
            {
                return true;

            }
        }

        private void btnActContrasemaAtras_Click(object sender, EventArgs e)
        {
            Form objFromCodeudor = new ActualizarEstudiante(objEstudiante);
            //Visible la ventana de Registro
            objFromCodeudor.Visible = true;
            //No mostrar la venta principal 
            Visible = false;
        }

        private void txtActCActual_Enter(object sender, EventArgs e)
        {
            if (txtActEstConActual.Text == "Contraseña")
            {
                txtActEstConActual.Text = "";
                txtActEstConActual.ForeColor = Color.Black;
            }
        }

        private void txtActEstConNueva_Enter(object sender, EventArgs e)
        {
            if (txtActEstConNueva.Text == "Contraseña")
            {
                txtActEstConNueva.Text = "";
                txtActEstConNueva.ForeColor = Color.Black;
            }
        }

        private void txtActEstConVerificar_Enter(object sender, EventArgs e)
        {
            if (txtActEstConConfirmar.Text == "Contraseña")
            {
                txtActEstConConfirmar.Text = "";
                txtActEstConConfirmar.ForeColor = Color.Black;
            }
        }
    }
}
