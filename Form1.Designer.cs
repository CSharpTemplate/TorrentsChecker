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
            groupBox1 = new GroupBox();
            Percent = new Label();
            Count = new Label();
            StatusLine = new Label();
            DetailGroup = new GroupBox();
            label3 = new Label();
            Detail = new RichTextBox();
            PathGroup = new GroupBox();
            Run = new Button();
            To = new Button();
            From = new Button();
            WhereTo = new TextBox();
            WhereFrom = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Status = new ProgressBar();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            DetailGroup.SuspendLayout();
            PathGroup.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Percent);
            groupBox1.Controls.Add(Count);
            groupBox1.Controls.Add(StatusLine);
            groupBox1.Controls.Add(DetailGroup);
            groupBox1.Controls.Add(PathGroup);
            groupBox1.Controls.Add(Status);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 531);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // Percent
            // 
            Percent.AutoSize = true;
            Percent.Location = new Point(428, 478);
            Percent.Name = "Percent";
            Percent.Size = new Size(84, 15);
            Percent.TabIndex = 6;
            Percent.Text = "Осталось: 0 %";
            // 
            // Count
            // 
            Count.AutoSize = true;
            Count.Location = new Point(9, 478);
            Count.Name = "Count";
            Count.Size = new Size(95, 15);
            Count.TabIndex = 5;
            Count.Text = "Всего файлов: 0";
            // 
            // StatusLine
            // 
            StatusLine.AutoSize = true;
            StatusLine.Location = new Point(224, 478);
            StatusLine.Name = "StatusLine";
            StatusLine.Size = new Size(94, 15);
            StatusLine.TabIndex = 4;
            StatusLine.Text = "Обработанно: 0";
            // 
            // DetailGroup
            // 
            DetailGroup.Controls.Add(label3);
            DetailGroup.Controls.Add(Detail);
            DetailGroup.Location = new Point(3, 180);
            DetailGroup.Name = "DetailGroup";
            DetailGroup.Size = new Size(527, 298);
            DetailGroup.TabIndex = 3;
            DetailGroup.TabStop = false;
            DetailGroup.Text = "Детали:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 461);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 1;
            label3.Text = "Файл:";
            // 
            // Detail
            // 
            Detail.BackColor = SystemColors.ScrollBar;
            Detail.BorderStyle = BorderStyle.None;
            Detail.Dock = DockStyle.Fill;
            Detail.Location = new Point(3, 19);
            Detail.Name = "Detail";
            Detail.ReadOnly = true;
            Detail.Size = new Size(521, 276);
            Detail.TabIndex = 0;
            Detail.Text = "";
            // 
            // PathGroup
            // 
            PathGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PathGroup.Controls.Add(Run);
            PathGroup.Controls.Add(To);
            PathGroup.Controls.Add(From);
            PathGroup.Controls.Add(WhereTo);
            PathGroup.Controls.Add(WhereFrom);
            PathGroup.Controls.Add(label2);
            PathGroup.Controls.Add(label1);
            PathGroup.Location = new Point(3, 19);
            PathGroup.Name = "PathGroup";
            PathGroup.Size = new Size(527, 165);
            PathGroup.TabIndex = 2;
            PathGroup.TabStop = false;
            PathGroup.Text = "Путь";
            // 
            // Run
            // 
            Run.AutoSize = true;
            Run.Enabled = false;
            Run.FlatStyle = FlatStyle.System;
            Run.Location = new Point(66, 102);
            Run.Name = "Run";
            Run.Size = new Size(351, 57);
            Run.TabIndex = 6;
            Run.Text = "Обработать файлы";
            Run.UseVisualStyleBackColor = true;
            // 
            // To
            // 
            To.FlatStyle = FlatStyle.System;
            To.Location = new Point(425, 73);
            To.Name = "To";
            To.Size = new Size(99, 23);
            To.TabIndex = 5;
            To.Text = "Обзор";
            To.UseVisualStyleBackColor = true;
            // 
            // From
            // 
            From.FlatStyle = FlatStyle.System;
            From.Location = new Point(425, 27);
            From.Name = "From";
            From.Size = new Size(99, 24);
            From.TabIndex = 4;
            From.Text = "Обзор";
            From.UseVisualStyleBackColor = true;
            // 
            // WhereTo
            // 
            WhereTo.BorderStyle = BorderStyle.FixedSingle;
            WhereTo.Enabled = false;
            WhereTo.Location = new Point(66, 73);
            WhereTo.Name = "WhereTo";
            WhereTo.Size = new Size(351, 23);
            WhereTo.TabIndex = 3;
            // 
            // WhereFrom
            // 
            WhereFrom.BorderStyle = BorderStyle.FixedSingle;
            WhereFrom.Enabled = false;
            WhereFrom.Location = new Point(66, 27);
            WhereFrom.Name = "WhereFrom";
            WhereFrom.Size = new Size(351, 23);
            WhereFrom.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 73);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Куда:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Откуда:";
            // 
            // Status
            // 
            Status.Dock = DockStyle.Bottom;
            Status.Enabled = false;
            Status.Location = new Point(3, 498);
            Status.Name = "Status";
            Status.Size = new Size(527, 30);
            Status.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 531);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check Torrent";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            DetailGroup.ResumeLayout(false);
            DetailGroup.PerformLayout();
            PathGroup.ResumeLayout(false);
            PathGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ProgressBar Status;
        private GroupBox PathGroup;
        private GroupBox DetailGroup;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label StatusLine;
        private Label Percent;
        private Label Count;
        public RichTextBox Detail;
        public Button Run;
        public Button To;
        public Button From;
        public TextBox WhereTo;
        public TextBox WhereFrom;
    }
}