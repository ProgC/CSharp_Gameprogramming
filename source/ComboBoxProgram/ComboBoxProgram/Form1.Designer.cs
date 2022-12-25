namespace ComboBoxProgram
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
            this.btnComplete = new System.Windows.Forms.Button();
            this.cbCharacterClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNation = new ComboBoxProgram.ImageComboBox();
            this.cbHairColor = new ComboBoxProgram.ColorComboBox();
            this.SuspendLayout();
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(162, 161);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(86, 20);
            this.btnComplete.TabIndex = 1;
            this.btnComplete.Text = "완료";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // cbCharacterClass
            // 
            this.cbCharacterClass.FormattingEnabled = true;
            this.cbCharacterClass.Location = new System.Drawing.Point(127, 79);
            this.cbCharacterClass.Name = "cbCharacterClass";
            this.cbCharacterClass.Size = new System.Drawing.Size(121, 20);
            this.cbCharacterClass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "케릭터 선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "케릭터 머리 색상";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "케릭터 생성";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "케릭터 국적";
            // 
            // cbNation
            // 
            this.cbNation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNation.FormattingEnabled = true;
            this.cbNation.ImageHeight = 16;
            this.cbNation.ImageWidth = 20;
            this.cbNation.Location = new System.Drawing.Point(127, 39);
            this.cbNation.Name = "cbNation";
            this.cbNation.Size = new System.Drawing.Size(121, 22);
            this.cbNation.TabIndex = 7;
            // 
            // cbHairColor
            // 
            this.cbHairColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbHairColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHairColor.FormattingEnabled = true;
            this.cbHairColor.ItemHeight = 14;
            this.cbHairColor.Location = new System.Drawing.Point(127, 122);
            this.cbHairColor.Name = "cbHairColor";
            this.cbHairColor.Size = new System.Drawing.Size(121, 20);
            this.cbHairColor.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.cbNation);
            this.Controls.Add(this.cbHairColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCharacterClass);
            this.Controls.Add(this.btnComplete);
            this.Name = "Form1";
            this.Text = "콤보 박스 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.ComboBox cbCharacterClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ColorComboBox cbHairColor;
        private ImageComboBox cbNation;
    }
}

