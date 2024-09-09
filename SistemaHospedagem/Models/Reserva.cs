namespace SistemaHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite SuiteReservada { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() 
        {
            Hospedes = new List<Pessoa>();
        }

        public void CadastrarSuite(Suite suite)
        {
            SuiteReservada = suite;
        }

        public void AdicionarHospede(Pessoa hospede)
        {
            if (Hospedes.Count >= SuiteReservada.Capacidade)
            {
                throw new Exception("A suíte não comporta essa quantidade de hóspedes.");
            }
            Hospedes.Add(hospede);
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorTotal = DiasReservados * SuiteReservada.ValorDiaria;
            if (DiasReservados >= 10)
            {
                valorTotal *= 0.9m; // Desconto de 10%
            }
            return valorTotal;
        }
    }
}
