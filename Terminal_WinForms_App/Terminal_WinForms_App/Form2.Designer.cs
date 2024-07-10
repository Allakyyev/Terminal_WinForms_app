namespace Terminal_WinForms_App {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.encashmentPasscodeTextBox = new System.Windows.Forms.TextBox();
            this.Cancel_Encashment = new System.Windows.Forms.Button();
            this.Submit_Encashment = new System.Windows.Forms.Button();
            this.encashmentErrorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encashmentPasscodeTextBox
            // 
            this.encashmentPasscodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encashmentPasscodeTextBox.Location = new System.Drawing.Point(284, 67);
            this.encashmentPasscodeTextBox.Name = "encashmentPasscodeTextBox";
            this.encashmentPasscodeTextBox.Size = new System.Drawing.Size(553, 83);
            this.encashmentPasscodeTextBox.TabIndex = 0;
            // 
            // Cancel_Encashment
            // 
            this.Cancel_Encashment.BackColor = System.Drawing.Color.Red;
            this.Cancel_Encashment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Encashment.Location = new System.Drawing.Point(284, 177);
            this.Cancel_Encashment.Name = "Cancel_Encashment";
            this.Cancel_Encashment.Size = new System.Drawing.Size(182, 77);
            this.Cancel_Encashment.TabIndex = 1;
            this.Cancel_Encashment.Text = "Отменить";
            this.Cancel_Encashment.UseVisualStyleBackColor = false;
            this.Cancel_Encashment.Click += new System.EventHandler(this.Cancel_Encashment_Click);
            // 
            // Submit_Encashment
            // 
            this.Submit_Encashment.BackColor = System.Drawing.Color.ForestGreen;
            this.Submit_Encashment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_Encashment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Submit_Encashment.Location = new System.Drawing.Point(596, 177);
            this.Submit_Encashment.Name = "Submit_Encashment";
            this.Submit_Encashment.Size = new System.Drawing.Size(241, 77);
            this.Submit_Encashment.TabIndex = 2;
            this.Submit_Encashment.Text = "Инкассация";
            this.Submit_Encashment.UseVisualStyleBackColor = false;
            this.Submit_Encashment.Click += new System.EventHandler(this.Submit_Encashment_Click);
            // 
            // encashmentErrorLabel
            // 
            this.encashmentErrorLabel.AutoSize = true;
            this.encashmentErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encashmentErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.encashmentErrorLabel.Location = new System.Drawing.Point(481, 23);
            this.encashmentErrorLabel.Name = "encashmentErrorLabel";
            this.encashmentErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.encashmentErrorLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 76);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ключ:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encashmentErrorLabel);
            this.Controls.Add(this.Submit_Encashment);
            this.Controls.Add(this.Cancel_Encashment);
            this.Controls.Add(this.encashmentPasscodeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox encashmentPasscodeTextBox;
        private System.Windows.Forms.Button Cancel_Encashment;
        private System.Windows.Forms.Button Submit_Encashment;
        private System.Windows.Forms.Label encashmentErrorLabel;
        private System.Windows.Forms.Label label1;
    }
}