namespace cam
{
    partial class camForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.camStationNum = new System.Windows.Forms.TextBox();
            this.camNum = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.camDisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.camDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "監視站數量（1-4）：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "每站之監視器數量（1-9）：";
            // 
            // camStationNum
            // 
            this.camStationNum.Location = new System.Drawing.Point(181, 24);
            this.camStationNum.Name = "camStationNum";
            this.camStationNum.Size = new System.Drawing.Size(50, 22);
            this.camStationNum.TabIndex = 2;
            this.camStationNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.camStationNum_KeyPress);
            // 
            // camNum
            // 
            this.camNum.Location = new System.Drawing.Point(227, 58);
            this.camNum.Name = "camNum";
            this.camNum.Size = new System.Drawing.Size(50, 22);
            this.camNum.TabIndex = 3;
            this.camNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.camNum_KeyPress);
            // 
            // generate
            // 
            this.generate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.generate.Location = new System.Drawing.Point(17, 100);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(260, 35);
            this.generate.TabIndex = 4;
            this.generate.Text = "開始繪圖";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // camDisplay
            // 
            this.camDisplay.Location = new System.Drawing.Point(3, 141);
            this.camDisplay.Name = "camDisplay";
            this.camDisplay.Size = new System.Drawing.Size(20, 15);
            this.camDisplay.TabIndex = 5;
            this.camDisplay.TabStop = false;
            // 
            // camForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 435);
            this.Controls.Add(this.camDisplay);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.camNum);
            this.Controls.Add(this.camStationNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "camForm";
            this.Text = "監視系統模擬";
            ((System.ComponentModel.ISupportInitialize)(this.camDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox camStationNum;
        private System.Windows.Forms.TextBox camNum;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.PictureBox camDisplay;
    }
}

