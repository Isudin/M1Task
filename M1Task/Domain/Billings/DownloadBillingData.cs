using M1Task.Domain.ApiConnection;
using M1Task.Domain.Model;
using M1Task.Infrastructure;
using System.Text;
using System.Text.RegularExpressions;

namespace M1Task.Domain.Billings
{
    internal class DownloadBillingData
    {
        private static readonly Regex regex = new("[0-9]*-[0-9]*");

        internal async static Task<Response> DownloadData()
        {
            Console.WriteLine("Enter order IDs range (e.g. 12345-12500) for which billings should be downloaded.");
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                return new Response($"ID not entered");

            if (!regex.IsMatch(input))
                return new Response($"IDs does not have the correct format");

            int[] ids = input.Split('-').Select(x => int.Parse(x)).OrderBy(x => x).ToArray();
            if (ids.Length == 0)
                return new Response($"No order has been found in entered IDs range");

            OrderTable[] orders = AllegroContext.Context.OrderTable.Where(x => x.Id >= ids[0] && x.Id <= ids[1]).ToArray();
            if (orders.Length == 0)
                return new Response($"No order has been found in entered IDs range");

            List<Response> responses = [];
            foreach (OrderTable order in orders)
                responses.Add(await DownloadBilling(order.OrderId));

            if (responses.Count == 1)
                return responses.First();

            StringBuilder sb = new();
            foreach (Response response in responses)
                sb.AppendLine(response.Message);

            return new Response(sb.ToString());
        }

        private async static Task<Response> DownloadBilling(string orderId)
        {
            BillingRequests requests = new(orderId);
            BillingsManagement billingsManagement = new(requests, AllegroContext.Context);
            return await billingsManagement.DownloadBillingsToDatabase();
        }
    }
}
