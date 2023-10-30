﻿using Arc.Converters.Views.Admins.Interfaces;
using Arc.Models.DataBase.Models;
using Arc.Models.Views.Admins.Tables.Models.ComplexProperties;

namespace Arc.Converters.Views.Admins.Implementations;

public sealed class ComplexPropertyToComplexPropertyReadResponseConverter :
    ConverterBase
    <
        ComplexProperty,
        ComplexPropertyReadResponse
    >,
    IComplexPropertyToComplexPropertyReadResponseConverter
{
    public override ComplexPropertyReadResponse Convert(
        ComplexProperty entity
    )
    {
        var description =
            _complexPropertyDescriptionToDescriptionResponseConverter
                .Convert(
                    entity.Description
                );

        var test =
            _testToGroupReadResponseConverter
                .Convert(
                    entity.Group
                );

        return new(
            entity.Id,
            entity.Value,
            description,
            test
        );
    }

#region Constructor

    private readonly IGroupToGroupReadResponseConverter
        _testToGroupReadResponseConverter;

    private readonly IComplexPropertyDescriptionToDescriptionResponseConverter
        _complexPropertyDescriptionToDescriptionResponseConverter;

    public ComplexPropertyToComplexPropertyReadResponseConverter(
        IGroupToGroupReadResponseConverter
            testToGroupReadResponseConverter,
        IComplexPropertyDescriptionToDescriptionResponseConverter
            complexPropertyDescriptionToDescriptionResponseConverter
    )
    {
        _testToGroupReadResponseConverter =
            testToGroupReadResponseConverter;

        _complexPropertyDescriptionToDescriptionResponseConverter =
            complexPropertyDescriptionToDescriptionResponseConverter;
    }

#endregion
}