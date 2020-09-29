

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

 - [Aplicar encapsulamento](#aplicar-encapsulamento)
    - [PROTEÇÃO DE DADOS](#proteção-de-dados)
    - [Propriedades e Campos](#propriedades-e-campos)
    - [Indexadores](#indexadores)
    - [ESPECIFICADORES/MODIFICADORES](#especificadoresmodificadores)
    - [Modificador de acesso](#modificador-de-acesso)
    - [Private](#private)
    - [Protected](#protected)
    - [Internal](#internal)
    - [Protected internal](#protected-internal)
  - [MÉTODOS](#métodos)
    - [Tipo de retorno](#tipo-de-retorno)
    - [Parâmetros](#parâmetros)
    - [Assinatura](#assinatura)
    - [Static](#static)
  - [CONSTRUTORES](#construtores)
  - [POLIMORFISMO](#polimorfismo)
  - [POLIMORFISMO ESTÁTICO - Overloading/Sobrecarga](#polimorfismo-estático---overloadingsobrecarga)
    - [Overloading (Sobrecarga)](#overloading-sobrecarga)
    - [Sobrecarga do operador](#sobrecarga-do-operador)
  - [POLIMORFISMO DINÂMICO - Overriding/Sobrescrita](#polimorfismo-dinâmico---overridingsobrescrita)
    - [Método Abstrato](#método-abstrato)
    - [Método Virtual](#método-virtual)
    - [Ocultando membros de classe base com novos membros](#ocultando-membros-de-classe-base-com-novos-membros)
    - [Impedindo que classes derivadas substituam membros virtuais](#impedindo-que-classes-derivadas-substituam-membros-virtuais)
    - [Acessando membros virtuais da classe base das classes derivadas](#acessando-membros-virtuais-da-classe-base-das-classes-derivadas)
    - [Métodos de Extensão (Extension Methods)](#métodos-de-extensão-extension-methods)
    - [Interface Explicitamente(Ver também, mais a frente, Implementando Interfaces)](#interface-explicitamentever-também-mais-a-frente-implementando-interfaces)
    
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

```csharp
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
```csharp
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

```csharp
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
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/publicclass.png" alt="Image" width="400px" />
</p>


Membros definidos com especificadores de acesso public podem ser acessados dentro e fora da classe. Os dados públicos também podem ser acessíveis de fora do projeto.

```csharp
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


```csharp
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

```csharp
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

```csharp
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

```csharp
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
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/Tpretorno.png" alt="Image" width="400px" />
</p>

### Parâmetros
- Especifica o nome e o tipo de dados dos valores que devem ser fornecidos quando o método é chamado. Por padrão, todos os parâmetros listados são necessários ao chamar o método
- Os valores passados para os parâmetros do método são chamados de argumentos. Assim, as palavras 'parâmetros' e 'argumentos' são frequentemente usadas de forma intercambiável
- Os argumentos devem ser compatíveis com o tipo de dados do parâmetro
- Os parâmetros de um método são geralmente utilizados posicionalmente
  Parametros
- Parâmetros opcionais são definidos no final da lista de parâmetros, após todos os parâmetros necessários. Se nenhum argumento for enviado para esse parâmetro, o valor padrão será usado.
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/Parametros_op.png" alt="Image" width="400px" />
</p>

### Assinatura
- Refere-se à estrutura do método
- Para sobrecarga(overloading), a assinatura inclui o nome do método e os tipos de parâmetro
- Para delegados(delegates), a assinatura inclui o tipo de retorno e os tipos de parâmetro
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/Assinatura.png" alt="Image" width="400px" />
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

## TIPOS POLIMORFISMO

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

```csharp
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

```csharp

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

```csharp
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

```csharp
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

```csharp
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

```csharp
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

```csharp
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
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/Workfield.png" alt="Image" width="500px" />
</p>
 
Quando uma classe derivada substitui um membro virtual, esse membro é chamado, mesmo quando uma instância dessa classe está sendo acessada como uma instância da classe base. O código a seguir mostra um exemplo:

```csharp
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


```csharp
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

public class NewDerivedClass : BaseClass
{
    public new int WorkField;
    public new void DoWork()
    {
        WorkField++;
        Console.WriteLine("NewDerivedClass valor override WorkProperty(3) é: " + WorkProperty);
        Console.WriteLine("NewDerivedClass valor int new WorkField++ é: " + WorkField);
    }

    public new int WorkProperty
    {
        get { return 3; }
    }
}

NewDerivedClass ndc_first = new NewDerivedClass();
ndc_first.DoWork();
// Calls the new method NewDerivedClass.
//NewDerivedClass valor override WorkProperty(3) é: 3
//NewDerivedClass valor int new WorkField++ é: 1

BaseClass ndc_sec = new NewDerivedClass();
ndc_sec.DoWork();
//BaseClass valor virtual int WorkProperty(1) = 1
//BaseClass valor int WorkField++ é: 1

Você ainda pode acessar os membros da classe base ocultos a partir do código do cliente, convertendo a instância da classe derivada a uma instância da classe base. Por exemplo:

BaseClass ndc_third = (BaseClass)ndc_first;
ndc_third.DoWork();
//Calls the old method BaseClass.
//BaseClass valor virtual int WorkProperty(1) = 1
//BaseClass valor int WorkField++ é: 1

NewDerivedClass ndc_four = (NewDerivedClass)ndc_third;
ndc_four.DoWork();
//NewDerivedClass valor override WorkProperty(3) é: 3
//NewDerivedClass valor int new WorkField++ é: 2
```

### Impedindo que classes derivadas substituam membros virtuais

Os membros virtuais permanecem virtuais por tempo indeterminado, independentemente de quantas classes foram declaradas entre o membro virtual e a classe que originalmente o declarou. Se a classe BaseClass declara um membro virtual, a classe DerivedClass deriva de BaseClass e a classe ThirdClass eFourthclass Deriva de DerivedClass, a classe ThirdClass/FourthClass herda o membro virtual e tem a opção de substituí-lo, independentemente de a classe DerivedClass ter declarado uma substituição para esse membro. O código a seguir mostra um exemplo, de como a herança multi-níveis pode ficar confusa e com resultados imprevisíveis se nãp possuírem um controle de heranças:


```csharp
BaseClass multi_bc = new BaseClass();
multi_bc.DoWork();
// Calls the new method BaseClass.
//BaseClass valor virtual int WorkProperty(1) = 1
//BaseClass valor int WorkField++ é: 1

BaseClass multi_dc = new DerivedClass();
multi_dc.DoWork();
// Calls the new method DerivedClass.
//DerivedClass valor override WorkProperty(2) é: 2
//DerivedClass valor int (BaseClass) WorkField++ é: 1

BaseClass multi_th = new ThirdClass();
multi_th.DoWork();
//ThirdClass valor override WorkProperty(3) é: 3
//ThirdClass valor int (BaseClass) WorkField++ é: 1      

BaseClass multi_de_th = (DerivedClass)multi_th;
multi_de_th.DoWork();
//ThirdClass valor override WorkProperty(3) é: 3
//ThirdClass valor int (BaseClass)WorkField++ é: 2

//FourthClass NÃO implementa o método DoWork
//Então utiliza o método virtual da classe herdada DerivedClass
BaseClass multi_bc_fo = new FourthClass();
multi_bc_fo.DoWork(); 
//DerivedClass valor override WorkProperty(2) é: 4
//DerivedClass valor int (BaseClass) WorkField++ é: 1
```


O modificador sealed (também conhecido como selado) define que uma classe não pode ser uma classe base, ou seja, não pode ter herdeiras. Uma classe sealed está pronta para uso e deve ser empregada no programa. Devido especialmente às suas características, as classes sealed podem ser consideradas o oposto das classes abstratas.
 
Além das explicações mencionadas referentes às classes sealed, devemos considerar alguns outros, conforme podemos ver abaixo:
- Os membros sealed não podem ser sobrescritos, mas devem sobrescrever um membro virtual ou virtual deduzido (por exemplo, um membro abstrato);
- O modificador sealed deve ser combinado com a palavra-chave override. Apesar de não poder ser aplicado a membros estáticos, ele pode ser aplicado a propriedades, métodos, indexadores e eventos;

Uma classe derivada pode interromper a herança virtual, declarando uma substituição como sealed. Isso exige a colocação da palavra-chave sealed antes da palavra-chave override na declaração de membro de classe. O código a seguir mostra um exemplo:


```csharp
public class SealedThirdClass : DerivedClass
{
    public sealed override void DoWork()
    {
        WorkField++;
        Console.WriteLine("SealedThirdClass valor override WorkProperty(3) é: " + WorkProperty);
        Console.WriteLine("SealedThirdClass valor int (BaseClass)WorkField++ é: " + WorkField);
    }

    public override int WorkProperty
    {
        get
        {
            return 3;
        }
    }
}
```

No exemplo anterior, o método DoWork não será mais virtual para qualquer classe derivada de SealedThirdClass. Ele ainda será virtual para instâncias de SealedThirdClass, mesmo se elas forem convertidas em métodos tipo DerivedClass ou tipo BaseClass. 
 
 <p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/DoWork.png" alt="Image" width="100%" />
</p>
 

Se invés do método o selead estiver na classe como abaixo, não será possível nem herdar da classe.


```csharp
public sealed class SealedThirdClass : DerivedClass
```
<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/DerivaSeal.png" alt="Image" width="100%" />
</p>


Métodos lacrados podem ser substituídos por classes derivadas usando a palavra-chave new, como mostra o exemplo a seguir:

```csharp
public class DerivaSeal_FourthClass : SealedThirdClass
{
    public new void DoWork()
    {
        WorkField++;
        Console.WriteLine("FourthClass valor override WorkProperty(34) é: " + WorkProperty);
        Console.WriteLine("FourthClass valor int (BaseClass)WorkField++ é: " + WorkField);
    }
}
```


Neste caso, se DoWork é chamado em DerivaSeal_FourthClass usando uma variável do tipo DerivaSeal_FourthClass, o novo DoWork é chamado. Se uma variável do tipo SealedThirdClass, DerivedClass ou BaseClass é usada para acessar uma instância de DerivaSeal_FourthClass, uma chamada de DoWork seguirá as regras de herança virtual, encaminhando as chamadas para a implementação de DoWork na classe SealedThirdClass.

### Acessando membros virtuais da classe base das classes derivadas

A classe derivada que substituiu um método ou propriedade ainda pode acessar o método ou propriedade na classe base usando a palavra-chave base. O código a seguir mostra um exemplo:

```csharp
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
        //Metodo alternativa de chamada direta da classe base
        base.DoWork();
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
//BaseClass valor virtual int WorkProperty(1) = 1
//BaseClass valor int WorkField++ é: 1

BaseClass dc = new DerivedClass();
dc.DoWork();
//BaseClass valor virtual int WorkProperty(1) = 2
//BaseClass valor int WorkField++ é: 1

```

### Métodos de Extensão (Extension Methods)

No .NET 4.0, foi adicionado um novo recurso chamado métodos de extensão. Os métodos de extensão precisam ser declarados em uma classe estática não genérica, não aninhada e permite adicionar novos recursos para um tipo existente. Métodos de extensão são métodos estáticos especiais, pois injetam métodos de adição:
- Sem criar um novo tipo derivado
- Sem recompilar
- Sem modificar o tipo de original
- Eles são sempre chamados como se fossem um método de instância.
- Os métodos de extensão são sempre definidos dentro da classe estática. 
- O primeiro parâmetro do método de extensão deve ter o operador "this", que informa em qual instância esse método de extensão deve fornecer acesso.
- O método de extensão deve ser definido no mesmo namespace em que é usado ou importar o namespace no qual o método de extensão foi definido

Lembre-se de que a diferença entre um método estático regular e um método de extensão é a palavra-chave especial this para o primeiro argumento. Abaixo um exemplo de método estático regular:

```csharp
static class Helper
{
    public static int age;

    static Helper()
    {
        age = 22;
    }

    public static bool isLessThan_Extension(int compareValue)
    {
        //return true if origin value is less
        if (age < compareValue)
            return true;
        else
            return false;
    }
}

Console.WriteLine(Helper.isLessThan_Extension(16)); //True
```

Agora, um método de extensão em classe não estática utilizando o parâmetro this:

```csharp
public class  Product
{
    public decimal Price { get; set; }
}

public static  class MyExtensions
{
    public static decimal Discount(this Product product)
    {
        return product.Price * .9M;
    }
}

public class  Calculator
{
    public decimal CalculateDiscount(Product p)
    {
        return p.Discount();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var oprod = new Product();
        var ocalc = new Calculator();

        oprod.Price = 1.99m;
        var desconto = ocalc.CalculateDiscount(oprod);
        Console.WriteLine(desconto); // 1,791

        Console.ReadKey();
    }
}
```

O método de extensão não pode ser declarado apenas em uma classe ou estrutura.Também pode ser declarado em uma interface (como IEnumerable <T>). Normalmente, uma interface não teria nenhuma implementação. Com os métodos de extensão, no entanto, você pode adicionar métodos que estará disponível em todas as implementações concretas da interface.

A Consulta Integrada à Linguagem (LINQ) é um dos melhores exemplos de como você pode usar estetécnica para aprimorar o código existente. Em vez de precisar adicionar todos os operadores LINQ a cada e todas as classes, eles são criados como métodos de extensão nas interfaces básicas de cada coleção tipo. Dessa forma, todas as coleções podem usar repentinamente o LINQ.

### Interface Explicitamente(Ver também, mais a frente, Implementando Interfaces)

As interfaces são úteis ao usar o encapsulamento. Mais abaixo, na implementação de hierarquia de classe, há um explicação mais detalhada de como projetar e usar interfaces. Mas com relação ao tópico do encapsulamento, é necessário entender sobre a implementação explícita da interface.

Como exemplo de implementação explícita da interface, consulte o Entity Framework (um mapeador de objeto-relacional que faz parte do .NET Framework). Ao trabalhar com o Entity Framework, você trabalha com uma classe DbContext, que é um invólucro do ObjectContext e expõe uma interface mais fácil de usar. O DbContext implementa a seguinte interface:

```csharp
public interface IObjectContextAdapter
{
    objectContext ObjectContext { get; }
}
```

Embora a interface mostre uma propriedade ObjectContext, o código a seguir não será compilado:

```csharp
DbContext ctx = …; // create a new context
var context = ctx.ObjectContext;
```

O seguinte será compilado:

```csharp
var adaptedContext = ((IObjectContextAdapter)ctx).ObjectContext;
```

É possível porque o DbContext implementa a interface IobjectContextAdapterexplicitamente. A implementação explícita da interface significa que um elemento do tipo de interface pode ser acessado apenas ao usar a interface diretamente. Você pode criar uma implementação explícita da interface adicionando o nome da interface e um ponto à implementação.

```csharp
interface IInterfaceA
{
    void MyMethod();
}

class Implementation : IInterfaceA
{
    void IInterfaceA.MyMethod() { }
}
```

A classe Implementation implementa a interface IInterfaceA explicitamente. Quando você tem uma instância de Implementação, não pode acessar o MyMethod. Mas quando você lança Implementation para IInterfaceA, você tem acesso ao MyMethod. Dessa forma, a implementação explícita da interface pode ser usada para ocultar membros de uma classe para usuários externos.

Há outra situação em que a implementação explícita da interface é necessária: quando uma classe implementa duas interfaces que contêm assinaturas de método duplicadas, mas deseja uma implementação diferente para ambas. Ao implementar implicitamente essas duas interfaces, apenas um método existe na implementação. Com a implementação explícita da interface, ambas as interfaces têm sua própria implementação. O código abaixo mostra como implementar uma interface explicitamente.

```csharp
class Program
{
    static void Main(string[] args)
    {
        Machine1 m1 = new Machine1();
        Machine3 m3 = new Machine3();

        m1.Start();

        m3.Start();
        ((IControls_2)m3).Start();

        Console.ReadKey();
    }
}

public class Machine1 : IControls
{
    public void Start()
    {
        Console.WriteLine("Machine1...Start");
    }
}

public class Machine3 : IControls, IControls_2
{
    public void Start()
    {
        Console.WriteLine("Implementation of IControls.Start()...");
    }

    int IControls_2.Start()
    {
        Console.WriteLine("Implementation of IControls_2.Start...");
        return 6;
    }
}

interface IControls
{
    void Start();
}

interface IControls_2
{
    int Start();
}
```

**Sumário**
- O encapsulamento é importante no software orientado a objetos. Oculta detalhes internos e melhora a usabilidade de um tipo.
- Os dados podem ser encapsulados com propriedades e indexadores
- As propriedades podem ter um acessador get e um set que podem executar código adicional, comumente conhecido como getters e setters.
- Tipos e elementos de tipo podem ter modificadores de acesso para restringir a acessibilidade.
- Os modificadores de acesso são públicos, internos, protegidos, protegidos internos e privados.
- A classe derivada pode herdar todos os dados de sua classe base, exceto uma que é mencionada com o especificador de acesso privado.
- O C# não permite herança múltipla, mas permite herança em vários níveis.
- Uma classe deve implementar todos os membros de uma interface e todos os métodos abstratos de uma classe abstrata.
- O método abstrato só pode ser escrito dentro de uma classe abstrata.
