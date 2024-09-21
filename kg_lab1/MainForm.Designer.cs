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
            this.MovePlusX = new System.Windows.Forms.Button();
            this.MovePlusY = new System.Windows.Forms.Button();
            this.MovePlusZ = new System.Windows.Forms.Button();
            this.MoveMinusZ = new System.Windows.Forms.Button();
            this.MoveMinusY = new System.Windows.Forms.Button();
            this.MoveMinusX = new System.Windows.Forms.Button();
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
            this.buttonDeffaultPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeffaultPosition.Location = new System.Drawing.Point(691, 496);
            this.buttonDeffaultPosition.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeffaultPosition.Name = "buttonDeffaultPosition";
            this.buttonDeffaultPosition.Size = new System.Drawing.Size(86, 53);
            this.buttonDeffaultPosition.TabIndex = 0;
            this.buttonDeffaultPosition.Text = "Начльная позиция";
            this.buttonDeffaultPosition.UseVisualStyleBackColor = true;
            this.buttonDeffaultPosition.Click += new System.EventHandler(this.buttonDeffaultPosition_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 446);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Перемещение";
            // 
            // MovePlusX
            // 
            this.MovePlusX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MovePlusX.Location = new System.Drawing.Point(11, 466);
            this.MovePlusX.Margin = new System.Windows.Forms.Padding(2);
            this.MovePlusX.Name = "MovePlusX";
            this.MovePlusX.Size = new System.Drawing.Size(38, 24);
            this.MovePlusX.TabIndex = 3;
            this.MovePlusX.Text = "X+";
            this.MovePlusX.UseVisualStyleBackColor = true;
            this.MovePlusX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovePlusX_MouseDown);
            this.MovePlusX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Current_MouseUp);
            // 
            // MovePlusY
            // 
            this.MovePlusY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MovePlusY.Location = new System.Drawing.Point(60, 466);
            this.MovePlusY.Margin = new System.Windows.Forms.Padding(2);
            this.MovePlusY.Name = "MovePlusY";
            this.MovePlusY.Size = new System.Drawing.Size(38, 24);
            this.MovePlusY.TabIndex = 4;
            this.MovePlusY.Text = "Y+";
            this.MovePlusY.UseVisualStyleBackColor = true;
            this.MovePlusY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovePlusY_MouseDown);
            this.MovePlusY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Current_MouseUp);
            // 
            // MovePlusZ
            // 
            this.MovePlusZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MovePlusZ.Location = new System.Drawing.Point(109, 466);
            this.MovePlusZ.Margin = new System.Windows.Forms.Padding(2);
            this.MovePlusZ.Name = "MovePlusZ";
            this.MovePlusZ.Size = new System.Drawing.Size(38, 24);
            this.MovePlusZ.TabIndex = 5;
            this.MovePlusZ.Text = "Z+";
            this.MovePlusZ.UseVisualStyleBackColor = true;
            this.MovePlusZ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovePlusZ_MouseDown);
            this.MovePlusZ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Current_MouseUp);
            // 
            // MoveMinusZ
            // 
            this.MoveMinusZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MoveMinusZ.Location = new System.Drawing.Point(109, 496);
            this.MoveMinusZ.Margin = new System.Windows.Forms.Padding(2);
            this.MoveMinusZ.Name = "MoveMinusZ";
            this.MoveMinusZ.Size = new System.Drawing.Size(38, 24);
            this.MoveMinusZ.TabIndex = 8;
            this.MoveMinusZ.Text = "Z-";
            this.MoveMinusZ.UseVisualStyleBackColor = true;
            this.MoveMinusZ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveMinusZ_MouseDown);
            this.MoveMinusZ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Current_MouseUp);
            // 
            // MoveMinusY
            // 
            this.MoveMinusY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MoveMinusY.Location = new System.Drawing.Point(60, 496);
            this.MoveMinusY.Margin = new System.Windows.Forms.Padding(2);
            this.MoveMinusY.Name = "MoveMinusY";
            this.MoveMinusY.Size = new System.Drawing.Size(38, 24);
            this.MoveMinusY.TabIndex = 7;
            this.MoveMinusY.Text = "Y-";
            this.MoveMinusY.UseVisualStyleBackColor = true;
            this.MoveMinusY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveMinusY_MouseDown);
            this.MoveMinusY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Current_MouseUp);
            // 
            // MoveMinusX
            // 
            this.MoveMinusX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MoveMinusX.Location = new System.Drawing.Point(11, 496);
            this.MoveMinusX.Margin = new System.Windows.Forms.Padding(2);
            this.MoveMinusX.Name = "MoveMinusX";
            this.MoveMinusX.Size = new System.Drawing.Size(38, 24);
            this.MoveMinusX.TabIndex = 6;
            this.MoveMinusX.Text = "X-";
            this.MoveMinusX.UseVisualStyleBackColor = true;
            this.MoveMinusX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveMinusX_MouseDown);
            this.MoveMinusX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Current_MouseUp);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 444);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вращение";
            // 
            // RotateLeftZ
            // 
            this.RotateLeftZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RotateLeftZ.Location = new System.Drawing.Point(257, 496);
            this.RotateLeftZ.Margin = new System.Windows.Forms.Padding(2);
            this.RotateLeftZ.Name = "RotateLeftZ";
            this.RotateLeftZ.Size = new System.Drawing.Size(38, 24);
            this.RotateLeftZ.TabIndex = 16;
            this.RotateLeftZ.Text = "Z-l";
            this.RotateLeftZ.UseVisualStyleBackColor = true;
            this.RotateLeftZ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RotateLeftZ_MouseDown);
            this.RotateLeftZ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Current_MouseUp);
            // 
            // RotateLeftY
            // 
            this.RotateLeftY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RotateLeftY.Location = new System.Drawing.Point(208, 496);
            this.RotateLeftY.Margin = new System.Windows.Forms.Padding(2);
            this.RotateLeftY.Name = "RotateLeftY";
            this.RotateLeftY.Size = new System.Drawing.Size(38, 24);
            this.RotateLeftY.TabIndex = 15;
            this.RotateLeftY.Text = "Y-l";
            this.RotateLeftY.UseVisualStyleBackColor = true;
            this.RotateLeftY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RotateLeftY_MouseDown);
            this.RotateLeftY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Current_MouseUp);
            // 
            // RotateLeftX
            // 
            this.RotateLeftX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RotateLeftX.Location = new System.Drawing.Point(159, 496);
            this.RotateLeftX.Margin = new System.Windows.Forms.Padding(2);
            this.RotateLeftX.Name = "RotateLeftX";
            this.RotateLeftX.Size = new System.Drawing.Size(38, 24);
            this.RotateLeftX.TabIndex = 14;
            this.RotateLeftX.Text = "X-l";
            this.RotateLeftX.UseVisualStyleBackColor = true;
            this.RotateLeftX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RotateLeftX_MouseDown);
            this.RotateLeftX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Current_MouseUp);
            // 
            // RotateRightZ
            // 
            this.RotateRightZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RotateRightZ.Location = new System.Drawing.Point(257, 467);
            this.RotateRightZ.Margin = new System.Windows.Forms.Padding(2);
            this.RotateRightZ.Name = "RotateRightZ";
            this.RotateRightZ.Size = new System.Drawing.Size(38, 24);
            this.RotateRightZ.TabIndex = 13;
            this.RotateRightZ.Text = "Z-r";
            this.RotateRightZ.UseVisualStyleBackColor = true;
            this.RotateRightZ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RotateRightZ_MouseDown);
            this.RotateRightZ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Current_MouseUp);
            // 
            // RotateRightY
            // 
            this.RotateRightY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RotateRightY.Location = new System.Drawing.Point(208, 467);
            this.RotateRightY.Margin = new System.Windows.Forms.Padding(2);
            this.RotateRightY.Name = "RotateRightY";
            this.RotateRightY.Size = new System.Drawing.Size(38, 24);
            this.RotateRightY.TabIndex = 12;
            this.RotateRightY.Text = "Y-r";
            this.RotateRightY.UseVisualStyleBackColor = true;
            this.RotateRightY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RotateRightY_MouseDown);
            this.RotateRightY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Current_MouseUp);
            // 
            // RotateRightX
            // 
            this.RotateRightX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RotateRightX.Location = new System.Drawing.Point(159, 467);
            this.RotateRightX.Margin = new System.Windows.Forms.Padding(2);
            this.RotateRightX.Name = "RotateRightX";
            this.RotateRightX.Size = new System.Drawing.Size(38, 24);
            this.RotateRightX.TabIndex = 11;
            this.RotateRightX.Text = "X-r";
            this.RotateRightX.UseVisualStyleBackColor = true;
            this.RotateRightX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RotateRightX_MouseDown);
            this.RotateRightX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Current_MouseUp);
            // 
            // MirrorXY
            // 
            this.MirrorXY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MirrorXY.Location = new System.Drawing.Point(196, 526);
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
            this.MirrorXZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MirrorXZ.Location = new System.Drawing.Point(337, 526);
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
            this.MirrorYZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MirrorYZ.Location = new System.Drawing.Point(478, 526);
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
            this.Stretch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Stretch.Location = new System.Drawing.Point(55, 526);
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
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(782, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 53);
            this.button1.TabIndex = 25;
            this.button1.Text = "Перемещение точки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MovingAPoint_Click);
            // 
            // ScaleTB
            // 
            this.ScaleTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ScaleTB.Location = new System.Drawing.Point(10, 529);
            this.ScaleTB.Name = "ScaleTB";
            this.ScaleTB.Size = new System.Drawing.Size(40, 20);
            this.ScaleTB.TabIndex = 26;
            this.ScaleTB.Text = "2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MoveMinusZ);
            this.Controls.Add(this.MoveMinusY);
            this.Controls.Add(this.MoveMinusX);
            this.Controls.Add(this.MovePlusZ);
            this.Controls.Add(this.MovePlusY);
            this.Controls.Add(this.MovePlusX);
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
        private System.Windows.Forms.Button MovePlusX;
        private System.Windows.Forms.Button MovePlusY;
        private System.Windows.Forms.Button MovePlusZ;
        private System.Windows.Forms.Button MoveMinusZ;
        private System.Windows.Forms.Button MoveMinusY;
        private System.Windows.Forms.Button MoveMinusX;
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

