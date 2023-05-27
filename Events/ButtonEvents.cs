using CheckTorrent.Components;
using CheckTorrent.Modules;
namespace CheckTorrent.Events
{
    internal class ButtonEvents
    {
        private Form1 form { get; set; }
        private Folder folder {get; set; }
        private DirectoryOperation operation { get; set;} = new DirectoryOperation();
        public ButtonEvents(Form1 buttons)
        {
            if (buttons != null )
            {
                this.form = buttons;
                this.form.From.Click += From_Click;
                this.form.To.Click   += To_Click;
                this.form.Run.Click  += Run_Click;
                this.folder = new Folder();
            }
        }

        /*
         * Изменяет значение текстового поля для исходной директории
         */
        private void From_Click(object sender, EventArgs e)
        {
            folder.Show();
            form.WhereFrom.Text = folder.getPath();
        }

        /**
        * Изменяет значение текстового поля для 
        * директории в которую пишем изменения
        */
        private void To_Click(object sender, EventArgs e)
        {
            folder.Show();
            form.WhereTo.Text = folder.getPath();
        }

        /**
         * Событие которое запускает обработку файлов
         */
        private void Run_Click(object sender , EventArgs e)
        {
            this.operation = new DirectoryOperation(this.form,form.WhereFrom.Text, form.WhereTo.Text);
                 operation.Load();
                 operation.Dir();
        }
    }
}
