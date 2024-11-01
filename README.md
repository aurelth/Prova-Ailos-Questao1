Sistema de Cadastro de Contas Bancárias: 
Este programa, desenvolvido em .NET 6, simula o sistema de cadastro e gerenciamento de contas bancárias para uma instituição financeira. Ele permite que o usuário cadastre novas contas, realize depósitos e saques, e visualize o saldo atualizado após cada operação.

Funcionalidades
Cadastro de Conta Bancária:
Solicita o número da conta, o nome do titular e a possibilidade de um depósito inicial.
O depósito inicial é opcional; caso não seja feito, o saldo começa em zero.

Operações de Conta:

Depósito: Permite ao usuário inserir um valor para aumentar o saldo da conta.
Saque: Permite ao usuário sacar um valor da conta, aplicando uma taxa de saque de $3.50.
Observação: A conta pode ficar com saldo negativo se o saldo não for suficiente para cobrir o valor do saque e a taxa.

Cadastro de Múltiplas Contas:
Ao final de cada operação, o programa pergunta se o usuário deseja cadastrar uma nova conta e, caso positivo, reinicia o processo.

Exemplos de Uso
Exemplo 1:
Entre o número da conta: 5447
Entre o titular da conta: Milton Gonçalves
Haverá depósito inicial (s/n)? s
Entre o valor de depósito inicial: 350.00

Dados da conta:
Conta 5447, Titular: Milton Gonçalves, Saldo: $ 350.00

Entre um valor para depósito: 200.00
Dados da conta atualizados:
Conta 5447, Titular: Milton Gonçalves, Saldo: $ 550.00

Entre um valor para saque: 199.00
Dados da conta atualizados:
Conta 5447, Titular: Milton Gonçalves, Saldo: $ 347.50

Exemplo 2:
Entre o número da conta: 5139
Entre o titular da conta: Elza Soares
Haverá depósito inicial (s/n)? n

Dados da conta:
Conta 5139, Titular: Elza Soares, Saldo: $ 0.00

Entre um valor para depósito: 300.00
Dados da conta atualizados:
Conta 5139, Titular: Elza Soares, Saldo: $ 300.00

Entre um valor para saque: 298.00
Dados da conta atualizados:
Conta 5139, Titular: Elza Soares, Saldo: $ -1.50

Tecnologias e Padrões
.NET 6: Utiliza a versão mais recente do framework .NET com a estrutura de código simplificada.
Boas práticas de programação: Encapsulamento de dados, controle de acesso e validações de entrada.
Configuração de Cultura: Usa CultureInfo("en-US") para garantir que o separador decimal seja o ponto (.), tanto em entradas quanto em saídas.

Como Executar
Clone o repositório: git clone https://github.com/seu-usuario/nome-do-repositorio.git
Navegue até a pasta do projeto: cd nome-do-repositorio
Compile e execute o projeto: dotnet run

Observações
O código foi implementado utilizando uma estrutura de código simplificada do .NET 6 e segue padrões de encapsulamento para proteger o saldo e o número da conta contra alterações indesejadas.
