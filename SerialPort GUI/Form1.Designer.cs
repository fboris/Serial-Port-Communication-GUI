namespace SerialPort_GUI
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.msgDisplayTextBox = new System.Windows.Forms.TextBox();
            this.openPortButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openSaveFileDialogButton = new System.Windows.Forms.Button();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.portNumberComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.writeTimeOutTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sendPeriodTextBox = new System.Windows.Forms.TextBox();
            this.isSendCheckBox = new System.Windows.Forms.CheckBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.sendMsgTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.isSaveFileCheckBox = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgDisplayTextBox
            // 
            this.msgDisplayTextBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.msgDisplayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msgDisplayTextBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.msgDisplayTextBox.Location = new System.Drawing.Point(12, 12);
            this.msgDisplayTextBox.Multiline = true;
            this.msgDisplayTextBox.Name = "msgDisplayTextBox";
            this.msgDisplayTextBox.ReadOnly = true;
            this.msgDisplayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msgDisplayTextBox.Size = new System.Drawing.Size(782, 188);
            this.msgDisplayTextBox.TabIndex = 0;
            this.msgDisplayTextBox.TextChanged += new System.EventHandler(this.msgDisplayTextBox_TextChanged);
            // 
            // openPortButton
            // 
            this.openPortButton.Location = new System.Drawing.Point(12, 324);
            this.openPortButton.Name = "openPortButton";
            this.openPortButton.Size = new System.Drawing.Size(75, 23);
            this.openPortButton.TabIndex = 1;
            this.openPortButton.Text = "Open";
            this.openPortButton.UseVisualStyleBackColor = true;
            this.openPortButton.Click += new System.EventHandler(this.openPortButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "File Path";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Enabled = false;
            this.filePathTextBox.HideSelection = false;
            this.filePathTextBox.Location = new System.Drawing.Point(129, 288);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(120, 22);
            this.filePathTextBox.TabIndex = 7;
            // 
            // openSaveFileDialogButton
            // 
            this.openSaveFileDialogButton.Enabled = false;
            this.openSaveFileDialogButton.Location = new System.Drawing.Point(255, 290);
            this.openSaveFileDialogButton.Name = "openSaveFileDialogButton";
            this.openSaveFileDialogButton.Size = new System.Drawing.Size(24, 22);
            this.openSaveFileDialogButton.TabIndex = 8;
            this.openSaveFileDialogButton.Text = "...";
            this.openSaveFileDialogButton.UseVisualStyleBackColor = true;
            this.openSaveFileDialogButton.Click += new System.EventHandler(this.openSaveFileDialogButton_Click);
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baudRateComboBox.Location = new System.Drawing.Point(70, 248);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(121, 20);
            this.baudRateComboBox.TabIndex = 9;
            this.baudRateComboBox.Text = "115200";
            // 
            // portNumberComboBox
            // 
            this.portNumberComboBox.FormattingEnabled = true;
            this.portNumberComboBox.Location = new System.Drawing.Point(70, 208);
            this.portNumberComboBox.Name = "portNumberComboBox";
            this.portNumberComboBox.Size = new System.Drawing.Size(121, 20);
            this.portNumberComboBox.TabIndex = 10;
            this.portNumberComboBox.Tag = "COM1";
            this.portNumberComboBox.DropDown += new System.EventHandler(this.portNumberComboBox_DropDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.writeTimeOutTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sendPeriodTextBox);
            this.groupBox1.Controls.Add(this.isSendCheckBox);
            this.groupBox1.Controls.Add(this.sendButton);
            this.groupBox1.Controls.Add(this.sendMsgTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(285, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 107);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "ms";
            // 
            // writeTimeOutTextBox
            // 
            this.writeTimeOutTextBox.Location = new System.Drawing.Point(90, 18);
            this.writeTimeOutTextBox.Name = "writeTimeOutTextBox";
            this.writeTimeOutTextBox.Size = new System.Drawing.Size(100, 22);
            this.writeTimeOutTextBox.TabIndex = 16;
            this.writeTimeOutTextBox.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "Write Time Out";
            // 
            // sendPeriodTextBox
            // 
            this.sendPeriodTextBox.Enabled = false;
            this.sendPeriodTextBox.Location = new System.Drawing.Point(198, 80);
            this.sendPeriodTextBox.Name = "sendPeriodTextBox";
            this.sendPeriodTextBox.Size = new System.Drawing.Size(120, 22);
            this.sendPeriodTextBox.TabIndex = 15;
            // 
            // isSendCheckBox
            // 
            this.isSendCheckBox.AutoSize = true;
            this.isSendCheckBox.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.isSendCheckBox.Location = new System.Drawing.Point(90, 87);
            this.isSendCheckBox.Name = "isSendCheckBox";
            this.isSendCheckBox.Size = new System.Drawing.Size(111, 16);
            this.isSendCheckBox.TabIndex = 15;
            this.isSendCheckBox.Text = "Send Periodically :";
            this.isSendCheckBox.UseVisualStyleBackColor = true;
            this.isSendCheckBox.CheckedChanged += new System.EventHandler(this.isSendCheckBox_CheckedChanged);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(394, 21);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 54);
            this.sendButton.TabIndex = 13;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // sendMsgTextBox
            // 
            this.sendMsgTextBox.Location = new System.Drawing.Point(90, 48);
            this.sendMsgTextBox.Name = "sendMsgTextBox";
            this.sendMsgTextBox.Size = new System.Drawing.Size(298, 22);
            this.sendMsgTextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "Send Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "ms";
            // 
            // isSaveFileCheckBox
            // 
            this.isSaveFileCheckBox.AutoSize = true;
            this.isSaveFileCheckBox.Location = new System.Drawing.Point(12, 294);
            this.isSaveFileCheckBox.Name = "isSaveFileCheckBox";
            this.isSaveFileCheckBox.Size = new System.Drawing.Size(69, 16);
            this.isSaveFileCheckBox.TabIndex = 13;
            this.isSaveFileCheckBox.Text = "Save File:";
            this.isSaveFileCheckBox.UseVisualStyleBackColor = true;
            this.isSaveFileCheckBox.CheckedChanged += new System.EventHandler(this.isSaveFileCheckBox_CheckedChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(719, 211);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 355);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.isSaveFileCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.portNumberComboBox);
            this.Controls.Add(this.baudRateComboBox);
            this.Controls.Add(this.openSaveFileDialogButton);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openPortButton);
            this.Controls.Add(this.msgDisplayTextBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "USART Recevier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox msgDisplayTextBox;
        private System.Windows.Forms.Button openPortButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button openSaveFileDialogButton;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox portNumberComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox sendMsgTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox isSaveFileCheckBox;
        private System.Windows.Forms.TextBox sendPeriodTextBox;
        private System.Windows.Forms.CheckBox isSendCheckBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox writeTimeOutTextBox;
        private System.Windows.Forms.Label label6;
    }
}

