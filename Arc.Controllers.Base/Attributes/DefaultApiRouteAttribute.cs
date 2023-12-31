﻿using Arc.Infrastructure.Common.Constants;

namespace Arc.Controllers.Base.Attributes;

public sealed class DefaultApiRouteAttribute() :
    RouteAttribute(
        ControllerRouteTemplateConstants.DefaultRoute
    );