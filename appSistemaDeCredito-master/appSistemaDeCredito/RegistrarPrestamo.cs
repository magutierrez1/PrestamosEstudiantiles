using System;
using appSistemaDeCredito.Logica;
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
    public partial class RegistrarPrestamo : Form
    {
        private Estudiante objEstudiante;

        public RegistrarPrestamo(Estudiante objEstudiante)
        {
            InitializeComponent();
            this.objEstudiante = objEstudiante;
            //No se cambien los datos 
            cbxPreBanco.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPreCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPreMonto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            #region variables
            String nomBanco;
            int monto;
            int cuotas;
            DataSet objDateSet_existeCodeudor = new DataSet();
            DaoCodeudorGestion gestionC = new DaoCodeudorGestion();
            DaoPrestamo gestionP = new DaoPrestamo();
            Prestamo objPrestamo;

            #endregion


            if (cbxPreBanco.SelectedItem != null && cbxPreCuotas.SelectedItem != null && cbxPreMonto.SelectedItem != null)
            {
                #region capturar datos 
                nomBanco = cbxPreBanco.SelectedItem.ToString();
                monto = int.Parse(cbxPreMonto.SelectedItem.ToString());
                cuotas = int.Parse(cbxPreCuotas.SelectedItem.ToString());
                #endregion
                //Creo el objeto con la informacion obtenida desde la vista 
                objPrestamo = new Prestamo(nomBanco, monto, cuotas);
                //Uno al prestamo con el objeto Estudiante
                objEstudiante.setPrestamo(objPrestamo);
                
                //Insertar el codeudor en la base de Datos 
                objDateSet_existeCodeudor = gestionC.consultarCodeudor(objEstudiante.getobjCodeudor().getIdCod());
                if (objDateSet_existeCodeudor.Tables[0].Rows.Count == 0)
                {
                    gestionC.registrarCodeudor(objEstudiante.getobjCodeudor());
                }

                gestionP.registrarPrestamo(objPrestamo);
                //Inserto solicitar prestamo en la BD
                gestionP.asociarUsuarioPrestamo(objEstudiante, objPrestamo);

                MessageBox.Show("Su solicitu ha sido enviado exitosamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                opciones objFromOpciones = new opciones(objEstudiante);
                objFromOpciones.activarBtnSolicitar(true);
                objFromOpciones.activarBtnCodeudor(true);
                objEstudiante.setobjCodeudor(null);
                objEstudiante.setPrestamo(null);
                //Visible la ventana de Registro
                objFromOpciones.Visible = true;
                //No mostrar la venta principal 
                Visible = false;

            }
            else
            {
                MessageBox.Show("Ingrese todos los datos  ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbxPreBanco_Enter(object sender, EventArgs e)
        {
            if (cbxPreBanco.Text == "Banco")
            {
                cbxPreBanco.Text = "";
                cbxPreBanco.ForeColor = Color.Black;
            }
        }

        private void cbxPreBanco_Leave(object sender, EventArgs e)
        {
            if (cbxPreBanco.Text == "")
            {
                cbxPreBanco.Text = "Banco";
                cbxPreBanco.ForeColor = Color.Silver;
            }
        }

        private void cbxPreMonto_Enter(object sender, EventArgs e)
        {
            if (cbxPreMonto.Text == "Monto")
            {
                cbxPreMonto.Text = "";
                cbxPreMonto.ForeColor = Color.Black;
            }
        }

        private void cbxPreMonto_Leave(object sender, EventArgs e)
        {
            if (cbxPreMonto.Text == "")
            {
                cbxPreMonto.Text = "Monto";
                cbxPreMonto.ForeColor = Color.Silver;
            }
        }

        private void cbxPreCuotas_Enter(object sender, EventArgs e)
        {
            if (cbxPreCuotas.Text == "Cuotas")
            {
                cbxPreCuotas.Text = "";
                cbxPreCuotas.ForeColor = Color.Black;
            }
        }

        private void cbxPreCuotas_Leave(object sender, EventArgs e)
        {
            if (cbxPreCuotas.Text == "")
            {
                cbxPreCuotas.Text = "Cuotas";
                cbxPreCuotas.ForeColor = Color.Silver;
            }
        }

        private void btnRegPAtras_Click(object sender, EventArgs e)
        {
            opciones objFromOpciones = new opciones(objEstudiante);
            //objFromOpciones.activarBtnSolicitar(false);
            objFromOpciones.activarBtnCodeudor(false);
            //Visible la ventana de Registro
            objFromOpciones.Visible = true;
            //No mostrar la venta principal 
            Visible = false;
        }
    }
}
