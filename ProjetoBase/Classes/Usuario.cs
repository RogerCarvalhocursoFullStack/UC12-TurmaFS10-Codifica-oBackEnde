using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBase.Classes
{
    public class Usuario
    {
        //propriedades
        public string nome;
        public string endereco;
        public string email { get; set; }
        public string senha { get; set; }

        //métodos
        public void alterarLogin(){
            System.Console.WriteLine($"Alterar Login está em Desenvolvimento");
        }

    }
}