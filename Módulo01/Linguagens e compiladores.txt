Baixo e Alto Nível

- Baixo nível: proximidade com a máquina, código binário etc. Quanto mais detalhada a necessidade, menoer é o nível. Assembly é linguagem de baixo nível.
  - Alto nível: proximidade com o dev, linguagens de programação modernas. C# é lingugagem alto nível.
  
_______________________________________________________________________________________________________________________________________________________________________
 
  - C# no tem tanto controle do processador, como o Assembly tem.*/
  
_______________________________________________________________________________________________________________________________________________________________________
Linguages Compiladas e Interpretadas
  
  - Linguagem compilada: Escrever o código em linguagem normal (a qual podemos ler e entender) e converter para binário.
  
  - Linguagens Interpretadas: Não são convertidos para bináro, apenas lido. Feito em tempo real. JS é linguagem interpretada. (Tempo de execução é o que acontece durante a execução do código pelo computador ou interpretadors.)
  
_______________________________________________________________________________________________________________________________________________________________________
 *Interpretada
    
     Prós
      - Não precisa ser compilada
      - Correções mais fáceis de serem executadas
      - Mais simples de serem distribuídas

    Contras
      - Detecção de erros
        (Os erros só aparecem quando a aplicação estiver sendo lida)
      - Tamanho final da aplicação maior
        (É mair pois é um arquivo em texto, não em binario, compilado)
      - Menor otimização da execução
        (Ferramentas para otimização, mas q são padrão na compilada)
      - Múltiplos arquivos

 *Compilada
   
    Prós
      - Tempo de compilação
        (Detecção mais rápida de erros)
      - Tamanho menor das aplicações
        (arquivo compacto, binario)
      - Maior otimização da execução
      - Apenas um arquivo final

    Contras
      - Precisa de um compilador
      - (Para transformar em uma linguagem de baixo nivel)
      - Pode ser mais burocrática
      
      _______________________________________________________________________________________________________________________________________________________________________
      Tipagem de Dados
      
      - Defeinição obrigatório dos tipos de dados
      (Tipo de Dado = definição dos valores(numérico, literal, caracteres, etc))
      
      - C# é uma lingugem de alto nivel, compilada e fortemente tipada.
      
      - O let usa o mesmo tamanho de alocação da memoria, ele não sabe sevai usar menos ou mias espaço.
      - Já no C# as variaveis possuem um tamanho pré-determinado
      int => 32-bit
      float => 32 bit
      double  => 64 bit
      decimal => 128 bit
      O que varia é a quantidade de numeros que conseguimos alocar nos tipos numérico.
