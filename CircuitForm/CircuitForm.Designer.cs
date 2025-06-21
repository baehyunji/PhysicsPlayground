namespace PhysicsPlayground
{
    partial class CircuitForm
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBack = new System.Windows.Forms.Button();
            this.addResistorButton = new System.Windows.Forms.Button();
            this.addVoltageButton = new System.Windows.Forms.Button();
            this.sliderButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.bulbButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBack.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBack.Location = new System.Drawing.Point(20, 21);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 39);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<- 뒤로가기";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // addResistorButton
            // 
            this.addResistorButton.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addResistorButton.Location = new System.Drawing.Point(20, 81);
            this.addResistorButton.Name = "addResistorButton";
            this.addResistorButton.Size = new System.Drawing.Size(127, 45);
            this.addResistorButton.TabIndex = 2;
            this.addResistorButton.Text = "전압기";
            this.addResistorButton.UseVisualStyleBackColor = true;
            this.addResistorButton.Click += new System.EventHandler(this.addResistorButton_Click);
            // 
            // addVoltageButton
            // 
            this.addVoltageButton.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addVoltageButton.Location = new System.Drawing.Point(20, 149);
            this.addVoltageButton.Name = "addVoltageButton";
            this.addVoltageButton.Size = new System.Drawing.Size(127, 45);
            this.addVoltageButton.TabIndex = 3;
            this.addVoltageButton.Text = "전원";
            this.addVoltageButton.UseVisualStyleBackColor = true;
            this.addVoltageButton.Click += new System.EventHandler(this.addVoltageButton_Click);
            // 
            // sliderButton
            // 
            this.sliderButton.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sliderButton.Location = new System.Drawing.Point(20, 284);
            this.sliderButton.Name = "sliderButton";
            this.sliderButton.Size = new System.Drawing.Size(127, 41);
            this.sliderButton.TabIndex = 4;
            this.sliderButton.Text = "미끄럽 가저항";
            this.sliderButton.UseVisualStyleBackColor = true;
            this.sliderButton.Click += new System.EventHandler(this.sliderButton_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(20, 344);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 39);
            this.button5.TabIndex = 5;
            this.button5.Text = "스위치";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusLabel.Location = new System.Drawing.Point(185, 21);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(19, 19);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "0";
            // 
            // bulbButton
            // 
            this.bulbButton.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bulbButton.Location = new System.Drawing.Point(20, 222);
            this.bulbButton.Name = "bulbButton";
            this.bulbButton.Size = new System.Drawing.Size(127, 41);
            this.bulbButton.TabIndex = 7;
            this.bulbButton.Text = "전구";
            this.bulbButton.UseVisualStyleBackColor = true;
            this.bulbButton.Click += new System.EventHandler(this.bulbButton_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(20, 455);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 46);
            this.button6.TabIndex = 8;
            this.button6.Text = "재우기";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CircuitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.bulbButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.sliderButton);
            this.Controls.Add(this.addVoltageButton);
            this.Controls.Add(this.addResistorButton);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CircuitForm";
            this.Size = new System.Drawing.Size(820, 641);
            this.Click += new System.EventHandler(this.sliderButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button addResistorButton;
        private System.Windows.Forms.Button addVoltageButton;
        private System.Windows.Forms.Button sliderButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button bulbButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer1;
    }
}
