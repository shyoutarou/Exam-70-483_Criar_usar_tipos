# Course Overview MCSD – Microsoft Certification

A Microsoft oferece atualmente quatro certificações MCSD com base em várias tecnologias
- MCSD: Windows Store Apps
- MCSD: Web Applications
- MCSD: SharePoint Applications
- MCSD: Application Lifecycle Management

The MCSD: Windows Store Apps can be achieved by passing three exams:
- Programming in C# (Exam 70-483)
- Essentials of Developing Windows Store Apps Using C# (Exam 70-484) **Esse exame foi desativado**
-Advanced Windows Store App Development Using C# (Exam 70-485) **Esse exame foi desativado**

### Exame 70-483/Curso 20483B

**Programação em C#**
Este exame é destinado a desenvolvedores com um ano de experiência ou mais em programação de lógica de aplicativo/negócio essencial para diversos tipos de aplicativos e plataformas de hardware/software usando C#.

**Exame 70-357: Desenvolvendo Aplicativos Móveis**
**Desenvolvendo Aplicativos Móveis**
Candidatos para o exame são os desenvolvedores experientes que projetam e desenvolvem aplicativos para Windows 10 de implantação para Windows Store ou Windows Store for Business.

Os candidatos têm, normalmente, mais de dois anos de experiência no desenvolvimento de aplicativos do Windows usando c# e XAML, além de experiência com WPF ou Silverlight para Windows Phone. Os candidatos também devem ter experiência com o padrão de projeto Model-View-ViewModel (MVVM) e Entity Framework, além das tecnologias de autenticação. Experiência com Visual Studio 2015 é altamente recomendada.

**Exame 70-486/Curso 20486B**
**Desenvolvendo Aplicativos Web ASP .NET MVC**
Este exame é destinado a desenvolvedores com no mínimo três a cinco anos de experiência no desenvolvimento de aplicativos Web ASP .NET, incluindo dois anos ou mais desenvolvendo soluções baseadas em MVC.

**Habilidades medidas**
- **60 QUESTÕES**
- **1-4 HORAS PARA COMPLETAR O EXAME**
- **PODE REVER QUESTÕES (Mas Não pode mover entre Caso de Estudos)**
- **700 passou! (Mas 700 não é 70%)**

Este exame mede sua habilidade em executar as tarefas técnicas listadas abaixo. As porcentagens indicam o peso relativo de cada área de tópico principal no exame. Quanto mais alta a porcentagem, mais perguntas você verá nessa área de conteúdo no exame. 

**Observe que as perguntas não estarão limitadas aos tópicos descritos no texto com marcadores.**

Observação: Existem atualizações de exame efetivas a partir de quinta-feira, 14 de dezembro de 2017. Para aprender mais sobre estas mudanças e como elas afetam as habilidades medidas, por favor baixe e reveja o Exam 483 change document.

### Criar e usar tipos (25–30%)
- **Criar tipos** 
    - Criar tipos de valor, incluindo structs e num; criar tipos de referência, tipos genéricos, variáveis estáticas
- **Consumir tipos**
    - Box ou unbox para converter entre tipos de valor; casting tipos; converter tipos; lidar com tipos dinâmicos; garantir a interoperabilidade com código que acesse APIs COM 
- **Aplicar encapsulamento**
    - Aplicar encapsulamento usando propriedades; forçar encapsulamento usando assessores/modificadores, incluindo público, privado, protegido e interno; forçar encapsulamento usando implementação explícita de interface, construtores, métodos, classes, métodos de extensão, parâmetros opcionais e nomeados e propriedades indexadas; criar métodos sobrecarregados(overloading) e substituídos(overriding)
- **Criar e implementar uma hierarquia de classe** 
    - Projetar e implementar uma interface; herdar de uma classe base; criar e implementar classes com base nas interfaces IComparable, IEnumerable, IDisposable e IUnknown
- **Localizar, executar e criar tipos em tempo de execução usando reflexão** 
    - Criar e aplicar atributos; ler atributos; gerar código em tempo de execução usando expressões CodeDom e lambda; usar tipos do namespace System.Reflection, incluindo Assembly, PropertyInfo, MethodInfo, Type 
- **Gerenciar o ciclo de vida do objeto** 
    - Gerenciar recursos não gerenciados; implementar IDisposable, incluindo interação com finalização; gerenciar IDisposable usando a instrução Using; gerenciar finalização e coleta de lixo
- **Manipular cadeias de caracteres** 
    - Manipular cadeias de caracteres usando as classes StringBuilder, StringWriter e StringReader; pesquisar cadeias de caracteres; enumerar métodos de cadeias de caracteres; formatar cadeias de caracteres; usar interpolação de cadeia

### Gerenciar fluxo de programa (25–30%)
- **Implementar processamento multithreading e assíncrono**
    - Usar a biblioteca Task Parallel, incluindo o Parallel.For method, PLINQ, Tasks; gerar threads usando ThreadPool; desbloquear a UI; usar palavras-chave async e await; gerenciar dados usando coleções simultâneas
- **Gerenciar multithreading** 
    - Sincronizar recursos; implementar bloqueio; cancelar uma tarefa de execução longa; implementar métodos thread-safe para manipular condições de corrida
- **Implementar fluxo de programa** 
    - Iterar em itens de coleção e de matriz; programar decisões usando instruções switch, se/então e operadores; avaliar expressões
- **Criar e implementar eventos e retornos de chamada**
    - Criar manipuladores de eventos; assinar e cancelar assinatura de eventos; usar tipos delegados integrados para criar eventos; criar delegados; expressões lambda; métodos anônimos
- **Implementar manipulação de exceções** 
    - Manipular tipos de exceções, incluindo exceções SQL, exceções de rede (network exceptions), exceções de comunicação (communication exceptions), exceções de tempo limite de rede (network timeout exceptions); usar declarações de captura; usar uma classe base de uma exceção; implementar blocos try-catch-finally; lançar exceções; relançar uma exceção; criar exceções personalizadas; manipular exceções internas (inner exceptions); manipular exceções agregadas(aggregate exception)

### Implementar acesso aos dados (25–30%)
- **Realizar operações de E/S** 
    - Ler e escrever arquivos e fluxos; ler e escrever a partir da rede usando classes no namespace System.Net; implementar operações de E/S assíncronas
- **Dados de consumo**  
    - Recuperar dados de um banco de dados; atualizar dados em um banco de dados; consumir dados JSON e XML; recuperar dados usando serviços Web
- **Consultar e manipular dados e objetos usando LINQ** 
    - Consultar dados usando operadores, incluindo projetar, juntar, agrupar, obter, ignorar, agregar; criar consultas LINQ baseadas em método; consultar dados usando sintaxe de compreensão de consulta; selecionar dados usando tipos anônimos; forçar a execução de uma consulta; ler, filtrar, criar e modificar as estruturas de dados de usando LINQ to XML
- **Serializar e de-serializar dados** 
    - Serializar e de-serializar dados usando serialização binária, serialização personalizada, Serializador XML, Serializador JSON e Serializador de Contrato de Dados
- **Armazenar dados e recuperar dados de coleções**  
    - Armazenar e recuperar dados usando dicionários, matrizes, listas, conjuntos e filas; escolher um tipo de coleção; inicializar uma coleção; adicionar e remover itens de uma coleção; usar coleções tipificadas vs. coleções não tipificadas; implementar coleções personalizadas; implementar interfaces de coleções

### Depurar aplicativos e implementar segurança (25–30%)
- **Validar entrada de aplicativo** 
    - Validar dados JSON; escolher o tipo de coleta de dados adequado; gerenciar integridade de dados; avaliar uma expressão regular para validar o formato de entrada; usar funções internas para validar tipos e conteúdos
- **Realizar criptografia simétrica e assimétrica** 
    - Escolher um algoritmo de criptografia apropriado; gerenciar e criar certificados; implementar gerenciamento de chave; implementar o namespace System.Security; fazendo hash de dados; criptografar fluxos
- **Gerenciar montagens** 
    - Controlar versão de montagens; assinar montagens usando nomes fortes; implementar hospedagem lado a lado; colocar uma montagem no cache de montagens global; criar uma montagem WinMD
- **Depurar um aplicativo** 
    - Criar e gerenciar diretrizes de pré-processador; escolher um tipo de compilação apropriado; gerenciar arquivos e símbolos de banco de dados do programa (símbolos de depuração)
- **Implementar diagnóstico em um aplicativo** 
    - Implementar log e rastreamento; criação de perfil de aplicativos; criar e monitor contadores de desempenho; escrever para o log de eventos

<p align="center">
  <img src="https://github.com/shyoutarou/Exam-70-483_Criar_usar_tipos/blob/master/.github/MCSDcert.png" alt="Image" width="100%" />
</p>

[Microsoft Official Practice Test](https://global3.mindhub.com/70-483-programming-in-c-microsoft-official/p/MU-70-483?utm_source=microsoft&utm_medium=certpage&utm_campaign=msofficialpractice)


C# or VB programming skills are required to pass a number of other MCSD exams
- DevelopingASP.NET MVC WebApplications (70-486)
- Developing Microsoft Azure and Web Services (70-487)
- More... See www.microsoft.com/learning for more information

## VCE FILE

Um arquivo Visual CertExam exame podem ser criados e modificados usando um aplicativo incluído no software Visual CertExam Suite, enquanto outro aplicativo também vem com o programa Visual CertExam Suíte é usado para tirar esses testes ou exames armazenados em um arquivo exame CertExam Visual. O programa Visual CertExam Designer é implementado com um conjunto de funcionalidades utilizadas para a inserção de perguntas e respostas de múltipla escolha em um teste ou exame que pode ser salva como um arquivo de exame CertExam Visual. O aplicativo Visual CertExam Manager é por outro lado um programa que é usado para fazer os testes e exames armazenados em um arquivo exame Visual CertExam, e este software também oferece recursos utilizados na gestão e facilitar esses testes ou exames. O conteúdo de um arquivo de exame CertExam Visual é integrado com as especificações de codificação de dados utilizados para armazenar os dados inseridos pelo usuário Visual CertExam Designer no formato VCE. Afixada com o .vce extensão, esses testes e exames são geralmente utilizados para as avaliações de certificação ou avaliações. 

PS: Neste [examcollection](http://www.examcollection.com/70-536.html) tem mais exames no formato vce pra testar os conhecimentos pra prova.

<p align="center">
  <img src="https://github.com/shyoutarou/Exam-70-483_Criar_usar_tipos/blob/master/.github/RefBooks.png" alt="Image" width="100%" />
</p>


| Título | Data | Autor |
|:----------|------|---------------------|
|**The C# Programmer's Study Guide (MCSD): Exam: 70-483**|  23 jun 2017 |  Ali Asad, Hamza Ali |
|**Exam Ref 70-483 Programming in C# (MCSD)**  | 25 julho 2013  | Wouter de Kort |
|**MCSD Certification Toolkit (Exam 70-483): Programming in C#**  |  12 mai 2013 | Tiberiu Covaci, Gerry O'Brien, & 1 mais |

## .NET Framework

O .NET Framework é uma iniciativa da empresa Microsoft, que visa uma plataforma única para desenvolvimento e execução de sistemas e aplicações. Todo e qualquer código gerado para .NET pode ser executado em qualquer dispositivo que possua um framework de tal plataforma. Com ideia semelhante à plataforma Java, o programador deixa de escrever código para um sistema ou dispositivo específico, e passa a escrever para a plataforma .NET. Aplicações escritas para ele funcionam em um ambiente de software controlado, em oposição a um ambiente de hardware, através de uma máquina virtual de aplicação. 

O .NET Framework consiste basicamente em dois componentes principais que permite executar diversas linguagens permitindo grande interoperabilidade entre elas, ou seja, ela é executada no CLR e interagindo com o FCL:
- **Common Language Runtime** - CLR (Ambiente de Execução Independente de Linguagem). O CLR fornece gerenciamento de memória, controle de exceção, interoperabilidade, manipulação de processamento paralelo e concorrente, reflexão, segurança, serviços de compilação para a arquitetura específica, entre outros.
- **Framework Class Library** - FCL (Conjunto de Bibliotecas Unificadas). A FCL oferece APIs para UI de console, acesso a dados, conectividade com banco de dados, redes, web, criptografia, acesso aos serviços do sistema operacional, estruturas de dados e algoritmos diversos, facilidades para a linguagem e muito mais. 

Originalmente só funcionava no Windows, agora também funciona no Linux e no macOS através do .NET Core. Inicialmente era proprietário, mas seus fontes foram liberados. O .NET Core já nasceu como um projeto 100% aberto, contando com contribuições da comunidade através da .NET Foundation. Existem diversas variações, tais como .NET Compact Framework, .NET Micro Framework e Silverlight. 

Esta CLR é capaz de executar através da Common Language Infrastructure, uma grande quantidade de linguagens de programação, interagindo entre si como se fossem uma única linguagem. 

Algumas linguagens são: 
 
 <p align="center">
  <img src="https://github.com/shyoutarou/Exam-70-483_Criar_usar_tipos/blob/master/.github/LinguagensNET.png" alt="Image" width="100%" />
</p>


Esta plataforma permite a execução, construção e desenvolvimento de Web Services (Aplicações Web) de forma integrada e unificada. 

Originalmente a plataforma .NET baseia-se em um dos princípios utilizados na tecnologia Java (Just In Time Compiler - JIT), os programas desenvolvidos para ela são compilados duas vezes, uma na distribuição (gerando um código que é conhecido como "bytecodes") e outra na execução. 

Um programa é escrito em qualquer das linguagens de programação disponíveis para a plataforma, o código fonte gerado pelo programador é então compilado pela linguagem escolhida gerando um código intermediário em uma linguagem chamada CIL (Common Intermediate Language). 

Este novo código fonte gera um arquivo assembly, de acordo com o tipo de projeto: 
- **EXE - Arquivos Executáveis, Programas**
- **DLL - Biblioteca de Funções**
- **ASPX - Página Web**
- **ASMX - Web Service**

No momento da execução do programa ele é novamente compilado, desta vez pelo compilador JIT(Just-In-Time), de acordo com a utilização do programa, por exemplo: Temos um Web Site desenvolvido em ASP.NET, ao entrar pela primeira vez em uma página o JIT irá compila-la, nas outras vezes que algum outro usuário acessar esta página, ele usará esta compilação. 

Também é possível, através de ferramentas específicas, "pré-compilar" o código para que não se tenha o custo da compilação JIT durante a execução. 

O fato desta arquitetura utilizar a CIL gera uma possibilidade pouco desejada entre os criadores de software que é a de fazer a "engenharia reversa", ou seja, a partir de um código compilado, recuperar o código original. Isto não é uma ideia agradável para as empresas que sobrevivem da venda de softwares produzidos nesta plataforma. 

Por causa disso, existem ferramentas que "ofuscam" o código CIL, trocando nomes de variáveis, métodos, interfaces e etc para dificultar o trabalho de quem tentar uma engenharia reversa no mesmo. 

Para melhorar a performance de execução é possível gerar um código nativo após instalado com o NGEN (Gerador de Imagem Nativa). Este NGEN é uma ferramenta que melhora o desempenho de aplicativos gerenciados. Ngen.exe cria imagens nativas, que são arquivos que contém o código de máquina específico do processamento compilado e as instala no cache de imagem nativa do computador local. O tempo de execução pode usar imagens nativas do cache em vez de usar o compilador JIT para compilar o assembly original. 

 <p align="center">
  <img src="https://github.com/shyoutarou/Exam-70-483_Criar_usar_tipos/blob/master/.github/VersoesNET.png" alt="Image" width="100%" />
</p>

O .NET Framework 4 veio para melhorar, alguns pontos do Framework anterior, como por exemplo: 
- Aplicações legadas podem continuar rodando no release anterior do Framework, para não haver problemas de compatibilidade
- Possui Background Garbage Collection
- Tem suporte para aplicações Multitouch
- Consegue fazer uso das novas funcionalidades do Windows 7

Se você é um desenvolvedor Web, algumas das melhorias que são encontradas na nova versão do Framework: 
- Pré-carregamento da sua aplicação
- A utilização de Routing no ASP.NET para Web Forms
- Controle/Redução de ViewState
- A utilização do padrão MVC

## Visual Studio IDE	

### Integrated Development Environment (IDE) Available Editions:	
- Ultimate          
- Premium         
- Professional	
- Express
- Community
### Ultimate, Premium, Professional, Test Professional editions
- Fornecer vários recursos para diferentes equipes de desenvolvimento
- Varia em custo e licenciamento
### Express edition
- Livre
- Direcionado para plataforma específica (Web, C#, VB, etc.)
- Não é possível utilizar extensões

### Community edition
- Introduzido no final de 2014
- Livre
- Versão completa e extensível com poucas restrições
- Não pode ser usado em ambientes corporativos ou equipes com mais de cinco pessoas
- Pode ser usado para qualquer outro tipo de projeto comercial ou não comercial

