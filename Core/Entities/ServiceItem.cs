﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class ServiceItem : EntityBase
    {
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
