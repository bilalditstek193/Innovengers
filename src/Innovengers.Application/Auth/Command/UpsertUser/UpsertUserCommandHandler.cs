using MediatR;

namespace Innovengers.Application
{
    public class UpsertUserCommandHandler : IRequestHandler<UpsertUserCommand, int>
    {
        public Task<int> Handle(UpsertUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}