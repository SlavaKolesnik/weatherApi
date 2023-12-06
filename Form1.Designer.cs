namespace WeatherApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TbCity = new TextBox();
            label1 = new Label();
            brn_search = new Button();
            lab_condition = new Label();
            lab_detail = new Label();
            label4 = new Label();
            label5 = new Label();
            lab_sunrise = new Label();
            lab_sunset = new Label();
            label8 = new Label();
            label9 = new Label();
            lab_windspeed = new Label();
            lab_pressure = new Label();
            picture_icon = new PictureBox();
            label2 = new Label();
            lab_temp = new Label();
            button1 = new Button();
            btn_save_db = new Button();
            btn_show_data = new Button();
            pct_cat = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picture_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct_cat).BeginInit();
            SuspendLayout();
            // 
            // TbCity
            // 
            TbCity.BackColor = Color.FromArgb(192, 255, 255);
            TbCity.BorderStyle = BorderStyle.None;
            TbCity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TbCity.ForeColor = Color.Black;
            TbCity.Location = new Point(346, 182);
            TbCity.Margin = new Padding(4, 5, 4, 5);
            TbCity.Multiline = true;
            TbCity.Name = "TbCity";
            TbCity.RightToLeft = RightToLeft.Yes;
            TbCity.Size = new Size(341, 50);
            TbCity.TabIndex = 0;
            TbCity.TextAlign = HorizontalAlignment.Center;
            TbCity.TextChanged += TbCity_TextChanged;
            TbCity.Enter += TbCity_Enter;
            TbCity.Leave += TbCity_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(275, 189);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 32);
            label1.TabIndex = 1;
            label1.Text = "City:";
            // 
            // brn_search
            // 
            brn_search.BackColor = Color.Transparent;
            brn_search.Cursor = Cursors.Hand;
            brn_search.FlatStyle = FlatStyle.Flat;
            brn_search.Location = new Point(716, 180);
            brn_search.Margin = new Padding(4, 5, 4, 5);
            brn_search.Name = "brn_search";
            brn_search.Size = new Size(126, 50);
            brn_search.TabIndex = 2;
            brn_search.Text = "Seach";
            brn_search.UseVisualStyleBackColor = false;
            brn_search.Click += button1_Click;
            // 
            // lab_condition
            // 
            lab_condition.AutoSize = true;
            lab_condition.BackColor = Color.Transparent;
            lab_condition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_condition.Location = new Point(455, 366);
            lab_condition.Margin = new Padding(4, 0, 4, 0);
            lab_condition.Name = "lab_condition";
            lab_condition.Size = new Size(134, 32);
            lab_condition.TabIndex = 3;
            lab_condition.Text = "Conditions:";
            lab_condition.Click += lab_condition_Click;
            // 
            // lab_detail
            // 
            lab_detail.AutoSize = true;
            lab_detail.BackColor = Color.Transparent;
            lab_detail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_detail.Location = new Point(259, 366);
            lab_detail.Margin = new Padding(4, 0, 4, 0);
            lab_detail.Name = "lab_detail";
            lab_detail.Size = new Size(76, 32);
            lab_detail.TabIndex = 4;
            lab_detail.Text = "Detail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(263, 501);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 32);
            label4.TabIndex = 5;
            label4.Text = "Sunrise: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(263, 568);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 32);
            label5.TabIndex = 6;
            label5.Text = "Sunset:";
            label5.Click += label5_Click;
            // 
            // lab_sunrise
            // 
            lab_sunrise.AutoSize = true;
            lab_sunrise.BackColor = Color.Transparent;
            lab_sunrise.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_sunrise.Location = new Point(381, 501);
            lab_sunrise.Margin = new Padding(4, 0, 4, 0);
            lab_sunrise.Name = "lab_sunrise";
            lab_sunrise.Size = new Size(56, 32);
            lab_sunrise.TabIndex = 7;
            lab_sunrise.Text = "N/A";
            lab_sunrise.Click += label6_Click;
            // 
            // lab_sunset
            // 
            lab_sunset.AutoSize = true;
            lab_sunset.BackColor = Color.Transparent;
            lab_sunset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_sunset.Location = new Point(381, 568);
            lab_sunset.Margin = new Padding(4, 0, 4, 0);
            lab_sunset.Name = "lab_sunset";
            lab_sunset.Size = new Size(56, 32);
            lab_sunset.TabIndex = 8;
            lab_sunset.Text = "N/A";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(381, 291);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(146, 32);
            label8.TabIndex = 9;
            label8.Text = "Wind speed:";
            label8.UseMnemonic = false;
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(259, 433);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(108, 32);
            label9.TabIndex = 10;
            label9.Text = "Pressure:";
            // 
            // lab_windspeed
            // 
            lab_windspeed.AutoSize = true;
            lab_windspeed.BackColor = Color.Transparent;
            lab_windspeed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_windspeed.Location = new Point(554, 291);
            lab_windspeed.Margin = new Padding(4, 0, 4, 0);
            lab_windspeed.Name = "lab_windspeed";
            lab_windspeed.Size = new Size(56, 32);
            lab_windspeed.TabIndex = 11;
            lab_windspeed.Text = "N/A";
            // 
            // lab_pressure
            // 
            lab_pressure.AutoSize = true;
            lab_pressure.BackColor = Color.Transparent;
            lab_pressure.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_pressure.Location = new Point(381, 433);
            lab_pressure.Margin = new Padding(4, 0, 4, 0);
            lab_pressure.Name = "lab_pressure";
            lab_pressure.Size = new Size(56, 32);
            lab_pressure.TabIndex = 12;
            lab_pressure.Text = "N/A";
            lab_pressure.Click += label11_Click;
            // 
            // picture_icon
            // 
            picture_icon.BackColor = Color.Transparent;
            picture_icon.InitialImage = (Image)resources.GetObject("picture_icon.InitialImage");
            picture_icon.Location = new Point(217, 248);
            picture_icon.Name = "picture_icon";
            picture_icon.Size = new Size(150, 75);
            picture_icon.TabIndex = 13;
            picture_icon.TabStop = false;
            picture_icon.Click += picture_icon_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(381, 248);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 32);
            label2.TabIndex = 14;
            label2.Text = "Temperature:";
            label2.Click += label2_Click;
            // 
            // lab_temp
            // 
            lab_temp.AutoSize = true;
            lab_temp.BackColor = Color.Transparent;
            lab_temp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_temp.Location = new Point(554, 248);
            lab_temp.Margin = new Padding(4, 0, 4, 0);
            lab_temp.Name = "lab_temp";
            lab_temp.Size = new Size(56, 32);
            lab_temp.TabIndex = 15;
            lab_temp.Text = "N/A";
            lab_temp.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1079, 12);
            button1.Name = "button1";
            button1.Size = new Size(63, 49);
            button1.TabIndex = 16;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btn_save_db
            // 
            btn_save_db.BackColor = Color.Transparent;
            btn_save_db.Cursor = Cursors.Hand;
            btn_save_db.FlatStyle = FlatStyle.Flat;
            btn_save_db.Location = new Point(544, 604);
            btn_save_db.Margin = new Padding(4, 5, 4, 5);
            btn_save_db.Name = "btn_save_db";
            btn_save_db.Size = new Size(126, 50);
            btn_save_db.TabIndex = 17;
            btn_save_db.Text = "Save DB";
            btn_save_db.UseVisualStyleBackColor = false;
            btn_save_db.Click += btn_save_db_Click;
            // 
            // btn_show_data
            // 
            btn_show_data.BackColor = Color.Transparent;
            btn_show_data.Cursor = Cursors.Hand;
            btn_show_data.FlatStyle = FlatStyle.Flat;
            btn_show_data.Location = new Point(688, 604);
            btn_show_data.Margin = new Padding(4, 5, 4, 5);
            btn_show_data.Name = "btn_show_data";
            btn_show_data.Size = new Size(126, 50);
            btn_show_data.TabIndex = 18;
            btn_show_data.Text = "Show DB";
            btn_show_data.UseVisualStyleBackColor = false;
            btn_show_data.Click += btn_show_data_Click;
            // 
            // pct_cat
            // 
            pct_cat.BackColor = Color.Transparent;
            pct_cat.Location = new Point(617, 248);
            pct_cat.Name = "pct_cat";
            pct_cat.Size = new Size(365, 305);
            pct_cat.TabIndex = 19;
            pct_cat.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 750);
            Controls.Add(pct_cat);
            Controls.Add(btn_show_data);
            Controls.Add(btn_save_db);
            Controls.Add(button1);
            Controls.Add(lab_temp);
            Controls.Add(label2);
            Controls.Add(picture_icon);
            Controls.Add(lab_pressure);
            Controls.Add(lab_windspeed);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(lab_sunset);
            Controls.Add(lab_sunrise);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lab_detail);
            Controls.Add(lab_condition);
            Controls.Add(brn_search);
            Controls.Add(label1);
            Controls.Add(TbCity);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picture_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pct_cat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbCity;
        private Label label1;
        private Button brn_search;
        private Label lab_condition;
        private Label lab_detail;
        private Label label4;
        private Label label5;
        private Label lab_sunrise;
        private Label lab_sunset;
        private Label label8;
        private Label label9;
        private Label lab_windspeed;
        private Label lab_pressure;
        private PictureBox picture_icon;
        private Label label2;
        private Label lab_temp;
        private Button button1;
        private Button btn_save_db;
        private Button btn_show_data;
        private PictureBox pct_cat;
    }
}