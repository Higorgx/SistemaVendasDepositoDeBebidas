# Sistema de Vendas para Deposito de Bebidas
## Descrição
sistema de vendas para depósito de bebidas integrado com controle de fornecedores, rastreamento de carga, Controle de estoque e sistema leva e traz. 

## Banco de dados

### Credenciais de banco de Dados

* mysql
* 127.0.0.1
* root
* não tem senha
* sys_vendas

### Padrão de desenvolvimento
Nosso banco de dados utiliza o padrão de projeto DAO, em resumo, para cada entidade no banco de dados deve haver um modelo como o em Modelos/Usuario.cs e uma camada correspondente que abstrai a comunicação com o banco de dados como a em DAO/UsuarioDao. Sendo assim Não se pode simplesmente sair usando sql em um forme, isso quebraria o padrão.

### Como implementar o padrão DAO
Se você quer criar uma nova entidade para utilizar em nosso banco basta seguir o exemplo citado anteriormente apenas adicionando as alterações necessárias e melhorias conforme o gosto ou necessidade de cada um. Os códigos estão quase que 100% legendados então acredito que será fácil criar novas entidades. 

### Como Utilizar uma classe DAO
Exemplo feito com entidade de usuário simples: 

* Resetar uma tabela... Ato recomendado sempre para evitar dor de cabeça
```
UsuarioDao.resetarTabela(); 
```
* Criar uma tabela
```
UsuarioDao.criarTabela(); 
```
* Salvando 2 usuários 
```
// construtor de Usuario: (nome ou login, senha)
UsuarioDao.salvar(new Usuario("Ostavio", "fsdgsdsgs"));
UsuarioDao.salvar(new Usuario("Allan", "fsdgsdsgs")); 
```
* Obtendo todos os registros da tabela
```
List<Usuario> lista = UsuarioDao.retornarTudo();
```
* Buscando por um usuário, observe que nos parametros você deve passar as condições como em sql
```
Usuario usr = UsuarioDao.buscar("id = 1 AND nome = 'lucas'");
```
* deletando um usuário, observe que nos parametros você deve passar as condições como em sql
```
UsuarioDao.deletar($"id = 1");
```

### dúvidas
Havendo dúvidas contatar o membro do grupo chamado Thiago Piassi Bonfogo.
