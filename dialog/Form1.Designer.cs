﻿namespace dialog
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModal = new System.Windows.Forms.Button();
            this.btnModalists = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnModal
            // 
            this.btnModal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModal.Font = new System.Drawing.Font("문체부 바탕체", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnModal.Location = new System.Drawing.Point(0, 12);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(233, 84);
            this.btnModal.TabIndex = 0;
            this.btnModal.TabStop = false;
            this.btnModal.Text = "모달 대화상자";
            this.btnModal.UseVisualStyleBackColor = false;
            this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // btnModalists
            // 
            this.btnModalists.BackColor = System.Drawing.Color.IndianRed;
            this.btnModalists.Font = new System.Drawing.Font("문체부 바탕체", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnModalists.Location = new System.Drawing.Point(239, 12);
            this.btnModalists.Name = "btnModalists";
            this.btnModalists.Size = new System.Drawing.Size(256, 84);
            this.btnModalists.TabIndex = 1;
            this.btnModalists.Text = "모달리스 대화상자";
            this.btnModalists.UseVisualStyleBackColor = false;
            this.btnModalists.Click += new System.EventHandler(this.btnModalists_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("문체부 바탕체", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(21, 117);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 321);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnModalists);
            this.Controls.Add(this.btnModal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Button btnModalists;
        public System.Windows.Forms.TextBox textBox1;
    }
}
