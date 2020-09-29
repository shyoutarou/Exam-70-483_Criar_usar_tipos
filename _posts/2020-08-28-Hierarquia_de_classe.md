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



## Criar e implementar uma hierarquia de classe 
- **Projetar e implementar uma interface; herdar de uma classe base; criar e implementar classes com base nas interfaces IComparable, IEnumerable, IDisposable e IUnknown**

### HERANÇA   

Herança, juntamente com o encapsulamento e polimorfismo, é uma das três características primárias (ou pilares) da programação orientada a objeto. A herança permite que você crie novas classes que podem ser reutilizadas e/ou estendidas. Podemos ver exemplos de herança nas classes do próprio .Net Framework, Por exemplo a classe CollectionBase, que contém propriedades e métodos utilizados pela maioria das classes de Collection (coleções). Ela contém propriedades como Capacity e Count e métodos como Clear() e RemoveAt().

Para utilizar a classe base (superclasse) em outra classe (classe derivada ou subclasse) você faz referência à classe base, colocando o símbolo : (dois pontos) após o nome da classe derivada e em seguida coloque o nome da classe base. Quando você define uma classe para derivar de outra classe, a classe derivada implicitamente ganha todos os membros da classe base, exceto seus construtores e destrutores. A herança permite criar novas classes que reutilizam, estendem e modificam o comportamento definido em outras classes podendo assim reutilizar o código na classe base. Isso elimina a duplicação de elementos nas classes reduzindo a necessidade de escrever o mesmo código em duas classes diferentes facilitando a manutenção do código. Observe nas classes abaixo que existem muitas duplicações de propriedades e métodos e existem apenas duas diferenças:

<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/AdultChild.png" alt="Image" width="500px" />
</p>

A herança geralmente é implementada em um modelo denominado “general down to specific” em que se é criado uma classe base, cujos membros são herdados, e classes que herdam esses membros são chamadas de classes derivadas. Uma classe derivada pode ter apenas uma classe base direta. No entanto, a herança é transitiva. Se class C é derivada da class B e class B é derivada da class A, class C herda os membros declarados em class B e class A.

Conceitualmente, uma classe derivada é uma especialização da classe base. Poderíamos criar uma classe Patient que contasse com todas as propriedades e métodos que pertencem a todos os pacientes e as classes Adult e Child teriam as suas propriedades específicas com métodos mais especializados. Em que:
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/Patient.png" alt="Image" width="300px" />
</p>
  
- Uma classe só pode herdar de outra classe
- O Adulto não pode herdar do Patient e de outra classe. 
- Mais de uma classe pode herdar do Patient.
- A herança é transitiva; uma classe herdada do Adult (Over50, Over70) também tem acesso a propriedades e métodos no Patient

```csharp
class Program
{
    static void Main(string[] args)
    {
        Patient p = new Patient();
        p.Examine("Bob");  // use the Patient functionalities

        Child c = new Child();
        c.Examine("Billy");  // Use both Patient and Child functionalities
        c.Innoculate();
    }
}

public class  Patient
{
    public string  FirstName { get; set; }
    public string  LastName { get; set; }
    public string  Gender { get; set; }
    public int Age { get; set; }
    public int Weight { get; set; }
    publiclong SSN {get; set;}

    public void Examine(string pname)
    {
        // Add code for patient examination...
        Console.WriteLine("Exmination of " + pname + " completed...");
    }

    public void Billing(long ssn)
    {
        // Add code to retrive patient billing/balance info
        Console.WriteLine("Billing completed...");
    }
}

public class  Child : Patient  // Use colon to establish inheritance from Patient
{
    public void Innoculate()
    {
        // Add code to record innoculation
        Console.WriteLine("Child has been innoculated...");
    }
}
```
	Se na classe base tivessámos um construtor que aceitasse parâmetros como abaixo:


```csharp
public Patient(string FirstName, string LastName)
{
    // Validate the first and last names. 
    if ((FirstName == null) || (FirstName.Length < 1))
    throw new ArgumentOutOfRangeException( "firstName", FirstName, "FirstName must not be null or blank.");
    if ((LastName == null) || (LastName.Length < 1))
    throw new ArgumentOutOfRangeException( "lastName", LastName, "LastName must not be null or blank.");

    this.FirstName = FirstName;
    this.LastName = LastName;
}
```

Para garantir que o construtor da classe derivada Childaproveite dessas validações, primeiro precisamos atribuir um construtor à classe Child com a mesma assinatura, ou seja, quantidade, tipos e nomes do argumentos iguais. A seguir, após a lista de argumentos, colocamos dois pontos, a palavra-chave base e quaisquer parâmetros que deseja passar para o construtor da classe base, como no exemplo abaixo:

```csharp
public Child(string firstName, string lastName) : base(firstName, lastName)
{
}
```


Quando um construtor usa a palavra-chave base para chamar um construtor da classe base, o construtor da classe base é executado antes que o corpo do construtor da classe filho seja executado.
```csharp
Child pctor = new Child("Daryl", null);
```
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/PublicPatiente.png" alt="Image" width="500px" />
</p>
 
Agora imagine uma situação onde tivéssemos muitos campos dentro de uma classe e precisássemos criar vários construtores que setassem determinados campos, como no exemplo abaixo:
```csharp
public Patient(string FirstName, string LastName, string Gender)
{
    this.FirstName = FirstName;
    this.LastName = LastName;
    this.Gender = Gender;
}

public Patient(string FirstName, string LastName, string Gender, int Age)
{
    this.FirstName = FirstName;
    this.LastName = LastName;
    this.Gender = Gender;
    this.Age = Age;
}
```

Para evitar essa repetição de código dentro dos construtores temos a opção de fazer um construtor chame um segundo construtor através do uso da palavra-chave "this" em vez da palavra-chave base. O código a seguir mostra como o segundo construtor da classe Patientpode invocar seu primeiro construtor:

```csharp
public Patient(string FirstName, string LastName, string Gender)
{
    this.FirstName = FirstName;
    this.LastName = LastName;
    this.Gender = Gender;
}

public Patient(string FirstName, string LastName, string Gender, int Age) : this(FirstName, LastName, Gender)
{
    this.Age = Age;
}
```

Quando um construtor usa a palavra-chave “this” para chamar um segundo construtor na mesma classe, o segundo construtor é executado antes que o corpo do primeiro construtor seja executado.

Agora que entendemos o uso da palavra-chave “this” e “base”, podemos aplicar estas duas funcionalidades em conjunto na classe derivada Child incluindo mais um campo contendo o nome do pai, como se segue:

```csharp
public string  Nome_Pai { get; set; }

public Child(string firstName, string lastName) : base(firstName, lastName)
{
}

public Child(string firstName, string lastName, string nomepai)
    : this(firstName, lastName)
{
    Nome_Pai = nomepai;
}
```

### Princípio da substituição de Liskov

A herança é uma técnica poderosa, mas deve ser usada com cautela. Como já mencionado, a herança deve ser usada apenas quando você está lidando com um relacionamento “é uma espécie de”. O princípio de substituição de Liskov afirma que uma subclasse deve ser utilizável em cada local em que você pode usar uma das classes base. Eles não devem mudar repentinamente o comportamento do qual os usuários dependeriam. É fácil violar esse princípio. Considere o código abaixo.

```csharp
class Rectangle
{
    public virtual int Height { get; set; }
    public virtual int Width { get; set; }

    public int Area
    {
        get { return Height * Width; }
    }
}
```

Ao olhar para essa classe Rectangle, você diria que um Square é uma espécie de Rectangle? Em matemática, isso seria verdade. Sabemos que um quadrado é um tipo especial de retângulo. Você pode modelar isso usando uma relação de herança:

```csharp
class Square : Rectangle
{
    public override int Width
    {
        get { returnbase.Width; }
        set
        {
            base.Width = value;
            base.Height = value;
        }
    }

    public override int Height
    {
        get { returnbase.Height; }
        set
        {
            base.Height = value;
            base.Width = value;
        }
    }
}
```

Como você sabe que está lidando com um quadrado, ajude o usuário da classe modificando as propriedades Width e Height juntas. Dessa forma, o retângulo sempre será um quadrado.Suponha que você queira usar a classe como mostrado:

```csharp
Rectangle rect_squa = new Square();
rect_squa.Width = 10;
rect_squa.Height = 5;
Console.WriteLine("rect_squa Area:" + rect_squa.Area); // rect_squa Area:25
```

Esse código produzirá 25. O usuário acha que está lidando com um Rectangle com uma Areacalculada, mas como o Rectangle está apontando para um Square, apenas o valor mais recente de Height é armazenado. Este é um exemplo típico de violação do princípio de substituição de Liskov. A classe Square não pode ser usada em todos os lugares onde você normalmente usaria um Rectangle.

```csharp
Rectangle rect_rect = new Rectangle();
rect_rect.Width = 10;
rect_rect.Height = 5;
Console.WriteLine("rect_rect Area:" + rect_rect.Area); // rect_rect Area:50

Square squa_squa = new Square();
squa_squa.Width = 10;
squa_squa.Height = 5;
Console.WriteLine("squa_squa Area:" + squa_squa.Area); // squa_squa Area:25
```

### INTERFACES

Uma interface contém definições para um grupo de funcionalidades relacionadas que uma classe ou uma estrutura deve fornecer. A Interfacefornece o mais alto nível de abstração, é como se fosse a versão de software de um contrato, um padrão, que exige que uma classe implemente funcionalidades específicas, mas não diz à classe como fazê-lo, seus membros não têm detalhes de implementação. Quando uma classe implementa uma interface ela:
- Concorda com os termos do contrato
- Ele deve fornecer uma implementação para todos os membros definidos na interface. 
- Informa outras partes do programa que a classe possui esses recursos, para que o código possa invocá-los.
- Classes não podem herdar de mais de uma classe, mas podem implementar mais de uma interface

Todos os detalhes da implementação são definidos por classes que implementam (herdam) interfaces. A interface pode definir métodos, propriedades, eventos, indexadores fornecendo funcionalidade semelhante para nossas classes garantindo consistência entre a chamadas de métodos de classe e polimorfismo.

Isso fornece um tipo de polimorfismo semelhante à maneira como as classes pois, por exemplo, suponha que a classe Child herda da classe Patient e implemente a interface ICloneable. Nesse caso, um programa poderia tratar um objeto Employee como se fosse um objeto Child, Patient ou ICloneable.
Observação:
- Não pode ser instanciada
- Os membros da interface são automaticamente públicos
- Os membros da interface não podem incluir modificadores de acesso

Às vezes, escrever todos os métodos definidos por uma interface pode ser bastante trabalhoso. A menos que a interface esteja bem documentada, pode ser difícil definir quais propriedades, métodos e eventos são necessários. Felizmente, o Visual Studio fornece uma ferramenta que cria código para implementar uma interface para você. Para usar a ferramenta, escreva a declaração da classe e especifique a interface:

```csharp
interface IControls
{
    void Start();
}

interface IControls_2
{
    int Start();
}

```
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/Machine3.png" alt="Image" width="400px" />
</p>

Neste ponto, o Visual Studio sabe que você não implementou a interface. Clique com o botão direito do mouse na declaração da interface para exibir um menu de contexto. 
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/Machine3_intern.png" alt="Image" width="400px" />
</p>

Abra o item Implementar interface e selecione Implementar interface ou Implementar explicitamente para fazer o Visual Studio inserir stubs de código que satisfaçam a interface.O código a seguir mostra o resultado produzido por esta ferramenta se você escolher o item Implementar explicitamente a interface:

```csharp
public class Machine3 : IControls, IControls_2
{
    void IControls.Start()
    {
        throw new NotImplementedException();
    }

    int IControls_2.Start()
    {
        throw new NotImplementedException();
    }
}
```

Se você selecionar Implementar Interface, o código não incluirá as partes IControls e IControls_2, mostradas em destaque no código anterior.Além da diferença de sintaxe, há uma diferença funcional entre as duas maneiras de implementação da interface:

**Implicitamente**: 

Interfaces implícitas são implementadas publicamente. É implementado quando a definição explícita dos membros de cada interface não é necessária.
- Não use especificadores de acesso com os membros da interface.
- Não defina a definição de membros da interface.
- Propriedade Auto, indexador, método e evento podem ser usados como um membro de uma interface.
- A classe deve implementar a definição completa dos membros da interface. Caso contrário, poderá ocorrer um erro no tempo de compilação/execução.
- A classe pode implementar mais de uma interface.


```csharp
interface IVehicle
{
    int Wheels { get; }
}

class Bike : IVehicle
{
    private int wheels;
    public int Wheels
    {
        get
        {
            return wheels;
        }
    }
}
```

**Explicitamente** (Ver também, mais atrás, no último tópico de Encapsulamento)

Interfaces explícitas são implementadas em particular. Nós os implementamos explicitamente quando é necessária uma definição separada do membro de cada interface. Por exemplo, quando uma classe implementa mais de uma interface que compartilha o nome de um membro comum, é necessária uma implementação explícita da interface para separar a definição de cada membro.


```csharp
interface IEnglish
{
    int Marks { get; }
}

interface IMath
{
    int Marks { get; }
}

class Student : IEnglish, IMath
{
    int english = 10;
    int math = 9;
    int IMath.Marks
    {
        get
        {
            return english;
        }
    }

    int IEnglish.Marks
    {
        get
        {
            return math;
        }
    }
}

Student std = new Student();
int english = ((IEnglish)std).Marks;
int math = ((IMath)std).Marks;
// English Marks = 9 Math Marks = 10
Console.WriteLine("English Marks = {0} Math Marks = {1}",english, math);
```

**Explicação**
- IMath.Marks e IEnglish.Marks usado para implementar a interface explicitamente, definindo o nome do nome de gravação da interface antes do nome do membro.
- Nenhum especificador de acesso usado para implementar interfaces explícitas.
- (IEnglish) std) .Marks; usado para acessar a propriedade "Marks" da interface "IEnglish".

### Delegando Interfaces

Tendo duas classes Student e TeachingAssistant que implementam a interface IStudent, portanto, elas incluem código para fornecer os recursos da interface.Você pode evitar duplicar esse código delegando o trabalho de implementar a interface para um objeto Student dentro da classe TeachingAssistant. Sempre que o objeto TeachingAssistant precisar executar alguma tarefa especificada pela interface IStudent, ele faz com que o objeto Student faça o trabalho.

```csharp

public interface IStudent
{
    // The student's list of current courses.
    List<string> Courses { get; set; }

    // Print the student's current grades.
    void PrintGrades();
}

public class Student : IStudent
{
    // Implement IStudent.Courses.
    // The student's list of current courses.
    public List<string> Courses { get; set; }

    // Implement IStudent.PrintGrades.
    // Print the student's current grades.
    public void PrintGrades()
    {
        // Do whatever is necessary...
        Console.WriteLine("Student.PrintGrades");
    }
}

// Delegate IStudent to a Student object.
public class TeachingAssistant2 : IStudent
{
    // A Student object to handle IStudent.
    private Student MyStudent = new Student();

    public List<string> Courses
    {
        get { return MyStudent.Courses; }
        set { MyStudent.Courses = value; }
    }

    public void PrintGrades()
    {
        MyStudent.PrintGrades();
    }
}
```

Isso pode parecer um trabalho extra, mas permite manter todo o código para implementar a interface na classe Student. Agora, se você precisar alterar o código, poderá fazê-lo nesse local.

### IMPLEMENTAR INTERFACES COMUNS

O .NET Framework inclui muitas interfaces que ajudam as classes do Framework a realizar seus trabalhos. Por exemplo, se uma de suas classes implementar a interface IComparable, o método Array.Sort pode classificar uma matriz dessa classe. As seções a seguir explicam como você pode implementar algumas das interfaces mais úteis definidas pelo .NET Framework.

### IComparable

Se uma classe implementa IComparable, ele fornece um método CompareTo que permite que um programa compare duas instâncias da classe e determine qual pertence antes da outra na ordem classificada. Por exemplo, suponha que você queira criar uma classe Persone classificar os objetos Personpor suas idades. Nesse caso, você pode fazer com que a classe Personimplemente a interface IComparable e use Array.Sort para classificar uma matriz de objetos Person.

A interface IComparable vem em duas versões: uma versão simples e uma versão genérica. A versão genérica do IComparable é mais simples que a versão não genérica e fornece forte verificação de tipo, portanto você deve usá-lo. A versão não genérica é fornecida para compatibilidade com versões mais antigas do .NET Framework. 

A forte verificação de tipo fornecida pela versão genérica impede que você cometa o erro de tentar comparar objetos do tipo errado. Se você usar a versão simples, o método CompareTo usa dois objetos não específicos como parâmetros e o código deve convertê-los em objetos Personantes de comparar as idades. O método CompareTo retorna um valor int que mostra como dois elementos estão relacionados. A Tabela abaixo mostra os possíveis valores que o método CompareTo retorna.

| Valor | Significado | 
|:----------|------|
|Menos que zero| A instância atual precede o objeto especificado pelo método CompareTo na ordem de classificação. | 
| Zero  |  Essa instância atual ocorre na mesma posição na ordem de classificação que o objeto especificado pelo método CompareTo. |
| Maior que zero  | Essa instância atual segue o objeto especificado pelo método CompareTo na ordem de classificação. | 

O código a seguir mostra a classe Personcom esse tipo de método CompareTo:

```csharp
class Person : IComparable
{
    public string  Name { get; set; }
    public int Age { get; set; }
    public int CompareTo(object obj)
    {
        if (!(obj is Person))
        throw new ArgumentException("Object is not a Person");

                Person next = (Person)obj;
        return this.Age.CompareTo(next.Age);
    }
}

```

O código a seguir mostra a classe Personimplementando a versão genérica da interface IComparable:

```csharp
class Person_Generic : IComparable<Person_Generic>
{
    public string  Name { get; set; }
    public int Age { get; set; }
    public int CompareTo(Person_Generic other)
    {
        return this.Age.CompareTo(other.Age);
    }
}
```

Nesta versão, o nome da interface é seguido por um parâmetro genérico informando o tipo de objeto com o qual a classe pode se comparar, neste caso Person_Generic. O parâmetro do método CompareTo é um objeto desse tipo, portanto, o CompareTo não precisa verificar se o objeto é um Person_Generice não precisa converter o objeto em um Person_Generic.

```csharp
ArrayList people_array = new ArrayList()
{
    new Person { Name = "Sundus", Age = 21 },
    new Person { Name = "Ali", Age = 22 },
    new Person { Name = "Hogi", Age = 12 },
};

//sort list of persons
people_array.Sort();
foreach (Person person in people_array)
{
    //12 Hogi    21 Sundus    22 Ali
    Console.WriteLine(person.Age + " " + person.Name);
}
```

### IComparer

O programa de exemplo IComparable descrito na seção anterior usou uma classe Person que implementa IComparável, para que ele possa classificar uma variedade de objetos Person por suas idades, mas o método CompareTo pode classificar apenas um campo de cada vez, não sendo possível classificar a classe Person em propriedades diferentes, como o nome, por exemplo.

Uma classe que implementa a interface IComparer deve fornecer um método Compare que compara dois objetos. Por exemplo, você pode criar uma classe sortAge e outra classe SortName que implemente IComparer e que tenha um método Compare que compara objetos Person por idade e nome. Como no exemplo a seguir:

```csharp
class Person
{
    public string  Name { get; set; }
    public int Age { get; set; }
}

class SortAge : IComparer
{
    public int Compare(object x, object y)
    {
        Person first = (Person)x;
        Person second = (Person)y;
        return first.Age.CompareTo(second.Age);
    }
}

class SortName : IComparer
{
    public int Compare(object x, object y)
    {
        Person first = (Person)x;
        Person second = (Person)y;
        return first.Name.CompareTo(second.Name);
    }
}

ArrayList people = new ArrayList();
people.Add(new Person { Name = "Sundus", Age = 21 });
people.Add(new Person { Name = "Ali", Age = 22 });
people.Add(new Person { Name = "Hogi", Age = 12 });
//sort list according to age
people.Sort(new sortAge());
foreach (Person person in people)
{
    // 12 Hogi    21 Sundus       22 Ali
    Console.WriteLine(person.Age + " " + person.Name);
}
Console.WriteLine();
//sort list according to name
people.Sort(new SortName());
foreach (Person person in people)
{
    // Ali 22     Hogi 12         Sundus 21
    Console.WriteLine(person.Name + " " + person.Age);
}
```

Porém esta implementação tem muitas limitações. Aparentemente só funciona com ArrayList, pois ao tentar com Array não aceita parâmetro IComparer (só há sobrecarga com Array) e ao tentar com List<Person> há erro em relação a que nosso IComparer não é genérico. Como vimos na implementação da interface IComparable. A versão IComparer genérica também é mais simples e fornece forte verificação de tipo, portanto devemos usá-la. Então nossa classes IComparer ficariam assim:

```csharp

class SortAge_Generic : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        return x.Age.CompareTo(y.Age);
    }
}

class SortName_Generic : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        return x.Name.CompareTo(y.Name);
    }
}
```

Isso já resolve parcialmente o problema de classificação por nome e idade mas, e se tivesse muitas outras propriedades da classe Person que gostariamos de classificar, teríamos de criar várias classes de comparadores uma para cada classificação. Uma opção seria criar uma única classe PersonComparer e dar a ela um campo que o programa possa definir para informar qual campo de carro usar ao comparar objetos de carro. O código a seguir mostra uma classe PersonComparer que demonstra essa abordagem:

```csharp

class PersonComparer : IComparer<Person>
{
    // The field to compare. 
    public enum CompareField { Name, Age }
    public CompareField SortBy = CompareField.Name;
    public int Compare(Person x, Person y)
    {
        switch (SortBy)
        {
            case CompareField.Name: return x.Name.CompareTo(y.Name);
            case CompareField.Age: return x.Age.CompareTo(y.Age);
        }
        return x.Name.CompareTo(y.Name);
    }
}
```

A classe começa com uma enumeração que define os tipos de classificação que essa classe pode fornecer. Seu campo SortBy indica o campo Personque a classe deve usar ao classificar. O método Compare examina o valor SortBy e compara dois objetos Personadequadamente. O programa de exemplo abaixo, usa essa classe PersonComparer para classificar os objetos Personpor Nome eIdade e poderia ser por muitas outras propriedades:

```csharp
var arr_per = new Person[]
{
    new Person { Name = "Sundus", Age = 21 },
    new Person { Name = "Ali", Age = 22 },
    new Person { Name = "Hogi", Age = 12 }
};

var sortPerson = "Age";
PersonComparer per_comparer = new PersonComparer();

if (sortPerson == "Name")
    per_comparer.SortBy = PersonComparer.CompareField.Name;
elseif (sortPerson == "Age")
    per_comparer.SortBy = PersonComparer.CompareField.Age;

Array.Sort(arr_per, new sortAge_Generic());
Array.Sort(arr_per, new SortName_Generic());
Array.Sort(arr_per, per_comparer);
```

Esse método cria um objeto PersonComparer e define seu valor SortBy de acordo com o valor selecionado por algum controle do programa (aqui definido com uma constante sortPerson). Em seguida, você pode passar um objeto PersonComparer para o método Array.Sort e ele pode usar esse objeto para classificar uma matriz de objetos Person. Caso você estivesse trabalhando com uma lista de Person bastaria convertê-la usando o método ToArray, como abaixo:

```csharp
List<Person> people_list = new List<Person>() {
new Person { Name = "Sundus", Age = 21 },
new Person { Name = "Ali", Age = 22 },
new Person { Name = "Hogi", Age = 12 }
};

Array.Sort(people_list.ToArray(), per_comparer);
```

### IEquatable

IEquatable <T> é uma interface implementada por tipos cujos valores podem ser equacionados (por exemplo, as classes numéricas e de string). A interface IEquatable fornece esse recurso exigindo que uma classe forneça um método Equals. O código a seguir mostra a classe Person:

```csharp

class Person_Equals : IEquatable<Person_Equals>
{
    public string  FirstName { get; set; }
    public string  LastName { get; set; }

    public bool Equals(Person_Equals other)
    {
        return ((FirstName == other.FirstName) && (LastName == other.LastName));
    }
}
```

Para a maioria dos tipos de referência, o uso do IEquatable é evitado porque, se você o fizer, precisará substituir os métodos Object.Equals(Object) e GetHashCode, pois seu comportamento é consistente com o método IEquatable.Equals. Implementando todas validações na classe Person ficaria assim:

```csharp

class Person : IEquatable<Person>
{
    public string  FirstName { get; set; }
    public string  LastName { get; set; }
    public int Age { get; set; }

    public bool Equals(Person other)
    {
        if ((FirstName == other.FirstName) && (LastName == other.LastName))
        return true;
        else return false;
    }

    public override bool Equals(object obj)
    {
        Person other = (Person)obj;
        return this.Equals(other);
    }

    public override int GetHashCode()
    {
        //custom implementation of hashcode
        string hash = this.FirstName + this.LastName;
        return hash.GetHashCode();
    }

    public static bool operator ==(Person person1, Person person2)
    {
        if (((object)person1) == null || ((object)person2) == null)
        return Object.Equals(person1, person2);
        return person1.Equals(person2);
    }

    public static bool operator !=(Person person1, Person person2)
    {
        if (((object)person1) == null || ((object)person2) == null)
        return !Object.Equals(person1, person2);
        return !(person1.Equals(person2));
    }
}
```


Classes de coleção genérica, como Lista, Dicionário, Pilha e Fila, fornece Contains e outros métodos que comparam objetos para igualdade. A Microsoft recomenda que seja implementado o IEquatable em qualquer classe que esteja em qualquer dessas coleções genéricas.

Isso permite criar uma lista de objetos Person que usa o método Contains da lista para verificar se a pessoa já está na lista. Se você tentar criar uma Pessoa com o mesmo nome e sobrenome que uma Pessoa criada anteriormente, o programa exibirá uma mensagem de erro. 

```csharp
Person person1 = new Person() { Age = 21, FirstName = "Ali", LastName = "Dali" };
Person person2 = new Person() { Age = 45, FirstName = "Ali", LastName = "Dali" };
Console.WriteLine(person1 == person2); // True

List<Person> People = new List<Person>();
People.Add(person1);

if (People.Contains(person2)) // True
    Console.WriteLine("The list already contains this person.");
else People.Add(person2);
```

O método Contains da lista usa o fato de que a classe Person implementa IEquatable para decidir se dois objetos são iguais. Se você comentar a parte: IEquatable da declaração da classe Person, a classe não implementa mais o IEquatable; portanto, a lista trata dois objetos diferentes como diferentes, mesmo que eles tenham os mesmos valores de primeiro e último nome. 

### ICloneable

Uma classe que implementa a interface ICloneable deve fornecer um método Clone que retorna uma cópia do objeto para o qual é chamado. Por exemplo, o código a seguir mostra uma classe Person simples e clonável:

```csharp
class Person : ICloneable
{
    public string  FirstName { get; set; }
    public string  LastName { get; set; }
    public Person Manager { get; set; }

    // Return a clone of this person. 
    public object Clone()
    {
        Person person = new Person();
        person.FirstName = FirstName;
        person.LastName = LastName;
        person.Manager = Manager;
        return person;
    }
}
```

O método Clone desta classe simplesmente cria um novo objeto Person com as mesmas propriedades FirstName, LastName e Manager que o original e, em seguida, retorna o novo objeto. Observe que o método Clone retorna um objeto não específico, não uma Person; portanto, o código de chamada deve converter o resultado em uma Person. O código a seguir mostra como o programa de exemplo ICloneablePerson, disponível para download no site do livro, cria dois objetos Person. e depois clona um deles:

```csharp
Person ann = new Person() { FirstName = "Ann", LastName = "Archer", Manager = null };
Person bob = new Person() { FirstName = "Bob", LastName = "Baker", Manager = ann };
Person bob2 = (Person)bob.Clone();
```


Esse código cria uma pessoa chamada Ann Archer e outra chamada Bob Baker. Em seguida, clona a pessoa de Bob Baker para criar um terceiro objeto de pessoa.A classe de método Person.Clone descrita nesta seção é um clone superficial porque define a propriedade Manager do clone igual à propriedade Manager do objeto original.Existem dois tipos de clones: 
- **Superficial**: qualquer valor de referência na cópia se refere aos mesmos objetos que os do objeto original
- **Profundo**: os valores de referência do novo objeto são definidos para novos objetos. 

A interface ICloneable não especifica se o método Clone deve retornar um clone superficial ou profundo; portanto, você deve fazer o que fizer mais sentido para o seu aplicativo. Se desejar, também é possível criar um segundo método Clone que assume como parâmetro um valor booleano que indica se a cópia deve ser um clone profundo.O código a seguir mostra como a classe Person poderia fornecer clones profundos:

```csharp
public object DeepClone()
{
    Person person = new Person();
    person.FirstName = FirstName;
    person.LastName = LastName;
    person.Manager = Manager;
    if (Manager != null)
        person.Manager = (Person)Manager.Clone();
    return person;
}
```

### IUnknown

Antes da existência do .NET, a primeira geração da API do Windows era baseada em uma biblioteca de funções contidas em uma biblioteca de vínculo dinâmico(DLL). Gerações posteriores coletaram essas funções em uma interface Component Object Model(COM). O .NET Framework fornece classes que agrupa muitas dessas APIs em uma versão gerenciada para que você quase nunca toque diretamente em nenhum componente COM.

Normalmente, você apenas adiciona uma referência a um objeto COM e o compilador gera as classes de wrapper necessárias chamadas classes de interoperabilidade COM. Se isso falhar por algum motivo, você precisará criar a classe wrapper; é aqui que a interface IUnknown é usada.

IUnknown é a interface base de todas as outras interfaces COM. Essa interface define três métodos: QueryInterface, AddRefe Release. QueryInterface permite que um usuário de interface solicite ao objeto um ponteiro para outra de suas interfaces. O AddRef e o Release implementam a contagem de referência na interface.

### IDisposable (Mais informações em “Gerenciar o ciclo de vida do objeto” mais adiante neste documento)

Outra interface útil no .NET Framework é IDisposable. Como o C# é uma linguagem gerenciada que usa um Garbage Collector para limpar a memória, essa interface é usada somente para facilitar o trabalho com recursos externos não gerenciados, como conexões com o banco de dados ou identificadores de arquivo. O único método que a interface IDisposable possui é Dispose(), conforme mostra a definição da interface IDisposable.

```csharp
interface pública IDisposable
{
    Dispose ();
}
```
