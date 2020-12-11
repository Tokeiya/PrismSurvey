﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GongSolutions.Wpf.DragDrop;
using Prism.Mvvm;

namespace PrismSurvey.ViewModels
{
	public class TextBlockViewModel:BindableBase,IDragSource
	{
		public TextBlockViewModel(string text) => _text = text;

		private string _text;

		public string Text
		{
			get => _text;
			set => SetProperty(ref _text, value);
		}
		
		public void StartDrag(IDragInfo dragInfo)
		{
			dragInfo.Data = Text;
			dragInfo.Effects = DragDropEffects.Copy;
			
			Console.WriteLine("DragSource StartDrag");
		}

		public bool CanStartDrag(IDragInfo dragInfo)
		{
			Console.WriteLine("can");
			return true;
		}

		public void Dropped(IDropInfo dropInfo)
		{
			Console.WriteLine("DragSource Dropped.");

		}

		public void DragDropOperationFinished(DragDropEffects operationResult, IDragInfo dragInfo)
		{
			Console.WriteLine("Finished.");
		}

		public void DragCancelled()
		{
			Console.WriteLine("Cancelled.");
		}

		public bool TryCatchOccurredException(Exception exception)
		{
			return false;
		}
	}
}
