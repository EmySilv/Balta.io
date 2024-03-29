  Instalação
  dotnet.microsoft.com/downloads
  
_______________________________________________________________________________________________________________________________________________________________________
  Dotnet CLI
  - Command Line Interface
    - Interface de linha de comando
    - Comandos via terminal
  - Comandos cmd
    - dotnet -version (verificação de versão do .NET)
    - dotnet --list-sdks (SDK's instalados)
    - dotnet --list-runtimes (Runtimes intalados)
    - dotnet help (auto-explicativo)

_______________________________________________________________________________________________________________________________________________________________________
  VS Code
  code.visualstudio.com
_______________________________________________________________________________________________________________________________________________________________________
  Tipos de Projeto
  - Class Library (Biblioteca de classes)
    - resultado final será DLL (Dynamic-link library, Biblioteca de vinculo dinamico)
    - não tem interface
  - Console Aplication 
    - famosa telinha preta
    - final aplicação que roda terminal
    - receber dados, esperar input do usuario
    - tem resultado visivel
  - Projeto Web
    - ASP.NET Web
    - ASP.NET MVC
    - ASP.NET WebAPI
  - Projeto Testes
    - São projetos que podemos fazer antes de enviar para o cliente. Mais para ver se esá tudo certo ou se precisa corrigirr algo.
    - Deixar todos os testes automátizados.
    - Microsft Tests
    
    Criando um novo projeto
    - dotnet cli
      - dotnet new console (cria um novo console)
      - dotnet new claslib (nova Class Library)
      - dotnet new web (cria um projeto ASP.NET Core)
      - dotnet new mvc (cria um projeto ASP.NET Core tb)
      - dotnet new webapi (cria um projeto ASP.NET Core tb)
      - dotnet new mstest (cria um Microsoft Test)
      entre outros...
    - Mesmo coisa que gera arquivos iniciais
    - Especificar uma pasta é o -o
    
_______________________________________________________________________________________________________________________________________________________________________
  Fluxo de Execução
  - dotnet restore (restaura/baixa pacotes que a aplicação precisa)
     - Primeira coisa a se fazer quando se tem uma aplicação dotnet é dar um dotnet restore para que baixe todas as dependencias.
     
  - dotnet build (compila)
    - te dá avisos e erros após a compilação
    
  - dotnet clean (limpa compilações anteriores)
    - limpa os itens do cache
  
  - dotnet run (compila e executa)
  
_______________________________________________________________________________________________________________________________________________________________________
  Variáveis de Ambiente
  - Os ambientes é onde a aplicação tá rodando, como por exemplo a minha máquina, que é um ambiente de desenvolvimento
    - Algumas empresas tem um ambiente de teste, outras não.
    - Assim como o ambiente de homologação, que umas tem outras não. 
    - E o ambiente de produção, que sai da maquina do dev e vai pro cliente, já sendo exibida.
  - Cada ambiente tem suas configs
  - Quando se está num ambiente dedesenvolvimento vc tem as variaveis de ambientes definidas para um desenvolvimento local não de produção.
  - Podendo chaviar essas informações no .net; para fazer isso no RUN é usada a palavra _enviroment_
  - O comando RUN não executa Debug
    - o ambiente onde vc está não significa que vc tá executando o debug, até pq o RUN não faz isso
  // As variáveis de ambiente são cadeias de caracteres que contêm informações sobre o ambiente do sistema e sobre o usuário que está no momento conectado. Alguns programas de software usam as informações para determinar onde colocar arquivos (como por exemplo, os arquivos temporários).
    
  
_______________________________________________________________________________________________________________________________________________________________________
  Estrutura do App
  - pasta bin se refere ao binário
  - arquivo csproj é XML (EXtensible Markup Language) linguagem de marcação.
  - cada tipo de projeto tem um output e esse csproj é exe(executavel)
  - target framework mostra qual framework a aplicação tá usando/baseando.
    link: docs.microsoft.com/pt-br/dotnet/standard/net-standard
  - toda aplicação que roda sem ser classLibrary tem um ponto de entrada, como o Program.cs; ele sempre vai buscar um arquivo Program.cs para executar
  - pasta obj, que é o tempo de debug
  
_______________________________________________________________________________________________________________________________________________________________________
  Debug
  - Modo Realese
    - Solta a aolicação
  - Quando executado um DOTNET RUN na aplicação, é como se fossemos um cliente executando ela, ou seja, modo release
  - para executar o modo debug temos que ir no insetozinho no code.
  
