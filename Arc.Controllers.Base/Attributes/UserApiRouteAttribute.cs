﻿using static Arc.Infrastructure.Common.Constants.ControllerRouteTemplateConstants;

namespace Arc.Controllers.Base.Attributes;

public sealed class UserApiRouteAttribute() :
    RouteAttribute(
        $"{UserRoutePrefix}{ControllerRoute}"
    );