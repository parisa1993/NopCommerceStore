﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Core.Domain.Projects
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public bool Published { get; set; }
    }
}
