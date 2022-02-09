using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MobiFlight.UI.Panels.Settings.Device
{
    public partial class MFVirtualOutputPanel : UserControl
    {
        /// <summary>
        /// Gets raised whenever config object has changed
        /// </summary>
        public event EventHandler Changed;

        private MobiFlight.Config.VirtualOutput virtualOutput;
        bool initialized = false;
        Board MobiFlightBoard;

        public MFVirtualOutputPanel()
        {
            InitializeComponent();
            mfPinComboBox.Items.Clear();
        }

        public MFVirtualOutputPanel(MobiFlight.Config.VirtualOutput virtualOutput, List<MobiFlightPin> Pins, Board MobiFlightBoard)
            : this()
        {
            ComboBoxHelper.BindMobiFlightFreePins(mfPinComboBox, Pins, virtualOutput.Pin);
            this.MobiFlightBoard = MobiFlightBoard;

            if (mfPinComboBox.Items.Count > 0)
            {
                mfPinComboBox.SelectedIndex = 0;
            }

            this.virtualOutput = virtualOutput;
            mfPinComboBox.SelectedValue = byte.Parse(virtualOutput.Pin);
            textBox1.Text = virtualOutput.Name;
            setValues();

            initialized = true;
        }

        private void value_Changed(object sender, EventArgs e)
        {
            if (!initialized) return;

            setValues();

            if (Changed != null)
                Changed(virtualOutput, new EventArgs());
        }

        private void setValues()
        {
            mfPinLabel.Text = "VirtualOutput";
            virtualOutput.Pin = mfPinComboBox.SelectedItem.ToString();
            virtualOutput.Name = textBox1.Text;
        }
    }
}
