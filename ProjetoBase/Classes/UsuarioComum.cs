using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoBase.Interfaces;

namespace ProjetoBase.Classes
{
    public class UsuarioComum : Usuario, IRegrasPessoas
    {
        //propriedade
        public int idCom { get; set; }

        public bool validaSenha(int parSenha)
        {
             if(parSenha != 0){
                return true;
            } else {
                return false;
            }
        }

        //metodos
    }
}