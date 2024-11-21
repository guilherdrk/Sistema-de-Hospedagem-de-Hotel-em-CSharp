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
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Capacidade menor que o número de hóspedes");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {

            int quantidadeHospedes = Hospedes.Count;
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {

            decimal calculoValorDiaria = DiasReservados * Suite.ValorDiaria;
            decimal valor = calculoValorDiaria;


            if (DiasReservados >= 10)
            {
                decimal calculoDaPorcentagem = (calculoValorDiaria/10);
                valor = calculoValorDiaria - (calculoDaPorcentagem);
                return valor;
            }

            return valor;
        }
    }
}