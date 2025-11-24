using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRpgEtec.Services.PersonagemHabilidades
{
    public class PersonagemHabilidadeService: Request
    {
        private readonly Request _request = null;

        private const string _apiUrlBase = "https://rpgapi3ai2025.azurewebsites.net/PersonagemHabilidade";
        private string _token;

        public PersonagemHabilidadeService(string token)
        {
            _request = new Request();
            _token = token;
        }
    }
}
