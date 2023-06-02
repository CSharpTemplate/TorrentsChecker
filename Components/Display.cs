using CheckTorrent.Interfaces;
using System.CodeDom;
using static System.Net.Mime.MediaTypeNames;

namespace CheckTorrent.Components
{
    internal class Display
    {
        public Form1 form { get; set; }
        public Display(Form1 form)
        {
            this.form = form;
        }

        public void SetText(string text)
        {
            try
            {
                this.form.Detail.AppendText(text);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Попытка передать в дисплей значение null", "Display component",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GetText()
        {
            return form.Detail.Text;
        }

        public void ClearText()
        {
            form.Detail.Clear();
        }
    }
}
