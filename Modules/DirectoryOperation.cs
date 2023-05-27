using CheckTorrent.Components;
using CheckTorrent.Interfaces;
namespace CheckTorrent.Modules
{
    internal class DirectoryOperation : IOperations
    {
        private Display? display { get; set; }
        public string? From { get; set; }
        public string? To   { get; set; }
        public Queue<string>? files { get; set; }
        public DirectoryOperation() { }
        public DirectoryOperation(Form1 form ,string from , string to)
        {
            this.display = new Display(form);
            this.From = from;
            To = to;
        }
        public void Dir()
        {
            foreach(string item in files)
            {
                display.SetText(item + "\n");
            }
        }
        public void Create(string name)
        {
           try
           {
               Directory.CreateDirectory(To + "/" + name);
           }catch(UnauthorizedAccessException ex)
           {
               MessageBox.Show("Для создания директории необходимы права администратора!",
                               "Нет прав",MessageBoxButtons.OK,MessageBoxIcon.Stop);
           }catch(NullReferenceException ex)
           {
                MessageBox.Show("Передача Null объектов недопустима",
                                "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
           }
        }    

        public void Delete()
        {
            try
            {

            }catch(UnauthorizedAccessException ex)
            {
                MessageBox.Show("Для удаления необходимы права администратора!",
                               "Нет прав на запись", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void CopyTo(string from, string to)
        {
            try
            {
                
            }catch(UnauthorizedAccessException ex ){
                MessageBox.Show("Для копирования файлов необходимы права администратора!",
                               "Нет прав на копирование", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void MoveTo(string from, string to)
        {
            try
            {

            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Для получения файлов необходимы права администратора!",
                               "Нет прав на запись", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            throw new NotImplementedException();
        }

        public void Load()
        {
            try
            {
                Directory.SetCurrentDirectory(From);
                  string[] filename = Directory.GetFiles(From, "*.*", SearchOption.AllDirectories);
                files = new Queue<string>();
                foreach (string file in filename)
                {
                    files.Enqueue(file);
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Передача Null объектов недопустима",
                               "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Запрашиваемая директория не найдена",
                                "Отсутствует директория", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch(UnauthorizedAccessException ex)
            {
                MessageBox.Show("Для чтения файлов необходимы права администратора!",
                                "Нет прав доступа", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch(System.ArgumentNullException ex)
            {
                MessageBox.Show("Одно из свойств DirectoryOperations не получило значения ",
                                "Неинициализированное свойство", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
