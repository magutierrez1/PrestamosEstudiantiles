using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSistemaDeCredito.Logica
{
    public class Estudiante
    {
        private String tipoDocEst;
        private long idEst;
        private String nombresEst;
        private String apellidosEst;
        private String generoEst;
        private String nombreIESEst;
        private String emailEst;
        private String direccionEst;
        private long telefonoEst;
        private String contrasemaEst;

        private codeudor objCoudeudor;
        private Prestamo objPrestamo;

        #region constructor
        public Estudiante() { }

        public Estudiante(String tipoDocEst, long idEst, String nombresEst, String apellidosEst, String generoEst, String nombreIESEst, String emailEst, String direccionEst, long telefonoEst, String contrasemaEst)
        {
            this.tipoDocEst = tipoDocEst;
            this.idEst = idEst;
            this.nombresEst = nombresEst;
            this.apellidosEst = apellidosEst;
            this.generoEst = generoEst;
            this.nombreIESEst = nombreIESEst;
            this.emailEst = emailEst;
            this.direccionEst = direccionEst;
            this.telefonoEst = telefonoEst;
            this.contrasemaEst = contrasemaEst;
        }
        #endregion

        #region Set y Get
        public String getTipoDocEst()
        {
            return tipoDocEst;
        }

        public void setTipoDocEst(String tipoDocEst)
        {
            this.tipoDocEst = tipoDocEst;
        }

        public long getIdEst()
        {
            return idEst;
        }

        public void setIdEst(long idEst)
        {
            this.idEst = idEst;
        }

        public String getNombresEst()
        {
            return nombresEst;
        }

        public void setNombresEst(String nombresEst)
        {
            this.nombresEst = nombresEst;
        }

        public String getApellidosEst()
        {
            return apellidosEst;
        }

        public void setApellidosEst(String apellidosEst)
        {
            this.apellidosEst = apellidosEst;
        }

        public String getGeneroEst()
        {
            return generoEst;
        }

        public void setGeneroEst(String generoEst)
        {
            this.generoEst = generoEst;
        }

        public String getNombreIESEst()
        {
            return nombreIESEst;
        }

        public void setNombreIESEst(String nombreIESEst)
        {
            this.nombreIESEst = nombreIESEst;
        }

        public String getEmailEst()
        {
            return emailEst;
        }

        public void setEmailEst(String emailEst)
        {
            this.emailEst = emailEst;
        }

        public String getDireccionEst()
        {
            return direccionEst;
        }

        public void setDireccionEst(String direccionEst)
        {
            this.direccionEst = direccionEst;
        }

        public long getTelefonoEst()
        {
            return telefonoEst;
        }

        public void setTelefonoEst(long telefonoEst)
        {
            this.telefonoEst = telefonoEst;
        }

        public String getContrasemaEst()
        {
            return contrasemaEst;
        }

        public void setContrasemaEst(String contrasemaEst)
        {
            this.contrasemaEst = contrasemaEst;
        }

        public codeudor getobjCodeudor()
        {
            return objCoudeudor;
        }

        public void setobjCodeudor(codeudor objCoudeudor)
        {
            this.objCoudeudor = objCoudeudor;
        }

        public void setPrestamo(Prestamo prmPrestamo)
        {
            objPrestamo = prmPrestamo;
        }

        public Prestamo getPrestamo()
        {
            return objPrestamo;
        }
        #endregion
    }
}
