﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace storeManager.Entities.Interfaces
{
    public interface IBaseEntity
    {
         int ID { get; }
         string DisplayName { get; }
    }
}
