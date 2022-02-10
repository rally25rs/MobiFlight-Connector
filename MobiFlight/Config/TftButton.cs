﻿using System;
using System.Linq;

namespace MobiFlight.Config
{
    public class TftButton : BaseDevice
    {
        const ushort _paramCount = 1;

        public TftButton() { Name = "TFT Touch Button"; _type = DeviceType.TftButton; }

        override public String ToInternal()
        {
            return base.ToInternal() + Separator
                    + Name 
                    + End;
        }

        override public bool FromInternal(String value)
        {
            if (value.Length==value.IndexOf(End)+1) value = value.Substring(0,value.Length-1);

            String[] paramList = value.Split(Separator);
            if (paramList.Count() != _paramCount+1)
            {
                throw new ArgumentException("Param count does not match. " + paramList.Count() + " given, " + _paramCount + " expected");
            }
            
            Name = paramList[1];

            return true;
        }

        public override bool Equals(object obj)
        {
            Button other = obj as Button;
            if (other == null)
            {
                return false;
            }

            return this.Name == other.Name
                && this.Type == other.Type;
        }

        public override string ToString()
        {
            return Type + ":" + Name;
        }
    }
}
