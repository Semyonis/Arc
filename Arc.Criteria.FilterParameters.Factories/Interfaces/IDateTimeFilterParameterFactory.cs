﻿using Arc.Criteria.FilterParameters.Implementations.Base;
using Arc.Models.BusinessLogic.Models.FilterProperties;

namespace Arc.Criteria.FilterParameters.Factories.Interfaces;

public interface IDateTimeFilterParameterFactory
{
    FilterParameterBase<TEntity> GetFilterParameter
    <
        TEntity
    >(
        DateTimeFilterPropertyModel filter,
        Expression<Func<TEntity, DateTime>> propertyPredicate
    );
}