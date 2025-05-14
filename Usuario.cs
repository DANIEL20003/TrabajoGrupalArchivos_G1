using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppArchivosGrupo1
{
    internal class Usuario
    {
        public string UsuarioNombre { get; set; }
        public string Contraseña { get; set; }

    
        public Usuario(string usuarioNombre, string contraseña)
        {
            UsuarioNombre = usuarioNombre;
            Contraseña = contraseña;
        }
    }
}
