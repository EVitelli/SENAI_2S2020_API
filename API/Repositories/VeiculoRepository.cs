using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class VeiculoRepository
    {
        private static List<Veiculos> veiculos;
        private static int contador = 1;

        public VeiculoRepository()
        {
            if(veiculos == null)
            {
                veiculos = new List<Veiculos>
                {
                    new Veiculos
                    {
                        Id = 1,
                        Modelo = "Toro",
                        Marca = "Fiat"
                    },
                    new Veiculos
                    {
                        Id = 2,
                        Marca = "Chevrolet",
                        Modelo = "Onix"
                    }
                };
            }
        }

        public List<Veiculos> getAll()
        {
            return veiculos;
        }

        public void add(Veiculos veiculo)
        {
            contador++;
            veiculo.Id = contador;
            veiculos.Add(veiculo);
        }
    }
}
