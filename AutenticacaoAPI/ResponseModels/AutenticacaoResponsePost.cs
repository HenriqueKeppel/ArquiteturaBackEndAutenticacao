using System;
using AutenticacaoAPI.Models;

namespace AutenticacaoAPI.ResponseModels
{
    public class AutenticacaoResponsePost
    {
        public AutenticacaoModel Autenticacao {get;set;}
        public int StatusCode {get;set;}
    }
}