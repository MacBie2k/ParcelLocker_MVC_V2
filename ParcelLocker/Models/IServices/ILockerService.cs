﻿using ParcelLocker.Models.ViewModels;
using System.Collections.Generic;

namespace ParcelLocker.Models.IServices
{
    public interface ILockerService
    {
        IEnumerable<LockerVM> GetAllLockers();
        LockerVM GetLockerByCode(string code);
    }
}
