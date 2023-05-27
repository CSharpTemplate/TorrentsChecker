namespace CheckTorrent.Events
{
    internal class TextBoxEvents
    {
        private Form1? form { get; set; }
        private string To { get; set; }
        private string From { get; set; }
        public TextBoxEvents(Form1 form)
        {
            try
            {
                this.form = form;
                this.form.WhereFrom.TextChanged += WhereFromText;
                this.form.WhereTo.TextChanged += WhereToText;
            }catch(NullReferenceException ex)
            {
                MessageBox.Show("Попытка передать Null объект" , "Конструктор TextBox Component" ,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        /**
        * Изменяет состояние кнопки
        */
        public void UpdateButtonState()
        {
            try
            {
                form.Run.Enabled = !string.IsNullOrEmpty(form.WhereFrom.Text)
                                       && !string.IsNullOrEmpty(form.WhereTo.Text);
            }catch(NullReferenceException ex)
            {
                MessageBox.Show("Не полученна ссылка на форму Windows", "TextBoxEvent::UpdateButtonState()",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

         /**
         * Событие текстового поля для "Откуда"
         */
        private void WhereFromText(object sender, EventArgs e)
        {
            UpdateButtonState();
             this.From = form.WhereFrom.Text;
        }

        /**
         *  Событие текстового поля для "Куда"
         */
        private void WhereToText(object sender, EventArgs e)
        {
            UpdateButtonState();
            this.To = form.WhereTo.Text;
        }

    }
}
