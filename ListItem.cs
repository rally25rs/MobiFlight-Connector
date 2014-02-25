﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public class ListItem
    {
        public String Value { get; set; }
        public String Label { get; set; }
    }

    public class ListItem<T>
    {
        public T Value { get; set; }
        public String Label { get; set; }
    }
}
