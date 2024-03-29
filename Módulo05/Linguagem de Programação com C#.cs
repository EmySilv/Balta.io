Notas Importantes
  - não utilizar caracteres especial ou espaço
  - utilizar camnhos curtos
  - evitar caminhos de rede
  - c# é case sensitive, diferencia maiuscula de minuscula.
______________________________________________________________________________
  Escopo de um Programa
  - é tudo que um programa tem para ser executado
    - no .net temos:
      - importações doq usaremos, definidas pelo USING;
      - namespace que são separações lógicas
      - classe
      - método principal
  ______________________________________________________________________________
  Namespace
  - divisão lógica
  - não podemos ter duas classescom mesmo nome em um namespace
  - recomendado ter um namespace e uma classe por arquivo
  - escopo do namespace é definido entre chaves, assim como classes e metodos
  - um namespace pode ser reutilizado, estando presente em varios arquivos
  - mesmo namespace e a classe diferente pode ter, só n o mesmo namespace e a mesma classe.
  - pode se ter um namespace dentro do outro usando o "."
  - pode se ser usado um namespace dentro de outro, fazendo a importação pelo USING;
  - durante a compilação os arquivos c# são unificados e a divisão fisica se perde e oq sobra é a divisão lógica. Formando uma DLL só
  ______________________________________________________________________________
  Using
  - a importação define as bibliotecas que o programa usará
  - o basico vem como padrão
  - palavra USING para esssa importação
  - serve tb para organizar o codigo em namespace
  - usar e abusar da criação de arquivos e namespace
______________________________________________________________________________
  Variaveis
  - utilizada para guardar informação
  - criação é instanciar, de modo técnico
  - pode ser usado um tipo ou a palavra reservada cvar para criar uma variavel
  - var é uma forma de evvitar escrecer o tipo da variavel
______________________________________________________________________________
  Constantes 
  - parecida com o conceito de variavel, mas não podem ser alteradas 
  - definida pelo const antes do tipo.
  - sem valor definido, ela inicia com 0
  - constantes em maiúsculo, separadopor "_"
______________________________________________________________________________
  Palavras Reservadas
  - keywords
  - exclusivos do c#
  - não podemos usar essas palavras reservadas
______________________________________________________________________________
  Comentários  
  - pode ser feita em:
      - uma linha;
      //
      
      - multiplas linhas;
      /**/
      
      - XML (MetaData): dados adicionais da classe
      ///
      
  - no vscode 'ctrl + k + c' comenta, e 'ctrl + k + u' tira o comentário.
______________________________________________________________________________
  Tipos Primitivos(built-in types)
  - são os tipos bases do dotnet, inteiros, caracteres, cadeia de caractere, ponto flutuante
  - definir de forma correta melhora a execução
  - Value Types
  - Classificados em:
    - Tipos Simples (Simple Types)
    - Enumerados (Enums)
    - Estruturas (Structs)
    - Tipos Nulos (Nullable Types)
  - cada tipo tem a sua capacidade
______________________________________________________________________________
  System
  - tipo base/raiz
  - todos os outro itens do.net derivam do System
______________________________________________________________________________
  Byte
  - utilizado pra representar um byte, de fato
  - tb chamado de byte array
  - sbyte (Signed Byte) permite valor negativo
______________________________________________________________________________
  Números Inteiros
  - sempontuação, definidos por:
    - short/ushort (16-bit)
    - int/uint (32-bit)
    - long/ulong (64-bit)
  sendo o 'u' significando UNSIGNED (sem sinal), não podendo receber valores negativos
______________________________________________________________________________
  NÚmeros Reais
  - numeros com ponto flutuante
  - defeinidos por:
    - float (32-bit)
    - double (64-bit)
    - decimal (128-bit)
  - pra definir um float colocamos um 'f' no final e o decimal um 'm' no final, pois a conversão padrão é do double
______________________________________________________________________________
  Boolean
  - armazena true or false
    - bool (8-bit)
______________________________________________________________________________
  Char
  - armazena somente um caractere no formato Unicode;
    - char (16-bit);
  - atribuição por aspas simoples, ex 'D';
______________________________________________________________________________
  String
  - armazena uma cadeia de caracteres;
    - string (?), depende da quantidade de caractere;
  - atribuição por aspas duplas;
  - podendo ser considerada uma lista de char;
______________________________________________________________________________
  Var
  - substitui o nome de um tipo
  - primeiro valor atribuido é que dá o tipo;
  - atalho para o nome da variavel;
  - não serve pra quando não sabemos o tipo do dado;
______________________________________________________________________________
  Object
  - tipo genérico que recebe qualquer valor ou objeto, pode ser qualquer coisa;
  - tipo um var;
  - não tem intelisence;
  - tipo desconhecido;
______________________________________________________________________________
  Nullable Types
  - Null
    - significa vazio
    - nulo é pra definiçaõ de tipo
    - diferente de zero ou uma  string vazia
    - atribuindo null a um objeto ele ficará vazio
    - feita com uma interrogaçaõ na frente de um tipo
      ex: int? idade = null;
______________________________________________________________________________
  Alias
  - apelido que todo tipo no .net tem
  - nao é exclusivo do .net
  - um exemplo de alias é o 'string' que é um apelido de 'String'
  - c# é case sensitive, tanto faz escrever um ou outro
  - o recomendado é usar os alias
      - com alias escrevemos menos, ex:
      int idade = 25; (alias)
      Int32 idade = 25:
______________________________________________________________________________
  Valores Padrões
  - .net sempre vem com um valor padrão
  - tipos built-in tem valor padrão
  - se não houver especificcação, o valor padrão é zero
    - int = 0
    - float = 0 
    - decimal = 0 
    - bool = false
    - char = '\0'
    - String => ""
______________________________________________________________________________
  Conversão Implícita
  - existem dois tipos de conversão implicitas e explicitas
  - as implicitas são conversões que podem ser executadas apenas com dados e dados compatives
   ex:
      float valor = 28.8f;
      int outro = 25;
      
      valor = outro; // conversão implícita
  - só ocorre se os tipos e tamnanho for compativel caso contrário não dá
  - tentar converter um numero real pra um inteiro não funciona, mas o contrario funciona.
______________________________________________________________________________
  Conversão Explicita
  - obrigatoriamente informar o tipo que sera convertido, acontece quando os tiposs não são compativeis
  - conversão se dá pelo parentese

______________________________________________________________________________
  Parse
  - presente em toido metodo primitivo
  - usado para converter uma string em qualquer outro tipo
  - se não for compativel, gera erro
______________________________________________________________________________
  Convert
  - parecido com o parse
  - porem faz a conversão de varios tipos de valores
  - devemos informar o tipo na hora ad conversão, não o alias
    ex:
      int inteiro = Convert.ToInt32("100")
   - é uma classe, não uma extensão
   
______________________________________________________________________________
  Convertendo Tipos
  - é conversão implicita e explicita
  - parse tb
    - parse espera uma String e não valores reais;
      string valorReal = real.ToString();
      inteiro = int.Parse(valorReal);
      - o .ToString estava convertendo o valor de float para string
  - convert arredonda os numeros e a conversão é mais "facil"
    Console.WriteLine(Convert.ToBoolean(0/1/...));
    vai retornar verdadeiro ou falso no console
______________________________________________________________________________
  Operadores Aritméticos
  - soma +
  - subtração - 
  - multiplicação / *
  - divisão = /
  
  - multiplicação e divisão são feitos primeiros
  - ordem personalizada se usa o parenteses
  - aceita todos os tipos númericos
  - se o valor for real, vai ser arrendondado (int)
    - 4.4 => 5 
______________________________________________________________________________
  Operadores de Atribuição
  - usamos o igual para atribuir um valor
  - porem podemos usar o igual com outro operador aritimético para fazer uma cona logo na atribuição
    ex:
      int x = 0;
      int x += 5;
      int x -= 1
      int x *= 10;
      int x /= 2
______________________________________________________________________________
  Operadores de Comparação
  - comparar dados
  - comparação só retorna true or false (boolean)
    - igual (comparação)
      - ==
      
    - diferente
      -!=
      
    - maior que
      - >
      
    - menor que
      - <
      
    - maiorou igual a 
      - >=
      
    - menor ou igual que
      - <=  
      
  - ex:
   int x = 25; (atribuição)
   x == 0; //false (comparação)
   x != 0; // true (diferente)
   x > 0; // true (maior que)
   x < 0; // false (menor que)
   x >= 0; //true (maior ou igual a)
   x <= 0; //false (menor ou igual a)
______________________________________________________________________________
  Utilizando operadores
  - colcando em pratica as aulas de operadores
  - ++ incrementa 1 a variavel
  - -- retira 1 da variavel
______________________________________________________________________________
  Operadores Lógicos
  - são usados para executar condicionais
  - sempre retorna true or false
  - E (and) -- &&
  - OU (or) -- ||
  - NEGAÇÃO (not) -- ! 
    ex : int x 12;
         bool entre = (x > 25) && (x < 40); // false
         bool ou = (x > 25) || (x < 40); // true
         bool negacao = !(x < 40); // false       
______________________________________________________________________________
  Estrutura Condicional: If
  - "SE"
  - composto do else
  - se a condição não for atendida temos a else if (condição)
    estrutura
    if (condição){
    
    }
  - se o resultado for uma linha pode não ter as chaves
    
    if (condição){
    
    } else {
    
    }
    
  - se o resultado for uma linha pode não ter as chaves no else tb
______________________________________________________________________________
  Estrutura condicional: Switch
  - utilizado para muitas condições
  - substitui o IF, em grandes proporções
  - pausa manual com break
  - execução padrão default
    ex 
      int valor = 1;
      switch (valor)
      {
          case 1: Console.WriteLine("1"); break;
          case 2: Console.WriteLine("2"); break;
          case 3: Console.WriteLine("3"); break;
          default: Console.WriteLine("4"); break;
      }
  - uma maneira mais facil, comparado ao if
______________________________________________________________________________
  Laço de Repetição: For
  - .net exige 3 parametros
    - contador
    - condição
    - incremento
      ex    
        for (var i = 0 (contador); i <= 5 (condição); i++(incrimento, que tá sempre adicionando +1))
    - se for apenas uma linha, não precisa abrir chaves
    - basicamente vc declara uma variavel, inicializa ela co um valor e depois diz oq tem que ser feita com essa variavel dentro dos parentesesa o for.
______________________________________________________________________________
  Laço de Repetição: While
  - tradução: enqaunto
  - roda até alguma coisa dar falo dentro do programa
  - checa a condição antes de executar
  - exige apenas uma condição
    ex
      var valor = 0;
    while (valor <= 5){
    Console.WriteLine(valor);
    valor++;
    
    or
    
    valor++; 
    Console.WriteLine(valor);  
}

    while (true){
    valor++;
    Console.WriteLine(valor);
    
} // vai executar infinitamente
______________________________________________________________________________
  Laço de Repetição: Do
  - tradução: faça
  - utilizado sempre com o while, seguido do while 
  - apenas uma condição
  - checa a condição depois de executar
    ex
        do{
      Console.WriteLine("teste");
      valor++;
      } while(valor < 5);
______________________________________________________________________________
  Métodos e Funções
  - main é um exemplo de metodo
  - tem retorno, nome e parametros
  - comecam sempre com maiuscula
  - assinatura do metodo: oq ele retorna, o nome e os parametros
      ex: definição 
          static void MeuMetodo(string parametro){
              Console.WriteLine(parametro);
          }
          
          invocação
          static void Main(string[] args){
              MeuMetodo("C#");
          }
______________________________________________________________________________
  Métodos e Funções: Prática
  namespace MeuApp{
    class Program{
        static void Main(string[] args){
            MeuMetodo();

            string nome = ReturnName("Emilly", "Vitória");
            Console.WriteLine(nome);
        }

        static void MeuMetodo(){
            Console.WriteLine("C#");
        }

        static string ReturnName(string name,
            string middleName, //parametro obrigatorio
            int idade = 18 //parametro opcional, sempre por ultimo.
         )
         {
            return name + " " + middleName + " tem " + idade.ToString();
        }
    }
} 
______________________________________________________________________________
  Value Types e Reference Types
  - memoria é dividida em duas partes, Heap e Stack
  - o Heap guarda os dados 
  - e o Stack guarda as referencias (endereço)
  - qualquer tipo no .net vai ser tratado ou como referencia ou como value types
  - os values types armazanam um dado
  - built-in, structs, enums são do tipo Heap
  - Garbage Colleector que é o coletor de lixo, ele olha a heap e ve que tem algo fora de uso, ele remove aquilo
  - garbage n acessa a memoria stack
  
  - reference armazena só o endereço
  - classes, objetos, arrays, são reference types
  - armazena a rferencia não o valor em si
  
  - sempre que igualamos um tipo, estamos criando uma copia desse valor.
  
______________________________________________________________________________
  Structs
  - tipo próprio
  - tipos de dado estruturado
  - apenas o esqueleto
  - armazena outros tipos de dados
  - nome sempre em maiusculo
  - pra criar usamos a plavra new
  - anatomia de estrutura 
                struct Product
                {
                    //propriedades 
                    
                    //metodos
                }
  - anatomia de propriedade
                 struct Product
                {
                    // propriedades
                    public int Id
                }
  - anatomia do método
                struct Product
    {
        public int Id;
        public float Prince;

        public float PrinceInDolar(float double)
        {
            return Prince * dolar
        }
    }
  
  - pra criar uma variavel do tipo product tem que usar o new
     var product = new Product;
       
______________________________________________________________________________
  Enumeradores
  - usado para melhor visualização do código
  - representados por inteiros
  - usados em listas curtas
  - dados fixos
    - hard coded
  - sempre em maiusculo
    - começam com a letra E
    
______________________________________________________________________________

______________________________________________________________________________
