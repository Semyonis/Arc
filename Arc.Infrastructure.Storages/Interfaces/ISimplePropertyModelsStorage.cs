﻿using Arc.Infrastructure.Storages.Interfaces.Base;
using Arc.Models.BusinessLogic.Models;

namespace Arc.Infrastructure.Storages.Interfaces;

public interface ISimplePropertyModelsStorage :
    IIntegerKeysModelStorageBase<SimplePropertyModel> { }