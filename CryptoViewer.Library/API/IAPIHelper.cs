using System.Net.Http;

namespace CryptoViewer.Library.API
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; }
    }
}