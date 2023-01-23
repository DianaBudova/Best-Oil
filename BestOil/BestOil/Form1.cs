using BestOil.BL;
using System.ComponentModel;
using System.Globalization;

namespace BestOil
{
    public partial class Form1 : Form
    {
        private FoodPrice foodPrice;
        private TextBox[] cafeAmountControls;
        static private int maxNumberOfLiters = 1000;
        static private int maxNumberOfSum = 50000;
        static private int maxNumberOfFood = 100;

        public Form1()
        {
            this.foodPrice = new();
            InitializeComponent();
            UpdateEverything();
            this.comboBox1.Items.AddRange(FuelPriceRatio.fuel);
            FillCafeAmountControls();
        }

        private void FillCafeAmountControls()
        {
            cafeAmountControls = new TextBox[FoodPriceRatio.food.Length];
            cafeAmountControls[0] = this.hotDogPrice;
            cafeAmountControls[1] = this.hamburgerPrice;
            cafeAmountControls[2] = this.frenchFriesPrice;
            cafeAmountControls[3] = this.sodaPrice;
            if (this.cafeAmountControls.Length == FoodPriceRatio.foodPrice.Count)
                for (short i = 0; i < FoodPriceRatio.food.Length; i++)
                    this.cafeAmountControls[i].Text = FoodPriceRatio.foodPrice.ElementAt(i).Value.ToString();
        }

        private void SetEmptyOrNullEverything()
        {
            this.comboBox1.Text = null;
            this.priceByFuel.Text = "";
            this.literAmount.Text = "";
            this.sumUAH.Text = "";
            this.hotDogAmount.Text = "";
            this.hamburgerAmount.Text = "";
            this.frenchFriesAmount.Text = "";
            this.sodaAmount.Text = "";
            this.fuelPayment.Text = "0";
            this.cafePayment.Text = "0";
            this.totalPayment.Text = "0";
        }

        private void UpdateEverything()
        {
            SetEmptyOrNullEverything();
            this.radioButton1.Enabled = this.radioButton2.Enabled = false;
            this.radioButton1.Checked = this.radioButton2.Checked = false;
            this.fuelPayment.Enabled = this.cafePayment.Enabled = this.totalPayment.Enabled = false;
            this.fuelPayment.ReadOnly = this.cafePayment.ReadOnly = this.totalPayment.ReadOnly = true;
            this.literAmount.ReadOnly = this.sumUAH.ReadOnly = true;
            this.literAmount.Enabled = this.sumUAH.Enabled = false;
            this.hotDogAmount.Enabled = this.hamburgerAmount.Enabled = this.frenchFriesAmount.Enabled = this.sodaAmount.Enabled = false;
            this.hotDogAmount.ReadOnly = this.hamburgerAmount.ReadOnly = this.frenchFriesAmount.ReadOnly = this.sodaAmount.ReadOnly = true;
            this.hotDogPrice.Enabled = this.hamburgerPrice.Enabled = this.frenchFriesPrice.Enabled = this.sodaPrice.Enabled = false;
            this.hotDogPrice.ReadOnly = this.hamburgerPrice.ReadOnly = this.frenchFriesPrice.ReadOnly = this.sodaPrice.ReadOnly = true;
            this.checkBox1.Checked = this.checkBox2.Checked = this.checkBox3.Checked = this.checkBox4.Checked = false;
        }

        private void LocalizationFillByCarEN()
        {
            this.groupBox4.Text = "For payment";
            this.label6.Text = "UAH";
        }

        private void LocalizationFillByCarUA()
        {
            this.groupBox4.Text = "До оплати";
            this.label6.Text = "грн";
        }

        private void ChooseFuel_TextChanged(object sender, EventArgs e)
        {
            ComboBox currentComboBox = (ComboBox)sender;
            if (currentComboBox.Text == "" || currentComboBox.Text == null)
                return;
            this.radioButton1.Enabled = this.radioButton2.Enabled = true;
            this.priceByFuel.Text = FuelPriceRatio.fuelPrice[currentComboBox.Text].ToString();
        }

        private void FillCarBy_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == true)
            {
                if (CultureInfo.CurrentCulture.TextInfo.CultureName == "en-EN")
                    LocalizationFillByCarEN();
                if (CultureInfo.CurrentCulture.TextInfo.CultureName == "uk-UA")
                    LocalizationFillByCarUA();
                this.sumUAH.Clear();
                this.sumUAH.Enabled = false;
                this.sumUAH.ReadOnly = true;
                this.literAmount.Enabled = true;
                this.literAmount.ReadOnly = false;
            }
            else
            {
                if (CultureInfo.CurrentCulture.TextInfo.CultureName == "en-EN")
                {
                    this.groupBox4.Text = "To issue";
                    this.label6.Text = "L";
                }
                if (CultureInfo.CurrentCulture.TextInfo.CultureName == "uk-UA" || CultureInfo.CurrentCulture.TextInfo.CultureName == "ru-UA")
                {
                    this.groupBox4.Text = "До видачі";
                    this.label6.Text = "л";
                }
                this.literAmount.Clear();
                this.literAmount.Enabled = false;
                this.literAmount.ReadOnly = true;
                this.sumUAH.Enabled = true;
                this.sumUAH.ReadOnly = false;
            }
        }

        private void SetPrice_TextChanged(object sender, EventArgs e)
        {
            if (this.literAmount.Text != "" && double.Parse(this.literAmount.Text) <= maxNumberOfLiters)
                this.fuelPayment.Text = Math.Round(double.Parse(this.priceByFuel.Text) * double.Parse(this.literAmount.Text), 2).ToString();
            else
                this.fuelPayment.Text = "0";
        }

        private void SetLiters_TextChanged(object sender, EventArgs e)
        {
            if (this.sumUAH.Text != "" && double.Parse(this.sumUAH.Text) >= double.Parse(this.priceByFuel.Text) && double.Parse(this.sumUAH.Text) <= maxNumberOfSum)
                this.fuelPayment.Text = Math.Round(double.Parse(this.sumUAH.Text) / double.Parse(this.priceByFuel.Text)).ToString();
            else
                this.fuelPayment.Text = "0";
        }

        private void CountTotalPayment_Click(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked == true)
                this.totalPayment.Text = Math.Round(double.Parse(this.fuelPayment.Text) * double.Parse(this.priceByFuel.Text) + double.Parse(this.cafePayment.Text), 2).ToString();
            else
                this.totalPayment.Text = Math.Round(double.Parse(this.fuelPayment.Text) + double.Parse(this.cafePayment.Text), 2).ToString();
        }

        private void HotDog_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                this.hotDogAmount.Enabled = true;
                this.hotDogAmount.ReadOnly = false;
            }
            else
            {
                this.hotDogAmount.Clear();
                this.hotDogAmount.Enabled = false;
                this.hotDogAmount.ReadOnly = true;
            }
        }

        private void Hamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked == true)
            {
                this.hamburgerAmount.Enabled = true;
                this.hamburgerAmount.ReadOnly = false;
            }
            else
            {
                this.hamburgerAmount.Clear();
                this.hamburgerAmount.Enabled = false;
                this.hamburgerAmount.ReadOnly = true;
            }
        }

        private void FrenchFries_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked == true)
            {
                this.frenchFriesAmount.Enabled = true;
                this.frenchFriesAmount.ReadOnly = false;
            }
            else
            {
                this.frenchFriesAmount.Clear();
                this.frenchFriesAmount.Enabled = false;
                this.frenchFriesAmount.ReadOnly = true;
            }
        }

        private void Soda_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox4.Checked == true)
            {
                this.sodaAmount.Enabled = true;
                this.sodaAmount.ReadOnly = false;
            }
            else
            {
                this.sodaAmount.Clear();
                this.sodaAmount.Enabled = false;
                this.sodaAmount.ReadOnly = true;
            }
        }

        private void hotDogAmount_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text != "" && int.Parse(((TextBox)sender).Text) <= maxNumberOfFood)
                this.foodPrice.priceFood[0] = double.Parse(((TextBox)sender).Text) * FoodPriceRatio.foodPrice[FoodPriceRatio.food[0]];
            else
                this.foodPrice.priceFood[0] = 0;
            this.cafePayment.Text = this.foodPrice.SetTotalPrice().ToString();
        }

        private void hamburgerAmount_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text != "" && int.Parse(((TextBox)sender).Text) <= maxNumberOfFood)
                this.foodPrice.priceFood[1] = double.Parse(((TextBox)sender).Text) * FoodPriceRatio.foodPrice[FoodPriceRatio.food[1]];
            else
                this.foodPrice.priceFood[1] = 0;
            this.cafePayment.Text = this.foodPrice.SetTotalPrice().ToString();
        }

        private void frenchFriesAmount_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text != "" && int.Parse(((TextBox)sender).Text) <= maxNumberOfFood)
                this.foodPrice.priceFood[2] = double.Parse(((TextBox)sender).Text) * FoodPriceRatio.foodPrice[FoodPriceRatio.food[2]];
            else
                this.foodPrice.priceFood[2] = 0;
            this.cafePayment.Text = this.foodPrice.SetTotalPrice().ToString();
        }

        private void sodaAmount_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text != "" && int.Parse(((TextBox)sender).Text) <= maxNumberOfFood)
                this.foodPrice.priceFood[3] = double.Parse(((TextBox)sender).Text) * FoodPriceRatio.foodPrice[FoodPriceRatio.food[3]];
            else
                this.foodPrice.priceFood[3] = 0;
            this.cafePayment.Text = this.foodPrice.SetTotalPrice().ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            if (CultureInfo.CurrentCulture.TextInfo.CultureName == "uk-UA")
                this.dateTimeStripStatusLabel1.Text = $"{dateTime.Hour:00}:{dateTime.Minute:00}:{dateTime.Second:00} {dateTime.ToString("dddd", new CultureInfo("uk-UA")).ToUpperFirstChar()}";
            else
                this.dateTimeStripStatusLabel1.Text = $"{dateTime.Hour:00}:{dateTime.Minute:00}:{dateTime.Second:00} {dateTime.DayOfWeek}";
        }

        private void ukrainianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEverything();
            this.toolStripDropDownButton1.Text = "Мова";
            Thread.CurrentThread.CurrentCulture = new CultureInfo("uk-UA");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk-UA");
            ComponentResourceManager manager = new ComponentResourceManager(this.GetType());
            foreach (Control c in this.Controls)
            {
                manager.ApplyResources(c, c.Name);
                foreach (Control child in c.Controls)
                {
                    manager.ApplyResources(child, child.Name);
                    foreach (Control childChild in child.Controls)
                        manager.ApplyResources(childChild, childChild.Name);
                }
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEverything();
            this.toolStripDropDownButton1.Text = "Language";
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-EN");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-EN");
            ComponentResourceManager manager = new ComponentResourceManager(this.GetType());
            foreach (Control c in this.Controls)
            {
                manager.ApplyResources(c, c.Name);
                foreach (Control child in c.Controls)
                {
                    manager.ApplyResources(child, child.Name);
                    foreach (Control childChild in child.Controls)
                        manager.ApplyResources(childChild, childChild.Name);
                }
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
                notifyIcon1.Visible = false;
        }
    }
}