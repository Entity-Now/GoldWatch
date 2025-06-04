using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using GoldWatch.ModelView;
using Avalonia.Markup.Xaml;

namespace GoldWatch;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        // 初始化modelView
        DataContext = new MainModelView();
        // 设置无边框
        this.SystemDecorations = SystemDecorations.None;
        // 设置置顶
        this.Topmost = true;

        this.CanResize = false;
        this.TransparencyLevelHint = new[] { WindowTransparencyLevel.Transparent };
        this.Background = null!;
    }
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    private void InputElement_OnPointerPressed(object? sender, PointerPressedEventArgs e)
    {
        BeginMoveDrag(e);
    }

    private void MenuItem_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }
}