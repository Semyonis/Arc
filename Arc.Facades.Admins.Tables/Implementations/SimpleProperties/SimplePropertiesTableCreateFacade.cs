﻿using Arc.Converters.Views.Admins.Interfaces;
using Arc.Facades.Admins.Tables.Implementations.Base;
using Arc.Facades.Admins.Tables.Interfaces.SimpleProperties;
using Arc.Facades.Domain.Interface;
using Arc.Infrastructure.Repositories.Interfaces;
using Arc.Infrastructure.Transactions.Interfaces;
using Arc.Models.BusinessLogic.Models.Identities;
using Arc.Models.BusinessLogic.Response;
using Arc.Models.DataBase.Models;
using Arc.Models.Views.Admins.Tables.Models.SimpleProperties;

namespace Arc.Facades.Admins.Tables.Implementations.SimpleProperties;

public sealed class SimplePropertiesTableCreateFacade(
    ICreateRepository
        repository,
    IResponsesDomainFacade
        internalFacade,
    ISimplePropertyCreateRequestToSimplePropertyConverter
        createConverter,
    ITransactionManager
        transactionManager
) : BaseTableCreateFacade
    <
        SimpleProperty,
        SimplePropertyCreateRequest
    >(
        repository,
        internalFacade,
        createConverter,
        transactionManager
    ),
    ISimplePropertiesTableCreateFacade
{
    public async Task<Response> Execute(
        SimplePropertyTableCreateRequest tableRequest,
        AdminIdentity identity
    ) =>
        await
            Execute(
                tableRequest.Items,
                identity
            );
}