namespace PhysicsPlayground
{
    partial class RefractionForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new PhysicsPlayground.DoubleBufferedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBack.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBack.Location = new System.Drawing.Point(26, 26);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 49);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<- 뒤로가기";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnMaterial);
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbMaterial);
            this.panel1.Location = new System.Drawing.Point(3, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 716);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(544, 623);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "빨간색: 굴절선, 파란색: 입사선, 초록색: 반사선";
            // 
            // btnMaterial
            // 
            this.btnMaterial.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMaterial.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterial.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMaterial.Location = new System.Drawing.Point(523, 204);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(132, 48);
            this.btnMaterial.TabIndex = 3;
            this.btnMaterial.Text = "매질";
            this.btnMaterial.UseVisualStyleBackColor = false;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(582, 167);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 18);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "결과값";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(520, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "결과: ";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Items.AddRange(new object[] {
            "진공",
            "공기",
            "물(20℃)",
            "설탕물(30%)",
            "설탕물(80%)",
            "얼음",
            "유리",
            "사파이어",
            "다이아몬드"});
            this.cmbMaterial.Location = new System.Drawing.Point(523, 119);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(121, 23);
            this.cmbMaterial.TabIndex = 0;
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            // 
            // RefractionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Name = "RefractionForm";
            this.Size = new System.Drawing.Size(1000, 1000);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private PhysicsPlayground.DoubleBufferedPanel panel1;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
