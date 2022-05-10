﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem.Models
{
    public abstract class TicketDecorator : TicketModel
    {
        public abstract override string Name { get; }
    }
}
