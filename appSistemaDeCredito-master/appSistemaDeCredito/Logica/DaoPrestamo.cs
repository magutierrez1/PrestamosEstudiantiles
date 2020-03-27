using appSistemaDeCredito.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSistemaDeCredito.Logica
{
    class DaoPrestamo
    {
        private int resultado;
        //creo un objeto de la clase datos para poder acceder a los metodos de la clase
        private datos objDatos = new datos();

        public int registrarPrestamo(Prestamo objPrestamo)
        {
            string consulta = "";

            consulta = "INSERT INTO tblprestamo  values (" + objPrestamo.getIdPrestamo() + ", '" + objPrestamo.getNomBanco() + "'," + objPrestamo.getMonto() + "," +
                       objPrestamo.getnumCoutas() + ",'"+objPrestamo.getEstado() +"')";
            resultado = objDatos.ejecutarDML(consulta);
            return resultado;
        }


        public int asociarUsuarioPrestamo(Estudiante objEstudiante, Prestamo objPrestamo)
        {

            string consulta = "";
            consulta = "INSERT INTO solicitar values (" + objPrestamo.getIdPrestamo() + "," + objEstudiante.getIdEst() + "," + objEstudiante.getobjCodeudor().getIdCod() + ",'" + DateTime.Now.ToString("dd/MM/yy") + "')";
            resultado = objDatos.ejecutarDML(consulta);
            return resultado;
        }

        public int cambiarEstado(int prmIdprestamo , String prmEstado)
        {
            string consulta = "";
            consulta = "UPDATE tblprestamo set estado = '" + prmEstado + "' where idprestamo = " + prmIdprestamo ;
            resultado = objDatos.ejecutarDML(consulta);
            return resultado;
        }

        public int eliminarSolicitud (int prmIdprestamo)
        {
            string consulta = "";
            consulta = "DELETE solicitar where idprestamo = " + prmIdprestamo;
            resultado = objDatos.ejecutarDML(consulta);
            return resultado;
        }

        public int eliminarPrestamo(int prmIdprestamo )
        {
            string consulta = "";
            consulta = "DELETE tblprestamo where idprestamo = " + prmIdprestamo;
            resultado = objDatos.ejecutarDML(consulta);
            return resultado;
        }


    }
}
