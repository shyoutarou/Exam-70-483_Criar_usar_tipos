
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

## Gerenciar o ciclo de vida do objeto 
- **Gerenciar recursos não gerenciados; implementar IDisposable, incluindo interação com finalização; gerenciar IDisposable usando a instrução Using; gerenciar finalização e coleta de lixo**

- [Perdas de memória (Memory Leaks)](#perdas-de-memória-memory-leaks)
- [GARBAGE COLLECTOR](#garbage-collector)
- [Benefícios do Garbage Collector](#benefícios-do-garbage-collector)
- [O heap gerenciado](#o-heap-gerenciado)
- [Gerações](#gerações)
- [O ciclo de trabalho do Garbage Collector na heap](#o-ciclo-de-trabalho-do-garbage-collector-na-heap)
- [Sobreviventes e promoções](#sobreviventes-e-promoções)
- [Gerações e segmentos efêmeros](#gerações-e-segmentos-efêmeros)
- [Gerenciando recursos não gerenciados](#gerenciando-recursos-não-gerenciados)
- [Finalize ~](#finalize-)
- [Disposal](#disposal)
- [Try-finally](#try-finally)
- [Using](#using)
- [Implementando IDisposable e um finalizador](#implementando-idisposable-e-um-finalizador)
- [WeakReference - Referências fracas](#weakreference---referências-fracas)

O ciclo de vida de um objeto é simplesmente o tempo entre quando um objeto é criado na memória e quando é destruído a partir dele. Fundamentalmente, o ciclo de vida de um objeto envolve as duas etapas a seguir:
1.	**Criação de um objeto**: Usamos a palavra-chave new para instanciar um novo objeto.
Person person = new Person();
Um bloco de memória está alocado. Esse bloco de memória é grande o suficiente para armazenar o objeto (o CLR lida com a alocação de memória para objetos gerenciados). O bloco de memória é convertido em um objeto inicializado na memória (podemos controlar esta etapa implementando um construtor).
2.	**Exclusão de um objeto**: Usamos a destruição para recuperar quaisquer recursos usados por esse objeto. O objeto é limpo, por exemplo, liberando quaisquer recursos não gerenciados usados pelo aplicativo, como identificadores de arquivo e conexões com o banco de dados (podemos controlar esta etapa implementando um destruidor). C# fornece duas maneiras de lidar com o gerenciamento de memória
    - **Garbage Collection (Coleta de lixo)**: o CLR libera a memória usada pelos objetos gerenciados
    - **Disposal**: é necessário liberar manualmente a memória implementando IDisposable para objetos não gerenciados.

### Perdas de memória (Memory Leaks)

Se um aplicativo não liberar o recurso alocado na memória após a conclusão do uso, ele criará um vazamento de memória porque a mesma memória alocada não está mais sendo usada pelo aplicativo. Se vazamentos de memória não forem gerenciados corretamente, o sistema acabará ficando sem memória; consequentemente, o sistema começa a ficar lento e o usuário não consegue fechar o aplicativo, sendo necessário é reiniciar o computador. A seguir, algumas causas comuns de vazamento de memória:
1.	**Mantendo referências a objetos gerenciados por um longo tempo**: Se as referências de um objeto gerenciado permanecerem mais longas do que o necessário, os contadores de desempenho poderão mostrar um aumento constante no consumo de memória e poderá ocorrer uma OutOfMemoryException. Isso pode ocorrer devido a um escopo global variável, porque o GC não pode destruir uma variável ativa, mesmo que ela não esteja mais sendo usada por um aplicativo. O desenvolvedor precisa lidar com isso informando quanto tempo uma variável pode manter uma referência e destruí-la depois que ela não é mais necessária.
1.	**Não foi possível gerenciar o recurso não gerenciado**: O coletor de lixo não pode liberar a memória do recurso não gerenciado. O desenvolvedor precisa liberar explicitamente recursos de recursos não gerenciados. Para fazer isso, o desenvolvedor precisa implementar uma interface IDisposable em tipos que usam recursos não gerenciados.
2.	**Referência estática**: Se um objeto for referenciado por um campo estático, ele nunca será liberado. Tais objetos se tornam duradouros. O desenvolvedor precisa garantir que objetos de campo estático desnecessários sejam destruídos quando terminarem de ser usado pelo aplicativo
3.	**Evento com a falta de inscrição**: Se um manipulador de eventos estiver inscrito (+=), o publicador do evento manterá uma referência ao assinante por meio do delegado do manipulador de eventos (assumindo que o delegado seja um método de instância). Se o editor viver mais que o assinante, ele manterá o assinante ativo, mesmo quando não houver outras referências ao assinante. Essa é a causa do vazamento de memória quando a desinscrição de um evento não está definida. O desenvolvedor precisa sempre cancelar a inscrição (-=) do evento com um manipulador igual.

### GARBAGE COLLECTOR

Quando programamos em C ou C++, muitos objetos requerem que façamos a alocação de seus recursos em sua declaração, antes dos objetos poderem ser utilizados com segurança. Liberar estes recursos de volta ao pool de memória livre também é responsabilidade do programador. Se os recursos não forem liberados, dizemos que o código está com vazamento de memória e mais recursos serão consumidos sem necessidade. Por outro lado, se os recursos forem liberados prematuramente, perda de dados, áreas de memória corrompidas e erros de ponteiros nulos podem ocorrer.

O **Garbage Collector** é um processo que automático que cuida do gerenciamento de memória liberando memória de objetos que não mais estão em uso. Características:
- Objetos que não são mais referenciados no programa serão destruídos. Porém não significa que o GC acontece imediatamente quando um objeto fica órfão
- Ele não especifica quando o objeto será destruído. O GC ocorre periodicamente com base na memória disponível, na alocação de memória atual e no tempo desde a última coleta O atraso entre as coleções pode variar de segundos a dias.
- Apenas os objetos não utilizados são destruídos: um objeto nunca é destruído se ele mantém a referência de um outro objeto.
- Nem todos os objetos órfãos são recuperados a cada coleção
- Existem alguns casos em que é necessário ajudar o GC
    - Você pode forçar a coleta de lixo chamando GC.Collect();

Você não pode destruir um objeto explicitamente no código, ou seja, você não pode determinar quando o método destruidor será chamado. Também, quando um objeto perde o escopo no final do método Main(), o processo de destruição não é necessariamente invocado. A decisão de recorrer ao processo de destruição é feita exclusivamente pelo Garbage Collector. 

O Garbage Collector foi implementado em uma thread em separado, sempre rodando no back end. Como uma thread separada ocasiona um overhead extra, a thread do Garbage Collector tem a prioridade mais baixa. Mas quando o Sistema não encontra mais espaço no heap gerenciado, a thread do Garbage Collector recebe prioridade REALTIME (é a mais alta prioridade no Windows) e sai recolhendo todos os objetos que não são mais utilizados.

### Benefícios do Garbage Collector
- Permite que os desenvolvedores escrevam aplicativos sem se preocupar em liberar memória manualmente.
- Aloca memória em um heap gerenciado. Essa alocação de objetos é feito com o máximo de eficiência.
- Recolhe objetos que não estão sendo utilizados e limpa a memória.
- Ativa a segurança da memória, mantendo os objetos em memória em seu devido lugar, impedindo que um objeto utilize conteúdo de outro objeto.

### O heap gerenciado

Há dois lugares na memória onde o CLR (Commom Language Runtime) armazena itens enquanto o código é executado. Um é a stack; o outro é o heap. Em uma simplificação exagerada, ostack controla o que está executando no seu código e o heap controla os objetosgrandes com um ponteiro na stack apontado para ele. Mas, basicamente, essa é a distinção entre os dois tipos de memória. A stack é limpa automaticamente pelo CLR no final de um método, já o heap é gerenciada pelo Garbage Collector. Depois que o Garbage Collector é inicializado pelo CLR, elechama um método VirtualAlloc do Win32 que aloca um segmento contígua deespaço de endereçode memória para armazenar objetos ou processos. Esta memória é chamada de heap gerenciado. 
- Existe um heap gerenciado para cada processo gerenciado. 
- Todas as threads de um processo alocam memória no mesmo heap.

Enquanto os espaços de endereços estão disponíveis no heap gerenciado, o runtime continua a alocar espaço para novos objetos.  O heap é dividido em dois: uma parte com objetos grandes (a partir de 85Kbytes, normalmente arrays) e outro com os menores. Quanto menos objetos alocados no heap, menos trabalho o Garbage Collector terá. Por isso, quando você alocar objetos, tente alocar apenas a quantidade de memória necessária.Por exemplo, não aloque uma matriz de 10 bytes quando você precisou apenas de uma matriz de 5 bytes.

No entanto, a memória não é infinita. Eventualmente, o Garbage Collector deve executar uma coleta, a fim de liberar memória. O motor de otimização do Garbage Collector determina o melhor momento para realizar a coleta, com base nas alocações feitas. Quando uma coleta é disparada, o Garbage Collectorchama um método VirtualFree do Win32que limpa a memória ocupada por objetos sem uso. Este processo “compacta” objetos em uso, os reorganiza para ficarem juntos e o espaço excedente é removido. Assim o heap fica menor, ocupando menos memória. Isto assegura que objetos alocados juntos continuem juntos no heap gerenciado, preservando sua localização.
A frequência e duração da intervenção das coletas é resultado do volume de alocações e da quantidade de memória restante no heap gerenciado.

### Gerações

Os objetos que são alocados na heap acabam sendo divididos em três grupos, também chamados de gerações, para poder lidar com **objetos de vida útil longa** e **objetos de vida útil curta**. A coleta ocorre primeiro com os objetos de vida útil curta, que normalmente ocupam uma pequena parte do heap.Existem 3 gerações de objetos no heap:
- **Geração 0**: é a primeira geração onde um objeto é alocado. Assim que algo é alocado na heap, o objeto alocado é colocado imediatamente como sendo parte da geração 0; Um exemplo de objeto de vida curta são variáveis temporárias. A coleta ocorre mais frequentemente nesta geração.
- **Geração 1**: trata-se de uma geração de transição, onde objetos que são utilizados de maneira “média”,de vida curta, são alocados. Serve como um buffer entre objetos de vida curta e objetos de vida longa.
- **Geração 2**: é uma geração que contém objetos que são utilizados por mais tempo, de vida longa, e que, por isso, precisam existir na memória por um tempo maior. Um exemplo deste tipo é um objeto de uma aplicação servidor que contém dados estáticos que se mantém ativos durante o processo.

### O ciclo de trabalho do Garbage Collector na heap

O que o Garbage Collector faz basicamente é migrar os objetos entre estas três áreas distintas e eliminar as áreas de memória associadas a objetos que não são mais utilizados. Seguindo o seguinte ciclo de análise:
1.	Suspenda todos os threads gerenciados, exceto o thread que acionou o Garbage Collection.
2.	Encontre uma lista de todos os objetos ativos.
3.	Remova os objetos mortos e recupere sua memória.
4.	Compacte os objetos sobreviventes e promova-os para uma geração mais antiga.

Objetos novos alocados formam uma nova geração de objetos e são implicitamente de geração 0, a não ser que sejam objetos grandes. Neste caso eles vão diretamente para o heap de grandes objetos na geração 2.A maioria dos objetos são coletados na geração 0 e não sobrevivem para a próxima geração.

A coleta ocorre em gerações específicas quando as condições permitem.É importante notar também que os ciclos de análise ocorrem na geração que é alvo do ciclo e nas gerações anteriores, mais novas. Por exemplo: se o Garbage Collector precisa analisar a geração 0, somente ela é analisada. Se o Garbage Collector precisa analisar a geração 1, as gerações 1 e 0 são analisadas. Se o Garbage Collector precisa analisar a geração 2, as gerações 2, 1 e 0 são analisadas. Em decorrência desse funcionamento, o ciclo de análise na geração 2 ganha o nome de coleta completa ou total, pois analisa todos os objetos de todas as gerações (ou seja, todos os objetos do heap gerenciado). Essa análise do Garbage Collector pode ocorrer em situações pré-definidas:
- Quando o sistema operacional ficar sem memória física disponível;
- O tamanho das gerações é estourado, ou seja, objetos alocados na memória precisam de mais espaço;
- O método GC.Collect() é invocado manualmente, o que caracteriza uma chamada explícita para o processo de análise do Garbage Collector dentro da aplicação.

O Garbage Collector trabalha em ciclos de análise sobre as gerações que existem na heap. O que diferencia o funcionamento do Garbage Collector sobre as gerações é a peridiocidade da inspeção: a geração 0, por ser menor na maioria das vezes, sofre análises do Garbage Collector mais frequentes do que as gerações 1 e 2 por exemplo. Nestas análises, o que o Garbage Collector faz é verificar se os integrantes das gerações estão ainda sendo utilizados e, caso algum integrante não seja mais necessário, este é removido, fazendo com que a área de memória correspondente seja liberada e fique disponível para novas alocações.

### Sobreviventes e promoções

Os objetos são inicialmente alocados na geração 0 – portanto, na geração que sofre coletas mais rápidas – porque a CLR supõe que estes objetos não serão mais necessários muito rapidamente, o que faria com que estes objetos fossem removidos rapidamente da memória. E isso é verdade para a maioria dos cenários. Porém, alguns objetos podem precisar sobreviver por mais de um ciclo de análise do garbage collector.

Objetos não recolhidos durante uma coleta são conhecidos como sobreviventes e são promovidos para a próxima geração, sofrendo ciclos mais espaçados de análise do garbage collector. Objetos sobreviventes de uma coleta na geração 0 são promovidos para a geração 1, objetos sobreviventes de uma coleta na geração 1 são promovidos para a geração 2 e objetos que sobreviventes a uma coleta na geração 2 permanecem na geração 2.

Esse processo de promoção pode tornar a gerência de memória um processo muito lento, já que esse deslocamento de gerações pode exigir uma quantidade de processamento computacional considerável, dependendo da quantidade de objetos alocados. Por isso, o CLR sempre está “supervisionando” o trabalho do Garbage Collector. Se o Garbage Collector passa a detectar que a taxa de sobrevivência de objetos em uma determinada geração é muito alta, a CLR aumenta o tamanho da geração em questão, evitando que as gerações tenham seu tamanho estourado frequentemente. A CLR sempre tenta equilibrar os ciclos de análise do Garbage Collector e o tamanho das gerações – as gerações também não podem ser sempre expandidas, pois isso deixaria o sistema operacional sem memória em um curto espaço de tempo. Ou seja, O CLR faz o balanço continuamente de duas prioridades: não deixar que o conjunto de trabalho de um aplicativo fique muito grande e não deixar a coleta tomar muito tempo.
 
### Gerações e segmentos efêmeros

O CLR e o Garbage Collector supõe que os objetos que fazem parte das gerações 0 e 1 terão um ciclo de vida muito curto, sendo eliminados rapidamente da memória. Por isso, estas gerações também são conhecidas como gerações efêmeras, pelo fato dos objetos neles serem de vida curta.

Gerações efêmeras devem ser alocados no segmento de memória que é conhecido como segmento efêmero. Cada novo segmento adquirido pelo Garbage Collector se torna um novo segmento efêmero e contém os elementos que sobreviveram a coleta da geração 0. O antigo segmento efêmero se torna o novo segmento geração 2.

O tamanho do segmento efêmero varia dependendo do sistema (32 ou 64 bits) e do tipo de Garbage Collector que está em execução. Valores padrão estão na tabela seguinte.

| Tipo | 32-bit | 64-bit |
|:----------|------|---------------------|
|GC de estação| 16 MB | 256 MB |
|GC de servidor  |  64 MB | 4 GB |
|GC de servidor com mais de 4 CPUs lógicos	  |  32 MB |  2 GB |
|GC de servidor com mais de 8 CPUs lógicos  |  16 MB |  1 GB |

Segmentos efêmeros podem incluir objetos geração 2. Objetos geração 2 podem utilizar múltiplos segmentos (quantas seu processo precisar e a memória suportar).

A quantidade de memória liberada é proporcional ao espaço ocupado pelos objetos inativos.A linguagem C# fornece métodos especiais que são usados para liberar a instância de uma classe a partir da memória, são eles: Finalize() e Dispose().

### Gerenciando recursos não gerenciados

Tudo isso seria suficiente se você estivesse trabalhando apenas com recursos gerenciados. Manter objetos como seqüências de caracteres, números e outros tipos gerenciados é manuseado completamente pelo coletor de lixo. Mas recursos não gerenciados como uma conexão de rede, identificador de arquivo, identificador de janela, é necessário liberar explicitamente esses itens. Caso contrário, você receberá erros como "Este arquivo está em uso" ou não poderá se conectar ao seu banco de dados porque todas as conexões estão em uso.

### Finalize ~

Por esse motivo, o C# suporta o conceito de finalização. Esse mecanismo permite que um tipo seja limpo antes da coleta de lixo. É importante entender que um finalizador de C# não é o mesmo que um destruidor de C++. Os destruidores de C++ podem ser chamados determinísticos, pois você sabe quando eles serão executados. Em C#, no entanto, você não sabe quando o GC chamará o método Finalize de um objeto, portanto, esse processo é chamado de finalização não determinística.

O método destruidor Finalize()é um método especial que é chamado a partir de uma classe para qual ele pertence ou a partir de classes derivadas. Um finalizador é o oposto de um construtor, enquanto o construtor é a primeira oportunidade de trabalhar com um objeto o Finalize é a última oportunidade de trabalhar com um objeto. Um finalizador em C# requer alguma sintaxe especial, assim como um construtor. Você precisa prefixar o nome da classe com um til (~) para criar um finalizador.

```csharp
public class SomeType
{
    ~SomeType()
    {
        // This code is called when the finalize method executes
    }
}
```


Este destruidor é convertido no seguinte método Finalize:

```csharp
protectedoverridevoid Finalize()
{
    try
    {
        // Free unmanaged resources here. ... 
    }
    finally
    {
        base.Finalize();
    }
}
```

Você não pode substituir explicitamente o método Finalize no código C#. Isso também é bom porque seu código não pode chamar diretamente o método Finalize da classe base. (Veja a lista anterior de regras destruidoras.)

Várias regras se aplicam a destruidores que não se aplicam a outros métodos. A lista a seguir resume essas regras:
- Destrutores podem ser definidos apenas em classes, não em estruturas.
- Uma classe pode ter no máximo um destruidor.
- Os destruidores não podem ser herdados ou sobrecarregados.
- Destrutores não podem ser chamados diretamente.
- Destruidores não podem ter modificadores ou parâmetros.

O importante é entender que um finalizador aumenta a vida útil de um objeto. Como o código de finalização também precisa ser executado, o .NET Framework mantém uma referência ao objeto em uma fila de finalização especial. Um encadeamento adicional executa todos os finalizadores em um momento considerado apropriado com base no contexto de execução. Isso atrasa a coleta de lixo para tipos que têm um finalizador.
1.	Os objetos utilizam um ponteiro na pilha que referencia os dados armazenados na pilha. Quando o GC é executado, ele vê que os dois objetos ainda têm referências e, portanto, nenhuma ação é tomada.
2.	Na próxima vez que o GC for executado, o Endereço: 1 e o Endereço: 2 não terão mais referências. Como o endereço: 1 não possui um finalizador, ele é removido.
3.	Como o Endereço: 2 possui um Finalizador, ele é colocado em uma fila e mantido vivo.
4.	O thread do Finalizador é executado e identifica objetos na fila e executa seus métodos de finalização. Após a finalização, o objeto fica órfão. Na próxima vez que o GC ocorrer, o objeto será excluído

<p align="center">
  <img src="https://raw.githubusercontent.com/shyoutarou/Exam-70-483_Criar_usar_tipos/master/.github/Finalizador.png" alt="Image" width="100%" />
</p>
 
Os finalizadores devem ser usados somente quando necessário, pois:
- Usa muitos recursos do sistema
- Reduza a alocação e a coleta de memória
- Prolongar a vida útil dos objetos, não limpa a memória imediatamente.
- Impossível prever a ordem na qual os finalizadores de um conjunto de objetos serão chamados
- Se o código em um finalizador bloquear, referenciar outros objetos finalizáveis ou lançar exceções, a finalização não ocorrerá.

Pode ser utilizado durante o uso de qualquer recurso não gerenciado como um Stream de arquivo declarado no nível de classe. Podemos não estar sabendo em que fase ou etapa deve ser apropriada para fechar o arquivo. Este objeto está sendo usado em muitos lugares no aplicativo. Portanto, neste cenário o Finalize pode ser apropriado onde o recurso não gerenciado pode ser liberado.

### Disposal

O método Dispose() é chamado para liberar recursos que GC não é capaz de liberar uma vez que não dispõe de informações para reivindicar a memória desses recursos como manipuladores de arquivos, manipuladores de janelas, sockets de rede, conexões de banco de dados, etc, tão logo o objeto usando o recurso não esta mais sendo usado. 

Por exemplo, se você abrir um arquivo no programa e não fechá-lo após o processamento, o arquivo não estará disponível para outras operações ou ele está sendo usado por outra aplicação que não podem abrir ou modificar o arquivo. Para este fim classe FileStream fornece o método Dispose. Temos de chamar esse método após o processamento do arquivo ser concluído, caso contrário, ocorrerá uma exceção de acesso negado ou de que o arquivo está sendo usado por outro programa.

```csharp
StreamWriter stream = File.CreateText("temp.dat");
stream.Write("some data");
File.Delete("temp.dat"); // Throws an IOException because the file is already open.
```

Os métodos finalizers são chamados no final do ciclo de varredura do Garbage Collector e realizam a limpeza de recursos não gerenciados. É uma alternativa usada quando o objeto que consome o recurso não chama o Dispose. Você pode forçar isso adicionando uma chamada ao GC.Collect, conforme mostrado no código a seguir. A linha WaitForPendingFinalizers garante que todos os finalizadores tenham sido executados antes que o código continue. O Garbage Collector é bastante inteligente no gerenciamento de memória e não é recomendável fazer a chamada manualmente para o GC.

```csharp
StreamWriter stream = File.CreateText("temp.dat");
stream.Write("some data");
GC.Collect();
GC.WaitForPendingFinalizers();
File.Delete("temp.dat");
```

Ao executar esse trecho de código no modo Release, o Garbage Collector verá que não há mais referências ao fluxo e liberará qualquer memória associada à instância do StreamWriter. Isso executará o finalizador, que, por sua vez, liberará qualquer identificador de arquivo para o arquivo temp.dat (no modo de depuração, o compilador garantirá que a referência não seja coletada como lixo até o final do método).

No geral, você não deve depender do Garbage Collector para executar um finalizador para fechar seu arquivo. Para oferecer a você a oportunidade de liberar explicitamente recursos não gerenciados, o C# oferece a idéia da interface IDisposable.

```csharp
public interface IDisposable
{
    void Dispose();
}
```

A interface IDiposable oferece umúnico método: Dispose, que libera qualquer recurso não gerenciado imediatamente. Diferente do método Finalize() o método Dispose() não é chamado automaticamente e você precisa chamá-lo explicitamente a partir de uma aplicação cliente quando um objeto não mais for necessário.O exemplo anterior também poderia ter sido escrito utilizando o método Dispose().
```csharp
StreamWriter stream = File.CreateText("temp.dat");
stream.Write("some data");
stream.Dispose();
File.Delete("temp.dat");
```

Mas e se uma exceção ocorresse antes que stream.Dispose() fosse chamado? Para garantir que seus recursos sejam sempre limpos, você precisa agrupar todos os tipos que implementam IDisposable em uma instrução try/finally.

### Try-finally

É o jeito mais antigo de consumir recursos desde que using foi implementado no .NET Framework. Uma regra básica ao se consumir um recurso é garantir o sucesso de quem for utilizá-lo. No bloco finally vai a chamada explícita ao método Dispose. É seguro, pois o bloco finally sempre será executado. 

```csharp
FileStream fs = null;
string path = @"C:\temp\Teste.txt";
try
{
    fs = new FileStream(path, FileMode.CreateNew, FileAccess.ReadWrite);
}
catch (IOException)
{
    if (File.Exists(path))
    {
        var newPath = path.Replace("Teste", "outro");
        //tenta criar o arquivo com novo path
        fs = new FileStream(newPath, FileMode.CreateNew, FileAccess.ReadWrite);
    }
}
finally
{
    if (fs != null) fs.Dispose();
}
```

### Using

Como o uso dos tipos que implementam IDisposable em uma instrução try/finally é muito comum, o C# possui uma instrução especial para simplicar isso: a instrução using. A instrução using é convertida pelo compilador em uma instrução try/finally que faz uma chamada implícita ao método Dispose no objeto. Por esse motivo, a instrução using pode ser usada apenas com tipos que implementam IDisposable, como StreamReader/StreamWriter, DataTable.

```csharp
string path = @"C:\temp\outro.txt";
string destPath = @"C:\temp\Teste.txt";

using (TextReader txt = new StreamReader(path))
{
if (!File.Exists(path))
    {
        File.Copy(path, destPath);
        Console.WriteLine("Arquivo copiado com sucesso.");
    }
}

```


Após descartar um item, você não poderá mais usá-lo. O uso de um item descartado resultará em uma ObjectDisposedException. Abaixo um exemplo de classe implementando IDisposable utilizando using.

```csharp
class MyClass : IDisposable
{
    public StreamReader reader;
    public void Dispose()
    {
        //Cleanup unmanaged resources
        if (reader != null)
            reader.Dispose();
        GC.SuppressFinalize(this);
        Console.WriteLine("Disposed");
    }
}

using (myClass obj = new myClass()) { }
Console.WriteLine("End");
```

### Implementando IDisposable e um finalizador

O método Finalize não pode ser chamado explicitamente no código. Só pode haver a implementação da interface IDisposable, via declaração do destruidor, e deixar o GC realizar o seu serviço que é o de chamar o Finalize quando os objetos se tornam inacessíveis. É recomendável implementar os métodos Finalize e Dispose em conjunto, se você precisar implementar o método Finalize. Após a compilação o destruidor se torna o método Finalize.

Por exemplo, suponha que você tenha uma classe de wrapper em torno de um recurso de arquivo não gerenciado. Você implementa IDisposable para que os usuários da sua classe possam limpar imediatamente, se quiserem. Você também implementa um finalizador, caso eles se esqueçam de chamar Dispose. A exemplo abaixo mostra como fazer isso. 

```csharp
class UnmangedWrapper : IDisposable
{
    bool disposed = false;
    public FileStream Stream { get; privateset; }

    public UnmangedWrapper()
    {
        this.Stream = File.Open("temp.dat", FileMode.Create);
    }

    ~UnmangedWrapper()
    {
        Dispose(false);
    }

    public void Close()
    {
        Dispose();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public void Dispose(bool disposing)
    {
        if (disposed) return;
        if (disposing)
        {
        if (Stream != null)
            {
                Stream.Close();
            }
        }
        disposed = true;
    }
}
```

Há algumas coisas a serem observadas sobre essa implementação:
- Foi criado uma flag que vai controlar se o recurso já foi liberado ou não (bool disposed);
- O finalizador chama Dispose apenas passando false para disposing.
- O método Dispose extra com o argumento booleano faz o trabalho real. Este método deve ser protected virtual por causa da hierarquia de herança. É assinado com protected para limitar sua visibilidade por outras classes fora da hierarquia. Este método verifica se está sendo chamado em um Dispose explícito ou se está sendo chamado a partir do finalizador:
    - Se o finalizador chamar Dispose, você não fará nada porque o objeto Stream também implementa um finalizador e o Garbage Collector se encarrega de chamar o finalizador da instância do Stream. Você não pode ter certeza se já foi chamado, por isso é melhor deixar isso para o coletor de lixo.
    - Se Dispose for chamado explicitamente, feche o FIleStream subjacente. É importante ser defensivo ao codificar esse método; sempre verifique qualquer fonte de possíveis exceções. Pode ser que Dispose seja chamado várias vezes e isso não cause erros.
- O método Dispose regular chama GC.SuppressFinalize (this) para garantir que o objeto seja removido da lista de finalização que o Garbage Collector está acompanhando. A instância já foi executada, portanto, não é necessário que o Garbage Collector chame o finalizador.
- Por fim, utilize o finalizer apenas se ele não foi implementado no seu código dentro de um bloco using ou try-finally com uma chamada ao Dispose.

É importante saber a diferença entre implementar o IDisposable e um finalizador. Ambos limpam seu objeto, mas um finalizador é chamado pelo Garbage Collector e o método Dispose pode ser chamado a partir do código.

| Finalize | Dispose | 
|:----------|------|
|Usado para liberar recursos não gerenciados como arquivos, conexões de banco de dados, recursos COM, etc. retidos por um objeto antes que objeto seja destruído. | Ele é usado para liberar recursos não gerenciados como arquivos, conexões de banco de dados, etc COM a qualquer momento. | 
|Internamente é chamado pelo Garbage Collector e não pode ser chamado pelo código do usuário.  |  É chamado explicitamente pelo código do usuário, a classe que o define deve implementar a interface IDisposable.  |
| Pertence a classe Object  |  Pertence à interface IDisposable. | 
| Implementar quando você tem recursos não gerenciados em seu código, e quer ter certeza de que esses recursos são liberados quando a coleta de lixo acontecer.  |  Implementar quando você está escrevendo uma classe personalizada que será usada por outros usuários. | 
| Há custo de desempenho associado.  |  Não há custo de desempenho associado | 	
	
A lista a seguir resume as regras e conceitos de gerenciamento de recursos:
- Se uma classe não contém recursos gerenciados e não gerenciados, não é necessário implementarIDisposable ou ter um destruidor.
- Se a classe tiver apenas recursos gerenciados, deverá implementar IDisposable, mas não precisa de um destruidor. O destruidor deve liberar apenas recursos não gerenciados. (Quando o destruidor é executado, você não pode ter certeza de que os objetos gerenciados ainda existem, portanto não pode chamar os métodos Dispose de qualquer maneira.)
- Se a classe tiver apenas recursos não gerenciados, precisará implementar IDisposable e precisará de um destruidor, caso o programa não chame Dispose.
- O método Dispose deve ser seguro para executar mais de uma vez. Você pode conseguir isso usando uma variável para acompanhar se ela já foi executada antes.
- O método Dispose deve liberar recursos gerenciados e não gerenciados.
- Após liberar recursos, o destruidor deve chamarGC.SuppressFinalize, para que o objeto possa pular a fila de finalização.
- Para evitar confusão, idealmente, uma classe não deve incluir recursos gerenciados e não gerenciados. Se a classe tiver recursos não gerenciados, deverá gerenciar apenas um recurso

### WeakReference - Referências fracas

Um WeakReference permite que o coletor de lixo colete o objeto enquanto ainda permite que o aplicativo o acesse. Uma referência fraca é válida somente durante o período indeterminado até que o objeto seja coletado quando não há nenhuma referência forte. Quando você usa uma referência fraca, o aplicativo ainda pode obter uma referência forte para o objeto, o que impede que ele seja coletado. No entanto, sempre há o risco de o coletor de lixo obter o objeto primeiro antes de uma referência forte ser restabelecida.

| Propriedades | Descrição | 
|:----------|------|
| IsAlive | Obtém uma indicação se o objeto referenciado pelo objeto WeakReference atual passou pela coleta de lixo. | 
| Target  |  Obtém ou define o objeto (o destino) referenciado pelo objeto WeakReference atual. |
| TrackResurrection  |  Obtém uma indicação se o objeto referenciado pelo objeto WeakReference atual é acompanhado depois de finalizado. | 

```csharp
static WeakReference _weak;

static void Main(string[] args)
{
    _weak = new WeakReference(new StringBuilder("perls"));

    // See if weak reference is alive.
    if (_weak.IsAlive)
        Console.WriteLine((_weak.Target as StringBuilder).ToString());

    // Invoke GC.Collect.
        GC.Collect();

    // Check alive.
    if (_weak.IsAlive)
    {
        Console.Write("stillAlive: ");
        Console.WriteLine((_weak.Target as StringBuilder).ToString());
    }

    Console.ReadKey();
}
```

Você pode criar uma referência fraca curta ou uma referência fraca longa:
- **Short**: O destino de uma referência fraca curta se torna null quando o objeto é recuperado pela coleta de lixo. A referência fraca é um objeto gerenciado e está sujeita à coleta de lixo assim como qualquer outro objeto gerenciado. Uma referência fraca curta é o construtor sem parâmetros para WeakReference.
- **Long**: Uma referência fraca longa é mantida após o método Finalize do objeto ter sido chamado. Isso permite que o objeto seja recriado, mas o estado do objeto permanece imprevisível. Para usar uma referência longa, especifique true no construtor WeakReference.
Se o tipo de objeto não tiver um método Finalize, a funcionalidade de referência fraca curta é aplicada e a referência fraca é válida apenas até o destino ser coletado, o que pode ocorrer a qualquer momento após o finalizador ser executado.

Para estabelecer uma referência forte e usar o objeto novamente, converta a propriedade Target de um WeakReference para o tipo do objeto. Se a propriedade Target retornar null, o objeto terá sido coletado, caso contrário, continue usando o objeto, pois o aplicativo recuperou uma referência forte para ele.

Às vezes, você precisa trabalhar com objetos grandes que exigem muito tempo para serem criados. Por exemplo, uma lista de objetos que precisam ser recuperados de um banco de dados. Seria bom se você pudesse apenas manter os itens na memória; no entanto, isso aumenta a carga de memória do seu aplicativo e talvez a lista não seja mais necessária. Mas se a coleta de lixo ainda não ocorreu, seria bom se você pudesse reutilizar a lista que criou.

```csharp
static WeakReference data;

public static void Run()
{
    object result = GetData();
    // GC.Collect(); Uncommenting this line will make data.Target null
    result = GetData();
}

private static object GetData()
{
    if (data == null)
    {
        data = new WeakReference(LoadLargeList());
    }

    if (data.Target == null)
    {
        data.Target = LoadLargeList();
    }

    return data.Target;
}

private static object LoadLargeList()
{
    throw new NotImplementedException();
}
```

A função GetData verifica se o WeakReference ainda contém dados. Caso contrário, os dados serão carregados novamente e salvos no WeakReference. O interessante é que descomentar a linha GC.Collect () libera a memória que o WeakReference aponta. Se a coleta de lixo não ocorreu, os dados dentro de WeakReference.Target podem ser acessados e retornados ao chamador.

Usar o WeakReference não é uma solução completa para um cenário de armazenamento em cache. Se você deseja implementar um cache, defina um algoritmo que decida quais itens devem ser removidos do cache. Ao remover, você transforma uma referência em WeakReference e deixa para o coletor de lixo.
