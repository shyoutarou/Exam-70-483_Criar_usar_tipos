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

  - [Manipular cadeias de caracteres](#manipular-cadeias-de-caracteres)
    - [Construtores de String](#construtores-de-string)
    - [Campos e propriedades da sequência](#campos-e-propriedades-da-sequência)
    - [Imutabilidade](#imutabilidade)
    - [Stringbuilder](#stringbuilder)
    - [StringReader](#stringreader)
    - [StringWriter](#stringwriter)
    - [Procurando por Strings](#procurando-por-strings)
    - [Enumerando Strings](#enumerando-strings)
    - [Formatando strings](#formatando-strings)
    - [ToString](#tostring)
    - [IFormatProvider e IFormattable](#iformatprovider-e-iformattable)
    - [Formatos numéricos padrão](#formatos-numéricos-padrão)
    - [Controle de espaçamento](#controle-de-espaçamento)
    - [Alinhadores de controle](#alinhadores-de-controle)
    - [Interpolação de Strings](#interpolação-de-strings)
    - [Como usar seqüências de escape em uma sequência interpolada](#como-usar-seqüências-de-escape-em-uma-sequência-interpolada)
    - [Como usar um operador condicional ternário](#como-usar-um-operador-condicional-ternário)
    - [Como criar uma string de resultados específica da cultura com interpolação de string](#como-criar-uma-string-de-resultados-específica-da-cultura-com-interpolação-de-string)
    - [Como criar uma sequência de resultados usando a cultura invariável](#como-criar-uma-sequência-de-resultados-usando-a-cultura-invariável)
    - [Caracteres especiais](#caracteres-especiais)
    
## Manipular cadeias de caracteres 
- **Manipular cadeias de caracteres usando as classes StringBuilder, StringWriter e StringReader; pesquisar cadeias de caracteres; enumerar métodos de cadeias de caracteres; formatar cadeias de caracteres; usar interpolação de cadeia($)**

Strings são diferentes de outros tipos de dados. Os programas geralmente os tratam como se fossem qualquer outro dado de valor, mas nos bastidores a classe string é notavelmente complexa. Por exemplo, se você entender Como as strings são armazenadas, saberá quando seria melhor usar a classe StringBuilder em vez de simplesmente concatenar as strings juntas.

No C#, a palavra-chave string é um alias para System.String cujo valor é text; portanto, quando você cria uma variável de string, na verdade, você está criando um objeto String. Internamente, o texto é armazenado como uma coleção sequencial de somente leitura de objetos Char. O .NET Framework representa caracteres como a versão Unicode UTF-16, um formato que usa 16 bits para armazenar cada caractere. Isso permite que um caractere Unicode represente muito mais caracteres do que os fornecidos em um teclado americano padrão. (A versão mais recente do Unicode define valores para mais de 110.000 caracteres em mais de 100 scripts.). 

Uma das características mais incomuns do Strings é que eles são imutáveis. Isso significa que o conteúdo de uma String não pode ser alterado após a criação da String. Em vez disso, métodos que parecem modificar o valor de uma String, como Replace e ToUpper, na verdade retornam um novo objeto String que contém o valor modificado. As operações de string no .NET são altamente otimizadas, portanto:
- Na maioria das condições, seu uso não afetará o desempenho
- Porém, as funções de loop que executam centenas ou milhares de vezes executando operações de string podem afetar o desempenho

Para economizar memória, o CLR mantém uma tabela chamada pool interno que contém uma única referência a cada único valor de texto usado por um programa. Qualquer variável String que se refere a uma parte específica do texto é na verdade uma referência ao pool interno. Múltiplas Strings que representam o mesmo valor referem-se à mesma entrada no pool interno.Tudo isso requer alguma sobrecarga, portanto, trabalhar com Strings não é tão rápido quanto trabalhar com tipos de valor. Se um programa deve executar um grande número de concatenações, cada um cria uma nova instância de String que deve ser internada e que leva tempo. Nesse caso, o uso da classe StringBuilder pode oferecer melhor desempenho. 

### Construtores de String

Três das maneiras mais comuns de inicializar uma variável String são:
- Setagem por uma string literal. (string mystring = "test";)
- Setagem por um controle TextBox ou ComboBox. (string mystring = TextBox.Text)
- Setagem por resultado de um cálculo. (string mystring = (1 + 2).ToString())

O último deles inclui métodos que formatam uma variável para produzir uma String, como usar o método ToString ou o método String.Format. Além desses métodos, a classe String fornece vários construtores que às vezes podem ser úteis:
1.	Inicializa a String a partir de uma matriz unidimensional de caracteres.
```csharp
var hello = newchar[] { 'H', 'e', 'l', 'l', 'o', '!' };
string ctor1 = newstring(hello);
Console.WriteLine(ctor1); //Hello!
```

2.	Um segundo construtor usa apenas parte de uma matriz de caracteres, tomando como parâmetros a matriz, uma posição inicial e o comprimento dos caracteres a serem usados.
```csharp
var hello = newchar[] { 'H', 'e', 'l', 'l', 'o', '!' };
string ctor2 = newstring(hello, 0, 4);
Console.WriteLine(ctor2); //Hell
```

3.	Um terceiro construtor usa como parâmetro um caractere e o número de vezes que você deseja repetir esse caractere na nova String. Isso pode ser particularmente útil se você quiser recuar uma sequência com um certo número de espaços ou caracteres de tabulação. 

Por exemplo, o código a seguir exibe os números de 1 a 10 em linhas separadas, com cada linha recuada mais quatro espaços que o anterior:
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/Sequencia.png" alt="Image" width="400px" />
</p>

```csharp
for (int i = 1; i <= 10; i++)
{
string indent = newstring(' ', 4 * i);
    Console.WriteLine(indent + i.ToString());
}
```

A maioria dos valores de String é criada por literais de string, texto digitado pelo usuário ou pelos resultados de cálculos, mas os construtores de String às vezes podem ser úteis.

### Campos e propriedades da sequência

A classe String fornece apenas três campos e propriedades: 
- **String.Empty**: que retorna um objeto que representa uma sequência vazia. Você pode usar esse valor para definir o valor de uma string ou para ver se uma string contém um valor vazio. (Como alternativa, você pode usar a string vazia literal "".)
- **Length**: que retorna o número de caracteres na string. 
- **Indexador read-only**: que retorna os caracteres na String. Por ser um indexador, você pode obter seus valores adicionando um índice ao nome de uma variável String. Por exemplo, a instruçãousername[4] retorna o caractere 4 da stringusername. O indexador é somente leitura, portanto, você não pode definir um dos caracteres da String com uma declaração como username[4] = 'x'. Se você precisar fazer algo assim, poderá usar os métodos String descritos na próxima seção. 

Se for mais fácil tratar a String como se fosse uma matriz de caracteres de leitura/gravação, você pode usar o método ToCharArray para converter String em uma matriz de caracteres, manipule-os e crie uma nova String passando o construtor pela matriz modificada. Por exemplo, o código a seguir usa uma matriz para alternar os caracteres de uma string entre maiúsculas e minúsculas:

```csharp
var text = "text em maiuscula e minusculas";

char[] characters = text.ToCharArray();
for (int i = 0; i < characters.Length; i++)
if (i % 2 == 0) characters[i] = char.ToUpper(characters[i]);
else characters[i] = char.ToLower(characters[i]);

text = newstring(characters);
Console.WriteLine(text); //TeXt eM MaIuScUlA E MiNuScUlAs
```

Você também pode usar o indexador como fonte de iteração em um loop foreach:

```csharp
text = "The quick brown fox jumps over the lazy dog.";
int[] counts = newint[26];
text = text.ToUpper();
foreach (char ch in text)
{
    Console.Write(ch + " - ");
if (char.IsLetter(ch))
    {
int index = (int)ch - (int)'A';
        counts[index]++;
    }
}
```

### Imutabilidade

String é usada para armazenar valores de texto. String é imutável, o que significa que, uma vez que uma variável de string armazena algum texto, ela não pode editá-lo novamente; o texto é armazenado como uma coleção somente leitura de objetos Char. Portanto, sempre que o valor de uma variável de string é atualizado, ele recria uma instância para literais de string, o que não é bom em termos de memória e consumo de processo. O código abaixo parece inocente, mas criará uma nova string para cada iteração no seu loop. Ele usa muita memória desnecessária e mostra por que você deve ter cuidado ao trabalhar com seqüências de caracteres.

```csharp
Stopwatch watch = new Stopwatch();
//Record how much time
watch.Start();

string mystring = "test";
for (int i = 1; i < 100000; i++)
{
    mystring += i;
}

//Stop Recording time
watch.Stop();
float miliToSec = watch.ElapsedMilliseconds / 1000;
Console.WriteLine("Total time: {0}s", miliToSec); // Total time: 19s
```

Esse código será executado 100.000 vezes e sempre que criará uma nova string. A referência "s" apontará apenas para o último item, para que todas as outras seqüências estejam prontas imediatamente para a coleta de lixo. Como o C# está ciente desse problema, o compilador tenta otimizar o trabalho com seqüências de caracteres para você. Ao criar dois string idênticos em uma unidade de compilação, o compilador garante que apenas um objeto de string seja criado pelo CLR. Isso é chamado de cadeia de caracteres interna (string interning), que é feita apenas no tempo de compilação. Fazer isso em tempo de execução acarretaria uma penalidade de desempenho excessiva (pesquisar todas as strings toda vez que você criar uma nova resulta em muita perda de performance).

Ao trabalhar com um número tão grande de operações de string, você deve ter em mente que a string é imutável e que o .NET Framework oferece algumas classes auxiliares especiais ao lidar com strings.

### Stringbuilder

StringBuilder é uma classe de System.Text que fornece melhor desempenho ao manipular dados de texto de uma maneira muito melhor que um System.String tradicional. StringBuilder é mutável, o que significa que os dados de texto podem ser editável. Seu método Append ajuda a concatenar os dados de texto, pois cria um buffer de sequência de caracteres que fornece melhor desempenho nessas situações. 

A classe StringBuilder pode ser usada quando você estiver trabalhando com seqüências de caracteres em um loop restrito. Em vez de criar uma nova sequência repetidamente, você pode usar o StringBuilder, que usa um buffer de seqüências internamente para melhorar o desempenho. A classe StringBuilder ainda permite alterar o valor de caracteres individuais dentro de uma string, adicionar uma nova linha ao texto existente ou limpar todo o conteúdo.

```csharp
//// Let's look at string concatenation
string s1 = "This is an example of s1 ";            
s1 = s1 + "string concatenation.";

//Isso realmente fará com que um novo objeto s1 seja criado
//This is an example of s1 string concatenation.
Console.WriteLine(s1);

// StringBuilder pode realmente acrescentar dados a uma string
StringBuilder sb2 = new StringBuilder("This is an example of sb2 ");
sb2.Append("string concatenation.");
Console.WriteLine(sb2); // This is an example of sb2 string concatenation

// O StringBuilder pode adicionar uma nova linha ao texto existente ou limpar todo o conteúdo
sb2.AppendLine();
sb2.Append("Using StringBuilder...");
Console.WriteLine(sb2);// This is an example of sb2 string concatenationUsing StringBuilder...

// StringBuilder pode substituir o conteúdo no objeto
sb2.Replace("StringBuilder", "the StringBuilder class...");
Console.WriteLine(sb2);
// This is an example of sb2 string concatenation.
// Using the StringBuilder class......

sb2[0] = 'N';
sb2[1] = 'Ó';
Console.WriteLine(sb2);
// NÓis is an example of sb2 string concatenation.
// Using the StringBuilder class......
```

Se executar novamente a análise de performance realizada no System.String anteriormente teremos:

```csharp
Stopwatch watch = new Stopwatch();
//Record how much time
watch.Start();
StringBuilder mystring = new StringBuilder("test");
for (int i = 1; i < 100000; i++)
{
    mystring.Append(i);
}
//Stop Recording time
watch.Stop();
float miliToSec = watch.ElapsedMilliseconds / 1000;

Console.WriteLine("Total time: {0}ms", miliToSec); // Total time: 0ms
Console.ReadKey();
```

Na minha máquina, foram necessários 0 milissegundos para acrescentar um texto no StringBuilder, enquanto no exemplo anterior System.String levou 19 segundos. Portanto, o StringBuilder é mais rápido que o System.String. Mas um aspecto a ter em mente é que o StringBuilder nem sempre oferece melhor desempenho. Ao concatenar uma série fixa de seqüências, o compilador pode otimizar isso e combinar operações de concatenação individuais em uma única operação. Quando você está trabalhando com um número arbitrário de strings, como no exemplo de loop, um StringBuilder é uma escolha melhor (neste exemplo, você poderia ter usado também umnew String (“x”, 10000) para criar a string; ao lidar com com dados mais variados, isso não será possível).

Lembre-se também de que os tempos envolvidos para algumas operações de String são pequenos. O uso de um StringBuilder para concatenar 10 seqüências pode ser um pouco mais rápido do que executar 10 concatenações simples, mas a quantidade total de tempo economizada é medida em milissegundos. A menos que o programa repita essa operação muitas vezes ou faça concatenações muito mais longas, talvez seja melhor sacrificar alguns milissegundos para manter o código mais fácil de entender.

A Tabela a seguir descreve as propriedades mais úteis da classe StringBuilder.


| Propriedade | Descrição | 
|:----------|------|
| Capacity | Obtém ou define o número de caracteres que podem ser mantidos pelo StringBuilder. Se a quantidade de texto armazenada no StringBuilder excede esse valor, o objeto aloca mais espaço. Se você sabe que o StringBuilder precisa armazenar pelo menos um certo número de caracteres, você pode usar essa propriedade para fazer com que o objeto pré-aloque memória em vez de alocar memória de forma incremental. Algumas versões sobrecarregadas do construtor da classe permitem especificar uma capacidade inicial. | 
| Length  |  Obtém ou define o número atual dos caracteres armazenados no StringBuilder. Se você definir esse valor como menor que o comprimento atual, o texto no StringBuilder será truncado |

A Tabela abaixo descreve os métodos mais úteis da classe StringBuilder.


| Método | Descrição | 
|:----------|------|
| Append | Anexa uma representação de string de um objeto ao final do texto doStringBuilder  | 
| AppendFormat  |  Formata uma série de objetos e anexa o resultado ao final do texto do StringBuilder |
| EnsureCapacity  |  Garante que o StringBuilder tenha pelo menos uma determinada capacidade | 
| Insert | Insere uma representação de seqüência de caracteres de um objeto em uma determinada posição no texto do StringBuilder | 
| Remove | Remove um intervalo de caracteres do texto do StringBuilder | 
| Replace  |  Substitui todas as instâncias de um caractere ou sequência por um novo caractere ou sequência |
| ToString  |  Retorna uma representação String normal do texto do StringBuilder | 
	
Algumas APIs no .NET Framework esperam que um TextWriter ou TextReader funcione. Essas APIs não podem funcionar diretamente com uma string ou com o StringBuilder. Por isso, o .NET Framework adiciona uma classe StringReader e StringWriter. Essas classes adaptam a interface do StringBuilder para que possam ser usadas em locais onde é esperado um TextWriter ou TextReader. 

### StringReader

StringReader é uma classe do System.IO usada para ler linhas de uma string. Com StringReader, podemos ler um caractere com o método Read ou ReadAsync e uma string inteira com o método ReadToEnd ou ReadToEndAsync. Esse tipo ajuda a acessar dados da string por meio de uma interface orientada a fluxo (Stream).A classe StringReader fornece uma implementação TextReader que lê partes de dados obtidas de um StringBuilder subjacente. Ele fornece métodos que facilitam a leitura seqüencial de partes de texto de uma string.

| Método | Descrição | 
|:----------|------|
| Peek | Retorna o próximo caractere nos dados, mas não avança para o seguinte caractere. | 
| Read  |  Retorna o próximo caractere nos dados e avança para o seguinte caractere. Uma versão sobrecarregada pode ler um bloco de caracteres. |
| ReadAsync  |  Lê assincronamente caracteres do StringReader em um buffer. | 
| ReadBlock  |  Lê até um número máximo de caracteres do StringReader em um buffer começando em um índice especificado. | 
| ReadBlockAsync  |  Lê assincronamente até um número máximo de caracteres do StringReader em um buffer começando em um índice especificado. | 	
| ReadLine  |  Lê caracteres do StringReader até encontrar o final da linha. | 	
| ReadLineAsync  |  Lê assincronamente caracteres do StringReader até encontrar o final da linha. | 	
| ReadToEnd  |  Retorna o texto restante do StringReader como uma String. | 	
| ReadToEndAsync  |  Retorna assincronamente o texto restante do StringReader como uma String | 				
	
```csharp
//'@' It's a verbatim string literal. It ignores escape sequence
string text = @"Hi I'm Ali Asad.
            I can help you in C# Certification Exam.
            I've helped many individuals like you in their exam prep.
            I believe if we work together, you can become:
            Microsoft Certified Professional & Specialist in C#";
StringReader reader = new StringReader(text);
int currentLine = 0;
string line = "";
//return each line of string to 'line'
while ((line = reader.ReadLine()) != null)
{
    Console.WriteLine("line{0}: {1}", ++currentLine, line.Trim());
}
```

### StringWriter

StringWriter é uma classe do System.IO. É usado para gravar em uma classe StringBuilder. Com StringWriter, podemos escrever um caractere/string com o método Write ou WriteAsync e uma linha inteira de string com o método WriteLine ou WriteLineAsync. É uma maneira eficiente de usar o StringBuilder com o StringWriter para manipular a string. A classe StringWriter fornece métodos que facilitam a gravação sequencial de valores em uma string. A Tabela a seguir descreve os métodos mais úteis do StringWriter.

| Método | Descrição | 
|:----------|------|
| Flush | Libera todos os dados armazenados no StringWriter subjacente. | 
| ToString  | Retorna o conteúdo atual do objeto como uma String. |
| Write  |  Anexa um item aos dados da sequência. As versões sobrecarregadas anexam char, string, int, double e muitos outros tipos de dados. | 
| WriteAsync  |  Anexa de forma assíncrona um caractere, sequência ou matriz de caracteres ao final dos dados da sequência. |
| WriteLine  |  Anexa um item aos dados da string da mesma forma que Write e adiciona uma nova linha. | 

```csharp
StringBuilder builder = new StringBuilder();
StringWriter swriter = new StringWriter(builder);
swriter.Write("Ali Asad");

//Ali Asad
Console.WriteLine(builder.ToString());
```
	
Um dos métodos no .NET Framework que espera uma instância do TextWriter é o XmlWriter.Create. Normalmente, você transmite uma instância do StreamWriter para poder criar um novo arquivo XML. Mas quando você deseja o XML resultante apenas na memória, pode passar um StringWriter.

```csharp
var stringWriter = new StringWriter();
using (XmlWriter writer = XmlWriter.Create(stringWriter))
{
    writer.WriteStartElement("book");
    writer.WriteElementString("price", "19.95");
    writer.WriteEndElement();
    writer.Flush();
}
string xml = stringWriter.ToString();
//<?xml version="1.0" encoding="utf-16"?><book><price>19.95</price></book>
Console.WriteLine(xml);
```

Ao usar o XmlReader, você pode analisar um pouco de XML e acessar os elementos individuais. XmlReader espera uma instância do TextWriter, para que você possa passar um StringReader

```csharp
var stringReader = new StringReader(xml);
using (XmlReader readerxml = XmlReader.Create(stringReader))
{
    readerxml.ReadToFollowing("price");

// Make sure that you read the decimal part correctly
decimal price = decimal.Parse(readerxml.ReadInnerXml(), new CultureInfo("en-US"));
    Console.WriteLine(price); //19,95
}
```

O método Serialize da classe XmlSerializer envia a saída para um TextWriter. Se você deseja serializar em uma string, pode enviar a saída para um StringWriter e depois usar o método ToString do StringWriter para obter o resultado. Se você precisar manipular os dados da string subjacente de outras maneiras, como remover ou substituir caracteres, o StringBuilder fornece mais flexibilidade.

Internamente, StringWriter e StringReader usam um StringBuilder. A única coisa que eles fazem é adaptar a interface do StringBuilder à do TextWriter e TextReader. Conforme pode ser visto com mais clareza no seguinte exemplo:

```csharp

class Program
{
    static void Main(string[] args)
    {
        StringReadWrite srw = new StringReadWrite();
    }
}

public class StringReadWrite
{
    StringBuilder sb = new StringBuilder();

    public StringReadWrite()
    {
        WriteData();
        ReadData();
        Console.ReadKey();
    }

    public void WriteData()
    {
        // Note that we are passing the StringBuilder sb object to the StringWriter
        StringWriter sw = new StringWriter(sb);
        Console.WriteLine("Please enter your first and last name...");
        string name = Console.ReadLine();

        // Write the name to the StringBuilder sb object
        sw.WriteLine("Name: " + name);

        // Close the sw stream object
        sw.Flush();
        sw.Close();
    }

    public void ReadData()
    {
        // Note we are converting the sb object to a string and passing it to the StringReader
        StringReader sr = new StringReader(sb.ToString());
        Console.WriteLine("Reading the information...");

        // Use Peek to see if another character exists in sb
        while (sr.Peek() > -1)
        {
            // Read a line from the string and display it
            Console.WriteLine(sr.ReadLine());
        }

        Console.WriteLine("Thank you!");
        sr.Close();
    }
}
//Please enter your first and last name...
//Rick Bob
//Reading the information...
//Name: Rick Bob
//Thank you!
```

### Procurando por Strings

Ao trabalhar com cadeias de caracteres, você costuma procurar uma substring dentro de outra cadeia de caracteres, para analisar algum conteúdo ou verificar a entrada válida do usuário ou outro cenário.A classe String oferece alguns métodos que podem ajudá-lo a executar todos os tipos de ações de pesquisa. Os mais comuns são IndexOf, LastIndexOf, StartsWith, EndsWith e SubString.

Uma coisa a ter em mente é que os métodos de string podem ser sensíveis à cultura. É por isso que a maioria dos métodos aceita uma instância da enumeração StringComparison. Ao trabalhar com seqüências de caracteres, sempre tente evitar os métodos que não usam um valor explícito de StringComparison.

| Método | Descrição | Exemplo ```value = "<mycustominput>" ```  |
|:----------|------|---------------------|
| IndexOf | Retorna o índice da primeira ocorrência de um caractere ou substring em uma string. Se o valor não puder ser encontrado, ele retorna -1. | ```value.IndexOf('y'); // 2``` |
| LastIndexOf  |  O mesmo que IndexOf, exceto que esse método começa a pesquisar no final de uma sequência e passa para o início | ```value.LastIndexOf('m');``` // 8 |
| StartsWith  |  Verifica se o string inicia com um determinado valor. Retorna verdadeiro ou falso.|  ```if(value.StartsWith("<")) { }``` |
| EndsWith  |  Verifica se o string termina com um determinado valor. Retorna verdadeiro ou falso. | ```if(value.EndsWith(">")) { }``` |
| SubString  | Recupera uma cadeia parcial de outra cadeia |  ```value.Substring(3, 6);``` //custom |

Outra maneira de pesquisar uma string é usando uma expressão regular, que usa uma notação de correspondência de padrões que pode analisar rapidamente grandes quantidades de texto procurando um formato específico. Expressões regulares podem ser úteis ao validar a entrada do usuário (como um endereço de email, CEP ou data). O código abaixo retira todos os títulos dos nomes que você passa. Imagine quanto trabalho teria sido criar isso ao usar IndexOf e SubString.

```csharp
string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )";
string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels", "Abraham Adams", "Ms. Nicole Norris" };
foreach (string name in names)
    Console.WriteLine(Regex.Replace(name, pattern, String.Empty));
//Henry Hunt
//Sara Samuels
//Abraham Adams
//Nicole Norris
```

### Enumerando Strings

Uma string é uma matriz de caracteres. Você pode enumerar uma sequência como se fosse uma coleção típica. Como uma string implementa IEnumerable e IEnumerable<Char>, expõe o método GetEnumerator que você pode usar para iterar sobre uma string.

Você pode usar uma sequência em um loop foreach para verificar todos os caracteres individuais, como abaixo:

```csharp
string value = "My Custom Value";
foreach (char c in value)
    Console.WriteLine(c);
```

Também é possível dividir uma sequência de palavras e iterá-las. A seguinte linha divide a sentença em espaços; retorna um IEnumerable que pode ser iterado:

```csharp
foreach (string word in"My sentence separated by spaces".Split(' '))
    Console.WriteLine(word);
```

Um exemplo usando apenas StringBuilders (sem Strings), podemos escrer um programa que exiba todas as subsequências iniciais das letras do alfabeto A, AB, ABC e assim por diante.

```csharp
StringBuilder letters = new StringBuilder("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
StringBuilder line = new StringBuilder();
// Create the result StringBuilder. 
StringBuilder result = new StringBuilder();
// Loop over the letters. 
for (int i = 0; i < 26; i++)
{
// Add the next letter to line. 
    line.Append(letters[i]);
// Add line to the result. 
    result.AppendLine(line.ToString());
}
```

As String possuem muitos métodos e propriedades que ajudam a manipular dados de texto. Alguns deles estão listados abaixo.

| Método | Descrição | ``` Exemplo value = "<mycustominput>" ``` <br> ``` string value2 = "Ali"; ```  |
|:----------|------|---------------------|
| Clone | Use para criar clone de sequência no tipo de objeto. | ```value.Clone() as string;```  |
| CompareTo  |  Compare dois valores de sequência e retorne o valor inteiro. Retorna 0 para true e -1 para false | ```string value2 = "asad";``` <br> ```if ((value.CompareTo(value2)) == 0)``` |
| Equals  |  Compare duas strings e retorne true se forem iguais. |  ```value.Equals(value2)``` //False |
| IndexOf | Retorne o número do índice da primeira ocorrência de um caractere especificado. | ```value.IndexOf('t')```//6  | 
| ToLower  |  Retorne a minúscula da string. | ```value2.ToLower()```//ali |
| ToUpper  |  Retorne a caixa alta da string. |  ```value.ToUpper() //<MYCUSTOMINPUT>```|
| Insert | Retorna uma nova string na qual um novo caractere/string é inserido em um índice especificado de uma string. |  ```value2.Insert(3, " Asad") ``` //Ali Asad |
| Remove  |  Retorne uma nova string excluindo todos os caracteres de um índice especificado até o final. | ```value.Remove(3) //<my```  |
| Replace  |  Retorna uma nova string na qual a ocorrência de caracteres especificados é substituída por outra especificada personagens. |  ```value2.Replace("Ali","Asad")``` //Asad |
| Split | Divida uma sequência em uma matriz de sequências baseada nos caracteres que ocorrem em uma sequência. |  ```value2.Split(' ')``` |
| ToCharArray  |  Retornar uma nova matriz de caracteres que contém um caractere de uma sequência | ```value2.ToCharArray()``` |
| Trim  |  Remova os espaços em branco do início e do final de uma string. |  ```value2.Trim()```|

### Formatando strings

Ao exibir seqüências de caracteres para o usuário, você deseja garantir que elas estejam no formato correto. Especialmente ao trabalhar com dados sensíveis à cultura, como DateTime ou números, é importante garantir que a sequência seja exibida de maneira adequada aos usuários atuais e suas configurações.

Formatar um valor para exibição é uma conversão de tipo particularmente importante. Até converter um DateTime, decimal ou double em algum tipo de String, você não pode exibi-lo para o usuário. Dois dos métodos mais úteis para realizar a “Formatação composta” de valores como strings são os métodos ToString e String.Format. Outra forma de formatação é a interpolação de strings que veremos mais adiante. As cadeias de formatação se enquadram em duas grandes categorias:
- **Formatação padrão**: permitem determinar como você deseja que um valor seja exibido em um nível alto. As cadeias de formatação padrão reconhecem a localidade, portanto, permitem que o programa produza uma saída apropriada para a localidade do computador. Por exemplo, a sequência de formato de data “d” indica um padrão de data curto e produz um resultado semelhante a 14/03/2014 nos Estados Unidos ou 14/03/2014 na França.
- **Formatação personalizadas**: permitem criar formatos que não são fornecidos pelas seqüências de formatação padrão. Por exemplo, a instrução a seguir produz um resultado semelhante ao: São agora 14 horas. Console.WriteLine (string.Format ("São agora {0: HH} horas", DateTime.Now)).

### ToString

A classe de objeto fornece um método ToString que todas as outras classes herdam. Por padrão, esse método retorna o nome do tipo de um objeto como uma String, mas a maioria das classes para as quais faz sentido substitui esse método para retornar o valor do objeto como uma String. Por exemplo, se uma variável flutuante mantiver o valor 1,23, seu método ToString retornará o valor "1,23" como uma sequência. Por outro lado, se você definir uma classe Employee, por padrão, o método ToString retornará o nome da classe, semelhante ao Formatting.Employee. Se você usar o método ToString de uma variável sem parâmetros, obterá uma representação padrão de seu valor. 

```csharp
classEmployee
{
    public string  Name { get; set; }
    public decimal Salary { get; set; }
}

decimal inteiro = newint();
decimal value = 1.23m;
Employee e = new Employee();
Console.WriteLine(inteiro); //  0
Console.WriteLine(value); //  1,23
Console.WriteLine(e); // Formatting.Employee
Console.WriteLine(e.ToString()); // Formatting.Employee
```

O método ToString também pode levar como parâmetros um provedor de formato, uma string de formatação ou ambos. Usando a sequência de formatação, você pode personalizar o texto resultante. Por exemplo, se o custo variável for flutuante, a instrução value.ToString ("0,000000") produzirá uma sequência contendo o valor do custo exibido mais casas decimais.

```csharp
decimal value = 1.23m;
Console.WriteLine(value.ToString("0.000000")); // 1,230000
Console.WriteLine(value.ToString("0,000000")); // 0.000.001
```

Quando um objeto possui várias representações de seqüência de caracteres, a substituição de ToString não é suficiente. Por exemplo, um objeto Temperatura pode exibir sua temperatura em graus Fahrenheit, Celsius ou Kelvin. Um valor inteiro também pode ser exibido de várias maneiras. Talvez represente um número de telefone ou uma quantia em dinheiro. Para habilitar esse tipo de comportamento, você pode usar seqüências de caracteres de formato, que descrevem como um objeto deve ser exibido. O .NET Framework os utiliza para tipos numéricos, datas, horas e enumerações, como mostra abaixo.

```csharp
double cost = 1234.56;
Console.WriteLine(cost.ToString("C", new CultureInfo("en-US"))); // $1,234.56
```


Você pode usar a mesma abordagem ao exibir um valor de data e hora. Dependendo da cultura, a saída formatada pode ser completamente diferente. A código a seguir mostra como usar cadeias de formato diferentes com um DateTime para uma cultura inglesa.

```csharp
DateTime d = new DateTime(2013, 4, 22);
CultureInfo provider = new CultureInfo("en-US");
Console.WriteLine(d.ToString("d", provider)); // Displays 4/22/2013
Console.WriteLine(d.ToString("D", provider)); // Displays Monday, April 22, 2013
Console.WriteLine(d.ToString("M", provider)); // Displays April 22
```

Fornecer o CultureInfo correto é importante ao formatar valores. Ele contém todas as informações necessárias sobre como um tipo específico é exibido nessa cultura. Da mesma forma, é importante garantir que, quando você salvar valores em um banco de dados, por exemplo, você faz isso de uma maneira que não agride a cultura. Se os dados insensíveis à cultura forem carregados, eles poderão ser formatados dependendo do usuário que estiver visualizando os dados.

Você também pode implementar essa formatação personalizada em seus próprios tipos. Você faz isso criando um método ToString (string) no seu tipo. Overridingo ToString é uma boa prática. Se você não fizer isso, o ToString retornará por padrão o nome do seu tipo. Ao overrideo ToString, você pode atribuir um valor mais significativo, como mostra a exemplo.

```csharp
class Person
{
    public Person(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public string  FirstName { get; set; }
    public string  LastName { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return FirstName + " " + LastName;
    }

    public string  ToString(string format)
    {
        if (string.IsNullOrWhiteSpace(format)) format = "FL";
        format = format.Trim().ToUpperInvariant();
        switch (format)
        {
            case"FL":
            return FirstName + " " + LastName;
            case"LF":
            return LastName.ToUpper() + ", " + FirstName;
            case"FSA":
            return FirstName + " " + LastName + "(" + Age + ")";
            default:
            throw new FormatException(String.Format(
            "The '{0}' format string is not supported.", format));
        }
    }
}

Person p = new Person("John", "Doe", 24);
Console.WriteLine(p); // John Doe
Console.WriteLine(p.ToString()); // John Doe
Console.WriteLine(p.ToString("LF")); // DOE, John
Console.WriteLine(p.ToString("fsa")); // John, Doe(24)

```

### IFormatProvider e IFormattable

Ao formatar seqüências de caracteres, você também pode usar um IFormatProvider. O IFormatProvider possui um método, GetFormat (Type), que retorna informações de formatação específicas para formatar um tipo. Todos os objetos CultureInfo implementam IFormatProvider. O objeto CultureInfo retorna um NumberFormatInfo ou DateTimeFormatInfo específico da cultura se uma sequência de caracteres ou DateTime estiver formatada. Dessa forma, você pode formatar uma string como cultura específica, passando um objeto CultureInfo para o método ToString.

Ao implementar seu próprio método de formatação ToString em um tipo, você também pode optar por aceitar um IFormatProvider. Ao fazer isso, você pode implementar a interface IFormattable. O uso do IFormattable garante que você possa integrar-se ao .NET Framework quando se trata de formatar seqüências de caracteres.

Ao implementar o IFormattable, você tem suporte para conversão de string pela classe Convert (que possui uma sobrecarga que aceita um objeto e o IFormatProvider). Você também pode suportar a Formatação Composta, na qual seu tipo é usado para criar uma sequência composta com outros tipos.

O método ToString permite converter o valor de uma única variável em uma String. O método Format estático da classe String permite criar uma String que pode conter os valores de muitas variáveis formatadas de maneiras diferentes. O método String.Format possui algumas versões sobrecarregadas, mas o mais comum toma como parâmetros uma string de formatação e um ou mais argumentos usados para preencher itens na cadeia de formatação. O código a seguir mostra um exemplo simples.

```csharp
int a = 1;
int b = 2;
string result = string.Format("a: {0}, b: {1}", a, b);
Console.WriteLine(result); // Displays ‘a: 1, b: 2’
```

Os métodos ToString e String.Format entendem centenas de seqüências de caracteres de formato padrão e personalizadas. Objetos são de vários tipos e alguns são raramente usados. Para cada tipo, os dados são armazenados ou exibidos em um formato diferente. Alguns dos formatos estão listados abaixo:

### Formatos numéricos padrão

| Especificador | Descrição | Exemplo |
|:----------|------|---------------------|
| "C" ou "c" | Usado para formatar o valor da moeda |  ```$12,345.67``` |
| "D" ou "d"  |  Usado para formatar dígitos inteiros com sinal negativo opcional | ```12345``` |
| "E" ou "e"  |  Usado para formatar notação exponencial |  ```1.234567E+004```|
| "F" ou "f"  |  Usado para o especificador de precisão para definir o valor flutuante fixo |  ```12345.67```|
| "G" ou "g"  |  Geral (ponto fixo ou científico, o que for mais curto |  ```12345.67```|
| "N" ou "n"  |  Usado para formatar números por separadores de grupos(com separadores decimais e milhares) |  ```12,345.67```|		
| "P" ou "p"  |  Usado para exibir porcentagem com número(multiplicado por 100 e% adicionada) |  ```0.12 torna 12.00%```|
| "X" ou "x"  |  Usado para exibir o valor hexadecimal(somente tipos inteiros) |  ```3039```|		

Alguns desses formatos podem ter um especi ﬁ cador de precisão opcional que controla o número de dígitos exibidos. Para a maioria desses tipos, o especi ﬁ cador de precisão indica o número de dígitos a serem exibidos após o ponto decimal. Por exemplo, se o valor for 12345.67, então value.ToString ("C4") produz $ 12.345,6700. Para notação científica, o especificador de precisão indica o número de dígitos após o ponto decimal na mantissa. Por exemplo, se o valor for 12345.67, então value.ToString ("E2") produz 1,23E + 004.

Formatos DateTime padrão

| Formato | Descrição | Exemplo |
|:----------|------|---------------------|
| d | Short date |  ``` 3/14/2014 ``` |
| D  |  Long date | ```Friday, March 14, 2012``` |
| f  |  “Full” with short time |  ```Friday, March 14, 2012 2:15 PM```|
| F | “Full” with long time |  ``` Friday, March 14, 2012 2:15:16 PM ``` |
| g  |  “General” with short time | ```3/14/2014 2:15 PM``` |
| G  |  “General” with long time |  ```3/14/2014 2:15:16 PM```|
| M ou m | Month/day |  ``` March 14 ``` |
| t | Short time |  ``` 2:15 PM ``` |
| T  |  Long time | ```2:15:16 PM``` |
| Y ou y  |  Year/month |  ```March, 2014```|

Além desses formatos padrão, a estrutura DateTime fornece quatro métodos que produzem resultados semelhantes aos especificadores dos formatos d, D, te T. Esses métodos são ToShortDateString, ToLongDateString, ToShortTimeString e ToLongTimeString

### Controle de espaçamento

O espaçamento é útil para formatar a saída. String pode ajudar a formatar o espaçamento.
```csharp
string name = "Ali";
int age = 22;
//Name Ali | Age         22
Console.WriteLine("Name {0,10} | Age {1, 10}", name, age);
```


### Alinhadores de controle 

Por padrão, as strings estão alinhadas à direita. Para criar uma sequência alinhada à esquerda em um campo, você precisa usar um sinal negativo, como {0, -5} para definir um campo alinhado à direita de 5 caracteres.
```csharp
//- Ali | end
string name = "Ali";
Console.WriteLine("- {0,-8} |end", name);
```

### Interpolação de Strings

O recurso interpolação de cadeia de caracteres baseia-se no recurso formatação composta e fornece uma sintaxe mais legível e conveniente para incluir resultados de expressão formatada em uma cadeia de caracteres de resultado. Este recurso está disponível a partir de C# 6. Para identificar uma literal de cadeia de caracteres como uma cadeia de caracteres interpolada, preceda-o com o símbolo $. Você pode inserir qualquer expressão C# válida que retorna um valor em uma cadeia de caracteres interpolada. No seguinte exemplo, assim que uma expressão é avaliada, o resultado é convertido em uma cadeia de caracteres e incluído em uma cadeia de caracteres de resultado:

```csharp
string name = "Mark";
var date = DateTime.Now;
// Composite formatting:
Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
// String interpolation:
Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
// Hello, Mark! Today is Sunday, it's 12:20 now.

```


Cadeia de caracteres interpoladas são compatíveis com todos os recursos do recurso formatação composta de cadeia de caracteres. Isso as torna uma alternativa mais legível ao uso do método String.Format.

A estrutura de um item com uma expressão de interpolação é a seguinte:

```{<interpolationExpression> [, <alignment>] [: <formatString>]}```

Elementos em colchetes são opcionais. A tabela a seguir descreve cada elemento:
| Elemento | Descrição | 
|:----------|------|
| interpolationExpression | A expressão que produz um resultado a ser formatado. A representação em cadeia de null é String.Empty. | 
| alignment  |  A expressão constante cujo valor define o número mínimo de caracteres na representação de sequência do resultado da expressão. Se positivo, a representação da string está alinhada à direita; se negativo, está alinhado à esquerda.  |
| formatString  | Um formato string suportada pelo tipo do resultado da expressão. | 


O exemplo a seguir usa os componentes opcionais de formatação descritos acima:

```csharp
Console.WriteLine($"|{"Left",-7}|{"Right",7}|"); //| Left | Right |

constint FieldWidthRightAligned = 20;
//    3,14159265358979 - default formatting of the pi number
Console.WriteLine($"{Math.PI,FieldWidthRightAligned} - default formatting of the pi number");
//               3,142 - display only three decimal digits of the pi number
Console.WriteLine($"{Math.PI,FieldWidthRightAligned:F3} - display only three decimal digits of the pi number");
```

Especifique uma cadeia de caracteres de formato compatível com o tipo do resultado de expressão seguindo a expressão de interpolação com dois-pontos ```(":")``` e o format string. 

```{<interpolationExpression>:<formatString>}```

O seguinte exemplo mostra como especificar cadeias de caracteres de formato padrão e personalizadas para expressões que produzem resultados numéricos ou de data e hora:

```csharp
var data = new DateTime(1731, 11, 25);
Console.WriteLine($"On {data:dddd, MMMM dd, yyyy} Leonhard Euler introduced the letter e to denote {Math.E:F5} in a letter to Christian Goldbach.");
```


Você especifica a largura mínima do campo e o alinhamento do resultado da expressão formatada seguindo a expressão de interpolação com uma vírgula (",") e a expressão constante:

```{<interpolationExpression>, <alignment>}```

Se o valor do alinhamento for positivo, o resultado da expressão formatada será alinhado à direita; se negativo, está alinhado à esquerda. Se você precisar especificar o alinhamento e uma sequência de formato, comece com o componente de alinhamento:

```{<interpolationExpression>, <alignment>: <formatString>}```

O exemplo a seguir mostra como especificar o alinhamento e usa caracteres de barra vertical ("|") para delimitar os campos de texto:

```csharp
double a = 3;
double b = 4;
Console.WriteLine($"Three classical Pythagorean means of {a} and {b}:");
Console.WriteLine($"|{"Arithmetic",NameAlignment}|{0.5 * (a + b),ValueAlignment:F3}|"); //| Arithmetic | 3,500 |
Console.WriteLine($"|{"Geometric",NameAlignment}|{Math.Sqrt(a * b),ValueAlignment:F3}|"); // | Geometric | 3,464 |
Console.WriteLine($"|{"Harmonic",NameAlignment}|{2 / (1 / a + 1 / b),ValueAlignment:F3}|"); //  | Harmonic | 3,429 |
```

Como mostra a saída de exemplo, se o comprimento do resultado da expressão formatada exceder a largura do campo especificada, o valor do alinhamento será ignorado.

### Como usar seqüências de escape em uma sequência interpolada

Seqüências de caracteres interpoladas suportam todas as seqüências de escape que podem ser usadas em literais de seqüência de caracteres comuns. Para obter mais informações, consulte Sequências de escape de string.

Para interpretar seqüências de escape literalmente, use uma string literal literal. Uma sequência literal interpolada começa com o caractere $ seguido pelo caractere @. A partir do C# 8.0, você pode usar os tokens $ e @ em qualquer ordem: $ @ "..." e @ $ "..." são cadeias verbais interpoladas válidas.

{% raw %}

Para incluir um colchete, "{" ou "}", em uma sequência de resultados, use dois colchetes, "{{" ou "}}". Para obter mais informações, consulte a seção Escapando chaves do tópico Formatação composta.

O exemplo a seguir mostra como incluir chaves em uma sequência de resultados e construir uma sequência interpolada literal:

```csharp
var xs = newint[] { 1, 2, 7, 9 };
var ys = newint[] { 7, 9, 12 };
Console.WriteLine($"Find the intersection of the {{{string.Join(", ", xs)}}} and {{{string.Join(", ", ys)}}} sets.");

var userName = "Jane";
var stringWithEscapes = $"C:\\Users\\{userName}\\Documents";
var verbatimInterpolated = $@"C:\Users\{userName}\Documents";
Console.WriteLine(stringWithEscapes);
Console.WriteLine(verbatimInterpolated);
```
{% endraw %}

### Como usar um operador condicional ternário

Como os dois pontos ```(":")``` têm um significado especial em um item com uma expressão de interpolação, para usar um operador condicional em uma expressão, coloque-o entre parênteses, como mostra o exemplo a seguir:

```csharp
var rand = new Random();
for (int i = 0; i < 7; i++)
{
    Console.WriteLine($"Coin flip: {(rand.NextDouble() < 0.5 ? "heads" : "tails")}");
}

```

### Como criar uma string de resultados específica da cultura com interpolação de string

Por padrão, uma cadeia de caracteres interpolada usa a cultura atual definida pela propriedade CultureInfo.CurrentCulture para todas as operações de formatação. Use a conversão implícita de uma seqüência de caracteres interpolada em uma instância System.FormattableString e chame seu método ToString (IFormatProvider) para criar uma sequência de resultados específica da cultura. O exemplo a seguir mostra como fazer isso:

```csharp

var cultures = new System.Globalization.CultureInfo[]
{
    System.Globalization.CultureInfo.GetCultureInfo("en-US"),
    System.Globalization.CultureInfo.GetCultureInfo("en-GB"),
    System.Globalization.CultureInfo.GetCultureInfo("nl-NL"),
    System.Globalization.CultureInfo.InvariantCulture
};

var data2 = DateTime.Now;
var number = 31_415_926.536;
FormattableString message = $"{data2,20}{number,20:N3}";
foreach (var culture in cultures)
{
var cultureSpecificMessage = message.ToString(culture);
    Console.WriteLine($"{culture.Name,-10}{cultureSpecificMessage}");
}
```

Como o exemplo mostra, você pode usar uma instância FormattableString para gerar várias seqüências de resultados para várias culturas.

### Como criar uma sequência de resultados usando a cultura invariável

Junto com o método FormattableString.ToString (IFormatProvider), você pode usar o método estático FormattableString.Invariant para resolver uma seqüência de caracteres interpolada em uma seqüência de resultados da InvariantCulture. O exemplo a seguir mostra como fazer isso:

```csharp
string messageInInvariantCulture = FormattableString.Invariant($"Date and time in invariant culture: {DateTime.Now}");
Console.WriteLine(messageInInvariantCulture);
```

### Caracteres especiais

{% raw %}

Para incluir uma chave, "{" ou "}", no texto produzido por uma cadeia de caracteres interpolada, use duas chaves, "{{" ou "}}". Como os dois-pontos ```(":")``` têm um significado especial em um item de expressão de interpolação, para usar um operador condicional em uma expressão de interpolação, coloque essa expressão entre parênteses.

O seguinte exemplo mostra como incluir uma chave em uma cadeia de caracteres de resultado e como usar um operador condicional em uma expressão de interpolação:


```csharp
string nome = "Horace";
int age = 34;
Console.WriteLine($"He asked, \"Is your name {nome}?\", but didn't wait for a reply :-{{"); 
Console.WriteLine($"{nome} is {age} year{(age == 1 ? "" : "s")} old.");
//He asked, "Is your name Horace?", but didn't wait for a reply :-{
//Horace is 34 years old.
```

{% endraw %}    


