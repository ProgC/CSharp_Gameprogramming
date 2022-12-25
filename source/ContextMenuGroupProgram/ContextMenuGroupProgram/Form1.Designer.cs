namespace ContextMenuGroupProgram
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
            this.picKnight = new System.Windows.Forms.PictureBox();
            this.picWorker = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picKnight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // picKnight
            // 
            this.picKnight.BackColor = System.Drawing.Color.Blue;
            this.picKnight.Image = global::ContextMenuGroupProgram.Properties.Resources.knight;
            this.picKnight.Location = new System.Drawing.Point(211, 121);
            this.picKnight.Name = "picKnight";
            this.picKnight.Size = new System.Drawing.Size(55, 89);
            this.picKnight.TabIndex = 1;
            this.picKnight.TabStop = false;
            // 
            // picWorker
            // 
            this.picWorker.BackColor = System.Drawing.Color.Red;
            this.picWorker.Image = global::ContextMenuGroupProgram.Properties.Resources.worker;
            this.picWorker.Location = new System.Drawing.Point(80, 127);
            this.picWorker.Name = "picWorker";
            this.picWorker.Size = new System.Drawing.Size(51, 83);
            this.picWorker.TabIndex = 0;
            this.picWorker.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 329);
            this.Controls.Add(this.picKnight);
            this.Controls.Add(this.picWorker);
            this.Name = "Form1";
            this.Text = "각각의 컨트롤에 Context Menu연결하기";
            ((System.ComponentModel.ISupportInitialize)(this.picKnight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picWorker;
        private System.Windows.Forms.PictureBox picKnight;
    }
}

