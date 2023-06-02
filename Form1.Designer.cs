namespace CheckTorrent
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainPanel = new GroupBox();
            Statusbar = new GroupBox();
            Count = new Label();
            Peer = new Label();
            Filename = new Label();
            Seed = new Label();
            Status = new ProgressBar();
            DetailGroup = new GroupBox();
            Detail = new RichTextBox();
            PathGroup = new GroupBox();
            WhereFrom = new TextBox();
            Run = new Button();
            To = new Button();
            From = new Button();
            WhereTo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьЛогToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            правкаToolStripMenuItem = new ToolStripMenuItem();
            настройкиОкнаToolStripMenuItem = new ToolStripMenuItem();
            настройкиЯзыкаToolStripMenuItem = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            настройкаПроксиToolStripMenuItem = new ToolStripMenuItem();
            настройкиПрограммыToolStripMenuItem = new ToolStripMenuItem();
            окноToolStripMenuItem = new ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            обоМнеToolStripMenuItem = new ToolStripMenuItem();
            MainPanel.SuspendLayout();
            Statusbar.SuspendLayout();
            DetailGroup.SuspendLayout();
            PathGroup.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.Window;
            MainPanel.Controls.Add(Statusbar);
            MainPanel.Controls.Add(DetailGroup);
            MainPanel.Controls.Add(PathGroup);
            MainPanel.Location = new Point(1, 31);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(597, 535);
            MainPanel.TabIndex = 0;
            MainPanel.TabStop = false;
            // 
            // Statusbar
            // 
            Statusbar.BackColor = SystemColors.Menu;
            Statusbar.Controls.Add(Count);
            Statusbar.Controls.Add(Peer);
            Statusbar.Controls.Add(Filename);
            Statusbar.Controls.Add(Seed);
            Statusbar.Controls.Add(Status);
            Statusbar.Dock = DockStyle.Bottom;
            Statusbar.Location = new Point(3, 453);
            Statusbar.Name = "Statusbar";
            Statusbar.Size = new Size(591, 79);
            Statusbar.TabIndex = 4;
            Statusbar.TabStop = false;
            Statusbar.Text = "Статус бар:";
            // 
            // Count
            // 
            Count.AutoSize = true;
            Count.Location = new Point(456, 19);
            Count.Name = "Count";
            Count.Size = new Size(95, 15);
            Count.TabIndex = 10;
            Count.Text = "Всего файлов: 0";
            // 
            // Peer
            // 
            Peer.AutoSize = true;
            Peer.Location = new Point(301, 19);
            Peer.Name = "Peer";
            Peer.Size = new Size(88, 15);
            Peer.TabIndex = 9;
            Peer.Text = "Отдача: 0 КБ/С";
            // 
            // Filename
            // 
            Filename.AutoSize = true;
            Filename.Location = new Point(9, 19);
            Filename.Name = "Filename";
            Filename.Size = new Size(39, 15);
            Filename.TabIndex = 1;
            Filename.Text = "Файл:";
            // 
            // Seed
            // 
            Seed.AutoSize = true;
            Seed.Location = new Point(126, 19);
            Seed.Name = "Seed";
            Seed.Size = new Size(95, 15);
            Seed.TabIndex = 8;
            Seed.Text = "Загрузка: 0 КБ/с";
            // 
            // Status
            // 
            Status.BackColor = SystemColors.Window;
            Status.Dock = DockStyle.Bottom;
            Status.Enabled = false;
            Status.Location = new Point(3, 46);
            Status.Name = "Status";
            Status.Size = new Size(585, 30);
            Status.TabIndex = 7;
            // 
            // DetailGroup
            // 
            DetailGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DetailGroup.BackColor = SystemColors.Window;
            DetailGroup.Controls.Add(Detail);
            DetailGroup.Location = new Point(3, 199);
            DetailGroup.Name = "DetailGroup";
            DetailGroup.Size = new Size(588, 248);
            DetailGroup.TabIndex = 3;
            DetailGroup.TabStop = false;
            DetailGroup.Text = "Детали:";
            // 
            // Detail
            // 
            Detail.BackColor = SystemColors.ScrollBar;
            Detail.BorderStyle = BorderStyle.None;
            Detail.Dock = DockStyle.Fill;
            Detail.Location = new Point(3, 19);
            Detail.Name = "Detail";
            Detail.ReadOnly = true;
            Detail.Size = new Size(582, 226);
            Detail.TabIndex = 0;
            Detail.Text = "";
            // 
            // PathGroup
            // 
            PathGroup.Anchor = AnchorStyles.None;
            PathGroup.BackColor = SystemColors.Menu;
            PathGroup.Controls.Add(WhereFrom);
            PathGroup.Controls.Add(Run);
            PathGroup.Controls.Add(To);
            PathGroup.Controls.Add(From);
            PathGroup.Controls.Add(WhereTo);
            PathGroup.Controls.Add(label2);
            PathGroup.Controls.Add(label1);
            PathGroup.Location = new Point(3, 18);
            PathGroup.Name = "PathGroup";
            PathGroup.Size = new Size(591, 175);
            PathGroup.TabIndex = 2;
            PathGroup.TabStop = false;
            PathGroup.Text = "Путь";
            // 
            // WhereFrom
            // 
            WhereFrom.Location = new Point(101, 24);
            WhereFrom.Name = "WhereFrom";
            WhereFrom.ReadOnly = true;
            WhereFrom.Size = new Size(323, 23);
            WhereFrom.TabIndex = 7;
            // 
            // Run
            // 
            Run.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Run.AutoSize = true;
            Run.Enabled = false;
            Run.FlatStyle = FlatStyle.System;
            Run.Location = new Point(101, 93);
            Run.Name = "Run";
            Run.Size = new Size(323, 65);
            Run.TabIndex = 6;
            Run.Text = "Обработать файлы";
            Run.UseVisualStyleBackColor = true;
            // 
            // To
            // 
            To.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            To.FlatStyle = FlatStyle.System;
            To.Location = new Point(450, 64);
            To.Name = "To";
            To.Size = new Size(82, 23);
            To.TabIndex = 5;
            To.Text = "Обзор";
            To.UseVisualStyleBackColor = true;
            // 
            // From
            // 
            From.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            From.FlatStyle = FlatStyle.System;
            From.Location = new Point(450, 23);
            From.Name = "From";
            From.Size = new Size(82, 24);
            From.TabIndex = 4;
            From.Text = "Обзор";
            From.UseVisualStyleBackColor = true;
            // 
            // WhereTo
            // 
            WhereTo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WhereTo.BorderStyle = BorderStyle.FixedSingle;
            WhereTo.Enabled = false;
            WhereTo.Location = new Point(101, 64);
            WhereTo.Name = "WhereTo";
            WhereTo.ReadOnly = true;
            WhereTo.Size = new Size(323, 23);
            WhereTo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 68);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Куда:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 27);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Откуда:";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, правкаToolStripMenuItem, настройкиToolStripMenuItem, окноToolStripMenuItem, обоМнеToolStripMenuItem });
            menuStrip1.Location = new Point(4, 4);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(289, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьЛогToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьЛогToolStripMenuItem
            // 
            открытьЛогToolStripMenuItem.Name = "открытьЛогToolStripMenuItem";
            открытьЛогToolStripMenuItem.Size = new Size(180, 22);
            открытьЛогToolStripMenuItem.Text = "Сохранить лог";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(180, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // правкаToolStripMenuItem
            // 
            правкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { настройкиОкнаToolStripMenuItem, настройкиЯзыкаToolStripMenuItem });
            правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            правкаToolStripMenuItem.Size = new Size(39, 20);
            правкаToolStripMenuItem.Text = "Вид";
            // 
            // настройкиОкнаToolStripMenuItem
            // 
            настройкиОкнаToolStripMenuItem.Name = "настройкиОкнаToolStripMenuItem";
            настройкиОкнаToolStripMenuItem.Size = new Size(163, 22);
            настройкиОкнаToolStripMenuItem.Text = "Настройки окна";
            // 
            // настройкиЯзыкаToolStripMenuItem
            // 
            настройкиЯзыкаToolStripMenuItem.Name = "настройкиЯзыкаToolStripMenuItem";
            настройкиЯзыкаToolStripMenuItem.Size = new Size(163, 22);
            настройкиЯзыкаToolStripMenuItem.Text = "Темы";
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { настройкаПроксиToolStripMenuItem, настройкиПрограммыToolStripMenuItem });
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(79, 20);
            настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // настройкаПроксиToolStripMenuItem
            // 
            настройкаПроксиToolStripMenuItem.Name = "настройкаПроксиToolStripMenuItem";
            настройкаПроксиToolStripMenuItem.Size = new Size(203, 22);
            настройкаПроксиToolStripMenuItem.Text = "Настройка прокси";
            // 
            // настройкиПрограммыToolStripMenuItem
            // 
            настройкиПрограммыToolStripMenuItem.Name = "настройкиПрограммыToolStripMenuItem";
            настройкиПрограммыToolStripMenuItem.Size = new Size(203, 22);
            настройкиПрограммыToolStripMenuItem.Text = "Настройки программы";
            // 
            // окноToolStripMenuItem
            // 
            окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            окноToolStripMenuItem.Size = new Size(48, 20);
            окноToolStripMenuItem.Text = "Окно";
            // 
            // обоМнеToolStripMenuItem
            // 
            обоМнеToolStripMenuItem.Name = "обоМнеToolStripMenuItem";
            обоМнеToolStripMenuItem.Size = new Size(67, 20);
            обоМнеToolStripMenuItem.Text = "Обо мне";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 578);
            Controls.Add(MainPanel);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check Torrent";
            Load += LoaderEvent;
            MainPanel.ResumeLayout(false);
            Statusbar.ResumeLayout(false);
            Statusbar.PerformLayout();
            DetailGroup.ResumeLayout(false);
            PathGroup.ResumeLayout(false);
            PathGroup.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox MainPanel;
        private GroupBox PathGroup;
        private GroupBox DetailGroup;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private Label label1;
        private Label Filename;
        public RichTextBox Detail;
        public Button Run;
        public Button To;
        public Button From;
        public TextBox WhereTo;
        private GroupBox Statusbar;
        private ProgressBar Status;
        private Label Peer;
        private Label Seed;
        private Label Count;
        public TextBox WhereFrom;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem окноToolStripMenuItem;
        private ToolStripMenuItem открытьЛогToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem настройкиОкнаToolStripMenuItem;
        private ToolStripMenuItem настройкиЯзыкаToolStripMenuItem;
        private ToolStripMenuItem настройкаПроксиToolStripMenuItem;
        private ToolStripMenuItem настройкиПрограммыToolStripMenuItem;
        private ToolStripMenuItem обоМнеToolStripMenuItem;
    }
}