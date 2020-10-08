
### Este exame será retirado em 31 de janeiro de 2021 às 23h59, horário central. Você não poderá mais fazer o exame após essa data. Saiba mais sobre outros exames que serão retirados [aqui](https://docs.microsoft.com/en-us/learn/certifications/retired-certification-exams)

<ul>
{% for post in site.posts %}
<li>
<a href="{{ site.baseurl }}{{ post.url }}">{{ post.title }}</a>
</li>
{% endfor %}
</ul>

1. [Criar_usar_tipos](https://github.com/shyoutarou/Exam-70-483_Criar_usar_tipos/wiki/Criar_usar_tipos)
     - [GitHub Page](https://shyoutarou.github.io/Exam-70-483_Criar_usar_tipos/)
2. [Gerenciar_fluxo](https://github.com/shyoutarou/Exam-70-483_Gerenciar_fluxo/wiki/Gerenciar_fluxo)
     - [GitHub Page](https://shyoutarou.github.io/Exam-70-483_Gerenciar_fluxo/)
3. [Acesso_dados](https://github.com/shyoutarou/Exam-70-483_Acesso_dados/wiki/Acesso_dados)
     - [GitHub Page](https://shyoutarou.github.io/Exam-70-483_Acesso_dados/)
4. [Depurar_segurança](https://github.com/shyoutarou/Exam-70-483_Depurar_seguranca/wiki/Depurar_seguranca)
     - [GitHub Page](https://shyoutarou.github.io/Exam-70-483_Depurar_seguranca/)
5. [Csharp8_Csharp9](https://github.com/shyoutarou/Exam-70-483_Csharp8_Csharp9/wiki/Csharp8_Csharp9)
     - [GitHub Page](https://shyoutarou.github.io/Exam-70-483_Csharp8_Csharp9/)
6. [Questions](https://github.com/shyoutarou/Exam-70-483_Questions/wiki/Questions)

- [Course Overview MCSD – Microsoft Certification](#course-overview-mcsd--microsoft-certification)
    - [Exame 70-483/Curso 20483B](#exame-70-483curso-20483b)
    - [Criar e usar tipos (25–30%)](#criar-e-usar-tipos-2530)
    - [Gerenciar fluxo de programa (25–30%)](#gerenciar-fluxo-de-programa-2530)
    - [Implementar acesso aos dados (25–30%)](#implementar-acesso-aos-dados-2530)
    - [Depurar aplicativos e implementar segurança (25–30%)](#depurar-aplicativos-e-implementar-segurança-2530)
  - [VCE FILE](#vce-file)
  - [.NET Framework](#net-framework)
  - [Visual Studio IDE](#visual-studio-ide)
    - [Integrated Development Environment (IDE) Available Editions:](#integrated-development-environment-ide-available-editions)
    - [Ultimate, Premium, Professional, Test Professional editions](#ultimate-premium-professional-test-professional-editions)
    - [Express edition](#express-edition)
    - [Community edition](#community-edition)
  - [C# Basics](#c-basics)
    - [CARACTERÍSTICAS DE C](#características-de-c)
    - [C# foi projetado com base em sete pontos básicos](#c-foi-projetado-com-base-em-sete-pontos-básicos)
    
# Course Overview MCSD – Microsoft Certification

A Microsoft oferece atualmente quatro certificações MCSD com base em várias tecnologias
- MCSD: Windows Store Apps
- MCSD: Web Applications
- MCSD: SharePoint Applications
- MCSD: Application Lifecycle Management

The MCSD: Windows Store Apps can be achieved by passing three exams:
- Programming in C# (Exam 70-483)
- Essentials of Developing Windows Store Apps Using C# (Exam 70-484) 
    - **Esse exame foi desativado**
-Advanced Windows Store App Development Using C# (Exam 70-485) 
    - **Esse exame foi desativado**

### Exame 70-483/Curso 20483B

**Programação em C#**
Este exame é destinado a desenvolvedores com um ano de experiência ou mais em programação de lógica de aplicativo/negócio essencial para diversos tipos de aplicativos e plataformas de hardware/software usando C#.

**Exame 70-357: Desenvolvendo Aplicativos Móveis**
**Desenvolvendo Aplicativos Móveis**

**Este exame será retirado em 31 de janeiro de 2021 às 23h59** [Saiba mais](https://docs.microsoft.com/en-us/learn/certifications/retired-certification-exams)

Candidatos para o exame são os desenvolvedores experientes que projetam e desenvolvem aplicativos para Windows 10 de implantação para Windows Store ou Windows Store for Business.

Os candidatos têm, normalmente, mais de dois anos de experiência no desenvolvimento de aplicativos do Windows usando C# e XAML, além de experiência com WPF ou Silverlight para Windows Phone. Os candidatos também devem ter experiência com o padrão de projeto Model-View-ViewModel (MVVM) e Entity Framework, além das tecnologias de autenticação. Experiência com Visual Studio 2015 é altamente recomendada.



**Exame 70-486/Curso 20486B**
**Desenvolvendo Aplicativos Web ASP .NET MVC**

**Este exame será retirado em 31 de janeiro de 2021 às 23h59** [Saiba mais](https://docs.microsoft.com/en-us/learn/certifications/retired-certification-exams)

Este exame é destinado a desenvolvedores com no mínimo três a cinco anos de experiência no desenvolvimento de aplicativos Web ASP .NET, incluindo dois anos ou mais desenvolvendo soluções baseadas em MVC.


**Habilidades medidas**
- **60 QUESTÕES**
- **1-4 HORAS PARA COMPLETAR O EXAME**
- **PODE REVER QUESTÕES (Mas Não pode mover entre Caso de Estudos)**
- **700 passou! (Mas 700 não é 70%)**

Este exame mede sua habilidade em executar as tarefas técnicas listadas abaixo. As porcentagens indicam o peso relativo de cada área de tópico principal no exame. Quanto mais alta a porcentagem, mais perguntas você verá nessa área de conteúdo no exame. 

**Observe que as perguntas não estarão limitadas aos tópicos descritos no texto com marcadores.**

**Observação**: Existem atualizações de exame efetivas a partir de quinta-feira, 14 de dezembro de 2017. Para aprender mais sobre estas mudanças e como elas afetam as habilidades medidas, por favor baixe e reveja o Exam 483 change document.

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
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/MCSDcert.png" alt="Image" width="100%" />
</p>

[Microsoft Official Practice Test](https://global3.mindhub.com/70-483-programming-in-c-microsoft-official/p/MU-70-483?utm_source=microsoft&utm_medium=certpage&utm_campaign=msofficialpractice)

Habilidades de programação C# ou VB são necessárias para passar em uma série de outros exames MCSD
- Developing ASP.NET MVC Web Applications (70-486)
- Developing Microsoft Azure and Web Services (70-487)
- [More...](www.microsoft.com/learning)

## VCE FILE

Um arquivo Visual CertExam exame podem ser criados e modificados usando um aplicativo incluído no software Visual CertExam Suite, enquanto outro aplicativo também vem com o programa Visual CertExam Suíte é usado para tirar esses testes ou exames armazenados em um arquivo exame CertExam Visual. O programa Visual CertExam Designer é implementado com um conjunto de funcionalidades utilizadas para a inserção de perguntas e respostas de múltipla escolha em um teste ou exame que pode ser salva como um arquivo de exame CertExam Visual. O aplicativo Visual CertExam Manager é por outro lado um programa que é usado para fazer os testes e exames armazenados em um arquivo exame Visual CertExam, e este software também oferece recursos utilizados na gestão e facilitar esses testes ou exames. O conteúdo de um arquivo de exame CertExam Visual é integrado com as especificações de codificação de dados utilizados para armazenar os dados inseridos pelo usuário Visual CertExam Designer no formato VCE. Afixada com o .vce extensão, esses testes e exames são geralmente utilizados para as avaliações de certificação ou avaliações. 

PS: Neste [examcollection](http://www.examcollection.com/70-536.html) tem mais exames no formato vce pra testar os conhecimentos pra prova.
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/RefBook.png" alt="Image" width="100%" />
</p>

Outro site para treinar questõe é [Exam Topics](https://www.examtopics.com/exams/microsoft/70-483/view/)

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
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/LinguagensNET.png" alt="Image" width="100%" />
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
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/VersoesNET.png" alt="Image" width="100%" />
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

    **Getting Visual Studio Community Edition**
    - [Visual Studio](www.visualstudio.com)
    - Free developer tools
    - [Microsoft](www.microsoft.com)
    - Search for Visual Studio Community'
    - Download is 6.9 GB

    **Hardware requirements**
    - 1.6 GHz or faster processor
    - 1 GB of RAM (1.5 GB if running on a virtual machine)
    - 20 GB of available hard disk space
    - 5400 RPM hard disk drive
    - DirectX 9-capable video card that runs at 1024 x 768 orhigher display resolution

 
## C# Basics

### CARACTERÍSTICAS DE C#

O C# é uma linguagem de programação visual dirigida por eventos e totalmente orientada a objetos. Permite um novo grau de intercâmbio entre linguagens (componentes de software de diferentes linguagens podem interagir). Os desenvolvedores podem empacotar até software antigo, para trabalhar com novos programas C#. Além disso, os aplicativos C# podem interagir pela Internet usando padrões do setor, como SOAP (protocolo de acesso a objetos simples) e XML (linguagem de marcação extensível). 

O C# tem raízes em C, C++ e Java, adaptando os melhores recursos de cada linguagem e acrescentando novas capacidades próprias. Combina os melhores recursos das línguagens existentes anteriormente
 
- C ++
- Pascal
- Java
- Visual Basic 
 
Ele fornece os recursos que são mais importantes para os programadores, como programação orientada a objetos, strings, elementos gráficos, componentes de interface com o usuário gráfica (GUI), tratamento de exceções, múltiplas linhas de execução, multimídia (áudio, imagens, animação e vídeo), processamento de arquivos, estruturas de dados pré-empacotadas, processamento de banco de dados, redes cliente/servidor com base na Internet e na World Wide Web e computação distribuída. 


| Version | .NET Framework | Visual Studio | Important Features |
|:----------|------|---------------------|---------------------|
|C# 1.0| .NET Framework 1.0/1.1 | Visual Studio .NET 2002 | - Basic features   |
| C# 2.0 | .NET Framework 2.0  |  Visual Studio 2005 | - Generics <br>  - Partial types <br>  - Anonymous methods <br> - Iterators, a.k.a yield statement <br> - Nullable types <br> - Private Getter/setter (properties) <br> - Method group conversions (delegates)  <br> - Covariance and Contra-variance  <br>  - Static classes <br>  - Delegate inference <br>  - Type and namespace aliases  |
|C# 3.0  |  .NET Framework 3.0\3.5 |  Visual Studio 2008 | - Implicitly typed local variables <br> - Object and collection initializers <br> - Auto-Implemented properties <br> - Anonymous types <br>- Extension methods <br> - Query expressions, a.k.a LINQ    <br> - Lambda expressions <br> - Expression trees <br> - Partial Methods <br> - Lock statement  |
|C# 4.0| .NET Framework 4.0 | Visual Studio 2010 | - Dynamic binding (late binding) <br> - Named and optional arguments  <br> - Generic co- and contravariance <br> - Embedded interop types  |
|C# 5.0| .NET Framework 4.5 | Visual Studio 2012/2013 | - Async features <br>  - Caller information |
|C# 6.0| .NET Framework 4.6 | Visual Studio 2013/2015 | - Expression Bodied Methods  <br>  - Auto-property initializer <br> - nameof Expression  <br> - Primary constructor  <br> - Await in catch block  <br> - Exception Filter  <br> - String Interpolation   <br> - Compiler-as-a-service (Roslyn)  <br> - Null propagator   <br> - Dictionary initializer |
|C# 7.0| .NET Core 2.0 <br>  .NET Framework 4.7 <br>  .NET Standard 1.x | Visual Studio 2017 | - out variables <br> - Tuples   <br>  - Discards  <br>   <br> - Pattern Matching  <br> - Local functions  <br>  - Generalized async return types <br> - Numeric literal syntax improvements  <br> - Deconstruction   <br> - Binary Literals  <br> - Ref returns and locals  <br> - Throw expressions |
|C# 7.1| .NET Core 2.0 <br>  .NET Framework 4.7.1 <br>  .NET Standard 1.x | Visual Studio 2017 version 15.3 | - Async main <br>  - Default expressions <br> - Reference assemblies   <br>  - Inferred tuple element names  <br> - Pattern-matching with generics  |
|C# 7.2| .NET Core 2.0 <br>  .NET Framework 4.7.2 <br>  .NET Standard 1.x | Visual Studio 2017 version 15.5 | - Span and ref-like types <br> - In parameters and readonly references   <br>  - Ref conditional  <br> - Non-trailing named arguments  <br> - Private protected accessibility  <br>  - Digit separator after base specifier |
|C# 7.3| .NET Core 2.0 <br>  .NET Framework all <br>  .NET Standard 2.0 | Visual Studio 2017 version 15.7 | - System.Enum, System.Delegate and unmanaged constraints <br> - Ref local re-assignment   <br>  - Stackalloc initializers  <br> - Indexing movable fixed buffers  <br> - Custom fixed statement  <br>  - Expression variables in initializers and queries <br> - Tuple comparison  <br> - Attributes on backing fields   |
|C# 8.0| .NET Core 3.0 <br>  .NET Framework 4.8 | Visual Studio 2019 | - Readonly members <br> - Default interface methods  <br> - Using declarations <br> - Static local functions  <br>  - Disposable ref structs  <br> - Nullable reference types <br> - Asynchronous streams  <br> - Indices and ranges <br> - Null-coalescing assignment  <br> - Unmanaged constructed types <br>  - Stackalloc in nested expressions <br> - Enhancement of interpolated verbatim strings |
|C# 9.0| .NET 5 | Visual Studio 2019 em 09/04/2020 | - Records <br> - Init only setters  <br> - Top-level statements <br> - Pattern matching enhancements  <br>  - Native sized integers  <br> - Function pointers <br> - Suppress emitting localsinit flag  <br> - Target-typed new expressions <br> - static anonymous functions  <br> - Target-typed conditional expressions <br>  - Covariant return types <br> - Lambda discard parameters <br> - Attributes on local functions <br> - Module initializers <br> - New features for partial methods |

Abra o Prompt de Comando do Desenvolvedor para Visual Studio e execute o seguinte comando para ver a lista de versões de idioma disponíveis em sua máquina.
```csharp
csc -langversion:?
```
 <p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/langversion.png" alt="Image" width="100%" />
</p>

### C# foi projetado com base em sete pontos básicos

| Pontos | Descrição |
|:----------|------|
| Simples| - Menos operadores, sem ponteiros, etc. | 
| Moderno  | - Coleta de lixo, segurança aprimorada | 
| Orientado a objetos  |  - Encapsulamento, herança, polimorfismo <br> - Nenhuma função global, variáveis ou constantes <br> - Tudo é encapsulado dentro de uma classe | 
| Tipo seguro| - Não é possível usar variáveis não inicializadas <br> - Casts(Conv ersões de tipos) inseguros não são permitidos | 
| Versão  | - O C# suporta o de controle de versão fornecida pelo Common Language Specification (CLS) | 
| Compatível | - Permite acessar diferentes APIs <br> - Compilador garante conformidade com CLS | 
| Flexível  | - Classes e/ou métodos podem ser declarados como inseguros <br> - Habilitando o uso de ponteiros e outros itens necessários para usar outras APIs | 
 


