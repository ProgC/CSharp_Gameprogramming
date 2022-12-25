namespace ButtonProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.lblWis = new System.Windows.Forms.Label();
            this.lblDex = new System.Windows.Forms.Label();
            this.myButton1 = new ButtonProgram.MyButton();
            this.myButton2 = new ButtonProgram.MyButton();
            this.myButton3 = new ButtonProgram.MyButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Strength";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Magic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dexterity";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(83, 17);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(29, 12);
            this.lblStr.TabIndex = 4;
            this.lblStr.Text = "1234";
            // 
            // lblWis
            // 
            this.lblWis.AutoSize = true;
            this.lblWis.Location = new System.Drawing.Point(83, 48);
            this.lblWis.Name = "lblWis";
            this.lblWis.Size = new System.Drawing.Size(29, 12);
            this.lblWis.TabIndex = 4;
            this.lblWis.Text = "1234";
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Location = new System.Drawing.Point(83, 75);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(29, 12);
            this.lblDex.TabIndex = 4;
            this.lblDex.Text = "1234";
            // 
            // myButton1
            // 
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton1.Image = ((System.Drawing.Image)(resources.GetObject("myButton1.Image")));
            this.myButton1.Location = new System.Drawing.Point(132, 17);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(40, 21);
            this.myButton1.TabIndex = 5;
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // myButton2
            // 
            this.myButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton2.Image = ((System.Drawing.Image)(resources.GetObject("myButton2.Image")));
            this.myButton2.Location = new System.Drawing.Point(132, 44);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(40, 21);
            this.myButton2.TabIndex = 6;
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // myButton3
            // 
            this.myButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton3.Image = ((System.Drawing.Image)(resources.GetObject("myButton3.Image")));
            this.myButton3.Location = new System.Drawing.Point(132, 71);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(40, 21);
            this.myButton3.TabIndex = 7;
            this.myButton3.UseVisualStyleBackColor = true;
            this.myButton3.Click += new System.EventHandler(this.myButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 116);
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.lblDex);
            this.Controls.Add(this.lblWis);
            this.Controls.Add(this.lblStr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "레벨업 윈도우";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.Label lblWis;
        private System.Windows.Forms.Label lblDex;
        private MyButton myButton1;
        private MyButton myButton2;
        private MyButton myButton3;
        //private MyButton myButton1;

    }
}

