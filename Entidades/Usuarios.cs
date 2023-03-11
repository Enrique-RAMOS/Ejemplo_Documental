using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebra.Entidades
{
    public class Usuarios

    {

        public int IdUsuario { get; set; }
        public string Nombre_Apellido { get; set; }
        public string Usua { get; set; }
        public string Password { get; set; }

       
       

        public int idUsuario
        {
            get { return IdUsuario; }
            set { IdUsuario = value; }
        }



        public Usuarios() { }


    }

}
