namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        // tipos de dados simples/primitivos

string nome = "Rogerio";
int idade = 44;
double carteira = 10.50;
float sonhoLoteria = 3000000.00f;
bool tomouVacina = true;


//System.Console.WriteLine("Olá " + nome);
//System.Console.WriteLine("Idade " + idade);
//System.Console.WriteLine("Dinehiro em Carteira R$ " + carteira);
//System.Console.WriteLine("Se ganhar na loteria a carteira ficará com R$ " + carteira + sonhoLoteria);
//System.Console.WriteLine(nome + " Tomou Vacina? " + tomouVacina);
//System.Console.WriteLine( $"{nome} Tomou Vacina? {tomouVacina}");

//exemplo de interpolação que aceita caracteres especiais
Console.WriteLine(@$"
 Nome: {nome}
 Idade: {idade}
 Dinehiro em Carteira R$: {carteira}
 Se ganhar na loteria a carteira ficará com R$: {carteira + sonhoLoteria}
 {nome} Tomou Vacina? {tomouVacina}

");


    }
}









