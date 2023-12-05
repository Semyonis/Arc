﻿using Arc.Converters.Base.Interfaces;
using Arc.Database.Entities.Models;
using Arc.Models.Views.Admins.Tables.Models.Groups;

namespace Arc.Converters.Views.Admins.Interfaces;

public interface IGroupCreateRequestToGroupConverter :
    IConverterBase
    <
        GroupCreateRequest,
        Group
    >;