using Microsoft.Web.WebView2.Core;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WebBroeser;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
        InitializeAsync();
    }

    private async void InitializeAsync() {
        await WebView.EnsureCoreWebView2Async();

        WebView.CoreWebView2.NavigationStarting += CoreWebView2_NavigationStarting; ;
        WebView.CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;
    }

    //読み込み開始したらプログレスバーを表示
    private void CoreWebView2_NavigationStarting(object? sender, CoreWebView2NavigationStartingEventArgs e) {
        LoadingBar.Visibility = Visibility.Visible;
        LoadingBar.IsIndeterminate = true;
    }

    //読み込み完了したらプログレスバーを非表示
    private void CoreWebView2_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e) {
        LoadingBar.Visibility = Visibility.Collapsed;
        LoadingBar.IsIndeterminate = false;
    }

    private void BackButton_Click(object sender, RoutedEventArgs e) {
        if (WebView.CanGoBack) {
            WebView.GoBack();
        }
    }

    private void FowardButton_Click(object sender, RoutedEventArgs e) {
        if (WebView.CanGoForward) {
            WebView.GoForward();
        }
    }

    private void GoButton_Click(object sender, RoutedEventArgs e) {
        var url = AddressBar.Text.Trim();
        if (string.IsNullOrWhiteSpace(url)) return;

        WebView.Source = new Uri(url);
    }
}