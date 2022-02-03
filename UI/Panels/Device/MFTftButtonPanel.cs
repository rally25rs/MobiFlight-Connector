using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MobiFlight.UI.Panels.Settings.Device
{
    public partial class MFTftButtonPanel : UserControl
    {
        /// <summary>
        /// Gets raised whenever config object has changed
        /// </summary>
        public event EventHandler Changed;
        private MobiFlight.Config.TftButton button;
        bool initialized = false;

        public MFTftButtonPanel()
        {
            InitializeComponent();
        }

        public MFTftButtonPanel(MobiFlight.Config.TftButton button)
            : this()
        {
            this.button = button;
            textBox1.Text = button.Name;
            setValues();

            initialized = true;
        }

        private void value_Changed(object sender, EventArgs e)
        {
            if (!initialized) return;

            setValues();

            if (Changed != null)
                Changed(button, new EventArgs());
        }

        private void setValues()
        {
            button.Name = textBox1.Text;
        }
    }
}
