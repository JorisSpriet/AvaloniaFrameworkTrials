using System.Reactive;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ReactiveUI;

namespace AvaloniaApplication1
{
	public class MainWindow : Window
	{
		public MainWindow()
		{

			ButtonCommand = ReactiveCommand.Create(CommandImplementation);

			InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

			
		}

		private IReactiveCommand ButtonCommand { get; set; }

		private void CommandImplementation()
		{}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
