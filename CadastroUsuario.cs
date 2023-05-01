using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static class CadastroUsuario
    {
        private static Usuario[] usuarios =
        {
            new Usuario(){login = "Eduardo", senha = "abc123"},
            new Usuario(){login = "Juca", senha = "123a"},
            new Usuario(){login = "rodolfo", senha = "rd12"}
        };
        private static Usuario _userLog = null;
        public static Usuario Userlog
        {
            get { return _userLog; }
            private set { _userLog = value; }
        }
        public static bool Login (string login, string senha)
        {
            foreach(Usuario usuario in usuarios)
            {
                if(usuario.login == login && usuario.senha == senha)
                {
                    Userlog = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
