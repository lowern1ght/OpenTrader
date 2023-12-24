﻿using Trader.Models.Base;

namespace Trader.Models.Identity;

public class UserInfoModel : BaseModel
{
    public required string Id { get; set; }
    public required string Email { get; set; }
    public required string Username { get; set; }
}