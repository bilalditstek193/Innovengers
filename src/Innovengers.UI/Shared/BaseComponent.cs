using Microsoft.AspNetCore.Components;
using MediatR;

namespace Innovengers.UI
{
    public class BaseComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager Navigation { get; set; }

        [Inject]
        protected IMediator Mediator { get; set; }

        protected void NavigateTo(string url)
        {
            Navigation.NavigateTo(url);
        }

        protected async Task<TResponse> SendRequestAsync<TResponse>(IRequest<TResponse> request)
        {
            return await Mediator.Send(request, CancellationToken.None);
        }

        protected async Task SendRequestAsync(IRequest request)
        {
            await Mediator.Send(request, CancellationToken.None);
        }
    }
}