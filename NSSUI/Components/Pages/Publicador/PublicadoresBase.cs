using Application.DTOs;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Components;

namespace NSSUI.Components.Pages.Publicador;

public class PublicadoresBase : ComponentBase
{
    [Inject]
    private IPublicadorService _publicadorService { get; set; }
    protected List<PublicadorDto> publicadores { get; set; }

    protected override async Task OnInitializedAsync()
    {
        publicadores = await _publicadorService.GetAllAsync();
    }
}
