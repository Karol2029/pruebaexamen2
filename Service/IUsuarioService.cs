using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prueba2.Model;

namespace prueba2.Service
{
    public interface IUsuarioService
    {
        public Usuario consultarPorCedula(string Cedula);
    }
}