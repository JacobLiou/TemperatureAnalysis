using System.Data;

namespace TemperatureAnalysisUI;

public partial class MainForm : BaseForm
{
    private DataTable dt = new DataTable();
    private static readonly Random random = new Random();
    private Double gridMinvalue = 1.2;
    private Double gridMaxvalue = 2.4;
    private int totalColumntoDisplay = 20;
    private Double USLs = 2.27;
    private Double LSLs = 1.26;
    private Double CpkPpkAcceptanceValue = 1.33;

    public MainForm()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        loadGridColums();
        loadgrid();
        USLs = Convert.ToDouble(txtusl.Text);
        LSLs = Convert.ToDouble(txtLSL.Text);
        CpkPpkAcceptanceValue = Convert.ToDouble(txtData.Text);
        spcChartCtrl.USL = USLs;
        spcChartCtrl.LSL = LSLs;
        spcChartCtrl.CpkPpKAcceptanceValue = CpkPpkAcceptanceValue;
        spcChartCtrl.Bindgrid(dt);
    }

    public void loadGridColums()
    {
        dt.Columns.Add("No");
        for (int jval = 1; jval <= totalColumntoDisplay; jval++)
        {
            dt.Columns.Add(jval.ToString());
        }
    }

    private static double RandomNumberBetween(double minValue, double maxValue)
    {
        var next = random.NextDouble();

        return Math.Round(minValue + (next * (maxValue - minValue)), 3);
    }

    public void loadgrid()
    {
        dt.Clear();
        dt.Rows.Clear();
        for (int i = 1; i <= 5; i++)
        {
            DataRow row = dt.NewRow();
            row["NO"] = i.ToString();
            for (int jval = 1; jval <= totalColumntoDisplay; jval++)
            {
                row[jval.ToString()] = RandomNumberBetween(gridMinvalue, gridMaxvalue);
            }

            dt.Rows.Add(row);
        }
        dataGridView1.AutoResizeColumns();
        dataGridView1.DataSource = dt;
        // dataGridView1.DataBindings();
        dataGridView1.AutoResizeColumns();
    }

    #region Events

    private void buttonManual_Click(object sender, EventArgs e)
    {
        gridMinvalue = 2.7;
        gridMaxvalue = 8.4;
        loadgrid();
        USLs = Convert.ToDouble(txtusl.Text);
        LSLs = Convert.ToDouble(txtLSL.Text);
        CpkPpkAcceptanceValue = Convert.ToDouble(txtData.Text);
        spcChartCtrl.USL = USLs;
        spcChartCtrl.LSL = LSLs;
        spcChartCtrl.CpkPpKAcceptanceValue = CpkPpkAcceptanceValue;
        spcChartCtrl.Bindgrid(dt);
    }

    private void btnRealTime_Click(object sender, EventArgs e)
    {
        gridMinvalue = 1.2;
        gridMaxvalue = 4.8;


    }

    private void uiSwitchRealTime_ValueChanged(object sender, bool value)
    {
        if (value)
        {
            timer1.Enabled = true;
            timer1.Start();
        }
        else
        {
            timer1.Enabled = false;
            timer1.Stop();
        }
    }

    private void uiButtonSImu_Click(object sender, EventArgs e)
    {
        CurveSimu curveSimu = new CurveSimu();
        curveSimu.Show();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        loadgrid();
        USLs = Convert.ToDouble(txtusl.Text);
        LSLs = Convert.ToDouble(txtLSL.Text);
        CpkPpkAcceptanceValue = Convert.ToDouble(txtData.Text);
        spcChartCtrl.USL = USLs;
        spcChartCtrl.LSL = LSLs;
        spcChartCtrl.CpkPpKAcceptanceValue = CpkPpkAcceptanceValue;
        spcChartCtrl.Bindgrid(dt);
    }

    #endregion Events
}