﻿using Arc.Controllers.Admins.Tables.Implementations.Base;
using Arc.Controllers.Base.Attributes;
using Arc.Facades.Admins.Tables.Interfaces.ComplexProperties;
using Arc.Models.Views.Admins.Tables.Models.ComplexProperties;

namespace Arc.Controllers.Admins.Tables.Implementations.ComplexProperties;

[ControllerGroup(
    "ComplexProperties"
)]
public sealed class ComplexPropertiesTableUpdateController :
    BaseTableAuthorizedUpdateController
    <
        ComplexPropertyTableUpdateRequest
    >
{
    public ComplexPropertiesTableUpdateController(
        IComplexPropertiesTableUpdateFacade
            facade
    ) : base(
        facade
    ) { }
}