using Microsoft.MobileBlazorBindings.WebView.Windows;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace CatTrackerDemo.Windows
{
    public class MainWindow : FormsApplicationPage
    {
        [STAThread]
        public static void Main()
        {
            var app = new System.Windows.Application();
            app.Run(new MainWindow() { Title = "Cat tracker" });
        }

        public MainWindow()
        {
            Forms.Init();
            BlazorHybridWindows.Init();
            LoadApplication(new App());
        }
    }
}
