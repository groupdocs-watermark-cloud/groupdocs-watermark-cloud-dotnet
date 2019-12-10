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
using NUnit.Framework;
using System.Linq;

namespace GroupDocs.Watermark.Cloud.Sdk.Test.Api
{
    [TestFixture]
    public class TestSearchWatermarkApi : BaseApiTest
    {
        [Test]
        public void Search_Watermark()
        {
            var testFile = TestFiles.PdfWithWatermarks;
            var options = new SearchOptions
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
                SaveFoundImages = true,
                OutputFolder = "found_image_watermarks"
            };
            var request = new SearchRequest(options);
            var result = WatermarkApi.Search(request);

            Assert.IsNotNull(result);
            var urlTemplate = "watermark/storage/file/found_image_watermarks/sample_pdf/watermark_image_{0}";
            var itemsWithImage = result.Watermarks.Where(x => x.ImageUrl != null).ToList();
            for (int i = 0; i < itemsWithImage.Count; i++)
            {
                Assert.IsTrue(itemsWithImage.Any(x => x.ImageUrl.Contains(string.Format(urlTemplate, i))));
            }

            var text = result.Watermarks.First(x => !string.IsNullOrWhiteSpace(x.Text));
            Assert.AreEqual("Watermark text", text.Text);
        }

        [Test]
        public void Search_Watermark_File_Not_Found()
        {
            var testFile = TestFiles.NotExist;
            var options = new SearchOptions()
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
                OutputFolder = "found_image_watermarks"
            };

            var request = new SearchRequest(options);
            var ex = Assert.Throws<ApiException>(() => { WatermarkApi.Search(request); });
            Assert.AreEqual($"Can't find file located at '{testFile.FullName}'.", ex.Message);
        }

        [Test]
        public void Search_Watermark_Incorrect_Password()
        {
            var testFile = TestFiles.PasswordProtected;
            var options = new SearchOptions
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
                OutputFolder = "found_image_watermarks"
            };

            var request = new SearchRequest(options);
            var ex = Assert.Throws<ApiException>(() => { WatermarkApi.Search(request); });
            Assert.AreEqual($"Password provided for file '{testFile.FullName}' is incorrect.", ex.Message);
        }

        [Test]
        public void Search_Watermark_File_Not_Supported()
        {
            var testFile = TestFiles.Zip;
            var options = new SearchOptions
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
                OutputFolder = "found_image_watermarks"
            };

            var request = new SearchRequest(options);
            var ex = Assert.Throws<ApiException>(() => { WatermarkApi.Search(request); });
            Assert.AreEqual($"The specified file '{testFile.FullName}' has type which is not currently supported.", ex.Message);
        }

        [Test]
        public void Search_Watermark_Without_Options()
        {
            var request = new SearchRequest(null);
            var ex = Assert.Throws<ApiException>(() => { WatermarkApi.Search(request); });
            Assert.AreEqual("Missing required parameter 'options' when calling Search", ex.Message);
        }

        [Test]
        public void Search_Watermark_No_Search_Criteria()
        {
            var testFile = TestFiles.Xlsx;
            var options = new SearchOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputFolder = "found_image_watermarks"
            };

            var request = new SearchRequest(options);
            var ex = Assert.Throws<ApiException>(() => { WatermarkApi.Search(request); });
            Assert.AreEqual("Request parameters missing or have incorrect format", ex.Message);
        }
    }
}