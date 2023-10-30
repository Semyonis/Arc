﻿using Arc.Controllers.Admins.Implementations.Base;
using Arc.Controllers.Base.Attributes;
using Arc.Facades.Admins.Interfaces.Backdoors;

namespace Arc.Controllers.Admins.Implementations.Backdoors;

public sealed class DictionaryUpdateController :
    AdminAuthorizedArcController
{
    public DictionaryUpdateController(
        IDictionaryUpdateFacade
            facade
    ) : base(
        facade
    ) { }

    [HttpPost]
    [ProducesOkResponseType]
    public async Task<IActionResult> Call() =>
        await
            Invoke();
}