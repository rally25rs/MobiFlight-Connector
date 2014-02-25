﻿namespace MobiFlight.Panels
{
    partial class MFEncoderPanel
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mfPinLabel = new System.Windows.Forms.Label();
            this.mfLeftPinComboBox = new System.Windows.Forms.ComboBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mfRightPinComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mfRightPinComboBox);
            this.groupBox1.Controls.Add(this.mfPinLabel);
            this.groupBox1.Controls.Add(this.mfLeftPinComboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pin settings";
            // 
            // mfPinLabel
            // 
            this.mfPinLabel.Location = new System.Drawing.Point(61, 22);
            this.mfPinLabel.Name = "mfPinLabel";
            this.mfPinLabel.Size = new System.Drawing.Size(47, 18);
            this.mfPinLabel.TabIndex = 14;
            this.mfPinLabel.Text = "Left Pin";
            // 
            // mfLeftPinComboBox
            // 
            this.mfLeftPinComboBox.FormattingEnabled = true;
            this.mfLeftPinComboBox.Location = new System.Drawing.Point(18, 19);
            this.mfLeftPinComboBox.MaxLength = 2;
            this.mfLeftPinComboBox.Name = "mfLeftPinComboBox";
            this.mfLeftPinComboBox.Size = new System.Drawing.Size(37, 21);
            this.mfLeftPinComboBox.TabIndex = 13;
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(110, 121);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 4;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 48);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(61, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Right Pin";
            // 
            // mfRightPinComboBox
            // 
            this.mfRightPinComboBox.FormattingEnabled = true;
            this.mfRightPinComboBox.Location = new System.Drawing.Point(18, 43);
            this.mfRightPinComboBox.MaxLength = 2;
            this.mfRightPinComboBox.Name = "mfRightPinComboBox";
            this.mfRightPinComboBox.Size = new System.Drawing.Size(37, 21);
            this.mfRightPinComboBox.TabIndex = 15;
            // 
            // MFEncoderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MFEncoderPanel";
            this.Size = new System.Drawing.Size(185, 241);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label mfPinLabel;
        private System.Windows.Forms.ComboBox mfLeftPinComboBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox mfRightPinComboBox;

    }
}
