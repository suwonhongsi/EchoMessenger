namespace EchoMessenger
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
            this.Label = new System.Windows.Forms.TextBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.SystemColors.Info;
            this.Label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Label.Font = new System.Drawing.Font("맑은 고딕", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label.ForeColor = System.Drawing.Color.Blue;
            this.Label.Location = new System.Drawing.Point(73, 39);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(658, 100);
            this.Label.TabIndex = 0;
            this.Label.Text = "Echo Messenger";
            // 
            // TextBox
            // 
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.Location = new System.Drawing.Point(64, 699);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(912, 68);
            this.TextBox.TabIndex = 2;
            this.TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.Color.Lime;
            this.Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button.Font = new System.Drawing.Font("맑은 고딕", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button.Location = new System.Drawing.Point(1056, 684);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(284, 99);
            this.Button.TabIndex = 3;
            this.Button.Text = "전송";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 24;
            this.ListBox.Location = new System.Drawing.Point(64, 168);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(1268, 460);
            this.ListBox.TabIndex = 4;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1416, 828);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Label;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.ListBox ListBox;
    }
}

