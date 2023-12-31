﻿using Arc.Converters.Base.Interfaces;
using Arc.Database.Entities.Models;
using Arc.Models.Views.Admins.Tables.Models.ComplexProperties;

namespace Arc.Converters.Views.Admins.Interfaces;

public interface IComplexPropertyCreateRequestToComplexPropertyConverter :
    IConverterBase
    <
        ComplexPropertyCreateRequest,
        ComplexProperty
    >;