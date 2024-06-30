namespace Terminal_WinForms_App {
    partial class Form1 {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_actions = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_to_main = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelInputPhoneNumber = new System.Windows.Forms.Panel();
            this.button_number_back = new System.Windows.Forms.Button();
            this.button_number_del = new System.Windows.Forms.Button();
            this.button_number_0 = new System.Windows.Forms.Button();
            this.button_number_9 = new System.Windows.Forms.Button();
            this.button_number_8 = new System.Windows.Forms.Button();
            this.button_number_7 = new System.Windows.Forms.Button();
            this.button_number_6 = new System.Windows.Forms.Button();
            this.button_number_5 = new System.Windows.Forms.Button();
            this.button_number_4 = new System.Windows.Forms.Button();
            this.button_number_3 = new System.Windows.Forms.Button();
            this.button_number_2 = new System.Windows.Forms.Button();
            this.button_number_1 = new System.Windows.Forms.Button();
            this.label_phone_number = new System.Windows.Forms.Label();
            this.panel_confirm_number = new System.Windows.Forms.Panel();
            this.label_confirm_phone_number = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_decline_phone_number = new System.Windows.Forms.Button();
            this.button_confirm_phone_number = new System.Windows.Forms.Button();
            this.panel_accept_payment = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button_accept_bill_pay = new System.Windows.Forms.Button();
            this.label_accept_bill_phone = new System.Windows.Forms.Label();
            this.label_accept_bill_total = new System.Windows.Forms.Label();
            this.panel_success = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_actions.SuspendLayout();
            this.panelInputPhoneNumber.SuspendLayout();
            this.panel_confirm_number.SuspendLayout();
            this.panel_accept_payment.SuspendLayout();
            this.panel_success.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Terminal_WinForms_App.Properties.Resources._6488a521039a550cedb28a4e9920ff6b_fgraphic;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.time);
            this.panel2.Controls.Add(this.label1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // time
            // 
            resources.ApplyResources(this.time, "time");
            this.time.Name = "time";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_actions
            // 
            this.panel_actions.Controls.Add(this.button1);
            this.panel_actions.Controls.Add(this.button_to_main);
            resources.ApplyResources(this.panel_actions, "panel_actions");
            this.panel_actions.Name = "panel_actions";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_to_main
            // 
            this.button_to_main.BackColor = System.Drawing.SystemColors.WindowFrame;
            resources.ApplyResources(this.button_to_main, "button_to_main");
            this.button_to_main.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_to_main.Name = "button_to_main";
            this.button_to_main.UseVisualStyleBackColor = false;
            this.button_to_main.Click += new System.EventHandler(this.button_to_main_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panelInputPhoneNumber
            // 
            this.panelInputPhoneNumber.Controls.Add(this.button_number_back);
            this.panelInputPhoneNumber.Controls.Add(this.button_number_del);
            this.panelInputPhoneNumber.Controls.Add(this.button_number_0);
            this.panelInputPhoneNumber.Controls.Add(this.button_number_9);
            this.panelInputPhoneNumber.Controls.Add(this.button_number_8);
            this.panelInputPhoneNumber.Controls.Add(this.button_number_7);
            this.panelInputPhoneNumber.Controls.Add(this.button_number_6);
            this.panelInputPhoneNumber.Controls.Add(this.button_number_5);
            this.panelInputPhoneNumber.Controls.Add(this.button_number_4);
            this.panelInputPhoneNumber.Controls.Add(this.button_number_3);
            this.panelInputPhoneNumber.Controls.Add(this.button_number_2);
            this.panelInputPhoneNumber.Controls.Add(this.button_number_1);
            this.panelInputPhoneNumber.Controls.Add(this.label_phone_number);
            resources.ApplyResources(this.panelInputPhoneNumber, "panelInputPhoneNumber");
            this.panelInputPhoneNumber.Name = "panelInputPhoneNumber";
            // 
            // button_number_back
            // 
            this.button_number_back.BackColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.button_number_back, "button_number_back");
            this.button_number_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_number_back.Name = "button_number_back";
            this.button_number_back.UseVisualStyleBackColor = false;
            this.button_number_back.Click += new System.EventHandler(this.button_number_back_Click);
            // 
            // button_number_del
            // 
            this.button_number_del.BackColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.button_number_del, "button_number_del");
            this.button_number_del.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_number_del.Name = "button_number_del";
            this.button_number_del.UseVisualStyleBackColor = false;
            this.button_number_del.Click += new System.EventHandler(this.button_number_del_Click);
            // 
            // button_number_0
            // 
            this.button_number_0.BackColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.button_number_0, "button_number_0");
            this.button_number_0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_number_0.Name = "button_number_0";
            this.button_number_0.UseVisualStyleBackColor = false;
            this.button_number_0.Click += new System.EventHandler(this.button_number_0_Click);
            // 
            // button_number_9
            // 
            this.button_number_9.BackColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.button_number_9, "button_number_9");
            this.button_number_9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_number_9.Name = "button_number_9";
            this.button_number_9.UseVisualStyleBackColor = false;
            this.button_number_9.Click += new System.EventHandler(this.button_number_9_Click);
            // 
            // button_number_8
            // 
            this.button_number_8.BackColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.button_number_8, "button_number_8");
            this.button_number_8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_number_8.Name = "button_number_8";
            this.button_number_8.UseVisualStyleBackColor = false;
            this.button_number_8.Click += new System.EventHandler(this.button_number_8_Click);
            // 
            // button_number_7
            // 
            this.button_number_7.BackColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.button_number_7, "button_number_7");
            this.button_number_7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_number_7.Name = "button_number_7";
            this.button_number_7.UseVisualStyleBackColor = false;
            this.button_number_7.Click += new System.EventHandler(this.button_number_7_Click);
            // 
            // button_number_6
            // 
            this.button_number_6.BackColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.button_number_6, "button_number_6");
            this.button_number_6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_number_6.Name = "button_number_6";
            this.button_number_6.UseVisualStyleBackColor = false;
            this.button_number_6.Click += new System.EventHandler(this.button_number_6_Click);
            // 
            // button_number_5
            // 
            this.button_number_5.BackColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.button_number_5, "button_number_5");
            this.button_number_5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_number_5.Name = "button_number_5";
            this.button_number_5.UseVisualStyleBackColor = false;
            this.button_number_5.Click += new System.EventHandler(this.button_number_5_Click);
            // 
            // button_number_4
            // 
            this.button_number_4.BackColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.button_number_4, "button_number_4");
            this.button_number_4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_number_4.Name = "button_number_4";
            this.button_number_4.UseVisualStyleBackColor = false;
            this.button_number_4.Click += new System.EventHandler(this.button_number_4_Click);
            // 
            // button_number_3
            // 
            this.button_number_3.BackColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.button_number_3, "button_number_3");
            this.button_number_3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_number_3.Name = "button_number_3";
            this.button_number_3.UseVisualStyleBackColor = false;
            this.button_number_3.Click += new System.EventHandler(this.button_number_3_Click);
            // 
            // button_number_2
            // 
            this.button_number_2.BackColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.button_number_2, "button_number_2");
            this.button_number_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_number_2.Name = "button_number_2";
            this.button_number_2.UseVisualStyleBackColor = false;
            this.button_number_2.Click += new System.EventHandler(this.button_number_2_Click);
            // 
            // button_number_1
            // 
            this.button_number_1.BackColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.button_number_1, "button_number_1");
            this.button_number_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_number_1.Name = "button_number_1";
            this.button_number_1.UseVisualStyleBackColor = false;
            this.button_number_1.Click += new System.EventHandler(this.button_number_1_Click);
            // 
            // label_phone_number
            // 
            resources.ApplyResources(this.label_phone_number, "label_phone_number");
            this.label_phone_number.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_phone_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_phone_number.Name = "label_phone_number";
            // 
            // panel_confirm_number
            // 
            this.panel_confirm_number.Controls.Add(this.label_confirm_phone_number);
            this.panel_confirm_number.Controls.Add(this.label2);
            this.panel_confirm_number.Controls.Add(this.button_decline_phone_number);
            this.panel_confirm_number.Controls.Add(this.button_confirm_phone_number);
            resources.ApplyResources(this.panel_confirm_number, "panel_confirm_number");
            this.panel_confirm_number.Name = "panel_confirm_number";
            // 
            // label_confirm_phone_number
            // 
            resources.ApplyResources(this.label_confirm_phone_number, "label_confirm_phone_number");
            this.label_confirm_phone_number.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_confirm_phone_number.Name = "label_confirm_phone_number";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // button_decline_phone_number
            // 
            this.button_decline_phone_number.BackColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.button_decline_phone_number, "button_decline_phone_number");
            this.button_decline_phone_number.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_decline_phone_number.Name = "button_decline_phone_number";
            this.button_decline_phone_number.UseVisualStyleBackColor = false;
            this.button_decline_phone_number.Click += new System.EventHandler(this.button_decline_phone_number_Click);
            // 
            // button_confirm_phone_number
            // 
            this.button_confirm_phone_number.BackColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.button_confirm_phone_number, "button_confirm_phone_number");
            this.button_confirm_phone_number.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_confirm_phone_number.Name = "button_confirm_phone_number";
            this.button_confirm_phone_number.UseVisualStyleBackColor = false;
            this.button_confirm_phone_number.Click += new System.EventHandler(this.button_confirm_phone_number_Click);
            // 
            // panel_accept_payment
            // 
            this.panel_accept_payment.Controls.Add(this.button2);
            this.panel_accept_payment.Controls.Add(this.button_accept_bill_pay);
            this.panel_accept_payment.Controls.Add(this.label_accept_bill_phone);
            this.panel_accept_payment.Controls.Add(this.label_accept_bill_total);
            resources.ApplyResources(this.panel_accept_payment, "panel_accept_payment");
            this.panel_accept_payment.Name = "panel_accept_payment";
            this.panel_accept_payment.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_accept_payment_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_accept_bill_pay
            // 
            this.button_accept_bill_pay.BackColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.button_accept_bill_pay, "button_accept_bill_pay");
            this.button_accept_bill_pay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_accept_bill_pay.Name = "button_accept_bill_pay";
            this.button_accept_bill_pay.UseVisualStyleBackColor = false;
            this.button_accept_bill_pay.Click += new System.EventHandler(this.button_accept_bill_pay_Click);
            // 
            // label_accept_bill_phone
            // 
            resources.ApplyResources(this.label_accept_bill_phone, "label_accept_bill_phone");
            this.label_accept_bill_phone.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_accept_bill_phone.Name = "label_accept_bill_phone";
            // 
            // label_accept_bill_total
            // 
            resources.ApplyResources(this.label_accept_bill_total, "label_accept_bill_total");
            this.label_accept_bill_total.Name = "label_accept_bill_total";
            // 
            // panel_success
            // 
            this.panel_success.BackColor = System.Drawing.Color.Green;
            this.panel_success.Controls.Add(this.label4);
            this.panel_success.Controls.Add(this.label3);
            resources.ApplyResources(this.panel_success, "panel_success");
            this.panel_success.Name = "panel_success";
            this.panel_success.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.panelInputPhoneNumber);
            this.Controls.Add(this.panel_actions);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel_success);
            this.Controls.Add(this.panel_accept_payment);
            this.Controls.Add(this.panel_confirm_number);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_actions.ResumeLayout(false);
            this.panelInputPhoneNumber.ResumeLayout(false);
            this.panelInputPhoneNumber.PerformLayout();
            this.panel_confirm_number.ResumeLayout(false);
            this.panel_confirm_number.PerformLayout();
            this.panel_accept_payment.ResumeLayout(false);
            this.panel_accept_payment.PerformLayout();
            this.panel_success.ResumeLayout(false);
            this.panel_success.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_actions;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panelInputPhoneNumber;
        private System.Windows.Forms.Label label_phone_number;
        private System.Windows.Forms.Button button_number_9;
        private System.Windows.Forms.Button button_number_8;
        private System.Windows.Forms.Button button_number_7;
        private System.Windows.Forms.Button button_number_6;
        private System.Windows.Forms.Button button_number_5;
        private System.Windows.Forms.Button button_number_4;
        private System.Windows.Forms.Button button_number_3;
        private System.Windows.Forms.Button button_number_2;
        private System.Windows.Forms.Button button_number_1;
        private System.Windows.Forms.Button button_number_back;
        private System.Windows.Forms.Button button_number_del;
        private System.Windows.Forms.Button button_number_0;
        private System.Windows.Forms.Button button_to_main;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_confirm_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_decline_phone_number;
        private System.Windows.Forms.Button button_confirm_phone_number;
        private System.Windows.Forms.Label label_confirm_phone_number;
        private System.Windows.Forms.Panel panel_accept_payment;
        private System.Windows.Forms.Label label_accept_bill_phone;
        private System.Windows.Forms.Label label_accept_bill_total;
        private System.Windows.Forms.Button button_accept_bill_pay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_success;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

