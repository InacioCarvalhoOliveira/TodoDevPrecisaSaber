![OOP IMAGEM](https://i0.wp.com/www.institutedata.com/wp-content/uploads/2024/01/Defining-Object-Oriented-Programming-.png?resize=470%2C470&ssl=1)

## Definição da OOP:
A Programação Orientada a Objetos (OOP) é um paradigma de programação que utiliza objetos para representar e organizar o código. Nesse paradigma, os objetos são criados a partir de modelos chamados de classes, que definem suas características e comportamentos. A OOP permite a reutilização de código, facilita a manutenção e promove a modularidade do sistema, sem regras não há ordem.    0


### Os 04 Pilares da Orientação a Objetos

**Encapsulamento**: O encapsulamento é um conceito que permite agrupar **dados** e **comportamentos** relacionados em uma única unidade chamada de **classe**. Ele protege os dados internos da classe, permitindo que sejam acessados e modificados apenas através de **métodos** específicos, conhecidos como **getters** e **setters**. Isso garante que os dados sejam manipulados de forma controlada e evita que sejam alterados de maneira incorreta ou inesperada. É como se a classe fosse uma caixa preta, onde os detalhes internos são ocultados e só é possível interagir com ela através de uma interface bem definida.

**Abstração**: A abstração é o processo de identificar as características essenciais de um objeto e representá-las em uma classe. Ela permite criar modelos simplificados e mais genéricos, que representam entidades do mundo real de forma mais clara e compreensível. Por exemplo, se estivermos modelando um sistema de uma loja, podemos criar uma **classe** chamada **"Produto"** que representa os produtos vendidos pela loja. Essa classe pode ter **atributos**(O que tem) como nome, preço e quantidade em estoque, além de **métodos**(O que faz) para realizar operações relacionadas a esses produtos. A abstração nos permite focar apenas nos aspectos relevantes do objeto, ignorando detalhes desnecessários.

**Herança** e **Polimorfismo**: A herança é um mecanismo que permite criar novas classes a partir de classes existentes, aproveitando os atributos e métodos já definidos. Uma classe que herda de outra é chamada de classe **filha** ou **subclasse**, enquanto a classe original é chamada de classe **pai** ou **superclasse**. A herança permite reutilizar código, evitando a duplicação de implementação e promovendo a organização e a hierarquia entre as classes.

**Polimorfismo**: O polimorfismo é um dos pilares da Orientação a Objetos e se refere à capacidade de um objeto poder ser referenciado de diferentes formas, ou seja, um objeto pode ser tratado como uma instância de sua própria classe ou como uma instância de uma classe pai. Isso permite que diferentes objetos possam responder de maneira diferente a uma mesma mensagem, possibilitando a implementação de comportamentos específicos para cada tipo de objeto. O polimorfismo contribui para a flexibilidade e extensibilidade do código, permitindo a criação de hierarquias de classes e a implementação de interfaces comuns. 

Bom, esses são os conceitos fundamentais do paradigma da Orienteação a Objetos, agora iremos um pouco mais a fundo, tratando dos termos **Classe** / **Objeto** / **Método**

recaptulando:

    Classe - Escopo inicial obrigatório que agrupará nossos dados;  
    Objeto - Compõe a Classe, represemta entidades do mundo real;
    Método - o "o Que faz?" realiza as operações;
    Atributos - o " o Que tem?" também conhecido como "Propriedades" dando forma ao dado.


### Modificadores de acesso
Aqui está um exemplo utilizando a linguagem C#

![CLASSES IMAGEM](/img/classes.png)

##

### Modificadores de Acesso Padrão de qualquer Stack  

**public**: Quando um tipo ou membro é declarado como público, significa que **qualquer código em qualquer parte do programa pode acessá-lo**. É como se fosse uma porta aberta para todos. Por exemplo, se você tem uma classe chamada "Carro" com um método público chamado "ligarMotor", qualquer parte do programa pode chamar esse método e ligar o motor do carro.

**private**: Quando um membro é declarado como privado, significa que ***apenas o código dentro da mesma classe ou estrutura pode acessá-lo***. É como se fosse uma porta trancada que só pode ser aberta de dentro. Por exemplo, se você tem uma classe chamada "Pessoa" com um campo privado chamado "nome", apenas os métodos dentro da classe "Pessoa" podem ler ou modificar esse campo.

**protected**: Quando um tipo ou membro é declarado como protegido, significa que **apenas o código dentro da mesma classe ou em uma classe derivada (que herda da classe atual) pode acessá-lo**. É como se fosse uma porta trancada que só pode ser aberta por membros da família. Por exemplo, se você tem uma classe chamada "Animal" com um método protegido chamado "mover", apenas os métodos dentro da classe "Animal" ou em uma classe derivada, como "Cachorro" ou "Gato", podem chamar esse método.
##

### Modificadores de Acesso Exclusivos do C#

**internal**: Quando um tipo ou membro é declarado como interno, significa que a**penas o código dentro do mesmo assembly (um conjunto de arquivos de código-fonte compilados juntos) pode acessá-lo**. É como se fosse uma porta trancada que só pode ser aberta por pessoas dentro do mesmo prédio. Por exemplo, se você tem um assembly chamado "MinhaAplicacao" com uma classe interna chamada "Configuracoes", apenas o código dentro desse assembly pode criar uma instância dessa classe.

**protected internal**: Quando um tipo ou membro é declarado como interno protegido, significa que a**penas o código dentro do mesmo assembly ou em uma classe derivada em outro assembly pode acessá-lo**. É uma combinação das regras de acesso interno e protegido. Por exemplo, se você tem um assembly chamado "MinhaAplicacao" com uma classe interna protegida chamada "Configuracoes", o código dentro desse assembly ou em uma classe derivada em outro assembly pode acessar essa classe.

**private protected**: Quando um tipo ou membro é declarado como privado protegido, significa que a**penas o código dentro do mesmo assembly e na mesma classe ou em uma classe derivada pode acessá-lo**. É uma combinação das regras de acesso privado e protegido. Por exemplo, se você tem um assembly chamado "MinhaAplicacao" com uma classe privada protegida chamada "Configuracoes", apenas o código dentro desse assembly e na mesma classe ou em uma classe derivada pode acessar essa classe.

**file**: Quando um tipo ou membro é declarado como arquivo, significa que **apenas o código no mesmo arquivo pode acessá-lo**. É como se fosse uma porta trancada que só pode ser aberta por pessoas dentro da mesma sala. Por exemplo, se você tem um arquivo chamado "Utilitarios.cs" com uma classe chamada "Calculadora", apenas o código dentro desse arquivo pode criar uma instância dessa classe.

##


### Mão na Massa 
Sim, só lendo é um pouco complexo de entender, então vamos a prática!

 - Modificador público 

        // Aqui criamos nossa classe publica(Superclasse)
        public class Carro
        {
        
            public int QtdPorta { get; set; } = 3;
            public string Cor { get; set; } = "Prata";
            private string Placa { get; set; } = "EDK2024";
                
            public bool ligarMotor()
            {
                bool estaLigado = true;
                Console.WriteLine("O motor está ligado!");
                return estaLigado;
            }
            public string informacoesVeiculo()
            {
            var ficha =   ($" QtdPorta: {QtdPorta},\n Cor: {Cor},\n Placa: {Placa}");
            Console.WriteLine(ficha);
            return ficha;
            }
        }

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

        public class Program
        {
            public static void Main(string[] args)
            {
                Teste teste = new Teste();
                teste.testarMotor();
                teste.fichaTecnica();
                
                var r1 = teste.QtdPorta;
                var r2 = teste.Cor;
            // var r3 = teste.Placa;
                
                Console.WriteLine($"\n\n{r1}");
                Console.WriteLine($"\n\n{r2}");
                //Console.WriteLine(r3);
                
            }
        }








