using System.Diagnostics;
using System.Windows;

namespace TemperatureAnalysisPre.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _Message = "";

        public string Message
        {
            get { return _Message; }
            set { SetProperty(ref _Message, value); }
        }

        public MainWindowViewModel(IContainerExtension container) : base(container)
        {
        }

        #region 视图属性

        private bool _Network = true;

        public bool Network
        {
            get { return _Network; }
            set { SetProperty(ref _Network, value); }
        }

        private string _title = "欢迎";

        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private WindowState _WindowState;

        /// <summary>
        /// 窗体状态
        /// </summary>
        public WindowState WindowState
        {
            get { return _WindowState; }
            set { _WindowState = value; RaisePropertyChanged(); }
        }

        private Thickness _GlassFrameThickness;

        public Thickness GlassFrameThickness
        {
            get { return _GlassFrameThickness; }
            set { _GlassFrameThickness = value; RaisePropertyChanged(); }
        }

        #endregion 视图属性

        #region 窗体命令

        private DelegateCommand<string> _GoBrowser;

        public DelegateCommand<string> GoBrowser =>
            _GoBrowser ?? (_GoBrowser = new DelegateCommand<string>(ExecuteGoBrowser));

        private void ExecuteGoBrowser(string uri)
        {
            Process.Start(new ProcessStartInfo(uri));
        }

        #endregion 窗体命令

        #region 核心方法

        public override void ExecuteLoadedCommand()
        {
            base.ExecuteLoadedCommand();
        }

        #endregion 核心方法
    }
}