using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCoreProject.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosyapdf.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();

            Paragraph paragraf = new Paragraph("Traversal Rezervasyon Pdf Raporu");
            document.Add(paragraf);
            document.Close();
            return File("/PdfReports/dosyapdf.pdf", "application/pdf", "dosyapdf.pdf");

        }

        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosyapdf2.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();


            PdfPTable pdfTable = new PdfPTable(3);
            pdfTable.AddCell("Misafir Adı");
            pdfTable.AddCell("Misafir Soyadı");
            pdfTable.AddCell("Misafir Tc");
            pdfTable.AddCell("Aysenur");
            pdfTable.AddCell("Balkan");
            pdfTable.AddCell("1111111111");
            document.Add(pdfTable);
            document.Close();
            return File("/PdfReports/dosyapdf2.pdf", "application/pdf", "dosyapdf2.pdf");

        }
    }
}
