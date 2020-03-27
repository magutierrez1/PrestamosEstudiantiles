using appSistemaDeCredito.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSistemaDeCredito.Logica
{
    class DaoEstudianteGestion
    {
        //Captura el numero de filas que se han alterado con insert, delete y update 
        private int resultado;
        //creo un objeto de la clase datos para poder acceder a los metodos de la clase
        private datos objDatos = new datos();

        //insertar 
        public int registrarEstudiante(Estudiante objEstudiante)
        {
            string consulta = "";
            consulta = "INSERT INTO tblestudiante values ('" + objEstudiante.getTipoDocEst() + "'," + objEstudiante.getIdEst() + ",'" +
                     objEstudiante.getNombresEst() + "','" + objEstudiante.getApellidosEst() + "','" + objEstudiante.getGeneroEst() +
                     "','" + objEstudiante.getNombreIESEst() + "','" + objEstudiante.getEmailEst() + "','" + objEstudiante.getDireccionEst()
                     + "'," + objEstudiante.getTelefonoEst() + ",'" + objEstudiante.getContrasemaEst() + "')";
            resultado = objDatos.ejecutarDML(consulta);
            return resultado;
        }

        public int actualizarInfoGeneral(Estudiante objEstudiante)
        {
            string consulta = "";
            consulta = "UPDATE tblestudiante SET NOMBRESEST = '" + objEstudiante.getNombresEst() + "', APELLIDOSEST = '" + objEstudiante.getApellidosEst()
                     + "', GENEROEST = '" + objEstudiante.getGeneroEst() + "', NOMBREIESEST = '" + objEstudiante.getNombreIESEst()
                     + "' WHERE IDEST = " + objEstudiante.getIdEst();
            resultado = objDatos.ejecutarDML(consulta);
            return resultado;
        }

        public int actualizarInfoContacto(Estudiante objEstudiante)
        {
            string consulta = "";
            consulta = "UPDATE tblestudiante SET EMAILEST = '" + objEstudiante.getEmailEst() + "', DIRECCIONEST = '" + objEstudiante.getDireccionEst()
                     + "', TELEFONOEST = "+ objEstudiante.getTelefonoEst() + " WHERE IDEST = " + objEstudiante.getIdEst();
            resultado = objDatos.ejecutarDML(consulta);
            return resultado;
        }

        public int actualizarContasema(Estudiante objEstudiante)
        {
            string consulta = "";
            consulta = "UPDATE tblestudiante SET CONTRASENAEST = '" + objEstudiante.getContrasemaEst() +
                "' WHERE idest  = " + objEstudiante.getIdEst();
            resultado = objDatos.ejecutarDML(consulta);
            return resultado;
        }
        public DataSet consultarEstudiante(long id)
        {
            // creo objetos de tipo dataSet
            DataSet objDataSet = new DataSet();
            string consulta;
            consulta = "select* from TBLESTUDIANTE where idest =" + id;
            objDataSet = objDatos.ejecutarSELECT(consulta);
            return objDataSet;
        }

        public DataSet existeEmail(String Email)
        {
            // creo objetos de tipo dataSet
            DataSet objDataSet = new DataSet();
            string consulta;
            consulta = "select* from TBLESTUDIANTE where emailest = '" + Email + "'";
            objDataSet = objDatos.ejecutarSELECT(consulta);
            return objDataSet;
        }

        public DataSet verificarIniciarSesion(String Email, String contrasena)
        {
            // creo objetos de tipo dataSet
            DataSet objDataSet = new DataSet();
            string consulta;
            consulta = "select* from TBLESTUDIANTE where emailest = '" + Email + "' and contrasenaest = '" + contrasena + "'";
            objDataSet = objDatos.ejecutarSELECT(consulta);
            return objDataSet;
        }

        public DataSet consultarHistorial(Estudiante objEstudiante)
        {
            // creo objetos de tipo dataSet
            DataSet objDataSet = new DataSet();
            string consulta;
            consulta = "select *   from(select idestudiante, idcodeudor, fecha_solicitud, idprestamo as idp " +
                       "from solicitar where idestudiante = " + objEstudiante.getIdEst() + 
                         ") inner join (select idcod, nombrescod, apellidoscod from tblcodeudor)"
                        + "on idcodeudor = idcod inner join tblprestamo on idp = tblprestamo.idprestamo";
            objDataSet = objDatos.ejecutarSELECT(consulta);
            return objDataSet;
        }

    }
}
