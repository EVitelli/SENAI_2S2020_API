using App2.Models;
using App2.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace App2.ViewModels
{
    public class VeiculosViewModel: BaseViewModel
    {
        private List<Veiculos> _veiculos;

        public List<Veiculos> veiculos
        {
            get { return _veiculos; }
            set 
            {
                _veiculos = value;
                OnPropertyChanged();
            }
        }

        public VeiculosViewModel()
        {
            veiculos = new List<Veiculos>();

            getVeiculos();
        }

        private void getVeiculos()
        {
            try
            {
                HttpClient client = Utils.getClient;

                HttpResponseMessage response = client.GetAsync("veiculos").Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    veiculos = JsonConvert.DeserializeObject<List<Veiculos>>(json);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
