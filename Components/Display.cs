using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void ClearText()
        {
            this.form.Detail.Text = " ";
        }
    }
}
