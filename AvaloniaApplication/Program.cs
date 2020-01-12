using Avalonia;
using Avalonia.Logging.Serilog;

namespace AvaloniaApplication
{
    internal class Program
    {
        public static void Main(string[] args) => BuildAvaloniaApp().Start<MainWindow>();

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToDebug()
                .With(new Win32PlatformOptions
                {
                    UseDeferredRendering = false
                });
    }
}