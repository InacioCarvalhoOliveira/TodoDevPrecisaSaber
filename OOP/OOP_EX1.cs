namespace OOP
{
    // Aqui temos um exemplo de Heranca, Encapsulamento e Polimorfismo em C#
    public class Program
    {
        // Classe publica que contem os atributos e metodos do carro
        public class Carro
        {

            public int QtdPorta { get; set; } = 3;
            public string Cor { get; set; } = "Prata";
            private string Placa { get; set; } = "EDK2024";

            // Metodo publico que retorna um booleano
            public bool ligarMotor()
            {
                bool estaLigado = true;
                Console.WriteLine("O motor está ligado!");
                return estaLigado;
            }

            // Metodo publico que retorna uma string
            public string informacoesVeiculo()
            {
                var ficha = ($" QtdPorta: {QtdPorta},\n Cor: {Cor},\n Placa: {Placa}");
                Console.WriteLine(ficha);
                return ficha;
            }
        }
        // Classe publica que herda de Carro e contem metodos que acessam os metodos da classe Carro
        public class Teste : Carro
        {
            public void testarMotor()
            {
                ligarMotor();
            }
            public void fichaTecnica()
            {
                informacoesVeiculo();
            }
        }

        // Classe publica que contem o metodo Main que instancia a classe Teste e acessa seus metodos e atributos
        public class Program
        {
            public static void Main(string[] args)
            {
                Teste teste = new Teste(); // Instancia da classe Teste que herda de Carro  
                teste.testarMotor();       //  retorna "O motor está ligado!"
                teste.fichaTecnica();      // retorna "QtdPorta: 3, Cor: Prata, Placa: EDK2024"

                var r1 = teste.QtdPorta; // isso retorna o valor contido em {QtdPorta}
                var r2 = teste.Cor;      // isso retorna o texto contido em {Cor}
                var r3 = teste.Placa;    // aqui temos um erro de acesso a um objeto Privado, faz com que a aplicacao nao compile 

                Console.WriteLine(r1); // retona = 3
                Console.WriteLine(r2); // retorna = "Prata"
                Console.WriteLine(r3); // aqui temos um erro de acesso a um objeto Privado 

            }
        }
    }
}