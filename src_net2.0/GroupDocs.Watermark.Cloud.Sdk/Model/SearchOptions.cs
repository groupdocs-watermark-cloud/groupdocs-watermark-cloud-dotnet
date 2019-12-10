// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SearchOptions.cs">
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
    /// Class for search watermark options.
    /// </summary>  
    public class SearchOptions : SearchCriteriaOptions 
    {                       
        /// <summary>
        /// Gets or sets the file information.
        /// </summary>  
        public FileInfo FileInfo { get; set; }

        /// <summary>
        /// Gets or sets the output folder.
        /// </summary>  
        public string OutputFolder { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether found images should be saved.
        /// </summary>  
        public bool? SaveFoundImages { get; set; }

        /// <summary>
        /// Gets or sets the objects to search.
        /// </summary>  
        public ObjectsToSearch ObjectsToSearch { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SearchOptions {\n");
          sb.Append("  FileInfo: ").Append(this.FileInfo).Append("\n");
          sb.Append("  OutputFolder: ").Append(this.OutputFolder).Append("\n");
          sb.Append("  SaveFoundImages: ").Append(this.SaveFoundImages).Append("\n");
          sb.Append("  ObjectsToSearch: ").Append(this.ObjectsToSearch).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
