// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="Position.cs">
//  Copyright (c) 2003-2023 Aspose Pty Ltd
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
    /// Class for watermark position options.
    /// </summary>  
    public class Position 
    {                       
        /// <summary>
        /// Gets or sets the x coordinate.
        /// </summary>  
        public double? X { get; set; }

        /// <summary>
        /// Gets or sets the y coordinate.
        /// </summary>  
        public double? Y { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>  
        public double? Width { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>  
        public double? Height { get; set; }

        /// <summary>
        /// Gets or sets the horizontal alignment.
        /// </summary>  
        public string HorizontalAlignment { get; set; }

        /// <summary>
        /// Gets or sets the vertical alignment.
        /// </summary>  
        public string VerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets the margins.
        /// </summary>  
        public Margin Margins { get; set; }

        /// <summary>
        /// Gets or sets the type of the sizing.
        /// </summary>  
        public string SizingType { get; set; }

        /// <summary>
        /// Gets or sets the scale factor.
        /// </summary>  
        public double? ScaleFactor { get; set; }

        /// <summary>
        /// Gets or sets the rotate angle.
        /// </summary>  
        public double? RotateAngle { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether parent margins should be considered.
        /// </summary>  
        public bool? ConsiderParentMargins { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether watermark is background.
        /// </summary>  
        public bool? IsBackground { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Position {\n");
          sb.Append("  X: ").Append(this.X).Append("\n");
          sb.Append("  Y: ").Append(this.Y).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  HorizontalAlignment: ").Append(this.HorizontalAlignment).Append("\n");
          sb.Append("  VerticalAlignment: ").Append(this.VerticalAlignment).Append("\n");
          sb.Append("  Margins: ").Append(this.Margins).Append("\n");
          sb.Append("  SizingType: ").Append(this.SizingType).Append("\n");
          sb.Append("  ScaleFactor: ").Append(this.ScaleFactor).Append("\n");
          sb.Append("  RotateAngle: ").Append(this.RotateAngle).Append("\n");
          sb.Append("  ConsiderParentMargins: ").Append(this.ConsiderParentMargins).Append("\n");
          sb.Append("  IsBackground: ").Append(this.IsBackground).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
