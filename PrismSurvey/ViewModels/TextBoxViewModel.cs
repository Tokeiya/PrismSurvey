using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GongSolutions.Wpf.DragDrop;
using Prism.Mvvm;

namespace PrismSurvey.ViewModels
{
	public class TextBoxViewModel : BindableBase, IDropTarget
	{
		private string _text = "Drop here!";

		public string Text
		{
			get => _text;
			set => SetProperty(ref _text, value);
		}

		public void DragOver(IDropInfo dropInfo)
		{

			Console.WriteLine(dropInfo.Data.GetType().Name);
			dropInfo.DropTargetAdorner = DropTargetAdorners.Highlight;
			dropInfo.Effects = DragDropEffects.Copy;
		}

		public void Drop(IDropInfo dropInfo)
		{
			Text += (string) dropInfo.Data + " ";
		}
	}
}