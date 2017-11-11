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
            this.lbPassrod = new System.Windows.Forms.Label();
            this.lbEntryName = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.gbVote = new System.Windows.Forms.GroupBox();
            this.lbHit = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.lbInterval = new System.Windows.Forms.Label();
            this.lbURL = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_spring = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_ip = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbPPPOE.SuspendLayout();
            this.gbVote.SuspendLayout();
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
            // lbPassrod
            // 
            this.lbPassrod.AutoSize = true;
            this.lbPassrod.Location = new System.Drawing.Point(13, 80);
            this.lbPassrod.Name = "lbPassrod";
            this.lbPassrod.Size = new System.Drawing.Size(51, 12);
            this.lbPassrod.TabIndex = 6;
            this.lbPassrod.Text = "Password:";
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
            // gbVote
            // 
            this.gbVote.Controls.Add(this.lbHit);
            this.gbVote.Controls.Add(this.lbInfo);
            this.gbVote.Controls.Add(this.lbCount);
            this.gbVote.Controls.Add(this.lbInterval);
            this.gbVote.Controls.Add(this.lbURL);
            this.gbVote.Controls.Add(this.btnStart);
            this.gbVote.Controls.Add(this.tbCount);
            this.gbVote.Controls.Add(this.tbURL);
            this.gbVote.Controls.Add(this.tbInterval);
            this.gbVote.Location = new System.Drawing.Point(12, 124);
            this.gbVote.Name = "gbVote";
            this.gbVote.Size = new System.Drawing.Size(200, 132);
            this.gbVote.TabIndex = 5;
            this.gbVote.TabStop = false;
            this.gbVote.Text = "Vote";
            // 
            // lbHit
            // 
            this.lbHit.AutoSize = true;
            this.lbHit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbHit.Location = new System.Drawing.Point(115, 113);
            this.lbHit.Name = "lbHit";
            this.lbHit.Size = new System.Drawing.Size(32, 16);
            this.lbHit.TabIndex = 11;
            this.lbHit.Text = " 0/0";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbInfo.Location = new System.Drawing.Point(35, 113);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(32, 16);
            this.lbInfo.TabIndex = 10;
            this.lbInfo.Text = " 0/0";
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
            // lbInterval
            // 
            this.lbInterval.AutoSize = true;
            this.lbInterval.Location = new System.Drawing.Point(20, 53);
            this.lbInterval.Name = "lbInterval";
            this.lbInterval.Size = new System.Drawing.Size(44, 12);
            this.lbInterval.TabIndex = 8;
            this.lbInterval.Text = "Interval:";
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
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(70, 78);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(31, 22);
            this.tbCount.TabIndex = 2;
            this.tbCount.Text = "1000";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(70, 21);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(100, 22);
            this.tbURL.TabIndex = 1;
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(70, 50);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(31, 22);
            this.tbInterval.TabIndex = 0;
            this.tbInterval.Text = "500";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus,
            this.tssl_spring,
            this.tssl_ip});
            this.statusStrip.Location = new System.Drawing.Point(0, 264);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(211, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(33, 17);
            this.tsslStatus.Text = "Init...";
            // 
            // tssl_spring
            // 
            this.tssl_spring.Name = "tssl_spring";
            this.tssl_spring.Size = new System.Drawing.Size(63, 17);
            this.tssl_spring.Spring = true;
            // 
            // tssl_ip
            // 
            this.tssl_ip.Name = "tssl_ip";
            this.tssl_ip.Size = new System.Drawing.Size(100, 17);
            this.tssl_ip.Text = "255.255.255.255";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 286);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbVote);
            this.Controls.Add(this.gbPPPOE);
            this.Name = "frmMain";
            this.Text = "AutoVote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.gbPPPOE.ResumeLayout(false);
            this.gbPPPOE.PerformLayout();
            this.gbVote.ResumeLayout(false);
            this.gbVote.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbVote;
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
        private System.Windows.Forms.Label lbHit;
        private System.Windows.Forms.ToolStripStatusLabel tssl_spring;
        private System.Windows.Forms.ToolStripStatusLabel tssl_ip;
    }
}

