using Lebra.Controlador;
using Lebra.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lebra
{
    public partial class RegistroUsuario : Form
    {

        CUsuarios Cusarios = new CUsuarios();
        Usuarios usuario = new Usuarios();

        public RegistroUsuario(Usuarios usuario=null)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            //usuariosBindingSource.AddNew();
            if (usuario == null)
            {
                usuariosBindingSource.AddNew();
            }
            else
            {
                usuariosBindingSource.DataSource = usuario;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CUsuarios cusuarios = new CUsuarios();
            //Usuarios usuario = new Usuarios();
            //usuariosBindingSource.EndEdit();

            //usuario = (Usuarios)usuariosBindingSource.Current;
            //cusuarios.Insertar(usuario);
            //this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario = (Usuarios)usuariosBindingSource.Current;


            if (usuario.idUsuario == 0)
            {
                Cusarios.Insertar(usuario);
            }
            else
            {
                Cusarios.Actualizar(usuario);
            }

            this.Close();
        }

       
    }
}
