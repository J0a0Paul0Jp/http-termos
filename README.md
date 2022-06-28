*TERMOS HTTP*
----
O **"status"** é forma de declaração que o servidor retorna em seu corpo de resposta
pra definir o status de uma solicitação, sendo representado principalmente como código numérico, os códigos mais utilizados dentre eles estão os:

- ``` 200``` -> é retornado quando uma solicitação é realizada com sucesso.
- ```400``` -> é retornado quando dados necessários para o processamento da solicitação não foram passados corretamente ou incompletos.
- ```404``` -> na maioria das vezes é retornado quando o cliente solicita um serviço que não existe ou uma solicitação de busca no banco de dados que não retorna nenhum dado.
- ```500``` -> ocorre quando se tem um erro interno com relação ao servidor, mais precisamente por parte do desenvolvimento podendo ser um erro de programação no tratamento de dados que é feito da maneira errada até mesmo um erro de lógica 
----

**Verbos e Métodos**: Os verbos são os tipos de ações que o cliente usa pra realizar diferentes tipo de solicitação para o servidor, tendo os métodos como uma maneira de formalizar as solicitações que iremos fazer, tendo destaque para os métodos:

- ```GET``` -> usado pelo cliente pra solicitar algo do servidor
- ```POST``` -> usado pra enviar dados através para o servidor
- ```PUT``` -> em um cenário que um determinado dado já foi previamente adicionado através  do método ```GET```, o método ```PUT``` faz o papel de editar esse dado com novas informações quando chamado
- ```DELETE``` -> no cenário que tendo uma base de dados, quando chamado iremos deletar um dado ou conjunto que faz parte, baseados no tipo de informações que foi passado na chamada do método
----

**Path/Url**: 
- Uma url quando acessada por um cliente possui diversas opções para que seja passada valores, esses valores podem definir a forma que queremos obter dados, chamados de parâmetros são essenciais em  casos onde trabalhamos com diversos
 tipos e formas de consulta, como uma pesquisa que gostaríamos de realizar em base dados baseado onde se tem múltiplas filtros, assim também como definir um retorno de valores de forma ordenada por alguma regra
----

**Body**:
- é um corpo de informações que enviamos na utilização de algum verbo/método http, como por exemplo quando chamado o método ```POST```, obrigatoriamente devemos passar dados onde esse dado vem passados dentro do body
----

**Header**: 
- o cabeçalho é modo de passagem de informações adicionais especificas, podendo descrever os tipo de conexão que queremos estabelecer entre cliente e servidor, como também informações do tipo de conteúdo que está sendo enviado, podendo conter chaves necessárias de autenticação em caso da conexão ter controle de acesso
----

**Serialização**: 
- é a forma de como transformamos o estado de determinado dado para que ele seja compartilhado com outro serviço, e nesse serviço ser possível voltar ao seu estado original, na maioria das vezes um objeto é transformado em bytes para ser utilizado posteriormente  em seu estado original
----

*Injeção de dependência (Transient, Scoped e Singleton)*
serviços
---
**Injeção de dependência** Com a Injeção de dependência o processo de desenvolvimento se torna mais dinâmico, uma vez que vamos se preocupar apenas no desenvolvimento da implementação de nossas classes e não mais nas classes que utilizam meus métodos, como vemos [nesse](https://github.com/J0a0Paul0Jp/http-termos/blob/2275a257dd38fa9687254de477476e3e201ad598/codigos/c%23/Injecao/sem_injecao/Controller.cs#L5) exemplo verificamos que existe uma grande dependência que o controller possui de ```AtendenteService```, dificultando em muitos casos a implementação de testes específicos

----
- ```Singleton``` -> quando uma classe instanciada, o objeto resultante passa a ser o mesmo em todas as operações que forem executada, durante toda a vida útil da aplicação [injeção de dependência no código](https://github.com/J0a0Paul0Jp/http-termos/blob/2275a257dd38fa9687254de477476e3e201ad598/codigos/c%23/Injecao/com_injecao/Program.cs#L9)
- ```Transient``` -> uma instancia sempre será criada quando a classe for chamada, assim sempre será um objeto diferente da mesma classe a cada vez que seu serviço for chamada 
[injeção de dependência no código](https://github.com/J0a0Paul0Jp/http-termos/blob/2275a257dd38fa9687254de477476e3e201ad598/codigos/c%23/Injecao/com_injecao/Program.cs#L10)
----
- ```Scope``` -> são criadas instancias a cada solicitação de um cliente, sendo muito usado em aplicações web

*DDD*
---
Domain Driven Design
- ```Linguagem Ubíqua``` -> linguagem do dia-a-dia presente no contexto do qual fazemos parte do processo
- ```Bounded Contexts```-> história das relações que podem ocorrer durante o processo de uso, delimitando um contexto da aplicação própria 
- ```Context Map``` -> mapeamento dos ```Bounded Contexts```, exibe as relaçoes que existe em cada entidade do domínio e em que contexto ocorre o relacionamento

**Service**
- Constituem a lógica dos negócios, trabalham com os fluxos através das entidades como também os value objects, assim fazem o papel de ligar dados que constituem a aplicação com diversas entidades como acessar um banco de dados onde é requisitado um dado para a realização de uma tarefa
----

**Value Objects** 
- objetos imutáveis, possui um conjunto de atributos, onde não pode ter seus atributos mudados depois de intanciaodos

Pessoa pessoa=construtor("Nome","SobreNome","Cpf")
----

**Aggregate Objects - Entidades**
- Conjunto de entidades que fazem parte de um
mesmo contexto, sendo entidades os que possui validadores, métodos, e propriedades
----

**DTO - Data Transfer Object** 
- Representa uma classe de transferência de dados entre diferentes camadas da aplicação de forma mais segura, podem ser um meio de export apenas dados que seja conveniente a partir de outra objeto, como por exemplo se um objeto possui o campo CPF e queremos que ele não seja exposto podemos usar uma classe DTO, para não export o atributo CPF, assim abstraindo funções que outras entidades não tem obrigações de conhecer

