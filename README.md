# GroupDocs.Watermark Cloud SDK for .NET
This repository contains GroupDocs.Watermark Cloud SDK for .NET source code. This SDK allows you to work with GroupDocs.Watermark Cloud REST APIs in your .NET applications.

## How to use the SDK?
The complete source code is available in this repository folder, you can either directly use it in your project via NuGet package manager. For more details, please visit our [documentation website](https://docs.groupdocs.cloud/display/watermarkcloud/Available+SDKs#AvailableSDKs-.NET).

## Dependencies
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json)

## Getting Started

```csharp
using System;
using System.Diagnostics;
using GroupDocs.Watermark.Cloud.Sdk.Api;

namespace Example
{
    public class Example
    {
        public void Main()
        {
            //TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
            var appSid = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX";
            var appKey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

            var api = new WatermarkApi(appSid, appKey);

            try
            {
                // Get supported file formats
                var response = api.GetSupportedFileFormats();

                foreach (var format in response.Formats)
                {
                    Debug.Print(format.ToString());
                }
            }
            catch (Exception e)
            {
                Debug.Print("Something went wrong: " + e.Message);
            }
        }
    }
}
```

## Licensing
All GroupDocs.Watermark Cloud SDKs are licensed under [MIT License](LICENSE).

## Resources
+ [**Website**](https://www.groupdocs.cloud)
+ [**Product Home**](https://products.groupdocs.cloud/watermark)
+ [**Documentation**](https://docs.groupdocs.cloud/display/watermarkcloud/Home)
+ [**Free Support Forum**](https://forum.groupdocs.cloud/c/watermark)
+ [**Blog**](https://blog.groupdocs.cloud/category/watermark)

## Contact Us
Your feedback is very important to us. Please feel free to contact us using our [Support Forums](https://forum.groupdocs.cloud/c/watermark).