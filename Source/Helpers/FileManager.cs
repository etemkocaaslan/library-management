using System.Configuration;

namespace LibraryManagement.Source.Helpers
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
            if (IsFileDialogSuccessful())
            {
                return LoadImageFromFile();
            }
            return null;
        }

        private static bool IsFileDialogSuccessful()
        {
            return openImageFileDialog.ShowDialog() == DialogResult.OK;
        }

        private static Bitmap LoadImageFromFile()
        {
            return new Bitmap(openImageFileDialog.FileName);
        }

    }
}
