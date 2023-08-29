// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
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

using GroupDocs.Watermark.Cloud.Sdk.Client;
using GroupDocs.Watermark.Cloud.Sdk.Model;
using GroupDocs.Watermark.Cloud.Sdk.Model.Requests;
using GroupDocs.Watermark.Cloud.Sdk.Test.Api.Internal;
using GroupDocs.Watermark.Cloud.Sdk.Test.Infrastructure;
using NUnit.Framework;

namespace GroupDocs.Watermark.Cloud.Sdk.Test.Api
{
    [TestFixture]
    public class TestReplaceWatermarkApi : BaseApiTest
    {
        [Test]
        public void Replace_Watermark_Test()
        {
            var testFile = TestFiles.PdfWithWatermarks;
            var options = new ReplaceOptions
            {
                FileInfo = testFile.ToFileInfo(),
                ImageSearchCriteria = new ImageSearchCriteria
                {
                    ImageFileInfo = TestFiles.SampleWatermarkTransparent.ToFileInfo()
                },
                TextSearchCriteria = new TextSearchCriteria
                {
                    SearchText = "Watermark text"
                },
                ReplaceTextOptions = new ReplaceTextOptions
                {
                    Text = "New watermark text",
                },
                ReplaceImageOptions = new ReplaceImageOptions
                {
                    Image = TestFiles.Jpg.ToFileInfo()
                }
            };
            var request = new ReplaceRequest(options);
            var result = WatermarkApi.Replace(request);

            CheckIfWatermarkExist(result.Path, "Watermark text", TestFiles.Jpg.ToFileInfo());
        }

        [Test]
        public void Replace_Watermark_File_Not_Found()
        {
            var testFile = TestFiles.NotExist;
            var options = new ReplaceOptions()
            {
                FileInfo = testFile.ToFileInfo(),
                ImageSearchCriteria = new ImageSearchCriteria
                {
                    ImageFileInfo = TestFiles.SampleWatermarkTransparent.ToFileInfo()
                },
                TextSearchCriteria = new TextSearchCriteria
                {
                    SearchText = "Watermark text"
                }
            };

            var request = new ReplaceRequest(options);
            var ex = Assert.Throws<ApiException>(() => { WatermarkApi.Replace(request); });
            Assert.AreEqual($"Can't find file located at '{testFile.FullName}'.", JsonUtils.GetErrorMessage(ex.Message));
        }

        [Test]
        public void Replace_Watermark_Incorrect_Password()
        {
            var testFile = TestFiles.PasswordProtected;
            var options = new ReplaceOptions
            {
                FileInfo = new FileInfo
                {
                    FilePath = testFile.FullName,
                    Password = "123"
                },
                ImageSearchCriteria = new ImageSearchCriteria
                {
                    ImageFileInfo = TestFiles.SampleWatermarkTransparent.ToFileInfo()
                },
                TextSearchCriteria = new TextSearchCriteria
                {
                    SearchText = "Watermark text"
                }
            };

            var request = new ReplaceRequest(options);
            var ex = Assert.Throws<ApiException>(() => { WatermarkApi.Replace(request); });
            Assert.AreEqual($"Password provided for file '{testFile.FullName}' is incorrect.", JsonUtils.GetErrorMessage(ex.Message));
        }

        [Test]
        public void Replace_Watermark_File_Not_Supported()
        {
            var testFile = TestFiles.Zip;
            var options = new ReplaceOptions
            {
                FileInfo = testFile.ToFileInfo(),
                ImageSearchCriteria = new ImageSearchCriteria
                {
                    ImageFileInfo = TestFiles.SampleWatermarkTransparent.ToFileInfo()
                },
                TextSearchCriteria = new TextSearchCriteria
                {
                    SearchText = "Watermark text"
                }
            };

            var request = new ReplaceRequest(options);
            var ex = Assert.Throws<ApiException>(() => { WatermarkApi.Replace(request); });
            Assert.AreEqual($"The specified file '{testFile.FullName}' has type which is not currently supported.", JsonUtils.GetErrorMessage(ex.Message));
        }

        [Test]
        public void Replace_Watermark_Without_Options()
        {
            var request = new ReplaceRequest(null);
            var ex = Assert.Throws<ApiException>(() => { WatermarkApi.Replace(request); });
            Assert.AreEqual("Missing required parameter 'options' when calling Replace", ex.Message);
        }

        [Test]
        public void Replace_Watermark_No_Search_Criteria()
        {
            var testFile = TestFiles.Xlsx;
            var options = new ReplaceOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputFolder = "found_image_watermarks"
            };

            var request = new ReplaceRequest(options);
            var ex = Assert.Throws<ApiException>(() => { WatermarkApi.Replace(request); });
            Assert.AreEqual("Request parameters missing or have incorrect format", JsonUtils.GetErrorMessage(ex.Message));
        }

        private void CheckIfWatermarkExist(string path, string watermarkText, FileInfo watermarkImage)
        {
            var existRequest = new ObjectExistsRequest(path);
            Assert.True(StorageApi.ObjectExists(existRequest).Exists);

            var searchOptions = new SearchOptions();
            searchOptions.FileInfo = new FileInfo
            {
                FilePath = path
            };

            if (watermarkText != null)
            {
                searchOptions.TextSearchCriteria = new TextSearchCriteria { SearchText = watermarkText };
            }

            if (watermarkImage != null)
            {
                searchOptions.ImageSearchCriteria = new ImageSearchCriteria
                    { ImageFileInfo = watermarkImage };
            }

            var searchRequest = new SearchRequest(searchOptions);
            var searchResult = WatermarkApi.Search(searchRequest);

            Assert.IsNotEmpty(searchResult.Watermarks);
        }
    }
}