<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/301388415/20.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T937121)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [SampleData.cs](./CS/BlazorApp_WordProcessing/Data/SampleData.cs)

* [Index.razor](./CS/BlazorApp_WordProcessing/Pages/Index.razor)
<!-- default file list end -->

# Word Processing – How to Generate and Send Business Letters within Your Blazor Server Apps

This Blazor Server application uses the [Word Processing Document API](https://docs.devexpress.com/OfficeFileAPI/17488/word-processing-document-api?p=netstandard) to generate multiple business letters based on a template. Users can download these letters in PDF format or send them via e-mail.

![Word Processing - Final App](./images/word-processing-blazor-final-app.png)

To run the application, you need to install or restore the following NuGet packages:

* [DevExpress.Document.Processor](https://nuget.devexpress.com/packages/DevExpress.Document.Processor/) - Contains the DevExpress Office File API components.

* [DevExpress.Blazor](https://nuget.devexpress.com/packages/DevExpress.Blazor/) - Contains the DevExpress Blazor UI components.

* [MailKit](https://www.nuget.org/packages/MailKit/) - An open source .NET library used to send e-mail messages.
