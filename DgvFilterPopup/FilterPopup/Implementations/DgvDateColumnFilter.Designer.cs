namespace DgvFilterPopup {
    partial class DgvDateColumnFilter {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ComboBoxOperator = new System.Windows.Forms.ComboBox();
            this.DateTimePickerValue = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // comboBoxOperator
            // 
            this.ComboBoxOperator.FormattingEnabled = true;
            this.ComboBoxOperator.Location = new System.Drawing.Point(3, 3);
            this.ComboBoxOperator.Name = "ComboBoxOperator";
            this.ComboBoxOperator.Size = new System.Drawing.Size(49, 21);
            this.ComboBoxOperator.TabIndex = 0;
            // 
            // dateTimePickerValue
            // 
            this.DateTimePickerValue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerValue.Location = new System.Drawing.Point(58, 3);
            this.DateTimePickerValue.Name = "DateTimePickerValue";
            this.DateTimePickerValue.Size = new System.Drawing.Size(127, 20);
            this.DateTimePickerValue.TabIndex = 1;
            // 
            // DgvDateColumnFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.DateTimePickerValue);
            this.Controls.Add(this.ComboBoxOperator);
            this.Name = "DgvDateColumnFilter";
            this.Size = new System.Drawing.Size(194, 28);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
