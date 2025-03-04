﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobiFlight;
using MobiFlight.OutputConfig;

namespace MobiFlight
{
    public interface IFsuipcConfigItem
    {
        FsuipcOffset FSUIPC { get; set; }
        string Value { get; set; }
        Transformation Transform { get; set; }
    }
}
