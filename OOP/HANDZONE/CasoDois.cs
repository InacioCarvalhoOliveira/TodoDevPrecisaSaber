/*
    exemplo de uso de método protegido em C#
    Aqui temos uma classe Animal com um método protegido e uma classe derivada 
    que herda de Animal e contém métodos públicos que chamam o método protegido 
    da classe base

    O método Main instancia a classe derivada e chama seus métodos públicos
    O método Main retorna "Gato: Estou me movendo... -- Miau!" 
    e "Cachorro: Estou me movendo... -- Au Au!"
*/
namespace OOP
{    
    // Classe Animal com método protegido
    public class Animal
    {
        // Método protegido
        protected void Mover()
        {
            Console.WriteLine("Estou me movendo...");
        }
    }
    
    // Classe derivada
    public class Derivada : Animal
    {
        // Método público
        public string Gato()
        { 
            Console.WriteLine("Gato:");
            Mover();
            return " -- Miau!";
        }

        public string Cachorro()
        {
            Console.WriteLine("Cachorro:");
            Mover();
            return " -- Au Au!";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância da classe derivada
            Derivada d = new Derivada();
            
            // Chamando o método público da classe derivada
            Console.WriteLine(d.Gato()); //retorno  Gato: Estou me movendo... -- Miau!
            
            // Chamando o método público da classe derivada
            Console.WriteLine(d.Cachorro()); // Cachorro: Estou me movendo... -- Au Au!                   
        }
    }
}