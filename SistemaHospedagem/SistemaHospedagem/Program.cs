using SistemaHospedagem.Models;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Criando uma suíte e uma reserva
        Suite suite = new Suite("Deluxe", 2, 150.00m);
        Reserva reserva = new Reserva();
        
        // Cadastrando a suíte na reserva
        reserva.CadastrarSuite(suite);
        
        // Adicionando hóspedes
        reserva.AdicionarHospede(new Pessoa("Arnoldo", "Freire"));
        reserva.AdicionarHospede(new Pessoa("Carlos", "Silva"));

        // Definindo a quantidade de dias reservados
        reserva.DiasReservados = 10;

        // Exibindo a quantidade de hóspedes e o valor da diária
        Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor Total da Diária: {reserva.CalcularValorDiaria():F2}");  // Formatação com 2 casas decimais
    }
}
