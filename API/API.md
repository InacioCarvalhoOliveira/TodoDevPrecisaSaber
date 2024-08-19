![API IMAGEM](https://velog.velcdn.com/images/yhko1992/post/f9311e90-0043-46a9-a935-9bfe85b985c4/image.png)

## Definição de api :
Uma API (Application Programming Interface) é um conjunto de regras e protocolos que permite a comunicação entre diferentes softwares. Ela define os métodos e formatos de dados que podem ser utilizados para interagir com um determinado sistema ou serviço. Uma API fornece uma interface consistente e padronizada para que os desenvolvedores possam acessar e utilizar as funcionalidades de um software de forma programática, sem precisar conhecer os detalhes internos de sua implementação. Isso facilita a integração entre sistemas e permite que diferentes aplicações se comuniquem de forma eficiente e segura.

**Definição abstrata** :

Um exemplo simples de como uma API funciona usando um restaurante como exemplo no mundo real é o seguinte:

Suponha que você queira fazer um pedido em um restaurante usando um aplicativo de entrega de comida. O restaurante possui uma API que permite que o aplicativo se comunique com o sistema do restaurante.

Quando você faz um pedido no aplicativo, o aplicativo envia uma solicitação para a API do restaurante, especificando os detalhes do pedido, como o tipo de comida, a quantidade, o endereço de entrega, etc.

A API do restaurante recebe essa solicitação e processa as informações. Ela verifica se o restaurante pode atender ao pedido, se os itens estão disponíveis, calcula o preço total, etc.

Em seguida, a API do restaurante envia uma resposta de volta para o aplicativo de entrega de comida, contendo os detalhes do pedido confirmado, como o tempo estimado de entrega, o número do pedido, etc.

O aplicativo de entrega de comida exibe essas informações para você, permitindo que você acompanhe o status do seu pedido.

Nesse exemplo, a API do restaurante atua como uma ponte de comunicação entre o aplicativo de entrega de comida e o sistema do restaurante. Ela define os métodos e formatos de dados que podem ser utilizados para fazer pedidos, obter informações sobre o cardápio, etc. Essa interface consistente e padronizada facilita a integração entre o aplicativo e o restaurante, permitindo que eles se comuniquem de forma eficiente e segura.

### Métodos e formatos de dados
Existem vários métodos HTTP que podem ser utilizados em uma API. Alguns dos principais métodos são:

**OS MAIS UTILIZADOS E COMUNS**
- GET: O método GET é utilizado para recuperar informações de um recurso. Por exemplo, ao fazer uma requisição GET para a rota "/users", você pode obter uma lista de usuários cadastrados.

- POST: O método POST é utilizado para criar um novo recurso. Por exemplo, ao fazer uma requisição POST para a rota "/users", você pode criar um novo usuário com os dados fornecidos.RETA

- DELETE: O método DELETE é utilizado para remover um recurso. Por exemplo, ao fazer uma requisição DELETE para a rota "/users/1", você pode remover o usuário com o ID 1.

- PUT: O método PUT é utilizado para atualizar um recurso existente. Por exemplo, ao fazer uma requisição PUT para a rota "/users/1", você pode atualizar os dados do usuário com o ID 1.


**OS MENOS UTILIZADOS MAIS ESPECIALIZADOS**

- FETCH: O método FETCH é uma função JavaScript que permite fazer requisições HTTP. Ele pode ser utilizado para realizar qualquer tipo de requisição, como GET, POST, DELETE, entre outros.

- HEAD: O método HEAD é utilizado para obter apenas os cabeçalhos de uma resposta HTTP, sem o corpo da resposta. Ele pode ser útil para verificar informações sobre um recurso, como o tamanho do arquivo ou a data de modificação.

- PATCH: O método PATCH é utilizado para fazer modificações parciais em um recurso existente. Por exemplo, ao fazer uma requisição PATCH para a rota "/users/1", você pode atualizar apenas alguns campos específicos do usuário com o ID 1.

- OPTIONS: O método OPTIONS é utilizado para obter informações sobre os métodos suportados por um recurso. Por exemplo, ao fazer uma requisição OPTIONS para a rota "/users", você pode obter uma lista dos métodos permitidos para interagir com a API de usuários.

- TRACE: O método TRACE é utilizado para realizar um loopback de uma requisição, permitindo que o cliente veja quais modificações foram feitas pelo servidor durante o processamento da requisição. Esse método é principalmente utilizado para fins de depuração e diagnóstico.

- CONNECT: O método CONNECT é utilizado para estabelecer uma conexão com um servidor proxy, geralmente utilizado para criar túneis seguros através de firewalls ou proxies.

    **Definição de Proxy**:

        Um servidor proxy é um intermediário entre um cliente e um servidor. Ele atua como um "proxy" ou representante do cliente, encaminhando as solicitações do cliente para o servidor e enviando as respostas do servidor de volta para o cliente.

        Um exemplo comum de uso de um servidor proxy é quando você está navegando na internet através de uma rede corporativa. O servidor proxy da empresa atua como um intermediário entre o seu dispositivo e os sites que você está acessando. Ele recebe as solicitações do seu navegador, encaminha essas solicitações para os servidores dos sites e, em seguida, envia as respostas dos servidores de volta para o seu navegador.

        O servidor proxy pode ser configurado para filtrar e bloquear determinados tipos de conteúdo, controlar o acesso à internet, melhorar o desempenho da rede, entre outras funcionalidades. Ele também pode ser usado para mascarar o endereço IP do cliente, fornecendo anonimato na navegação.

        Simplificando, um servidor proxy é um intermediário(MIDDLEWARE) que facilita a comunicação entre um cliente e um servidor, oferecendo recursos como filtragem, controle de acesso e anonimato na navegação.



### EMBATE: Api VS Api (Rest/Restful) porque tantos termos ?

Basicamente tudo faz a mesma coisa de forma diferente kk. sério, os termos são as suas ARQUITETURAS.

OK, o conceito de **API** já sabemos, mas então o que é **REST** e **RESTFUL** ??

**API REST**:
API REST (Representational State Transfer) é um estilo arquitetural para o desenvolvimento de APIs que utiliza os princípios do protocolo HTTP. Uma API REST é baseada em recursos, que são identificados por URLs (Uniform Resource Locators). Os recursos podem ser manipulados através dos métodos HTTP, como GET, POST, PUT e DELETE. Além disso, uma API REST utiliza os códigos de status HTTP para indicar o resultado de uma operação, como sucesso, erro ou redirecionamento. Uma característica importante das APIs REST é que elas são stateless, o que significa que cada requisição é independente e não mantém informações de estado entre as requisições. Isso permite que as requisições sejam tratadas de forma isolada, facilitando a escalabilidade e a manutenção da API.

**Definição abstrata**

Por exemplo, imagine que você está construindo uma aplicação de gerenciamento de tarefas. Você pode ter um recurso chamado "tarefas" que é identificado pela URL "/tarefas". Através dessa URL, você pode realizar diferentes operações, como obter a lista de tarefas existentes (usando o método GET), adicionar uma nova tarefa (usando o método POST), atualizar uma tarefa existente (usando o método PUT) ou excluir uma tarefa (usando o método DELETE).

Além disso, uma API REST utiliza os códigos de status HTTP para indicar o resultado de uma operação. Por exemplo, o código 200 indica que a operação foi bem-sucedida, o código 404 indica que o recurso não foi encontrado e o código 500 indica um erro interno do servidor.

   
**API RESTFUL**:
API RESTful é um termo utilizado para descrever uma API que segue os princípios da arquitetura REST. Uma API RESTful utiliza os mesmos princípios de uma API REST, como recursos identificados por URLs e métodos HTTP para manipulação desses recursos. No entanto, uma API RESTful também segue outras boas práticas, como a utilização de nomes de recursos no plural, a utilização de verbos HTTP para indicar a ação a ser realizada e a utilização de códigos de status HTTP adequados. Uma API RESTful é projetada para ser simples, escalável, interoperável e fácil de usar.

Em resumo, uma API é um conjunto de regras e protocolos para a comunicação entre softwares. Uma API REST é uma API baseada nos princípios do protocolo HTTP, enquanto uma API RESTful é uma API que segue os princípios da arquitetura REST, além de outras boas práticas. Ambas as abordagens são amplamente utilizadas no desenvolvimento de APIs e oferecem vantagens em termos de eficiência, escalabilidade e interoperabilidade.

🔗 [CLIQUE EM MIM: REQUISICOES HTTP](https://www.httpstatus.com.br/) 


### EMBATE FINAL Api e WebService, amigos de longa data 👯

**Definição de Webservice**:

Um Webservice é um sistema de software que permite a comunicação entre diferentes aplicativos através da internet. Ele utiliza protocolos padrão, como HTTP e XML, para permitir que aplicativos se comuniquem e compartilhem dados de forma interoperável. Um Webservice expõe suas funcionalidades através de uma API, permitindo que outros aplicativos possam consumir essas funcionalidades de forma remota.

**Relação entre Webservice e API**:

Uma API (Application Programming Interface) é um conjunto de regras e protocolos que permite a comunicação entre diferentes softwares. Um Webservice, por sua vez, é um sistema que utiliza uma API para expor suas funcionalidades e permitir a comunicação com outros aplicativos. Portanto, podemos dizer que um Webservice é uma implementação de uma API.

**Pontos positivos e negativos de cada implementação**:

- Webservice:
    - Pontos positivos:
        - Interoperabilidade: Um Webservice permite que diferentes aplicativos, desenvolvidos em diferentes linguagens de programação, possam se comunicar e compartilhar dados de forma padronizada.
        - Escalabilidade: Um Webservice pode ser facilmente escalado para atender a um grande número de requisições, permitindo que aplicativos consumidores possam utilizar suas funcionalidades de forma eficiente.
        - Segurança: Um Webservice pode implementar mecanismos de autenticação e criptografia para garantir a segurança das comunicações entre os aplicativos.
    - Pontos negativos:
        - Complexidade: A implementação de um Webservice pode ser mais complexa do que a implementação de uma API simples, envolvendo a configuração de servidores, a definição de contratos de comunicação, entre outros aspectos técnicos.
        - Overhead de comunicação: A comunicação entre aplicativos através de um Webservice pode envolver um overhead adicional, devido à serialização e desserialização dos dados, bem como à comunicação através da rede.

- API:
    - Pontos positivos:
        - Simplicidade: A implementação de uma API pode ser mais simples do que a implementação de um Webservice completo, especialmente quando se trata de uma API RESTful, que utiliza os princípios do protocolo HTTP.
        - Performance: A comunicação direta entre aplicativos através de uma API pode ser mais rápida do que a comunicação através de um Webservice, devido à eliminação do overhead de comunicação adicional.
    - Pontos negativos:
        - Restrições de interoperabilidade: Uma API pode ser restrita a uma determinada linguagem de programação ou plataforma, dificultando a comunicação entre aplicativos desenvolvidos em diferentes tecnologias.
        - Limitações de escalabilidade: Uma API pode ter limitações em termos de escalabilidade, especialmente se não for projetada para lidar com um grande volume de requisições simultâneas.


Em resumo, tanto Webservices quanto APIs têm suas vantagens e desvantagens. Webservices oferecem maior interoperabilidade e escalabilidade, mas podem ser mais complexos de implementar. APIs, por outro lado, são mais simples e podem ter melhor performance, mas podem ter restrições de interoperabilidade e escalabilidade. A escolha entre Webservice e API depende das necessidades específicas do projeto e das tecnologias utilizadas. 

-------------                                          
