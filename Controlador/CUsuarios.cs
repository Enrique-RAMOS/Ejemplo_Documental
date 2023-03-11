﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebra.Entidades;
using Lebra.Modelos;

namespace Lebra.Controlador
{
    public class CUsuarios
    {
        MUsuarios mUsuarios = new MUsuarios();


        public void Insertar(Usuarios usuario)
        {
            mUsuarios.Insertar(usuario);
        }

        public void Actualizar(Usuarios usuario)
        {
            mUsuarios.Actualizar(usuario);
        }

        public void Eliminar(Usuarios usuario)
        {
            mUsuarios.Eliminar(usuario);
        }

        public List<Usuarios> ConsultarListado()
        {
            return mUsuarios.ConsultarListado();
        }


        //public Usuarios ConsultarUna(int id)
        //{
        //    return mUsuarios.ConsultarUna(id);
        //}




    }
}
