using System.Configuration;
using System.Data;
using System.Windows;

namespace TemperatureAnalysisPre
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        public App()
        {
            //初始化日志配置信息
            log4net.Config.XmlConfigurator.Configure();
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            DispatcherUnhandledException += App_DispatcherUnhandledException;
        }
        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            //log4net.LogManager.Error(e.Exception.Message);
            //e.Handled = true;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //throw new NotImplementedException();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            //moduleCatalog.AddModule<HomeModule>();
            //moduleCatalog.AddModule<FundamentalElementModule>();
            //moduleCatalog.AddModule<ComponentExampleModule>();
        }
    }

}
