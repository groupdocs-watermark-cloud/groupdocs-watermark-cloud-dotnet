// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="TextFormattingSearchCriteria.cs">
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
    /// Class for text formatting search criteria options.
    /// </summary>  
    public class TextFormattingSearchCriteria 
    {                       
        /// <summary>
        /// Gets or sets the foreground color range.
        /// </summary>  
        public ColorRange ForegroundColorRange { get; set; }

        /// <summary>
        /// Gets or sets the background color range.
        /// </summary>  
        public ColorRange BackgroundColorRange { get; set; }

        /// <summary>
        /// Gets or sets the name of the font.
        /// </summary>  
        public string FontName { get; set; }

        /// <summary>
        /// Gets or sets the minimum size of the font.
        /// </summary>  
        public double? MinFontSize { get; set; }

        /// <summary>
        /// Gets or sets the maximum size of the font.
        /// </summary>  
        public double? MaxFontSize { get; set; }

        /// <summary>
        /// Gets or sets the font bold style.
        /// </summary>  
        public bool? FontBold { get; set; }

        /// <summary>
        /// Gets or sets the font underline style.
        /// </summary>  
        public bool? FontUnderline { get; set; }

        /// <summary>
        /// Gets or sets the font strikeout style.
        /// </summary>  
        public bool? FontStrikeout { get; set; }

        /// <summary>
        /// Gets or sets the font italic style.
        /// </summary>  
        public bool? FontItalic { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TextFormattingSearchCriteria {\n");
          sb.Append("  ForegroundColorRange: ").Append(this.ForegroundColorRange).Append("\n");
          sb.Append("  BackgroundColorRange: ").Append(this.BackgroundColorRange).Append("\n");
          sb.Append("  FontName: ").Append(this.FontName).Append("\n");
          sb.Append("  MinFontSize: ").Append(this.MinFontSize).Append("\n");
          sb.Append("  MaxFontSize: ").Append(this.MaxFontSize).Append("\n");
          sb.Append("  FontBold: ").Append(this.FontBold).Append("\n");
          sb.Append("  FontUnderline: ").Append(this.FontUnderline).Append("\n");
          sb.Append("  FontStrikeout: ").Append(this.FontStrikeout).Append("\n");
          sb.Append("  FontItalic: ").Append(this.FontItalic).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
