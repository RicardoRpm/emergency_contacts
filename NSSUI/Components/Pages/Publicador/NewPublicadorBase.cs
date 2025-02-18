using Application.DTOs;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Components;

namespace NSSUI.Components.Pages.Publicador;

public class NewPublicadorBase : ComponentBase
{
    [Inject]
    private IPublicadorService _publicadorService { get; set; }
    protected PublicadorDto publicadorDto { get; set; }

    protected override Task OnInitializedAsync()
    {
        return base.OnInitializedAsync();
    }

    protected override Task OnAfterRenderAsync(bool firstRender)
    {
        return base.OnAfterRenderAsync(firstRender);
    }

    public void addPublicador()
    {
        var returnValue = _publicadorService.AddAsync(publicadorDto);
        if (returnValue == 1)
        {

        }

    }
}
