﻿using Arc.Dependencies.Cache.Interfaces.Base;
using Arc.Infrastructure.Dictionaries.Implementations.Base;
using Arc.Infrastructure.Dictionaries.Interfaces;
using Arc.Infrastructure.Dictionaries.Interfaces.Managers;
using Arc.Models.BusinessLogic.Models;
using Arc.Models.DataBase.Models;

namespace Arc.Infrastructure.Dictionaries.Implementations;

public sealed class SimplePropertyModelsDictionary(
        IDictionariesManager dictionaryManager,
        IDataCache dataCache
    )
    :
        ModelDictionaryBaseIntegerKeys<SimplePropertyModel>(
            dictionaryManager,
            dataCache
        ),
        ISimplePropertyModelsDictionary
{
    protected override IReadOnlyList<Type> GetDependencies() =>
        new[]
        {
            typeof(SimpleProperty),
        };
}