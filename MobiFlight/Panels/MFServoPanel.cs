﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MobiFlight.Panels
{
    public partial class MFServoPanel : UserControl
    {
        /// <summary>
        /// Gets raised whenever config object has changed
        /// </summary>
        public event EventHandler Changed;

        private Config.Servo servo;

        public MFServoPanel()
        {
            InitializeComponent();
            for (int i = 0; i != 56; i++)
            {
                mfPinComboBox.Items.Add(i);
            }
            mfPinComboBox.SelectedIndex = 0;
        }

        public MFServoPanel(Config.Servo servo)
            : this()
        {
            // TODO: Complete member initialization
            this.servo = servo;
            ComboBoxHelper.SetSelectedItem(mfPinComboBox, servo.DataPin);
            textBox1.Text = servo.Name;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            servo.DataPin = mfPinComboBox.Text;
            servo.Name = textBox1.Text;
            Changed(servo, new EventArgs());
        }
    }
}
