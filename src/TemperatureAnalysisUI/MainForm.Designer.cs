namespace TemperatureAnalysisUI;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        panel1 = new Panel();
        uiSwitchRealTime = new Sunny.UI.UISwitch();
        uiButtonManual = new Sunny.UI.UIButton();
        groupBox1 = new GroupBox();
        label4 = new Label();
        label3 = new Label();
        txtusl = new TextBox();
        txtData = new TextBox();
        txtLSL = new TextBox();
        label2 = new Label();
        dataGridView1 = new DataGridView();
        uiLabel1 = new Sunny.UI.UILabel();
        spcChartCtrl = new SPCChartCtrl();
        timer1 = new System.Windows.Forms.Timer(components);
        helpProvider1 = new HelpProvider();
        uiButtonSImu = new Sunny.UI.UIButton();
        panel1.SuspendLayout();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(uiSwitchRealTime);
        panel1.Controls.Add(uiButtonSImu);
        panel1.Controls.Add(uiButtonManual);
        panel1.Controls.Add(groupBox1);
        panel1.Controls.Add(dataGridView1);
        panel1.Controls.Add(uiLabel1);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 35);
        panel1.Name = "panel1";
        panel1.Size = new Size(1256, 208);
        panel1.TabIndex = 2;
        // 
        // uiSwitchRealTime
        // 
        uiSwitchRealTime.Font = new Font("微软雅黑", 9F);
        uiSwitchRealTime.Location = new Point(1178, 107);
        uiSwitchRealTime.MinimumSize = new Size(1, 1);
        uiSwitchRealTime.Name = "uiSwitchRealTime";
        uiSwitchRealTime.Size = new Size(59, 30);
        uiSwitchRealTime.TabIndex = 130;
        uiSwitchRealTime.Text = "自动数据";
        uiSwitchRealTime.ValueChanged += uiSwitchRealTime_ValueChanged;
        // 
        // uiButtonManual
        // 
        uiButtonManual.Font = new Font("微软雅黑", 9F);
        uiButtonManual.Location = new Point(1104, 41);
        uiButtonManual.MinimumSize = new Size(1, 1);
        uiButtonManual.Name = "uiButtonManual";
        uiButtonManual.Size = new Size(105, 42);
        uiButtonManual.TabIndex = 129;
        uiButtonManual.Text = "手动数据";
        uiButtonManual.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
        uiButtonManual.Click += buttonManual_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(txtusl);
        groupBox1.Controls.Add(txtData);
        groupBox1.Controls.Add(txtLSL);
        groupBox1.Controls.Add(label2);
        groupBox1.Location = new Point(8, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(176, 205);
        groupBox1.TabIndex = 128;
        groupBox1.TabStop = false;
        groupBox1.Text = "设置";
        // 
        // label4
        // 
        label4.Font = new Font("宋体", 10.8F, FontStyle.Bold);
        label4.ForeColor = SystemColors.ControlText;
        label4.Location = new Point(5, 130);
        label4.Name = "label4";
        label4.Size = new Size(38, 18);
        label4.TabIndex = 118;
        label4.Text = "Cpk Limit";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("宋体", 10.8F, FontStyle.Bold);
        label3.ForeColor = SystemColors.ControlText;
        label3.Location = new Point(5, 84);
        label3.Name = "label3";
        label3.Size = new Size(38, 18);
        label3.TabIndex = 117;
        label3.Text = "LSL";
        // 
        // txtusl
        // 
        txtusl.BackColor = Color.White;
        txtusl.BorderStyle = BorderStyle.FixedSingle;
        txtusl.Location = new Point(88, 38);
        txtusl.MaxLength = 6;
        txtusl.Name = "txtusl";
        txtusl.Size = new Size(80, 27);
        txtusl.TabIndex = 116;
        txtusl.Text = "2.27";
        // 
        // txtData
        // 
        txtData.BackColor = Color.White;
        txtData.BorderStyle = BorderStyle.FixedSingle;
        txtData.Location = new Point(88, 128);
        txtData.MaxLength = 6;
        txtData.Name = "txtData";
        txtData.Size = new Size(80, 27);
        txtData.TabIndex = 115;
        txtData.Text = "1.33";
        // 
        // txtLSL
        // 
        txtLSL.BackColor = Color.White;
        txtLSL.BorderStyle = BorderStyle.FixedSingle;
        txtLSL.Location = new Point(88, 83);
        txtLSL.MaxLength = 6;
        txtLSL.Name = "txtLSL";
        txtLSL.Size = new Size(80, 27);
        txtLSL.TabIndex = 114;
        txtLSL.Text = "1.26";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("宋体", 10.8F, FontStyle.Bold);
        label2.ForeColor = SystemColors.ControlText;
        label2.Location = new Point(5, 38);
        label2.Name = "label2";
        label2.Size = new Size(38, 18);
        label2.TabIndex = 0;
        label2.Text = "USL";
        // 
        // dataGridView1
        // 
        dataGridView1.BackgroundColor = Color.WhiteSmoke;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(192, 3);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.RowTemplate.Height = 23;
        dataGridView1.Size = new Size(895, 205);
        dataGridView1.TabIndex = 125;
        // 
        // uiLabel1
        // 
        uiLabel1.Font = new Font("微软雅黑", 9F);
        uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
        uiLabel1.Location = new Point(1101, 113);
        uiLabel1.Name = "uiLabel1";
        uiLabel1.Size = new Size(94, 29);
        uiLabel1.TabIndex = 131;
        uiLabel1.Text = "自动数据";
        // 
        // spcChartCtrl
        // 
        spcChartCtrl.CokPpkValue = 1.33D;
        spcChartCtrl.Dock = DockStyle.Fill;
        spcChartCtrl.Location = new Point(0, 243);
        spcChartCtrl.LSL = 0D;
        spcChartCtrl.Name = "spcChartCtrl";
        spcChartCtrl.Size = new Size(1256, 454);
        spcChartCtrl.TabIndex = 3;
        spcChartCtrl.USL = 0D;
        // 
        // timer1
        // 
        timer1.Interval = 900;
        timer1.Tick += timer1_Tick;
        // 
        // uiButtonSImu
        // 
        uiButtonSImu.Font = new Font("微软雅黑", 9F);
        uiButtonSImu.Location = new Point(1101, 155);
        uiButtonSImu.MinimumSize = new Size(1, 1);
        uiButtonSImu.Name = "uiButtonSImu";
        uiButtonSImu.Size = new Size(105, 42);
        uiButtonSImu.TabIndex = 129;
        uiButtonSImu.Text = "拟合数据";
        uiButtonSImu.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
        uiButtonSImu.Click += uiButtonSImu_Click;
        // 
        // MainForm
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(1256, 697);
        Controls.Add(spcChartCtrl);
        Controls.Add(panel1);
        Name = "MainForm";
        Text = "工艺温控曲线拟合验证工具";
        Load += Form1_Load;
        panel1.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    internal System.Windows.Forms.TextBox txtusl;
    internal System.Windows.Forms.TextBox txtData;
    internal System.Windows.Forms.TextBox txtLSL;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView dataGridView1;
    private SPCChartCtrl spcChartCtrl;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.HelpProvider helpProvider1;
    private Sunny.UI.UIButton uiButtonManual;
    private Sunny.UI.UISwitch uiSwitchRealTime;
    private Sunny.UI.UILabel uiLabel1;
    private Sunny.UI.UIButton uiButtonSImu;
}
