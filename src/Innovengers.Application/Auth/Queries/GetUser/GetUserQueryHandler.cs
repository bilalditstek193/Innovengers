using MediatR;

namespace Innovengers.Application
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, Unit>
    {
        public Task<Unit> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
