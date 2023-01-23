using ProjetoBase.Classes;

//Livro LivroInfantil = new Livro();

//    LivroInfantil.Titulo = "A Bela e a Fera";
//    LivroInfantil.Autor = "Maria Oliveira";
//    LivroInfantil.Editora = "Crescer Editora";

//System.Console.WriteLine($"******** Livro Infantil ********");
//System.Console.WriteLine($"Titulo: {LivroInfantil.Titulo}");
//System.Console.WriteLine($"Autor: {LivroInfantil.Autor}");
//System.Console.WriteLine($"Editora: {LivroInfantil.Editora}");

//LivroInfantil.CalculaTempoDeLeitura();

//System.Console.WriteLine();
//System.Console.WriteLine();

//Livro LivroTecnico = new Livro();

//LivroInfantil.Titulo = "Tecnicas de Programação Orientada com C#";
//LivroInfantil.Autor = "Ana Oliveira";
//LivroInfantil.Editora = "Editora Código";


//System.Console.WriteLine($"******** Livro Técnico ********");
//System.Console.WriteLine($"Titulo: {LivroInfantil.Titulo}");
//System.Console.WriteLine($"Autor: {LivroInfantil.Autor}");
//System.Console.WriteLine($"Editora: {LivroInfantil.Editora}");

//LivroInfantil.CalculaTempoDeLeitura();

// conceito de herança
// instancia de classe
UsuarioComum usComum1 = new UsuarioComum();
UsuarioComum usComum2 = new UsuarioComum();

UsuarioAdm usAdm = new UsuarioAdm();

//preenchendo dos dados
//usuario 1
usComum1.nome = "Rogerio";
usComum1.email = "rogerio@rogerio.com";
usComum1.endereco = "Rua de Casa 123";
usComum1.idCom = 1;

//usuario 2
usComum2.nome = "Maria";
usComum2.email = "maria@maria.com";
usComum2.endereco = "Rua do Portal da Cidade 22";
usComum2.idCom = 2;

//usuario ADM **
usAdm.nome = "Marcos";
usAdm.email = "mar.cao@silva.com";
usAdm.endereco = "Rua do Estado 556";

System.Console.WriteLine($"Usuario 1: {usComum1.nome}");
System.Console.WriteLine($"Usuario 2: {usComum2.nome}");
System.Console.WriteLine($"Usuario Admin: {usAdm.nome}");
