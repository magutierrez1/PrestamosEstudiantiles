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
    public partial class EliminarPrestamo : Form
    {

        private Estudiante objEstudiante;

        public EliminarPrestamo(Estudiante prmEstudiante)
        {
            InitializeComponent();
            objEstudiante = prmEstudiante;
            llenarTabla();
            //No se cambien los datos 
            cbxIdPrestamo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnEliminarPrestamo_Click(object sender, EventArgs e)
        {

            
            if (cbxIdPrestamo.SelectedItem != null )
            {
                String idPrestamo = cbxIdPrestamo.SelectedItem.ToString();
                DaoPrestamo gestion = new DaoPrestamo();
                //gestion.eliminarSolicitud(int.Parse(idPrestamo));
                //gestion.eliminarPrestamo(int.Parse(idPrestamo));
                MessageBox.Show("Se elimino satisfactoriamente su solicitud de prestamo ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvEliminarPrestamo.Rows.RemoveAt(buscarFila(idPrestamo));
            }
            else
            {
                MessageBox.Show("No ha selecionado ningun prestamo para eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
        }
        #region get set
        public void setEstudiante(Estudiante prmEstudiante)
        {
            objEstudiante = prmEstudiante;
            llenarTabla();
        }

        public Estudiante getEstudiante()
        {
            return objEstudiante;
        }
        #endregion

        public void llenarTabla()
        {
            DaoEstudianteGestion gestion = new DaoEstudianteGestion();
            DataSet objDateSet = new DataSet();
            objDateSet = gestion.consultarHistorial(objEstudiante);

            int valorfila = objDateSet.Tables[0].Rows.Count;

            for (int fila = 0; fila < valorfila; fila++)
            {
                //Adiccionar nuevo renglon
                dgvEliminarPrestamo.Rows.Add();
                //colocamos la informacion
                dgvEliminarPrestamo.Rows[fila].Cells[0].Value = objDateSet.Tables[0].Rows[fila][5].ToString() + " " + objDateSet.Tables[0].Rows[fila][6].ToString();
                dgvEliminarPrestamo.Rows[fila].Cells[1].Value = objDateSet.Tables[0].Rows[fila][7].ToString();
                dgvEliminarPrestamo.Rows[fila].Cells[2].Value = objDateSet.Tables[0].Rows[fila][2].ToString();
                dgvEliminarPrestamo.Rows[fila].Cells[3].Value = objDateSet.Tables[0].Rows[fila][11].ToString();
                dgvEliminarPrestamo.Rows[fila].Cells[4].Value = objDateSet.Tables[0].Rows[fila][8].ToString();
                dgvEliminarPrestamo.Rows[fila].Cells[5].Value = objDateSet.Tables[0].Rows[fila][9].ToString();
                dgvEliminarPrestamo.Rows[fila].Cells[6].Value = objDateSet.Tables[0].Rows[fila][10].ToString();


                if (objDateSet.Tables[0].Rows[fila][11].ToString().Equals("EN ESPERA"))
                {
                    agregarCombox(int.Parse(objDateSet.Tables[0].Rows[fila][7].ToString()));
                }
            }


            
        }

        private int buscarFila(String idprestamo)
        {
            int indice = 0;
            int numfilas = dgvEliminarPrestamo.Rows.Count;
            for (int valor = 0; valor < numfilas; valor++)
            {
               

                if (dgvEliminarPrestamo.Rows[valor].Cells[1].Equals(idPrestamo))
                {
                    return valor;
                }
            }
            return indice;
        }

        private void agregarCombox(int prmIdprestamo)
        {
            
            cbxIdPrestamo.Items.Add(prmIdprestamo);
        }

        private void btnEliminarPAtras_Click(object sender, EventArgs e)
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

        // public void 

    }
}
