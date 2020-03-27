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
    public partial class VistaPrincipal : Form
    {
        public VistaPrincipal()
        {
            InitializeComponent();
        }

        private void btnVistIniciar_Click(object sender, EventArgs e)
        {
            //Manda a la vista Iniciar Sesion 
            Form objFromIniciarSesion = new IniciarSesion();
            //Visible la ventana de Iniciar Sesion
            objFromIniciarSesion.Visible = true;
            //No mostrar la venta principal 
            Visible = false;

        }

        private void btnVistRegistrar_Click(object sender, EventArgs e)
        {
            //Manda a la vista Registrar Usuario
            Form formularioRegistrar = new RegistroEstudiante();
            //Visible la ventana de Registro
            formularioRegistrar.Visible = true;
            //No mostrar la venta principal 
            Visible = false;
        }


    }
}

