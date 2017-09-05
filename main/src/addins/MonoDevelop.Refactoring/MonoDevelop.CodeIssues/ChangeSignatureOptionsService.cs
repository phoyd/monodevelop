//
// ChangeSignatureOptionsService.cs
//
// Author:
//       Marius Ungureanu <maungu@microsoft.com>
//
// Copyright (c) 2017 
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System.Composition;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.ChangeSignature;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.CodeAnalysis.Notification;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.ChangeSignature
{
	// master-refactorings contains implementation for this
	[ExportWorkspaceService(typeof(IChangeSignatureOptionsService), ServiceLayer.Host), Shared]
	internal class ChangeSignatureOptionsService : IChangeSignatureOptionsService
	{
		//private readonly ClassificationTypeMap _classificationTypeMap;

		//[ImportingConstructor]
		//public VisualStudioChangeSignatureOptionsService(ClassificationTypeMap classificationTypeMap)
		//{
		//	_classificationTypeMap = classificationTypeMap;
		//}

		public ChangeSignatureOptionsResult GetChangeSignatureOptions(ISymbol symbol, ParameterConfiguration parameters, INotificationService notificationService)
		{
			//var viewModel = new ChangeSignatureDialogViewModel(notificationService, parameters, symbol, _classificationTypeMap);

			//var dialog = new ChangeSignatureDialog(viewModel);
			//var result = dialog.ShowModal();

			//if (result.HasValue && result.Value)
			//{
			//	return new ChangeSignatureOptionsResult { IsCancelled = false, UpdatedSignature = new SignatureChange(parameters, viewModel.GetParameterConfiguration()), PreviewChanges = viewModel.PreviewChanges };
			//}

			return new ChangeSignatureOptionsResult { IsCancelled = true };
		}
	}
}
