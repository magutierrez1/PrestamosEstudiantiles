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
    public partial class Actualizar_Info_General : Form
    {
        //Dato del estudiante
        private Estudiante objEstudiante; 

        public Actualizar_Info_General(Estudiante prmEstudiante)
        {
            InitializeComponent();
            objEstudiante = prmEstudiante;
            llenarCampos(prmEstudiante);
        }

        private void llenarCampos(Estudiante prmEstudiante)
        {
            txtActEstNombre.Text = prmEstudiante.getNombresEst();
            txtActEstApellido.Text = prmEstudiante.getApellidosEst();
            txtActEstNomIes.Text = prmEstudiante.getNombreIESEst();
            if (prmEstudiante.getGeneroEst().Equals("F"))
            {
                rdActEstFemenino.Checked = true;
            }
            else
            {
                rdActEstMasculino.Checked = true;
            }
        }

        private void btnActInfGeneral_Click(object sender, EventArgs e)
        {
            //Variables para capturar Datos
            String nombre = "";
            String apellido  = "";
            String nombreIes = "";
            String genero = "";

            nombre = txtActEstNombre.Text;
            apellido = txtActEstApellido.Text;
            nombreIes = txtActEstNomIes.Text;
            if (rdActEstFemenino.Checked == true )
            {
                genero = "F";
            }
            else
            {
                genero = "M";
            }

            if (estaVacio(nombre) == false && estaVacio(apellido) == false &&  estaVacio(nombreIes) == false)
            {
                objEstudiante.setNombresEst(nombre);
                objEstudiante.setNombreIESEst(nombreIes);
                objEstudiante.setApellidosEst(apellido);
                objEstudiante.setGeneroEst(genero);

                DaoEstudianteGestion gestion = new DaoEstudianteGestion();
                gestion.actualizarInfoGeneral(objEstudiante);
                MessageBox.Show("Se actualizo la informacion general ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form objFromCodeudor = new ActualizarEstudiante(objEstudiante);
                //Visible la ventana de Registro
                objFromCodeudor.Visible = true;
                //No mostrar la venta principal 
                Visible = false;
            }
            else
            {
                MessageBox.Show("Error no se digito todos los campos ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActInfGeneralAtras_Click(object sender, EventArgs e)
        {
           
            Form objFromCodeudor = new ActualizarEstudiante (objEstudiante);
            //Visible la ventana de Registro
            objFromCodeudor.Visible = true;
            //No mostrar la venta principal 
            Visible = false;
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

        private void validarActEstNom(object sender, KeyPressEventArgs e)
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

        private void validarActEstApe(object sender, KeyPressEventArgs e)
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

        private void validarActEstNomIes(object sender, KeyPressEventArgs e)
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
    }
}
