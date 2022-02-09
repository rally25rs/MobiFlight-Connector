using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandMessenger;

namespace MobiFlight
{
    public class MobiFlightVirtualOutput : IConnectedDevice
    {
        public const string TYPE = "VirtualOutput";

        private String _name = "VirtualOutput";
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private DeviceType _type = DeviceType.VirtualOutput;
        public DeviceType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public CmdMessenger CmdMessenger { get; set; }
        public int Pin { get; set; }
        
        public MobiFlightVirtualOutput() { }

        public void Set(int value)
        {
            var command = new SendCommand((int)MobiFlightModule.Command.VirtualOutputChange);
            command.AddArgument(Pin);
            command.AddArgument(value);
            // Send command
            Log.Instance.log("Command: SetPin <" + (int)MobiFlightModule.Command.VirtualOutputChange + "," +
                                          Pin + "," +
                                          value + ";>", LogSeverity.Debug);

            CmdMessenger.SendCommand(command);
        }

        public void Stop()
        {
            Set(0);
        }
    }
}
