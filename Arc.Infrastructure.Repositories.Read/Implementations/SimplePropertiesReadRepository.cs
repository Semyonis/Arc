﻿using Arc.Database.Context;
using Arc.Infrastructure.Repositories.Read.Implementations.Base;
using Arc.Infrastructure.Repositories.Read.Interfaces;
using Arc.Models.DataBase.Models;

namespace Arc.Infrastructure.Repositories.Read.Implementations;

public sealed class SimplePropertiesReadRepository :
    IdReadRepositoryBase<SimpleProperty>,
    ISimplePropertiesReadRepository
{
    public SimplePropertiesReadRepository(
        ArcDatabaseContext context
    ) : base(
        context
    ) { }
}