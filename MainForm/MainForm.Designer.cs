﻿namespace PhysicsPlayground
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuoyancy = new System.Windows.Forms.Button();
            this.btnPendulum = new System.Windows.Forms.Button();
            this.btnRefraction = new System.Windows.Forms.Button();
            this.btnCircuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(283, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "탐험!물리놀이터🛝";
            // 
            // btnBuoyancy
            // 
            this.btnBuoyancy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuoyancy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBuoyancy.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuoyancy.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBuoyancy.Location = new System.Drawing.Point(367, 206);
            this.btnBuoyancy.Name = "btnBuoyancy";
            this.btnBuoyancy.Size = new System.Drawing.Size(241, 63);
            this.btnBuoyancy.TabIndex = 1;
            this.btnBuoyancy.TabStop = false;
            this.btnBuoyancy.Text = "부력";
            this.btnBuoyancy.UseVisualStyleBackColor = false;
            this.btnBuoyancy.Click += new System.EventHandler(this.btnBuoyancy_Click);
            // 
            // btnPendulum
            // 
            this.btnPendulum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPendulum.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPendulum.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendulum.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnPendulum.Location = new System.Drawing.Point(369, 289);
            this.btnPendulum.Name = "btnPendulum";
            this.btnPendulum.Size = new System.Drawing.Size(241, 63);
            this.btnPendulum.TabIndex = 2;
            this.btnPendulum.TabStop = false;
            this.btnPendulum.Text = "단진자운동";
            this.btnPendulum.UseVisualStyleBackColor = false;
            this.btnPendulum.Click += new System.EventHandler(this.btnPendulum_Click);
            // 
            // btnRefraction
            // 
            this.btnRefraction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefraction.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRefraction.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefraction.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRefraction.Location = new System.Drawing.Point(369, 372);
            this.btnRefraction.Name = "btnRefraction";
            this.btnRefraction.Size = new System.Drawing.Size(241, 63);
            this.btnRefraction.TabIndex = 3;
            this.btnRefraction.TabStop = false;
            this.btnRefraction.Text = "빛의굴절";
            this.btnRefraction.UseVisualStyleBackColor = false;
            this.btnRefraction.Click += new System.EventHandler(this.btnRefraction_Click);
            // 
            // btnCircuit
            // 
            this.btnCircuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCircuit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCircuit.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCircuit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCircuit.Location = new System.Drawing.Point(369, 455);
            this.btnCircuit.Name = "btnCircuit";
            this.btnCircuit.Size = new System.Drawing.Size(241, 63);
            this.btnCircuit.TabIndex = 4;
            this.btnCircuit.TabStop = false;
            this.btnCircuit.Text = "전기회로";
            this.btnCircuit.UseVisualStyleBackColor = false;
            this.btnCircuit.Click += new System.EventHandler(this.btnCircuit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btnCircuit);
            this.Controls.Add(this.btnRefraction);
            this.Controls.Add(this.btnPendulum);
            this.Controls.Add(this.btnBuoyancy);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuoyancy;
        private System.Windows.Forms.Button btnPendulum;
        private System.Windows.Forms.Button btnRefraction;
        private System.Windows.Forms.Button btnCircuit;
    }
}

