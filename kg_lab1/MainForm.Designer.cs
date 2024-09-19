namespace kg_lab1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonDeffaultPosition = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MoveTextBox = new System.Windows.Forms.TextBox();
            this.MovePlusX = new System.Windows.Forms.Button();
            this.MovePlusY = new System.Windows.Forms.Button();
            this.MovePlusZ = new System.Windows.Forms.Button();
            this.MoveMinusZ = new System.Windows.Forms.Button();
            this.MoveMinusY = new System.Windows.Forms.Button();
            this.MoveMinusX = new System.Windows.Forms.Button();
            this.RotateTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RotateLeftZ = new System.Windows.Forms.Button();
            this.RotateLeftY = new System.Windows.Forms.Button();
            this.RotateLeftX = new System.Windows.Forms.Button();
            this.RotateRightZ = new System.Windows.Forms.Button();
            this.RotateRightY = new System.Windows.Forms.Button();
            this.RotateRightX = new System.Windows.Forms.Button();
            this.MirrorXY = new System.Windows.Forms.Button();
            this.MirrorXZ = new System.Windows.Forms.Button();
            this.MirrorYZ = new System.Windows.Forms.Button();
            this.Stretch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ScaleTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDeffaultPosition
            // 
            this.buttonDeffaultPosition.Location = new System.Drawing.Point(10, 10);
            this.buttonDeffaultPosition.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeffaultPosition.Name = "buttonDeffaultPosition";
            this.buttonDeffaultPosition.Size = new System.Drawing.Size(137, 24);
            this.buttonDeffaultPosition.TabIndex = 0;
            this.buttonDeffaultPosition.Text = "Начльная позиция";
            this.buttonDeffaultPosition.UseVisualStyleBackColor = true;
            this.buttonDeffaultPosition.Click += new System.EventHandler(this.buttonDeffaultPosition_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Перемещение";
            // 
            // MoveTextBox
            // 
            this.MoveTextBox.Location = new System.Drawing.Point(88, 37);
            this.MoveTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MoveTextBox.Name = "MoveTextBox";
            this.MoveTextBox.Size = new System.Drawing.Size(60, 20);
            this.MoveTextBox.TabIndex = 2;
            this.MoveTextBox.Text = "10";
            // 
            // MovePlusX
            // 
            this.MovePlusX.Location = new System.Drawing.Point(12, 59);
            this.MovePlusX.Margin = new System.Windows.Forms.Padding(2);
            this.MovePlusX.Name = "MovePlusX";
            this.MovePlusX.Size = new System.Drawing.Size(38, 24);
            this.MovePlusX.TabIndex = 3;
            this.MovePlusX.Text = "X+";
            this.MovePlusX.UseVisualStyleBackColor = true;
            this.MovePlusX.Click += new System.EventHandler(this.MovePlusX_Click);
            // 
            // MovePlusY
            // 
            this.MovePlusY.Location = new System.Drawing.Point(61, 59);
            this.MovePlusY.Margin = new System.Windows.Forms.Padding(2);
            this.MovePlusY.Name = "MovePlusY";
            this.MovePlusY.Size = new System.Drawing.Size(38, 24);
            this.MovePlusY.TabIndex = 4;
            this.MovePlusY.Text = "Y+";
            this.MovePlusY.UseVisualStyleBackColor = true;
            this.MovePlusY.Click += new System.EventHandler(this.MovePlusY_Click);
            // 
            // MovePlusZ
            // 
            this.MovePlusZ.Location = new System.Drawing.Point(110, 59);
            this.MovePlusZ.Margin = new System.Windows.Forms.Padding(2);
            this.MovePlusZ.Name = "MovePlusZ";
            this.MovePlusZ.Size = new System.Drawing.Size(38, 24);
            this.MovePlusZ.TabIndex = 5;
            this.MovePlusZ.Text = "Z+";
            this.MovePlusZ.UseVisualStyleBackColor = true;
            this.MovePlusZ.Click += new System.EventHandler(this.MovePlusZ_Click);
            // 
            // MoveMinusZ
            // 
            this.MoveMinusZ.Location = new System.Drawing.Point(110, 89);
            this.MoveMinusZ.Margin = new System.Windows.Forms.Padding(2);
            this.MoveMinusZ.Name = "MoveMinusZ";
            this.MoveMinusZ.Size = new System.Drawing.Size(38, 24);
            this.MoveMinusZ.TabIndex = 8;
            this.MoveMinusZ.Text = "Z-";
            this.MoveMinusZ.UseVisualStyleBackColor = true;
            this.MoveMinusZ.Click += new System.EventHandler(this.MoveMinusZ_Click);
            // 
            // MoveMinusY
            // 
            this.MoveMinusY.Location = new System.Drawing.Point(61, 89);
            this.MoveMinusY.Margin = new System.Windows.Forms.Padding(2);
            this.MoveMinusY.Name = "MoveMinusY";
            this.MoveMinusY.Size = new System.Drawing.Size(38, 24);
            this.MoveMinusY.TabIndex = 7;
            this.MoveMinusY.Text = "Y-";
            this.MoveMinusY.UseVisualStyleBackColor = true;
            this.MoveMinusY.Click += new System.EventHandler(this.MoveMinusY_Click);
            // 
            // MoveMinusX
            // 
            this.MoveMinusX.Location = new System.Drawing.Point(12, 89);
            this.MoveMinusX.Margin = new System.Windows.Forms.Padding(2);
            this.MoveMinusX.Name = "MoveMinusX";
            this.MoveMinusX.Size = new System.Drawing.Size(38, 24);
            this.MoveMinusX.TabIndex = 6;
            this.MoveMinusX.Text = "X-";
            this.MoveMinusX.UseVisualStyleBackColor = true;
            this.MoveMinusX.Click += new System.EventHandler(this.MoveMinusX_Click);
            // 
            // RotateTextBox
            // 
            this.RotateTextBox.Location = new System.Drawing.Point(88, 118);
            this.RotateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RotateTextBox.Name = "RotateTextBox";
            this.RotateTextBox.Size = new System.Drawing.Size(60, 20);
            this.RotateTextBox.TabIndex = 10;
            this.RotateTextBox.Text = "45";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вращение";
            // 
            // RotateLeftZ
            // 
            this.RotateLeftZ.Location = new System.Drawing.Point(110, 172);
            this.RotateLeftZ.Margin = new System.Windows.Forms.Padding(2);
            this.RotateLeftZ.Name = "RotateLeftZ";
            this.RotateLeftZ.Size = new System.Drawing.Size(38, 24);
            this.RotateLeftZ.TabIndex = 16;
            this.RotateLeftZ.Text = "Z-l";
            this.RotateLeftZ.UseVisualStyleBackColor = true;
            this.RotateLeftZ.Click += new System.EventHandler(this.RotateLeftZ_Click);
            // 
            // RotateLeftY
            // 
            this.RotateLeftY.Location = new System.Drawing.Point(61, 172);
            this.RotateLeftY.Margin = new System.Windows.Forms.Padding(2);
            this.RotateLeftY.Name = "RotateLeftY";
            this.RotateLeftY.Size = new System.Drawing.Size(38, 24);
            this.RotateLeftY.TabIndex = 15;
            this.RotateLeftY.Text = "Y-l";
            this.RotateLeftY.UseVisualStyleBackColor = true;
            this.RotateLeftY.Click += new System.EventHandler(this.RotateLeftY_Click);
            // 
            // RotateLeftX
            // 
            this.RotateLeftX.Location = new System.Drawing.Point(12, 172);
            this.RotateLeftX.Margin = new System.Windows.Forms.Padding(2);
            this.RotateLeftX.Name = "RotateLeftX";
            this.RotateLeftX.Size = new System.Drawing.Size(38, 24);
            this.RotateLeftX.TabIndex = 14;
            this.RotateLeftX.Text = "X-l";
            this.RotateLeftX.UseVisualStyleBackColor = true;
            this.RotateLeftX.Click += new System.EventHandler(this.RotateLeftX_Click);
            // 
            // RotateRightZ
            // 
            this.RotateRightZ.Location = new System.Drawing.Point(110, 143);
            this.RotateRightZ.Margin = new System.Windows.Forms.Padding(2);
            this.RotateRightZ.Name = "RotateRightZ";
            this.RotateRightZ.Size = new System.Drawing.Size(38, 24);
            this.RotateRightZ.TabIndex = 13;
            this.RotateRightZ.Text = "Z-r";
            this.RotateRightZ.UseVisualStyleBackColor = true;
            this.RotateRightZ.Click += new System.EventHandler(this.RotateRightZ_Click);
            // 
            // RotateRightY
            // 
            this.RotateRightY.Location = new System.Drawing.Point(61, 143);
            this.RotateRightY.Margin = new System.Windows.Forms.Padding(2);
            this.RotateRightY.Name = "RotateRightY";
            this.RotateRightY.Size = new System.Drawing.Size(38, 24);
            this.RotateRightY.TabIndex = 12;
            this.RotateRightY.Text = "Y-r";
            this.RotateRightY.UseVisualStyleBackColor = true;
            this.RotateRightY.Click += new System.EventHandler(this.RotateRightY_Click);
            // 
            // RotateRightX
            // 
            this.RotateRightX.Location = new System.Drawing.Point(12, 143);
            this.RotateRightX.Margin = new System.Windows.Forms.Padding(2);
            this.RotateRightX.Name = "RotateRightX";
            this.RotateRightX.Size = new System.Drawing.Size(38, 24);
            this.RotateRightX.TabIndex = 11;
            this.RotateRightX.Text = "X-r";
            this.RotateRightX.UseVisualStyleBackColor = true;
            this.RotateRightX.Click += new System.EventHandler(this.RotateRightX_Click);
            // 
            // MirrorXY
            // 
            this.MirrorXY.Location = new System.Drawing.Point(12, 202);
            this.MirrorXY.Margin = new System.Windows.Forms.Padding(2);
            this.MirrorXY.Name = "MirrorXY";
            this.MirrorXY.Size = new System.Drawing.Size(137, 24);
            this.MirrorXY.TabIndex = 17;
            this.MirrorXY.Text = "Отражение OXY";
            this.MirrorXY.UseVisualStyleBackColor = true;
            this.MirrorXY.Click += new System.EventHandler(this.MirrorXY_Click);
            // 
            // MirrorXZ
            // 
            this.MirrorXZ.Location = new System.Drawing.Point(12, 231);
            this.MirrorXZ.Margin = new System.Windows.Forms.Padding(2);
            this.MirrorXZ.Name = "MirrorXZ";
            this.MirrorXZ.Size = new System.Drawing.Size(137, 24);
            this.MirrorXZ.TabIndex = 18;
            this.MirrorXZ.Text = "Отражение OXZ";
            this.MirrorXZ.UseVisualStyleBackColor = true;
            this.MirrorXZ.Click += new System.EventHandler(this.MirrorXZ_Click);
            // 
            // MirrorYZ
            // 
            this.MirrorYZ.Location = new System.Drawing.Point(12, 260);
            this.MirrorYZ.Margin = new System.Windows.Forms.Padding(2);
            this.MirrorYZ.Name = "MirrorYZ";
            this.MirrorYZ.Size = new System.Drawing.Size(137, 24);
            this.MirrorYZ.TabIndex = 19;
            this.MirrorYZ.Text = "Отражение OYZ";
            this.MirrorYZ.UseVisualStyleBackColor = true;
            this.MirrorYZ.Click += new System.EventHandler(this.MirrorYZ_Click);
            // 
            // Stretch
            // 
            this.Stretch.Location = new System.Drawing.Point(12, 289);
            this.Stretch.Margin = new System.Windows.Forms.Padding(2);
            this.Stretch.Name = "Stretch";
            this.Stretch.Size = new System.Drawing.Size(137, 24);
            this.Stretch.TabIndex = 20;
            this.Stretch.Text = "Масштаб";
            this.Stretch.UseVisualStyleBackColor = true;
            this.Stretch.Click += new System.EventHandler(this.Stretch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Перемещение точки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScaleTB
            // 
            this.ScaleTB.Location = new System.Drawing.Point(13, 318);
            this.ScaleTB.Name = "ScaleTB";
            this.ScaleTB.Size = new System.Drawing.Size(136, 20);
            this.ScaleTB.TabIndex = 26;
            this.ScaleTB.Text = "2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 465);
            this.Controls.Add(this.ScaleTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Stretch);
            this.Controls.Add(this.MirrorYZ);
            this.Controls.Add(this.MirrorXZ);
            this.Controls.Add(this.MirrorXY);
            this.Controls.Add(this.RotateLeftZ);
            this.Controls.Add(this.RotateLeftY);
            this.Controls.Add(this.RotateLeftX);
            this.Controls.Add(this.RotateRightZ);
            this.Controls.Add(this.RotateRightY);
            this.Controls.Add(this.RotateRightX);
            this.Controls.Add(this.RotateTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MoveMinusZ);
            this.Controls.Add(this.MoveMinusY);
            this.Controls.Add(this.MoveMinusX);
            this.Controls.Add(this.MovePlusZ);
            this.Controls.Add(this.MovePlusY);
            this.Controls.Add(this.MovePlusX);
            this.Controls.Add(this.MoveTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeffaultPosition);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Афинные преобразования";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeffaultPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MoveTextBox;
        private System.Windows.Forms.Button MovePlusX;
        private System.Windows.Forms.Button MovePlusY;
        private System.Windows.Forms.Button MovePlusZ;
        private System.Windows.Forms.Button MoveMinusZ;
        private System.Windows.Forms.Button MoveMinusY;
        private System.Windows.Forms.Button MoveMinusX;
        private System.Windows.Forms.TextBox RotateTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RotateLeftZ;
        private System.Windows.Forms.Button RotateLeftY;
        private System.Windows.Forms.Button RotateLeftX;
        private System.Windows.Forms.Button RotateRightZ;
        private System.Windows.Forms.Button RotateRightY;
        private System.Windows.Forms.Button RotateRightX;
        private System.Windows.Forms.Button MirrorXY;
        private System.Windows.Forms.Button MirrorXZ;
        private System.Windows.Forms.Button MirrorYZ;
        private System.Windows.Forms.Button Stretch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ScaleTB;
    }
}

