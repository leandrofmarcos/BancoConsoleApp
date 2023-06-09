# Projeto Conta Bancária

Este projeto implementa uma classe `ContaBancaria` em C# que representa uma conta bancária com funcionalidades de saldo, saque, depósito e extrato. O objetivo é exemplificar o uso de testes unitários para garantir a qualidade do código e facilitar a realização de testes de regressão.

## Funcionalidades

A classe `ContaBancaria` possui os seguintes métodos:

- `Sacar`: realiza um saque na conta bancária, subtraindo o valor do saldo.
- `Depositar`: realiza um depósito na conta bancária, adicionando o valor ao saldo.
- `Extrato`: exibe o extrato das operações realizadas na conta bancária, mostrando as transações e o saldo atual.

## Testes Funcionais

Os testes funcionais são responsáveis por verificar o comportamento correto do sistema em relação às regras de negócio. No caso deste projeto, os testes funcionais se concentram na classe `Program` e são executados via linha de comando. Os testes incluem as seguintes verificações:

- Verificar o saldo atual da conta.
- Realizar um saque e verificar se o saldo foi atualizado corretamente.
- Realizar um depósito e verificar se o saldo foi atualizado corretamente.
- Exibir o extrato da conta e verificar se as operações e o saldo estão corretos.

## Testes Unitários

Os testes unitários são responsáveis por testar cada unidade isoladamente, verificando se cada método da classe `ContaBancaria` funciona corretamente. Os testes unitários são executados utilizando o framework de testes NUnit. Os testes unitários aplicados neste projeto incluem:

- Testar o saldo inicial da conta ao criar uma instância.
- Testar se é possível sacar um valor maior que o saldo disponível.
- Testar se é possível sacar um valor igual ao saldo disponível.
- Testar se é possível sacar um valor menor que o saldo disponível.
- Testar se é possível depositar um valor maior que zero.
- Testar se é possível depositar um valor igual a zero.
- Testar se é possível obter o extrato da conta.
- Testar se o extrato está correto após um saque.
- Testar se o extrato está correto após um depósito.
- Testar se o saldo é atualizado corretamente após um saque.
- Testar se o saldo é atualizado corretamente após um depósito.

## Vantagens dos Testes Unitários

Os testes unitários têm várias vantagens, incluindo:

- Detectar erros e falhas em unidades individuais de código.
- Facilitar a identificação e correção de problemas antes que eles se propaguem para outras partes do sistema.
- Permitir a refatoração do código com segurança, garantindo que as alterações não introduzam regressões.
- Melhorar a confiabilidade e a estabilidade do software.
- Acelerar o processo de desenvolvimento, uma vez que problemas são detectados e corrigidos precocemente.

Ao manter um conjunto abrangente de testes unitários, é possível realizar testes de regressão de forma eficiente, garantindo que as alterações no código não afetem negativamente as funcionalidades existentes. Isso proporciona mais confiança na integridade do software e agiliza o ciclo de desenvolvimento.

## Executando os Testes

Para executar os testes unitários, certifique-se de ter o framework NUnit instalado. Em seguida, siga estes passos:

1. Abra o projeto no Visual Studio ou em outra IDE compatível.
2. Certifique-se de ter o NUnit instalado.
3. Na janela de Test Explorer, selecione os testes que deseja executar.
4. Clique com o botão direito do mouse e escolha "Run Selected Tests" para executar os testes selecionados.
5. Verifique a saída da execução dos testes para ver os resultados.

Certifique-se de que todos os testes passem com êxito antes de prosseguir com alterações ou atualizações no código.

## Conclusão

Este projeto demonstra a importância dos testes unitários na verificação do comportamento correto de uma classe, destacando a vantagem de manter um conjunto abrangente de testes unitários para facilitar os testes de regressão e garantir a qualidade do software. Através dos testes funcionais e dos testes unitários, é possível ter mais confiança na integridade e no desempenho do sistema.
