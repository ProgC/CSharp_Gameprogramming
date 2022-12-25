namespace KeyboardProcess
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
            this.chkArrowUp = new System.Windows.Forms.CheckBox();
            this.chkArrowDown = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkArrowUp
            // 
            this.chkArrowUp.AutoSize = true;
            this.chkArrowUp.Location = new System.Drawing.Point(67, 41);
            this.chkArrowUp.Name = "chkArrowUp";
            this.chkArrowUp.Size = new System.Drawing.Size(76, 16);
            this.chkArrowUp.TabIndex = 0;
            this.chkArrowUp.Text = "화살표 위";
            this.chkArrowUp.UseVisualStyleBackColor = true;
            // 
            // chkArrowDown
            // 
            this.chkArrowDown.AutoSize = true;
            this.chkArrowDown.Location = new System.Drawing.Point(67, 63);
            this.chkArrowDown.Name = "chkArrowDown";
            this.chkArrowDown.Size = new System.Drawing.Size(88, 16);
            this.chkArrowDown.TabIndex = 0;
            this.chkArrowDown.Text = "화살표 아래";
            this.chkArrowDown.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(67, 85);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 16);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "화살표 위";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(67, 107);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(76, 16);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "화살표 위";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 351);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.chkArrowDown);
            this.Controls.Add(this.chkArrowUp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkArrowUp;
        private System.Windows.Forms.CheckBox chkArrowDown;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

