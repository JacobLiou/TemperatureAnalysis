namespace TemperatureAnalysisUI
{
    partial class SPCChartCtrl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            PicBox = new PictureBox();
            OuterPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)PicBox).BeginInit();
            OuterPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PicBox
            // 
            this.PicBox.BackColor = System.Drawing.Color.White;
            this.PicBox.Location = new System.Drawing.Point(0, 0);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(1100, 550);
            this.PicBox.TabIndex = 3;
            this.PicBox.TabStop = false;
            // 
            // OuterPanel
            // 
            this.OuterPanel.AutoScroll = true;
            this.OuterPanel.BackColor = System.Drawing.Color.White;
            this.OuterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OuterPanel.Controls.Add(this.PicBox);
            this.OuterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OuterPanel.Location = new System.Drawing.Point(0, 0);
            this.OuterPanel.Name = "OuterPanel";
            this.OuterPanel.Size = new System.Drawing.Size(1135, 560);
            this.OuterPanel.TabIndex = 4;
            // 
            // SPCChartCtrl
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OuterPanel);
            Size = new Size(1135, 560);
            ((System.ComponentModel.ISupportInitialize)PicBox).EndInit();
            OuterPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PicBox;
        private Panel OuterPanel;
    }
}
