using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MobiFlight.OutputConfig
{
    public class VirtualOutput
    {
        public string DisplayPin { get; set; }

        public VirtualOutput ()
        {
            DisplayPin = ""; // not initialized anymore
        }

        public override bool Equals(Object obj)
        {
            return
                (obj != null) && (obj is VirtualOutput) &&
                (this.DisplayPin == (obj as VirtualOutput).DisplayPin);
        }

        public void ReadXml(XmlReader reader)
        {

            if (reader["pin"] != null && reader["pin"] != "")
            {
                DisplayPin = reader["pin"];
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("pin", DisplayPin);
        }

        public object Clone()
        {
            VirtualOutput clone = new VirtualOutput();
            clone.DisplayPin = DisplayPin;
            return clone;
        }
    }
}
