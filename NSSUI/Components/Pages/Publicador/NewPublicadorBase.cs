using Application.Interfaces.Repositories;
using Microsoft.AspNetCore.Components;

namespace NSSUI.Components.Pages.Publicador;

public class NewPublicadorBase : ComponentBase
{
    [Inject]
    private IPublicadorRepository _publicadorRepository { get; set; }

    protected override Task OnInitializedAsync()
    {
        return base.OnInitializedAsync();
    }

    protected override Task OnAfterRenderAsync(bool firstRender)
    {
        return base.OnAfterRenderAsync(firstRender);
    }
}
