namespace TemperatureAnalysisPre;

public abstract class ViewModelBase : BindableBase, 
    INavigationAware, 
    IRegionMemberLifetime, 
    IConfirmNavigationRequest
{
    /// <summary>
    /// 导航器
    /// </summary>
    public IRegionManager? Region;

    /// <summary>
    /// 弹窗服务
    /// </summary>
    public IDialogService? Dialog;

    /// <summary>
    /// 事件聚合器
    /// </summary>
    public IEventAggregator? Event;

    private DelegateCommand? _LoadedCommand;

    public DelegateCommand LoadedCommand =>
        _LoadedCommand ?? (_LoadedCommand = new DelegateCommand(ExecuteLoadedCommand));

    public ViewModelBase()
    {
    }

    public ViewModelBase(IContainerExtension container)
    {
        Region = container.Resolve<IRegionManager>();
        Dialog = container.Resolve<IDialogService>();
        Event = container.Resolve<IEventAggregator>();
    }



    /// <summary>
    ///初始化界面加载
    /// </summary>
    public virtual void ExecuteLoadedCommand()
    {
    }

    /// <summary>
    /// 标记上一个视图时候被销毁
    /// </summary>
    public bool KeepAlive => false;

    public virtual void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
    {
        continuationCallback(true);
    }

    /// <summary>
    /// 导航后的目标视图是否缓存
    /// </summary>
    /// <param name="navigationContext"></param>
    /// <returns></returns>
    public virtual bool IsNavigationTarget(NavigationContext navigationContext)
    {
        return false;
    }

    /// <summary>
    /// 导航前
    /// </summary>
    /// <param name="navigationContext"></param>
    public virtual void OnNavigatedFrom(NavigationContext navigationContext)
    {
    }

    /// <summary>
    /// 导航后
    /// </summary>
    /// <param name="navigationContext"></param>
    public virtual void OnNavigatedTo(NavigationContext navigationContext)
    {
    }
}