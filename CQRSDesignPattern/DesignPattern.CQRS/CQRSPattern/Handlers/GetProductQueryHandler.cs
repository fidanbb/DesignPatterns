using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handler()
        {
            var values = _context.Products.Select(m => new GetProductQueryResult
            {
                ProductId = m.ProductId,
                Name = m.Name,
                Price = m.Price,
                Stock = m.Stock
            }).ToList();

            return values;
        }
    }
}
