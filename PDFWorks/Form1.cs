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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PDFWorks
{
    public partial class Form1 : Form
    {
        List<string> Files = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FilesMessage = "";
                foreach (string File in openFileDialog1.FileNames)
                {
                    Files.Add(File);
                    FilesMessage += File + "\n";
                }
                MessageBox.Show("Seçilen dosyalar: \n"+FilesMessage);
            }
            else
            {
                MessageBox.Show("Dosya seçim işlemi kullanıcı tarafından iptal edildi.");
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            MergePDFs(Files);
        }
        public void MergePDFs(List<string> PDFs)
        {
            try
            {
                using (PdfDocument targetDoc = new PdfDocument())
                {
                    foreach (string pdf in PDFs)
                    {
                        using (PdfDocument pdfDoc = PdfReader.Open(pdf, PdfDocumentOpenMode.Import))
                        {
                            for (int i = 0; i < pdfDoc.PageCount; i++)
                            {
                                targetDoc.AddPage(pdfDoc.Pages[i]);
                            }
                        }
                    }
                    saveFileDialog1.Filter = "PDF document (*.pdf)|*.pdf";
                    if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        targetDoc.Save(saveFileDialog1.FileName);
                        MessageBox.Show("Başarıyla kaydedildi. Dosya yolu: " + saveFileDialog1.FileName);
                        lblSelectedFiles.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("PDF ler birleştirildi fakat kaydetme işlemi kullanıcı tarafından iptal edildi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex);
            }
            
        }
    }
}
