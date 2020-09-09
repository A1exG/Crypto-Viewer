using Caliburn.Micro;
using CryptoViewer.Library.API;
using System;
using System.Threading.Tasks;

namespace CryptoViewer.UI.ViewModels
{
    public class CryptoViewModel : Screen
    {
        private IAPIHelper _apiHelper;
        private CryptoEndpoint _cryptoEndpoint;

        public CryptoViewModel(IAPIHelper apiHelper, CryptoEndpoint cryptoEndpoint)
        {
            _apiHelper = apiHelper;
            _cryptoEndpoint = cryptoEndpoint;
        }

        protected override async void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            try
            {
                await LoadCrypto();
            }
            catch (Exception)
            {
                TryClose();
            }

        }

        public async Task LoadCrypto()
        {
            try
            {
                var cryptoList = await _cryptoEndpoint.GetAll();
            }
            catch (Exception ex)
            {
                var massage = ex.Message;
            }
        }
    }
}
