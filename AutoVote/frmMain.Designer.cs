namespace AutoVote
{
    partial class frmMain
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbEntryName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.gbPPPOE = new System.Windows.Forms.GroupBox();
            this.lbEntryName = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassrod = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbURL = new System.Windows.Forms.Label();
            this.lbInterval = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbInfo = new System.Windows.Forms.Label();
            this.gbPPPOE.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(70, 49);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 22);
            this.tbUsername.TabIndex = 2;
            // 
            // tbEntryName
            // 
            this.tbEntryName.Location = new System.Drawing.Point(70, 21);
            this.tbEntryName.Name = "tbEntryName";
            this.tbEntryName.Size = new System.Drawing.Size(100, 22);
            this.tbEntryName.TabIndex = 1;
            this.tbEntryName.Text = "ISP";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(70, 77);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 22);
            this.tbPassword.TabIndex = 3;
            // 
            // gbPPPOE
            // 
            this.gbPPPOE.Controls.Add(this.lbPassrod);
            this.gbPPPOE.Controls.Add(this.lbEntryName);
            this.gbPPPOE.Controls.Add(this.lbUsername);
            this.gbPPPOE.Controls.Add(this.tbEntryName);
            this.gbPPPOE.Controls.Add(this.tbPassword);
            this.gbPPPOE.Controls.Add(this.tbUsername);
            this.gbPPPOE.Location = new System.Drawing.Point(12, 12);
            this.gbPPPOE.Name = "gbPPPOE";
            this.gbPPPOE.Size = new System.Drawing.Size(200, 106);
            this.gbPPPOE.TabIndex = 4;
            this.gbPPPOE.TabStop = false;
            this.gbPPPOE.Text = "PPPoE";
            // 
            // lbEntryName
            // 
            this.lbEntryName.AutoSize = true;
            this.lbEntryName.Location = new System.Drawing.Point(6, 24);
            this.lbEntryName.Name = "lbEntryName";
            this.lbEntryName.Size = new System.Drawing.Size(61, 12);
            this.lbEntryName.TabIndex = 5;
            this.lbEntryName.Text = "EntryName:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(13, 52);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(54, 12);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "Username:";
            // 
            // lbPassrod
            // 
            this.lbPassrod.AutoSize = true;
            this.lbPassrod.Location = new System.Drawing.Point(13, 80);
            this.lbPassrod.Name = "lbPassrod";
            this.lbPassrod.Size = new System.Drawing.Size(51, 12);
            this.lbPassrod.TabIndex = 6;
            this.lbPassrod.Text = "Password:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbInfo);
            this.groupBox1.Controls.Add(this.lbCount);
            this.groupBox1.Controls.Add(this.lbInterval);
            this.groupBox1.Controls.Add(this.lbURL);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.tbCount);
            this.groupBox1.Controls.Add(this.tbURL);
            this.groupBox1.Controls.Add(this.tbInterval);
            this.groupBox1.Location = new System.Drawing.Point(12, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 132);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(70, 50);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(31, 22);
            this.tbInterval.TabIndex = 0;
            this.tbInterval.Text = "10000";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(70, 21);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(100, 22);
            this.tbURL.TabIndex = 1;
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(70, 78);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(31, 22);
            this.tbCount.TabIndex = 2;
            this.tbCount.Text = "1000";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 259);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(222, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(107, 50);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(64, 50);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(33, 24);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(31, 12);
            this.lbURL.TabIndex = 7;
            this.lbURL.Text = "URL:";
            // 
            // lbInterval
            // 
            this.lbInterval.AutoSize = true;
            this.lbInterval.Location = new System.Drawing.Point(20, 53);
            this.lbInterval.Name = "lbInterval";
            this.lbInterval.Size = new System.Drawing.Size(44, 12);
            this.lbInterval.TabIndex = 8;
            this.lbInterval.Text = "Interval:";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(27, 81);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(37, 12);
            this.lbCount.TabIndex = 9;
            this.lbCount.Text = "Count:";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(33, 17);
            this.tsslStatus.Text = "Init...";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbInfo.Location = new System.Drawing.Point(80, 106);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(12, 16);
            this.lbInfo.TabIndex = 10;
            this.lbInfo.Text = " ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 281);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPPPOE);
            this.Name = "frmMain";
            this.Text = "AutoVote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.gbPPPOE.ResumeLayout(false);
            this.gbPPPOE.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbEntryName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.GroupBox gbPPPOE;
        private System.Windows.Forms.Label lbPassrod;
        private System.Windows.Forms.Label lbEntryName;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label lbInterval;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.Label lbInfo;
    }
}

