namespace DM280
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnTrigger = new System.Windows.Forms.Button();
            this.txtMasterCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMasterCode = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxCRLF = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDisConnectPLC = new System.Windows.Forms.Button();
            this.btnConnectPLC = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbOKNG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DtrEnable = true;
            this.serialPort1.PortName = "COM7";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(31, 42);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(125, 42);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 0;
            this.btnDisconnect.Text = "DisConnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnTrigger
            // 
            this.btnTrigger.Location = new System.Drawing.Point(224, 42);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(75, 23);
            this.btnTrigger.TabIndex = 0;
            this.btnTrigger.Text = "Trigger";
            this.btnTrigger.UseVisualStyleBackColor = true;
            this.btnTrigger.Click += new System.EventHandler(this.btnTrigger_Click);
            // 
            // txtMasterCode
            // 
            this.txtMasterCode.Location = new System.Drawing.Point(102, 125);
            this.txtMasterCode.Name = "txtMasterCode";
            this.txtMasterCode.Size = new System.Drawing.Size(150, 20);
            this.txtMasterCode.TabIndex = 1;
            this.txtMasterCode.TextChanged += new System.EventHandler(this.txtMasterCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Master Code";
            // 
            // btnMasterCode
            // 
            this.btnMasterCode.Location = new System.Drawing.Point(271, 123);
            this.btnMasterCode.Name = "btnMasterCode";
            this.btnMasterCode.Size = new System.Drawing.Size(75, 23);
            this.btnMasterCode.TabIndex = 3;
            this.btnMasterCode.Text = "Save";
            this.btnMasterCode.UseVisualStyleBackColor = true;
            this.btnMasterCode.Click += new System.EventHandler(this.btnMasterCode_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(102, 198);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(142, 20);
            this.txtData.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data";
            // 
            // checkBoxCRLF
            // 
            this.checkBoxCRLF.AutoSize = true;
            this.checkBoxCRLF.Location = new System.Drawing.Point(108, 155);
            this.checkBoxCRLF.Name = "checkBoxCRLF";
            this.checkBoxCRLF.Size = new System.Drawing.Size(45, 17);
            this.checkBoxCRLF.TabIndex = 6;
            this.checkBoxCRLF.Text = "\\r\\n";
            this.checkBoxCRLF.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DM280";
            // 
            // btnDisConnectPLC
            // 
            this.btnDisConnectPLC.Location = new System.Drawing.Point(586, 42);
            this.btnDisConnectPLC.Name = "btnDisConnectPLC";
            this.btnDisConnectPLC.Size = new System.Drawing.Size(95, 23);
            this.btnDisConnectPLC.TabIndex = 8;
            this.btnDisConnectPLC.Text = "DisConnect PLC";
            this.btnDisConnectPLC.UseVisualStyleBackColor = true;
            this.btnDisConnectPLC.Click += new System.EventHandler(this.btnDisConnectPLC_Click);
            // 
            // btnConnectPLC
            // 
            this.btnConnectPLC.Location = new System.Drawing.Point(457, 42);
            this.btnConnectPLC.Name = "btnConnectPLC";
            this.btnConnectPLC.Size = new System.Drawing.Size(95, 23);
            this.btnConnectPLC.TabIndex = 8;
            this.btnConnectPLC.Text = "Connect PLC";
            this.btnConnectPLC.UseVisualStyleBackColor = true;
            this.btnConnectPLC.Click += new System.EventHandler(this.btnConnectPLC_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(454, 85);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 9;
            this.lbStatus.Text = "Status";
            // 
            // lbOKNG
            // 
            this.lbOKNG.AutoSize = true;
            this.lbOKNG.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbOKNG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbOKNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOKNG.ForeColor = System.Drawing.Color.Red;
            this.lbOKNG.Location = new System.Drawing.Point(289, 182);
            this.lbOKNG.MaximumSize = new System.Drawing.Size(100, 100);
            this.lbOKNG.MinimumSize = new System.Drawing.Size(10, 10);
            this.lbOKNG.Name = "lbOKNG";
            this.lbOKNG.Size = new System.Drawing.Size(62, 64);
            this.lbOKNG.TabIndex = 10;
            this.lbOKNG.Text = "OK NG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbOKNG);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnConnectPLC);
            this.Controls.Add(this.btnDisConnectPLC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxCRLF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnMasterCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMasterCode);
            this.Controls.Add(this.btnTrigger);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnTrigger;
        private System.Windows.Forms.TextBox txtMasterCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMasterCode;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxCRLF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDisConnectPLC;
        private System.Windows.Forms.Button btnConnectPLC;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbOKNG;
    }
}

