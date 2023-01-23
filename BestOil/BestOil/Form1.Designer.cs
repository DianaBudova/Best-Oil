namespace BestOil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fuelPayment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sumUAH = new System.Windows.Forms.TextBox();
            this.literAmount = new System.Windows.Forms.TextBox();
            this.FillCarBy = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceByFuel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cafePayment = new System.Windows.Forms.TextBox();
            this.sodaAmount = new System.Windows.Forms.TextBox();
            this.sodaPrice = new System.Windows.Forms.TextBox();
            this.frenchFriesAmount = new System.Windows.Forms.TextBox();
            this.frenchFriesPrice = new System.Windows.Forms.TextBox();
            this.hamburgerAmount = new System.Windows.Forms.TextBox();
            this.hamburgerPrice = new System.Windows.Forms.TextBox();
            this.hotDogAmount = new System.Windows.Forms.TextBox();
            this.hotDogPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.totalPayment = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dateTimeStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ukrainianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.FillCarBy.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sumUAH);
            this.groupBox1.Controls.Add(this.literAmount);
            this.groupBox1.Controls.Add(this.FillCarBy);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.priceByFuel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.fuelPayment);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // fuelPayment
            // 
            resources.ApplyResources(this.fuelPayment, "fuelPayment");
            this.fuelPayment.Name = "fuelPayment";
            this.fuelPayment.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // sumUAH
            // 
            resources.ApplyResources(this.sumUAH, "sumUAH");
            this.sumUAH.Name = "sumUAH";
            this.sumUAH.ReadOnly = true;
            this.sumUAH.TextChanged += new System.EventHandler(this.SetLiters_TextChanged);
            // 
            // literAmount
            // 
            resources.ApplyResources(this.literAmount, "literAmount");
            this.literAmount.Name = "literAmount";
            this.literAmount.ReadOnly = true;
            this.literAmount.TextChanged += new System.EventHandler(this.SetPrice_TextChanged);
            // 
            // FillCarBy
            // 
            resources.ApplyResources(this.FillCarBy, "FillCarBy");
            this.FillCarBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FillCarBy.Controls.Add(this.radioButton2);
            this.FillCarBy.Controls.Add(this.radioButton1);
            this.FillCarBy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FillCarBy.Name = "FillCarBy";
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.FillCarBy_CheckedChanged);
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.FillCarBy_CheckedChanged);
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.TextChanged += new System.EventHandler(this.ChooseFuel_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // priceByFuel
            // 
            resources.ApplyResources(this.priceByFuel, "priceByFuel");
            this.priceByFuel.Name = "priceByFuel";
            this.priceByFuel.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.sodaAmount);
            this.groupBox2.Controls.Add(this.sodaPrice);
            this.groupBox2.Controls.Add(this.frenchFriesAmount);
            this.groupBox2.Controls.Add(this.frenchFriesPrice);
            this.groupBox2.Controls.Add(this.hamburgerAmount);
            this.groupBox2.Controls.Add(this.hamburgerPrice);
            this.groupBox2.Controls.Add(this.hotDogAmount);
            this.groupBox2.Controls.Add(this.hotDogPrice);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.cafePayment);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // cafePayment
            // 
            resources.ApplyResources(this.cafePayment, "cafePayment");
            this.cafePayment.Name = "cafePayment";
            this.cafePayment.ReadOnly = true;
            // 
            // sodaAmount
            // 
            resources.ApplyResources(this.sodaAmount, "sodaAmount");
            this.sodaAmount.Name = "sodaAmount";
            this.sodaAmount.ReadOnly = true;
            this.sodaAmount.TextChanged += new System.EventHandler(this.sodaAmount_TextChanged);
            // 
            // sodaPrice
            // 
            resources.ApplyResources(this.sodaPrice, "sodaPrice");
            this.sodaPrice.Name = "sodaPrice";
            this.sodaPrice.ReadOnly = true;
            // 
            // frenchFriesAmount
            // 
            resources.ApplyResources(this.frenchFriesAmount, "frenchFriesAmount");
            this.frenchFriesAmount.Name = "frenchFriesAmount";
            this.frenchFriesAmount.ReadOnly = true;
            this.frenchFriesAmount.TextChanged += new System.EventHandler(this.frenchFriesAmount_TextChanged);
            // 
            // frenchFriesPrice
            // 
            resources.ApplyResources(this.frenchFriesPrice, "frenchFriesPrice");
            this.frenchFriesPrice.Name = "frenchFriesPrice";
            this.frenchFriesPrice.ReadOnly = true;
            // 
            // hamburgerAmount
            // 
            resources.ApplyResources(this.hamburgerAmount, "hamburgerAmount");
            this.hamburgerAmount.Name = "hamburgerAmount";
            this.hamburgerAmount.ReadOnly = true;
            this.hamburgerAmount.TextChanged += new System.EventHandler(this.hamburgerAmount_TextChanged);
            // 
            // hamburgerPrice
            // 
            resources.ApplyResources(this.hamburgerPrice, "hamburgerPrice");
            this.hamburgerPrice.Name = "hamburgerPrice";
            this.hamburgerPrice.ReadOnly = true;
            // 
            // hotDogAmount
            // 
            resources.ApplyResources(this.hotDogAmount, "hotDogAmount");
            this.hotDogAmount.Name = "hotDogAmount";
            this.hotDogAmount.ReadOnly = true;
            this.hotDogAmount.TextChanged += new System.EventHandler(this.hotDogAmount_TextChanged);
            // 
            // hotDogPrice
            // 
            resources.ApplyResources(this.hotDogPrice, "hotDogPrice");
            this.hotDogPrice.Name = "hotDogPrice";
            this.hotDogPrice.ReadOnly = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // checkBox4
            // 
            resources.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.Soda_CheckedChanged);
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.FrenchFries_CheckedChanged);
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.Hamburger_CheckedChanged);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.HotDog_CheckedChanged);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.totalPayment);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CountTotalPayment_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // totalPayment
            // 
            resources.ApplyResources(this.totalPayment, "totalPayment");
            this.totalPayment.Name = "totalPayment";
            this.totalPayment.ReadOnly = true;
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateTimeStripStatusLabel1,
            this.toolStripDropDownButton1});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // dateTimeStripStatusLabel1
            // 
            resources.ApplyResources(this.dateTimeStripStatusLabel1, "dateTimeStripStatusLabel1");
            this.dateTimeStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimeStripStatusLabel1.Name = "dateTimeStripStatusLabel1";
            // 
            // toolStripDropDownButton1
            // 
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ukrainianToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            // 
            // ukrainianToolStripMenuItem
            // 
            resources.ApplyResources(this.ukrainianToolStripMenuItem, "ukrainianToolStripMenuItem");
            this.ukrainianToolStripMenuItem.Name = "ukrainianToolStripMenuItem";
            this.ukrainianToolStripMenuItem.Click += new System.EventHandler(this.ukrainianToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.FillCarBy.ResumeLayout(false);
            this.FillCarBy.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox priceByFuel;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private TextBox sumUAH;
        private TextBox literAmount;
        private Panel FillCarBy;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox4;
        private Label label6;
        private TextBox fuelPayment;
        private TextBox sodaAmount;
        private TextBox sodaPrice;
        private TextBox frenchFriesAmount;
        private TextBox frenchFriesPrice;
        private TextBox hamburgerAmount;
        private TextBox hamburgerPrice;
        private TextBox hotDogAmount;
        private TextBox hotDogPrice;
        private Label label8;
        private Label label7;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox5;
        private Label label9;
        private TextBox cafePayment;
        private Button button1;
        private Label label10;
        private TextBox totalPayment;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel dateTimeStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem ukrainianToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private NotifyIcon notifyIcon1;
    }
}