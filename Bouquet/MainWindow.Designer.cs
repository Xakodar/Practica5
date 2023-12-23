namespace BouquetApp
{
    partial class MainWindow
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
            this.ShowBouquetsTextBox = new System.Windows.Forms.TextBox();
            this.AddFlowerBtn = new System.Windows.Forms.Button();
            this.DeleteFlowerDtn = new System.Windows.Forms.Button();
            this.SetInWaterBtn = new System.Windows.Forms.Button();
            this.SetOutWaterBtn = new System.Windows.Forms.Button();
            this.ShowPriceBtn = new System.Windows.Forms.Button();
            this.ShowRealPriceBtn = new System.Windows.Forms.Button();
            this.PrintStateBouquetBtn = new System.Windows.Forms.Button();
            this.IdDeleteFlowerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StateBouquetLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.RealPriceTextBox = new System.Windows.Forms.TextBox();
            this.TimeBouquetLabel = new System.Windows.Forms.Label();
            this.DiffTimeBtn = new System.Windows.Forms.Button();
            this.DiffTimeNUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DiffTimeNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowBouquetsTextBox
            // 
            this.ShowBouquetsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowBouquetsTextBox.Location = new System.Drawing.Point(49, 189);
            this.ShowBouquetsTextBox.Multiline = true;
            this.ShowBouquetsTextBox.Name = "ShowBouquetsTextBox";
            this.ShowBouquetsTextBox.ReadOnly = true;
            this.ShowBouquetsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShowBouquetsTextBox.Size = new System.Drawing.Size(373, 225);
            this.ShowBouquetsTextBox.TabIndex = 0;
            // 
            // AddFlowerBtn
            // 
            this.AddFlowerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddFlowerBtn.Location = new System.Drawing.Point(438, 252);
            this.AddFlowerBtn.Name = "AddFlowerBtn";
            this.AddFlowerBtn.Size = new System.Drawing.Size(182, 79);
            this.AddFlowerBtn.TabIndex = 1;
            this.AddFlowerBtn.Text = "Добавить цветок в букет";
            this.AddFlowerBtn.UseVisualStyleBackColor = true;
            this.AddFlowerBtn.Click += new System.EventHandler(this.AddFlowerBtn_Click);
            // 
            // DeleteFlowerDtn
            // 
            this.DeleteFlowerDtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteFlowerDtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteFlowerDtn.Location = new System.Drawing.Point(684, 153);
            this.DeleteFlowerDtn.Name = "DeleteFlowerDtn";
            this.DeleteFlowerDtn.Size = new System.Drawing.Size(150, 57);
            this.DeleteFlowerDtn.TabIndex = 2;
            this.DeleteFlowerDtn.Text = "Удалить цветок по id";
            this.DeleteFlowerDtn.UseVisualStyleBackColor = true;
            this.DeleteFlowerDtn.Click += new System.EventHandler(this.DeleteFlowerDtn_Click);
            // 
            // SetInWaterBtn
            // 
            this.SetInWaterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetInWaterBtn.Location = new System.Drawing.Point(49, 420);
            this.SetInWaterBtn.Name = "SetInWaterBtn";
            this.SetInWaterBtn.Size = new System.Drawing.Size(150, 74);
            this.SetInWaterBtn.TabIndex = 3;
            this.SetInWaterBtn.Text = "Поставить букет в воду";
            this.SetInWaterBtn.UseVisualStyleBackColor = true;
            this.SetInWaterBtn.Click += new System.EventHandler(this.SetInWaterBtn_Click);
            // 
            // SetOutWaterBtn
            // 
            this.SetOutWaterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetOutWaterBtn.Location = new System.Drawing.Point(272, 420);
            this.SetOutWaterBtn.Name = "SetOutWaterBtn";
            this.SetOutWaterBtn.Size = new System.Drawing.Size(150, 74);
            this.SetOutWaterBtn.TabIndex = 4;
            this.SetOutWaterBtn.Text = "Извлечь букет из воды";
            this.SetOutWaterBtn.UseVisualStyleBackColor = true;
            this.SetOutWaterBtn.Click += new System.EventHandler(this.SetOutWaterBtn_Click);
            // 
            // ShowPriceBtn
            // 
            this.ShowPriceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPriceBtn.Location = new System.Drawing.Point(684, 267);
            this.ShowPriceBtn.Name = "ShowPriceBtn";
            this.ShowPriceBtn.Size = new System.Drawing.Size(150, 48);
            this.ShowPriceBtn.TabIndex = 5;
            this.ShowPriceBtn.Text = "Узнать стоимость букета";
            this.ShowPriceBtn.UseVisualStyleBackColor = true;
            this.ShowPriceBtn.Click += new System.EventHandler(this.ShowPriceBtn_Click);
            // 
            // ShowRealPriceBtn
            // 
            this.ShowRealPriceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowRealPriceBtn.Location = new System.Drawing.Point(684, 335);
            this.ShowRealPriceBtn.Name = "ShowRealPriceBtn";
            this.ShowRealPriceBtn.Size = new System.Drawing.Size(150, 48);
            this.ShowRealPriceBtn.TabIndex = 6;
            this.ShowRealPriceBtn.Text = "Узнать реальную стоимость букета";
            this.ShowRealPriceBtn.UseVisualStyleBackColor = true;
            this.ShowRealPriceBtn.Click += new System.EventHandler(this.ShowRealPriceBtn_Click);
            // 
            // PrintStateBouquetBtn
            // 
            this.PrintStateBouquetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintStateBouquetBtn.Location = new System.Drawing.Point(162, 123);
            this.PrintStateBouquetBtn.Name = "PrintStateBouquetBtn";
            this.PrintStateBouquetBtn.Size = new System.Drawing.Size(150, 60);
            this.PrintStateBouquetBtn.TabIndex = 7;
            this.PrintStateBouquetBtn.Text = "Вывести цветы букета";
            this.PrintStateBouquetBtn.UseVisualStyleBackColor = true;
            this.PrintStateBouquetBtn.Click += new System.EventHandler(this.PrintStateBouquetBtn_Click);
            // 
            // IdDeleteFlowerTextBox
            // 
            this.IdDeleteFlowerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdDeleteFlowerTextBox.Location = new System.Drawing.Point(859, 168);
            this.IdDeleteFlowerTextBox.Name = "IdDeleteFlowerTextBox";
            this.IdDeleteFlowerTextBox.Size = new System.Drawing.Size(140, 26);
            this.IdDeleteFlowerTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(397, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Симулятор букета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Состояние букета:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(752, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Время букета:";
            // 
            // StateBouquetLabel
            // 
            this.StateBouquetLabel.AutoSize = true;
            this.StateBouquetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StateBouquetLabel.Location = new System.Drawing.Point(208, 80);
            this.StateBouquetLabel.Name = "StateBouquetLabel";
            this.StateBouquetLabel.Size = new System.Drawing.Size(59, 25);
            this.StateBouquetLabel.TabIndex = 12;
            this.StateBouquetLabel.Text = "state";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceTextBox.Location = new System.Drawing.Point(859, 278);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(140, 26);
            this.PriceTextBox.TabIndex = 13;
            // 
            // RealPriceTextBox
            // 
            this.RealPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RealPriceTextBox.Location = new System.Drawing.Point(859, 346);
            this.RealPriceTextBox.Name = "RealPriceTextBox";
            this.RealPriceTextBox.ReadOnly = true;
            this.RealPriceTextBox.Size = new System.Drawing.Size(140, 26);
            this.RealPriceTextBox.TabIndex = 14;
            // 
            // TimeBouquetLabel
            // 
            this.TimeBouquetLabel.AutoSize = true;
            this.TimeBouquetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeBouquetLabel.Location = new System.Drawing.Point(905, 80);
            this.TimeBouquetLabel.Name = "TimeBouquetLabel";
            this.TimeBouquetLabel.Size = new System.Drawing.Size(52, 25);
            this.TimeBouquetLabel.TabIndex = 15;
            this.TimeBouquetLabel.Text = "time";
            // 
            // DiffTimeBtn
            // 
            this.DiffTimeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiffTimeBtn.Location = new System.Drawing.Point(684, 446);
            this.DiffTimeBtn.Name = "DiffTimeBtn";
            this.DiffTimeBtn.Size = new System.Drawing.Size(150, 48);
            this.DiffTimeBtn.TabIndex = 16;
            this.DiffTimeBtn.Text = "Изменить время букета";
            this.DiffTimeBtn.UseVisualStyleBackColor = true;
            this.DiffTimeBtn.Click += new System.EventHandler(this.DiffTimeBtn_Click);
            // 
            // DiffTimeNUD
            // 
            this.DiffTimeNUD.DecimalPlaces = 1;
            this.DiffTimeNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiffTimeNUD.Location = new System.Drawing.Point(859, 458);
            this.DiffTimeNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.DiffTimeNUD.Name = "DiffTimeNUD";
            this.DiffTimeNUD.Size = new System.Drawing.Size(140, 26);
            this.DiffTimeNUD.TabIndex = 17;
            this.DiffTimeNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 550);
            this.Controls.Add(this.DiffTimeNUD);
            this.Controls.Add(this.DiffTimeBtn);
            this.Controls.Add(this.TimeBouquetLabel);
            this.Controls.Add(this.RealPriceTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.StateBouquetLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdDeleteFlowerTextBox);
            this.Controls.Add(this.PrintStateBouquetBtn);
            this.Controls.Add(this.ShowRealPriceBtn);
            this.Controls.Add(this.ShowPriceBtn);
            this.Controls.Add(this.SetOutWaterBtn);
            this.Controls.Add(this.SetInWaterBtn);
            this.Controls.Add(this.DeleteFlowerDtn);
            this.Controls.Add(this.AddFlowerBtn);
            this.Controls.Add(this.ShowBouquetsTextBox);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DiffTimeNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShowBouquetsTextBox;
        private System.Windows.Forms.Button AddFlowerBtn;
        private System.Windows.Forms.Button DeleteFlowerDtn;
        private System.Windows.Forms.Button SetInWaterBtn;
        private System.Windows.Forms.Button SetOutWaterBtn;
        private System.Windows.Forms.Button ShowPriceBtn;
        private System.Windows.Forms.Button ShowRealPriceBtn;
        private System.Windows.Forms.Button PrintStateBouquetBtn;
        private System.Windows.Forms.TextBox IdDeleteFlowerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StateBouquetLabel;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox RealPriceTextBox;
        private System.Windows.Forms.Label TimeBouquetLabel;
        private System.Windows.Forms.Button DiffTimeBtn;
        private System.Windows.Forms.NumericUpDown DiffTimeNUD;
    }
}

