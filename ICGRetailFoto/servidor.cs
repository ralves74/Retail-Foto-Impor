using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICGRetailFoto
{
    class servidor
    {
        private string licenca;
        private string instancia;
        private string basedados;
        private string utilizador;
        private string password;

        public string Licenca
        {
            get { return licenca; }
            set { licenca = value; }
        }
        public string Instancia
        {
            get { return instancia; }
            set { instancia = value; }
        }

        public string BaseDados
        {
            get { return basedados; }
            set { basedados = value; }
        }

        public string Utilizador
        {
            get { return utilizador; }
            set { utilizador = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
