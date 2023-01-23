using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjetoBase.Classes
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public string Editora;

        //métodos
        public void CalculaTempoDeLeitura(){
            System.Console.WriteLine("Tempo de Leitura: 1 hora");
        }
    }
    
}