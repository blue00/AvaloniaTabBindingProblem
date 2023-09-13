namespace AvaloniaTabBindingProblem.ViewModels;

public class MainViewModel : ViewModelBase
{
    public ViewModel1 ViewModel1 { get; set; } = new ViewModel1();
    public ViewModel2 ViewModel2 { get; set; } = new ViewModel2();
}
