using M1Task.Domain.ApiConnection;
using M1Task.Domain.ApiConnection.Model;
using M1Task.Domain.Model;
using M1Task.Infrastructure;
using Mapster;

namespace M1Task.Domain.Billings
{
    internal class BillingsManagement
    {
        private readonly BillingRequests _billingRequests;
        private readonly AllegroContext _allegroContext;

        public BillingsManagement(BillingRequests billingRequests, AllegroContext allegroContext)
        {
            _billingRequests = billingRequests;
            _allegroContext = allegroContext;
        }

        internal async Task<Response> DownloadBillingsToDatabase()
        {
            if (string.IsNullOrEmpty(Authorization.Authorization.accessToken))
            {
                var auth = new Authorization.Authorization();
                var response = await auth.Authorize();
                if (response.IsError)
                    return response;
            }

            var billings = await _billingRequests.GetBillingEntries();
            if (billings == null)
                return new Response(_billingRequests.Error!);

            if (billings.BillingEntriesArray == null || billings.BillingEntriesArray.Length == 0)
                return new Response("No billings has been downloaded");

            return await SaveBillings(billings);
        }

        private async Task<Response> SaveBillings(BillingEntries billingEntries)
        {
            try
            {
                var billings = billingEntries.Adapt<Billing>();
                _allegroContext.Billings.Add(billings);
                int savedEntities = await _allegroContext.SaveChangesAsync();
                return new Response($"Successfully downloaded and saved {savedEntities} billings to database.");
            }
            catch (Exception ex)
            {
                return new Response($"{ex.Message}{Environment.NewLine}{ex.StackTrace}", true);
            }
        }
    }
}
