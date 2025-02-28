﻿using System;
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
        private Iupdatable updatable;
        public ReadImage(Iupdatable updatable)
        {
            this.updatable = updatable;
        }
        public string ImageToText(string filepath, string filename)
        {
            var ENGLISH_LANGUAGE = @"eng";

            var blogPostImage = filepath;
            string finaltext = "";
            // sito netrink:
            // tavo: C:\Users\valde\source\repos\text_from_photo_slave\tessdata
            // mano: C:\Users\domin\source\repos\text_from_photo_slave\tessdata
            using (var ocrEngine = new TesseractEngine(@"C:\Users\valde\source\repos\text_from_photo_slave\tessdata", ENGLISH_LANGUAGE, EngineMode.Default))
            {
                using (var imageWithText = Pix.LoadFromFile(blogPostImage))
                {
                    using (var page = ocrEngine.Process(imageWithText))
                    {
                        var text = page.GetText();
                        Console.WriteLine(text);
                        updatable.displayText(text,filepath+filename);
                        Console.ReadLine();

                        finaltext = text;
                        using (StreamWriter writer = new StreamWriter(filepath+".txt"))
                        {
                            writer.WriteLine(finaltext);
                            
                        }

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
