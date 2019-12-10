// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="WatermarkOptions.cs">
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
    /// Watermark options
    /// </summary>  
    public class WatermarkOptions 
    {                       
        /// <summary>
        /// Gets or sets the protect level.
        /// </summary>
        /// <value>Gets or sets the protect level.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtectLevelEnum
        { 
            /// <summary>
            /// Enum Document for "Document"
            /// </summary>            
            Document,
            
            /// <summary>
            /// Enum Images for "Images"
            /// </summary>            
            Images,
            
            /// <summary>
            /// Enum DocumentAndImages for "DocumentAndImages"
            /// </summary>            
            DocumentAndImages            
        }

        /// <summary>
        /// Gets or sets the protect level.
        /// </summary>
        public ProtectLevelEnum? ProtectLevel { get; set; }

        /// <summary>
        /// Gets or sets the file information.
        /// </summary>  
        public FileInfo FileInfo { get; set; }

        /// <summary>
        /// The folder for the resultant file.
        /// </summary>  
        public string OutputFolder { get; set; }

        /// <summary>
        /// Gets or sets the watermark details.
        /// </summary>  
        public List<WatermarkDetails> WatermarkDetails { get; set; }

        /// <summary>
        /// Gets or sets the PDF options.
        /// </summary>  
        public PdfOptions PdfOptions { get; set; }

        /// <summary>
        /// Gets or sets the image options.
        /// </summary>  
        public ImageOptions ImageOptions { get; set; }

        /// <summary>
        /// Gets or sets the presentation options.
        /// </summary>  
        public PresentationOptions PresentationOptions { get; set; }

        /// <summary>
        /// Gets or sets the word processing options.
        /// </summary>  
        public WordProcessingOptions WordProcessingOptions { get; set; }

        /// <summary>
        /// Gets or sets the spreadsheet options.
        /// </summary>  
        public SpreadsheetOptions SpreadsheetOptions { get; set; }

        /// <summary>
        /// Gets or sets the diagram options.
        /// </summary>  
        public DiagramOptions DiagramOptions { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class WatermarkOptions {\n");
          sb.Append("  FileInfo: ").Append(this.FileInfo).Append("\n");
          sb.Append("  OutputFolder: ").Append(this.OutputFolder).Append("\n");
          sb.Append("  WatermarkDetails: ").Append(this.WatermarkDetails).Append("\n");
          sb.Append("  ProtectLevel: ").Append(this.ProtectLevel).Append("\n");
          sb.Append("  PdfOptions: ").Append(this.PdfOptions).Append("\n");
          sb.Append("  ImageOptions: ").Append(this.ImageOptions).Append("\n");
          sb.Append("  PresentationOptions: ").Append(this.PresentationOptions).Append("\n");
          sb.Append("  WordProcessingOptions: ").Append(this.WordProcessingOptions).Append("\n");
          sb.Append("  SpreadsheetOptions: ").Append(this.SpreadsheetOptions).Append("\n");
          sb.Append("  DiagramOptions: ").Append(this.DiagramOptions).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
