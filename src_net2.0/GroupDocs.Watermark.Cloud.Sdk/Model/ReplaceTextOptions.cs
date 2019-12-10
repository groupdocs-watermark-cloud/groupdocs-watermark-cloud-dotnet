// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ReplaceTextOptions.cs">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Watermark.Cloud.Sdk.Model 
{
    using System;  
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    
    /// <summary>
    /// Class for replace text options.
    /// </summary>  
    public class ReplaceTextOptions 
    {                       
        /// <summary>
        /// Gets or sets the text.
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the font family.
        /// </summary>  
        public string FontFamily { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>  
        public double? Size { get; set; }

        /// <summary>
        /// Gets or sets the style.
        /// </summary>  
        public string Style { get; set; }

        /// <summary>
        /// Gets or sets the color of the foreground.
        /// </summary>  
        public Color ForegroundColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the background.
        /// </summary>  
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ReplaceTextOptions {\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  FontFamily: ").Append(this.FontFamily).Append("\n");
          sb.Append("  Size: ").Append(this.Size).Append("\n");
          sb.Append("  Style: ").Append(this.Style).Append("\n");
          sb.Append("  ForegroundColor: ").Append(this.ForegroundColor).Append("\n");
          sb.Append("  BackgroundColor: ").Append(this.BackgroundColor).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
