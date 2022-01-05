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
            // 
            // btn_Fee_Setting
            // 
            this.btn_Fee_Setting.BackColor = System.Drawing.Color.Gray;
            this.btn_Fee_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fee_Setting.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Fee_Setting.ForeColor = System.Drawing.Color.White;
            this.btn_Fee_Setting.Location = new System.Drawing.Point(268, 39);
            this.btn_Fee_Setting.Name = "btn_Fee_Setting";
            this.btn_Fee_Setting.Size = new System.Drawing.Size(72, 23);
            this.btn_Fee_Setting.TabIndex = 3;
            this.btn_Fee_Setting.Text = "주차요금설정";
            this.btn_Fee_Setting.UseVisualStyleBackColor = false;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(345, 332);
            this.Controls.Add(this.btn_Fee_Setting);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parking Charge Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Fee_Setting;
    }
}

