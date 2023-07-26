using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVVMClass1.ViewModel
{
    public class ClUsuarioEVM
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public string Imagen { get; set; }

    }
}