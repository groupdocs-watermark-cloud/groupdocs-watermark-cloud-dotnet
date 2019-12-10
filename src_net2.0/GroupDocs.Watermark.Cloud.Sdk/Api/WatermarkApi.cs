// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="WatermarkApi.cs">
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

namespace GroupDocs.Watermark.Cloud.Sdk.Api
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using GroupDocs.Watermark.Cloud.Sdk.Client;
    using GroupDocs.Watermark.Cloud.Sdk.Client.RequestHandlers;
    using GroupDocs.Watermark.Cloud.Sdk.Model;
    using GroupDocs.Watermark.Cloud.Sdk.Model.Requests;
    
    /// <summary>
    /// GroupDocs.Watermark Cloud API.
    /// </summary>
    public class WatermarkApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public WatermarkApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public WatermarkApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new AuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, this.configuration.Timeout);
        }                            

        /// <summary>
        /// Add watermarks to a document of any supported type. 
        /// </summary>
        /// <param name="request">Request. <see cref="AddRequest" /></param>
        /// <returns><see cref="WatermarkResult"/></returns>
        public WatermarkResult Add(AddRequest request)
        {
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling Add");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/watermark";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.options); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (WatermarkResult)SerializationHelper.Deserialize(response, typeof(WatermarkResult));
            }

            return null;
        }

        /// <summary>
        /// Find and remove watermarks using search criteria. 
        /// </summary>
        /// <param name="request">Request. <see cref="RemoveRequest" /></param>
        /// <returns><see cref="RemoveResult"/></returns>
        public RemoveResult Remove(RemoveRequest request)
        {
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling Remove");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/watermark/remove";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.options); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (RemoveResult)SerializationHelper.Deserialize(response, typeof(RemoveResult));
            }

            return null;
        }

        /// <summary>
        /// Replace watermarks. 
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceRequest" /></param>
        /// <returns><see cref="ReplaceResult"/></returns>
        public ReplaceResult Replace(ReplaceRequest request)
        {
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling Replace");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/watermark/replace";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.options); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (ReplaceResult)SerializationHelper.Deserialize(response, typeof(ReplaceResult));
            }

            return null;
        }

        /// <summary>
        /// Find watermarks using search criteria. 
        /// </summary>
        /// <param name="request">Request. <see cref="SearchRequest" /></param>
        /// <returns><see cref="SearchResult"/></returns>
        public SearchResult Search(SearchRequest request)
        {
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling Search");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/watermark/search";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.options); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (SearchResult)SerializationHelper.Deserialize(response, typeof(SearchResult));
            }

            return null;
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="AddRequest.cs">
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

namespace GroupDocs.Watermark.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Watermark.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Watermark.Cloud.Sdk.Api.WatermarkApi.Add" /> operation.
    /// </summary>  
    public class AddRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="AddRequest"/> class.
          /// </summary>        
          public AddRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="AddRequest"/> class.
          /// </summary>
          /// <param name="options"></param>
          public AddRequest(WatermarkOptions options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// Gets or sets options
          /// </summary>  
          public WatermarkOptions options { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="RemoveRequest.cs">
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

namespace GroupDocs.Watermark.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Watermark.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Watermark.Cloud.Sdk.Api.WatermarkApi.Remove" /> operation.
    /// </summary>  
    public class RemoveRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="RemoveRequest"/> class.
          /// </summary>        
          public RemoveRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="RemoveRequest"/> class.
          /// </summary>
          /// <param name="options"></param>
          public RemoveRequest(RemoveOptions options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// Gets or sets options
          /// </summary>  
          public RemoveOptions options { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ReplaceRequest.cs">
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

namespace GroupDocs.Watermark.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Watermark.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Watermark.Cloud.Sdk.Api.WatermarkApi.Replace" /> operation.
    /// </summary>  
    public class ReplaceRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="ReplaceRequest"/> class.
          /// </summary>        
          public ReplaceRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="ReplaceRequest"/> class.
          /// </summary>
          /// <param name="options"></param>
          public ReplaceRequest(ReplaceOptions options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// Gets or sets options
          /// </summary>  
          public ReplaceOptions options { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SearchRequest.cs">
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

namespace GroupDocs.Watermark.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Watermark.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Watermark.Cloud.Sdk.Api.WatermarkApi.Search" /> operation.
    /// </summary>  
    public class SearchRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="SearchRequest"/> class.
          /// </summary>        
          public SearchRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="SearchRequest"/> class.
          /// </summary>
          /// <param name="options"></param>
          public SearchRequest(SearchOptions options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// Gets or sets options
          /// </summary>  
          public SearchOptions options { get; set; }
    }
}
