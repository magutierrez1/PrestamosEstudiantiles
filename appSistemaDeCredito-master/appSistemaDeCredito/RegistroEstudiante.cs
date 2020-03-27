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
    public partial class RegistroEstudiante : Form
    {
        public RegistroEstudiante()
        {
            InitializeComponent();
        }

        private void btnEstGuardar_Click(object sender, EventArgs e)
        {

            #region Variables
            //Variables para capturar los datos
            Estudiante objEstudiante;
            String tipoDocEst;
            long idEst;
            String nombresEst;
            String apellidosEst;
            String generoEst;
            String nombreIESEst;
            String emailEst;
            String direccionEst;
            long telefonoEst;
            String contrasemaEst;
            //Comunica la base de datos con la app
            DaoEstudianteGestion gestion = new DaoEstudianteGestion();
            //Respuesta a una consulta de la BD
            DataSet objDateSet_existeEstudiante = new DataSet();
            DataSet objDateSet_existeEmail = new DataSet();

            #endregion

            if (estaVacio(txtEstId.Text) == false && estaVacio(txtEstNombre.Text) == false && estaVacio(txtEstApellido.Text) == false
                && estaVacio(txtEstNomIes.Text) == false && estaVacio(txtEstEmail.Text) == false && estaVacio(txtEstDireccion.Text) == false
                && estaVacio(txtEstTelefono.Text) == false && estaVacio(txtEstContrasema.Text) == false && seleccionoGenero() != ""
                && seleccionoTipo() != "")
            {
                #region Captura De Datos 
                tipoDocEst = seleccionoTipo();
                idEst = long.Parse(txtEstId.Text);
                nombresEst = txtEstNombre.Text;
                apellidosEst = txtEstApellido.Text;
                generoEst = seleccionoGenero();
                nombreIESEst = txtEstNomIes.Text;
                emailEst = txtEstEmail.Text;
                direccionEst = txtEstDireccion.Text;
                telefonoEst = long.Parse(txtEstTelefono.Text);
                contrasemaEst = txtEstContrasema.Text;
                #endregion

                /*Trae la fila de la base de datos que tengan el mismo id del estudiante que se esta registrando*/
                objDateSet_existeEstudiante = gestion.consultarEstudiante(idEst);
                //Si se encuentra un estudiante con ese mismo email se retornara la fila desde la base de datos  
                objDateSet_existeEmail = gestion.existeEmail(emailEst);

                //Verficamos si la consulta trajo alguna fila de la base de datos (Un estudiante registrado con ese id)
                if (objDateSet_existeEstudiante.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("El Estudiante ya esta registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Verficamos si la consulta trajo alguna fila de la base de datos (Un estudiante registrado con ese email)
                if (objDateSet_existeEmail.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("El email ya fue registrado por otro estudiante ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEstEmail.Text = "";
                }
                else
                {
                    //Se crea el objeto con toda la informacion
                    objEstudiante = new Estudiante(tipoDocEst, idEst, nombresEst, apellidosEst, generoEst, nombreIESEst, emailEst, direccionEst, telefonoEst, contrasemaEst);
                    //Se 
                    gestion.registrarEstudiante(objEstudiante);
                    MessageBox.Show("El Estudiante se ha registrado exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //lo manda la vista de opciones
                    opciones objFromOpcion = new opciones(objEstudiante);
                    objFromOpcion.activarBtnCodeudor(true);
                    objFromOpcion.activarBtnSolicitar(false);
                    //Visible la ventana de Registro
                    objFromOpcion.Visible = true;
                    //No mostrar la venta principal 
                    Visible = false;

                }
            }
            else
            {
                MessageBox.Show("Error no se digito todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region procedimientosAuxiliares
        private String seleccionoGenero()
        {
            if (rdEstFemenino.Checked == true)
            {
                return "F";
            }
            if (rdEstMasculino.Checked == true)
            {
                return "M";
            }

            return "";
        }
        private String seleccionoTipo()
        {
            if (rdEstTi.Checked == true)
            {
                return "T.I";
            }
            if (rdEstCC.Checked == true)
            {
                return "C.C";
            }

            return "";
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
        #endregion

        #region aceptarSoloNumeros
        //Asegurarse que solo sean numeros
        private void validarEstNumId(object sender, KeyPressEventArgs e)
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
        //Asegurarse que solo sean numeros
        private void validarEstTelefono(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Solo se permiten Numeros Positivos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region aceptarSoloLetras
        private void validarLetraNombre(object sender, KeyPressEventArgs e)
        {
            // Para obligar a que sólo se introduzcan letras 
            if (Char.IsLetter(e.KeyChar))
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

                if (Char.IsSeparator(e.KeyChar)) //permitir teclas de separar 
                {
                    e.Handled = false;
                }
                else

                {   //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                    MessageBox.Show("Solo letras ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void validarLetraApellido(object sender, KeyPressEventArgs e)
        {
            // Para obligar a que sólo se introduzcan letras 
            if (Char.IsLetter(e.KeyChar))
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

                if (Char.IsSeparator(e.KeyChar)) //permitir teclas de separar 
                {
                    e.Handled = false;
                }
                else

                {   //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                    MessageBox.Show("Solo letras ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void validarNomIES(object sender, KeyPressEventArgs e)
        {

            // Para obligar a que sólo se introduzcan letras 
            if (Char.IsLetter(e.KeyChar))
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

                if (Char.IsSeparator(e.KeyChar)) //permitir teclas de separar 
                {
                    e.Handled = false;
                }
                else

                {   //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                    MessageBox.Show("Solo letras ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }



        #endregion

        #region validar casilla vacia 
        private void validarVacioEstNumId(object sender, EventArgs e)
        {
            if (txtEstId.Text == "")
            {
                epEstVacio.SetError(txtEstId, "Introduzca Id");
                txtEstId.Focus();
            }
            else
            {
                epEstVacio.Clear();
            }
        }

        private void validarVacioEstNom(object sender, EventArgs e)
        {
            if (txtEstNombre.Text == "")
            {
                epEstVacio.SetError(txtEstNombre, "Introduzca Nombre");
                txtEstNombre.Focus();
            }
            else
            {
                epEstVacio.Clear();
            }
        }

        private void validarVacioEstApe(object sender, EventArgs e)
        {
            if (txtEstApellido.Text == "")
            {
                epEstVacio.SetError(txtEstApellido, "Introduzca Apellido");
                txtEstApellido.Focus();
            }
            else
            {
                epEstVacio.Clear();
            }
        }

        private void validarVacioEstNomIes(object sender, EventArgs e)
        {
            if (txtEstNomIes.Text == "")
            {
                epEstVacio.SetError(txtEstNomIes, "Introduzca IES");
                txtEstNomIes.Focus();
            }
            else
            {
                epEstVacio.Clear();
            }
        }

        private void validarVacioEstEmail(object sender, EventArgs e)
        {
            if (txtEstEmail.Text == "")
            {
                epEstVacio.SetError(txtEstEmail, "Introduzca Email");
                txtEstEmail.Focus();
            }
            else
            {
                epEstVacio.Clear();
            }
        }

        private void validarVacioEstDir(object sender, EventArgs e)
        {
            if (txtEstDireccion.Text == "")
            {
                epEstVacio.SetError(txtEstDireccion, "Introduzca Direccion");
                txtEstDireccion.Focus();
            }
            else
            {
                epEstVacio.Clear();
            }
        }

        private void validarVacioEstTel(object sender, EventArgs e)
        {
            if (txtEstTelefono.Text == "")
            {
                epEstVacio.SetError(txtEstTelefono, "Introduzca Telefono");
                txtEstTelefono.Focus();
            }
            else
            {
                epEstVacio.Clear();
            }
        }

        private void validarVacioEstCon(object sender, EventArgs e)
        {
            if (txtEstContrasema.Text == "")
            {
                epEstVacio.SetError(txtEstContrasema, "Introduzca Contraseña");
                txtEstContrasema.Focus();
            }
            else
            {
                epEstVacio.Clear();
            }
        }

        #endregion



        private void txtEstId_Enter(object sender, EventArgs e)
        {
            if(txtEstId.Text == "Número Documento")
            {
                txtEstId.Text = "";
                txtEstId.ForeColor = Color.Black;
            }
        }

        private void txtEstId_Leave(object sender, EventArgs e)
        {
            if (txtEstId.Text == "")
            {
                txtEstId.Text = "Número Documento";
                txtEstId.ForeColor = Color.Silver;
            }
        }

        private void txtEstNombre_Enter(object sender, EventArgs e)
        {
            if (txtEstNombre.Text == "Nombres")
            {
                txtEstNombre.Text = "";
                txtEstNombre.ForeColor = Color.Black;
            }
        }

        private void txtEstNombre_Leave(object sender, EventArgs e)
        {
            if (txtEstNombre.Text == "")
            {
                txtEstNombre.Text = "Nombres";
                txtEstNombre.ForeColor = Color.Silver;
            }
        }

        private void txtEstApellido_Enter(object sender, EventArgs e)
        {
           if (txtEstApellido.Text == "Apellidos")
            {
                txtEstApellido.Text = "";
                txtEstApellido.ForeColor = Color.Black;
            }
        }

        private void txtEstApellido_Leave(object sender, EventArgs e)
        {
            if (txtEstApellido.Text == "")
            {
                txtEstApellido.Text = "Apellidos";
                txtEstApellido.ForeColor = Color.Silver;
            }
        }

        private void txtEstNomIes_Enter(object sender, EventArgs e)
        {
            if (txtEstNomIes.Text == "Nombre IES")
            {
                txtEstNomIes.Text = "";
                txtEstNomIes.ForeColor = Color.Black;
            }
        }

        private void txtEstNomIes_Leave(object sender, EventArgs e)
        {
            if (txtEstNomIes.Text == "")
            {
                txtEstNomIes.Text = "Nombre IES";
                txtEstNomIes.ForeColor = Color.Silver;
            }
        }

        private void txtEstEmail_Enter(object sender, EventArgs e)
        {
            if (txtEstEmail.Text == "Email")
            {
                txtEstEmail.Text = "";
                txtEstEmail.ForeColor = Color.Black;
            }
        }

        private void txtEstEmail_Leave(object sender, EventArgs e)
        {
            if (txtEstEmail.Text == "")
            {
                txtEstEmail.Text = "Email";
                txtEstEmail.ForeColor = Color.Silver;
            }

        }

        private void txtEstDireccion_Enter(object sender, EventArgs e)
        {
            if (txtEstDireccion.Text == "Dirección")
            {
                txtEstDireccion.Text = "";
                txtEstDireccion.ForeColor = Color.Black;
            }
        }

        private void txtEstDireccion_Leave(object sender, EventArgs e)
        {
            if (txtEstDireccion.Text == "")
            {
                txtEstDireccion.Text = "Dirección";
                txtEstDireccion.ForeColor = Color.Silver;
            }
        }

        private void txtEstTelefono_Enter(object sender, EventArgs e)
        {
            if (txtEstTelefono.Text == "Telefono")
            {
                txtEstTelefono.Text = "";
                txtEstTelefono.ForeColor = Color.Black;
            }
        }

        private void txtEstTelefono_Leave(object sender, EventArgs e)
        {
            if (txtEstTelefono.Text == "")
            {
                txtEstTelefono.Text = "Telefono";
                txtEstTelefono.ForeColor = Color.Silver;
            }
        }

        private void txtEstContrasema_Enter(object sender, EventArgs e)
        {
            if (txtEstContrasema.Text == "Contraseña")
            {
                txtEstContrasema.Text = "";
                txtEstContrasema.ForeColor = Color.Black;
            }
        }

        private void txtEstContrasema_Leave(object sender, EventArgs e)
        {
            if (txtEstContrasema.Text == "")
            {
                txtEstContrasema.Text = "Contraseña";
                txtEstContrasema.ForeColor = Color.Silver;
            }
        }

        private void btnRegEAtras_Click(object sender, EventArgs e)
        {
            VistaPrincipal objFromOpciones = new VistaPrincipal();
            objFromOpciones.Visible = true;
            //No mostrar la venta principal 
            Visible = false;
        }

      
        //#endregion
    }
}

