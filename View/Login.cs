using Lebra.Modelos;
using Lebra.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lebra
{
    public partial class Login : Form
    {

        MUsuarios sqlControl = new MUsuarios();


        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int resul = sqlControl.Login(txt_Usuario.Text, txt_Password.Text);
            if (resul == 1)
            {
                Dashboard frm = new Dashboard();
                this.Hide();
                frm.ShowDialog();

            }else if (resul == 0)
            {
                MessageBox.Show("Usuario o Contraseña incorrecta.");
            }




        }

        private void txt_Usuario_Click(object sender, EventArgs e)
        {
            txt_Usuario.Text = "";
        }

        private void txt_Password_Click(object sender, EventArgs e)
        {
            txt_Password.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (txt_Password.PasswordChar == '•')
                {
                    //El PasswordChar Lo pone en nulo \0
                    txt_Password.PasswordChar = '\0';
                }
            }
            else
            {
                txt_Password.PasswordChar = '•';
            }
        }
    }
}
