namespace Bineva_L_RestaurantMangmentForm
{
    partial class Form2
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
            name = new TextBox();
            phone = new TextBox();
            time = new ComboBox();
            table_num = new ComboBox();
            reserve_btn = new Button();
            restaurant = new ComboBox();
            SuspendLayout();
            // 
            // name
            // 
            name.BackColor = Color.LemonChiffon;
            name.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            name.ForeColor = SystemColors.MenuText;
            name.Location = new Point(252, 37);
            name.Name = "name";
            name.PlaceholderText = "Name:";
            name.Size = new Size(227, 27);
            name.TabIndex = 0;
            // 
            // phone
            // 
            phone.BackColor = Color.LemonChiffon;
            phone.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            phone.ForeColor = SystemColors.MenuText;
            phone.Location = new Point(253, 82);
            phone.Name = "phone";
            phone.PlaceholderText = "Phone:";
            phone.Size = new Size(227, 27);
            phone.TabIndex = 1;
            // 
            // time
            // 
            time.BackColor = Color.LemonChiffon;
            time.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            time.Items.AddRange(new object[] { "Time ", "18:00", "18:30", "19:00", "19:30", "20:00", "21:00", "22:00" });
            time.Location = new Point(253, 128);
            time.Name = "time";
            time.Size = new Size(227, 28);
            time.TabIndex = 4;
            time.Text = "Time";
            // 
            // table_num
            // 
            table_num.BackColor = Color.LemonChiffon;
            table_num.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            table_num.Items.AddRange(new object[] { "Table", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21" });
            table_num.Location = new Point(252, 180);
            table_num.Name = "table_num";
            table_num.Size = new Size(227, 28);
            table_num.TabIndex = 5;
            table_num.Text = "Table";
            // 
            // reserve_btn
            // 
            reserve_btn.BackColor = Color.LemonChiffon;
            reserve_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            reserve_btn.Location = new Point(252, 279);
            reserve_btn.Name = "reserve_btn";
            reserve_btn.Size = new Size(228, 51);
            reserve_btn.TabIndex = 6;
            reserve_btn.Text = "Reserve";
            reserve_btn.UseVisualStyleBackColor = false;
            reserve_btn.Click += reserve_btn_Click;
            // 
            // restaurant
            // 
            restaurant.BackColor = Color.LemonChiffon;
            restaurant.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            restaurant.Items.AddRange(new object[] { "Restaurant", "Floret Restaurant and Bar", "Sense Hotel Rooftop", "La Branche" });
            restaurant.Location = new Point(252, 231);
            restaurant.Name = "restaurant";
            restaurant.Size = new Size(227, 28);
            restaurant.TabIndex = 7;
            restaurant.Text = "Restaurant";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cool_colors_colorful_digital_art_simple_background_wallpaper_preview;
            ClientSize = new Size(734, 412);
            Controls.Add(restaurant);
            Controls.Add(reserve_btn);
            Controls.Add(table_num);
            Controls.Add(time);
            Controls.Add(phone);
            Controls.Add(name);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private TextBox phone;
        private ComboBox time;
        private ComboBox table_num;
        private Button reserve_btn;
        private ComboBox restaurant;
    }
}