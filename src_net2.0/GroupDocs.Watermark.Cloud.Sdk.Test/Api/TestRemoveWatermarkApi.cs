// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
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

using GroupDocs.Watermark.Cloud.Sdk.Client;
using GroupDocs.Watermark.Cloud.Sdk.Model;
using GroupDocs.Watermark.Cloud.Sdk.Model.Requests;
using GroupDocs.Watermark.Cloud.Sdk.Test.Api.Internal;
using GroupDocs.Watermark.Cloud.Sdk.Test.Infrastructure;
using NUnit.Framework;

namespace GroupDocs.Watermark.Cloud.Sdk.Test.Api
{
    [TestFixture]
    public class TestRemoveWatermarkApi : BaseApiTest
    {
        [Test]
        public void Remove_Watermark()
        {
            var testFile = TestFiles.PdfWithWatermarks;
            var options = new RemoveOptions
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
                OutputFolder = "removed_watermarks"
            };
            var request = new RemoveRequest(options);
            var result = WatermarkApi.Remove(request);

            CheckIfWatermarkNotExist(result.Path, "Watermark text", TestFiles.SampleWatermarkTransparent.ToFileInfo());
        }

        [Test]
        public void Remove_Watermark_File_Not_Found()
        {
            var testFile = TestFiles.NotExist;
            var options = new RemoveOptions
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
                OutputFolder = "removed_watermarks"
            };

            var request = new RemoveRequest(options);
            var ex = Assert.Throws<ApiException>(() => { WatermarkApi.Remove(request); });
            Assert.AreEqual($"Can't find file located at '{testFile.FullName}'.", JsonUtils.GetErrorMessage(ex.Message));
        }

        [Test]
        public void Remove_Watermark_Incorrect_Password()
        {
            var testFile = TestFiles.PasswordProtected;
            var options = new RemoveOptions
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
                },
                OutputFolder = "removed_watermarks"
            };

            var request = new RemoveRequest(options);
            var ex = Assert.Throws<ApiException>(() => { WatermarkApi.Remove(request); });
            Assert.AreEqual($"Password provided for file '{testFile.FullName}' is incorrect.", JsonUtils.GetErrorMessage(ex.Message));
        }

        [Test]
        public void Remove_Watermark_File_Not_Supported()
        {
            var testFile = TestFiles.Zip;
            var options = new RemoveOptions
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
                OutputFolder = "removed_watermarks"
            };

            var request = new RemoveRequest(options);
            var ex = Assert.Throws<ApiException>(() => { WatermarkApi.Remove(request); });
            Assert.AreEqual($"The specified file '{testFile.FullName}' has type which is not currently supported.", JsonUtils.GetErrorMessage(ex.Message));
        }

        [Test]
        public void Remove_Watermark_Without_Options()
        {
            var request = new RemoveRequest(null);
            var ex = Assert.Throws<ApiException>(() => { WatermarkApi.Remove(request); });
            Assert.AreEqual("Missing required parameter 'options' when calling Remove", ex.Message);
        }

        [Test]
        public void Remove_Watermark_No_Search_Criteria()
        {
            var testFile = TestFiles.Xlsx;
            var options = new RemoveOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputFolder = "removed_watermarks"
            };

            var request = new RemoveRequest(options);
            var ex = Assert.Throws<ApiException>(() => { WatermarkApi.Remove(request); });
            Assert.AreEqual("Request parameters missing or have incorrect format", JsonUtils.GetErrorMessage(ex.Message));
        }

        private void CheckIfWatermarkNotExist(string path, string watermarkText, FileInfo watermarkImage)
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

            Assert.IsEmpty(searchResult.Watermarks);
        }
    }
}