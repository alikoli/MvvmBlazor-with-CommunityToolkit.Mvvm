namespace MvvmBlazor.Tests.Components;

public class TestViewModel : ViewModelBase
{
    private string? _testProperty;

    public string? TestProperty
    {
        get => _testProperty;
        set => SetProperty(ref _testProperty, value);
    }
}