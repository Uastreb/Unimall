using Core.ServiceModels.GoogleSheets;

namespace Core.Interfaces.Services
{
    public interface IGoogleSheetsService
    {
        Task<IList<GoogleSheetProduct>> ReadProductsAsync();
        IList<GoogleSheetProduct> ReadProducts();
    }
}
