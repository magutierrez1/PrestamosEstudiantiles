using appSistemaDeCredito.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSistemaDeCredito.Logica
{
    class DaoCodeudorGestion
    {

        private int resultado;
        //creo un objeto de la clase datos para poder acceder a los metodos de la clase
        private datos objDatos = new datos();

        //insertar 
        public int registrarCodeudor(codeudor objCodeudor)
        {
            string consulta = "";
            consulta = "INSERT INTO tblCodeudor values ('" + objCodeudor.getTipoDocCod() + "'," + objCodeudor.getIdCod() + ",'" +
                     objCodeudor.getNombresCod() + "','" + objCodeudor.getApellidosCod() + "','" + objCodeudor.getGeneroCod() +
                     "','" + objCodeudor.getEmailCod() + "','" + objCodeudor.getDireccionCod()
                     + "'," + objCodeudor.getTelefonoCod() + ")";
            resultado = objDatos.ejecutarDML(consulta);
            return resultado;
        }

        public DataSet consultarCodeudor(long id)
        {
            // creo objetos de tipo dataSet
            DataSet objDataSet = new DataSet();
            string consulta;
            consulta = "select* from TBLCODEUDOR where idCod =" + id;
            objDataSet = objDatos.ejecutarSELECT(consulta);
            return objDataSet;
        }

        public DataSet existeEmail(String Email)
        {
            // creo objetos de tipo dataSet
            DataSet objDataSet = new DataSet();
            string consulta;
            consulta = "select* from TBLCODEUDOR where emailcod = '" + Email + "'";
            objDataSet = objDatos.ejecutarSELECT(consulta);
            return objDataSet;
        }


    }
}
