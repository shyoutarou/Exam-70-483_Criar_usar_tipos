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
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/MCSDcert.png" alt="Image" width="100%" />
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
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/RefBooks.png" alt="Image" width="100%" />
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

    #### Getting Visual Studio Community Edition
    - www.visualstudio.com
    - Free developer tools
    - www.microsoft.com
    - Search for Visual Studio Community'
    - Download is 6.9 GB
    #### Hardware requirements
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
| C# 2.0 | .NET Framework 2.0  |  Visual Studio 2005 | - Generics <br>  - Partial types <br>  - Anonymous methods <br> - Iterators <br> - Nullable types <br> - Private setters (properties) <br> - Method group conversions (delegates)  <br> - Covariance and Contra-variance  <br>  - Static classes  |
|C# 3.0  |  .NET Framework 3.0\3.5 |  Visual Studio 2008 | - Implicitly typed local variables <br> - Object and collection initializers <br> - Auto-Implemented properties <br> - Anonymous types <br>- Extension methods <br> - Query expressions   <br> - Lambda expressions <br> - Expression trees <br> - Partial Methods  |
|C# 4.0| .NET Framework 4.0 | Visual Studio 2010 | - Dynamic binding (late binding) <br> - Named and optional arguments  <br> - Generic co- and contravariance <br> - Embedded interop types  |
|C# 5.0| .NET Framework 4.5 | Visual Studio 2012/2013 | - Async features <br>  - Caller information |
|C# 6.0| .NET Framework 4.6 | Visual Studio 2013/2015 | - Expression Bodied Methods  <br>  - Auto-property initializer <br> - nameof Expression  <br> - Primary constructor  <br> - Await in catch block  <br> - Exception Filter  <br> - String Interpolation |
|C# 7.0| .NET Core 2.0 | Visual Studio 2017 | - out variables <br> - Tuples   <br>  - Discards  <br>   <br> - Pattern Matching  <br> - Local functions  <br>  - Generalized async return types <br> - Numeric literal syntax improvements |
|C# 8.0| .NET Core 3.0 | Visual Studio 2019 | - Readonly members <br> - Default interface methods  <br> - Using declarations <br> - Static local functions  <br>  - Disposable ref structs  <br> - Nullable reference types <br> - Asynchronous streams  <br> - Indices and ranges <br> - Null-coalescing assignment  <br> - Unmanaged constructed types <br>  - Stackalloc in nested expressions <br> - Enhancement of interpolated verbatim strings|

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
 
# CRIAR E USAR TIPOS (25–30%)
## Criar tipos
- **Criar tipos de valor, incluindo structs e num; criar tipos de referência, tipos genéricos, variáveis estáticas.**

### POO - PROGRAMAÇÃO ORIENTADA A OBJETOS

Essa colocação nos traz a um detalhe importante: a programação estruturada, quando bem feita, possui um desempenho superior ao que vemos na programação orientada a objetos. Isso ocorre pelo fato de ser um paradigma sequencial, em que cada linha de código é executada após a outra, sem muitos desvios, como vemos na POO. Além disso, o paradigma estruturado costuma permitir mais liberdades com o hardware, o que acaba auxiliando na questão desempenho. As vantagens do OOP são:
- O código é dividido em grupos independentes
- O código pode ser facilmente reutilizado
- Complexidade reduzida
- Desacoplamento pode ser alcançado
- Extensibilidade

### Classes

Uma classe é uma estrutura que abstrai um conjunto de objetos com características similares. Uma classe define o comportamento de seus objetos - através de métodos - e os estados possíveis destes objetos - através de atributos. Uma classe é um modelo usado para criar objetos
- Fornece detalhes necessários para criar uma versão de software de um objeto real.
- Uma classe é semelhante a um planta usada para construir edifícios. Um projeto pode ser usado para construir vários edifícios, uma classe pode ser usada para criar vários objetos

### Objetos

Um objeto, em programação orientada a objetos, é uma instância (ou seja, um exemplar) de uma classe. Um objeto é capaz de armazenar estados através de seus atributos e reagir a mensagens enviadas a ele, assim como se relacionar e enviar mensagens a outros objetos. 

Atributos são características de um objeto. Basicamente a estrutura de dados que vai representar a classe. 
Um objeto é uma variável que contém duas coisas
- As propriedades que foram definidas na classe
- As habilidades definidas como métodos na classe

Vários objetos podem ser criados com base em uma única classe. Apesar de cada objeto tem seu próprio 'estado' ou coleção exclusiva de valores de dados, como todos os objetos são baseados em classes, ao alterar uma classe afetará todos os objetos criados a partir dessa classe

Exemplos: um objeto da classe "Funcionário" teria como atributos "nome", "endereço", "telefone", "CPF", etc 
O conjunto de valores dos atributos de um determinado objeto é chamado de estado. 

### Herança (Veja mais detalhes em Aplicar Hierarquia, mais abaixo)

Herança é um princípio de orientação a objetos, que permite que classes compartilhem atributos e métodos, através de "heranças". Ela é usada na intenção de reaproveitar código ou comportamento generalizado ou especializar operações ou atributos.
- Permite que uma classe reutilize o código de outra classe
- Um único objeto pode possuir a funcionalidade de várias classes
- Evita duplicação de código

Oferece a capacidade de estender e modificar o comportamento em um ambiente de fácil manutenção. A classe cujos membros são herdados é chamada classe base e a classe que herdou esses membros é chamada classe derivada.

```bash
class Parent1
{
    public string  SurName { get; set; }
}

class Child1 : Parent1
{
    private string _name;

    public string  Name
    {
        get
        {
            return (_name + " " + base.SurName);
        }
        set
        {
            Name = value;
        }
    }
}
```



Em C#, uma classe não pode herdar de várias classes, mas pode ser herdada em vários níveis, o que é conhecido como herança múltipla. Outra observação é que uma classe não pode herdar várias classes, mas pode implementar várias interfaces ao mesmo tempo.

Lembre-se, na herança ao criar um objeto de uma classe derivada, o compilador sempre executa suao construtor da classe base/pai primeiro e depois executa o construtor da classe filho. Se a mesma classe pai herdou de outra classe, o construtor dessa classe será executado primeiro e, em seguida, descerá ao nível de filho e neto para executar o construtor um após o outro.

### Encapsulamento (Veja mais detalhes em Encapsulamento, mais abaixo)

A maior parte das linguagens orientadas a objetos implementam o encapsulamento baseado em propriedades privadas, ligadas a métodos especiais chamados getters e setters, que irão retornar e setar o valor da propriedade, respectivamente. Essa atitude evita o acesso direto a propriedade do objeto, adicionando uma outra camada de segurança à aplicação.

Para fazermos um paralelo com o que vemos no mundo real, temos o encapsulamento em outros elementos. Por exemplo, quando clicamos no botão ligar da televisão, não sabemos o que está acontecendo internamente. Podemos então dizer que os métodos que ligam a televisão estão encapsulados.
- Agrupamento de dados e funções em um único componente
- Permite 'ocultação' seletiva de dados e funcionalidades
- Fornece segurança e facilidade de uso para objetos
- Exemplo: fazer uma chamada usando um smartphone

### Polimorfismo (Veja mais detalhes em Encapsulamento, mais abaixo)

Na natureza, vemos animais que são capazes de alterar sua forma conforme a necessidade, e é dessa ideia que vem o polimorfismo na orientação a objetos. Como sabemos, os objetos filhos herdam as características e ações de seus “ancestrais”. Entretanto, em alguns casos, é necessário que as ações para um mesmo método seja diferente. Em outras palavras, o polimorfismo consiste na alteração do funcionamento interno de um método herdado de um objeto pai.

Como um exemplo, temos um objeto genérico “Eletrodoméstico”. Esse objeto possui um método, ou ação, “Ligar()”. Temos dois objetos, “Televisão” e “Geladeira”, que não irão ser ligados da mesma forma. Assim, precisamos, para cada uma das classes filhas, reescrever o método “Ligar()”.

Com relação ao polimorfismo, valem algumas observações. Como se trata de um assunto que está intimamente conectado à herança, entender os dois juntamente é uma boa ideia. Outro ponto é o fato de que as linguagens de programação implementam o polimorfismo de maneiras diferentes. O C#, por exemplo, faz uso de método virtuais (com a palavra-chave virtual) que podem ser reimplementados (com a palavra-chave override) nas classes filhas. Já em Java, apenas o atributo “@Override” é necessário.
- O resultado da herança e encapsulamento
- A capacidade de fornecer funcionalidades diferentes para o mesmo nome de método
- Com base no contexto de como o método é chamado
- Uma hierarquia de herança de classes e objetos pode fornecer várias funções com o mesmo nome: mas funcionalidades diferentes

## TIPOS DE C#

C# é uma linguagem fortemente tipada
- Toda variável e constante tem um tipo específico
- Expressões que avaliam um valor têm um tipo

Um tipo especifica até quatro características principais dos dados que podem ser armazenados
- O espaço de armazenamento que uma variável do tipo requer
- Os valores máximo e mínimo que ele pode representar
- Os membros (métodos, campos, eventos etc.) que ele contém
- O tipo de base herdado 

O que significa 'tipo seguro'? O compilador garante que todas as operações executadas sejam válidas para o tipo de dados que está sendo manipulado
Exemplos:
- Variáveis que são do tipo inteiro (int) podem ser usadas em operações de adição e subtração
- Variáveis do tipo bool não podem ser usadas em operações de adição e subtração

C# fornece um conjunto padrão de tipos internos
- Numérico
- String
- Objeto

## VALUE TYPES (Tipos de Valor) E REFERENCE TYPES (Tipos de Referência) 

O C# categorizou principalmente os tipos de dados em dois tipos: tipos de valor e tipos de referência. Os tipos de valor incluem tipos simples (por exemplo, int, float, bool e char), tipos de enumeração, tipos de estrutura e tipos de valor Nullable. Os tipos de referência incluem tipos de classe, tipos de interface, tipos de delegados e tipos de matriz. 

<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/ValueTypes.png" alt="Image" width="100%" />
</p>
 

Os tipos são divididos em duas categorias segundo:
- Regras em tempo de compilação
- Comportamento em tempo de execução (uso e gerenciamento de memória)

As categorias são: 
- **Tipos de valor(Value-Type)**:derivados de System.ValueType, são tipos leves como os tipos primitivos e structs, que ficam armazenados diretamente na memória stack. Os valores das variáveis ficam armazenados juntamente com as próprias variáveis, sendo o acesso ao seu conteúdo feito de maneira direta;
- **Tipos de referência(Reference-Type)**: derivados de System.Object, são tipos pesados  como objetos criados a partir de classes, que ficam armazenados na heap. Para não sacrificar a performance, é criada uma referência (ponteiro) na stack que aponta para qual posição de memória o objeto está armazenado na heap. O acesso é feito via essa referência na stack. Sendo assim, o acesso ao conteúdo é indireto, dependendo dessa referência;

O .NET Framework armazena itens na memória em um dos dois locais
- **Stack (Pilha)**: Os tipos de valor são armazenados. Porção de memória pequena onde os value-types e os ponteiros ficam;
- **Heap(montes, porções)**: Os tipos de referência são armazenados. Porção maior de memória onde os reference-types ficam de fato alocados. Para se fazer o acesso a eles, precisamos de um ponteiro na stack que indique a posição de memória na heap onde o objeto está de fato alocado.

Na configuração padrão do .NET Framework, para que você tenha uma idéia melhor de como a stack é muito menor que a heap, o tamanho padrão para a memória stack é de apenas 1MB!

Ambas trabalham como pilhas, porém, a maneira como cada uma provê acesso a seu conteúdo é diferente. A stack é bem mais eficiente para localizar as coisas em seu interior com relação a heap, mesmo porque ela é bem menor.

As variáveis de alguns tipos de dados leves (tipos primitivos – int, double, bool etc. – e structs) são armazenadas diretamente na stack, a área menor e mais eficiente para localização dos conteúdos. Elas ficam diretamente nessa área justamente por serem tipos de dados que não ocupam tanto espaço na memória. O mais interessante é que o valor que elas contêm também fica junto com elas na stack. Ou seja, quando você faz a declaração abaixo:

Vejamos os tipos de valor armazenados na Stack - pilha...
- A quantidade de memória necessária para armazenar um tipo de valor é uma quantidade definida
- Quando a variável não é mais necessária, ela é excluída da pilha. Exemplo:
    - int a = 4;
    - int b = 6;
- Cada variável é armazenada na pilha na ordem em que foi criada
    - int c = b;
- Cada variável armazena seus próprios dados

<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/StackPilha.png" alt="Image" width="100%" />
</p>
 

Perceba que o valor da variável fica junto com a própria variável. Variáveis onde isso acontece são chamadas de Value-Types, justamente porque o valor delas fica junto  com a própria variável na memória stack. Assim, quando você tem o seguinte código

<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/StackHeap.png" alt="Image" width="400px" />
</p>

Agora, outros tipos de dados ocupam muito mais espaço de memória do que estes tipos leves que são value-types. Por isso, eles não podem ser armazenados diretamente na stack (caso fossem, rapidamente a memória stack seria “estourada”, causando o famoso erro StackOverflowException). Sendo assim, estes dados são armazenados na memória heap. Vamos imaginar que você tenha o seguinte código:


```bash
class Pessoa
{
    public int Id {get; set;}
    public string Nome {get; set;}
}
```

Quando você cria um objeto dessa classe, este objeto será armazenado na memória heap:

```bash
Pessoa minhaPessoa = new Pessoa();
```

<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/NewPessoa.png" alt="Image" width="400px" />
</p>
 
Porém, o compilador não acessa a heap diretamente. Por que ele não acessa? Justamente porque ela é muito grande… Se ele fosse procurar o objeto minhaPessoa dentro da heap, ele iria demorar um tantinho bom de tempo. O compilador precisaria ter um jeito de acessar pela stack (que é rápida pra encontrar as coisas até mesmo por ser bem menor) o que está alocado na heap (que é bem maior). Como o compilador contorna isso? Criando uma referência dentro da stack para o objeto minhaPessoa, apontando onde na memória heap que este objeto está de fato guardado!
 
 <p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/StackRef.png" alt="Image" width="400px" />
</p>

Essa porção de memória que é alocada na stack para apontar para uma posição de memória da heap é chamada de ponteiro. Por isso ele tem esse asterisco (*) na frente do seu nome.

Repare então que é criada uma referência da stack para uma determinada posição de memória da heap, referência essa guardada por um ponteiro na stack. Esse tipo de variável (como no caso da variável minhaPessoa, do tipo Pessoa) é chamada de Reference-Type, já que é necessário uma referência da stack para a heap para que esta variável seja acessível. Variáveis reference-type geralmente precisam que seja chamado o respectivo construtor através da palavra-chave new, pois ele é que define que uma porção de memória da heap deverá ser utilizada para guardar aquele objeto.

Agora, veja outro exemplo de valores de referência na Heap ...


```bash
class Car
{
     int hp;
}
Car c = new Car (); 
c.hp = 340;
Car d = new CarO; 
d.hp = 340;
Car f = d;
f.hp = 100; <- altera o valor em d também
```
 <p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/Carclass.png" alt="Image" width="100%" />
</p>


As variáveis baseadas em tipos de valor (value types) contêm diretamente o valor. Quando copiamos uma variável para outra, uma cópia do valor é passada; em tipos de referência (reference types), é passada somente uma referência do objeto. Os values types dividem-se em duas categorias principais: estruturas (structs) e enumerações (enum).

## TIPOS DE REFERÊNCIA – reference types

Nas variáveis de tipos de referência (reference types), somente uma referência doobjeto é passada. A seguir, temos os tipos de referências: class, interface, delegate, object, string e Array.

| Tipo | Descrição | Alcance | Sufixo |
|:----------|------|---------------------|-----------------|
|object| Tipo base de todos os outros tipos.| ----- | ----- |
|string  |  Uma sequência de caracteres Unicode | ----- | ----- |

### Tipo object

Todos os tipos são herdados direta ou indiretamente da classe Object. Assim, é possívelconverter qualquer tipo para object. O ato de converter um variável value type para object é chamado de Boxing. E quando um tipo object é convertido para um value type, é chamado de Unboxing. O tipo object é representado pela classe Object no .NET Framework.

```bash
object x = 1;
```

### Tipo string

O tipo string é o mais utilizado, uma vez que todas as variáveis que não contêm númerosquase sempre são declaradas como string. O tipo string é representado por uma sequência de caracteres Unicode. Uma string deve estar cercada por aspas duplas (""):

```bash
string b = "texto aqui";
char extrai = b[6];
Console.WriteLine(extrai); //a
Console.WriteLine(extrai + b); //atexto aqui
Console.WriteLine(extrai + "2"); //a2
Console.WriteLine(b + '2'); //texto aqui2
Console.WriteLine(extrai + '2'); //147
Console.WriteLine((int)extrai); //97 , valor ASCII
Console.WriteLine(extrai + 2); //99

```

Um recurso importante é a facilidade de extrair um caractere definido na variável, como ocorre em char extrai = b[6]. O sinal de mais (+) é usado para concatenar uma string mas, devemos ter cuidado ao utilizar este recurso com outros tipos pois podem trazer resultados indesejáveis. Você pode extrair uma letra de uma palavra:

```bash
char extrai = "Alfredo"[3];  // r
```


O arroba (@) evita que sequências de escape sejam processadas:

```bash
@"C:\Livro\Capitulo1\Construtores.cs"
```


É o mesmo que:
```bash
"C:\\Livro\\Capitulo1\\Construtores.cs"
```

Evita que aspas sejam interpretadas dentro de uma string cercada por aspas duplas.

```bash
string aspas = @"""abc"" teste";
```

A linha anterior retorna: "abc" teste.

## TIPOS DE VALOR – value types

As estruturas – struct são divididas em tipos numéricos (tipos integrais, ponto flutuante e decimal), bool e estruturas personalizadas criadas pelos programadores.O C# inclui alguns tipos de valor predefinidos. A tabela a seguir lista os tipos de dados predefinidos:

| Tipo | Descrição | Alcance | Sufixo |
|:----------|------|---------------------|-----------------|
|byte| Número inteiro não assinado de 8 bits.| 0 a 255 | ----- |
|sbyte  |  Número inteiro assinado de 8 bits | -128 a 127 | ----- |
|short| Número inteiro assinado de 16 bits | -32.768 a 32.767 | ----- |
|ushort  |  Inteiro não assinado de 16 bits | 0 a 65.535 | ----- |
|int | Número inteiro assinado de 32 bits | -2.147.483.648 a 2.147.483.647 | ----- |
|uint  |  Número inteiro não assinado de 32 bits | 0 a 4.294.967.295 | u |
|long| Número inteiro assinado de 64 bits| -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807 | I |
|ulong  |  Número inteiro não assinado de 64 bits | 0 a 18.446.744.073.709.551.615 | ul |
|char| Caractere Unicode único de 16 bits | Qualquer caractere válido, por exemplo, a, *, \ x0058 (hex) ou \ u0058 (Unicode) | ----- |
|bool  |  Valor verdadeiro / falso lógico de 8 bits | Verdadeiro ou falso	 | ----- |
|Datetime| Representa data e hora | 0:00:00 1/1/01 para 11:59:59 pm 31/12/9999 | ----- |


Os tipos de ponto flutuante são: float, double, os quais diferem entre si na faixa e na precisão

| Tipo | Descrição | Alcance | Sufixo |
|:----------|------|---------------------|-----------------|
|float| Tipo de ponto flutuante de precisão única de 32 bits | -3.402823e38 a 3.402823e38 | f |
|double  |  Tipo de ponto flutuante de precisão dupla de 64 bits  | -1.79769313486232e308 a 1.79769313486232e308 | d |
|decimal  | Tipo decimal de 128 bits para cálculos financeiros e monetários	(+ ou -) | 1,0 x 10e-28para7.9 x 10e28 | m |

Se não atribuirmos um valor ao declarar uma variável, gerará um erro sobre o uso de uma variável não atribuída. Isso evita o uso de um valor que foi armazenado no local da memória antes da criação dessa variável. A atribuição é feita com um valor ou através da palavra-chave new e o alias do tipo, neste caso, essa instrução funcionará bem e imprimirá o valor padrão para esse tipo, que no exemplo abaixo caso é 0 para integer.

```bash
int myInt; // emite erro na compilação 
int myNewInt = newint(); // 0
System.Int32 myInt32 = new System.Int32();// 0
```

Além do intervalo padrão suportado por cada tipo, podemos acrescentar um valor nulo. Para isso, basta declarar o nome do tipo com um ponto de interrogação.

```bash
int? x = 10;
```

Use o operador ?? para definir um valor padrão, caso o tipo seja nulo. Ou use o método GetValueOrDefault:

```bash
int d = x ?? 0;
int? x = 10;
x.GetValueOrDefault(0);
```

A propriedade HasValue verifica se um tipo contém ou não um valor nulo.

```bash
int? x=5;
if (x.HasValue)Console.WriteLine(x.Value);
else Console.WriteLine("Valor nulo.");
```

### Tipo decimal

O tipo decimal é de alta precisão. Ideal para cálculos financeiros e monetários, é umtipo de dados de 128 bits que pode representar valores de aproximadamente:

```bash
±1.0 × 10−28 até ±7.9 × 1028
```

Com 28 ou 29 dígitos significantes. A precisão é dada em dígitos e não em casas decimais.
O sufixo m ou M deve ser utilizado para declarar variáveis do tipo decimal.

```bash
decimal x = 102.89m;
```

Sem o sufixo m ou M, a variável será tratada como se fosse do tipo double. Um erro égerado em tempo de compilação.

### BigInteger e Complex

O .NET Framework 4.0 inclui dois novos tipos: BigInteger e Complex, sendo que ambos fazem parte do namespace System.Numerics e não contêm intervalos fixos, ou seja, não têm limites predefinidos como um inteiro tradicional.Para utilizar um tipo BigInteger ou Complex, é preciso adicionar uma referência a namespace System.Numerics. 


```bash
using System;
using System.Numerics;

namespace ComplexType
{
class Program
    {
 static void Main(string[] args)
        {
long varLong = 931548458140;
            BigInteger fromLong = varLong;
            Console.WriteLine("Número convertido para BigInteger.");
            Console.WriteLine(fromLong);
            Console.Read();
        }
    }
}
```


O tipo Complex suporta operações aritméticas e trigonométricas, bastante úteis para aplicações na área de engenharia elétrica e eletrônica.

```bash
 static void Main(string[] args)
{
    var c1 = new Complex(2, 5);
    var c2 = new Complex(4, 7);
    var add = c1 + c2;
    Console.WriteLine("Adição: " + add);
    var sub = c1 - c2;
    Console.WriteLine("Subtração: " + sub);
    var mult = c1 * c2;
    Console.WriteLine("Multiplicação: " + mult);
    var div = c1 / c2;
    Console.WriteLine("Divisão: " + div);

    Console.Read();
}
```



### Tipo char

Representa um único caractere Unicode de 16 bits. É utilizado para representar a maioria das linguagens no mundo. Assim, podemos criar variáveis do tipo char e adicionar caracteres:

```bash
char letra = 'A';
char letra1 = 'H';
```

Uma variável char pode conter sequências de escape hexadecimal (prefixo \x) ou uma representação Unicode (prefixo \u):

```bash
char letra2 = '\x0072';   // Hexadecimal
char letra3 = '\u0072';   // Unicode
```

Podemos transformar, de forma explícita, um integral em um char ou vice-versa.

```bash
char letra4 = (char)72;   // corresponde a letra H
int numero = (int)'B';    // inteiro 66
```

Combinações de caracteres que consistem de uma barra invertida (\) seguida de uma letra ou combinação de dígitos são chamadas de sequência de escape. Sequências de escape são usadas em situações específicas, como: salto de linha, retorno de carro, avanço  de  página,  tabulação  horizontal  e  vertical. Veja  a  seguir  as  sequências  de escape usadas no C#:

| Sequência | Significado | 
|:----------|------|
|\'| Apóstrofo | 
|\"  |  Aspas | 
|\\  |  Barra invertida | 
|\a  |  Alerta | 
|\b  |  Retrocesso | 
|\f  |  Avanço de página | 
|\n  |  Salto de linha | 
|\r  |  Retorno de carro | 
|\t  |  Tabulação horizontal | 
|\v  |  Tabulação vertical | 	
	
### Tipo bool

Representa  um  valor  verdadeiro  ou  falso.  É  usado  com  variáveis  ou  métodos  que retornam o valor true ou false. O valor-padrão do tipo bool é false:

```bash
bool x = true;
bool b = false;
```

## ENUM  - Enumerações

As enumerações permitem criar um tipo distinto, formado por um conjunto de cons-tantes nomeadas. A seguir, temos sua forma mais simples:

```bash
enum Dias { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
```

Os elementos da enumeração são por padrão do tipo int. No entanto, os elementos podem ser de qualquer tipo integral, exceto char. O primeiro elemento é zero, o se-gundo elemento é igual a 1, e assim sucessivamente. 

Na  enumeração  anterior,  Domingo  é  igual  a  0  (zero),  Segunda  é  igual  a 1, Terça  é igual a 2 etc.Podemos também atribuir valores arbitrários a cada elemento:

```bash
enum Dias { Domingo = 10, Segunda = 25, Terça = 48, Quarta = 8, Quinta, Sexta, Sábado };
```

Os elementos aos quais não atribuímos valores arbitrários são incrementados a partir do último elemento com valor. Onde Domingo é igual a 10, Segunda é 25, Terça é 48, Quarta é 8, Quinta é 9, Sexta é 10, Sábado é 11. 

Um tipo integral diferente de int pode ser definido:

```bash
enum Dias : short { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
```


Para acessar o valor de cada elemento, é necessário converter, de forma explícita, cada elemento da enumeração para int:

```bash
int x = (int)Dias.Domingo;
int y = (int)Dias.Sexta;
Console.WriteLine(x);  // 0
Console.WriteLine(y);  // 5
Console.ReadKey();
```


Para acessar o valor de vários elementos ao mesmo tempo, é preciso antes preparar a enumeração. O atributo System.FlagsAttribute deve ser usado na declaração da enumeração. O exemplo completo que segue retorna Segunda, Sexta, Sábado:

```bash
[Flags] public enum Dias { Segunda = 0x01, Quarta = 0x02, Sexta = 0x04, Sábado = 0x08, }

static void Main(string[] args)
{
    Dias d = Dias.Sábado | Dias.Segunda | Dias.Sexta;
    Console.WriteLine(d); // Segunda, Sexta, Sábado
    Console.ReadKey();
}
```

Você aprendeu anteriormente que cada tipo de valor tinha seu próprio tipo de sistema equivalente, como System.Int32 ou System.Byte. O tipo de enumeração não é diferente porque é uma instância do tipo System.Enum, que contém vários métodos que você pode usar com suas próprias enumerações. A seguir está um código de exemplo que mostra alguns dos métodos disponíveis quando você trabalha com suas enumerações

```bash
string name = Enum.GetName(typeof(Dias), 2);
Console.WriteLine("The 2th day in the enum is " + name); //The 2th day in the enum is Quarta
foreach (int values in Enum.GetValues(typeof(Dias)))
{
    Console.WriteLine(values); //1 2 4 8
}
```

## STRUCTS

Uma estrutura é muito semelhante a uma classe. Parece e age como uma classe e compartilham muitas funcionalidades de classes como campos, propriedades, métodos e eventos
Como as estruturas são diferentes das classes
- Não é possível declarar um construtor padrão (construtor sem parâmetros). Mas é possível ter um construtor com parâmetros.
- Não é possível herdar de outra estrutura ou classe
- Pode ser instanciado sem a palavra-chave 'new', mas não há chamada do construtor e todos os campos devem ser inicializados antes que o objeto possa ser usado
- É um tipo de valor, não um tipo de referência (classe)


```bash
class Program
{
    static void Main(string[] args)
{

//Possível ter construtor com parametros...
Mark m = new Mark(6,7);
m.Dothis();

//Se não colocar new, tem que inicializar variaveis...
Mark m2;
        m2.x = 3;
        m2.y = 12;
        m2.Dothis();
    }
}

public struct Mark
{
    public int x;
    public int y;

    public Mark(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Dothis()
    {
        Console.WriteLine(x + y);
        Console.ReadLine();
    }
}

```

## GENERIC - Tipos genéricos

Tipos Genéricos fornecem a solução para uma limitação nas versões anteriores do Common Language Runtime e da linguagem C#. Os Tipos Genéricos foram adicionados à versão 2.0 da linguagem C#, tendo como ideia básica, permitir que os tipos (Número inteiro, String e tipos definidos pelo usuário) seja um parâmetro para métodos, classes e interfaces. 
- Introduzido no C# versão 2.0
- Uma maneira mais rápida, segura e eficiente de lidar com coleções tipo em tempo de compilação
- Tornar possível projetar classes e métodos que adiam a especificação de um ou mais tipos até que a classe ou método seja declarado e instanciado pelo código do cliente

Antes do C# versão 2.0, coleções como ArrayList não eram genéricas e tinham uma limitação quanto a ausência de verificação de tipo eficaz. Você pode colocar qualquer objeto em uma ArrayList, porque todas as classes na linguagem de programação C# se estendem da classe base do objeto, mas isso compromete a segurança de tipo e contradiz a definição básica de C# como uma linguagem de segurança de tipo. Além disso, o uso de ArrayList envolve uma sobrecarga significativa de desempenho na forma de conversão de tipo implícita e explícita, necessária para adicionar ou recuperar objetos.

Tipos Genéricos introduzem o conceito de parâmetros de tipo, pelo qual é possível criar classes, estruturas, interfaces e métodos que possuem espaços reservados para os tipos usados e adiam o enquadramento do tipo de dados até que a classe ou método seja declarado e instanciado pelo código do cliente. Isso permite definir as estruturas de dados seguras para tipos, além de resultar em um notável aumento de desempenho e código de alto nível, porque ajuda a reutilizar algoritmos de processamento de dados sem replicar código específico de tipo e reduzem a necessidade de boxe, unboxing e conversão de tipos de variáveis ou objetos.
Vantagens dos genéricos
- **Reutilização**: você pode usar uma única definição de tipo genérico para várias finalidades no mesmo código sem nenhuma alteração. Por exemplo, você pode criar um método genérico para adicionar dois números. Este método pode ser usado para adicionar dois números inteiros e dois flutuadores sem nenhuma modificação no código.
- **Segurança de tipo**: tipos de dados genéricos fornecem melhor segurança de tipo, especialmente no caso de coleções. Ao usar genéricos, você precisa definir o tipo de objetos a serem passados para uma coleção. Isso ajuda o compilador a garantir que apenas os tipos de objetos definidos na definição possam ser passados para a coleção.
- **Desempenho**: os tipos genéricos oferecem melhor desempenho em comparação aos tipos de sistema normais, porque reduzem a necessidade de boxe, unboxing e conversão de tipos de variáveis ou objetos.
- **Podemos usar o Generic com classes, interfaces, eventos e delegados**.
- **Podemos colocar restrições na classe genérica**, para que o cliente possa usar apenas os tipos selecionados.

### Generic Nullables

Uma área do .NET Framework na qual você pode ver o uso de genéricos está no suporte para Nullables. Um tipo de referência pode ter um valor real nulo, o que significa que não tem valor. Um tipo de valor não pode ter um valor nulo, no entanto. Por exemplo, como você expressaria que algum valor booleano é verdadeiro, falso ou desconhecido? Um booleano comum pode ser verdadeiro ou falso.

É por isso que os Nullables foram adicionados ao C# 2.0. Um Nullable é um wrapper em torno de um tipo de valor com um sinalizador booleano que ele armazena se o Nullable tiver um valor definido. Pense nisso como algo como a seguinte estrutura.

```bash
[Serializable]
public struct Nullable<T>where T : struct
{
    public bool HasValue { get; }

    public T Value { get; }

    // other implementation
}
```


Você pode usar o '?' operador para abreviar a sintaxe p. int ?, por muito tempo? em vez de usar Nullable <T>.
Em vez de criar um tipo Nullable para cada tipo de valor possível, agora existe apenas uma implementação que usa um parâmetro de tipo genérico para torná-lo mais flexível. Dessa forma, os genéricos podem ser usados para promover a reutilização de código. Um nulo do tipo int é o mesmo que um int comum mais um sinalizador que diz se o int tem um valor ou não (é nulo ou não). Todo o resto é trabalho do compilador que trata "nulo" como um valor válido.

O .NET Framework possui várias implementações genéricas de classes de coleção no namespace System.Collections.Generic. Sempre que possível, essas coleções genéricas devem ser usado em favor de suas contrapartes não genéricas.

C# tem muitas possibilidades ao usar genéricos. Eles podem ser usados em estruturas, classes, interfaces, métodos, propriedades e delegados. Você pode até especificar vários parâmetros tipos genéricos quando necessário.
Como você pode ver no exemplo de Nullable <T>, um parâmetro de tipo genérico também pode ser restringido.

No caso de Nullable<T>, não faria sentido se T pudesse ser um tipo de referência. Os tipos de referência por natureza já têm a opção de serem nulos.

Ao trabalhar com um tipo de referência, o valor padrão é nulo; com um tipo de valor como int, é 0. Mas qual é o valor padrão ao trabalhar com um parâmetro de tipo genérico? Nesse caso, você pode usar a palavra-chave padrão especial (T). Isso fornece o valor padrão para o tipo específico de T. 


```bash
public void MyGenericMethod<T>()
{
    T defaultValue = default(T);
}

```

### Compreendendo genérico versus não genérico

A maioria dos tipos de coleção possui uma versão genérica e uma não genérica. Ao trabalhar com objetos de um tipo específico (ou tipo base), use a coleção genérica. Isso melhorará a segurança e o desempenho do tipo, porque não há necessidade de casting.

As coleções não genéricas podem ser encontradas em System.Collections e coleções genéricas podem ser encontradas em System.Collections.Generic. Se você usar um tipo de valor como parâmetro de tipo para uma coleção genérica, precisará eliminar todos os cenários nos quais o boxe pode ocorrer. Por exemplo, se seu tipo de valor não implementar IEquatable <T>, seu objeto precisará de um box para chamar Object.Equals (Object) para verificar a igualdade. O mesmo vale para a interface IComparable <T>. Ao usar tipos de referência, você não terá esses problemas.

```bash
class Program
{
    static void Main(string[] args)
    {
        // AO ADICIONAR A STRING "HELLO"
        // EM UM ARRAYLIST DE NUMEROS NÃO DÁ ERRO NA COMPILAÇÃO
        // POIS ESTÁ SENDO ADICIONADO COMO OBJETO
        // MAS DA ERRO NA EXECUÇÃO POIS NÃO CONSEGUE REALIZAR O CAST DO TIPO(UNBOXING)
        System.Collections.ArrayList list1 = new System.Collections.ArrayList();
                list1.Add(3);
                list1.Add(5);
            list1.Add("Hello");

        Console.WriteLine("Non-Generic List Results:");
        foreach(int x in list1)
        {
            Console.WriteLine(x);
        }

        // COM UMA LISTA GENERICS, COMO O TIPO É DEFINIDO PREVIAMENTE(int)
        // JÁ NA COMPILAÇÃO DO CÓDIGO, APARECEM OS ERROS DE CONVERSÃO
        List<int> list2 = new List<int>();
                list2.Add(9);
                list2.Add(11);
                list2.Add("Hello");
    }   
}
```
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/ErroListGeneric.png" alt="Image" width="100%" />
</p>
 
O .NET fornece várias classes e interfaces genéricas. Isso existe no namespace System.Collections.Generic. Alguns estão listados abaixo:

|  |  | Tipos |  |  | 
|:--------|------|--------| ------- | ------- | 
| ```HashSet<T>``` |```List<T>``` | ```Stack<T>``` | ```IComparer<T>```  |  ```IEnumerator<T>``` |
| ```LinkedList<T>``` |  ```Queue<T>```  |  ```ICollection<T>``` |  ```IEnumerable<T>``` | 	```ILIst<T>```  |

```bash
public class NodeList<T>
{
    private List<T> nodes;

    public NodeList()
    {
        this.nodes = new List<T>();
    }

    public void AddNode(T newNode)
    {
        nodes.Add(newNode);
    }

    public void DeleteNode(T nodeToRemove)
    {
        nodes.Remove(nodeToRemove);
    }

    public void ProcessAllNodes()
    {
        foreach (var node in nodes)
        {
            Console.WriteLine(node.ToString());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        NodeList<int> nodesOfInt = new NodeList<int>();
        nodesOfInt.AddNode(2);
        nodesOfInt.AddNode(4);
        nodesOfInt.AddNode(6);
        nodesOfInt.AddNode(7);
        nodesOfInt.DeleteNode(7);

        nodesOfInt.ProcessAllNodes(); //2   4   6

        NodeList<string> nodesOfString = new NodeList<string>();
        nodesOfString.AddNode("Lory");
        nodesOfString.AddNode("Julia");
        nodesOfString.AddNode("Lerman");
        nodesOfString.AddNode("James");

        nodesOfString.ProcessAllNodes(); //Lory   Julia   Julia   James

        Console.ReadKey();
    }
}
```	
			
### Generic Type/Class

A definição de tipos genéricos é feita através do uso de um parâmetro de tipo genérico entre colchetes angulares, <T>.T é apenas a representação padrão para tipos genéricos usada na maioria da documentação relativa aos genéricos. Você pode usar a letra de sua própria escolha. Um exemplo de uma classe genérica a seguir:

```bash
// We use <> to specify Parameter type 
public class GFG<T>
{
    // private data members 
    private T data;

    // using properties 
    public T value
    {
         // using accessors 
        get
        {
        return this.data;
        }
        set
        {
            this.data = value;
        }
    }

    // Generics method 
    public void Display<TypeOfValue>(string msg, TypeOfValue value)
    {
        Console.WriteLine("{0}:{1}", msg, value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // instance of string type 
        GFG<string> name = new GFG<string>();
        name.value = "GeeksforGeeks";

        // instance of float type 
        GFG<float> version = new GFG<float>();
        version.value = 5.0F;

        Console.WriteLine(name.value); //GeeksforGeeks

        Console.WriteLine(version.value); //5

        // calling Generics method 
        name.Display<int>("Integer", 122); //Integer: 122
        name.Display<char>("Character", 'H'); //Character: H
        version.Display<double>("Decimal", 255.67); // Decimal:255,67

        Console.ReadKey();
    }
}
```

Embora uma classe seja demonstrada aqui chamada GFG<T>, você deve examinar o namespace System.Collection.Generic para determinar se o .NET Framework já contém uma classe genérica. Sempre reutilize o código existente sempre que possível. Seus tipos genéricos agem exatamente como outros tipos de referência e podem incluir construtores, variáveis de membro e métodos. Os métodos, incluindo o construtor, também podem incluir parâmetros de tipo.

### Métodos Genéricos

Métodos genéricos também serão declarados com parâmetros de tipo. Isso significa que, como a assinatura da classe, a assinatura do método usará um espaço reservado para o tipo que será passado para o método. Da mesma maneira que as classes genéricas são seguras para o tipo e não exigem boxe/unboxing ou conversão explícita, os métodos genéricos também compartilham essa mesma característica. Um dos exemplos mais simples que existem no MSDN e em vários outros exemplos de documentação está usando um método de troca (Swap). A troca é uma função comumente usada em algoritmos de ordenação simples. Um exemplo de método de troca genérico a seguir:

```bash
// example of generic method with type parameters
public static void Swap<T>(ref T valueOne, ref T valueTwo)
{
    T temp = valueOne;
    valueOne = valueTwo;
    valueTwo = temp;
}

int[] arrInts = newint[] { 2, 5, 4, 7, 6, 7, 1, 3, 9, 8 };
// Sorting: integer Sort 
for (int i = 0; i < arrInts.Length; i++)
{
    for (int j = i + 1; j < arrInts.Length; j++)
    {
        if (arrInts[i] > arrInts[j])
        {
            Swap<int>(ref arrInts[i], ref arrInts[j]);
        }
    }
}
```

Na assinatura do método, você ainda usa modificadores de acesso e tipos de retorno. No exemplo acima, o método é público e o tipo de retorno é nulo. Em seguida, vem o nome do método Swap que, semelhante à classe genérica, usa colchetes angulares e um espaço reservado de tipo<T>. Os parâmetros usam a palavra-chave ref e o espaço reservado T significa que os argumentos serão do tipo T, com base no tipo usado no momento em que o método é chamado. Os argumentos podem ser tipos de valor ou tipos de referência. A palavra-chave ref indica que os argumentos estão sendo passados por referência. O método atua sobre os valores reais passados através da referência ao endereço da memória para os argumentos. A seguir, alguns exemplos de métodos que utilizam Multiparâmetros onde os argumentos são passados como valor e não referência:

```bash
public void MultipleGenericMethodArgs<T, U>(T first, U second)
{
    Console.WriteLine("{0}: {1}", first, second);
}

public U ReturnFromMultipleGenericMethodArgs<T, U>(T first)
{
    U temp = default(U);
    return temp;
}

methods.MultipleGenericMethodArgs<string, int>("Exam", 70483); //Exam: 70483
int FromMultiple = methods.ReturnFromMultipleGenericMethodArgs<string, int>("Exam: ");
Console.WriteLine(FromMultiple); //0
```

### Restrições Generic

O C# permite adicionar uma cláusula where simples. A cláusula where em uma definição genérica especifica restrições sobre os tipos que são usados como argumentos para parâmetros de tipo em um tipo genérico, método, delegado ou função local. As restrições podem especificar interfaces, classes básicas ou exigir que um tipo genérico seja um tipo de referência, valor ou não gerenciado. Eles declaram capacidades que o argumento do tipo deve ter. 

```bash
public void MyGenericMethod<T>(T parameter) { /*....*/ }
public void MyGenericMethod2<T>(T parameter) where T : class { /*....*/ }
```

No primeiro, você pode chamá-lo com um tipo não ref, por exemplo. MyGenericMethod<int> (10). No segundo método, o T só pode aceitar tipo de referência(classe) e não pode ser um tipo de estrutura. No momento da instanciação da classe genérica, se o cliente fornecer parâmetro de tipo inválido, a compilação causará um erro.

Na Tabela abaixo, você pode ver as diferentes restrições que pode usar. Eles diferem apenas no tempo de compilação, pois o compilador verifica se T é do tipo ref ou não.

| Restrição | Descrição | 
|:----------|------|
|where T: struct |  	O argumento type deve ser um tipo de valor (apenas Nullable não é permitido). | 
|where T : class  |  O argumento type deve ser um tipo de referência: por exemplo, uma classe, interface, delegado ou matriz. | 
|where T : new()  |  O tipo deve ter um construtor público padrão, sem parâmetros acessível.A restrição new() não pode ser combinada às restrições struct ou unmanaged. |  
|where T : <base class name>  |  O argumento type deve ser ou derivar da classe base especificada. |  
|where T : <interface name>  |  O argumento type deve ser ou implementar a interface especificada. Múltiplas restrições de interface podem ser especificadas. A interface de restrição também pode ser genérica. |  
|where T : U  |  O argumento de tipo fornecido para T deve ser ou derivar do argumento fornecido para U. |  
|where T : notnull  |  A notnull restrição limita o parâmetro de tipo a tipos não anulados. Esse tipo pode ser um tipo de valor ou um tipo de referência não anulado. A notnull restrição está disponível a partir de C# 8.0 para código compilado em um contexto. Ao contrário de outras restrições, se um argumento de tipo violar a notnull restrição, o compilador gera um aviso em vez de um erro. Os avisos só nullable enable são gerados em um contexto. |  
|where T : unmanaged  |  A restrição unmanaged limita o parâmetro de tipo a tipos conhecidos como tipos não gerenciados. Usando a restrição unmanaged, é mais fácil escrever o código de interoperabilidade de nível baixo em C#. Essa restrição habilita rotinas reutilizáveis em todos os tipos não gerenciados. A restrição unmanaged não pode ser combinada à restrição class ou struct. A restrição unmanaged impõe que o tipo deve ser um struct |  

É possível aplicar restrições a vários parâmetros e várias restrições a um único parâmetro, conforme mostrado no exemplo a seguir:

```bash
class Base { }
class Test<T, U>
where U : struct
where T : Base, new()
{ }
```
Várias restrições podem ser aplicadas ao mesmo parâmetro de tipo e as restrições em si podem ser tipos genéricos, da seguinte maneira:


```bash
classEmployeeList<T>where T : Employee, IEmployee, System.IComparable<T>, new()
{
// ...
}
```


	As restrição podem ser aplicadas também em métodos genéricos:

```bash
public static void OpEqualsTest<T>(T s, T t) where T : class
{
    System.Console.WriteLine(s == t);
}

string s1 = "target";
System.Text.StringBuilder sb = new System.Text.StringBuilder("target");
string s2 = sb.ToString();
OpEqualsTest<string>(s1, s2);
```

	Abaixo, alguns exemplos de uso de restrições de classes genéricas:

```bash
public class NodeList<T>where T : struct
```
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/restricaowhere.png" alt="Image" width="100%" />
</p>

```bash
public class NodeList<T>where T : class
```
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/restricaoint.png" alt="Image" width="100%" />
</p>
 
```bash
public class Employee
{
    public Employee() {}
}

public class  Customer
{
    public Customer(string customerName) {}
}

public class NodeList<T>where T : new()
```
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/restricaoNodeList.png" alt="Image" width="100%" />
</p>


 
```bash
public class Base { }

public class Employee : Base
{
    public Employee() {}
}

public class  Customer
{
    public Customer(string customerName) {}
}

public class NodeList<T>where T : Base
```
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/restricaoBase.png" alt="Image" width="100%" />
</p>
 
```bash
public interface IEmployee{}

public class Employee : IEmployee
{
    public Employee() {}
}

public class  Customer
{
    public Customer(string customerName) {}
}

public class NodeList<T>where T : IEmployee
```
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/restricaoIEmployee.png" alt="Image" width="100%" />
</p>

```bash
public class Employee : IEmployee
{
public Employee() { }
}

public class  Customer : Base
{
public Customer(string customerName) { }
}

public class NodeListMult<T, U>where T : U
{
public void DoWork(T subClass, U baseClass)
    {
    }
}

NodeListMult<Employee, IEmployee> employeeNodesmult = new NodeListMult<Employee, IEmployee>();
NodeListMult<Customer, Base> employeeNodesbase = new NodeListMult<Customer, Base>();
NodeListMult<Customer, Customer> employeeNodescust = new NodeListMult<Customer, Customer>();

```

## TIPOS ESPECIAIS EM C#

O C# fornece tipos especiais que são açúcar sintático para os usuários. Esses tipos ajudam os usuários a maximizar suaprodutividade escrevendo código auxiliar dentro deles. Esses tipos especiais estão listados abaixo.
- **System.Object type**	
- **Anonymous type**	
- **Dynamic type**	
- **Nullable type**	
- **Static type**

### Tipo System.Object 

Todos os tipos de valor e referência são derivados do tipo system.object. No .NET, o objeto é a base de toda a hierarquia de tipos. A figura abaixo mostra a hierarquia de tipos de system.object.
 <p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/SystemObject.png" alt="Image" width="100%" />
</p>
 
Como todos os tipos no .NET são derivados de system.object, ele pode manipular valores de todos os tipos. Por exemplo, no seguinte snippet de código, o objeto armazenou os valores de string e int.
```bash
object name = "Ali";
object age = 22;
```


Todo tipo no .NET herda métodos do tipo system.object, que eles podem substituir. Esses métodos são:
- Equals: use para comparar dois objetos.
- Finalize: use para executar operações de limpeza antes que o objeto seja destruído.
- GetHashCode: use para obter o valor do hash do objeto no HashTable.
- ToString: use para obter as informações do objeto em forma de texto.

### Tipo anônimo

Tipos que não têm nomes são chamados tipos anônimos. Eles são usados para agrupar dados em propriedade read-only. Diferentemente da classe, os tipos anônimos não têm um blueprint para definir os tipos de propriedade. Portanto, cada propriedade deve ter um dado para determinar seu tipo de propriedade.

Tipos anônimos são criados usando um novo operador com inicializador de objetos. A variável de tipo implícito var é usado para manter a referência de tipos anônimos.

Sintaxe: var variableName = new {/ * inicializador de objetos * /};

```bash
var person = new { Name = "Ali", Age = 22 };
Console.WriteLine("Name = {0}", person.Name);// Ali
Console.WriteLine("Age = {0}", person.Age);// 22
```


**Observações**
- No tipo anônimo, o valor da propriedade não pode ser nulo.
- Tipo anônimo não tem método definição.
- Tipos anônimos são um tipo de classe.
- Tipo anônimo não pode ser usado como parâmetro de método que retona um tipo
- O tipo anônimo é útil para armazenar um resultado de consulta em uma coleção.

###  Tipo Dinâmico

O tipo dinâmico é usado para armazenar e manipular quaisquer dados cuja definição de tipos e erros de operação sejam determinados em tempo de execução. Ignora verificações em tempo de compilação. Portanto, é fácil acessar APIs COM e DOM com tipo dinâmico. É definido usando uma palavra-chave dinâmica.

```bash
dynamic price = 20;
Console.WriteLine(price.GetType()); // System.Int32

dynamic name = "Ali";
Console.WriteLine(name.GetType()); // System.String
```

Diferentemente do tipo implícito (palavra-chave var), o tipo dinâmico pode armazenar valores de tipos diferentes com a mesma variável dinâmica. Portanto, uma variável dinâmica pode alterar seu tipo em tempo de execução.

```bash
dynamic tipo_dinamico = "Ali";
Console.WriteLine(tipo_dinamico.GetType()); // System.String

tipo_dinamico = 3.4m;
Console.WriteLine(tipo_dinamico.GetType()); // System.Decimal

tipo_dinamico = newdouble[10];
Console.WriteLine(tipo_dinamico.GetType()); // System.Double[]
```

**Observações**
- O tipo dinâmico pode ser usado para campo, propriedade, indexador, parâmetro de método e tipo de retorno.
- Exceção é lançado no tempo de execução se o tipo de dados ou o nome do membro não for compatível

### Tipo Nullable

Normalmente, o tipo de valor não pode ser atribuído com valor nulo. Mas com o tipo Nullable, o tipo de valor pode ser atribuído com valor nulo. O tipo de valor pode se tornar anulável usando "?".

```bash
bool? isMarried = null;
isMarried = true;
```


Já o operador null-coalaescing “??” possibilita definir um valor padrão caso a variável seja nula, permitindo assim a atribuição de valor a uma variável de mesmo tipo não-anulável.

```bash
Nullable<int> idade = null;
int Age = idade ?? 3;
```

O HasValue retornará true se o objeto tiver sido atribuído a um valor; se não tiver sido atribuído nenhum valor ou tiver sido atribuído um valor nulo, ele retornará false.

```bash
if (i.HasValue) Console.WriteLine(i.Value); // or Console.WriteLine(i)
else Console.WriteLine("Null");
```


Nulo é considerado menor que qualquer valor. Portanto, os operadores de comparação não funcionarão com nulo. Considere o seguinte exemplo em que i não é menor que j, maior que j nem igual a j:

```bash
int? i = null;
int j = 10;

if (i < j) Console.WriteLine("i < j");
else Console.WriteLine("Could not compare");
```

A classe estática Nullable fornece um método de comparação para comparar tipos anuláveis. 


```bash
if (Nullable.Compare<int>(i, j) < 0) Console.WriteLine("i < j");
elseif (Nullable.Compare<int>(i, j) > 0) Console.WriteLine("i > j");
else Console.WriteLine("i = j");
```


Ele também possui um método GetUnderlyingType que retorna o argumento de tipo subjacente de tipos anuláveis.
```bash
public class Example
{
    public int? MyMethod()
    {
        return 0;
    }
}

Type t = typeof(Example);
MethodInfo mi = t.GetMethod("MyMethod");
Type retval = mi.ReturnType;
//Return value type...System.Nullable`1[System.Int32]
Console.WriteLine("Return value type ... {0}", retval);
Type answer = Nullable.GetUnderlyingType(retval);
//Underlying type ..... System.Int32
Console.WriteLine("Underlying type ..... {0}", answer);

```

Pontos importantes
- O ```tipo <T> anulável``` permite a atribuição de nulo a tipos de valor.
- ? operador é uma sintaxe abreviada para tipos Nullable.
- Use a propriedade value para obter o valor do tipo anulável.
- Use a propriedade HasValue para verificar se o valor está atribuído ao tipo anulável ou não.
- A classe Nullable estática é uma classe auxiliar para comparar tipos anuláveis.
- O tipo de valor é boxed sempre que se tornar anulável.

### Tipo Estático

Diferentemente das classes normais, as classes estáticas não pode ser instanciado. Elas são úteis para definir métodos estáticos auxiliares. A classe estática não possui nenhum membro da instância. Todos membros devem ser estáticos na classe estática. Portanto, membros de classes estáticas podem acesso usando o próprio nome da classe. A classe estática é definida escrevendo uma palavra-chave estática antes da definição da classe.

Diferente da classe normal, a classe estática não contém um construtor de instância pública. Ele contém um construtor estático privado para inicializar membros estáticos. É chamado automaticamente antes da criação da primeira instância ou de qualquer membros estáticos são referenciados.

```bash
static class Helper
{
    public static int age;
    static Helper()
    {
        age = 22;
    }
}

Console.WriteLine(Helper.age); // 22
```

**Sumário**
- Os valores da constante enum podem ser sobreescritos (override)com valor inteiro.
- Construtor Struct deve inicializar todos membros de dados.
- O valor padrão do tipo de referência é sempre Null.
- Tipos definidos com struct e enum são exemplos de tipos de valor.
- Tipos definidos com classe, interface e delegados são exemplos de tipo de referência.
- O tipo System.Object é classe base de todos os tipos na hierarquia C#.
- Tipos anônimos devem ter um ou mais propriedades read only.
- Os tipos dinâmicos são úteis para interagir com COM, DOM e APIs dinâmicas.
- Tipo de valor pode armazenar nulo quando é declarado como nullable "?".
- Tipos estáticos não podem ser instanciados.
- Tipos estáticos têm apenas membros estáticos.

## Consumir tipos 
- **Box ou unbox para converter entre tipos de valor; tipos cast; converter tipos; lidar com tipos dinâmicos; garantir a interoperabilidade com código que acesse APIs COM** 

### BOXING E UNBOXING

O .NET Framework possui duas grandes divisões em seus tipos de dados, os Value Types (Tipos por Valor) e os Reference Types (Tipos por Referência). Os Value Types são armazenados na stack e os Reference Types são armazenados na heap.

C# introduz dois métodos para Boxing e Unboxing, que vincula o tipo de valor ao tipo de referência. A diferença básica entre Boxing e Unboxing é que Boxing é a conversão do tipo de valor para um tipo de objeto enquanto, por outro lado, o termo Unboxing se refere à conversão do tipo de objeto para o tipo de valor. Vamos estudar as outras diferenças entre o Boxing e o Unboxing.

Por exemplo, a biblioteca .NET contém um método string.Concat que adiciona o argumentos que recebe juntos e os retorna como uma sequência. Suponha que você chame string.Concat com os seguintes argumentos:

string.Concat (“Para encaixar ou não encaixar”, 42, verdadeiro);

Se você colocar esse código no Visual Studio e passar o mouse sobre a função Concat, poderá veja que são necessários três argumentos, todos do tipo objeto. Você pode perceber que está lidando com uma string, um int e um valor booleano. Isto é onde o boxe entra. O exemplo abaixo mostra um boxing, coloca um int dentro de um objeto, e o recupera novamente.

```bash
int i = 42;
object o = i;
int x = (int)o;
```
### Boxing

Boxing é um procedimento de conversão de um tipo de valor para um tipo de objeto. Aqui, o tipo de valor é armazenado na pilha e o tipo de objeto é armazenado na memória heap. Essa conversão do tipo de valor para o tipo de objeto é uma conversão implícita. Você pode atribuir diretamente um valor a um objeto e o C# manipulará a conversão restante. 

Boxing consome memória extra junto com o tempo extra. A razão é que um novo objeto, que se referirá ao tipo de valor, deve alocar o espaço de memória no heap. Em seguida, o valor do tipo de valor armazenado na pilha será transferido para o tipo de objeto, no local da memória de heap.

### Unboxing

Unboxing é uma conversão do tipo de objeto para o tipo de valor. Em Unboxing, o valor do tipo de objeto em caixa armazenado no heap é transferido para o tipo de valor armazenado na pilha. Ao contrário do boxe, o Unboxing tem que ser feito explicitamente. O tipo de objeto é explicitamente convertido para o tipo de valor e o tipo de valor deve ser o mesmo valor ao qual o tipo de objeto está se referindo.

Unboxing também consome mais memória e mais tempo. Desde que, quando um tipo de objeto precisa ser descompactado, o valor do tipo de objeto armazenado no heap deve ser transferido para o novo tipo de valor armazenado na pilha. O tipo de objeto cujo valor foi recuperado estará agora disponível para coleta de lixo.

```bash
static void Main(string[] args)
{
    object ob;
    int x = 123;

    //BOXING: CLASSE É CONVERTIDA EM OBJETO
    //coloca um int dentro de um objeto
    ob = x;           //Boxing Implicito
    ob = (object)x;   //Boxing Explicito

    Console.WriteLine("O objeto o = ", o); // O objeto o = 
    Console.WriteLine("x= " + x);  // x = 123

    //UNBOXING: OBJETO É CONVERTIDO EM CLASSE
    x = (int)o;
    Console.WriteLine("x= " + x);  // x = 123

    long y = 0;           // Declarando Int64 double
    //y = (Int64)o;       // Unboxing Explicito para double, da erro de Cast
    y = (Int64)(Int32)o;  // Unboxing e depois convertendo pra double

    Console.WriteLine("o= " + o);  // o = 123
    Console.WriteLine("y= " + x);  // y = 123

    Console.ReadKey();
}
```
| Base para Comparação | Boxe | Unboxing |
|:----------|------|---------------------|
|Basic| Tipo de objeto refere-se ao tipo de valor. | processo de recuperação de valor do objeto em caixa.|
|Armazenamento  | O valor armazenado na pilha é copiado para o objeto armazenado na memória heap. | O valor do objeto armazenado na memória heap é copiado para o tipo de valor armazenado na pilha. |
| Conversão  |  Conversão implícita. |  Conversão explícita. |
| Exemplo  |  int n = 24;  objeto ob = n; |  int m = (int) ob; |
		
		
Se você executar uma operação unbox inválida, o tempo de execução lançará uma InvalidCastException, como ocorreu ao tentar um unboxing de int para long em y = (Int64)o . Você não verá o erro no momento da compilação porque o compilador confia em você ao fazer a chamada certa. No tempo de execução, no entanto, a conversão falha e uma exceção é lançada.

A única outra coisa importante a saber é que, quando o boxe e o unboxing acontecem (como mostrado no exemplo, o unboxing é claro), você precisa converter explicitamente seu objeto de uma referência para um tipo de valor. O boxe, por outro lado, não é tão óbvio. Por exemplo, chamar GetType sempre coloca seu tipo de valor em caixa, porque GetType é definido apenas em um objeto e não pode ser substituído. O boxe também ocorre em outras situações. Uma coisa que pode surpreender é que um tipo de valor está em caixa quando você o usa como interface. Este trecho de caixa contém o valor 3 para que você possa usá-lo como uma interface.

```bash
IFormattable x = 3;
```

Existem algumas implicações de desempenho em cada operação de caixa e unbox. Ao usar as coleções não genéricas para armazenar um tipo de valor, você tem muitas dessas operações. As operações de boxe e unboxing podem prejudicar o desempenho; no entanto, agora que você possui suporte genérico no .NET Framework, isso é um problema menor, pois você pode armazenar tipos de valor em uma coleção sem encaixotá-los.

### CASTING E CONVERT

As variáveis C# tem tipagem estática, o que significa que o seu tipo não pode ser mudado, garantindo que sempre está sendo usado um tipo que é esperado em todas as situações.

A verificação do tipo é feita no código fonte pelo processo de compilação em tempo de execução. Esta análise ajuda na segurança de tipos do código ajudando a evitar erros e permite que o programador se preocupe menos, já que os dados já têm seu tipo definido.

O compilador fornece garantias que alguns problemas não poderão ocorrer após o programa ser compilado, exemplo disso é se for declarado uma variável inteira ela não poderá receber um número fracionário, desta forma, erros são detectados antes do programa ser executado.

### Casting

Porém, existem muitos casos em que uma variável de um tipo específico precisa armazenar dados de um tipo diferente. Casting e Converting são os processos fornecidos para alterar o tipo de dados. Existem dois tipos principais de conversões de tipo em C#:
- **Implícito**: Essas conversões ocorrem automaticamente porque não há risco de perda de dados (do tipo maior para o menor). Por exemplo, uma variável maior do tipo long (8 bytes inteiros) pode armazenar qualquer valor que um int (4 bytes) possa armazenar

```bash
long z = 7;
int x = 7;
z = x;

//MAS SE...
x = z;
```
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/erroCast.png" alt="Image" width="100%" />
</p>

Outra conversão implícita é a de um tipo de referência para um de seus tipos básicos. Por exemplo, cada tipo de referência pode ser armazenado dentro de um objeto porque, em última análise, cada tipo de referência herda de um objeto. Se um objeto implementa uma interface, ele também pode ser convertido implicitamente na interface. o exemplo abaixo mostra a conversão implícita de um objeto em um de seus tipos básicos.

```bash
HttpClient client = new HttpClient();
object o = client;
IDisposable dc = client;
```

- **Explícito**: Se a conversão não puder ser feita sem o risco de perda de informações, é necessária uma conversão explícita.

```bash
int x=7;
double y=12.6;
x = (int)y;
```

**Operador “as”** é uma palavra-chave usada para explicitamente converter um tipo para outro. Se um tipo for convertido com êxito, ele retornará valor nesse tipo. Se um tipo não se converter adequadamente, ele retornará valor nulo.

```bash
public class  Person { }
public class Employee : Person { }
public class Manager : Person { }

Person person = new Employee();
//convert explicitly from type A to B
Employee employe = person as Employee;
```

As mesmas regras para converter dados em um tipo para outro tipo compatível também são válidas para Arrays. Até os operadores "is" e "as" funcionam para Arrays.

```bash
// Implicit cast to an array of Persons
Employee[] employes = new Employee[10];
Person[] persons = employes;

// Explicit cast back to an array of Employees
employes = (Employee[])persons;
employes = persons as Employee[];

// After this as statement, managers is null.
Manager[] managers = persons as Manager[];
```

**Operador “is”** é uma palavra-chave usada para corresponder a um tipo. Se um tipo corresponde, ele retorna true; caso contrário, ele retornará false. Um uso comum deste operador vem com a conversão de tipo explícita, evitar essa exceção de convesrão de tipo.

if (persons is Employee[])
{ 
// Treat them as Employees. ...
}

### Convertendo valores

A conversão permite que um programa converta um valor de um tipo para outro tipo compatível, mas às vezes você pode converter um valor de um tipo para um tipo incompatível. Por exemplo, convém converter o valor da sequência 10 para o valor int 10 ou converter o valor da sequência True no valor booleano true. Em casos como esses, a conversão não funcionará. Para converter um valor de um tipo para um tipo incompatível, você deve usar algum tipo de classe auxiliar. O .NET Framework fornece três métodos principais para esses tipos de conversões:
- Métodos Parsing
- System.Convert
- System.BitConverter

Para conversão entre tipos compatíveis, você pode usar o System.Convert e os métodos Parse ou TryParse em vários tipos.Para converterentre tipos não compatíveis, você pode usar System.BitConverter. 

### Métodos Parsing (veja mais detalhes no Tópico 4-Depurar)

Cada um dos tipos de dados C# primitivos (int, bool, doubl, etc) possui um método Parse que converte uma representação de seqüência de caracteres de um valor nesse tipo de dados. Por exemplo, bool.Parse usa como argumento uma string que representa um valor booleano como true e retorna o valor correspondentevalor bool true.Estes métodos Parse lançam exceções se suas entradas estiverem em um formato não reconhecido. Por exemplo, a instrução bool.Parse("yes") lança uma FormatException porque esse método entende apenas os valores true e false.

Você pode usar um bloco try-catch para proteger o programa dessas exceções, mas para tornar a verificação de valor ainda mais fácil, cada uma dessas classes também fornece um método TryParse. Este método tenta analisar uma string e retorna true se for bem-sucedido oufalse se falhar. Se for bem-sucedido, o método também salvará o valor analisado em uma variável de saída que você passa para o método.

```bash
int value = Convert.ToInt32(“42”);
value = int.Parse(“42”);
bool success = int.TryParse(“42”, out value);
```

A lista abaixo contém os tipos de dados mais comuns que fornecem os métodos Parse e TryParse.
|  |  | Tipos |  |  |
|:--|-|--|--  |--  |
|Bool| Float| Uint | Datetime | Sbyte  |
|Char  |  Long | Ushort | Double | Timespan |
|decimal  |  short |  byte | Int | ulong |

	

Geralmente, os métodos de análise funcionam razoavelmente bem se a entrada deles faz sentido. Por exemplo, a declaraçãoint.Parse ("645") retorna o valor 645 sem confusão. Mesmo o método Parse do tipo de dados DateTime pode fazer sentido com as entradas mais razoáveis. Por exemplo, no inglês dos EUA, as seguintes declarações são todas convertidas para 15h45 de 1º de abril de 2014.

```bash
DateTime.Parse("3:45 PM April 1, 2014").ToString()
DateTime.Parse("1 apr 2014 15:45").ToString()
DateTime.Parse("15:45 4/1/14").ToString()
DateTime.Parse("3:45pm 4.1.14").ToString()
```

Por padrão, no entanto, os métodos de análise não tratam bem os valores da moeda. Por exemplo, o código a seguir lança uma FormatException (na localidade em inglês dos EUA): 

```bash
valor decimal = decimal.Parse ("$123.456,78");
```

A razão pela qual esse código falha é que, por padrão, o método decimal.Parse permite milhares e separadores decimais, mas não símbolos de moeda. Você podeativar símbolos de moeda no decimal. Parse, adicionando parâmetros que seja uma combinação de valores definidos pelo método Enumeração System.Globalization.NumberStyles. 

Se você fornecer quaisquer valores NumberStyles, quaisquer valores padrão serão removidos. Por exemplo, por padrão decimal.Parse permite milhares e separadores decimais. Se você passar o valor NumberStyles.AllowCurrencySymbol para o método, ele não permitirá mais milhares e separadores decimais. Para permitir todos os três, você precisa passar o método para todos os três valores, como no código a seguir:

```bash
decimal amount = decimal.Parse("$123,456.78", NumberStyles.AllowCurrencySymbol | NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint);
```

Como alternativa, você pode transmitir ao método o estilo composto Currency, conforme mostrado no código a seguir:

```bash
decimal amount = decimal.Parse("$123,456.78", NumberStyles.AllowCurrencySymbol);
```

### System.Convert(veja mais detalhes no arquivo 4-Depurar)

A classe System.Convert fornece mais de 300 métodos (incluindo versões sobrecarregadas) para converter um tipo de dados em outro. Por exemplo, o método ToInt32 converte um valor em um número inteiro de 32 bits (um int). Diferentes versões sobrecarregadas dos métodos usam parâmetros de diferentes tipos, comobools, bytes, DateTimes, duplas, seqüências de caracteres e assim por diante
- Convert fornece funcionalidade semelhante, mas fica um pouco mais complexo
- Convert éótimo ao trabalhar com strings
- Se Casting falhar, tente Converter

A Tabela abaixo lista os métodos de conversão mais úteis fornecidos pela classe System.Convert.

|  |  | Tipos |  |  |
|:--|-|--|--  |--  |
|ToBoolean| ToInt16 | ToUInt16 | ToDateTime | ToSByte  |
|ToChar  |  ToInt64 | ToUInt64 | ToDouble | ToString |
|ToDecimal  |  ToSingle |  ToByte | ToInt32 | ToUInt32 |

Básicamente não só no char como em int, float entre outros, temos os tipos signed e o unsigned (há outros além desses), a diferença é que o bit mais significativo que faz a alteração de valores positivos para negativos é ignorado e utilizado como espaço, sendo assim é liberado mas espaço, já em contrapartida os números negativos não são possíveis. Veja a tabela a seguir, todos os unsigneds começam com 0. Vale ressaltar que por padrão é utilizado o signed portanto você declarar

<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/tabminmax.png" alt="Image" width="100%" />
</p>
 
```bash
long z = 7;       
int x = 7;
double y = 12.6;
double yy = 12.6;

//CAST: IGNORA AS CASAS DECIMAIS(.6)
//RESULTADO: 12
x = (int)y;
//CONVERT: ARREDONDA PARA CIMA/BAIXO O VALOR
//RESULTADO: 13
xx = Convert.ToInt32(yy);
```

### Conversões definidas pelo usuário

O C# permite que os usuários forneçam a definição de conversão para seu tipo personalizado. Sua definição é semelhante à definição de sobrecarga do operador. A conversão definida pelo usuário é de dois tipos:
- **Implícita**: A conversão implícita ocorre automaticamente, um método estático especial é definido com uma palavra-chave implícita e de operador dentro da definição de tipo.

```bash
class Byte
{
    public int
    bits = 8;
    public static implicit operator int(Byte b)
    {
        return b.bits;
    }
}

// Conversão Implicita do usuario
Byte b = new Byte();
int totalBits = b;
Console.WriteLine(totalBits); //8
```

Onde:
    - O operator int informa que tipo de dados seria retornado na conversão implícita.
    - O tipo Byte b informa qual tipo seria convertido implicitamente.
    - O byte "b" obtem uma conversão implícita em "int" retornando o número total de bits em um byte

- **Explícita**: Casting é necessário para converter um tipo em outro, um método estático especial é definido com uma palavra-chave explícita e operator dentro da definição de tipo. Pode haver perda de dados na conversão explícita.


```bash
class Person
{
    public int Age { get; set; }
    public string  Name { get; set; }
    public static explicitoperatorstring(Person per)
    {
        return per.Name;
    }
}

// Conversão Explicita do usuario
Person per = new Person { Age = 22, Name = "Ali" };
string name = (string)per;
Console.WriteLine(name); //Ali

```

Onde:
    - O operator string informa que tipo de dados seria retornado na conversão implícita.
    - O Person per informa qual tipo seria convertido implicitamente
    - Com o Casting (string)per; lança os dados de uma pessoa em "string" explicitamente, retornando o nome da pessoa ou mais dados.

Suponha que você esteja trabalhando em uma classe Money que encapsule todos os tipos de algoritmos de arredondamento para trabalhar com moedas diferentes. 


```bash
class Money
{
    public Money(decimal amount)
    {
        Amount = amount;
    }

    public decimal Amount { get; set; }
    public static implicit operator decimal(Money money)
    {
        return money.Amount;
    }

    public static explicit operator int(Money money)
    {
        return (int)money.Amount;
    }
}

Money m = new Money(42.42M);
decimal amount = m;
int truncatedAmount = (int)m;
Console.WriteLine(amount); //42,42
Console.WriteLine(truncatedAmount); //42
```

Adicionar esses tipos de conversão pode realmente melhorar a usabilidade do seu tipo. Como você puder veja, o operador implícito e explícito deve ser declarado como um método estático público em seu classe. Você precisa especificar o tipo de retorno (o tipo para o qual está fazendo a conversão) e o tipo para o qual estátransmissão de (uma instância da sua classe).

### System.BitConverter

A classe System.BitConverter fornece métodos para converter valores de e para matrizes de bytes. O método GetBytes retorna uma matriz de bytes que representa o valor que você passa para ele. Por exemplo, se você passar um int (que ocupa 4 bytes de memória) no método, ele retornará uma matriz de 4 bytes que representa o valor.A classe System.BitConverter também fornece métodos como ToInt32 e ToSingle para converter byte os valores armazenados nas matrizes retornam a tipos de dados específicos. Por exemplo, suponha que uma função API retorne dois valores de 16 bits compactados nas metades esquerda e direita de um número inteiro de 32 bits. Um inteiro assinado de 16 bits, que pode conter um valor entre -32.768 e 32.767. Você pode usar o seguinte código para descompactar os dois valores:


```bash
int packedValue;

// The API function call sets packedValue here....
packedValue = 47483648;

// Convert the packed value into an array of bytes.
byte[] valueBytes = BitConverter.GetBytes(packedValue);

Console.WriteLine(BitConverter.ToString(valueBytes));
if (BitConverter.IsLittleEndian)
    Array.Reverse(valueBytes);

// Unpack the two values.
short firstHalf = BitConverter.ToInt16(valueBytes, 0); // 20
short secondHalf = BitConverter.ToInt16(valueBytes, 2); // 0
Console.WriteLine(firstHalf); // -29952
Console.WriteLine(secondHalf); // 724

byte[] recbytes = newbyte[4];
recbytes[0] = BitConverter.GetBytes(firstHalf)[0];
recbytes[1] = BitConverter.GetBytes(firstHalf)[1];
recbytes[2] = BitConverter.GetBytes(secondHalf)[0];
recbytes[3] = BitConverter.GetBytes(secondHalf)[1];
int reconstituted = BitConverter.ToInt32(recbytes, 0);
Console.WriteLine(reconstituted); // 47483648
```

Depois que a função API define o valor de packedValue, o código usa o BitConverter.GetBytes para converter o valor em uma matriz de 4 bytes. A ordem dos bytes depende se a arquitetura do computador é big-endian ou little-endian. (Você pode usar o campo IsLittleEndian do BitConverter para determinar se o valor é big endian ou little endian.)

Em sistemas pequenos endian, os bytes de ordem inferior precedem bytes de ordem superior. Em um sistema big endian, os bytes de ordem superior precedem os bytes de ordem inferior. A tabela a seguir ilustra a diferença nas matrizes de bytes que resultam da passagem do inteiro 1.234.567.890 (0x499602D2) para o método GetBytes(Int32). Os bytes são listados na ordem do byte no índice 0 para o byte no índice 3.

| Sistema | Conversão |
|:----------|------|
|Little-endian| D2-02-96-49 | 
|Big endian  | 49-96-02-D2 | 

A classe BitConverter inclui métodos estáticos para converter cada um dos tipos primitivos de e para uma matriz de bytes, como ilustra a tabela a seguir.

| Tipo | Para conversão de bytes | Conversão de byte |
|:----------|------|---------------------|
|Boolean| GetBytes(Boolean) |ToBoolean |
|Char  |  GetBytes(Char) | ToChar |
|Double  |  GetBytes(Double)- ou - DoubleToInt64Bits(Double) |  ToDouble- ou -Int64BitsToDouble|
|Int16  |  GetBytes(Int16) | ToInt16 |
|Int32  |  GetBytes(Int32) | ToInt32`|
|Int64  |  GetBytes(Int64) | ToInt64 |
|Single  |  GetBytes(Single) | ToSingle|
|UInt16  |  GetBytes(UInt16) | ToUInt16 |
|UInt32  |  GetBytes(UInt32) |  ToUInt32 |		
|UInt64  | GetBytes(UInt64) | ToUInt64 |


### Garantindo a interoperabilidade com código não gerenciado

A interoperabilidade permite que um programa C# use classes fornecidas por código não gerenciado que não foi gravado sob o controle do Common Language Runtime (CLR), o ambiente de tempo de execução que executa os programas C#. Os componentes ActiveX e a API do Win32 são exemplos de código não gerenciado que você pode chamar de um programa C#. As duas técnicas mais comuns para permitir que programas gerenciados usem código não gerenciado são:
- Chamada de plataforma (P/invoke)
- Tipo dinâmicos e Interoperabilidade COM 

### Plataforma P/invoke

Para usar P/invoke para acessar um recurso não gerenciado, como uma chamada de API, um programa inclui primeiro um atributo DllImport para definir os métodos não gerenciados que serão usados pelo programa gerenciado. O atributo DllImport faz parte do namespace System.Runtime.InteropServices, e utiliza parâmetros que informam o programa gerenciado sobre um método não gerenciado. Os parâmetros indicam coisas como a DLL que contém o método, o conjunto de caracteres usado pelo método (Unicode ou ANSI) e o ponto de entrada na DLL usada pelo método. (Se você omitir isso, o padrão é o nome do método.)

O programa aplica o atributo a uma declaração de método externo estático. A declaração inclui quaisquer parâmetros que o método requeira e define o tipo de retorno do método. Essa declaração deve estar dentro de uma classe como a classe que contém o código que usa o método.Por exemplo, o seguinte fragmento de código mostra onde a instrução using e o atributo DllImport são colocados no programa. 


```bash
using System;
using System.Runtime.InteropServices;

namespace Interoperabilidade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the long file name.
            string longName = @"C:\Users\RICARDO\Documents";
            // Allocate a buffer to hold the result.
            char[] buffer = newchar[1024];
            long length = GetShortPathName( longName, buffer, buffer.Length);

            // Get the short name.
            string shortName = newstring(buffer);
            Console.WriteLine(shortName); // C:\Users\RICARDO\DOCUME~1(com espaços em branco)

            shortName = shortName.Substring(0, (int)length);
            Console.WriteLine(shortName);// C:\Users\RICARDO\DOCUME~1

            Console.ReadKey();
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern uint GetShortPathName(string lpszLongPath, char[] lpszShortPath, int cchBuffer);
    }
}
```

A instrução DllImport indica que o método está na biblioteca kernel32.dll, que o programa deve determinar automaticamente se deve usar o conjunto de caracteres Unicode ou ANSI e que o método deve chamar SetLastError se houver algum problema. Se houver um erro, o programa pode usar GetLastWin32Error para ver o que deu errado.

A declaração do método indica que o programa usará o método GetShortPathName, que converte um caminho completo em um arquivo em um caminho curto que pode ser reconhecido pelo Windows. (Se o método usa o conjunto de caracteres Unicode, o nome do método geralmente termina com um "W" para "caracteres largos", como em GetShortPathNameW.) Esse método retorna uma uint e usa como parâmetros uma string, matriz de caracteres e int.

O primeiro parâmetro é o caminho do arquivo que você deseja converter para um caminho curto. Quando você chama o método, o P/Invoke o converte automaticamente em uma sequência terminada em nulo. O segundo parâmetro deve ser um buffer pré-alocado, onde GetShortPathName pode armazenar seus resultados. O terceiro parâmetro fornece o comprimento do buffer que você alocou, para que GetShortPathName saiba quanto espaço ele tem para trabalhar. O método retorna um uint indicando o comprimento da string que o método depositou no buffer lpszLongPath. 

Geralmente, o tipo de instrução DllImport mostrado anteriormente é bom o suficiente para fazer o trabalho. Se precisar de mais controle sobre como os valores são convertidos entre código gerenciado e não gerenciado, você pode adicionar o atributo MarshalAs aos parâmetros do método ou valor de retorno. O código a seguir mostra uma nova versão da instrução DllImport para o método GetShortPathName que usa os atributos MarshalAs:

```bash
[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
staticexternuint GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string lpszLongPath,
    [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpszShortPath, uint cchBuffer);
```

O primeiro atributo MarshalAs indica que o primeiro e segundo parâmetro é um tipo de dados LPTStr no código não gerenciado e deve ser tratado como uma string e StringBuilder, respectivamente, no código gerenciado.Claro, se você usar esta declaração, precisará alterar o código para usar um StringBuilder para um buffer em vez de uma matriz de caracteres.

```bash
var shortName = new StringBuilder();
long length = GetShortPathName(longName, shortName, 1024);
Console.WriteLine(shortName); // C:\Users\RICARDO\DOCUME~1

```

### Tipos Dinâmicos e Interoperabilidade COM

Os atributos DllImport e MarshalAs descritos na seção anterior permitem que você diga ao programa onde encontrar um método não gerenciado e que tipos de dados ele usa para parâmetros e um tipo de retorno. Isso permite que o programa chame métodos não gerenciados por meio da P/invoke.

Como mencionado anteriormente, o C# é uma linguagem digitada parcialmente estática. A palavra-chave dinâmica, adicionada no C# 4.0, é onde você entra no mundo das linguagens de tipo fraco. Trabalhar em um sistema de tipo fraco é útil ao se comunicar com recursos externos (como Interoperabilidade COM, Iron-Python, conjuntos de resultados JSON), ou o HTML Document Object Model (DOM) ou ao trabalhar com reflexão dentro de C#.

Quando o compilador C# encontra a palavra-chave dinâmica, ele pára com a verificação de tipo estaticamente (por exemplo, verificando se existe um método em um tipo ou se possui certos argumentos).Em vez disso, o compilador salva a intenção do código para que possa ser executado posteriormente em tempo de execução. É por isso que o uso de tipos dinâmicos não gera erros em tempo de compilação, embora certamente possa gerar erros de tempo de execução.

Ao integrar com aplicativos COM (Component Object Model), você usa um PIA (Primary Interop Assembly). Os PIAs são assemblies .NET que preenchem a lacuna entre .NET e COM. COM Interop fornece uma outra maneira pela qual um programa gerenciado pode interagir com código não gerenciado. Para usar a interoperabilidade COM, você precisa fornecer ao programa uma referência a uma biblioteca apropriada instalada no sistema ou através do Gerenciador pacotes do NuGet. 

Adicionar a referência da biblioteca informa ao seu programa (e Visual Studio) muito sobre o aplicativo COM não gerenciado. Se você abrir o menu Exibir e selecionar Pesquisador de objetos, poderá usar o Pesquisador de objetos para pesquisar os objetos e tipos definidos pela biblioteca. A biblioteca fornece ao Visual Studio informações suficientes para fornecer ao IntelliSense sobre alguns membros da biblioteca, mas o Visual Studio ainda pode não entender tudo. os tipos usados pela biblioteca. 

O tipo de dados dinâmico é usado para resolver essa situação. Este é um tipo de dados estático, mas seu tipo verdadeiro não é avaliado até o tempo de execução, portanto não corrige erros de sintaxe para problemas como incompatibilidade de tipos, porque ainda não avaliou o tipo dinâmico. Isso pode ser útil se você não puder fornecer informações completas sobre o tipo de um item para o compilador. O C# considera os objetos definidos pelo código de interoperabilidade COM não gerenciado como tendo o tipo dinâmico, portanto, não importa em tempo de compilação quais são seus tipos reais . Ele ignora a verificação da sintaxe dos objetos e aguarda o tempo de execução para ver se o código faz sentido. 

Por exemplo, o Microsoft Office possui os tipos de montagens que permitem a integração com Word, Excel e outros aplicativos do Office do seu aplicativo .NET. Antes da adição da palavra-chave dinâmica, fazer alguma automação do Office não era algo simples, mas com a nova palavra-chave dinâmica, acessar o Office é muito mais fácil. Essas montagens estão disponíveis como pacotes do NuGet e para instalar, basta clicar com o botão direito do mouse em References no seu projeto e selecionando Gerenciando pacotes do NuGet e procure por um dos pacotes listados abaixo:
- Microsoft.Office.Interop.Excel
- Microsoft.Office.Interop.Word
- Microsoft.Office.Interop.Outlook
- Microsoft.Office.Interop.PowerPoint
- Microsoft.Office.Interop.Graph

Ou instale usando o Console do Gerenciador de Pacotes:
PM> Install-Package Microsoft.Office.Interop.Excel

O código abaixo mostra como a palavra-chave dinâmica permite exportar alguns dados para o Excel.


```bash

class Program
{
    static void Main(string[] args)
    {
        var entities = new List<dynamic> {
        new{ ColumnA = 1, ColumnB = "Foo"},
        new { ColumnA= 2, ColumnB= "Bar"}};
        DisplayInExcel(entities);
    }

    static void DisplayInExcel(IEnumerable<dynamic> entities)
    {
        var excelApp = new Microsoft.Office.Interop.Excel.Application();
        excelApp.Visible = true;
        excelApp.Workbooks.Add();
        dynamic workSheet = excelApp.ActiveSheet;
        workSheet.Cells[1, "A"] = "Header A";
        workSheet.Cells[1, "B"] = "Header B";
        var row = 1;
        foreach (var entity in entities)
        {
            row++;
            workSheet.Cells[row, "A"] = entity.ColumnA;
            workSheet.Cells[row, "B"] = entity.ColumnB;
        }
        workSheet.Columns[1].AutoFit();
        workSheet.Columns[2].AutoFit();
    }
}
```

<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/DymanicExcel.png" alt="Image" width="100%" />
</p>


Neste exemplo, o tipo de planilha é dinâmico. As instruções que usam a variável de planilha são avaliadas em tempo de execução e despachadas para as interfaces de programação de aplicativos do Office (APIs). Toda a verificação de tipo e conversões necessárias ocorrem em tempo de execução.O Visual Studio não entende realmente o tipo de dados da sheet.Cells[1, 1], portanto, adia a verificação de tipo para esse valor. Isso permite que o programa se refira à propriedade Value dessa entidade, mesmo que o programa não saiba se a célula possui essa propriedade. Na verdade, você pode tentar definir sheet.Cells[1, 1].Whatever = ie o Visual Studio não se queixará até o tempo de execução, quando tentar acessar a propriedade Whatever e descobrir que não existe. Da mesma forma, o Visual Studio trata sheet.Columns[1] como tendo tipo dinâmico, portanto, não sabe que o método AutoFit existe até o tempo de execução.

Para um exemplo mais específico de C#, considere o código a seguir, demonstrado pelo programa de exemplo CloneArray:

```bash

// Make an array of numbers.
int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//Error compilação: This doesnt work because array1.Clone is an object.
//int[] array2 = array1.Clone();

// This works.
int[] array3 = (int[])array1.Clone();
array3[5] = 55;

// This also works.
dynamic array4 = array1.Clone();
array4[6] = 66;
//Error execução: 'Não é possível converter implicitamente tipo 'string' em 'int''
array4[7] = "This won't work";

```


Este código inicializa uma matriz de números inteiros. O código comentado tenta usar o método Clone da matriz para fazer uma cópia da matriz. Infelizmente, o método Clone retorna um objeto não específico, portanto o código não pode salvá-lo em uma variável que se refere a uma Array de int. 

A próxima instrução lança corretamente o objeto em um int[] para que ele funcione. Em seguida, o código armazena um novo valor inteiro na matriz. A declaração final tenta salvar uma string no array4 [7]. No tempo de design e compilação, o Visual Studio não tenta validar essa instrução porque o array4 foi declarado dinâmico. No entanto, em tempo de execução, isso falha porque o array4 é realmente um int[] e não pode conter uma string. 

### DynamicObject e ExpandoObject

O .NET Framework oferece duas classes especiais ao trabalhar com tipos dinâmicos: 
1.	**DynamicObject**: é o mais flexível. Ao herdar do DynamicObject, você pode substituir membros que permitem substituir operações como obter ou definir um membro, chamar um método ou realizar conversões. Usando DynamicObject, você pode criar objetos verdadeiramente dinâmicos e ter controle total sobre como eles operam em tempo de execução. 

```bash
public class SampleObject : DynamicObject
{
public override bool TryGetMember(GetMemberBinder binder, outobject result)
    {
        result = binder.Name;
return true;
    }
}

dynamic obj = new SampleObject();
Console.WriteLine(obj.SomeProperty); // Displays ‘SomeProperty’
```

2.	**ExpandoObject**: é uma implementação selada que permite obter e definir propriedades em um tipo. No ASP.NET Model-View-Controller (MVC), por exemplo, existe um ViewBag que pode ser usado para passar dados do Controller para o View. ViewBag é um ExpandoObject. Em vez de criar uma nova propriedade de tipo estaticamente para cada elemento de dados que você deseja transmitir, você pode usar o ViewBag, como mostra abaixo.

```bash
public ActionResult Index()
{
    ViewBag.MyDynamicValue = “This property is not statically typed”;
    return View();
}
```

A palavra-chave dinâmica deve ser usada com cuidado. Ele oferece uma grande flexibilidade, mas como você perde a digitação estática, também pode facilmente levar a erros que só podem ser encontrados em tempo de execução. Mas, ao integrar-se a outros idiomas ou para substituir a reflexão, o suporte dinâmico é uma boa adição ao .NET Framework.

**Sumário**
- O Boxing ocorre quando um tipo de valor é tratado como um tipo de referência.
- Ao converter entre tipos, você pode ter uma conversão implícita ou explícita.
- Uma conversão explícita é chamada de conversão e requer sintaxe especial.
- A conversão especial é necessária para a conversão explícita de tipos.
- Operador “as” é usado para converter um tipo em outro tipo.
- O usuário pode escrever sua definição para conversão de tipo usando palavras-chave implícitas e explícitas com métodos estáticos especiais
- O .NET Framework oferece vários métodos auxiliares para converter tipos.
- A palavra-chave dinâmica pode ser usada para facilitar a digitação estática de C# e melhorar a interoperabilidade com outras linguagens.

## Aplicar encapsulamento 
- **Aplicar encapsulamento usando propriedades; forçar encapsulamento usando assessores, incluindo público, privado, protegido e interno; forçar encapsulamento usando implementação explícita de interface, construtores, métodos, classes, métodos de extensão, parâmetros opcionais e nomeados e propriedades indexadas; criar métodos sobrecarregados (overload) e substituídos (override)**

O encapsulamento é um dos pilares do desenvolvimento orientado a objetos, que diz que, quando dados (atributos) e métodos (comportamentos) são definidos em uma única entidade. Também se refere a um princípio de design orientado a objetos chamado Data Hiding, que que restringe os elementos privados de outros objetos dentro de um sistema orientado a objetos que não são necessários para o usuário. Quando você quiser algo, peça a outro objeto para executar esta ação. A única coisa que você precisa saber é a interface externa. A implementação está oculta e você não precisa entender como ela funciona, desde que esteja em conformidade com a interface. 

O C# ajuda a encapsular o funcionamento interno de um objeto, fornecendo propriedades, modificadores de acesso e interfaces.O princípio do encapsulamento é um dos aspectos fundamentais do design orientado a objetos
- O princípio afirma que os dados armazenados dentro do objeto devem ser acessíveis apenas a esse objeto
- Não é diretamente acessível ao público de fora do objeto
- Explica a diferença entre propriedades e campos

O encapsulamento é implementado de duas maneiras:
1.	**Proteção de Dados**
2.	**Especificadores de acesso**

### PROTEÇÃO DE DADOS

### Propriedades e Campos

Os campos servem para armazenar os dados que descrevem as características de suas classes. Os campos são declarados como variáveis dentro da classe e podem ser de qualquer tipo, incluindo tipos de valor e referência.

Os campos vêm em dois tipos básicos, instância e estática, e uma classe pode conter um ou ambos. Um campo de instância é aquele que você usará com mais frequência em suas classes. Campos da instância são aqueles que estão contidos em cada objeto que você cria a partir da definição de classe. Cada campo de instância contém dados específicos para o objeto ao qual está atribuído. Como exemplo, crie um arquivo de classe simples no código e, em seguida, crie duas instâncias do arquivo de classe, definindo valores diferentes para os campos da classe.Tanto as propriedades e campos fornecem aos objetos a capacidade de armazenar dados.

| Tipo  | Descrição | 
|:----------|------|
|Campo| 	- Campo é uma variável privada que só pode ser acessada por código dentro do objeto, só está disponível de dentro do objeto | 
|Propriedade  | - Se parecem com membros de dados públicos (public data members), mas, são métodos especiais chamados accessors <br> - Uma propriedade é usada para fornecer acesso público, capacidade de ler e gravar dados, ao campo privado <br> - Especificamente, eles fornecem encapsulamento para os campos. Ele cria uma caixa de areia sobre os campos, o que a protege de salvar dados falsos. |  

```bash
public class  Person
{
    //CAMPO: PRIVATE
    private int age;

    //PROPRIEDADE: PUBLIC
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if ((value > 0) && (value < 15))
            {
                age = value;
            }
            else
            {
                throw new Exception("Age cannot be over 15...");
            }
        }
    }

    public int Weight { get; set; }
}
```

<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/publicstring.png" alt="Image" width="100%" />
</p>
 

Em C#, os dados são armazenados em uma única variável ou em uma matriz. Para proteger esses dados contra danos acidentais, temos:
- **Propriedades**
- **Indexadores**

As propriedades são de dois tipos:
1.	**Propriedade Full**: nesta propriedade, declaramos campos particulares e os encapsulamos dentro da definição de uma propriedade.
```bash
class Student_Full
{
    private int age;
    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
}
```


2.	**Propriedade Auto**: é muito parecida com a propriedade completa. A única diferença importante é que ele não requer nenhum campo ou lógica extra em seu get e set para manipular valores, porque um compilador cria seu próprio campo privado automaticamente. É apenas um versão sintática que o C# fornece aos seus desenvolvedores.

class Student_Auto
{
    public int Age { get; set; }
}

Podemos transformar uma propriedade Full quanto a Auto em somente leitura de duas maneiras. Remova o bloco set{} da definição da propriedade completa ou marque o bloco set com um especificador de acesso privado. Uma propriedade somente leitura é usada para retornar o valor de um campo e um usuário não pode definir seu valor de fora da classe.

### Indexadores

Os indexadores são usados para encapsular o valor de uma matriz. Ele se comporta e funciona como propriedade. Ele também usa especificadores de acesso, que oferecem melhor controle para ler, gravar ou manipular o valor de uma matriz. Ele cria uma sandbox sobre uma matriz, que a protege de:
1.	Salvar dados falsos em uma matriz;
2.	Usar o valor do índice errado em uma matriz;
3.	Alterar a referência de uma matriz do mundo exterior.

```bash
class Temperature
{
    //declare private array of float type.
    private float[] weekTemp = { 47.5F, 40.0F, 52.5F, 45.5F, 48.0F, 38.0F, 35.7F };
    //use float indexer, to encapsulate weekTemp
    public float this[int index]
    {
        get
        {
            if (index >= 0 && index < weekTemp.Length)
            {
                return weekTemp[index];
            }
        else return 0;
        }
        set
        {
            if (value > 0) weekTemp[index] = value;
            else Console.WriteLine("Please set value greater than 0");
        }
    }
}

Temperature temp = new Temperature();
float todayTemp = temp[1]; //read
Console.WriteLine(todayTemp); //40
temp[1] = -5.0F; //Please set value greater than 0
temp[1] = 10.0F;
Console.WriteLine(temp[1]); //10

public class  Car
{
    string[] car = newstring[40];

    public string this[int carNum]
    {
        get
        {
            if (carNum >= 0 && carNum < car.Length)
            return car[carNum];
            return"Out of index range";
        }
        set
        {
            if (carNum >= 0 && carNum < car.Length)
                car[carNum] = value;
        }
    }
}

Car c = new Car();
c[1] = "Mercedes";
c[2] = "Dodge";
c[3] = "Chevrolet";

Console.WriteLine("Car 1 is: " + c[1]); //Car 1 is: Mercedes
Console.WriteLine("Car 2 is: " + c[2]); //Car 2 is: Dodge
Console.WriteLine("Car 3 is: " + c[3]); //Car 3 is: Chevrolet
```

Aqui estão alguns pontos-chave a serem lembrados para propriedades indexadas:
- Eles aceitam um valor de índice no lugar do parâmetro de valor da propriedade padrão.
- Eles são identificados pelo uso da palavra-chave this
- Propriedades indexadas podem ser criadas em classes ou estruturas.
- Somente uma propriedade indexada pode existir em uma única classe ou estrutura. No entanto, você pode sobrecarregar um único indexador várias vezes.
- Eles podem conter métodos get e set, assim como outras propriedades
Os dados podem ser validados quando configurados ou obtidos usando instruções if-else. Por exemplo, podemos verificar se um valor é maior que 0; então pode ser definido na memória. Da mesma forma, podemos verificar se o valor do índice deve ser menor que o comprimento de sua matriz e maior ou igual a 0.

### ESPECIFICADORES/MODIFICADORES

Antes de criar classes, você deve entender o uso de modificadores em C#. Modificadores são usados na declaração de tipos e nos membros de dados dos seus tipos de referência. A Tabela abaixo lista os modificadores disponíveis em C# junto com uma descrição do que os modificadores fazem.

| Modificador | Descrição | 
|:----------|------|
|abstract| Usado para classes para indicar que essa classe não pode ser instanciada, mas que serve como uma classe base para outras classes em uma hierarquia de herança.| 
|virtual  |  Se você cria uma classe e deseja permitir que o método seja substituído em uma classe derivada, você pode usar o modificador virtual. É usada para modificar um método, propriedade, indexador ou evento declarado na classe base e permitir que eles sejam sobrescritos na classe derivada; | 
|override  | Usado ao herdar a funcionalidade de uma classe base que você deseja alterar. É usada para estender ou modificar um método virtual ou abstrato, propriedade, indexador ou evento da classe base na classe derivada; | 
| parcial  |  	Arquivos de classe podem existir em vários arquivos na mesma montagem. Esse modificador informa ao compilador que a classe existe em outro arquivo ou arquivos no assembly. | 
| sealed  |  	Aplicado às classes. Define que uma classe não pode ser uma classe base, ou não é possível herdar propriedade, indexador ou evento específico de uma classe. Se a classe for selada não é possível a herança, mas se apenas algum método for selado, então, é possível herdar da classe e esconder/sobrescrever o método selado na classe derivada com a palavra-chave new. | 
| async  | 	Configura o método ou expressão lambda à qual é aplicado como um método assíncrono. Isso permite que os métodos chamem processos de longa execução sem bloquear o código de chamada. | 
| const  |  A aplicação disso a um campo indica que o campo não pode ser modificado. As constantes devem ser inicializadas no momento em que são criadas. | 
| event  |  Usado para declarar eventos no seu código. | 
| extern  |  Usado para indicar que o método foi declarado e implementado externamente. Você pode usar isso com DLLs importadas ou assemblies externos. | 
| new  |  Quando usado com os membros da classe, esse modificador oculta os membros herdados dos membros (método, propriedade, indexador ou evento) da classe base na classe derivada. Você faria isso se herdou um membro de uma classe base, mas sua classe derivada precisa usar sua própria versão desse membro. | 
| readonly  |  Membros somente leitura podem ser atribuídos apenas durante a declaração ou em um construtor de classe. Nenhum outro meio de alterar ou atribuir um valor a esse membro é permitido. | 
| static  |  Quando aplicado a um membro da classe, significa que o membro pertence apenas à classe e não a objetos específicos criados a partir da classe. O .NET Framework tem muitos exemplos disso, como a classe Math ou a classe String. | 
| unsafe  |  C# é um código gerenciado, o que significa que as operações de memória são tratadas de maneira protegida. Usando a palavra-chave não segura declara um contexto que não é seguro em termos de gerenciamento de memória. Ponteiros C ++ são exemplos de operações de memória não segura. Para usar ponteiros em C#, você precisa declarar um contexto não seguro. | 
| volatile  | 	Quando esse modificador é aplicado a um campo, ele pode ser modificado por outros componentes que não o seu código. Exemplos podem ser o sistema operacional. | 
| base  |  chamada de dentro de uma classe derivada de uma propriedade, indexador ou evento da classe base. | 

### Modificador de acesso

Uma das principais funções modificadores é definir o nível de acessibilidade de um tipo (classe, estrutura, enum) e todos os membros e métodos de dados definidos em um assembly ou em outros assemblies. Em C#, temos cinco tipos de modificadores de acesso. Cada modificador de acesso define um nível de acessibilidade exclusivo. Esses especificadores de acesso são:

| Modificador | Descrição | 
|:----------|------|
| public | Um modificador de acesso que declara a acessibilidade do tipo ao qual está atribuído. Este é o nível mais permissivo. O acesso fora do corpo ou estrutura da classe é permitido. Os tipos de referência e valor, assim como os métodos, podem ser declarados públicos. | 
| private | Um modificador de acesso que declara a acessibilidade do tipo ao qual está atribuído. O menos permissivo, permite o acesso apenas ao corpo da classe ou estrutura. Os tipos de referência e valor podem ser declarados privados. Os métodos também podem ser declarados privados. | 
| internal | Um modificador de acesso que declara a acessibilidade do tipo ao qual está atribuído. Permite acessar apenas dentro de arquivos no mesmo assembly .NET. , mas não em outros assemblies | 
| protected | Um modificador de acesso de membro. Membros declarados protegidos são acessíveis apenas de dentro da classe e em classes derivadas. | 
|protected internal| O tipo ou membro pode ser acessado por qualquer código no assembly em que é declarado ... Ou de dentro de uma classe derivada em outro assembly | 

Public

<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/publicclass.png" alt="Image" width="500px" />
</p>


Membros definidos com especificadores de acesso public podem ser acessados dentro e fora da classe. Os dados públicos também podem ser acessíveis de fora do projeto.

```bash
class Access_Publico
{
    public void Method()
    {
        Console.WriteLine("Método Público");
    }
}

Access_Publico publico = new Access_Publico();
publico.Method(); // Método Público
```
### Private 

Membros definidos com especificadores de acesso privado são acessíveis apenas dentro da classe e não podem ser acessados de fora da classe. Use métodos públicos para acessar um membro privado no mundo exterior.


```bash
class Access_Privado
{
    private int age = 10;
    public int GetAge()
    {
        return age;
    }

    public void SetAge(int a)
    {
        age = a;
    }
}

Access_Privado privado = new Access_Privado();
int age = privado.GetAge();
Console.WriteLine("Private age = {0}", age); // Private age = 10
```

### Protected 

Membros definidos com especificadores de acesso protegido podem ser acessados dentro da classe e também dentro de suas classes filho. Eles não podem ser acessíveis fora da classe. Base é uma palavra-chave usada para acessar membros definidos como especificadores de acesso público/protegido em umparent/classe base.

```bash
class Parent
{
    protected int age;
}

class Child : Parent
{
    public void Display()
    {
        Console.WriteLine("Protect Age is = {0}", age);
        //Console.WriteLine("Age is = {0}", base.age);
    }
}

Child filho = new Child();
filho.Display(); // Protect Age is = 0
```

### Internal 

Dentro da montagem do projeto, os membros definidos com especificadores de acesso interno podem ser acessados dentro e fora da classe. Mas eles não são acessíveis a nenhuma classe definida fora da montagem do projeto.Em C#, as classes por padrão são internas, o que significa que nenhum assembly externo pode acessar as classes padrão, eles só poderão ser acessíveis a outros assemblies se as classes estiverem marcadas com especificadores de acesso público.

```bash
class Access_Interno
{
    internal int age = 20;
}

Access_Interno access = new Access_Interno();
int age_int = access.age;
Console.WriteLine("Internal age = {0}", age_int); // Internal age = 20
```

### Protected internal 

Protegido interno é uma união de comportamento interno e protegido de especificadores de acesso, que diz que, dentro da montagem do projeto, os membros definidos com especificadores de acesso protegido interno podem ser acessados como bem como fora da classe e também para as classes filho. Mas eles não são acessíveis a qualquer classe definida fora do escopo de montagem do projeto.Membros protegidos internos não são acessíveis apenas às classes filho, mas também são acessíveis a outras classes da montagem do mesmo projeto.

```bash
class Person
{
    internal protected int idade = 30;
}

class Employee : Person
{
    public void Display()
    {
        Console.WriteLine("Protect Internar Idade = {0}", base.idade);
    }
}

Person pessoa = new Person();
int idade = pessoa.idade;
Console.WriteLine("Protect Internar Idade = {0}", idade); // Protect Internar Idade = 30
```

## MÉTODOS

Métodos são os componentes de um aplicativo que permitem dividir os requisitos de computação do seu aplicativo em partes menores de funcionalidade. As boas práticas de programação determinam que você crie métodos para executar partes discretas da funcionalidade em seu código e que o método execute apenas o necessário para alcançar o resultado desejado. Alguns argumentam que a codificação dessa maneira resulta em um código que consome mais recursos devido à necessidade do sistema operacional manter indicadores e instruções de instruções para todas as chamadas de função, mas facilita muito a leitura e a manutenção do código. Se seu programa está gerando erros, é muito mais fácil rastrear o método que fornece a funcionalidade incorreta e depurar esse pequeno pedaço de código.Em essência, ummétodo é uma construção de código que contém um nome, uma assinatura, um bloco de instrução que inclui uma instrução ou conjunto de instruções e uma declaração de retorno opcional. 
- Um programa faz com que as instruções sejam executadas chamando o método e especificando quaisquer argumentos de método necessários
- Semelhante a sub-rotinas em outros idiomas
- Em C#: todas as instruções executadas são executadas no contexto de um método

Os métodos têm algumas características que você deve entender

### Tipo de retorno
- Métodos podem retornar um valor para o código de chamada
- Às vezes, chamado de função quando retorna um valor
- Se o tipo de retorno não for void; o método retornará um valor
- Uma instrução 'return' dentro do método interrompe a execução e retorna um valor para o chamador se o valor corresponder ao tipo de retorno
 
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/Tpretorno.png" alt="Image" width="100%" />
</p>

### Parâmetros
- Especifica o nome e o tipo de dados dos valores que devem ser fornecidos quando o método é chamado. Por padrão, todos os parâmetros listados são necessários ao chamar o método
- Os valores passados para os parâmetros do método são chamados de argumentos. Assim, as palavras 'parâmetros' e 'argumentos' são frequentemente usadas de forma intercambiável
- Os argumentos devem ser compatíveis com o tipo de dados do parâmetro
- Os parâmetros de um método são geralmente utilizados posicionalmente
  Parametros
- Parâmetros opcionais são definidos no final da lista de parâmetros, após todos os parâmetros necessários. Se nenhum argumento for enviado para esse parâmetro, o valor padrão será usado.
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/Parametros_op.png" alt="Image" width="500px" />
</p>

### Assinatura
- Refere-se à estrutura do método
- Para sobrecarga(overloading), a assinatura inclui o nome do método e os tipos de parâmetro
- Para delegados(delegates), a assinatura inclui o tipo de retorno e os tipos de parâmetro
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/Assinatura.png" alt="Image" width="500px" />
</p>

### Static
O modificador estático altera o comportamento dos tipos e membros de C#. Uma classe não estática é usada para criar vários objetos usando a palavra-chave 'new' com base no tipo não estático. 
- Classe ou membro estático não pode ser acessado por meio de uma instância
- Classes e membros podem ser marcados como estáticos
- Em uma classe estática, todos os métodos devem ser marcados como estáticos
- Apenas uma instância do objeto existe
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/Mod_static.png" alt="Image" width="100%" />
</p>

## CONSTRUTORES

Um método que é executado automaticamente toda vez que um objeto é instanciado da classe. Se você não fornecer seu próprio construtor, o C# criará um construtor padrão. O construtor padrão define os valores de cada variável de membro como seu valor padrão. 

O construtor leva o mesmo nome que a classe. Dentro dos colchetes, as declarações de inicialização são opcionais. Um construtor é um método, mas não inclui nenhum tipo de retorno, nem mesmo nulo. Incluir um tipo de retorno em um construtor é uma sintaxe incorreta e gerará um aviso do compilador.
- Toda classe ou estrutura C# tem um construtor que tem o mesmo nome da classe.
- Se um construtor não for fornecido pelo programador, o C# criará um construtor padrão
- Permite que ações sejam executadas quando um objeto é criado com base na classe
- Definir valores padrão
- Limita instanciação
- Executa uma ação específica
- Eles podem ser sobrecarregados (overloaded)
- Existem três tipos principais de construtores
    - **Instância (Instance)**>> Usado para criar e inicializar qualquer variável de membro da instância quando você usa a nova expressão para criar um objeto de uma classe
    - **Particular (Private)**>> Impede que outras classes criem instâncias dessa classe. Somente classes aninhadas podem criar uma instância dessa classe
    - **Estático (Static)**>> Usado para inicializar qualquer dado estático. O construtor estáticoé chamado apenas uma única vez antes da criação da primeira instância da classe ou da referência a qualquer membro estático

## POLIMORFISMO

Polimorfismo é tudo sobre mudança de comportamentos; em outras palavras, são formas diferentes de um objeto. Em C#, o polimorfismo é de dois tipos:
1.	**Polimorfismo estático (early binding)**; em tempo de compilação (Overloading/Sobrecarga);
Utilizar a sobrecarga nos permite criar mais de um método ou função que tem o mesmo nome, mas assinaturas ou parâmetros diferentes na mesma classe. Isto é chamado de sobrecarga de método, pontos importantes:
- O compilador chama automaticamente o método ou a função necessária, verificando o número de parâmetros e seu tipo, que são passados para esse método.
- Se o número de parâmetros e tipo não corresponder a nenhuma assinatura de método, ocorrerá o erro de tempo de compilação.
- Podemos obter sobrecarga de método alterando o número de parâmetros usados ou usando diferentes tipos de parâmetros ou alterando a ordem dos parâmetros.
- Com isto o compilador se encarrega de verificar a existência e coerência de diferentes métodos com o mesmo nome, alterando apenas a quantidade ou tipos de parâmetros necessários.

2.	**Polimorfismo dinâmico (late binding)**; em tempo de execução (Overriding/Sobrescrita);
Com o override, podemos criar um método em uma classe derivada com a mesma assinatura e mesmo nome que um método na classe base. Isto é chamado de substituição de método ou ainda ter dois métodos com o mesmo nome e a mesma assinatura, um método na classe base e outro na classe derivada, pontos importantes:
- Podemos substituir um método na classe base, criando função semelhante na classe derivada. Isso pode ser alcançado usando herança e usando virtual & override.
- Falar que o método possui a mesma assinatura que o outro significa que os métodos devem ter o mesmo nome, o mesmo número de argumentos e o mesmo tipo de argumento.
- A substituição de método é possível apenas nas classes derivadas, mas não dentro da mesma classe por isto temos Overload ou Shadowing (que iremos ver em outro post).
- Quando a classe derivada precisa de um método com a mesma assinatura da classe base, mas deseja executar um código diferente daquele fornecido pela classe base, a substituição do método será usada.

| Overload | Override | 
|:----------|------|
|Criação de mais de um método ou função com o mesmo nome, mas com assinaturas ou parâmetros diferentes na mesma classe| 	Criação de um método na classe derivada com a mesma assinatura que um método na classe base.| 
| É chamado de polimorfismo em tempo de compilação  |  É chamado polimorfismo de tempo de execução  |
|Ele tem o mesmo nome de método, mas com assinaturas ou parâmetros diferentes  |  Ele deve ter o mesmo nome do método, bem como as assinaturas ou os parâmetros. |  
|Sobrecarga de método não precisa de herança  |  A substituição de método precisa de herança  |
|Sobrecarga de método é possível apenas em classe única  |  A substituição do método precisa do nível hierárquico das classes, ou seja, uma classe pai e outra classe filho.  |  
|O modificador de acesso pode ser qualquer um.  |  O modificador de acesso deve ser público.  |
|A sobrecarga de método também é chamada de ligação antecipada.  |  A substituição de método também é chamada de ligação tardia. |  

## POLIMORFISMO ESTÁTICO - Overloading/Sobrecarga

Em C#, o polimorfismo estático pode ser implementado de duas maneiras:
1.	**Sobrecarga de método**
2.	**Sobrecarga do Operador**

### Overloading (Sobrecarga)

Os métodos são definidos pelo modificador, tipo de retorno, nome e número e tipo de argumentos. Mas um método também tem uma assinatura. A assinatura é o que identifica exclusivamente o método de qualquer outro método com o mesmo nome e consiste no nome do método mais o tipo de dados e tipo dos parâmetros no método. Podemos 'sobrecarregar' métodos com base em suas assinaturas exclusivas. Em C#, podemos sobrecarregar um método de duas maneiras:
1.	**Por tipos de parâmetros**: sobrecarregado definindo diferentes tipos de parâmetros para cada método que compartilham o mesmo nome do método.

```bash
class Calculator
{
    public void Add(int a, int b)
    {
        int result = a + b;
        Console.WriteLine("Sum of ints = {0}", result);
    }

    public void Add(string a, string b)
    {
        string result = a + b;
        Console.WriteLine("Sum of strings = {0}", result);
    }
}

Calculator cal = new Calculator();
cal.Add(1, 2); // Sum of ints = 3
cal.Add("C", "Sharp"); // Sum of strings = CSharp
```

2.	**Pelo comprimento dos parâmetros**:sobrecarregado definindo um comprimento de parâmetro diferente para cada método que compartilha o mesmo nome do método.

```bash

class Person
{
    public decimal salario;
    public string  endereco;

    public Person()
    {

    }

    public Person(decimal salario)
    {
        this.salario = salario;
    }

    public Person(decimal sal, string end)
    {
        this.salario = sal;
        this.endereco = end;
    }

    public void Show(string name)
    {
        Console.WriteLine("Name = {0}", name);
    }

    public void Show(string name, int age)
    {
        Console.WriteLine("Name = {0} - Age = {1}", name, age);
    }
}

Person per = new Person();
per.Show("Ali"); // Name = Ali
per.Show("Ali", 22); // Name = Ali - Age = 22

Person per2 = new Person(150);
Person per3 = new Person(50, "Rua Jacu");
```

Outro uso comum de métodos sobrecarregados está nos construtores de classes como podemos veracima na classe Person. A sobrecarga fornece a oportunidade de inicializar variáveis de membros seletivamente. Lembre-se, um construtor é apenas um método sem um tipo de retorno. 

### Sobrecarga do operador

Em C#, podemos sobrecarregar a definição de um operador para tipos personalizados (classe, estrutura). Para sobrecarregar a definição de um operador, definimos métodos especiais dentro de um tipo personalizado. Esses métodos ajudam o compilador a distinguir entre diferentes significados de um operador que produz resultados diferentes para um tipo diferente. Geralmente, em C#, podemos sobrecarregar três tipos de operadores:
1.	Operadores Unários: opera em um único operando (+, -, !, ++, -, true, false). Esses são operadores unários que podem ser sobrecarregados em C#.

```bash
class Distance_Unitary
{
    public int meter { get; set; }
    public static  Distance_Unitary operator ++(Distance_Unitary dis)
    {
        dis.meter += 1;
        return dis;
    }
}

Distance_Unitary distance = new Distance_Unitary();
distance.meter = 5;
distance++;
Console.WriteLine(distance.meter); // 6
```

**Explicação**
distance++ é chamado método operator ++; passou seu próprio objeto para o parâmetro operator ++.

2.	**Operadores binários**: opera em dois operandos (+, -, *, /, %, &, |, ^, <<, >>). Esses são operadores binários que podem ser sobrecarregados em C#

```bash
class Student_Binary
{
    public int Marks { get; set; }
    // + Operator Overloading Method
    public static  Student_Binary operator +(Student_Binary s1, Student_Binary s2)
    {
        Student_Binary std = new Student_Binary();
        std.Marks = s1.Marks + s2.Marks;
        return std;
    }
}

Student_Binary s1 = new Student_Binary { Marks = 10 };
Student_Binary s2 = new Student_Binary { Marks = 20 };
Student_Binary s3 = s1 + s2;
Console.WriteLine(s3.Marks); // 30
```

**Explicação**
Estudante s3 = s1 + s2; quando é chamado, o operador + método será executado, o que leva s1 e s2 para seus valores de parâmetro.

3.	**Operadores de comparação**: opera em dois operandos e retorna o valor booleano quando compara o valor do operando do lado esquerdo com o valor do operando do lado direito (==, !=, <, >, <=, >=). Esses são operadores de comparação que podem ser sobrecarregados em C#.

```bash
class Distance_Compare
{
    public int meter { get; set; }
    public static bool operator<(Distance_Compare d1, Distance_Compare d2)
    {
        return (d1.meter < d2.meter);
    }

    public static bool operator>(Distance_Compare d1, Distance_Compare d2)
    {
        return (d1.meter > d2.meter);
    }
}

Distance_Compare d1 = new Distance_Compare { meter = 10 };
Distance_Compare d2 = new Distance_Compare { meter = 20 };
if (d1 < d2) Console.WriteLine("d1 is less than d2");
elseif (d2 < d1) Console.WriteLine("d2 is less than d1");
```

**Explicação**
if (d1 <d2): quando esse código é executado, o operador <método será executado, o que leva d1 e d2 como seu parâmetro. Retorna true se o valor do medidor de d1 for menor que o valor do medidor de d2.

## POLIMORFISMO DINÂMICO - Overriding/Sobrescrita

O polimorfismo na programação é sobre mudar o comportamento, enquanto o polimorfismo dinâmico significa mudar o comportamento de um objeto no tempo de execução, substituindo a definição de um método. Também é conhecido como late binding.Uma classe derivada poderá substituir um membro de classe base somente se o membro da classe base tiver sido declarado como virtual ou abstrato. O membro derivado deve usar a palavra-chave override para indicar explicitamente que o método destina-se a participar da invocação virtual.
Em C#, o método pode ser overridden por duas maneiras:
1.	**Método Abstrato**
2.	**Método Virtual**

### Método Abstrato

Classes abstratas não podem ser instanciadas. É usado como classe base, onde fornece membros comuns a todas as suas classes derivadas. Ou ela é parcialmente sobrescrita (overridden) ou não é. Também é usado para declarar métodos abstratos (método sem definição) que, quando herdados, devem ser substituídos por suas classes derivadas.Um método abstrato é aquele que declara uma assinatura de método, não é considerado um método real porque não possui implementação.

Ao contrário do método virtual, o método abstrato não tem sua definição de método. Assim, sua classe derivada deve implementar a definição de método abstrato, caso contrário, o erro de tempo de compilação será gerado. Os métodos abstratos sempre declaram dentro de uma classe abstrata.

```bash
abstract class Vehicle_Abs
{
    public abstract void Run();
}

class Bike_Abs : Vehicle_Abs
{
    public override void Run()
    {
        Console.WriteLine("Run Bike_Abs");
    }
}

//Não podeser instanciada, classe abstrata
//Vehicle_Abs vei_inst = new Vehicle_Abs();
Vehicle_Abs vc_abs = new Bike_Abs();
vc_abs.Run(); // Run Bike_Abs
Console.WriteLine(vc_abs.Wheels); //2
```

**Explicação**
- Resumo público vazio Run(); declarar método abstrato sem implementar sua definição.
- substituição pública void Run(); substitui a definição do método Run na classe derivada "Bike". Assim, quando o método Run() é chamado, o método sempre derivado será chamado.
- A classe de veículo não pode ser instanciada, mas pode armazenar referência à sua bicicleta de objeto filho. 

### Método Virtual

Virtual é uma palavra-chave usada com método na classe base para definir um método virtual. Quando uma classe derivada herda de uma classe base, ela ganha todos os métodos, campos, propriedades e eventos da classe base. Método virtual tem uma definição de seu método; sua classe derivada pode:
- Substituir os membros virtuais na classe base,
- Herdaro método da classe base mais próxima, sem ignorá-lo
- Definir nova implementação não virtual desses membros que ocultam as implementações da classe base
Portanto, ao chamar o nome do método, o tempo de execução determinará qual método chamar.Os métodos e propriedades virtuais permitem que classes derivadas estendam uma classe base sem a necessidade de usar a implementação da classe base de um método. Uma interface fornece uma outra maneira de definir um método ou conjunto de métodos cuja implementação é deixada para classes derivadas.

```bash
public class BaseClass
{
    public int WorkField;
    public virtual void DoWork()
    {
        WorkField++;
        Console.WriteLine("BaseClass valor virtual int WorkProperty(1) = " + WorkProperty);
        Console.WriteLine("BaseClass valor int WorkField++ é: " + WorkField);
    }
    public virtual int WorkProperty
    {
        get
        {
            return 1;
        }
    }
}

public class DerivedClass : BaseClass
{
    public override void DoWork()
    {
        WorkField++;
        Console.WriteLine("DerivedClass valor override WorkProperty(2) é: " + WorkProperty);
        Console.WriteLine("DerivedClass valor int (BaseClass)WorkField++ é: " + WorkField);
   }
    public override int WorkProperty
    {
        get
        {
            return 2;
        }
    }
}

BaseClass bc = new BaseClass();
bc.DoWork();
//Calls the new method BaseClass.
//BaseClass valor virtual int WorkProperty(1) = 1
//BaseClass valor int WorkField++ é: 1

BaseClass dc = new DerivedClass(); 
dc.DoWork();
//Calls the new method DerivedClass.
//DerivedClass valor override WorkProperty(2) é: 2
//DerivedClass valor int (BaseClass) WorkField++ é: 1
```

O método public virtual void DoWork() {..} define um método virtual na classe base. E o método public override void DoWork() {..} substitui o método DoWorkna classe derivada, definindosua própria implementação do método DoWork().

Ao instanciarmos BaseClass dc = new DerivedClass(); dc mantém objeto de sua classe filho DerivedClass. Assim, quando executamos dc.DoWork(); o controle passará primeiro para o método "DoWork" na classe base. Como estamos em tempo de execução, o método DoWork é um método virtual; ele passará para a definiçãoda classe derivadaDerivedclass Para encontrar a implementação do método DoWork. Se encontrar o método, ele o invocará; caso contrário, retornará à classe base para executar o método DoWork virtual.

Os campos não podem ser virtuais, apenas os métodos, propriedades, eventos e indexadores podem ser virtuais. 

<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/Workfield.png" alt="Image" width="100%" />
</p>
 
Quando uma classe derivada substitui um membro virtual, esse membro é chamado, mesmo quando uma instância dessa classe está sendo acessada como uma instância da classe base. O código a seguir mostra um exemplo:

```bash
BaseClass dc = new DerivedClass();
dc.DoWork();
// Calls the new method DerivedClass.
//DerivedClass valor override WorkProperty(2) é: 2
//DerivedClass valor int (BaseClass) WorkField++ é: 1

BaseClass bc_dc = (BaseClass)dc;
bc_dc.DoWork();
// Also calls the method DerivedClass.
//BaseClass valor virtual int WorkProperty(1) = 2
//BaseClass valor int WorkField++ é: 2
```

Mas observe aqui que, como não foi utilizado o operador new, o campo WorkField foi incrementado em mais uma unidade. 

### Ocultando membros de classe base com novos membros

Se você quiser que o seu membro derivado tenha o mesmo nome de um membro de uma classe base, mas não quiser que ele participe da invocação virtual, será possível usar a palavra-chave new. A palavra-chave new é colocada antes do tipo de retorno de um membro de classe que está sendo substituído. O código a seguir mostra um exemplo:
