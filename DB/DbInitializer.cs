using Domain;
using System.Linq;

namespace DB
{
    public class DbInitializer
    {
        public static void Initialize(WeChipContext context)
        {
            context.Database.EnsureCreated();

            //Verifica se já não esta Carreda a tabela
            if (context.Produtos.Any())
                return;

            var produtos = new Produto[]
            {
                new Produto{Id=15,Descricao="Mouse",tipo=Tipo.Hardware,Preco=20},
                new Produto{Id=106,Descricao="Teclado",tipo=Tipo.Hardware,Preco=30},
                new Produto{Id=200,Descricao="Monitor 17’",tipo=Tipo.Hardware,Preco=350},
                new Produto{Id=211,Descricao="Pen Drive 8 GB",tipo=Tipo.Hardware,Preco=30},
                new Produto{Id=314,Descricao="Pen Drive 16 GB",tipo=Tipo.Hardware,Preco=50},
                new Produto{Id=459,Descricao="AVAST",tipo=Tipo.Software,Preco=199.99M},
                new Produto{Id=1104,Descricao="Pacote Office",tipo=Tipo.Software,Preco=499},
                new Produto{Id=1108,Descricao="Spotify (3 meses)",tipo=Tipo.Software,Preco=45.50M},
                new Produto{Id=1107,Descricao="Netilix (1 mês)",tipo=Tipo.Software,Preco=19.90M}
            };

            foreach (Produto produto in produtos)
                context.Produtos.Add(produto);

            var status = new Status[]
            {
                new Status{Id=1,Descricao="Nome Livre",Finaliza=false,Contabiliza=false },
                new Status{Id=7,Descricao="Não deseja ser contatado",Finaliza=true,Contabiliza=false},
                new Status{Id=9,Descricao="Cliente Aceitou Oferta",Finaliza=true,Contabiliza=true},
                new Status{Id=15,Descricao="Caiu a ligação",Finaliza=false,Contabiliza=false},
                new Status{Id=19,Descricao="Viajou",Finaliza=false,Contabiliza=false},
                new Status{Id=21,Descricao="Falecido",Finaliza=true,Contabiliza=false}
            };

            foreach (Status status1 in status)
                context.Status.Add(status1);

            context.SaveChanges();
        }
    }
}
