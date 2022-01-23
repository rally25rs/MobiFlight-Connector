﻿namespace MobiFlight.UI.Panels.OutputWizard
{
    partial class DisplayPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayPanel));
            this.displayTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.OutputTypeLabel = new System.Windows.Forms.Label();
            this.InputActionRadioButton = new System.Windows.Forms.RadioButton();
            this.OutputTypeDeviceRadioButton = new System.Windows.Forms.RadioButton();
            this.arcazeSerialLabel = new System.Windows.Forms.Label();
            this.displayModuleNameComboBox = new System.Windows.Forms.ComboBox();
            this.displayTypeComboBoxLabel = new System.Windows.Forms.Label();
            this.displayTypeComboBox = new System.Windows.Forms.ComboBox();
            this.testSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.displayPinTestStopButton = new System.Windows.Forms.Button();
            this.displayPinTestButton = new System.Windows.Forms.Button();
            this.groupBoxDisplaySettings = new System.Windows.Forms.GroupBox();
            this.displayTabTextBox = new System.Windows.Forms.TextBox();
            this.displayTypeGroupBox.SuspendLayout();
            this.testSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayTypeGroupBox
            // 
            resources.ApplyResources(this.displayTypeGroupBox, "displayTypeGroupBox");
            this.displayTypeGroupBox.Controls.Add(this.OutputTypeLabel);
            this.displayTypeGroupBox.Controls.Add(this.InputActionRadioButton);
            this.displayTypeGroupBox.Controls.Add(this.OutputTypeDeviceRadioButton);
            this.displayTypeGroupBox.Controls.Add(this.arcazeSerialLabel);
            this.displayTypeGroupBox.Controls.Add(this.displayModuleNameComboBox);
            this.displayTypeGroupBox.Controls.Add(this.displayTypeComboBoxLabel);
            this.displayTypeGroupBox.Controls.Add(this.displayTypeComboBox);
            this.displayTypeGroupBox.Name = "displayTypeGroupBox";
            this.displayTypeGroupBox.TabStop = false;
            // 
            // OutputTypeLabel
            // 
            resources.ApplyResources(this.OutputTypeLabel, "OutputTypeLabel");
            this.OutputTypeLabel.Name = "OutputTypeLabel";
            // 
            // InputActionRadioButton
            // 
            resources.ApplyResources(this.InputActionRadioButton, "InputActionRadioButton");
            this.InputActionRadioButton.Name = "InputActionRadioButton";
            this.InputActionRadioButton.UseVisualStyleBackColor = true;
            // 
            // OutputTypeDeviceRadioButton
            // 
            resources.ApplyResources(this.OutputTypeDeviceRadioButton, "OutputTypeDeviceRadioButton");
            this.OutputTypeDeviceRadioButton.Checked = true;
            this.OutputTypeDeviceRadioButton.Name = "OutputTypeDeviceRadioButton";
            this.OutputTypeDeviceRadioButton.TabStop = true;
            this.OutputTypeDeviceRadioButton.UseVisualStyleBackColor = true;
            // 
            // arcazeSerialLabel
            // 
            resources.ApplyResources(this.arcazeSerialLabel, "arcazeSerialLabel");
            this.arcazeSerialLabel.Name = "arcazeSerialLabel";
            // 
            // displayModuleNameComboBox
            // 
            resources.ApplyResources(this.displayModuleNameComboBox, "displayModuleNameComboBox");
            this.displayModuleNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displayModuleNameComboBox.FormattingEnabled = true;
            this.displayModuleNameComboBox.Items.AddRange(new object[] {
            resources.GetString("displayModuleNameComboBox.Items"),
            resources.GetString("displayModuleNameComboBox.Items1")});
            this.displayModuleNameComboBox.Name = "displayModuleNameComboBox";
            // 
            // displayTypeComboBoxLabel
            // 
            resources.ApplyResources(this.displayTypeComboBoxLabel, "displayTypeComboBoxLabel");
            this.displayTypeComboBoxLabel.Name = "displayTypeComboBoxLabel";
            // 
            // displayTypeComboBox
            // 
            resources.ApplyResources(this.displayTypeComboBox, "displayTypeComboBox");
            this.displayTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displayTypeComboBox.FormattingEnabled = true;
            this.displayTypeComboBox.Items.AddRange(new object[] {
            resources.GetString("displayTypeComboBox.Items"),
            resources.GetString("displayTypeComboBox.Items1"),
            resources.GetString("displayTypeComboBox.Items2")});
            this.displayTypeComboBox.Name = "displayTypeComboBox";
            // 
            // testSettingsGroupBox
            // 
            resources.ApplyResources(this.testSettingsGroupBox, "testSettingsGroupBox");
            this.testSettingsGroupBox.Controls.Add(this.displayPinTestStopButton);
            this.testSettingsGroupBox.Controls.Add(this.displayPinTestButton);
            this.testSettingsGroupBox.Name = "testSettingsGroupBox";
            this.testSettingsGroupBox.TabStop = false;
            // 
            // displayPinTestStopButton
            // 
            resources.ApplyResources(this.displayPinTestStopButton, "displayPinTestStopButton");
            this.displayPinTestStopButton.Image = global::MobiFlight.Properties.Resources.media_stop;
            this.displayPinTestStopButton.Name = "displayPinTestStopButton";
            this.displayPinTestStopButton.UseVisualStyleBackColor = true;
            // 
            // displayPinTestButton
            // 
            resources.ApplyResources(this.displayPinTestButton, "displayPinTestButton");
            this.displayPinTestButton.Image = global::MobiFlight.Properties.Resources.media_play;
            this.displayPinTestButton.Name = "displayPinTestButton";
            this.displayPinTestButton.UseVisualStyleBackColor = true;
            // 
            // groupBoxDisplaySettings
            // 
            resources.ApplyResources(this.groupBoxDisplaySettings, "groupBoxDisplaySettings");
            this.groupBoxDisplaySettings.Name = "groupBoxDisplaySettings";
            this.groupBoxDisplaySettings.TabStop = false;
            // 
            // displayTabTextBox
            // 
            resources.ApplyResources(this.displayTabTextBox, "displayTabTextBox");
            this.displayTabTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.displayTabTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayTabTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.displayTabTextBox.Name = "displayTabTextBox";
            this.displayTabTextBox.ReadOnly = true;
            this.displayTabTextBox.TabStop = false;
            // 
            // DisplayPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.testSettingsGroupBox);
            this.Controls.Add(this.groupBoxDisplaySettings);
            this.Controls.Add(this.displayTypeGroupBox);
            this.Controls.Add(this.displayTabTextBox);
            this.Name = "DisplayPanel";
            this.displayTypeGroupBox.ResumeLayout(false);
            this.displayTypeGroupBox.PerformLayout();
            this.testSettingsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox displayTypeGroupBox;
        private System.Windows.Forms.Label OutputTypeLabel;
        private System.Windows.Forms.RadioButton InputActionRadioButton;
        private System.Windows.Forms.RadioButton OutputTypeDeviceRadioButton;
        private System.Windows.Forms.Label arcazeSerialLabel;
        private System.Windows.Forms.ComboBox displayModuleNameComboBox;
        private System.Windows.Forms.Label displayTypeComboBoxLabel;
        private System.Windows.Forms.ComboBox displayTypeComboBox;
        private System.Windows.Forms.GroupBox testSettingsGroupBox;
        private System.Windows.Forms.Button displayPinTestStopButton;
        private System.Windows.Forms.Button displayPinTestButton;
        private System.Windows.Forms.GroupBox groupBoxDisplaySettings;
        private System.Windows.Forms.TextBox displayTabTextBox;
    }
}
