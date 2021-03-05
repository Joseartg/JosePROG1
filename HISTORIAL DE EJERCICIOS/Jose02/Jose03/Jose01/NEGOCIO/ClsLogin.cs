
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jose01.DAO;
using Jose01.DOMINIO;

namespace Jose01.NEGOCIO
{
    class ClsLogin
    {
        ClsListaUsuario cls = new ClsListaUsuario ();

        Login log = new Login();
        
        public int acceso(Login log)
        {
            int estado = 0;
            for (int i = 0; i < cls.user.Length; i++) {
                if (log.Usuario.Equals(cls.user[i]) && log.Password.Equals(cls.pass[i]))
                {
                    estado = 1;
                }
            }
            return estado;
        }

        internal void acceso(object log)
        {
            throw new NotImplementedException();
        }
    }
}
