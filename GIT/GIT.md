![GIT IMAGEM](https://media.dev.to/cdn-cgi/image/width=1000,height=420,fit=cover,gravity=auto,format=auto/https%3A%2F%2Fdev-to-uploads.s3.amazonaws.com%2Fuploads%2Farticles%2Fc7wnouyv2159dfxrik56.png)

## Definição do GIT :
O Git é um sistema de controle de versão distribuído(armazena arquivos locais) amplamente utilizado na indústria de desenvolvimento de software. Ele permite que os desenvolvedores acompanhem as alterações feitas em seus projetos ao longo do tempo, facilitando a colaboração em equipe e a rastreabilidade das alterações. O Git é conhecido por sua velocidade, eficiência e flexibilidade, tornando-o uma escolha popular para gerenciar o código-fonte de projetos de todos os tamanhos. 

## Mais sobre Sistemas de Controle de Versão
O **Git** é um dos mais populares e utilizados no quesito de Controle de versão, porem ele não é o único, temos alem dele sendo ou não **implementações** estes foram os principais que encontrei e deve ter mais rsrs :

 - GitHub = Interface Web Site mais amigável e de fácil uso(Subistitui terminal de comando por clique em botões)
 - TFS = Azure DevOps Server anteriormente chamado de Team Fundation Server, Hospedados na nuvem (tem terminal e Interface Web Site)
 - Bitbucket Cloud - Hospedado na nuvem com integrações extras a produtos da ATLASSIAN(Jira/Confluence)(100% botão clicável)
 - GitLab - Hospedado na nuvem( está implementado com IA agora e é 100% botão clicável)
 - Gitea - interface Web site mais amigavel do que a do git e capacidade de hospedar os repo na nuvem
 - Gogs - interface Web Site mais amigável e simples, para equipes que investe em interface mais simplificadas e Padawans iniciantes(100% botão clicável)


Ok, sabendo disso, como cheira e qual a cara do git? bem, a imagem acima descreve bem isso, mas, Basicamente ele é um terminal de comando, especificamente chamado GIT BASH assim como qualquer outro terminal com suas bibliotecas, tags de chamada etc. Aqui podemos fechar o entendimento do "o que é git e para o que ele serve", vamos dar sequência a pontos chave do tão grandioso Controlador de Versão Git.

Para utilizar o Git de forma Correta, primeiro é preciso entender o seu fluxo(Git Flow) que é um padrão de como disponibilizar e versionar seu projeto/código de forma organizada e escalada.

Arquitetura Git: Todo projeto é uma Branch, ou seja, para cada alteração feita neste projeto é criada uma Nova Branch com base no projeto Inicial, isso permite que uma ou mais pessoas trabalhem em uma branch(ramificação) do projeto, fazendo assim com que todos possam trabalhar/codar nos locais onde lhes foram atribuído a sua respectiva task(atividade) sem que haja conflito(assim é e esperado)  

##

Origin Main (conhecida como Master/Head) - Branch  Principal/produção

Develop - branch Secundária criada à partir da principal

Feature - branch de Desenvolvimento criada pelo Dev,à partir da branch Secundária

Hotfix  - branch criada a partir da Principal, ou seja, é uma branch de ajuste direto na branch Principal

Release - branch de Liberação criada à partir da branch Secundária, esta branch será mesclada com a branch Principal

Release Candidate - branch Candidata a Liberação criada à partir da branch Release, ou seja, podem haver várias Release Candidates

##

Repasse das nomenclaturas, é importante que os nomes pŕoprios(em Ingles) fixem fácil, para uma melhor comunicação

    Master  == Branch Principal
    Develop == Branch Secundària
    Feature == Branch do Dev
    Release == Branch de Liberação
    Hotfix  == Branch Ajuste Pontual para a Branch Principal
    Release Candidate == Branch Candidata a Liberação(uma Branch Release pode ter Várias Release Candidate)

    Merge branch == Mesclar uma branch dentro de outra

##
### Gitflow na Prática

![GIF GITGLOW](https://camo.githubusercontent.com/55c14b29762fa6257f06c615f657b2c430d4831834cd0f1a838ef8273b911064/68747470733a2f2f692e696d6775722e636f6d2f6332725a7935452e676966)

Descrição do que aconteceu aqui:

01. Na **Branch Develop**, foi criado **1 Commit**.

02. Foi gerada uma **Branch Feature** a partir da **Branch Develop**, com **1 Commit**.

03. O Commit gerado na **Branch Feature** foi mesclado com a **Branch Develop**.

04. Com base na **Branch Develop**, contendo os Commits da **Branch Feature**, foi gerada uma **Branch Release**.

05. A **Branch Releas** e foi mesclada com a **Branch Master** e a **Branch Master** foi mesclada de volta para a **Branch Develop**.

06. Foi criada uma **Branch Hotfix** na **Branch Master**.

07. Por fim, a **Branch Hotfix** criada na **Branch Master** deve ser mesclado de volta para a **Branch Develop**, pois a **Branch Master** e a **Branch Develop** devem sempre estar sincronizadas.


##
Certo, agora que foi entendida essas nomenclaturas e como se comportam agora é preciso entender de que forma são salvos esses ajustes na branch do Dev(Feature); Eles são feitos através de Commits(não existe uma definição correta pra esse termo, costumo nomea-lo de "Ajuste"). Os commits são pontos na linha do tempo de um projeto. Quando documentados propriamente nos mostram quem alterou, quando, em qual contexto e qual tipo de alteração foi feita. Existe uma Convenção para organizar os commits:

Type: Quais são os tipos de commit

O type é responsável por nos dizer qual o tipo de alteração ou iteração está sendo feita, das regras da convenção, temos os seguintes tipos:


    "test": indica qualquer tipo de criação ou alteração de códigos de teste. Exemplo: Criação de testes unitários.

    "feat": indica o desenvolvimento de uma nova feature ao projeto. Exemplo: Acréscimo de um serviço, funcionalidade, endpoint, etc.

    "refactor": usado quando houver uma refatoração de código que não tenha qualquer tipo de impacto na lógica/regras de negócio do sistema. Exemplo: Mudanças de código após um code review
    
    "style": empregado quando há mudanças de formatação e estilo do código que não alteram o sistema de nenhuma forma.
    Exemplo: Mudar o style-guide, mudar de convenção lint, arrumar indentações, remover espaços em brancos, remover comentários, etc..

    "fix": utilizado quando há correção de erros que estão gerando bugs no sistema.
    Exemplo: Aplicar tratativa para uma função que não está tendo o comportamento esperado e retornando erro.
    
    "chore": indica mudanças no projeto que não afetem o sistema ou arquivos de testes. São mudanças de desenvolvimento.
    Exemplo: Mudar regras do eslint, adicionar prettier, adicionar mais extensões de arquivos ao .gitignore

    "docs": usado quando há mudanças na documentação do projeto.
    Exemplo: adicionar informações na documentação da API, mudar o README, etc.

    "build": utilizada para indicar mudanças que afetam o processo de build do projeto ou dependências externas.    
    Exemplo: Gulp, adicionar/remover dependências do npm, etc.
    
    "perf": indica uma alteração que melhorou a performance do sistema.
    Exemplo: alterar ForEach por while, melhorar a query ao banco, etc.
    
    "ci": utilizada para mudanças nos arquivos de configuração de CI.
    Exemplo: Circle, Travis, BrowserStack, etc.
    revert: indica a reverão de um commit anterior.

    "WIP": Working-in-progress : indica mudanças recentes dentro da feature as quais integram ela, porem estão sendo melhores desenvolvidas



De forma geral Este é o conceito de Controle de Versionamento no Git deixo um link aqui contendo casos de erros que podem acontecer durante o processo :

Erros mais comuns com Git e como corrigí-los : 

**[clique em mim](https://www.campuscode.com.br/conteudos/erros-mais-comuns-com-git-e-como-corrigi-los)**

**[clique em mim](https://www.dio.me/articles/domine-o-git-e-o-github-evite-os-10-erros-iniciantes-que-podem-destruir-seus-projetos)**
