![](https://img.shields.io/badge/api-v1.0-lightgrey) ![Nuget](https://img.shields.io/nuget/v/GroupDocs.watermark-Cloud) ![Nuget](https://img.shields.io/nuget/dt/GroupDocs.watermark-Cloud) [![GitHub license](https://img.shields.io/github/license/groupdocs-watermark-cloud/groupdocs-watermark-cloud-dotnet)](https://github.com/groupdocs-watermark-cloud/groupdocs-watermark-cloud-dotnet/blob/master/LICENSE)

# GroupDocs.Watermark Cloud SDK for .NET
GroupDocs.Watermark Cloud is a REST API for managing watermarks in the documents. It provides the effective watermarking methods to add image and text watermarks. Furthermore, API works to search and remove the watermarks which were already added to the documents by other third-party software. Microsoft Word, Excel, PowerPoint, Visio, PDF, raster images, multi-page TIFF and animated GIF formats are supported.

This repository contains GroupDocs.Watermark Cloud SDK for .NET source code. This SDK allows you to work with GroupDocs.Watermark Cloud REST APIs in your .NET applications.

## Cloud Document Watermarking Features

- Add text or image watermarks to documents of supported formats.
- Create watermarks for specific pages only.
- Specify the physical attributes of the watermark, e.g., size, font, color, etc.
- Search for the collection of the image or text-based watermarks inside a document.
- Edit properties of the existing editable watermarks.
- Remove watermarks from specific pages or remove specific watermarks from the document.

## New features & Enhacements Version 19.12

- This is the first release of a completely new version of the GroupDocs.Watermark.Cloud API.

## Supported File Formats
The following file formats support the adding, removing, searching, and replacing watermark:

- **Microsoft Word**: DOC, DOT, DOCX, DOCM, DOTX, DOTM, RTF
- **Microsoft Excel**: XLSX, XLSM, XLTM, XLT, XLTX, XLS
- **Microsoft PowerPoint**: PPTX, PPTM, PPSX, PPSM, POTX, POTM, PPT, PPS
- **Microsoft Visio**: VSD, VDX, VSDX, VSTX, VSS, VSSX, VSDM, VSSM, VSTM, VTX, VSX
- **OpenOffice**: ODT
- **Image**: BMP, GIF, JPG, JPEG, JPE, JP2, PNG, TIFF, WEBP
- **Portable**: PDF
## How to use the SDK?
The complete source code is available in this repository folder, you can either directly use it in your project via NuGet package manager. For more details, please visit our [documentation website](https://docs.groupdocs.cloud/watermark/available-sdks/).

## Dependencies
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json)


## Get Supported File Formats for Watermark

```csharp
// Get Client Id and Client Secret from https://dashboard.groupdocs.cloud
string MyClientId = "";
string MyClientSecret = "";

// Create instance of the API
var configuration = new Configuration(MyClientId, MyClientSecret);
var api = new InfoApi(configuration);

// Get supported file formats
var response = api.GetSupportedFileFormats();

foreach (var format in response.Formats)
{
	Debug.Print(format.ToString());
}
```

## Licensing
All GroupDocs.Watermark Cloud SDKs are licensed under [MIT License](LICENSE).

[Home](https://www.groupdocs.cloud/) | [Product Page](https://products.groupdocs.cloud/watermark/net) | [Docs](https://docs.groupdocs.cloud/watermark/) | [Demos](https://products.groupdocs.app/watermark/family) | [API Reference](https://apireference.groupdocs.cloud/watermark/) | [Examples](https://github.com/groupdocs-watermark-cloud/groupdocs-watermark-cloud-dotnet-samples) | [Blog](https://blog.groupdocs.cloud/category/watermark/) | [Free Support](https://forum.groupdocs.cloud/c/watermark) | [Free Trial](https://purchase.groupdocs.cloud/trial)
