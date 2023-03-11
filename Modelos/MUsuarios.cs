using Lebra.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lebra.Modelos
{
    public class MUsuarios
    {
        IDbConnection cn = Conexion.conectarr();

        public void Insertar(Usuarios usuarios)
        {
            try
            {
                string consulta = "IF EXISTS(SELECT Usua FROM Usuarios WHERE Usua=@Usua) RAISERROR('Ya existe un Usuario con esta ID', 16,1)" +
                                  "else Insert into Usuarios values(@Nombre_Apellido, @Usua, @Password)";
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@Nombre_Apellido", usuarios.Nombre_Apellido, DbType.String);
                parametros.Add("@Usua", usuarios.Usua, DbType.String);
                parametros.Add("@Password", usuarios.Password, DbType.String);
                cn.Open();
                cn.Execute(consulta, parametros, commandType: CommandType.Text);
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        public void Actualizar(Usuarios usuarios)
        {
            string consulta = "Update Usuarios set Nombre_Apellido='" + usuarios.Nombre_Apellido + "Usua ='" + usuarios.Usua + "' where IdUsuario=" + usuarios.idUsuario;
            cn.Open();
            cn.Execute(consulta);
            cn.Close();
        }

        public void Eliminar(Usuarios usuarios)
        {
            string consulta = "Delete from Usuarios where IdUsuario=" + usuarios.idUsuario;
            cn.Open();
            cn.Execute(consulta);
            cn.Close();
        }

        public List<Usuarios> ConsultarListado()
        {
            List<Usuarios> Usuarios = new List<Usuarios>();
            string consulta = "Select * from Usuarios";
            cn.Open();
            Usuarios = cn.Query<Usuarios>(consulta).ToList();
            cn.Close();
            return Usuarios;

        }

        public int Login (string usuario, string pass)
        {
            try
            {

                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("validar_usuario", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usua", usuario);
                cmd.Parameters.AddWithValue("@Pass", pass);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return dr.GetInt32(0);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                Conexion.cerrar();
            }

            return -1;
        }



        //public Usuarios Una(int id)
        //{

        //}
    }
}
