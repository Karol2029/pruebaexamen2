using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prueba2.Model;

namespace prueba2.Service
{
    public class UsuarioService : IUsuarioService
    {
        private List<Usuario> usuarios;
        public Usuario consultarPorCedula(string Cedula)
        {

             Usuario? usuario = this.usuarios.Where(x => x.Cedula == Cedula)!.FirstOrDefault();
             if(usuario != null) 
                usuario.Cedula = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(usuario.Cedula!));
             return usuario!;
        }

        public UsuarioService(){
            this.usuarios = new List<Usuario>();
            Usuario usuario = new Usuario();
            usuario.Cedula = "1751448893";
            usuario.Nombre = "Karol";
            usuarios.Add(usuario);
            usuario = new Usuario();
            usuario.Cedula = "1759979956";
            usuario.Nombre = "Steven";
            usuarios.Add(usuario);
            usuario = new Usuario();
            usuario.Cedula = "1720776689";
            usuario.Nombre = "Elizabeth";
            usuarios.Add(usuario);
            usuario = new Usuario();
            usuario.Cedula = "1722220520";
            usuario.Nombre = "Daniel";
            usuarios.Add(usuario);

        }
    }


}