using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouquetApp
{
    public partial class AddFlowerWindow : Form
    {
        public AddFlowerWindow()
        {
            InitializeComponent();
            colors[] colorsFrowers = (colors[])Enum.GetValues(typeof(colors));

            ColorsComboBx.DataSource= colorsFrowers;
        }

        private void AddFlowerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameFlowerTextBox.Text))
            {
                MessageBox.Show("Заполните название цветка");
                return;
            }
            if (string.IsNullOrEmpty(ColorsComboBx.Text))
            {
                MessageBox.Show("Выберите цвет");
                return;
            }
            if (string.IsNullOrEmpty(RateWitheringInWaterNUD.Text))
            {
                MessageBox.Show("Укажите скорость увядания цветка в воде");
                return;
            }
            if (string.IsNullOrEmpty(RateWitheringWithoutWaterNUD.Text))
            {
                MessageBox.Show("Укажите скорость увядания цветка без воды");
                return;
            }
            if (string.IsNullOrEmpty(PriceNUD.Text))
            {
                MessageBox.Show("Укажите стоимость цветка");
                return;
            }

            string name = NameFlowerTextBox.Text;    

            colors color = (colors)ColorsComboBx.SelectedItem;

            double rateWitheringInWater = Convert.ToDouble(RateWitheringInWaterNUD.Value); 
            double rateWitheringWithoutWater = Convert.ToDouble(RateWitheringWithoutWaterNUD.Value);            
            double price = Convert.ToDouble(PriceNUD.Value);

            if (price == 0)
            {
                MessageBox.Show("Укажите стоимость цветка больше 0");
                return;
            }

            Flower flower = new Flower(name, color, rateWitheringInWater, rateWitheringWithoutWater, price);
            MainWindow.bouquet.addFlower(flower);

            MessageBox.Show($"Цветок \"{name}\" успешно добавлен!");

            Close();    
        }
    }
}
