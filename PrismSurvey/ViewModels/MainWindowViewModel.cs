using System;
using Prism.Mvvm;
using Reactive.Bindings;

namespace PrismSurvey.ViewModels
{
	public class MainWindowViewModel : BindableBase
	{
		private string _title = "Prism Application";

		public MainWindowViewModel()
		{
			ButtonCommand.Subscribe(() =>
			{
				Console.Clear();
				TextBoxValue.Text = "";
			});
		}

		public string Title
		{
			get => _title;
			set => SetProperty(ref _title, value);
		}

		public ReactiveCommand ButtonCommand { get; } = new();

		public TextBoxViewModel TextBoxValue { get; } = new();
		public TextBlockViewModel Upper { get; } = new("hello world");

		public TextBlockViewModel Middle { get; } = new("hello C#");
		public TextBlockViewModel Bottom { get; } = new("hello wpf");

		private void ClearConsole()
		{
			Console.Clear();
		}
	}
}