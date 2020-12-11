using System;
using System.Runtime.InteropServices;
using System.Windows;

namespace PrismSurvey.Views
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			_ = AllocConsole();
		}

		[DllImport("Kernel32.dll", CharSet = CharSet.Unicode)]
		static extern bool AllocConsole();

	}
}
