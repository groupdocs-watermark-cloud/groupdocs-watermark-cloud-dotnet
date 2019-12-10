using GroupDocs.Watermark.Cloud.Sdk.Client;
using GroupDocs.Watermark.Cloud.Sdk.Model;
using GroupDocs.Watermark.Cloud.Sdk.Model.Requests;
using GroupDocs.Watermark.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Watermark.Cloud.Sdk.Test.Api
{
    [TestFixture]
    public class TestInfoApi : BaseApiTest
    {
        [Test]
        public void InfoApiTest_Word()
        {
            var options = new InfoOptions { FileInfo = TestFiles.Docx.ToFileInfo() };
            var request = new GetInfoRequest(options);

            var result = InfoApi.GetInfo(request);
            Assert.IsNotNull(result);
            Assert.AreEqual("MICROSOFT WORD OPEN XML DOCUMENT", result.FileType.FileFormat.ToUpper());
            Assert.AreEqual(2, result.PageCount);
        }

        [Test]
        public void InfoApiTest_Msg()
        {
            var options = new InfoOptions { FileInfo = TestFiles.Msg.ToFileInfo() };
            var request = new GetInfoRequest(options);

            var result = InfoApi.GetInfo(request);
            Assert.IsNotNull(result);
            Assert.AreEqual("OUTLOOK MAIL MESSAGE", result.FileType.FileFormat.ToUpper());
            Assert.AreEqual(4090880L, result.Size);
        }

        [Test]
        public void InfoApiTest_Pdf()
        {
            var options = new InfoOptions { FileInfo = TestFiles.Pdf.ToFileInfo() };
            var request = new GetInfoRequest(options);

            var result = InfoApi.GetInfo(request);
            Assert.IsNotNull(result);
            Assert.AreEqual("PORTABLE DOCUMENT FORMAT FILE", result.FileType.FileFormat.ToUpper());
            Assert.AreEqual(2, result.PageCount);
        }

        [Test]
        public void InfoApiTest_Visio()
        {
            var options = new InfoOptions { FileInfo = TestFiles.Visio.ToFileInfo() };
            var request = new GetInfoRequest(options);

            var result = InfoApi.GetInfo(request);
            Assert.IsNotNull(result);
            Assert.AreEqual("VISIO DRAWING", result.FileType.FileFormat.ToUpper());
            Assert.AreEqual(1665923L, result.Size);
        }

        [Test]
        public void InfoApiTest_Pptx()
        {
            var options = new InfoOptions { FileInfo = TestFiles.Pptx.ToFileInfo() };
            var request = new GetInfoRequest(options);

            var result = InfoApi.GetInfo(request);
            Assert.IsNotNull(result);
            Assert.AreEqual("POWERPOINT OPEN XML PRESENTATION", result.FileType.FileFormat.ToUpper());
            Assert.AreEqual(3, result.PageCount);
        }

        [Test]
        public void InfoApiTest_Xlsx()
        {
            var options = new InfoOptions { FileInfo = TestFiles.Xlsx.ToFileInfo() };
            var request = new GetInfoRequest(options);

            var result = InfoApi.GetInfo(request);
            Assert.IsNotNull(result);
            Assert.AreEqual("MICROSOFT EXCEL OPEN XML SPREADSHEET", result.FileType.FileFormat.ToUpper());
            Assert.AreEqual(3, result.PageCount);
        }

        [Test]
        public void InfoApiTest_Jpeg()
        {
            var options = new InfoOptions { FileInfo = TestFiles.Jpg.ToFileInfo() };
            var request = new GetInfoRequest(options);

            var result = InfoApi.GetInfo(request);
            Assert.IsNotNull(result);
            Assert.AreEqual("JPEG IMAGE", result.FileType.FileFormat.ToUpper());
            Assert.AreEqual(1, result.PageCount);
        }

        [Test]
        public void InfoApiTest_FileNotFoundResult()
        {
            var options = new InfoOptions { FileInfo = TestFiles.NotExist.ToFileInfo() };
            var request = new GetInfoRequest(options);

            var ex = Assert.Throws<ApiException>(() => { InfoApi.GetInfo(request); });
            Assert.AreEqual($"Can't find file located at '{TestFiles.NotExist.FullName}'.", ex.Message);
        }

        [Test]
        public void InfoApiTest_Not_Supported()
        {
            var testFile = TestFiles.Zip;
            var options = new InfoOptions { FileInfo = testFile.ToFileInfo() };
            var request = new GetInfoRequest(options);

            var ex = Assert.Throws<ApiException>(() => { InfoApi.GetInfo(request); });
            Assert.AreEqual($"The specified file '{testFile.FullName}' has type which is not currently supported.", ex.Message);
        }
    }
}