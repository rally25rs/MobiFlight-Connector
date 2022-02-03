namespace MobiFlight 
{
    class MobiFlightTftButton : IConnectedDevice
    {
        public const string TYPE = "TFTButton";
        public enum InputEvent
        {
            PRESS,
            RELEASE,
            REPEAT
        }

        public string Name { get; set; }

        public DeviceType Type { get { return DeviceType.TftButton; } }

        public static string InputEventIdToString(int enumId) {
            string eventAction = "n/a";
            switch (enumId)
            {
                case (int)InputEvent.PRESS:
                    eventAction = InputEvent.PRESS.ToString();
                    break;

                case (int)InputEvent.RELEASE:
                    eventAction = InputEvent.RELEASE.ToString();
                    break;

                case (int)InputEvent.REPEAT:
                    eventAction = InputEvent.REPEAT.ToString();
                    break;
            }

            return eventAction;
        }
        public void Stop()
        {
            // do nothing
            return;
        }
    }
}
