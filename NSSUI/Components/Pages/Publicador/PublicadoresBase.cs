using Application.Interfaces.Repositories;
using Infrastruture.Repositories;
using Microsoft.AspNetCore.Components;

namespace NSSUI.Components.Pages.Publicador;

public class PublicadoresBase : ComponentBase
{
    [Inject]
    private IPublicadorRepository _publicadorRepository { get; set; }
    protected List<Domain.Entites.Publicador> publicadores { get; set; }

    protected override async Task OnInitializedAsync()
    {
        publicadores = await _publicadorRepository.GetAllAsync();
    }
}
