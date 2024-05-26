using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductUpdateByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateQueryResult Handler(GetProductUpdateByIdQuery query)
        {
            var values = _context.Set<Product>().Find(query.Id);

            return new GetProductUpdateQueryResult
            {
                Name = values.Name,
                Price = values.Price,
                ProductId = values.ProductId,
                Stock = values.Stock,
                Description = values.Description
            };
        }
    }
}
