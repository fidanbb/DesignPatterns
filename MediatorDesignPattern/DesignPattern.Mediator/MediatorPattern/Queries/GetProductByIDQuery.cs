using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Queries
{
    public class GetProductByIDQuery:IRequest<GetProductByIDQueryResult>
    {
        public int ProductID { get; set; }

        public GetProductByIDQuery(int productID)
        {
            ProductID = productID;
        }
    }
}
