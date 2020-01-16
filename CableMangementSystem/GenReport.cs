using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;


namespace CableMangementSystem
{
    public class GenReport
    {


        public void CreateDocument(string main,string sub,List<History> histories)
        {
            Document document = new Document();
            Section sec = document.AddSection();


            document.UseCmykColor = true;

            DefineStyles(document);

            const bool unicode = false;

            // add heading to the document 
            Heading(document, main, sub);

            // create table of information from the list of history
            CreateTableBilling(document, 7, histories);

            // rennder the document into pdf format 
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(unicode);
            pdfRenderer.Document = document;
            pdfRenderer.RenderDocument();

            const string fileName = "HelloWorld.pdf";
            pdfRenderer.PdfDocument.Save(fileName);
            Process.Start(fileName);
        }

        public static void Heading(Document document,string main,string sub)
        {
            Paragraph para = document.LastSection.AddParagraph(main, "Heading1");
            para.Format.Alignment = ParagraphAlignment.Center;

            //para = document.LastSection.AddParagraph(sub, "Heading2");
            //para.Format.Alignment = ParagraphAlignment.Center;
        }

        public static void DefineStyles(Document doc)
        {

            // main heading 
            Style style = doc.Styles["Normal"];
            style = doc.Styles["Heading1"];
            style.Font.Name = "Tahoma";
            style.Font.Size = 24;
            style.Font.Bold = true;
            style.Font.Color = Colors.DarkBlue;
            style.ParagraphFormat.PageBreakBefore = true;
            style.ParagraphFormat.SpaceAfter = 6;

            // sub heading
            style = doc.Styles["Heading2"];
            style.Font.Name = "Tahoma";
            style.Font.Size = 14;
            style.Font.Bold = true;
            style.Font.Color = Colors.DarkBlue;
            style.ParagraphFormat.PageBreakBefore = true;
            style.ParagraphFormat.SpaceAfter = 6;
        }

        private static void CreateTableBilling(Document doc,int col,List<History> userHistories)
        {
            Table table = new Table();
            table.Borders.Width = 1.00;

            Column column;
            for (int i = 0; i < col; i++)
            {
                column = table.AddColumn(Unit.FromCentimeter(2.5));
                column.Format.Alignment = ParagraphAlignment.Center;
            }

            Row addRow = table.AddRow();

            Cell cell = addRow.Cells[0];
            cell.AddParagraph("History Id");

            cell = addRow.Cells[1];
            cell.AddParagraph("User Id");

            cell = addRow.Cells[2];
            cell.AddParagraph("House Number");

            cell = addRow.Cells[3];
            cell.AddParagraph("Payment");

            cell = addRow.Cells[4];
            cell.AddParagraph("Received By");

            cell = addRow.Cells[5];
            cell.AddParagraph("Month");

            cell = addRow.Cells[6];
            cell.AddParagraph("Status");

            Row newRow;
            Cell newCell;
            int q = 0;

            var his = userHistories.ToArray();

            for(int i =0;i<userHistories.Count % 7; i++)
            {
                newRow = table.AddRow();
                for (int j = 0; j < userHistories.Count % 7;)
                {
                    newCell = newRow.Cells[j];
                    newCell.AddParagraph(userHistories[j].HistoryId.ToString());
                    newCell.AddParagraph(userHistories[j].UserId.ToString());

                    q++;
                }
                q = 0;
            }


            table.SetEdge(0, 0, 0, 0, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1.5, Colors.Black);

            doc.LastSection.Add(table);

        }



    }
}
