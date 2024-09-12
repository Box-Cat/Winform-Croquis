namespace Croquis
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
            components = new System.ComponentModel.Container();
            tableLayoutPanelForm = new TableLayoutPanel();
            tableLayoutPanelPicBox = new TableLayoutPanel();
            panelPicBox = new Panel();
            picBox = new PictureBox();
            tableLayoutPanelLeftBtn = new TableLayoutPanel();
            btnLeft = new Button();
            panelCheckBox = new Panel();
            label3 = new Label();
            checkBoxSize = new CheckBox();
            tableLayoutPanelRightBtn = new TableLayoutPanel();
            btnRight = new Button();
            tableLayoutPanelBtns = new TableLayoutPanel();
            panelTimer = new Panel();
            label2 = new Label();
            label1 = new Label();
            textBoxSec = new TextBox();
            textBoxMin = new TextBox();
            textBoxHour = new TextBox();
            panelStartBtn = new Panel();
            btnStart = new Button();
            panelPause = new Panel();
            btnPause = new Button();
            panelStop = new Panel();
            btnStop = new Button();
            menuStrip = new MenuStrip();
            loadToolStripMenuItem = new ToolStripMenuItem();
            timer = new System.Windows.Forms.Timer(components);
            tableLayoutPanelForm.SuspendLayout();
            tableLayoutPanelPicBox.SuspendLayout();
            panelPicBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            tableLayoutPanelLeftBtn.SuspendLayout();
            panelCheckBox.SuspendLayout();
            tableLayoutPanelRightBtn.SuspendLayout();
            tableLayoutPanelBtns.SuspendLayout();
            panelTimer.SuspendLayout();
            panelStartBtn.SuspendLayout();
            panelPause.SuspendLayout();
            panelStop.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelForm
            // 
            tableLayoutPanelForm.ColumnCount = 1;
            tableLayoutPanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelForm.Controls.Add(tableLayoutPanelPicBox, 0, 0);
            tableLayoutPanelForm.Controls.Add(tableLayoutPanelBtns, 0, 1);
            tableLayoutPanelForm.Dock = DockStyle.Fill;
            tableLayoutPanelForm.Location = new Point(0, 24);
            tableLayoutPanelForm.Name = "tableLayoutPanelForm";
            tableLayoutPanelForm.RowCount = 2;
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelForm.Size = new Size(800, 426);
            tableLayoutPanelForm.TabIndex = 0;
            // 
            // tableLayoutPanelPicBox
            // 
            tableLayoutPanelPicBox.ColumnCount = 3;
            tableLayoutPanelPicBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanelPicBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelPicBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanelPicBox.Controls.Add(panelPicBox, 1, 0);
            tableLayoutPanelPicBox.Controls.Add(tableLayoutPanelLeftBtn, 0, 0);
            tableLayoutPanelPicBox.Controls.Add(tableLayoutPanelRightBtn, 2, 0);
            tableLayoutPanelPicBox.Dock = DockStyle.Fill;
            tableLayoutPanelPicBox.Location = new Point(3, 3);
            tableLayoutPanelPicBox.Name = "tableLayoutPanelPicBox";
            tableLayoutPanelPicBox.RowCount = 1;
            tableLayoutPanelPicBox.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelPicBox.Size = new Size(794, 377);
            tableLayoutPanelPicBox.TabIndex = 0;
            // 
            // panelPicBox
            // 
            panelPicBox.Controls.Add(picBox);
            panelPicBox.Dock = DockStyle.Fill;
            panelPicBox.Location = new Point(53, 3);
            panelPicBox.Name = "panelPicBox";
            panelPicBox.Size = new Size(688, 371);
            panelPicBox.TabIndex = 2;
            // 
            // picBox
            // 
            picBox.Dock = DockStyle.Fill;
            picBox.Location = new Point(0, 0);
            picBox.Name = "picBox";
            picBox.Size = new Size(688, 371);
            picBox.TabIndex = 0;
            picBox.TabStop = false;
            // 
            // tableLayoutPanelLeftBtn
            // 
            tableLayoutPanelLeftBtn.ColumnCount = 1;
            tableLayoutPanelLeftBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelLeftBtn.Controls.Add(btnLeft, 0, 1);
            tableLayoutPanelLeftBtn.Controls.Add(panelCheckBox, 0, 0);
            tableLayoutPanelLeftBtn.Dock = DockStyle.Fill;
            tableLayoutPanelLeftBtn.Location = new Point(3, 3);
            tableLayoutPanelLeftBtn.Name = "tableLayoutPanelLeftBtn";
            tableLayoutPanelLeftBtn.RowCount = 3;
            tableLayoutPanelLeftBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 46.6666679F));
            tableLayoutPanelLeftBtn.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelLeftBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 53.3333359F));
            tableLayoutPanelLeftBtn.Size = new Size(44, 371);
            tableLayoutPanelLeftBtn.TabIndex = 3;
            // 
            // btnLeft
            // 
            btnLeft.Dock = DockStyle.Fill;
            btnLeft.Location = new Point(3, 152);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(38, 44);
            btnLeft.TabIndex = 0;
            btnLeft.Text = "◀";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // panelCheckBox
            // 
            panelCheckBox.Controls.Add(label3);
            panelCheckBox.Controls.Add(checkBoxSize);
            panelCheckBox.Dock = DockStyle.Fill;
            panelCheckBox.Location = new Point(3, 3);
            panelCheckBox.Name = "panelCheckBox";
            panelCheckBox.Size = new Size(38, 143);
            panelCheckBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 44);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 1;
            label3.Text = "大/小";
            // 
            // checkBoxSize
            // 
            checkBoxSize.AutoSize = true;
            checkBoxSize.Location = new Point(12, 71);
            checkBoxSize.Name = "checkBoxSize";
            checkBoxSize.Size = new Size(15, 14);
            checkBoxSize.TabIndex = 0;
            checkBoxSize.UseVisualStyleBackColor = true;
            checkBoxSize.CheckedChanged += checkBoxSize_CheckedChanged;
            // 
            // tableLayoutPanelRightBtn
            // 
            tableLayoutPanelRightBtn.ColumnCount = 1;
            tableLayoutPanelRightBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelRightBtn.Controls.Add(btnRight, 0, 1);
            tableLayoutPanelRightBtn.Dock = DockStyle.Fill;
            tableLayoutPanelRightBtn.Location = new Point(747, 3);
            tableLayoutPanelRightBtn.Name = "tableLayoutPanelRightBtn";
            tableLayoutPanelRightBtn.RowCount = 3;
            tableLayoutPanelRightBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelRightBtn.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelRightBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelRightBtn.Size = new Size(44, 371);
            tableLayoutPanelRightBtn.TabIndex = 4;
            // 
            // btnRight
            // 
            btnRight.Dock = DockStyle.Fill;
            btnRight.Location = new Point(3, 163);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(38, 44);
            btnRight.TabIndex = 0;
            btnRight.Text = "▶";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // tableLayoutPanelBtns
            // 
            tableLayoutPanelBtns.ColumnCount = 4;
            tableLayoutPanelBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanelBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelBtns.Controls.Add(panelTimer, 0, 0);
            tableLayoutPanelBtns.Controls.Add(panelStartBtn, 1, 0);
            tableLayoutPanelBtns.Controls.Add(panelPause, 2, 0);
            tableLayoutPanelBtns.Controls.Add(panelStop, 3, 0);
            tableLayoutPanelBtns.Dock = DockStyle.Fill;
            tableLayoutPanelBtns.Location = new Point(3, 386);
            tableLayoutPanelBtns.Name = "tableLayoutPanelBtns";
            tableLayoutPanelBtns.RowCount = 1;
            tableLayoutPanelBtns.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelBtns.Size = new Size(794, 37);
            tableLayoutPanelBtns.TabIndex = 1;
            // 
            // panelTimer
            // 
            panelTimer.Controls.Add(label2);
            panelTimer.Controls.Add(label1);
            panelTimer.Controls.Add(textBoxSec);
            panelTimer.Controls.Add(textBoxMin);
            panelTimer.Controls.Add(textBoxHour);
            panelTimer.Dock = DockStyle.Fill;
            panelTimer.Location = new Point(3, 3);
            panelTimer.Name = "panelTimer";
            panelTimer.Size = new Size(144, 31);
            panelTimer.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 9);
            label2.Name = "label2";
            label2.Size = new Size(10, 15);
            label2.TabIndex = 1;
            label2.Text = ":";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 9);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 1;
            label1.Text = ":";
            // 
            // textBoxSec
            // 
            textBoxSec.Location = new Point(104, 4);
            textBoxSec.Name = "textBoxSec";
            textBoxSec.Size = new Size(23, 23);
            textBoxSec.TabIndex = 0;
            textBoxSec.Text = "0";
            textBoxSec.KeyPress += textBoxSec_KeyPress;
            // 
            // textBoxMin
            // 
            textBoxMin.Location = new Point(60, 4);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.Size = new Size(23, 23);
            textBoxMin.TabIndex = 0;
            textBoxMin.Text = "0";
            textBoxMin.KeyPress += textBoxMin_KeyPress;
            // 
            // textBoxHour
            // 
            textBoxHour.Location = new Point(16, 4);
            textBoxHour.Name = "textBoxHour";
            textBoxHour.Size = new Size(23, 23);
            textBoxHour.TabIndex = 0;
            textBoxHour.Text = "0";
            textBoxHour.KeyPress += textBoxHour_KeyPress;
            // 
            // panelStartBtn
            // 
            panelStartBtn.Controls.Add(btnStart);
            panelStartBtn.Dock = DockStyle.Fill;
            panelStartBtn.Location = new Point(153, 3);
            panelStartBtn.Name = "panelStartBtn";
            panelStartBtn.Size = new Size(208, 31);
            panelStartBtn.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Fill;
            btnStart.Location = new Point(0, 0);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(208, 31);
            btnStart.TabIndex = 0;
            btnStart.Text = "▶";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // panelPause
            // 
            panelPause.Controls.Add(btnPause);
            panelPause.Dock = DockStyle.Fill;
            panelPause.Location = new Point(367, 3);
            panelPause.Name = "panelPause";
            panelPause.Size = new Size(208, 31);
            panelPause.TabIndex = 2;
            // 
            // btnPause
            // 
            btnPause.Dock = DockStyle.Fill;
            btnPause.Location = new Point(0, 0);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(208, 31);
            btnPause.TabIndex = 0;
            btnPause.Text = "❚❚";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // panelStop
            // 
            panelStop.Controls.Add(btnStop);
            panelStop.Dock = DockStyle.Fill;
            panelStop.Location = new Point(581, 3);
            panelStop.Name = "panelStop";
            panelStop.Size = new Size(210, 31);
            panelStop.TabIndex = 3;
            // 
            // btnStop
            // 
            btnStop.Dock = DockStyle.Fill;
            btnStop.Location = new Point(0, 0);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(210, 31);
            btnStop.TabIndex = 0;
            btnStop.Text = "■";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { loadToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            loadToolStripMenuItem.Size = new Size(45, 20);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanelForm);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Form1";
            SizeChanged += Form1_SizeChanged;
            tableLayoutPanelForm.ResumeLayout(false);
            tableLayoutPanelPicBox.ResumeLayout(false);
            panelPicBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            tableLayoutPanelLeftBtn.ResumeLayout(false);
            panelCheckBox.ResumeLayout(false);
            panelCheckBox.PerformLayout();
            tableLayoutPanelRightBtn.ResumeLayout(false);
            tableLayoutPanelBtns.ResumeLayout(false);
            panelTimer.ResumeLayout(false);
            panelTimer.PerformLayout();
            panelStartBtn.ResumeLayout(false);
            panelPause.ResumeLayout(false);
            panelStop.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelForm;
        private MenuStrip menuStrip;
        private ToolStripMenuItem loadToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanelPicBox;
        private TableLayoutPanel tableLayoutPanelBtns;
        private Panel panelTimer;
        private Panel panelStartBtn;
        private Panel panelPause;
        private Panel panelStop;
        private Panel panelPicBox;
        private TableLayoutPanel tableLayoutPanelLeftBtn;
        private Button btnLeft;
        private TableLayoutPanel tableLayoutPanelRightBtn;
        private Button btnRight;
        private PictureBox picBox;
        private Button btnStart;
        private Button btnPause;
        private Button btnStop;
        private TextBox textBoxHour;
        private TextBox textBoxSec;
        private TextBox textBoxMin;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer;
        private Panel panelCheckBox;
        private CheckBox checkBoxSize;
        private Label label3;
    }
}
