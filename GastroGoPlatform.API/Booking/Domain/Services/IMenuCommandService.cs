﻿using GastroGoPlatform.API.Booking.Domain.Model.Aggregates;
using GastroGoPlatform.API.Booking.Domain.Model.Commands;

namespace GastroGoPlatform.API.Booking.Domain.Services
{
    public interface IMenuCommandService
    {
        Task<Menu?> Handle(CreateMenuCommand command);
    }
}
