using CheckTorrent.Components;
using CheckTorrent.Events;
using CheckTorrent.Modules;

namespace CheckTorrent
{
    internal partial class Form1 : Form
    {
        private TextBoxEvents textEvents { get; set; }
        private ButtonEvents? btnEvents { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.btnEvents = new ButtonEvents(this);
            this.textEvents = new TextBoxEvents(this);
        }

        private void Seed_Click(object sender, EventArgs e)
        {

        }

        /*
         * Запрещает расстягивание формы
         */
        private void LoaderEvent(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimumSize = this.Size;
        }
    }
}