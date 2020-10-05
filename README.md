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
