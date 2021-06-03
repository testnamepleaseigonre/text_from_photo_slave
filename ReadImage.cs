using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace text_from_photo_slave
{
    public class ReadImage
    {
        public string ImageToText(string filepath)
        {
            var ENGLISH_LANGUAGE = @"eng";

            var blogPostImage = filepath;
            string finaltext = "";
            using (var ocrEngine = new TesseractEngine(@"\text_from_photo_slave\tessdata", ENGLISH_LANGUAGE, EngineMode.Default))
            {
                using (var imageWithText = Pix.LoadFromFile(blogPostImage))
                {
                    using (var page = ocrEngine.Process(imageWithText))
                    {
                        var text = page.GetText();
                        Console.WriteLine(text);
                        Console.ReadLine();

                        finaltext = text;

                    }
                }
            }
            return finaltext;
        }
        public void LoadImages(string folderpath)
        {
            List<string> allText = new List<string>();
            string imageText = "";
            foreach (string file in Directory.GetFiles(folderpath, "*", SearchOption.TopDirectoryOnly))
            {

                Console.WriteLine(file);
                //this.Invoke((Action)delegate // sitas sudas buvo kad prideti photo kuri ateina ir atvaizduoti teksta formoje
                //{
                //    pictureBox1.Image = Image.FromFile(file);
                //    imageText = ImageToText(file);
                //    ResultTextBox.Text = imageText;
                //    allText.Add(imageText);
                //});
                //break;

            }
            Console.WriteLine(folderpath);
        }
    }
}
