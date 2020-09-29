
### Este exame será retirado em 31 de janeiro de 2021 às 23h59, horário central. Você não poderá mais fazer o exame após essa data. Saiba mais sobre outros exames que serão retirados [aqui](https://docs.microsoft.com/en-us/learn/certifications/retired-certification-exams)


<ul>
{% for post in site.posts %}
<li>
<a href="{{ site.baseurl }}{{ post.url }}">{{ post.title }}</a>
</li>
{% endfor %}
</ul>


Resumo do treinamento para o exame................

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


## Consumir tipos 
- **Box ou unbox para converter entre tipos de valor; tipos cast; converter tipos; lidar com tipos dinâmicos; garantir a interoperabilidade com código que acesse APIs COM** 

### BOXING E UNBOXING

O .NET Framework possui duas grandes divisões em seus tipos de dados, os Value Types (Tipos por Valor) e os Reference Types (Tipos por Referência). Os Value Types são armazenados na stack e os Reference Types são armazenados na heap.

C# introduz dois métodos para Boxing e Unboxing, que vincula o tipo de valor ao tipo de referência. A diferença básica entre Boxing e Unboxing é que Boxing é a conversão do tipo de valor para um tipo de objeto enquanto, por outro lado, o termo Unboxing se refere à conversão do tipo de objeto para o tipo de valor. Vamos estudar as outras diferenças entre o Boxing e o Unboxing.

Por exemplo, a biblioteca .NET contém um método string.Concat que adiciona o argumentos que recebe juntos e os retorna como uma sequência. Suponha que você chame string.Concat com os seguintes argumentos:

string.Concat (“Para encaixar ou não encaixar”, 42, verdadeiro);

Se você colocar esse código no Visual Studio e passar o mouse sobre a função Concat, poderá veja que são necessários três argumentos, todos do tipo objeto. Você pode perceber que está lidando com uma string, um int e um valor booleano. Isto é onde o boxe entra. O exemplo abaixo mostra um boxing, coloca um int dentro de um objeto, e o recupera novamente.

```csharp
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

```csharp
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

|     Base para Comparação    |     Boxe                                                                                 |     Unboxing                                                                                              |
|-----------------------------|------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------|
|     Basic                   |     Tipo de objeto refere-se ao tipo de valor.                                           |     processo de recuperação de valor do objeto em caixa.                                                  |
|     Armazenamento           |     O valor armazenado na pilha é copiado para o objeto armazenado na   memória heap.    |     O valor do objeto armazenado na memória heap é copiado para o tipo de   valor armazenado na pilha.    |
|     Conversão               |     Conversão implícita.                                                                 |     Conversão explícita.                                                                                  |
|     Exemplo                 |     int n = 24;  <br>   objeto ob = n;                                                       |     int m = (int) ob;                                                                                     |

		
Se você executar uma operação unbox inválida, o tempo de execução lançará uma InvalidCastException, como ocorreu ao tentar um unboxing de int para long em y = (Int64)o . Você não verá o erro no momento da compilação porque o compilador confia em você ao fazer a chamada certa. No tempo de execução, no entanto, a conversão falha e uma exceção é lançada.

A única outra coisa importante a saber é que, quando o boxe e o unboxing acontecem (como mostrado no exemplo, o unboxing é claro), você precisa converter explicitamente seu objeto de uma referência para um tipo de valor. O boxe, por outro lado, não é tão óbvio. Por exemplo, chamar GetType sempre coloca seu tipo de valor em caixa, porque GetType é definido apenas em um objeto e não pode ser substituído. O boxe também ocorre em outras situações. Uma coisa que pode surpreender é que um tipo de valor está em caixa quando você o usa como interface. Este trecho de caixa contém o valor 3 para que você possa usá-lo como uma interface.

```csharp
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

```csharp
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

```csharp
HttpClient client = new HttpClient();
object o = client;
IDisposable dc = client;
```

- **Explícito**: Se a conversão não puder ser feita sem o risco de perda de informações, é necessária uma conversão explícita.

```csharp
int x=7;
double y=12.6;
x = (int)y;
```

### Operador “as” 

É uma palavra-chave usada para explicitamente converter um tipo para outro. Se um tipo for convertido com êxito, ele retornará valor nesse tipo. Se um tipo não se converter adequadamente, ele retornará valor nulo.

```csharp
public class  Person { }
public class Employee : Person { }
public class Manager : Person { }

Person person = new Employee();
//convert explicitly from type A to B
Employee employe = person as Employee;
```

As mesmas regras para converter dados em um tipo para outro tipo compatível também são válidas para Arrays. Até os operadores "is" e "as" funcionam para Arrays.

```csharp
// Implicit cast to an array of Persons
Employee[] employes = new Employee[10];
Person[] persons = employes;

// Explicit cast back to an array of Employees
employes = (Employee[])persons;
employes = persons as Employee[];

// After this as statement, managers is null.
Manager[] managers = persons as Manager[];
```

### Operador “is”

É uma palavra-chave usada para corresponder a um tipo. Se um tipo corresponde, ele retorna true; caso contrário, ele retornará false. Um uso comum deste operador vem com a conversão de tipo explícita, evitar essa exceção de convesrão de tipo.

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

### Métodos Parsing (veja mais detalhes em [Depurar_segurança](https://shyoutarou.github.io/Exam-70-483_Depurar_segurança/))

Cada um dos tipos de dados C# primitivos (int, bool, doubl, etc) possui um método Parse que converte uma representação de seqüência de caracteres de um valor nesse tipo de dados. Por exemplo, bool.Parse usa como argumento uma string que representa um valor booleano como true e retorna o valor correspondentevalor bool true.Estes métodos Parse lançam exceções se suas entradas estiverem em um formato não reconhecido. Por exemplo, a instrução bool.Parse("yes") lança uma FormatException porque esse método entende apenas os valores true e false.

Você pode usar um bloco try-catch para proteger o programa dessas exceções, mas para tornar a verificação de valor ainda mais fácil, cada uma dessas classes também fornece um método TryParse. Este método tenta analisar uma string e retorna true se for bem-sucedido oufalse se falhar. Se for bem-sucedido, o método também salvará o valor analisado em uma variável de saída que você passa para o método.

```csharp
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

```csharp
DateTime.Parse("3:45 PM April 1, 2014").ToString()
DateTime.Parse("1 apr 2014 15:45").ToString()
DateTime.Parse("15:45 4/1/14").ToString()
DateTime.Parse("3:45pm 4.1.14").ToString()
```

Por padrão, no entanto, os métodos de análise não tratam bem os valores da moeda. Por exemplo, o código a seguir lança uma FormatException (na localidade em inglês dos EUA): 

```csharp
valor decimal = decimal.Parse ("$123.456,78");
```

A razão pela qual esse código falha é que, por padrão, o método decimal.Parse permite milhares e separadores decimais, mas não símbolos de moeda. Você podeativar símbolos de moeda no decimal. Parse, adicionando parâmetros que seja uma combinação de valores definidos pelo método Enumeração System.Globalization.NumberStyles. 

Se você fornecer quaisquer valores NumberStyles, quaisquer valores padrão serão removidos. Por exemplo, por padrão decimal.Parse permite milhares e separadores decimais. Se você passar o valor NumberStyles.AllowCurrencySymbol para o método, ele não permitirá mais milhares e separadores decimais. Para permitir todos os três, você precisa passar o método para todos os três valores, como no código a seguir:

```csharp
decimal amount = decimal.Parse("$123,456.78", NumberStyles.AllowCurrencySymbol | NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint);
```

Como alternativa, você pode transmitir ao método o estilo composto Currency, conforme mostrado no código a seguir:

```csharp
decimal amount = decimal.Parse("$123,456.78", NumberStyles.AllowCurrencySymbol);
```

### System.Convert(veja mais detalhes em [Depurar_segurança](https://shyoutarou.github.io/Exam-70-483_Depurar_segurança/))

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
 
```csharp
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

```csharp
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


```csharp
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


```csharp
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


```csharp
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


```csharp
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

```csharp
[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
staticexternuint GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string lpszLongPath,
    [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpszShortPath, uint cchBuffer);
```

O primeiro atributo MarshalAs indica que o primeiro e segundo parâmetro é um tipo de dados LPTStr no código não gerenciado e deve ser tratado como uma string e StringBuilder, respectivamente, no código gerenciado.Claro, se você usar esta declaração, precisará alterar o código para usar um StringBuilder para um buffer em vez de uma matriz de caracteres.

```csharp
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


```csharp

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

```csharp

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

```csharp
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

```csharp
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
