namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Implementado MMSJR           
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            // Implementado MMSJR
            else
            {
                throw new ArgumentException("Quantidade de hóspedes maior que a Capacidade da Suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Implementado MMSJR
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Implementado MMSJR
            decimal valor = DiasReservados * Suite.ValorDiaria;
            decimal desconto = 0.90M;

      // Implementado MMSJR
      if (DiasReservados >= 10)
            {
                valor = valor * desconto;
            }

            return valor;
        }
    }
}