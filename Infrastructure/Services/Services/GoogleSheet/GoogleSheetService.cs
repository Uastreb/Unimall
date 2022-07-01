using Core.Interfaces.Services;
using Core.ServiceModels.GoogleSheets;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Microsoft.Extensions.Options;
using Shared.Configurations;
using System.Text;

using Data = Google.Apis.Sheets.v4.Data;

namespace Services.GoogleSheet
{
    //Неплохая статья для работы с сервисом гугл, https://code-maze.com/google-sheets-api-with-net-core/
    public class GoogleSheetsService : IGoogleSheetsService
    {
        private string[] _scopes = { SheetsService.Scope.Spreadsheets }; // Change this if you're accessing Drive or Docs

        private readonly SheetsService _sheetsService;
        private readonly GoogleSheetsConfiguration _googleSheetsConfig;

        public GoogleSheetsService(IOptions<GoogleSheetsConfiguration> googleSheetsConfig)
        {
            _googleSheetsConfig = googleSheetsConfig.Value;

            GoogleCredential credential;

            // Put your credentials json file in the root of the solution and make sure copy to output dir property is set to always copy 
            credential = GoogleCredential.FromJson(_googleSheetsConfig.SettingsJSON.GetJson());

            // Create Google Sheets API service.
            _sheetsService = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = googleSheetsConfig.Value.ApplicationName
            });
        }

        public async Task<IList<GoogleSheetProduct>> ReadProductsAsync()
        {
            var range = $"Лист1!A:M";
            var _googleSheetValues = _sheetsService.Spreadsheets.Values;
            var request = _googleSheetValues.Get(_googleSheetsConfig.SpeadsheetId, range);
            var response = await request.ExecuteAsync();
            var values = response.Values;

            var products = MapFromRangeData(values);

            return products;
        }

        public IList<GoogleSheetProduct> ReadProducts()
        {
            var range = $"Лист1!A:M";
            var _googleSheetValues = _sheetsService.Spreadsheets.Values;
            var request = _googleSheetValues.Get(_googleSheetsConfig.SpeadsheetId, range);
            var response = request.Execute();
            var values = response.Values;

            var products = MapFromRangeData(values);

            return products;
        }

        //public async Task<string> WriteSheetsAsync(IList<IList<object>> sheets, int startRow)
        //{
        //    var range = $"{_googleSheetsConfig.PageName}!A{startRow}:Y";
        //    string valueInputOption = "USER_ENTERED";

        //    // The new values to apply to the spreadsheet.
        //    List<Data.ValueRange> updateData = new List<Data.ValueRange>();
        //    var dataValueRange = new Data.ValueRange();
        //    dataValueRange.Range = range;
        //    dataValueRange.Values = sheets;
        //    updateData.Add(dataValueRange);

        //    Data.BatchUpdateValuesRequest requestBody = new Data.BatchUpdateValuesRequest();
        //    requestBody.ValueInputOption = valueInputOption;
        //    requestBody.Data = updateData;

        //    var request = _sheetsService.Spreadsheets.Values.BatchUpdate(requestBody, _googleSheetsConfig.SpeadsheetId);

        //    Data.BatchUpdateValuesResponse response = await request.ExecuteAsync();

        //    return JsonConvert.SerializeObject(response);
        //}

        //public string WriteSheets(IList<IList<object>> sheets, int startRow)
        //{
        //    var range = $"{_googleSheetsConfig.PageName}!A{startRow}:Y";
        //    string valueInputOption = "USER_ENTERED";

        //    // The new values to apply to the spreadsheet.
        //    List<Data.ValueRange> updateData = new List<Data.ValueRange>();
        //    var dataValueRange = new Data.ValueRange();
        //    dataValueRange.Range = range;
        //    dataValueRange.Values = sheets;
        //    updateData.Add(dataValueRange);

        //    Data.BatchUpdateValuesRequest requestBody = new Data.BatchUpdateValuesRequest();
        //    requestBody.ValueInputOption = valueInputOption;
        //    requestBody.Data = updateData;

        //    var request = _sheetsService.Spreadsheets.Values.BatchUpdate(requestBody, _googleSheetsConfig.SpeadsheetId);

        //    Data.BatchUpdateValuesResponse response = request.Execute();

        //    return JsonConvert.SerializeObject(response);
        //}

        private List<GoogleSheetProduct> MapFromRangeData(IList<IList<object>> values)
        {
            var products = new List<GoogleSheetProduct>();
            foreach (var value in values.Where(x => x.Count >= 8))
            {
                if (!Uri.TryCreate(value[0].ToString(), UriKind.Absolute, out var uri))
                {
                    continue;
                }

                double.TryParse(value[7].ToString(), out var cost);
                int.TryParse(value[4].ToString(), out var count);

                GoogleSheetProduct product = new()
                {
                    Link = uri,
                    Name = value[2].ToString(),
                    Count = count,
                    Cost = cost,
                };

                products.Add(product);
            }

            return products;
        }
    }
}
