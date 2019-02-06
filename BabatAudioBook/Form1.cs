using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabatAudioBook
{
    public partial class Form1 : Form
    {
        public string Filename { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void listView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void listView_DragDrop(object sender, DragEventArgs e)
        {
            listView.Items.Add(e.Data.ToString());
            var data = e.Data.GetData(DataFormats.FileDrop, false) as string[];
            Filename = data[0];

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PdfReader pdfReader = new PdfReader(Filename);
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < pdfReader.NumberOfPages ; i++)
            {
                sb.Append(PdfTextExtractor.GetTextFromPage(pdfReader, i));
            }

            var a = new SpeechSynthesizer();
            a.SelectVoiceByHints(VoiceGender.Neutral);
            a.Speak(sb.ToString());
            
            pdfReader.Close();
        }
    }
}
