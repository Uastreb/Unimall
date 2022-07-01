using Core.Interfaces.Data.UOW;
using Core.Interfaces.Services;
using MediatR;
using Shared.Entities;
using Shared.Wrapper;

namespace Core.Features.Products.Commands.UpdateProductCountsFromGoogleDoc
{
    public class UpdateProductCountsFromGoogleDocCommandHandler : IRequestHandler<UpdateProductCountsFromGoogleDocCommand, IResult>
    {
        private readonly IGoogleSheetsService _googleSheetsService;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateProductCountsFromGoogleDocCommandHandler(IGoogleSheetsService googleSheetsService, IUnitOfWork unitOfWork)
        {
            _googleSheetsService = googleSheetsService;
            _unitOfWork = unitOfWork;
        }

        public async Task<IResult> Handle(UpdateProductCountsFromGoogleDocCommand query, CancellationToken cancellationToken)
        {
            var sheetProducts = await _googleSheetsService.ReadProductsAsync();
            var errors = new List<string>();

            foreach (var sheetProduct in sheetProducts)
            {
                var productSeoName = sheetProduct.Link.Segments.Last();
                var seoUrl = await _unitOfWork.Repository<OcSeoUrl>().GetByPredicateAsync(x => x.Keyword == productSeoName);
                var productSeoUrl = seoUrl.FirstOrDefault();

                if (productSeoUrl == default || !productSeoUrl.Query.StartsWith("product_id="))
                {
                    errors.Add($"В таблице некорректный урл: {productSeoName}");

                    continue;
                }

                var productId = int.Parse(productSeoUrl.Query.Replace("product_id=", string.Empty));
                var product = await _unitOfWork.Repository<OcProduct>().GetByIdAsync(productId);

                if (product.Quantity == sheetProduct.Count)
                {
                    continue;
                }

                product.Quantity = sheetProduct.Count;
                await _unitOfWork.Repository<OcProduct>().UpdateAsync(product);
            }

            await _unitOfWork.Commit(cancellationToken);

            if (errors.Any())
            {
                return await Result.FailAsync(errors);
            }

            return await Result.SuccessAsync();
        }
    }
}
