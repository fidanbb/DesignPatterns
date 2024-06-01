using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPattern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class RemoveProductCommanfHandler : IRequestHandler<RemoveProductCommand>
    {
        private readonly Context _context;

        public RemoveProductCommanfHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);

            _context.Products.Remove(values);

            await  _context.SaveChangesAsync();
        }
    }
}
