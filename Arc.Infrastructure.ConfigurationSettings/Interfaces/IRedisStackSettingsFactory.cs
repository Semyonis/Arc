﻿using Arc.Infrastructure.ConfigurationSettings.Interfaces.Base;
using Arc.Infrastructure.ConfigurationSettings.Models;

namespace Arc.Infrastructure.ConfigurationSettings.Interfaces;

public interface IRedisStackSettingsFactory :
    ISettingsFactoryBase<RedisStackSettings>;