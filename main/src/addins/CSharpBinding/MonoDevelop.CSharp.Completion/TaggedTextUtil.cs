﻿//
// TaggedTextUtil.cs
//
// Author:
//       Mike Krüger <mikkrg@microsoft.com>
//
// Copyright (c) 2017 Microsoft Corporation
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
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis;
using MonoDevelop.Core;
using MonoDevelop.Ide.Editor.Highlighting;

namespace MonoDevelop.CSharp.Completion
{
	static class TaggedTextUtil
	{
		public static void AppendTaggedText (this StringBuilder markup, EditorTheme theme, IEnumerable<TaggedText> text)
		{
			foreach (var part in text) {
				markup.Append ("<span foreground=\"");
				markup.Append (GetThemeColor (theme, GetThemeColor (part.Tag)));
				markup.Append ("\">");
				markup.Append (part.Text);
				markup.Append ("</span>");
			}
		}

		static string GetThemeColor (EditorTheme theme, string scope)
		{
			return SyntaxHighlightingService.GetColorFromScope (theme, scope, EditorThemeColors.Foreground).ToPangoString ();
		}

		static string GetThemeColor (string tag)
		{
			switch (tag) {
			case TextTags.Keyword:
				return "keyword";

			case TextTags.Class:
				return EditorThemeColors.UserTypes;
			case TextTags.Delegate:
				return EditorThemeColors.UserTypesDelegates;
			case TextTags.Enum:
				return EditorThemeColors.UserTypesEnums;
			case TextTags.Interface:
				return EditorThemeColors.UserTypesInterfaces;
			case TextTags.Module:
				return EditorThemeColors.UserTypes;
			case TextTags.Struct:
				return EditorThemeColors.UserTypesValueTypes;
			case TextTags.TypeParameter:
				return EditorThemeColors.UserTypesTypeParameters;

			case TextTags.Alias:
			case TextTags.Assembly:
			case TextTags.Field:
			case TextTags.ErrorType:
			case TextTags.Event:
			case TextTags.Label:
			case TextTags.Local:
			case TextTags.Method:
			case TextTags.Namespace:
			case TextTags.Parameter:
			case TextTags.Property:
			case TextTags.RangeVariable:
				return "source.cs";

			case TextTags.NumericLiteral:
				return "constant.numeric";

			case TextTags.StringLiteral:
				return "string.quoted";

			case TextTags.Space:
			case TextTags.LineBreak:
				return "source.cs";

			case TextTags.Operator:
				return "keyword.source";

			case TextTags.Punctuation:
				return "punctuation";

			case TextTags.AnonymousTypeIndicator:
			case TextTags.Text:
				return "source.cs";

			default:
				LoggingService.LogWarning ("Warning unexpected text tag: " + tag);
				return "source.cs";
			}
		}
	}
}
