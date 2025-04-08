﻿using PocSII.DteBusinessRules.Common;
using PocSII.DteBusinessRules.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteBusinessRules.Interfaces
{
    public interface IDteQueryService
    {
        Task<Result<DTEResponseQuery>> GetDteAsync(string trackid, string endpointUrl);
    }
}
