using System.Configuration;

namespace WinFormsApp2
{
    internal static class FileManager
    {
        private static readonly string? image_path = ConfigurationManager.AppSettings["ImagePath"];
        private static readonly OpenFileDialog openImageFileDialog = new()
        {
            Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp",
            InitialDirectory = image_path,
            FileName = ""
        };

        public static Bitmap? GetImage()
        {
            return (openImageFileDialog.ShowDialog() == DialogResult.OK) ? new Bitmap(openImageFileDialog.FileName) : null;
        }
    }
}
