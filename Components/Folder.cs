using CheckTorrent.Interfaces;
using CheckTorrent.Modules;

namespace CheckTorrent.Components
{
    internal class Folder 
    {
        private FolderBrowserDialog dialog { get; set; } = new FolderBrowserDialog();
        private String? path { get; set; }
        public Folder(){}

        /**
         *  Получает путь 
         */
        public String getPath()
        {
            if (path != null )
            {
                return path;
            }
            return "Установи путь к директории!";
        }

        public void Show()
        {
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                this.path = dialog.SelectedPath;
            }
        }
    }
}
