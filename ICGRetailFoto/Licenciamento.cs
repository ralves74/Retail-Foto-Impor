using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICGRetailFoto
{
    class Licenciamento
    {
        static char[] barra ={' ','A','B','C','D','E','F','G','H','I','K','J','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','0','1','2','3','4','5','6','7','8','9','0'};
        public static string Cifrar(string textoNaoCifrado)
        {
            string cifra = "";
            foreach(char c in textoNaoCifrado)
            { 
                 cifra += barra[ (Array.IndexOf( barra, c) + 15) % 27 ];
             }
            return cifra ;
        }
        public static string Decifrar(string textoCifrado)
        {
        string textoOriginal = "";
        foreach(char c in textoCifrado)
        {
        textoOriginal += barra[(Array.IndexOf(barra, c) - 15 + 27) % 27];
        }
        return textoOriginal;
        }
        }
    }

