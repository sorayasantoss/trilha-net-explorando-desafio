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
            //Implementado
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                //Implementado
                throw new ArgumentException("A quantidade de hóspedes não pode ser maior do que a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            //Implementado
            int quantidadeHospedes = Hospedes.Count;
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            //Implementado
            decimal valor = DiasReservados*Suite.ValorDiaria;

            //Implementado
            if (DiasReservados => 10)
            {
                valor = valor - (valor*0.1);
                return valor;
            }
            else
	        {
                return valor;
	        }
            
        }
    }
}