Consulta de Feriados Públicos
Este projeto é um exemplo de aplicação em C# que consome a API Nager.Date, que retorna feriados públicos de diferentes países para um ano informado. A aplicação solicita ao usuário o ano e a sigla de um país e exibe os feriados públicos correspondentes.

Funcionalidades
Solicita ao usuário um ano e a sigla de um país (como "BR" para Brasil).
Faz uma requisição HTTP para a API de feriados públicos.
Exibe uma lista de feriados com suas respectivas datas e nomes locais.

Tecnologias Utilizadas
C#
.NET
HTTPClient para requisições HTTP.
System.Text.Json para desserializar a resposta JSON da API.

Como Executar
Requisitos
.NET SDK versão 6.0 ou superior.
Acesso à internet para consumir a API.

Passos
Clone o repositório:

git clone https://github.com/seu-usuario/projeto-feriados-publicos.git
Navegue até o diretório do projeto:

cd projeto-feriados-publicos
Restaure as dependências e execute o projeto:

dotnet run

O programa solicitará que você informe:

O ano desejado (ex: 2024)
A sigla do país (ex: BR para Brasil ou US para Estados Unidos)
O programa exibirá uma lista dos feriados públicos para o ano e o país fornecidos.

Exemplo de Uso
plaintext
Copiar código
Informe o ano desejado:
2024
Informe a sigla do país desejado:
BR
-------------------------------------------------------------------------------
Dia de Ano Novo - 01-01-2024

-------------------------------------------------------------------------------
Carnaval - 12-02-2024
Estrutura do Projeto


├── Feriado.cs                    # Classe para deserializar os dados da API
├── Program.cs                    # Código principal que faz a requisição e exibe os feriados
├── projeto-feriados-publicos.sln # Arquivo de solução do projeto
└── README.md                     # Documentação do projeto

Referências
API de Feriados Públicos - Nager.Date

Contribuições
Sinta-se à vontade para abrir issues ou fazer pull requests para melhorias ou correções.

