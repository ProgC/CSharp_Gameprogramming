namespace CheckBoxForMediatorPattern
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
            this.chkKnight = new System.Windows.Forms.CheckBox();
            this.chkWizard = new System.Windows.Forms.CheckBox();
            this.chkOne = new System.Windows.Forms.CheckBox();
            this.chkTwo = new System.Windows.Forms.CheckBox();
            this.chkStaff = new System.Windows.Forms.CheckBox();
            this.chkBerserker = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkKnight
            // 
            this.chkKnight.AutoSize = true;
            this.chkKnight.Location = new System.Drawing.Point(12, 12);
            this.chkKnight.Name = "chkKnight";
            this.chkKnight.Size = new System.Drawing.Size(48, 16);
            this.chkKnight.TabIndex = 0;
            this.chkKnight.Text = "검사";
            this.chkKnight.UseVisualStyleBackColor = true;
            this.chkKnight.CheckedChanged += new System.EventHandler(this.chkKnight_CheckedChanged);
            // 
            // chkWizard
            // 
            this.chkWizard.AutoSize = true;
            this.chkWizard.Location = new System.Drawing.Point(12, 56);
            this.chkWizard.Name = "chkWizard";
            this.chkWizard.Size = new System.Drawing.Size(60, 16);
            this.chkWizard.TabIndex = 0;
            this.chkWizard.Text = "마법사";
            this.chkWizard.UseVisualStyleBackColor = true;
            this.chkWizard.CheckedChanged += new System.EventHandler(this.chkWizard_CheckedChanged);
            // 
            // chkOne
            // 
            this.chkOne.AutoSize = true;
            this.chkOne.Location = new System.Drawing.Point(160, 56);
            this.chkOne.Name = "chkOne";
            this.chkOne.Size = new System.Drawing.Size(116, 16);
            this.chkOne.TabIndex = 1;
            this.chkOne.Text = "한손검 착용 여부";
            this.chkOne.UseVisualStyleBackColor = true;
            // 
            // chkTwo
            // 
            this.chkTwo.AutoSize = true;
            this.chkTwo.Location = new System.Drawing.Point(160, 34);
            this.chkTwo.Name = "chkTwo";
            this.chkTwo.Size = new System.Drawing.Size(116, 16);
            this.chkTwo.TabIndex = 1;
            this.chkTwo.Text = "두손검 착용 여부";
            this.chkTwo.UseVisualStyleBackColor = true;
            // 
            // chkStaff
            // 
            this.chkStaff.AutoSize = true;
            this.chkStaff.Location = new System.Drawing.Point(160, 12);
            this.chkStaff.Name = "chkStaff";
            this.chkStaff.Size = new System.Drawing.Size(116, 16);
            this.chkStaff.TabIndex = 1;
            this.chkStaff.Text = "지팡이 착용 여부";
            this.chkStaff.UseVisualStyleBackColor = true;
            // 
            // chkBerserker
            // 
            this.chkBerserker.AutoSize = true;
            this.chkBerserker.Location = new System.Drawing.Point(12, 34);
            this.chkBerserker.Name = "chkBerserker";
            this.chkBerserker.Size = new System.Drawing.Size(60, 16);
            this.chkBerserker.TabIndex = 0;
            this.chkBerserker.Text = "광전사";
            this.chkBerserker.UseVisualStyleBackColor = true;
            this.chkBerserker.CheckedChanged += new System.EventHandler(this.chkBerserker_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 98);
            this.Controls.Add(this.chkStaff);
            this.Controls.Add(this.chkTwo);
            this.Controls.Add(this.chkOne);
            this.Controls.Add(this.chkWizard);
            this.Controls.Add(this.chkBerserker);
            this.Controls.Add(this.chkKnight);
            this.Name = "Form1";
            this.Text = "CheckBox for Mediator Pattern";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkKnight;
        private System.Windows.Forms.CheckBox chkWizard;
        private System.Windows.Forms.CheckBox chkOne;
        private System.Windows.Forms.CheckBox chkTwo;
        private System.Windows.Forms.CheckBox chkStaff;
        private System.Windows.Forms.CheckBox chkBerserker;

    }
}

