using System.Windows;

namespace TemperatureAnalysisPre.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CancellationTokenSource cts = new CancellationTokenSource();

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            this.KeyDown += MainWindow_KeyDown;
        }

        private void MainWindow_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            cts.Cancel();
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //await Task.Delay(-1, cts.Token);

            while (!cts.IsCancellationRequested)
            {
                //await Task.Delay(1, cts.Token);
                await Task.Delay(1);
            }
        }
    }
}
