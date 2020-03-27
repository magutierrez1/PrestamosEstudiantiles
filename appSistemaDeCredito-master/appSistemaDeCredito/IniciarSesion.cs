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
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Variables para capturar los datos digitados en la vista 
            String email;
            String contrasena;
            //Variables para realizar consultas con la base de datos 
            DaoEstudianteGestion gestion = new DaoEstudianteGestion();
            //Variable para obtener los resultados de las consultas
            DataSet objDateSet = new DataSet();


            //Validacion de que los campos no esten vacios 
            if (estaVacio(txtIniciarContrasena.Text) == false && estaVacio(txtIniciarEmail.Text) == false)
            {
                //Capturar los datos de los txt
                email = txtIniciarEmail.Text;
                contrasena = txtIniciarContrasena.Text;

                //Consultamo en daoEstuante si hay un estudiante con ese email y contraseña (retorna filas si encuentra registros)
                objDateSet = gestion.verificarIniciarSesion(email, contrasena);

                //Verificando que si se haya retornado filas en el consulta con la variable anterior 
                if (objDateSet.Tables[0].Rows.Count > 0)
                {
                    //Se toman los datos extraidos de la base de datos para crear un objeto de Estudiante 
                    String tipoDocEst = objDateSet.Tables[0].Rows[0][0].ToString();
                    long idEst = long.Parse(objDateSet.Tables[0].Rows[0][1].ToString());
                    String nombresEst = objDateSet.Tables[0].Rows[0][2].ToString();
                    String apellidosEst = objDateSet.Tables[0].Rows[0][3].ToString();
                    String generoEst = objDateSet.Tables[0].Rows[0][4].ToString();
                    String nombreIESEst = objDateSet.Tables[0].Rows[0][5].ToString();
                    String emailEst = objDateSet.Tables[0].Rows[0][6].ToString();
                    String direccionEst = objDateSet.Tables[0].Rows[0][7].ToString();
                    long telefonoEst = long.Parse(objDateSet.Tables[0].Rows[0][8].ToString());
                    String contrasemaEst = objDateSet.Tables[0].Rows[0][9].ToString();
                    Estudiante objEstudiante = new Estudiante(tipoDocEst, idEst, nombresEst, apellidosEst, generoEst, nombreIESEst, emailEst, direccionEst, telefonoEst, contrasemaEst);

                    //Se crea objeto para activar la vista opciones  
                    opciones objFromOpcion = new opciones(objEstudiante);
                    //Se activa el boton para registrar el codeudor 
                    objFromOpcion.activarBtnCodeudor(true);
                    //Se desactiva el boton para que no realice el prestamo, mientras no se registre el codeudor 
                    objFromOpcion.activarBtnSolicitar(false);
                    //Visible la ventana de Registro
                    objFromOpcion.Visible = true;
                    //No mostrar la venta principal 
                    Visible = false;

                }
                else
                {
                    MessageBox.Show("Su intento para conectarse no tuvo exito. Causa: Usuario o Contraseña invalido, por favor reviso los datos ingresados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Complete todos los campos ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region procedimientos auxiliares 
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

        #region Mensaje de error para casillas vacias
        private void validarVacioContrasena(object sender, EventArgs e)
        {
            if (txtIniciarContrasena.Text == "")
            {
                epVacio.SetError(txtIniciarContrasena, "Introduzca Contraseña");
                txtIniciarContrasena.Focus();
            }
            else
            {
                epVacio.Clear();
            }
        }

        private void validarVacioEmail(object sender, EventArgs e)
        {
            if (txtIniciarEmail.Text == "")
            {
                epVacio.SetError(txtIniciarEmail, "Introduzca Email");
                txtIniciarEmail.Focus();
            }
            else
            {
                epVacio.Clear();
            }
        }

        #endregion

        private void txtIniciarEmail_Enter(object sender, EventArgs e)
        {
            if (txtIniciarEmail.Text == "Email")
            {
                txtIniciarEmail.Text = "";
                txtIniciarEmail.ForeColor = Color.Black;
            }
        }

        private void txtIniciarEmail_Leave(object sender, EventArgs e)
        {
            if (txtIniciarEmail.Text == "")
            {
                txtIniciarEmail.Text = "Email";
                txtIniciarEmail.ForeColor = Color.Silver;
            }
        }

        private void txtIniciarContrasena_Enter(object sender, EventArgs e)
        {
            if (txtIniciarContrasena.Text == "Contraseña")
            {
                txtIniciarContrasena.Text = "";
                txtIniciarContrasena.ForeColor = Color.Black;
            }
        }

        private void txtIniciarContrasena_Leave(object sender, EventArgs e)
        {
            if (txtIniciarContrasena.Text == "")
            {
                txtIniciarContrasena.Text = "Contraseña";
                txtIniciarContrasena.ForeColor = Color.Silver;
            }
        }

        private void btnSesionAtras_Click(object sender, EventArgs e)
        {
            VistaPrincipal objFromOpciones = new VistaPrincipal();
            objFromOpciones.Visible = true;
            //No mostrar la venta principal 
            Visible = false;
        }
    }
}
