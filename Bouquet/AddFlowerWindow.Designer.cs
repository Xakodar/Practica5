namespace BouquetApp
{
    partial class AddFlowerWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddFlowerButton = new System.Windows.Forms.Button();
            this.NameFlowerTextBox = new System.Windows.Forms.TextBox();
            this.ColorsComboBx = new System.Windows.Forms.ComboBox();
            this.RateWitheringInWaterNUD = new System.Windows.Forms.NumericUpDown();
            this.RateWitheringWithoutWaterNUD = new System.Windows.Forms.NumericUpDown();
            this.PriceNUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.RateWitheringInWaterNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateWitheringWithoutWaterNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(245, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название цветка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(279, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добавление цветка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(367, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цвет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(154, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Скорость увядания в воде";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(127, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Скорость увядания без воды";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(308, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Стоимость";
            // 
            // AddFlowerButton
            // 
            this.AddFlowerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddFlowerButton.Location = new System.Drawing.Point(332, 356);
            this.AddFlowerButton.Name = "AddFlowerButton";
            this.AddFlowerButton.Size = new System.Drawing.Size(196, 69);
            this.AddFlowerButton.TabIndex = 6;
            this.AddFlowerButton.Text = "Добавить цветок";
            this.AddFlowerButton.UseVisualStyleBackColor = true;
            this.AddFlowerButton.Click += new System.EventHandler(this.AddFlowerButton_Click);
            // 
            // NameFlowerTextBox
            // 
            this.NameFlowerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameFlowerTextBox.Location = new System.Drawing.Point(437, 102);
            this.NameFlowerTextBox.Name = "NameFlowerTextBox";
            this.NameFlowerTextBox.Size = new System.Drawing.Size(152, 29);
            this.NameFlowerTextBox.TabIndex = 7;
            // 
            // ColorsComboBx
            // 
            this.ColorsComboBx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorsComboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorsComboBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorsComboBx.IntegralHeight = false;
            this.ColorsComboBx.Items.AddRange(new object[] {
            "белый розовый голубой"});
            this.ColorsComboBx.Location = new System.Drawing.Point(437, 144);
            this.ColorsComboBx.Name = "ColorsComboBx";
            this.ColorsComboBx.Size = new System.Drawing.Size(152, 32);
            this.ColorsComboBx.TabIndex = 8;
            // 
            // RateWitheringInWaterNUD
            // 
            this.RateWitheringInWaterNUD.DecimalPlaces = 2;
            this.RateWitheringInWaterNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RateWitheringInWaterNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.RateWitheringInWaterNUD.Location = new System.Drawing.Point(437, 191);
            this.RateWitheringInWaterNUD.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RateWitheringInWaterNUD.Name = "RateWitheringInWaterNUD";
            this.RateWitheringInWaterNUD.Size = new System.Drawing.Size(152, 29);
            this.RateWitheringInWaterNUD.TabIndex = 9;
            // 
            // RateWitheringWithoutWaterNUD
            // 
            this.RateWitheringWithoutWaterNUD.DecimalPlaces = 2;
            this.RateWitheringWithoutWaterNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RateWitheringWithoutWaterNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.RateWitheringWithoutWaterNUD.Location = new System.Drawing.Point(437, 238);
            this.RateWitheringWithoutWaterNUD.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RateWitheringWithoutWaterNUD.Name = "RateWitheringWithoutWaterNUD";
            this.RateWitheringWithoutWaterNUD.Size = new System.Drawing.Size(152, 29);
            this.RateWitheringWithoutWaterNUD.TabIndex = 10;
            // 
            // PriceNUD
            // 
            this.PriceNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceNUD.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PriceNUD.Location = new System.Drawing.Point(437, 285);
            this.PriceNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PriceNUD.Name = "PriceNUD";
            this.PriceNUD.Size = new System.Drawing.Size(152, 29);
            this.PriceNUD.TabIndex = 11;
            // 
            // AddFlowerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PriceNUD);
            this.Controls.Add(this.RateWitheringWithoutWaterNUD);
            this.Controls.Add(this.RateWitheringInWaterNUD);
            this.Controls.Add(this.ColorsComboBx);
            this.Controls.Add(this.NameFlowerTextBox);
            this.Controls.Add(this.AddFlowerButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddFlowerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFlowerWindow";
            ((System.ComponentModel.ISupportInitialize)(this.RateWitheringInWaterNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateWitheringWithoutWaterNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddFlowerButton;
        private System.Windows.Forms.TextBox NameFlowerTextBox;
        private System.Windows.Forms.NumericUpDown RateWitheringInWaterNUD;
        private System.Windows.Forms.NumericUpDown RateWitheringWithoutWaterNUD;
        private System.Windows.Forms.NumericUpDown PriceNUD;
        private System.Windows.Forms.ComboBox ColorsComboBx;
    }
}