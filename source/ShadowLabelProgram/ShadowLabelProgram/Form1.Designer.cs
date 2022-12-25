namespace ShadowLabelProgram
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.shadowLabelWithFliker1 = new ShadowLabelProgram.ShadowLabelWithFliker();
            this.shadowLabel1 = new ShadowLabelProgram.ShadowLabel();
            this.SuspendLayout();
            // 
            // shadowLabelWithFliker1
            // 
            this.shadowLabelWithFliker1.AutoSize = true;
            this.shadowLabelWithFliker1.BackForeColor = System.Drawing.Color.Black;
            this.shadowLabelWithFliker1.DX = 1;
            this.shadowLabelWithFliker1.DY = 1;
            this.shadowLabelWithFliker1.FlikerEnable = true;
            this.shadowLabelWithFliker1.FlikerInterval = 300;
            this.shadowLabelWithFliker1.ForeColor = System.Drawing.Color.White;
            this.shadowLabelWithFliker1.Location = new System.Drawing.Point(204, 109);
            this.shadowLabelWithFliker1.Name = "shadowLabelWithFliker1";
            this.shadowLabelWithFliker1.Size = new System.Drawing.Size(251, 12);
            this.shadowLabelWithFliker1.TabIndex = 1;
            this.shadowLabelWithFliker1.Text = "이 컨트롤은 그림자 + 깜빡이는 컨트롤입니다.";
            // 
            // shadowLabel1
            // 
            this.shadowLabel1.AutoSize = true;
            this.shadowLabel1.BackForeColor = System.Drawing.Color.Black;
            this.shadowLabel1.DX = 1;
            this.shadowLabel1.DY = 1;
            this.shadowLabel1.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.shadowLabel1.ForeColor = System.Drawing.Color.White;
            this.shadowLabel1.Location = new System.Drawing.Point(12, 9);
            this.shadowLabel1.Name = "shadowLabel1";
            this.shadowLabel1.Size = new System.Drawing.Size(656, 35);
            this.shadowLabel1.TabIndex = 0;
            this.shadowLabel1.Text = "이 컨트롤은 그림자 라벨 컨트롤입니다.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(676, 214);
            this.Controls.Add(this.shadowLabelWithFliker1);
            this.Controls.Add(this.shadowLabel1);
            this.Name = "Form1";
            this.Text = "그림자 라벨 컨트롤";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShadowLabel shadowLabel1;
        private ShadowLabelWithFliker shadowLabelWithFliker1;
    }
}

