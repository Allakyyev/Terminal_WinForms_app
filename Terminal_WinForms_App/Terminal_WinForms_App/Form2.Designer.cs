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
            this.label2 = new System.Windows.Forms.Label();
            this.currentTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // encashmentPasscodeTextBox
            // 
            this.encashmentPasscodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encashmentPasscodeTextBox.Location = new System.Drawing.Point(320, 84);
            this.encashmentPasscodeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.encashmentPasscodeTextBox.Name = "encashmentPasscodeTextBox";
            this.encashmentPasscodeTextBox.Size = new System.Drawing.Size(802, 98);
            this.encashmentPasscodeTextBox.TabIndex = 0;
            this.encashmentPasscodeTextBox.TextChanged += new System.EventHandler(this.encashmentPasscodeTextBox_TextChanged);
            // 
            // Cancel_Encashment
            // 
            this.Cancel_Encashment.BackColor = System.Drawing.Color.Red;
            this.Cancel_Encashment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Encashment.Location = new System.Drawing.Point(102, 339);
            this.Cancel_Encashment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel_Encashment.Name = "Cancel_Encashment";
            this.Cancel_Encashment.Size = new System.Drawing.Size(205, 75);
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
            this.Submit_Encashment.Location = new System.Drawing.Point(707, 339);
            this.Submit_Encashment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Submit_Encashment.Name = "Submit_Encashment";
            this.Submit_Encashment.Size = new System.Drawing.Size(271, 75);
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
            this.encashmentErrorLabel.Location = new System.Drawing.Point(541, 29);
            this.encashmentErrorLabel.Name = "encashmentErrorLabel";
            this.encashmentErrorLabel.Size = new System.Drawing.Size(0, 25);
            this.encashmentErrorLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 91);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ключ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(565, 91);
            this.label2.TabIndex = 6;
            this.label2.Text = "Всего в кассе:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // currentTotal
            // 
            this.currentTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTotal.Location = new System.Drawing.Point(615, 192);
            this.currentTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.currentTotal.Name = "currentTotal";
            this.currentTotal.Size = new System.Drawing.Size(507, 98);
            this.currentTotal.TabIndex = 5;
            this.currentTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encashmentErrorLabel);
            this.Controls.Add(this.Submit_Encashment);
            this.Controls.Add(this.Cancel_Encashment);
            this.Controls.Add(this.encashmentPasscodeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currentTotal;
    }
}