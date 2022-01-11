namespace ParkingChargeCalculator
{
    partial class MainFrm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Fee_Setting = new System.Windows.Forms.Button();
            this.tbx_PrkInfoDescliption = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_CarInTime = new System.Windows.Forms.TextBox();
            this.tbx_CarOutTime = new System.Windows.Forms.TextBox();
            this.btn_CarIn_Now = new System.Windows.Forms.Button();
            this.btn_CarOut_Now = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(100)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 36);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "주차요금계산기";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(100)))), ((int)(((byte)(212)))));
            this.panel2.Location = new System.Drawing.Point(-4, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 14);
            this.panel2.TabIndex = 1;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(100)))), ((int)(((byte)(212)))));
            this.btn_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calculate.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Calculate.ForeColor = System.Drawing.Color.White;
            this.btn_Calculate.Location = new System.Drawing.Point(127, 277);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(98, 31);
            this.btn_Calculate.TabIndex = 2;
            this.btn_Calculate.Text = "계산";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Fee_Setting
            // 
            this.btn_Fee_Setting.BackColor = System.Drawing.Color.Peru;
            this.btn_Fee_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fee_Setting.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Fee_Setting.ForeColor = System.Drawing.Color.White;
            this.btn_Fee_Setting.Location = new System.Drawing.Point(268, 39);
            this.btn_Fee_Setting.Name = "btn_Fee_Setting";
            this.btn_Fee_Setting.Size = new System.Drawing.Size(72, 23);
            this.btn_Fee_Setting.TabIndex = 3;
            this.btn_Fee_Setting.Text = "주차요금설정";
            this.btn_Fee_Setting.UseVisualStyleBackColor = false;
            this.btn_Fee_Setting.Click += new System.EventHandler(this.btn_Fee_Setting_Click);
            // 
            // tbx_PrkInfoDescliption
            // 
            this.tbx_PrkInfoDescliption.Location = new System.Drawing.Point(9, 66);
            this.tbx_PrkInfoDescliption.Multiline = true;
            this.tbx_PrkInfoDescliption.Name = "tbx_PrkInfoDescliption";
            this.tbx_PrkInfoDescliption.Size = new System.Drawing.Size(330, 92);
            this.tbx_PrkInfoDescliption.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어_ac", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(9, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "입차시간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어_ac", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(9, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "출차시간";
            // 
            // tbx_CarInTime
            // 
            this.tbx_CarInTime.Location = new System.Drawing.Point(66, 191);
            this.tbx_CarInTime.Name = "tbx_CarInTime";
            this.tbx_CarInTime.Size = new System.Drawing.Size(158, 21);
            this.tbx_CarInTime.TabIndex = 7;
            this.tbx_CarInTime.Text = "HH:mm:ss";
            // 
            // tbx_CarOutTime
            // 
            this.tbx_CarOutTime.Location = new System.Drawing.Point(66, 225);
            this.tbx_CarOutTime.Name = "tbx_CarOutTime";
            this.tbx_CarOutTime.Size = new System.Drawing.Size(158, 21);
            this.tbx_CarOutTime.TabIndex = 8;
            this.tbx_CarOutTime.Text = "HH:mm:ss";
            // 
            // btn_CarIn_Now
            // 
            this.btn_CarIn_Now.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(100)))), ((int)(((byte)(212)))));
            this.btn_CarIn_Now.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CarIn_Now.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_CarIn_Now.ForeColor = System.Drawing.Color.White;
            this.btn_CarIn_Now.Location = new System.Drawing.Point(241, 189);
            this.btn_CarIn_Now.Name = "btn_CarIn_Now";
            this.btn_CarIn_Now.Size = new System.Drawing.Size(98, 25);
            this.btn_CarIn_Now.TabIndex = 9;
            this.btn_CarIn_Now.Text = "현재시간";
            this.btn_CarIn_Now.UseVisualStyleBackColor = false;
            this.btn_CarIn_Now.Click += new System.EventHandler(this.btn_CarIn_Now_Click);
            // 
            // btn_CarOut_Now
            // 
            this.btn_CarOut_Now.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(100)))), ((int)(((byte)(212)))));
            this.btn_CarOut_Now.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CarOut_Now.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_CarOut_Now.ForeColor = System.Drawing.Color.White;
            this.btn_CarOut_Now.Location = new System.Drawing.Point(241, 223);
            this.btn_CarOut_Now.Name = "btn_CarOut_Now";
            this.btn_CarOut_Now.Size = new System.Drawing.Size(98, 25);
            this.btn_CarOut_Now.TabIndex = 10;
            this.btn_CarOut_Now.Text = "현재시간";
            this.btn_CarOut_Now.UseVisualStyleBackColor = false;
            this.btn_CarOut_Now.Click += new System.EventHandler(this.btn_CarOut_Now_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(345, 332);
            this.Controls.Add(this.btn_CarOut_Now);
            this.Controls.Add(this.btn_CarIn_Now);
            this.Controls.Add(this.tbx_CarOutTime);
            this.Controls.Add(this.tbx_CarInTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_PrkInfoDescliption);
            this.Controls.Add(this.btn_Fee_Setting);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parking Charge Calculator";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Fee_Setting;
        private System.Windows.Forms.TextBox tbx_PrkInfoDescliption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_CarInTime;
        private System.Windows.Forms.TextBox tbx_CarOutTime;
        private System.Windows.Forms.Button btn_CarIn_Now;
        private System.Windows.Forms.Button btn_CarOut_Now;
    }
}

