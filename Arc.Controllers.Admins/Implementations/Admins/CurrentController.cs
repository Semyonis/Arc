﻿using Arc.Controllers.Admins.Implementations.Base;
using Arc.Controllers.Base.Attributes;
using Arc.Facades.Admins.Interfaces.Admins;
using Arc.Models.Views.Admins.Models;

namespace Arc.Controllers.Admins.Implementations.Admins;

public sealed class CurrentController(
    IAdminInfoFacade
        facade
) :
    AdminAuthorizedArcController(
        facade
    )
{
    [HttpGet]
    [ProducesOkResponseType(
        typeof(AdminResponse)
    )]
    public async Task<IActionResult> Call() =>
        await
            Invoke();
}