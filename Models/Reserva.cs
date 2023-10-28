namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Reserva(Suite suite) 
        {
            this.Suite = suite;
   
        }
                public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (Suite != null && Suite.CapacidadeSuite < hospedes.Count)
            {
                Hospedes = hospedes;
            }
            
            {
                throw new ArgumentException($"A suíte atualmente cadastrada não possui capacidade para esta quantidade de hóspedes.");
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*{}
             
            if (Hospedes == null)

             {
                return 0;
            }

            return Hospedes.Count;
        }


        }
         

        public decimal CalcularValorDiaria()
        {
             if (Suite == null)
            {
                return 0;
            }

            decimal valorTotal;
            valorTotal = Suite.ValorDiaria * DiasReservados;
            if (DiasReservados >= 10)
            {
                valorTotal *= 0.8M;
            }
            return valorTotal;
        }
    }

