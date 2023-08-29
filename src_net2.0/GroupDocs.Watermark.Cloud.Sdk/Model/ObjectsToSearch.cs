// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ObjectsToSearch.cs">
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
    /// Class for searchable objects options.
    /// </summary>  
    public class ObjectsToSearch 
    {                       
        /// <summary>
        /// Gets or sets the word processing searchable objects.
        /// </summary>  
        public string WordProcessingObjects { get; set; }

        /// <summary>
        /// Gets or sets the spreadsheet searchable objects.
        /// </summary>  
        public string SpreadsheetObjects { get; set; }

        /// <summary>
        /// Gets or sets the presentation searchable objects.
        /// </summary>  
        public string PresentationObjects { get; set; }

        /// <summary>
        /// Gets or sets the diagram searchable objects.
        /// </summary>  
        public string DiagramObjects { get; set; }

        /// <summary>
        /// Gets or sets the PDF searchable objects.
        /// </summary>  
        public string PdfObjects { get; set; }

        /// <summary>
        /// Gets or sets the email searchable objects.
        /// </summary>  
        public string EmailObjects { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ObjectsToSearch {\n");
          sb.Append("  WordProcessingObjects: ").Append(this.WordProcessingObjects).Append("\n");
          sb.Append("  SpreadsheetObjects: ").Append(this.SpreadsheetObjects).Append("\n");
          sb.Append("  PresentationObjects: ").Append(this.PresentationObjects).Append("\n");
          sb.Append("  DiagramObjects: ").Append(this.DiagramObjects).Append("\n");
          sb.Append("  PdfObjects: ").Append(this.PdfObjects).Append("\n");
          sb.Append("  EmailObjects: ").Append(this.EmailObjects).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
