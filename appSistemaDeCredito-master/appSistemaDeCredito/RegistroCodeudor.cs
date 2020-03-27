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
    public partial class RegistroCodeudor : Form
    {
        //Dato del estudiante
        private Estudiante objEstudiante;

        public RegistroCodeudor(Estudiante objEstudiante)
        {
            InitializeComponent();
            this.objEstudiante = objEstudiante;
        }

        private void btnCodRegistrar_Click(object sender, EventArgs e)
        {
            #region Variables
            //Conecta la BD con la app
            DaoCodeudorGestion gestion = new DaoCodeudorGestion();
            //Respuesta a una consulta de la BD
            DataSet objDateSet_existeEmail = new DataSet();
            //Varibles para capturar datos
            codeudor objCodeudor;
            String tipoDocCod;
            long idCod;
            String nombresCod;
            String apellidosCod;
            String generoCod;
            String emailCod;
            String direccionCod;
            long  telefonoCod;
            #endregion

            if (estaVacio(txtCodNumeroDocumento.Text) == false && estaVacio(txtCodNombre.Text) == false && estaVacio(txtCodApellido.Text) == false
                && estaVacio(txtCodEmail.Text) == false && estaVacio(txtCodDireccion.Text) == false
                && estaVacio(txtCodTelefono.Text) == false && seleccionoGenero() != ""
                && seleccionoTipo() != "")
            {
                #region CapturaDeDatos 
                tipoDocCod = seleccionoTipo();
                idCod = long.Parse(txtCodNumeroDocumento.Text);
                nombresCod = txtCodNombre.Text;
                apellidosCod = txtCodApellido.Text;
                generoCod = seleccionoGenero();
                emailCod = txtCodEmail.Text;
                direccionCod = txtCodDireccion.Text;
                telefonoCod = long.Parse(txtCodTelefono.Text);
                #endregion

                //Variables que capturan el resultado de la consulta que arroja DaoCodeudor 
                
                objDateSet_existeEmail = gestion.existeEmail(emailCod);

                
                
                    if (objDateSet_existeEmail.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("El email ya fue registrado por otro codeudor ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodEmail.Text = "";
                    }
                    else
                    {
                        objCodeudor = new codeudor(tipoDocCod, idCod, nombresCod, apellidosCod, generoCod, emailCod, direccionCod, telefonoCod);
                        objEstudiante.setobjCodeudor(objCodeudor);
                   
                        MessageBox.Show("El Codeudor se ha registrado exitosamente, puede solicitar el prestamo ahora", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        opciones objFromOpciones = new opciones(objEstudiante);
                        objFromOpciones.activarBtnSolicitar(true);
                        objFromOpciones.activarBtnCodeudor(false);
                        //Visible la ventana de Registro
                        objFromOpciones.Visible = true;
                        //No mostrar la venta principal 
                        Visible = false;
                        //gestion.asociarUsuarioCodeudor(idEstudiante, idCod);
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
            if (rbCodFemenino.Checked == true)
            {
                return "F";
            }
            if (rbCodMasculino.Checked == true)
            {
                return "M";
            }

            return "";
        }
        private String seleccionoTipo()
        {
            if (rbCodTi.Checked == true)
            {
                return "T.I";
            }
            if (rbCodCc.Checked == true)
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

        private void validarCodNumId(object sender, KeyPressEventArgs e)
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
        private void validarCodTelefono(object sender, KeyPressEventArgs e)
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

        #endregion

        #region validar casilla vacia 

        private void validarVacioCodNumId(object sender, EventArgs e)
        {
            if (txtCodNumeroDocumento.Text.Trim() == "")
            {
                ep.SetError(txtCodNumeroDocumento, "Introduzca id");
                txtCodNumeroDocumento.Focus();
            }
            else
            {
                ep.Clear();
            }
        }

        private void validarVacioCodNombre(object sender, EventArgs e)
        {
            if (txtCodNombre.Text.Trim() == "")
            {
                ep.SetError(txtCodNumeroDocumento, "Introduzca nombre");
                txtCodNombre.Focus();
            }
            else
            {
                ep.Clear();
            }
        }

        private void validarVacioCodApellido(object sender, EventArgs e)
        {
            if (txtCodApellido.Text.Trim() == "")
            {
                ep.SetError(txtCodApellido, "Introduzca apellido");
                txtCodApellido.Focus();
            }
            else
            {
                ep.Clear();
            }
        }

        private void validarVacioCodEmail(object sender, EventArgs e)
        {
            if (txtCodEmail.Text.Trim() == "")
            {
                ep.SetError(txtCodEmail, "Introduzca email");
                txtCodEmail.Focus();
            }
            else
            {
                ep.Clear();
            }
        }

        private void validarVacioCodDireccion(object sender, EventArgs e)
        {
            if (txtCodDireccion.Text.Trim() == "")
            {
                ep.SetError(txtCodDireccion, "Introduzca direccion");
                txtCodDireccion.Focus();
            }
            else
            {
                ep.Clear();
            }
        }

        private void validarVacioCodTelefono(object sender, EventArgs e)
        {
            if (txtCodTelefono.Text.Trim() == "")
            {
                ep.SetError(txtCodTelefono, "Introduzca telefono");
                txtCodTelefono.Focus();
            }
            else
            {
                ep.Clear();
            }
        }


    
    #endregion
    private void txtCodNumeroDocumento_Enter(object sender, EventArgs e)
        {
            if (txtCodNumeroDocumento.Text == "Número Documento")
            {
                txtCodNumeroDocumento.Text = "";
                txtCodNumeroDocumento.ForeColor = Color.Black;
            }
        }

        private void txtCodNumeroDocumento_Leave(object sender, EventArgs e)
        {
            if (txtCodNumeroDocumento.Text == "")
            {
                txtCodNumeroDocumento.Text = "Número Documento";
                txtCodNumeroDocumento.ForeColor = Color.Silver;
            }
        }

        private void txtCodNombre_Enter(object sender, EventArgs e)
        {
            if (txtCodNombre.Text == "Nombres")
            {
                txtCodNombre.Text = "";
                txtCodNombre.ForeColor = Color.Black;
            }
        }

        private void txtCodNombre_Leave(object sender, EventArgs e)
        {
            if (txtCodNombre.Text == "")
            {
                txtCodNombre.Text = "Nombres";
                txtCodNombre.ForeColor = Color.Silver;
            }
        }

        private void txtCodApellido_Enter(object sender, EventArgs e)
        {
            if (txtCodApellido.Text == "Apellidos")
            {
                txtCodApellido.Text = "";
                txtCodApellido.ForeColor = Color.Black;
            }
        }

        private void txtCodApellido_Leave(object sender, EventArgs e)
        {
            if (txtCodApellido.Text == "")
            {
                txtCodApellido.Text = "Apellidos";
                txtCodApellido.ForeColor = Color.Silver;
            }
        }

        private void txtCodEmail_Enter(object sender, EventArgs e)
        {
            if (txtCodEmail.Text == "Email")
            {
                txtCodEmail.Text = "";
                txtCodEmail.ForeColor = Color.Black;
            }
        }

        private void txtCodEmail_Leave(object sender, EventArgs e)
        {
            if (txtCodEmail.Text == "")
            {
                txtCodEmail.Text = "Email";
                txtCodEmail.ForeColor = Color.Silver;
            }
        }

        private void txtCodDireccion_Enter(object sender, EventArgs e)
        {
            if (txtCodDireccion.Text == "Dirección")
            {
                txtCodDireccion.Text = "";
                txtCodDireccion.ForeColor = Color.Black;
            }
        }

        private void txtCodDireccion_Leave(object sender, EventArgs e)
        {
            if (txtCodDireccion.Text == "")
            {
                txtCodDireccion.Text = "Dirección";
                txtCodDireccion.ForeColor = Color.Silver;
            }
        }

        private void txtCodTelefono_Enter(object sender, EventArgs e)
        {
            if (txtCodTelefono.Text == "Telefono")
            {
                txtCodTelefono.Text = "";
                txtCodTelefono.ForeColor = Color.Black;
            }
        }

        private void txtCodTelefono_Leave(object sender, EventArgs e)
        {
            if (txtCodTelefono.Text == "")
            {
                txtCodTelefono.Text = "Telefono";
                txtCodTelefono.ForeColor = Color.Silver;
            }
        }

        private void btnRegCAtras_Click(object sender, EventArgs e)
        {
            opciones objFromOpciones = new opciones(objEstudiante);
            objFromOpciones.activarBtnSolicitar(false);
            //objFromOpciones.activarBtnCodeudor(false);
            //Visible la ventana de Registro
            objFromOpciones.Visible = true;
            //No mostrar la venta principal 
            Visible = false;
        }
        //#endregion


    }

}
