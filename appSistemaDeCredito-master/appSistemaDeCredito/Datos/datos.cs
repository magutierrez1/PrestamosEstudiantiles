using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace appSistemaDeCredito.Datos
{
    class datos
    {
        //despues de crear la tabla en eql
        //construyo la cadena de conexion  
        string cadenaConexion = "Data Source = localhost; User ID = SisCredito; Password=oracle;";

        //metodo para ejecutar un insert, update o delete

        public int ejecutarDML(string consulta)
        {

            int filasAfectadas;

            //1. creo una conexion
            OracleConnection miConexxion = new OracleConnection(cadenaConexion);

            //2. crear un comando
            OracleCommand comando = new OracleCommand(consulta, miConexxion);

            //3. abrir la conexxion
            miConexxion.Open();

            //4. ejecuto el comando, este devuelve el numero de filas que se afectaron con un inserct, update o delete 
            filasAfectadas = comando.ExecuteNonQuery();

            //5. cierro la conexxion
            miConexxion.Close();

            //6. retornar
            return filasAfectadas;


        }

        public DataSet ejecutarSELECT(string consulta)
        {
            //1.creo un dataSet vacio
            DataSet ds = new DataSet();

            //2. creo un adaptador 
            OracleDataAdapter adaptador = new OracleDataAdapter(consulta, cadenaConexion);

            //3. lleno el dataSet atraves del asaptador
            adaptador.Fill(ds, "ResultadoDatos");
            return ds;
        }
    }
}
