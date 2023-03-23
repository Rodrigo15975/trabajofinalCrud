using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaControlador
{
    public  class CN_Usuarios
    {

        private CD_Usuarios  objetoCD = new CD_Usuarios();
        
        public bool Login (string usuario , string contra)
        {
            return objetoCD.Login (usuario , contra);
        }

    }
}
