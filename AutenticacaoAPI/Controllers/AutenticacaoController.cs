using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutenticacaoAPI.ResponseModels;
using AutenticacaoAPI.RequestModels;
using AutenticacaoAPI.Models;

namespace AutenticacaoAPI.Controllers
{
    [Route("AutenticacaoApi/v1/[controller]")]
    public class AutenticacaoController : Controller
    {
        [HttpPost]
        public async Task<AutenticacaoResponsePost> Post([FromBody]AutenticacaoRequestPost request)
        {
            AutenticacaoResponsePost result = new AutenticacaoResponsePost();

            if (request.Email == "keppel@iec.com.br" && request.Pass == "123456")
            {
                AutenticacaoModel autenticacao = new AutenticacaoModel
                {
                    Token = Guid.NewGuid().ToString(),
                    DataCriacao = DateTime.Now
                };
                result.StatusCode = 200;
                result.Autenticacao = autenticacao;
            }
            else
                result.StatusCode = 204;
            return result;
        }

        
        [HttpPost("ValidaAutenticacao")]
        public async Task<bool> ValidaAutenticacao([FromBody]ValidaAutenticacaoRequestPost request)
        {
            return true;
        }
        
    }
}
