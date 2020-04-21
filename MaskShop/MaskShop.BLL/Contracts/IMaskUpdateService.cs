﻿using MaskShop.Domain;
using MaskShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MaskShop.BLL.Contracts
{
    public interface IMaskUpdateService
    {
        Task<Mask> UpdateAsync(MaskUpdateModel mask);
    }
}
