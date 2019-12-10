// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SearchResultItem.cs">
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
    /// Search result item.
    /// </summary>  
    public class SearchResultItem 
    {                       
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>  
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the image URL.
        /// </summary>  
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>  
        public double? Height { get; set; }

        /// <summary>
        /// Gets or sets the rotate angle.
        /// </summary>  
        public double? RotateAngle { get; set; }

        /// <summary>
        /// Gets or sets the unit of measurement.
        /// </summary>  
        public string UnitOfMeasurement { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>  
        public double? Width { get; set; }

        /// <summary>
        /// Gets or sets the x coordinate.
        /// </summary>  
        public double? X { get; set; }

        /// <summary>
        /// Gets or sets the y coordinate.
        /// </summary>  
        public double? Y { get; set; }

        /// <summary>
        /// Gets or sets the type of the possible watermark type.
        /// </summary>  
        public string PossibleWatermarkType { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SearchResultItem {\n");
          sb.Append("  Id: ").Append(this.Id).Append("\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  ImageUrl: ").Append(this.ImageUrl).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  RotateAngle: ").Append(this.RotateAngle).Append("\n");
          sb.Append("  UnitOfMeasurement: ").Append(this.UnitOfMeasurement).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  X: ").Append(this.X).Append("\n");
          sb.Append("  Y: ").Append(this.Y).Append("\n");
          sb.Append("  PossibleWatermarkType: ").Append(this.PossibleWatermarkType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
