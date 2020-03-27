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
    public partial class HistorialPrestamo : Form
    {
        private Estudiante objEstudiante;

        public HistorialPrestamo(Estudiante prmEstudiante)
        {
            InitializeComponent();
            objEstudiante = prmEstudiante;
            llenarTabla();
        }

        #region Get y Set
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

            for ( int fila = 0; fila < valorfila; fila ++ )
            {
                //Adiccionar nuevo renglon
                dgVHistorial.Rows.Add();
                //colocamos la informacion
                dgVHistorial.Rows[fila].Cells[0].Value =  objDateSet.Tables[0].Rows[fila][5].ToString() + " " + objDateSet.Tables[0].Rows[fila][6].ToString();
                dgVHistorial.Rows[fila].Cells[1].Value = objDateSet.Tables[0].Rows[fila][7].ToString();
                dgVHistorial.Rows[fila].Cells[2].Value = objDateSet.Tables[0].Rows[fila][2].ToString();
                dgVHistorial.Rows[fila].Cells[3].Value = objDateSet.Tables[0].Rows[fila][11].ToString();
                dgVHistorial.Rows[fila].Cells[4].Value = objDateSet.Tables[0].Rows[fila][8].ToString();
                dgVHistorial.Rows[fila].Cells[5].Value = objDateSet.Tables[0].Rows[fila][9].ToString();
                dgVHistorial.Rows[fila].Cells[6].Value = objDateSet.Tables[0].Rows[fila][10].ToString();

                if (objDateSet.Tables[0].Rows[fila][11].ToString().Equals("EN ESPERA"))
                {
                    randomEstado(int.Parse(objDateSet.Tables[0].Rows[fila][7].ToString()));
                }
            }
            
            
        }

        private void btnHistorialAtras_Click(object sender, EventArgs e)
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

        public void randomEstado( int prmIdPrestamo )
        {
            String estado = "";
            DaoPrestamo gestion = new DaoPrestamo();
            Random aux = new Random();
            int idprest = aux.Next(1, 100);
            if ( idprest % 2 == 0)
            {
                estado = "EN ESPERA";
            }
            else
            {
                if (idprest % 5 == 0) {  estado = "APROBADO"; }
                else { estado = "REPROBADO"; }
                gestion.cambiarEstado(prmIdPrestamo, estado);
               
            }


        }


    }
}
