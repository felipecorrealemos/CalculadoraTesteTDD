namespace CalculadoraTesteTDD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window janela = new Window(new MainPage())
            {
                Title = "CalculadoraTesteTDD"
            };

#if WINDOWS
            janela.Created += (sender, args) =>
            {
                Microsoft.UI.Xaml.Window? janelaNativa =
                    janela.Handler?.PlatformView as Microsoft.UI.Xaml.Window;

                if (janelaNativa is null)
                {
                    return;
                }

                nint identificadorJanela =
                    WinRT.Interop.WindowNative.GetWindowHandle(janelaNativa);

                Microsoft.UI.WindowId identificador =
                    Microsoft.UI.Win32Interop.GetWindowIdFromWindow(identificadorJanela);

                Microsoft.UI.Windowing.AppWindow janelaDoAplicativo =
                    Microsoft.UI.Windowing.AppWindow.GetFromWindowId(identificador);

                if (janelaDoAplicativo.Presenter
                    is Microsoft.UI.Windowing.OverlappedPresenter apresentador)
                {
                    apresentador.Maximize();
                }
            };
#endif

            return janela;
        }
    }
}
