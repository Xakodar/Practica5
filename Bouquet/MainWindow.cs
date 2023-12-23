using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BouquetApp
{
    public partial class MainWindow : Form
    {
        public static Bouquet bouquet = new Bouquet();
        public MainWindow()
        {
            InitializeComponent();
            StateBouquetLabel.Text = "";
            TimeBouquetLabel.Text = "0";          
        }

        private void AddFlowerBtn_Click(object sender, EventArgs e)
        {
            AddFlowerWindow form = new AddFlowerWindow();
            form.ShowDialog();
        }

        private void ShowPriceBtn_Click(object sender, EventArgs e)
        {
            if (bouquet.flowersCount() > 0)
            {
                PriceTextBox.Text = bouquet.price().ToString();
            }
            else
            {
                MessageBox.Show("В букете нет ни одного цветка");
            }
        }

        private void ShowRealPriceBtn_Click(object sender, EventArgs e)
        {
            if (bouquet.flowersCount() > 0)
            {
                RealPriceTextBox.Text = bouquet.realPrice().ToString();
            }
            else
            {
                MessageBox.Show("В букете нет ни одного цветка");
            }
        }

        private void DeleteFlowerDtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdDeleteFlowerTextBox.Text))
            {
                MessageBox.Show("Укажите ID цветка для удаления");
                return;
            }

            int id;

            if (int.TryParse(IdDeleteFlowerTextBox.Text, out id))
            {
                if (bouquet.delFlower(id))
                {

                    MessageBox.Show($"Цветок с ID = {id} успешно удалён");
                    if (bouquet.flowersCount() >=1)
                    {
                        PrintStateBouquetBtn_Click(sender, e);
                    }
                    else
                    {
                        ShowBouquetsTextBox.Text = string.Empty;
                        StateBouquetLabel.Text = "цветов нет";
                        PriceTextBox.Text = string.Empty;
                        RealPriceTextBox.Text = string.Empty;
                    }
                    return;
                }
                else
                {
                    MessageBox.Show($"Цветок с ID = {id} не существует!");
                    return;
                }
            }
            else
            {
                MessageBox.Show($"Введите числовое значение ID цветка");
            }           
        }

        private void SetInWaterBtn_Click(object sender, EventArgs e)
        {
            if (bouquet.flowersCount() > 0)
            {
                bouquet.setInWater();
                StateBouquetLabel.Text = "в воде";
            }
            else
            {
                MessageBox.Show("В букете нет цветов");
            }
        }

        private void SetOutWaterBtn_Click(object sender, EventArgs e)
        {
            if (bouquet.flowersCount() > 0)
            {
                bouquet.setOutWater();
                StateBouquetLabel.Text = "не в воде";
            }
            else
            {
                MessageBox.Show("В букете нет цветов");
            }
        }

        private void PrintStateBouquetBtn_Click(object sender, EventArgs e)
        {
            if (bouquet.flowersCount() == 0)
            {
                MessageBox.Show("В букете ещё нет цветов");
                return;
            }

            ShowBouquetsTextBox.Text = string.Empty;

            var flowersList = bouquet.getFlowersList();
            for (int i = 0; i < bouquet.flowersCount(); i++)
            {
                ShowBouquetsTextBox.Text += $"[{i}] {flowersList[i].name} {flowersList[i].color} ";
                if (!flowersList[i].isWilted())
                {
                    ShowBouquetsTextBox.Text += "не завядший";
                }
                else
                {
                    ShowBouquetsTextBox.Text += "завядший";
                }
                ShowBouquetsTextBox.Text += "\r\n";
            }         
        }

        private void DiffTimeBtn_Click(object sender, EventArgs e)
        {
            double time;
            if (bouquet.flowersCount() == 0)
            {
                MessageBox.Show("В букете ещё нет цветов");
                return;
            }

            if (double.TryParse(DiffTimeNUD.Value.ToString(), out time))
            {
                bouquet.diffTime(time);

                TimeBouquetLabel.Text = (time + double.Parse(TimeBouquetLabel.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Введите число дней простаивания букета");
            }
        }
    }
}
