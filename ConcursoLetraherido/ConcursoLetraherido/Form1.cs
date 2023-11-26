using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf;
using System.Globalization;
using System.Text;

namespace ConcursoLetraherido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cPdf = carpetaPdf.Text;
            string cOk = carpetaOK.Text;
            string cKO = carpetaKO.Text;
            string cMaybe = carpetaMaybe.Text;
            string fileStats = carpetaStats.Text;
            string stats = "Nombre fichero;Palabras;Tiene frase;Título;Pseudónimo\n";
            checkFolder(cOk);
            checkFolder(cKO);
            checkFolder(cMaybe);
            if (Directory.Exists(cPdf))
            {
                // Obtener una matriz con la lista de archivos en la carpeta
                string[] archivos = Directory.GetFiles(cPdf);

                // Recorremos la lista de archivos e imprimimos sus nombres
                foreach (string archivo in archivos)
                {
                    string fileoriginal = Path.GetFileName(archivo);
                    string filename = fileoriginal.Substring(0,fileoriginal.LastIndexOf(" - "))+".pdf";
                    (int res, int palabras) = checkPdf(archivo);
                    string frase = "No";
                    if (res < 0)
                    {
                        File.Move(archivo, Path.Combine(cKO, filename));
                    }
                    else if (res > 0)
                    {
                        File.Move(archivo, Path.Combine(cOk, filename));
                        frase = "Sí";
                    }
                    else
                    {
                        File.Move(archivo, Path.Combine(cMaybe, filename));
                        frase = "Quizás";
                    }
                    string[] partes = filename.Replace(".pdf", "").Split("_");
                    stats += filename + ";" + palabras + ";" + frase + ";" + partes.ElementAtOrDefault(0) + ";" + partes.ElementAtOrDefault(1) + "\n";
                }
                Encoding encoding = Encoding.GetEncoding("iso-8859-1");

                using (StreamWriter writer = new StreamWriter(fileStats,false,encoding))
                {
                    // Escribimos el contenido en el archivo
                    writer.WriteLine(stats);
                }
            }
            else
            {
                MessageBox.Show("La carpeta no existe");
            }
        }
        private void checkFolder(string carpeta)
        {
            if (!Directory.Exists(carpeta))
            {
                // La carpeta no existe, así que la creamos
                Directory.CreateDirectory(carpeta);
            }
        }
        private (int, int) checkPdf(string ruta)
        {
            string texto = getTexto(ruta);
            string[] palabras = texto.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int max = int.Parse(maxPalabras.Text);
            string frase = RemoverAcentos(fraseBuscar.Text);
            if (palabras.Length > max + 4)
            {
                return (-1, palabras.Length);
            }
            if (texto.IndexOf(frase) >= 0 || texto.IndexOf(frase.Replace(" ", "")) >= 0)
            {
                return (1, palabras.Length);
            }
            string[] palabrasFrase = frase.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string palabra in palabrasFrase)
            {
                if (texto.IndexOf(palabra) < 0)
                {
                    return (-2, palabras.Length);
                }
            }

            return (0, palabras.Length);
        }
        private string getTexto(string ruta)
        {
            string textoPDF = "";
            using (PdfDocument pdfDoc = new PdfDocument(new PdfReader(ruta)))
            {

                for (int pagina = 1; pagina <= pdfDoc.GetNumberOfPages(); pagina++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string textoPagina = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(pagina), strategy);
                    textoPDF += textoPagina;
                }
                textoPDF = normalizar(textoPDF);
            }
            return textoPDF;
        }
        private string normalizar(string texto)
        {
            texto = texto.Replace("\r\n", " ");
            texto = texto.Replace("\n", " ");
            while (texto.IndexOf("  ") > 0)
            {
                texto = texto.Replace("  ", " ");
            }
            return RemoverAcentos(texto.ToLower());
        }
        private string RemoverAcentos(string input)
        {
            string normalizedString = input.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}