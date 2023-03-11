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
    public partial class MostrarUsuarios : Form
    {
        CUsuarios Cusarios = new CUsuarios();




        public MostrarUsuarios()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usuariosBindingSource.DataSource = Cusarios.ConsultarListado();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroUsuario frm = new RegistroUsuario();
            frm.ShowDialog();
            usuariosBindingSource.DataSource = null;
            usuariosBindingSource.DataSource = Cusarios.ConsultarListado();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.DataSource = Cusarios.ConsultarListado();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario = (Usuarios)usuariosBindingSource.Current;

            Cusarios.Eliminar(usuario);
            usuariosBindingSource.DataSource = Cusarios.ConsultarListado();


        }

        private void usuariosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usuariosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario = (Usuarios)usuariosBindingSource.Current;

            RegistroUsuario formulario = new RegistroUsuario(usuario);
            formulario.ShowDialog();
            //Cargar nuevamente los datos
            usuariosBindingSource.DataSource = Cusarios.ConsultarListado();
        }
    }
}
