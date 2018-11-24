namespace MapClicker
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zTextBox = new System.Windows.Forms.MaskedTextBox();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.yTextBox = new System.Windows.Forms.MaskedTextBox();
            this.xTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drawGridButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.coordinatesListBox = new System.Windows.Forms.ListBox();
            this.coordinatesTextBox = new System.Windows.Forms.TextBox();
            this.coordinatesDisplay = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.coordinatesDisplay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.zTextBox);
            this.groupBox1.Controls.Add(this.loadImageButton);
            this.groupBox1.Controls.Add(this.yTextBox);
            this.groupBox1.Controls.Add(this.xTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.drawGridButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Координаты считаем снизу слева.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(757, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Увеличение:";
            // 
            // zTextBox
            // 
            this.zTextBox.Enabled = false;
            this.zTextBox.Location = new System.Drawing.Point(834, 16);
            this.zTextBox.Mask = "0";
            this.zTextBox.Name = "zTextBox";
            this.zTextBox.Size = new System.Drawing.Size(30, 20);
            this.zTextBox.TabIndex = 6;
            this.zTextBox.Text = "1";
            this.zTextBox.ValidatingType = typeof(int);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(333, 14);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(121, 23);
            this.loadImageButton.TabIndex = 5;
            this.loadImageButton.Text = "Загрузить картинку";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(160, 16);
            this.yTextBox.Mask = "000";
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(53, 20);
            this.yTextBox.TabIndex = 4;
            this.yTextBox.Text = "270";
            this.yTextBox.ValidatingType = typeof(int);
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(101, 16);
            this.xTextBox.Mask = "000";
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(53, 20);
            this.xTextBox.TabIndex = 3;
            this.xTextBox.Text = "360";
            this.xTextBox.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Размеры сетки:";
            // 
            // drawGridButton
            // 
            this.drawGridButton.Enabled = false;
            this.drawGridButton.Location = new System.Drawing.Point(219, 14);
            this.drawGridButton.Name = "drawGridButton";
            this.drawGridButton.Size = new System.Drawing.Size(108, 23);
            this.drawGridButton.TabIndex = 0;
            this.drawGridButton.Text = "Рисовать сетку";
            this.drawGridButton.UseVisualStyleBackColor = true;
            this.drawGridButton.Click += new System.EventHandler(this.DrawGridButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Location = new System.Drawing.Point(3, 6);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(160, 175);
            this.imagePictureBox.TabIndex = 1;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imagePictureBox_MouseClick);
            this.imagePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imagePictureBox_MouseMove);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.imagePictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 403);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.coordinatesListBox);
            this.panel2.Controls.Add(this.coordinatesTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 106);
            this.panel2.TabIndex = 3;
            // 
            // coordinatesListBox
            // 
            this.coordinatesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coordinatesListBox.FormattingEnabled = true;
            this.coordinatesListBox.Location = new System.Drawing.Point(454, 0);
            this.coordinatesListBox.Name = "coordinatesListBox";
            this.coordinatesListBox.Size = new System.Drawing.Size(416, 106);
            this.coordinatesListBox.TabIndex = 1;
            // 
            // coordinatesTextBox
            // 
            this.coordinatesTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.coordinatesTextBox.Location = new System.Drawing.Point(0, 0);
            this.coordinatesTextBox.Multiline = true;
            this.coordinatesTextBox.Name = "coordinatesTextBox";
            this.coordinatesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.coordinatesTextBox.Size = new System.Drawing.Size(454, 106);
            this.coordinatesTextBox.TabIndex = 0;
            // 
            // coordinatesDisplay
            // 
            this.coordinatesDisplay.AutoSize = true;
            this.coordinatesDisplay.Location = new System.Drawing.Point(460, 19);
            this.coordinatesDisplay.Name = "coordinatesDisplay";
            this.coordinatesDisplay.Size = new System.Drawing.Size(36, 13);
            this.coordinatesDisplay.TabIndex = 9;
            this.coordinatesDisplay.Text = "X:   Y:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Map Clicker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button drawGridButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.MaskedTextBox yTextBox;
        private System.Windows.Forms.MaskedTextBox xTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox zTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox coordinatesTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox coordinatesListBox;
        private System.Windows.Forms.Label coordinatesDisplay;
    }
}

