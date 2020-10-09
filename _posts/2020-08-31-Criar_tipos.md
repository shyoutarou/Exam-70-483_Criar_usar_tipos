
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


# CRIAR E USAR TIPOS (25–30%)

  - [Criar tipos](#criar-tipos)
    - [POO - PROGRAMAÇÃO ORIENTADA A OBJETOS](#poo---programação-orientada-a-objetos)
    - [Classes](#classes)
    - [Objetos](#objetos)
    - [Herança (Veja mais detalhes em Aplicar Hierarquia, mais abaixo)](#herança-veja-mais-detalhes-em-aplicar-hierarquia-mais-abaixo)
    - [Encapsulamento (Veja mais detalhes em Encapsulamento, mais abaixo)](#encapsulamento-veja-mais-detalhes-em-encapsulamento-mais-abaixo)
    - [Polimorfismo (Veja mais detalhes em Encapsulamento, mais abaixo)](#polimorfismo-veja-mais-detalhes-em-encapsulamento-mais-abaixo)
  - [TIPOS DE C](#tipos-de-c)
  - [VALUE TYPES (Tipos de Valor) E REFERENCE TYPES (Tipos de Referência)](#value-types-tipos-de-valor-e-reference-types-tipos-de-referência)
  - [TIPOS DE REFERÊNCIA – reference types](#tipos-de-referência--reference-types)
    - [Tipo object](#tipo-object)
    - [Tipo string](#tipo-string)
  - [TIPOS DE VALOR – value types](#tipos-de-valor--value-types)
    - [Tipo decimal](#tipo-decimal)
    - [BigInteger e Complex](#biginteger-e-complex)
    - [Tipo char](#tipo-char)
    - [Tipo bool](#tipo-bool)
  - [ENUM  - Enumerações](#enum---enumerações)
  - [STRUCTS](#structs)
  - [GENERIC - Tipos genéricos](#generic---tipos-genéricos)
    - [Generic Nullables](#generic-nullables)
    - [Compreendendo genérico versus não genérico](#compreendendo-genérico-versus-não-genérico)
    - [Métodos Genéricos](#métodos-genéricos)
    - [Restrições Generic](#restrições-generic)
  - [TIPOS ESPECIAIS EM C](#tipos-especiais-em-c)
    - [Tipo System.Object](#tipo-systemobject)
    - [Tipo anônimo](#tipo-anônimo)
    - [Tipo Dinâmico](#tipo-dinâmico)
    - [Tipo Nullable](#tipo-nullable)
    - [Tipo Estático](#tipo-estático)
    
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

### Herança (Veja mais detalhes em [Implementar uma Hierarquia](#criar-e-implementar-uma-hierarquia-de-classe))

Herança é um princípio de orientação a objetos, que permite que classes compartilhem atributos e métodos, através de "heranças". Ela é usada na intenção de reaproveitar código ou comportamento generalizado ou especializar operações ou atributos.
- Permite que uma classe reutilize o código de outra classe
- Um único objeto pode possuir a funcionalidade de várias classes
- Evita duplicação de código

Oferece a capacidade de estender e modificar o comportamento em um ambiente de fácil manutenção. A classe cujos membros são herdados é chamada classe base e a classe que herdou esses membros é chamada classe derivada.

```csharp
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

### Encapsulamento (Veja mais detalhes em [Aplicar encapsulamento](#aplicar-encapsulamento))

A maior parte das linguagens orientadas a objetos implementam o encapsulamento baseado em propriedades privadas, ligadas a métodos especiais chamados getters e setters, que irão retornar e setar o valor da propriedade, respectivamente. Essa atitude evita o acesso direto a propriedade do objeto, adicionando uma outra camada de segurança à aplicação.

Para fazermos um paralelo com o que vemos no mundo real, temos o encapsulamento em outros elementos. Por exemplo, quando clicamos no botão ligar da televisão, não sabemos o que está acontecendo internamente. Podemos então dizer que os métodos que ligam a televisão estão encapsulados.
- Agrupamento de dados e funções em um único componente
- Permite 'ocultação' seletiva de dados e funcionalidades
- Fornece segurança e facilidade de uso para objetos
- Exemplo: fazer uma chamada usando um smartphone

### Polimorfismo (Veja mais detalhes em [Polimorfismo](#tipos-polimorfismo)) 

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
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/StackPilha.png" alt="Image" width="500px" />
</p>
 

Perceba que o valor da variável fica junto com a própria variável. Variáveis onde isso acontece são chamadas de Value-Types, justamente porque o valor delas fica junto  com a própria variável na memória stack. Assim, quando você tem o seguinte código

<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/StackHeap.png" alt="Image" width="500px" />
</p>

Agora, outros tipos de dados ocupam muito mais espaço de memória do que estes tipos leves que são value-types. Por isso, eles não podem ser armazenados diretamente na stack (caso fossem, rapidamente a memória stack seria “estourada”, causando o famoso erro StackOverflowException). Sendo assim, estes dados são armazenados na memória heap. Vamos imaginar que você tenha o seguinte código:


```csharp
class Pessoa
{
    public int Id {get; set;}
    public string Nome {get; set;}
}
```

Quando você cria um objeto dessa classe, este objeto será armazenado na memória heap:

```csharp
Pessoa minhaPessoa = new Pessoa();
```

<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/NewPessoa.png" alt="Image" width="500px" />
</p>
 
Porém, o compilador não acessa a heap diretamente. Por que ele não acessa? Justamente porque ela é muito grande… Se ele fosse procurar o objeto minhaPessoa dentro da heap, ele iria demorar um tantinho bom de tempo. O compilador precisaria ter um jeito de acessar pela stack (que é rápida pra encontrar as coisas até mesmo por ser bem menor) o que está alocado na heap (que é bem maior). Como o compilador contorna isso? Criando uma referência dentro da stack para o objeto minhaPessoa, apontando onde na memória heap que este objeto está de fato guardado!
 
 <p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/StackRef.png" alt="Image" width="500px" />
</p>

Essa porção de memória que é alocada na stack para apontar para uma posição de memória da heap é chamada de ponteiro. Por isso ele tem esse asterisco (*) na frente do seu nome.

Repare então que é criada uma referência da stack para uma determinada posição de memória da heap, referência essa guardada por um ponteiro na stack. Esse tipo de variável (como no caso da variável minhaPessoa, do tipo Pessoa) é chamada de Reference-Type, já que é necessário uma referência da stack para a heap para que esta variável seja acessível. Variáveis reference-type geralmente precisam que seja chamado o respectivo construtor através da palavra-chave new, pois ele é que define que uma porção de memória da heap deverá ser utilizada para guardar aquele objeto.

Agora, veja outro exemplo de valores de referência na Heap ...


```csharp
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
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/Carclass.png" alt="Image" width="500px" />
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

```csharp
object x = 1;
```

### Tipo string

O tipo string é o mais utilizado, uma vez que todas as variáveis que não contêm númerosquase sempre são declaradas como string. O tipo string é representado por uma sequência de caracteres Unicode. Uma string deve estar cercada por aspas duplas (""):

```csharp
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

```csharp
char extrai = "Alfredo"[3];  // r
```


O arroba (@) evita que sequências de escape sejam processadas:

```csharp
@"C:\Livro\Capitulo1\Construtores.cs"
```


É o mesmo que:
```csharp
"C:\\Livro\\Capitulo1\\Construtores.cs"
```

Evita que aspas sejam interpretadas dentro de uma string cercada por aspas duplas.

```csharp
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

```csharp
int myInt; // emite erro na compilação 
int myNewInt = newint(); // 0
System.Int32 myInt32 = new System.Int32();// 0
```

Além do intervalo padrão suportado por cada tipo, podemos acrescentar um valor nulo. Para isso, basta declarar o nome do tipo com um ponto de interrogação.

```csharp
int? x = 10;
```

Use o operador ?? para definir um valor padrão, caso o tipo seja nulo. Ou use o método GetValueOrDefault:

```csharp
int d = x ?? 0;
int? x = 10;
x.GetValueOrDefault(0);
```

A propriedade HasValue verifica se um tipo contém ou não um valor nulo.

```csharp
int? x=5;
if (x.HasValue)Console.WriteLine(x.Value);
else Console.WriteLine("Valor nulo.");
```

### Tipo decimal

O tipo decimal é de alta precisão. Ideal para cálculos financeiros e monetários, é umtipo de dados de 128 bits que pode representar valores de aproximadamente:

```csharp
±1.0 × 10−28 até ±7.9 × 1028
```

Com 28 ou 29 dígitos significantes. A precisão é dada em dígitos e não em casas decimais.
O sufixo m ou M deve ser utilizado para declarar variáveis do tipo decimal.

```csharp
decimal x = 102.89m;
```

Sem o sufixo m ou M, a variável será tratada como se fosse do tipo double. Um erro égerado em tempo de compilação.

### BigInteger e Complex

O .NET Framework 4.0 inclui dois novos tipos: BigInteger e Complex, sendo que ambos fazem parte do namespace System.Numerics e não contêm intervalos fixos, ou seja, não têm limites predefinidos como um inteiro tradicional.Para utilizar um tipo BigInteger ou Complex, é preciso adicionar uma referência a namespace System.Numerics. 


```csharp
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

```csharp
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

```csharp
char letra = 'A';
char letra1 = 'H';
```

Uma variável char pode conter sequências de escape hexadecimal (prefixo \x) ou uma representação Unicode (prefixo \u):

```csharp
char letra2 = '\x0072';   // Hexadecimal
char letra3 = '\u0072';   // Unicode
```

Podemos transformar, de forma explícita, um integral em um char ou vice-versa.

```csharp
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

```csharp
bool x = true;
bool b = false;
```

## ENUM  - Enumerações

As enumerações permitem criar um tipo distinto, formado por um conjunto de cons-tantes nomeadas. A seguir, temos sua forma mais simples:

```csharp
enum Dias { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
```

Os elementos da enumeração são por padrão do tipo int. No entanto, os elementos podem ser de qualquer tipo integral, exceto char. O primeiro elemento é zero, o se-gundo elemento é igual a 1, e assim sucessivamente. 

Na  enumeração  anterior,  Domingo  é  igual  a  0  (zero),  Segunda  é  igual  a 1, Terça  é igual a 2 etc.Podemos também atribuir valores arbitrários a cada elemento:

```csharp
enum Dias { Domingo = 10, Segunda = 25, Terça = 48, Quarta = 8, Quinta, Sexta, Sábado };
```

Os elementos aos quais não atribuímos valores arbitrários são incrementados a partir do último elemento com valor. Onde Domingo é igual a 10, Segunda é 25, Terça é 48, Quarta é 8, Quinta é 9, Sexta é 10, Sábado é 11. 

Um tipo integral diferente de int pode ser definido:

```csharp
enum Dias : short { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
```


Para acessar o valor de cada elemento, é necessário converter, de forma explícita, cada elemento da enumeração para int:

```csharp
int x = (int)Dias.Domingo;
int y = (int)Dias.Sexta;
Console.WriteLine(x);  // 0
Console.WriteLine(y);  // 5
Console.ReadKey();
```


Para acessar o valor de vários elementos ao mesmo tempo, é preciso antes preparar a enumeração. O atributo System.FlagsAttribute deve ser usado na declaração da enumeração. O exemplo completo que segue retorna Segunda, Sexta, Sábado:

```csharp
[Flags] public enum Dias { Segunda = 0x01, Quarta = 0x02, Sexta = 0x04, Sábado = 0x08, }

static void Main(string[] args)
{
    Dias d = Dias.Sábado | Dias.Segunda | Dias.Sexta;
    Console.WriteLine(d); // Segunda, Sexta, Sábado
    Console.ReadKey();
}
```

Você aprendeu anteriormente que cada tipo de valor tinha seu próprio tipo de sistema equivalente, como System.Int32 ou System.Byte. O tipo de enumeração não é diferente porque é uma instância do tipo System.Enum, que contém vários métodos que você pode usar com suas próprias enumerações. A seguir está um código de exemplo que mostra alguns dos métodos disponíveis quando você trabalha com suas enumerações

```csharp
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


```csharp
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

```csharp
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


```csharp
public void MyGenericMethod<T>()
{
    T defaultValue = default(T);
}

```

### Compreendendo genérico versus não genérico

A maioria dos tipos de coleção possui uma versão genérica e uma não genérica. Ao trabalhar com objetos de um tipo específico (ou tipo base), use a coleção genérica. Isso melhorará a segurança e o desempenho do tipo, porque não há necessidade de casting.

As coleções não genéricas podem ser encontradas em System.Collections e coleções genéricas podem ser encontradas em System.Collections.Generic. Se você usar um tipo de valor como parâmetro de tipo para uma coleção genérica, precisará eliminar todos os cenários nos quais o boxe pode ocorrer. Por exemplo, se seu tipo de valor não implementar IEquatable <T>, seu objeto precisará de um box para chamar Object.Equals (Object) para verificar a igualdade. O mesmo vale para a interface IComparable <T>. Ao usar tipos de referência, você não terá esses problemas.

```csharp
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
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/ErroListGeneric.png" alt="Image" width="400px" />
</p>
 
O .NET fornece várias classes e interfaces genéricas. Isso existe no namespace System.Collections.Generic. Alguns estão listados abaixo:

|  |  | Tipos |  |  | 
|:--------|------|--------| ------- | ------- | 
| ```HashSet<T>``` |```List<T>``` | ```Stack<T>``` | ```IComparer<T>```  |  ```IEnumerator<T>``` |
| ```LinkedList<T>``` |  ```Queue<T>```  |  ```ICollection<T>``` |  ```IEnumerable<T>``` | 	```ILIst<T>```  |

```csharp
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

```csharp
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

```csharp
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

```csharp
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

```csharp
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

```csharp
class Base { }
class Test<T, U>
where U : struct
where T : Base, new()
{ }
```
Várias restrições podem ser aplicadas ao mesmo parâmetro de tipo e as restrições em si podem ser tipos genéricos, da seguinte maneira:


```csharp
classEmployeeList<T>where T : Employee, IEmployee, System.IComparable<T>, new()
{
// ...
}
```


	As restrição podem ser aplicadas também em métodos genéricos:

```csharp
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

```csharp
public class NodeList<T>where T : struct
```
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/restricaowhere.png" alt="Image" width="100%" />
</p>

```csharp
public class NodeList<T>where T : class
```
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/restricaoint.png" alt="Image" width="100%" />
</p>
 
```csharp
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


 
```csharp
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
 
```csharp
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

```csharp
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
```csharp
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

```csharp
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

```csharp
dynamic price = 20;
Console.WriteLine(price.GetType()); // System.Int32

dynamic name = "Ali";
Console.WriteLine(name.GetType()); // System.String
```

Diferentemente do tipo implícito (palavra-chave var), o tipo dinâmico pode armazenar valores de tipos diferentes com a mesma variável dinâmica. Portanto, uma variável dinâmica pode alterar seu tipo em tempo de execução.

```csharp
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

```csharp
bool? isMarried = null;
isMarried = true;
```


Já o operador null-coalaescing “??” possibilita definir um valor padrão caso a variável seja nula, permitindo assim a atribuição de valor a uma variável de mesmo tipo não-anulável.

```csharp
Nullable<int> idade = null;
int Age = idade ?? 3;
```

O HasValue retornará true se o objeto tiver sido atribuído a um valor; se não tiver sido atribuído nenhum valor ou tiver sido atribuído um valor nulo, ele retornará false.

```csharp
if (i.HasValue) Console.WriteLine(i.Value); // or Console.WriteLine(i)
else Console.WriteLine("Null");
```


Nulo é considerado menor que qualquer valor. Portanto, os operadores de comparação não funcionarão com nulo. Considere o seguinte exemplo em que i não é menor que j, maior que j nem igual a j:

```csharp
int? i = null;
int j = 10;

if (i < j) Console.WriteLine("i < j");
else Console.WriteLine("Could not compare");
```

A classe estática Nullable fornece um método de comparação para comparar tipos anuláveis. 


```csharp
if (Nullable.Compare<int>(i, j) < 0) Console.WriteLine("i < j");
elseif (Nullable.Compare<int>(i, j) > 0) Console.WriteLine("i > j");
else Console.WriteLine("i = j");
```


Ele também possui um método GetUnderlyingType que retorna o argumento de tipo subjacente de tipos anuláveis.
```csharp
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

```csharp
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
