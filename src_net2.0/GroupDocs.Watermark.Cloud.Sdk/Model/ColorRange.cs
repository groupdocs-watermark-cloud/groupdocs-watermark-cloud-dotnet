// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ColorRange.cs">
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
    /// Represents a range of colors. Specifies ranges using HSB representation of RGB color.
    /// </summary>  
    public class ColorRange 
    {                       
        /// <summary>
        /// The exact color from which the range is created.
        /// </summary>  
        public Color Color { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether only the empty color is in range.
        /// </summary>  
        public bool? IsEmpty { get; set; }

        /// <summary>
        /// Gets or sets the ending brightness value.
        /// </summary>  
        public double? MaxBrightness { get; set; }

        /// <summary>
        /// Gets or sets the ending hue value, in degrees.
        /// </summary>  
        public double? MaxHue { get; set; }

        /// <summary>
        /// Gets or sets the ending saturation value.
        /// </summary>  
        public double? MaxSaturation { get; set; }

        /// <summary>
        /// Gets or sets the starting brightness value.
        /// </summary>  
        public double? MinBrightness { get; set; }

        /// <summary>
        /// Gets or sets the starting hue value, in degrees.
        /// </summary>  
        public double? MinHue { get; set; }

        /// <summary>
        /// Gets or sets the starting saturation value.
        /// </summary>  
        public double? MinSaturation { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ColorRange {\n");
          sb.Append("  Color: ").Append(this.Color).Append("\n");
          sb.Append("  IsEmpty: ").Append(this.IsEmpty).Append("\n");
          sb.Append("  MaxBrightness: ").Append(this.MaxBrightness).Append("\n");
          sb.Append("  MaxHue: ").Append(this.MaxHue).Append("\n");
          sb.Append("  MaxSaturation: ").Append(this.MaxSaturation).Append("\n");
          sb.Append("  MinBrightness: ").Append(this.MinBrightness).Append("\n");
          sb.Append("  MinHue: ").Append(this.MinHue).Append("\n");
          sb.Append("  MinSaturation: ").Append(this.MinSaturation).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
