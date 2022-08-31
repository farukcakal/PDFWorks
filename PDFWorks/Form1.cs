using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PDFWorks
{
    public partial class Form1 : Form
    {
        string FirstFile;
        string SecondFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFirstSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            FirstFile = openFileDialog1.FileName;
            lblFirstFile.Text = FirstFile;
        }

        private void btnSecondSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            SecondFile = openFileDialog1.FileName;
            lblSecondFile.Text = SecondFile;
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            string[] files = new string[2];
            files[0] = FirstFile;
            files[1] = SecondFile;
            MergePDFs(files);
        }
        public void MergePDFs(params string[] pdfs)
        {
            using (PdfDocument targetDoc = new PdfDocument())
            {
                foreach (string pdf in pdfs)
                {
                    using (PdfDocument pdfDoc = PdfReader.Open(pdf, PdfDocumentOpenMode.Import))
                    {
                        for (int i = 0; i < pdfDoc.PageCount; i++)
                        {
                            targetDoc.AddPage(pdfDoc.Pages[i]);
                        }
                    }
                }
                saveFileDialog1.ShowDialog();
                targetDoc.Save(saveFileDialog1.FileName);
            }
        }
    }
}
