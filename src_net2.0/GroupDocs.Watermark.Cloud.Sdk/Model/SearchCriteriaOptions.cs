// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SearchCriteriaOptions.cs">
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
    /// Class for search criteria options.
    /// </summary>  
    public class SearchCriteriaOptions 
    {                       
        /// <summary>
        /// Gets or sets the text search criteria.
        /// </summary>  
        public TextSearchCriteria TextSearchCriteria { get; set; }

        /// <summary>
        /// Gets or sets the image search criteria.
        /// </summary>  
        public ImageSearchCriteria ImageSearchCriteria { get; set; }

        /// <summary>
        /// Gets or sets the size search criteria.
        /// </summary>  
        public SizeSearchCriteria SizeSearchCriteria { get; set; }

        /// <summary>
        /// Gets or sets the rotate angle search criteria.
        /// </summary>  
        public RotateAngleSearchCriteria RotateAngleSearchCriteria { get; set; }

        /// <summary>
        /// Gets or sets the text formatting search criteria.
        /// </summary>  
        public TextFormattingSearchCriteria TextFormattingSearchCriteria { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SearchCriteriaOptions {\n");
          sb.Append("  TextSearchCriteria: ").Append(this.TextSearchCriteria).Append("\n");
          sb.Append("  ImageSearchCriteria: ").Append(this.ImageSearchCriteria).Append("\n");
          sb.Append("  SizeSearchCriteria: ").Append(this.SizeSearchCriteria).Append("\n");
          sb.Append("  RotateAngleSearchCriteria: ").Append(this.RotateAngleSearchCriteria).Append("\n");
          sb.Append("  TextFormattingSearchCriteria: ").Append(this.TextFormattingSearchCriteria).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
