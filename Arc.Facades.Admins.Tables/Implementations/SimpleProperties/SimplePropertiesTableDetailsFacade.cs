﻿using Arc.Converters.Views.Admins.Interfaces;
using Arc.Database.Entities.Models;
using Arc.Facades.Admins.Tables.Implementations.Base;
using Arc.Facades.Admins.Tables.Interfaces.SimpleProperties;
using Arc.Facades.Domain.Interface;
using Arc.Infrastructure.Exceptions.Interfaces;
using Arc.Infrastructure.Repositories.Read.Interfaces;
using Arc.Models.Views.Admins.Tables.Models.SimpleProperties;

namespace Arc.Facades.Admins.Tables.Implementations.SimpleProperties;

public sealed class SimplePropertiesTableDetailsFacade(
    ISimplePropertiesReadRepository
        readRepository,
    IResponsesDomainFacade
        internalFacade,
    ISimplePropertyToSimplePropertyReadResponseConverter
        readConverter,
    IEntityNotFoundExceptionDescriptor
        entityNotFoundExceptionDescriptor
) : BaseTableDetailsFacade
    <SimpleProperty, SimplePropertyReadResponse>(
        readRepository,
        internalFacade,
        readConverter,
        entityNotFoundExceptionDescriptor
    ),
    ISimplePropertiesTableDetailsFacade;