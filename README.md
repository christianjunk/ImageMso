# ImageMso
Microsoft Office Icons (ImageMSO) Gallery &amp; Extraction

---

Microsoft Excel Add-In to browse and save icons from Microsoft Office. Includes a compilation of 8,899 image names and a library for use with Excel development.

## Description

Microsoft Excel Add-In to browse and save icons from Microsoft Office.
Includes a compilation of 8,899 image names and a library for use with Excel development.

## Introduction

In building Microsoft Office Add-Ins and applications, ImageMSO icons (the images embedded in Microsoft Office core Applications that graphically represent controls) have come to frequent use as they very effectively illustrate several actions intended by underlying controls. Outside of the Microsoft Office embedded development environments though, ImageMSO icons are difficult to extract and use, as is the case with compiled .NET Add-Ins.

Searching online, there are resources provided by Microsoft as well as many posts that outline do-it-yourself processes to aide in finding and extracting ImageMSO icons for custom use but these resources have the following limitations:

- Searching ImageMSO names by keywords and correlating those names to images is a tedious and error prone process.
- The process to build a onetime solution to extract the ImageMSO icons, when only a few icons might be targeted, is repeated by every user and developer.
- The do-it-yourself solutions require development knowledge and an integrated development environment even when the purpose does not warrant such measures.

This project amalgamates and extends the knowledge base and presents it in a development ready library and user friendly Microsoft Excel Add-In.

## Summary

- A library class that encapsulates the collection of 8,899 distinct ImageMso names formed by the union of values collected from [2007 Office System Add-In: Icons Gallery](https://web.archive.org/web/20180330183754mp_/https://www.microsoft.com/en-us/download/details.aspx?id=11675), [Office 2010 Add-In: Icons Gallery](https://web.archive.org/web/20180330183754mp_/https://www.microsoft.com/en-us/download/details.aspx?id=21103), [Appendix A: Custom UI Control ID Tables, MS-CUSTOMUI imageMso Table](https://web.archive.org/web/20180330183754mp_/http://msdn.microsoft.com/en-us/library/dd953682.aspx) and [Microsoft Office Document: MS-CUSTOMUI2 Supporting Documentation](https://web.archive.org/web/20180330183754mp_/https://www.microsoft.com/en-us/download/details.aspx?id=727).
- A library class that encapsulates the methods to copy ImageMSO icons to a usable GDI+ bitmap in custom specified sizes for use with Microsoft Excel development based off the answer on Stack Overflow in response to the question [How to save ImageMSO icon from Microsoft Office 2007?](https://web.archive.org/web/20180330183754mp_/http://stackoverflow.com/questions/1073322/how-to-save-imagemso-icon-from-microsoft-office-2007) which was turn based off the MSDN blog post [Preserving the alpha channel when converting images](https://web.archive.org/web/20180330183754mp_/http://blogs.msdn.com/b/andreww/archive/2007/10/10/preserving-the-alpha-channel-when-converting-images.aspx).
- A Microsoft Excel Add-In, powered by Excel-DNA, that enables the user to:
  - filter ImageMSO names by keywords
  - copy ImageMSO names to clipboard
  - copy ImageMSO icons to clipboard
  - drag & drop ImageMSO icons into Microsoft Office applications
  - export ImageMSO icons, [by way of IconLib](https://web.archive.org/web/20180330183754mp_/http://www.codeproject.com/Articles/16178/IconLib-Icons-Unfolded-MultiIcon-and-Windows-Vista), in multiple sizes to a single icon resource file
  - save ImageMSO icons to several image file formats

## Links

- [Excel-DNA - Free and easy .NET for Excel](https://web.archive.org/web/20180330183754mp_/http://excel-dna.net/)
- [IconLib - Icons Unfolded (MultiIcon and Windows Vista supported)](https://web.archive.org/web/20180330183754mp_/http://www.codeproject.com/Articles/16178/IconLib-Icons-Unfolded-MultiIcon-and-Windows-Vista)
- [About the Author](https://web.archive.org/web/20180330183754mp_/https://www.facebook.com/altonxl)

You are also encouraged to directly [contact the author by e-mail](mailto:alton.x.lam@gmail.com) with questions, comments or suggestions.
