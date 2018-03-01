

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace LogoPlacer
{
    /// <summary>
    ///     Klasa służaca nakładaniu logo na zdjęcia z wybranego folderu
    /// </summary>
    public class Logo
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="logoPath">Scieżka bezwzględna do logo</param>
        public Logo(string logoPath)
        {
            LogoPath = logoPath;
            DT = DateTime.Now;
        }

        private string LogoPath { get; set; }
        private DateTime DT { get; set; }

        /// <summary>
        /// Metoda dodająca logo na konkretne zdjęcie
        /// </summary>
        /// <param name="pathToPhoto">Bezwzględna ścieżka do zdjęcia  na które nakładamy logo</param>
        /// <param name="pathToSave">Scieżka do folderu gdzie zostanie zapisane zdjęcie z nałożonym logo</param>
        /// <returns>Zwraca scieżke bezwględną do zdjęcia z nałozonym logo</returns>
        public string AddLogo(string pathToPhoto, string pathToSave)
        {
            Console.WriteLine($"Przetwarzanie zdjęcia: {pathToPhoto}");
            var bg = Image.FromFile(pathToPhoto);
            var logoImage = Image.FromFile(LogoPath);
            var g = Graphics.FromImage(bg);

            g.DrawImage(logoImage, new Rectangle(new Point(0, 0), bg.Size));

            DT = DateTime.Now;
            var prefix = $"{DT.ToLocalTime()}";
            prefix = prefix.Replace(':', '-').Replace('.', '_').Replace(' ', '_');

            bg.Save($"{pathToSave}\\{prefix}-logo.jpg",
                ImageFormat.Jpeg);

            Console.WriteLine($"Pomyslanie dodano logo: {pathToSave}\\{prefix}-logo.jpg");

            bg.Dispose();
            logoImage.Dispose();
            g.Dispose();
            File.Delete(pathToPhoto);
            Console.WriteLine($"Usuwam oryginał: {pathToPhoto}");
            return $"{pathToSave}\\{prefix}-logo.jpg";
        }

        /// <summary>
        /// Metoda zwracająca scieżki do nieobrobionych zdjęć
        /// </summary>
        /// <param name="path">Scieżka do folderu ze zdjęciami</param>
        /// <returns>Zwraca IEnumerble ze scieżkami bezwzględnymi do zdjęc nie obrobionych przez program</returns>
        public IEnumerable<string> GetFiles(string path)
        {
            return Directory.GetFiles(path, "*.jpg").ToList().Where(x => x[x.Length - 5] != 'o');
        }


        public void SetLogoPath(string logoPath)
        {
            LogoPath = logoPath;
        }
    }
}