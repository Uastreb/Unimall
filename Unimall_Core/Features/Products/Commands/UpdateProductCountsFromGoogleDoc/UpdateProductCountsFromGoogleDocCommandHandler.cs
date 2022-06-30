using MediatR;
using Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Features.Products.Commands.UpdateProductCountsFromGoogleDoc
{
    public class UpdateProductCountsFromGoogleDocCommandHandler : IRequestHandler<UpdateProductCountsFromGoogleDocCommand, IResult>
    {
        public UpdateProductCountsFromGoogleDocCommandHandler()
        {
            
        }

        public async Task<IResult> Handle(UpdateProductCountsFromGoogleDocCommand query, CancellationToken cancellationToken)
        {
            

            return await Result.SuccessAsync();
        }
    }
}
