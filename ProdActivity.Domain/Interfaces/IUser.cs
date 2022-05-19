﻿using ProdActivity.Domain.Enums;

namespace ProdActivity.Domain.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }

        string Password { get; set; }

        UserRole UserRole { get; set; }
    }
}