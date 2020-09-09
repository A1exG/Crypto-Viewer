using CryptoViewer.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CryptoViewer.Library.API
{
    public interface ICryptoEndpoint
    {
        Task<List<CurrencyLimit>> GetAll();
    }
}