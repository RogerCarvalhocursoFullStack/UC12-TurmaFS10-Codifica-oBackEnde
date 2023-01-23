using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoBase.Interfaces;

namespace ProjetoBase.Classes
{
    public class UsuarioAdm : Usuario, IRegrasPessoas
    {
        //propriedades
        public int id { get; set; }

        //metodos
        public bool BloquearUsuario(int parIdCom){
            return false;
        }

        public bool validaSenha(int parSenha)
        {
            if(parSenha != 0){
                return true;
            } else {
                return false;
            }
        }
    }
}