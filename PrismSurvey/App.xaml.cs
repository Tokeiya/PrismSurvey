﻿using Prism.Ioc;
using PrismSurvey.Views;
using System.Windows;

namespace PrismSurvey
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App
	{
		protected override Window CreateShell()
		{
			return Container.Resolve<MainWindow>();

		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{

		}
	}
}
