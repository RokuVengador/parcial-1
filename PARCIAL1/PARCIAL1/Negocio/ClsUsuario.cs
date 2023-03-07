using PARCIAL1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL1.Negocio
{
    public class ClsUsuario
    {
        public string Acceso(Usuario user)
        {
            if (user.Nombre == "mario" && user.Contra == 12345)
            {
                return "inicio de secion incorrecto, intenta nuevamente";
            }
            else
            {
                return "Nombre o contrasena incorrecta";
            }
        }   
    }
}
