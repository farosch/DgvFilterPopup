namespace DgvFilterPopup {
    partial class DgvTextBoxColumnFilter {
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
            this.TextBoxValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxOperator
            // 
            this.ComboBoxOperator.FormattingEnabled = true;
            this.ComboBoxOperator.Location = new System.Drawing.Point(3, 3);
            this.ComboBoxOperator.Name = "ComboBoxOperator";
            this.ComboBoxOperator.Size = new System.Drawing.Size(55, 21);
            this.ComboBoxOperator.TabIndex = 0;
            // 
            // textBoxValue
            // 
            this.TextBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxValue.Location = new System.Drawing.Point(64, 3);
            this.TextBoxValue.Name = "TextBoxValue";
            this.TextBoxValue.Size = new System.Drawing.Size(142, 20);
            this.TextBoxValue.TabIndex = 1;
            // 
            // DgvTextBoxColumnFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TextBoxValue);
            this.Controls.Add(this.ComboBoxOperator);
            this.Name = "DgvTextBoxColumnFilter";
            this.Size = new System.Drawing.Size(209, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
