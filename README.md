# Sistema de Hospedagem

Este é um projeto desenvolvido como parte de um desafio para a trilha .NET da DIO. O objetivo do projeto é criar um sistema de hospedagem para gerenciar reservas em um hotel.

## Descrição

O sistema de hospedagem permite que você crie reservas para hóspedes em suítes. Ele calcula o valor total da reserva com base no número de dias e oferece um desconto de 10% para reservas de mais de 10 dias.

### Funcionalidades

- **Cadastro de Hóspedes:** Utiliza a classe `Pessoa` para representar os hóspedes.
- **Cadastro de Suítes:** Utiliza a classe `Suíte` para representar as suítes disponíveis.
- **Gerenciamento de Reservas:** A classe `Reserva` gerencia as reservas, garantindo que o número de hóspedes não exceda a capacidade da suíte.
- **Cálculo de Diárias:** Calcula o valor total da diária, aplicando um desconto de 10% para reservas com duração igual ou superior a 10 dias.

## Regras e Validações

- **Capacidade da Suíte:** Não é possível reservar uma suíte com capacidade menor do que a quantidade de hóspedes.
- **Desconto:** Reservas de 10 dias ou mais recebem um desconto de 10% no valor total.

## Tecnologias Utilizadas

- **C#**
- **.NET**
- **Git & GitHub**

## Como Executar o Projeto

1. Clone este repositório:
   ```bash
   git clone https://github.com/arnoldofreire/sistema-hospedagem-dotnet.git
