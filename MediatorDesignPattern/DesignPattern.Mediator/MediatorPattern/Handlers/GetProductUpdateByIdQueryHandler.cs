using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPattern.Queries;
using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class GetProductUpdateByIdQueryHandler : IRequestHandler<GetProductUpdateByIDQuery, UpdateProductByIDQueryResult>
    {
        private readonly Context _context;

        public GetProductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<UpdateProductByIDQueryResult> Handle(GetProductUpdateByIDQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Products.FindAsync(request.Id);

            return new UpdateProductByIDQueryResult()
            {
                ProductID=value.ProductID,
                ProductName=value.ProductName,
                ProductStock=value.ProductStock,
                ProductStockType=value.ProductStockType,
                ProductCategory=value.ProductCategory,
                ProductPrice=value.ProductPrice,
            };
        }
    }
}
