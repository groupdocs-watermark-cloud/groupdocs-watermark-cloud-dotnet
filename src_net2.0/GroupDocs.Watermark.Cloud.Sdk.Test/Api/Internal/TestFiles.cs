// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="TestFiles.cs">
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

using System.Collections.Generic;

namespace GroupDocs.Watermark.Cloud.Sdk.Test.Api.Internal
{
    public static class TestFiles
    {
        public static readonly string DefaultPassword = "password";

        public static readonly TestFile PasswordProtected = new TestFile("password-protected.docx", "documents\\")
        {
            Password = DefaultPassword
        };

        public static readonly TestFile Docx = new TestFile("sample.docx", "documents\\");
        public static readonly TestFile Zip = new TestFile("sample.zip", "documents\\");
        public static readonly TestFile Msg = new TestFile("sample.msg", "documents\\");
        public static readonly TestFile Pdf = new TestFile("sample.pdf", "documents\\");
        public static readonly TestFile Pptx = new TestFile("sample.pptx", "documents\\");
        public static readonly TestFile Xlsx = new TestFile("sample.xlsx", "documents\\");
        public static readonly TestFile Visio = new TestFile("sample.vsdx", "documents\\");
        public static readonly TestFile MsgWithAttachments = new TestFile("samplewithattachments.msg", "documents\\");
        public static readonly TestFile Jpg = new TestFile("sample.jpg", "images\\");
        public static readonly TestFile Tiff = new TestFile("multipage_tiff_sample.tif", "images\\");
        public static readonly TestFile PdfWithWatermarks = new TestFile("sample.pdf", "with_watermarks\\");
        public static readonly TestFile SampleWatermarkTransparent = new TestFile("sample_watermark.png", "watermark_images\\");
        public static readonly TestFile NotExist = new TestFile("folder\\file-not-exist.pdf", "");

        public static IEnumerable<TestFile> TestFilesList
        {
            get
            {
                yield return PasswordProtected;
                yield return Docx;
                yield return Zip;
                yield return Msg;
                yield return Pdf;
                yield return Pptx;
                yield return Xlsx;
                yield return Visio;
                yield return MsgWithAttachments;
                yield return Jpg;
                yield return Tiff;
                yield return PdfWithWatermarks;
                yield return SampleWatermarkTransparent;
            }
        }
    }
}