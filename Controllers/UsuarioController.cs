using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using prueba2.Model;
using prueba2.Service;

namespace prueba2.Controllers
{
     
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly IUsuarioService usuarioService;

    public UsuarioController(ILogger<UsuarioController> logger,IUsuarioService usuarioService)
    {
        this.usuarioService = usuarioService;
        this._logger = logger;
    }
        [HttpGet("{cedula}")]
    public Usuario  GetByCedulaAsync(string cedula)
    {
        
        Usuario usuario = usuarioService.consultarPorCedula(cedula);
        if(usuario != null){
            this._logger.LogError("||METODO GET||CEDULA: "+usuario.Cedula+"||CODIGO 200");
        }
        else {
            this._logger.LogError("||METODO GET||CEDULA: NO ENCONTRADA||CODIGO 204");
        }
        return usuario;
    }
    }
}