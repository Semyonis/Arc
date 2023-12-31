﻿using Arc.Criteria.CompareFunctions.Interfaces;
using Arc.Infrastructure.Exceptions.Interfaces;

using static Arc.Infrastructure.Common.Constants.Filters.FilterOperationConstants;

namespace Arc.Criteria.CompareFunctions.Implementations;

public sealed class StringCompareFunctions(
    IUnsupportedOperationExceptionDescriptor
        unsupportedOperationExceptionDescriptor
) : IStringCompareFunctions
{
    public Expression<Func<string, string, bool>>
        GetFunction(
            string operation
        ) =>
        operation switch
        {
            Equal =>
                GetStringIsEqualFunction(),
            NotEqual =>
                GetStringIsNotEqualFunction(),
            Contains =>
                GetStringIsContainsFunction(),
            NotContains =>
                GetStringIsNotContainsFunction(),
            _ =>
                throw
                    unsupportedOperationExceptionDescriptor.CreateException(),
        };

    private static Expression<Func<string, string, bool>>
        GetStringIsEqualFunction() =>
        (
                first,
                second
            ) =>
            first == second;

    private static Expression<Func<string, string, bool>>
        GetStringIsNotEqualFunction() =>
        (
                first,
                second
            ) =>
            first != second;

    private static Expression<Func<string, string, bool>>
        GetStringIsContainsFunction() =>
        (
                first,
                second
            ) =>
            first
                .Contains(
                    second
                );

    private static Expression<Func<string, string, bool>>
        GetStringIsNotContainsFunction() =>
        (
                first,
                second
            ) =>
            !first
                .Contains(
                    second
                );
}