//
// Util.cs
//
// Author: Kees van Spelde <sicos2002@hotmail.com>
//
// Copyright (c) 2013-2019 Magic-Sessions. (www.magic-sessions.com)
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
// FITNESS FOR A PARTICULAR PURPOSE AND NON INFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

namespace MsgReader.Rtf
{
    /// <summary>
    /// Some utility functions
    /// </summary>
    internal static class Util
    {
        #region HasContentElement
        /// <summary>
        /// Checks if the root element has content elemens
        /// </summary>
        /// <param name="rootElement"></param>
        /// <returns>True when there are content elements</returns>
        public static bool HasContentElement(DomElement rootElement)
        {
            if (rootElement.Elements.Count == 0)
            {
                return false;
            }
            if (rootElement.Elements.Count == 1)
            {
                if (rootElement.Elements[0] is DomParagraph)
                {
                    var p = (DomParagraph) rootElement.Elements[0];
                    if (p.Elements.Count == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion
    }
}