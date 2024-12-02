using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;

namespace TemperatureAnalysisUI
{
    public partial class CurveSimu : BaseForm
    {
        public CurveSimu()
        {
            InitializeComponent();
            plotView1.Model = CreateFittedPlot();
        }

        public PlotModel CreateFittedPlot()
        {
            // 准备数据
            double[] xData = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] yData = { 1.1, 3.8, 7.2, 9.3, 13.5, 18.2, 23.1, 27.9, 32.1, 37.2 };

            // 多项式拟合
            var coefficients = Fit.Polynomial(xData, yData, 2);

            // 创建绘图模型
            var plotModel = new PlotModel { Title = "数据拟合示例" };

            // 添加坐标轴
            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "X轴"
            });
            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Y轴"
            });

            // 添加原始数据点
            var scatterSeries = new ScatterSeries
            {
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerFill = OxyColors.Blue,
                Title = "原始数据"
            };

            for (int i = 0; i < xData.Length; i++)
            {
                scatterSeries.Points.Add(new ScatterPoint(xData[i], yData[i]));
            }
            plotModel.Series.Add(scatterSeries);

            // 添加拟合曲线
            var lineSeries = new LineSeries
            {
                Color = OxyColors.Red,
                Title = "拟合曲线",
                StrokeThickness = 2
            };

            // 生成拟合曲线的点
            for (double x = xData.Min(); x <= xData.Max(); x += 0.1)
            {
                double y = coefficients[0] +
                          coefficients[1] * x +
                          coefficients[2] * Math.Pow(x, 2);
                lineSeries.Points.Add(new DataPoint(x, y));
            }
            plotModel.Series.Add(lineSeries);

            // 添加图例
            plotModel.Legends.Add(new Legend
            {
                LegendPosition = LegendPosition.RightTop,
                LegendPlacement = LegendPlacement.Inside
            });

            return plotModel;
        }
    }
}
