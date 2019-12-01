﻿using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace DirectoryApp
{
    public static class OfficeAutomation
    {
        // TODO: This method is huge and ugly... needs to be broken apart and refactored a bit.
        public static string GenerateDirectoryPages(List<DirectoryEntry> DirectoryEntries, 
            System.Windows.Forms.Button btnGenerateDirectoryPages, System.Windows.Forms.Label lblGenerateDirectoryStatus)
        {
            Application application = null;
            try
            {
                // Control updates
                btnGenerateDirectoryPages.Enabled = false;
                lblGenerateDirectoryStatus.Text = "Creating output document...";

                // Load clipboard with "no picture" image
                Assembly myAssembly = Assembly.GetExecutingAssembly();
                Stream myStream = myAssembly.GetManifestResourceStream("DirectoryApp.Assets.picture-not-available.jpg");
                Bitmap bmp = new Bitmap(myStream);
                System.Windows.Forms.Clipboard.SetImage(bmp);

                // Create output document
                application = new Application();
                var document = application.Documents.Add();

                // Format document
                lblGenerateDirectoryStatus.Text = "Formatting document...";
                document.PageSetup.Orientation = WdOrientation.wdOrientLandscape;
                document.PageSetup.TopMargin
                    = document.PageSetup.LeftMargin
                    = document.PageSetup.RightMargin
                    = document.PageSetup.BottomMargin
                    = application.InchesToPoints(0.5f);
                document.PageSetup.BookFoldPrinting = true;
                
                // Page numbers
                document.ActiveWindow.View.SeekView = WdSeekView.wdSeekCurrentPageFooter;
                document.ActiveWindow.ActivePane.Selection.Paragraphs.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                document.ActiveWindow.ActivePane.Selection.Font.Name = "Perpetua";
                document.ActiveWindow.ActivePane.Selection.Font.Size = 10;
                document.ActiveWindow.Selection.TypeText("Page ");
                Object CurrentPage = WdFieldType.wdFieldPage;
                document.ActiveWindow.Selection.Fields.Add(document.ActiveWindow.Selection.Range, ref CurrentPage);
                document.ActiveWindow.Selection.TypeText(" of ");
                Object TotalPages = WdFieldType.wdFieldNumPages;
                document.ActiveWindow.Selection.Fields.Add(document.ActiveWindow.Selection.Range, ref TotalPages);

                // Output data
                foreach (var (directoryEntry, index) in DirectoryEntries.WithIndex())
                {
                    // Update label
                    lblGenerateDirectoryStatus.Text = $"Outputting information for {directoryEntry.FirstName} {directoryEntry.LastName}...";

                    // Set directory entry text
                    var directoryEntryText = $"{directoryEntry.FirstName} {directoryEntry.LastName}"
                        + (!string.IsNullOrWhiteSpace(directoryEntry.Children) ? $"\v{directoryEntry.Children}" : string.Empty)
                        + (!string.IsNullOrWhiteSpace(directoryEntry.Address1) ? $"\v{directoryEntry.Address1}" : string.Empty)
                        + (!string.IsNullOrWhiteSpace(directoryEntry.Address2) ? $", {directoryEntry.Address2}" : string.Empty)
                        + (!string.IsNullOrWhiteSpace(directoryEntry.City) ? $"\v{directoryEntry.City}, {directoryEntry.State} {directoryEntry.Zipcode}" : string.Empty)
                        + (!string.IsNullOrWhiteSpace(directoryEntry.PhoneCell) ? $"\v(cell) {directoryEntry.PhoneCell}" : string.Empty)
                        + (!string.IsNullOrWhiteSpace(directoryEntry.PhoneHome) ? $"\v(home) {directoryEntry.PhoneHome}" : string.Empty)
                        + (!string.IsNullOrWhiteSpace(directoryEntry.PhoneWork) ? $"\v(work) {directoryEntry.PhoneWork}" : string.Empty)
                        + (!string.IsNullOrWhiteSpace(directoryEntry.Email) ? $"\v{directoryEntry.Email}" : string.Empty)
                        + (!string.IsNullOrWhiteSpace(directoryEntry.Email2) ? $"\v{directoryEntry.Email2}" : string.Empty)
                        + (!string.IsNullOrWhiteSpace(directoryEntry.Email3) ? $"\v{directoryEntry.Email3}" : string.Empty);

                    // Table
                    object objEndOfDocFlag = "\\endofdoc"; //  \endofdoc is a predefined bookmark
                    var tableRange = document.Bookmarks.get_Item(ref objEndOfDocFlag).Range;
                    var table = document.Tables.Add(tableRange, 1, 2);
                    table.Cell(1, 1).Width = application.PixelsToPoints(225f);

                    // Image
                    if (!string.IsNullOrWhiteSpace(directoryEntry.Picture) && File.Exists(Properties.Settings.Default.PhotosFolder + "\\" + directoryEntry.Picture))
                    {
                        table.Cell(1, 1).Range.InlineShapes.AddPicture(Properties.Settings.Default.PhotosFolder + "\\" + directoryEntry.Picture);
                    }
                    else
                    {
                        table.Cell(1, 1).Range.Paste();
                    }
                    
                    // Text information for directory entry
                    table.Cell(1, 2).Range.Text = directoryEntryText;
                    table.Cell(1, 2).Range.Font.Name = "Perpetua";
                    table.Cell(1, 2).Range.Font.Size = 11;

                    // Set names to bold
                    var wordCount = Common.CountWordsAndCommas(directoryEntry.FirstName);
                    wordCount += Common.CountWordsAndCommas(directoryEntry.LastName);
                    wordCount += Common.CountWordsAndCommas(directoryEntry.Children);
                    wordCount += string.IsNullOrWhiteSpace(directoryEntry.Children) ? 0 : 1;
                    Range boldRange = table.Cell(1, 2).Range;
                    boldRange.SetRange(table.Cell(1, 2).Range.Start, table.Cell(1, 2).Range.Words[wordCount].End);
                    boldRange.Bold = 1;

                    // Spacer
                    object spacerRange = document.Bookmarks.get_Item(ref objEndOfDocFlag).Range;
                    var spacerParagaph = document.Content.Paragraphs.Add(ref spacerRange);
                    spacerParagaph.Format.SpaceBefore = spacerParagaph.Format.SpaceAfter = 0;
                    spacerParagaph.Range.Font.Size = 10;
                }

                // Save output file
                lblGenerateDirectoryStatus.Text = "Saving file...";
                string fileName = $"{Properties.Settings.Default.OutputFolder}\\DirectoryBody_{DateTime.Now:yyyyMMddHHmmss}.docx";
                application.ActiveDocument.SaveAs(fileName, WdSaveFormat.wdFormatDocumentDefault);
                document.Close();

                // Return the filename
                return fileName;
            }
            finally
            {
                // Clean up
                if (application != null)
                {
                    application.Quit();
                    Marshal.FinalReleaseComObject(application);
                }

                // Control updates
                lblGenerateDirectoryStatus.Text = string.Empty;
                btnGenerateDirectoryPages.Enabled = true;
            }
        }
    }
}
