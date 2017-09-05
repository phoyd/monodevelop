//
// ExtractInterfaceOptionsService.cs
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
 
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.ExtractInterface;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.CodeAnalysis.LanguageServices;
using Microsoft.CodeAnalysis.Notification;
 
namespace Microsoft.VisualStudio.LanguageServices.Implementation.ExtractInterface
{
	// master-refactorings contains implementation for this
	[ExportWorkspaceService(typeof(IExtractInterfaceOptionsService), ServiceLayer.Host), Shared]
	class ExtractInterfaceOptionsService : IExtractInterfaceOptionsService
	{
		public ExtractInterfaceOptionsResult GetExtractInterfaceOptions(
			ISyntaxFactsService syntaxFactsService,
			INotificationService notificationService,
			List<ISymbol> extractableMembers,
			string defaultInterfaceName,
			List<string> allTypeNames,
			string defaultNamespace,
			string generatedNameTypeParameterSuffix,
			string languageName)
		{
			//var viewModel = new ExtractInterfaceDialogViewModel(
			//	syntaxFactsService,
			//	notificationService,
			//	defaultInterfaceName,
			//	extractableMembers,
			//	allTypeNames,
			//	defaultNamespace,
			//	generatedNameTypeParameterSuffix,
			//	languageName,
			//	languageName == LanguageNames.CSharp ? ".cs" : ".vb");

			//var dialog = new ExtractInterfaceDialog(viewModel);
			//var result = dialog.ShowModal();

			//if (result.HasValue && result.Value)
			//{
			//	return new ExtractInterfaceOptionsResult(
			//		isCancelled: false,
			//		includedMembers: viewModel.MemberContainers.Where(c => c.IsChecked).Select(c => c.MemberSymbol),
			//		interfaceName: viewModel.InterfaceName.Trim(),
			//		fileName: viewModel.FileName.Trim());
			//}
			return ExtractInterfaceOptionsResult.Cancelled;
		}
	}
}
