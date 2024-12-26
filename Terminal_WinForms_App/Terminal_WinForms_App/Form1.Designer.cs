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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.terminalNumberLabel = new System.Windows.Forms.Label();
            this.terminalNumberTextLabel = new System.Windows.Forms.Label();
            this.contactInputPhoneLabel = new System.Windows.Forms.Label();
            this.contactPhone = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_actions = new System.Windows.Forms.Panel();
            this.button_continue = new System.Windows.Forms.Button();
            this.button_to_main = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelInputPhoneNumber = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_number_3 = new System.Windows.Forms.Button();
            this.button_number_back = new System.Windows.Forms.Button();
            this.button_number_1 = new System.Windows.Forms.Button();
            this.button_number_del = new System.Windows.Forms.Button();
            this.button_number_2 = new System.Windows.Forms.Button();
            this.button_number_0 = new System.Windows.Forms.Button();
            this.button_number_4 = new System.Windows.Forms.Button();
            this.button_number_9 = new System.Windows.Forms.Button();
            this.button_number_5 = new System.Windows.Forms.Button();
            this.button_number_8 = new System.Windows.Forms.Button();
            this.button_number_6 = new System.Windows.Forms.Button();
            this.button_number_7 = new System.Windows.Forms.Button();
            this.label_phone_number = new System.Windows.Forms.Label();
            this.panel_confirm_number = new System.Windows.Forms.Panel();
            this.confirmTextLabel = new System.Windows.Forms.Label();
            this.label_confirm_phone_number = new System.Windows.Forms.Label();
            this.button_decline_phone_number = new System.Windows.Forms.Button();
            this.button_confirm_phone_number = new System.Windows.Forms.Button();
            this.panel_accept_payment = new System.Windows.Forms.Panel();
            this.button_payPanal_home = new System.Windows.Forms.Button();
            this.button_accept_bill_pay = new System.Windows.Forms.Button();
            this.label_accept_bill_phone = new System.Windows.Forms.Label();
            this.label_accept_bill_total = new System.Windows.Forms.Label();
            this.panel_success = new System.Windows.Forms.Panel();
            this.successLabel1 = new System.Windows.Forms.Label();
            this.successLabel2 = new System.Windows.Forms.Label();
            this.success_hide_timer = new System.Windows.Forms.Timer(this.components);
            this.pingTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelInputPhoneNumber.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_confirm_number.SuspendLayout();
            this.panel_accept_payment.SuspendLayout();
            this.panel_success.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Controls.Add(this.pictureBox3);
            this.panelMain.Controls.Add(this.pictureBox2);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.panel4);
            this.panelMain.Name = "panelMain";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Image = global::Terminal_WinForms_App.Properties.Resources.FlagRU;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::Terminal_WinForms_App.Properties.Resources.flagTMNew;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackgroundImage = global::Terminal_WinForms_App.Properties.Resources._1280x230_sandyk;
            this.panel3.Name = "panel3";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Terminal_WinForms_App.Properties.Resources.TMCellNew;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackgroundImage = global::Terminal_WinForms_App.Properties.Resources.bazar1;
            this.panel4.Controls.Add(this.label1);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Name = "panel4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Name = "label1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.terminalNumberLabel);
            this.panel2.Controls.Add(this.terminalNumberTextLabel);
            this.panel2.Controls.Add(this.contactInputPhoneLabel);
            this.panel2.Controls.Add(this.contactPhone);
            this.panel2.Controls.Add(this.time);
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // terminalNumberLabel
            // 
            resources.ApplyResources(this.terminalNumberLabel, "terminalNumberLabel");
            this.terminalNumberLabel.ForeColor = System.Drawing.Color.White;
            this.terminalNumberLabel.Name = "terminalNumberLabel";
            // 
            // terminalNumberTextLabel
            // 
            resources.ApplyResources(this.terminalNumberTextLabel, "terminalNumberTextLabel");
            this.terminalNumberTextLabel.ForeColor = System.Drawing.Color.White;
            this.terminalNumberTextLabel.Name = "terminalNumberTextLabel";
            // 
            // contactInputPhoneLabel
            // 
            resources.ApplyResources(this.contactInputPhoneLabel, "contactInputPhoneLabel");
            this.contactInputPhoneLabel.ForeColor = System.Drawing.Color.White;
            this.contactInputPhoneLabel.Name = "contactInputPhoneLabel";
            // 
            // contactPhone
            // 
            resources.ApplyResources(this.contactPhone, "contactPhone");
            this.contactPhone.ForeColor = System.Drawing.Color.White;
            this.contactPhone.Name = "contactPhone";
            // 
            // time
            // 
            resources.ApplyResources(this.time, "time");
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Name = "time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_actions
            // 
            resources.ApplyResources(this.panel_actions, "panel_actions");
            this.panel_actions.Name = "panel_actions";
            // 
            // button_continue
            // 
            resources.ApplyResources(this.button_continue, "button_continue");
            this.button_continue.BackColor = System.Drawing.Color.DarkGreen;
            this.button_continue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_continue.Name = "button_continue";
            this.button_continue.UseVisualStyleBackColor = false;
            this.button_continue.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_to_main
            // 
            resources.ApplyResources(this.button_to_main, "button_to_main");
            this.button_to_main.BackColor = System.Drawing.SystemColors.WindowFrame;
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
            resources.ApplyResources(this.panelInputPhoneNumber, "panelInputPhoneNumber");
            this.panelInputPhoneNumber.Controls.Add(this.button_continue);
            this.panelInputPhoneNumber.Controls.Add(this.button_to_main);
            this.panelInputPhoneNumber.Controls.Add(this.panel1);
            this.panelInputPhoneNumber.Controls.Add(this.label_phone_number);
            this.panelInputPhoneNumber.Name = "panelInputPhoneNumber";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.button_number_3);
            this.panel1.Controls.Add(this.button_number_back);
            this.panel1.Controls.Add(this.button_number_1);
            this.panel1.Controls.Add(this.button_number_del);
            this.panel1.Controls.Add(this.button_number_2);
            this.panel1.Controls.Add(this.button_number_0);
            this.panel1.Controls.Add(this.button_number_4);
            this.panel1.Controls.Add(this.button_number_9);
            this.panel1.Controls.Add(this.button_number_5);
            this.panel1.Controls.Add(this.button_number_8);
            this.panel1.Controls.Add(this.button_number_6);
            this.panel1.Controls.Add(this.button_number_7);
            this.panel1.Name = "panel1";
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
            // button_number_back
            // 
            this.button_number_back.BackColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.button_number_back, "button_number_back");
            this.button_number_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_number_back.Name = "button_number_back";
            this.button_number_back.UseVisualStyleBackColor = false;
            this.button_number_back.Click += new System.EventHandler(this.button_number_back_Click);
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
            // button_number_del
            // 
            this.button_number_del.BackColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.button_number_del, "button_number_del");
            this.button_number_del.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_number_del.Name = "button_number_del";
            this.button_number_del.UseVisualStyleBackColor = false;
            this.button_number_del.Click += new System.EventHandler(this.button_number_del_Click);
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
            // button_number_0
            // 
            this.button_number_0.BackColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.button_number_0, "button_number_0");
            this.button_number_0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_number_0.Name = "button_number_0";
            this.button_number_0.UseVisualStyleBackColor = false;
            this.button_number_0.Click += new System.EventHandler(this.button_number_0_Click);
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
            // button_number_9
            // 
            this.button_number_9.BackColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.button_number_9, "button_number_9");
            this.button_number_9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_number_9.Name = "button_number_9";
            this.button_number_9.UseVisualStyleBackColor = false;
            this.button_number_9.Click += new System.EventHandler(this.button_number_9_Click);
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
            // button_number_8
            // 
            this.button_number_8.BackColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.button_number_8, "button_number_8");
            this.button_number_8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_number_8.Name = "button_number_8";
            this.button_number_8.UseVisualStyleBackColor = false;
            this.button_number_8.Click += new System.EventHandler(this.button_number_8_Click);
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
            // button_number_7
            // 
            this.button_number_7.BackColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.button_number_7, "button_number_7");
            this.button_number_7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_number_7.Name = "button_number_7";
            this.button_number_7.UseVisualStyleBackColor = false;
            this.button_number_7.Click += new System.EventHandler(this.button_number_7_Click);
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
            resources.ApplyResources(this.panel_confirm_number, "panel_confirm_number");
            this.panel_confirm_number.Controls.Add(this.confirmTextLabel);
            this.panel_confirm_number.Controls.Add(this.label_confirm_phone_number);
            this.panel_confirm_number.Controls.Add(this.button_decline_phone_number);
            this.panel_confirm_number.Controls.Add(this.button_confirm_phone_number);
            this.panel_confirm_number.Name = "panel_confirm_number";
            // 
            // confirmTextLabel
            // 
            resources.ApplyResources(this.confirmTextLabel, "confirmTextLabel");
            this.confirmTextLabel.Name = "confirmTextLabel";
            // 
            // label_confirm_phone_number
            // 
            resources.ApplyResources(this.label_confirm_phone_number, "label_confirm_phone_number");
            this.label_confirm_phone_number.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_confirm_phone_number.Name = "label_confirm_phone_number";
            // 
            // button_decline_phone_number
            // 
            resources.ApplyResources(this.button_decline_phone_number, "button_decline_phone_number");
            this.button_decline_phone_number.BackColor = System.Drawing.Color.DarkRed;
            this.button_decline_phone_number.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_decline_phone_number.Name = "button_decline_phone_number";
            this.button_decline_phone_number.UseVisualStyleBackColor = false;
            this.button_decline_phone_number.Click += new System.EventHandler(this.button_decline_phone_number_Click);
            // 
            // button_confirm_phone_number
            // 
            resources.ApplyResources(this.button_confirm_phone_number, "button_confirm_phone_number");
            this.button_confirm_phone_number.BackColor = System.Drawing.Color.DarkGreen;
            this.button_confirm_phone_number.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_confirm_phone_number.Name = "button_confirm_phone_number";
            this.button_confirm_phone_number.UseVisualStyleBackColor = false;
            this.button_confirm_phone_number.Click += new System.EventHandler(this.button_confirm_phone_number_Click);
            // 
            // panel_accept_payment
            // 
            resources.ApplyResources(this.panel_accept_payment, "panel_accept_payment");
            this.panel_accept_payment.Controls.Add(this.button_payPanal_home);
            this.panel_accept_payment.Controls.Add(this.button_accept_bill_pay);
            this.panel_accept_payment.Controls.Add(this.label_accept_bill_phone);
            this.panel_accept_payment.Controls.Add(this.label_accept_bill_total);
            this.panel_accept_payment.Name = "panel_accept_payment";
            this.panel_accept_payment.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_accept_payment_Paint);
            // 
            // button_payPanal_home
            // 
            resources.ApplyResources(this.button_payPanal_home, "button_payPanal_home");
            this.button_payPanal_home.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_payPanal_home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_payPanal_home.Name = "button_payPanal_home";
            this.button_payPanal_home.UseVisualStyleBackColor = false;
            this.button_payPanal_home.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_accept_bill_pay
            // 
            resources.ApplyResources(this.button_accept_bill_pay, "button_accept_bill_pay");
            this.button_accept_bill_pay.BackColor = System.Drawing.Color.DarkGreen;
            this.button_accept_bill_pay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_accept_bill_pay.Name = "button_accept_bill_pay";
            this.button_accept_bill_pay.UseVisualStyleBackColor = false;
            this.button_accept_bill_pay.Click += new System.EventHandler(this.button_accept_bill_pay_ClickAsync);
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
            resources.ApplyResources(this.panel_success, "panel_success");
            this.panel_success.BackColor = System.Drawing.Color.Green;
            this.panel_success.Controls.Add(this.successLabel1);
            this.panel_success.Controls.Add(this.successLabel2);
            this.panel_success.Name = "panel_success";
            this.panel_success.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // successLabel1
            // 
            resources.ApplyResources(this.successLabel1, "successLabel1");
            this.successLabel1.BackColor = System.Drawing.Color.Transparent;
            this.successLabel1.ForeColor = System.Drawing.Color.White;
            this.successLabel1.Name = "successLabel1";
            // 
            // successLabel2
            // 
            resources.ApplyResources(this.successLabel2, "successLabel2");
            this.successLabel2.BackColor = System.Drawing.Color.Transparent;
            this.successLabel2.ForeColor = System.Drawing.Color.White;
            this.successLabel2.Name = "successLabel2";
            // 
            // success_hide_timer
            // 
            this.success_hide_timer.Interval = 5000;
            this.success_hide_timer.Tick += new System.EventHandler(this.success_hide_timer_Tick);
            // 
            // pingTimer
            // 
            this.pingTimer.Enabled = true;
            this.pingTimer.Interval = 1000000;
            this.pingTimer.Tick += new System.EventHandler(this.pingTimer_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel_actions);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelInputPhoneNumber);
            this.Controls.Add(this.panel_success);
            this.Controls.Add(this.panel_accept_payment);
            this.Controls.Add(this.panel_confirm_number);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelInputPhoneNumber.ResumeLayout(false);
            this.panelInputPhoneNumber.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel_confirm_number.ResumeLayout(false);
            this.panel_confirm_number.PerformLayout();
            this.panel_accept_payment.ResumeLayout(false);
            this.panel_accept_payment.PerformLayout();
            this.panel_success.ResumeLayout(false);
            this.panel_success.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelMain;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label time;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel_actions;
        public System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Panel panelInputPhoneNumber;
        public System.Windows.Forms.Label label_phone_number;
        public System.Windows.Forms.Button button_number_9;
        public System.Windows.Forms.Button button_number_8;
        public System.Windows.Forms.Button button_number_7;
        public System.Windows.Forms.Button button_number_6;
        public System.Windows.Forms.Button button_number_5;
        public System.Windows.Forms.Button button_number_4;
        public System.Windows.Forms.Button button_number_3;
        public System.Windows.Forms.Button button_number_2;
        public System.Windows.Forms.Button button_number_1;
        public System.Windows.Forms.Button button_number_back;
        public System.Windows.Forms.Button button_number_del;
        public System.Windows.Forms.Button button_number_0;
        public System.Windows.Forms.Button button_to_main;
        public System.Windows.Forms.Button button_continue;
        public System.Windows.Forms.Panel panel_confirm_number;
        public System.Windows.Forms.Label confirmTextLabel;
        public System.Windows.Forms.Button button_decline_phone_number;
        public System.Windows.Forms.Button button_confirm_phone_number;
        public System.Windows.Forms.Label label_confirm_phone_number;
        public System.Windows.Forms.Panel panel_accept_payment;
        public System.Windows.Forms.Label label_accept_bill_phone;
        public System.Windows.Forms.Label label_accept_bill_total;
        public System.Windows.Forms.Button button_accept_bill_pay;
        public System.Windows.Forms.Button button_payPanal_home;
        public System.Windows.Forms.Timer success_hide_timer;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label successLabel1;
        public System.Windows.Forms.Label successLabel2;
        public System.Windows.Forms.Panel panel_success;
        public System.Windows.Forms.Label contactPhone;
        public System.Windows.Forms.Label contactInputPhoneLabel;
        public System.Windows.Forms.Label terminalNumberLabel;
        public System.Windows.Forms.Label terminalNumberTextLabel;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer pingTimer;
        private System.Windows.Forms.Label label1;
    }
}

