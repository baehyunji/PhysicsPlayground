namespace PhysicsPlayground
{
    partial class BuoyancyForm
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
            this.timeRestart = new System.Windows.Forms.Button();
            this.timeStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBack.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBack.Location = new System.Drawing.Point(26, 26);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 49);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<- 뒤로가기";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // timeRestart
            // 
            this.timeRestart.Location = new System.Drawing.Point(794, 26);
            this.timeRestart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeRestart.Name = "timeRestart";
            this.timeRestart.Size = new System.Drawing.Size(95, 29);
            this.timeRestart.TabIndex = 3;
            this.timeRestart.Text = "이어서시작";
            this.timeRestart.UseVisualStyleBackColor = true;
            this.timeRestart.Click += new System.EventHandler(this.timeRestart_Click);
            // 
            // timeStop
            // 
            this.timeStop.Location = new System.Drawing.Point(794, 72);
            this.timeStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeStop.Name = "timeStop";
            this.timeStop.Size = new System.Drawing.Size(95, 29);
            this.timeStop.TabIndex = 4;
            this.timeStop.Text = "일시정지";
            this.timeStop.UseVisualStyleBackColor = true;
            this.timeStop.Click += new System.EventHandler(this.timeStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(792, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "나무상자를 클릭하여\r\n조종 할 수 있습니다.\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.Location = new System.Drawing.Point(0, 320);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1000, 381);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhysicsPlayground.Properties.Resources.New_Piskel__2_;
            this.pictureBox1.Location = new System.Drawing.Point(349, 201);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // BuoyancyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeStop);
            this.Controls.Add(this.timeRestart);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BuoyancyForm";
            this.Size = new System.Drawing.Size(1000, 701);
            this.Load += new System.EventHandler(this.BuoyancyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button timeRestart;
        private System.Windows.Forms.Button timeStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}
