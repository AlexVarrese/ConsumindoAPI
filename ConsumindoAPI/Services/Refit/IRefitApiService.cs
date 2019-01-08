using System;
using System.Threading.Tasks;
using ConsumindoAPI.Model;
using Refit;

namespace ConsumindoAPI.Services
{
    public interface IRefitApiService
    {
        [Get("/person")]
        Task<Usuario> GetUsuario();
    }
}
