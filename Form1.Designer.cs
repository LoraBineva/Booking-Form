namespace Bineva_L_RestaurantMangmentForm
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
            guests_box = new ComboBox();
            tables_box = new ComboBox();
            restaurant_box = new ComboBox();
            data_grid = new DataGridView();
            search_btn = new Button();
            clear_btn = new Button();
            book_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)data_grid).BeginInit();
            SuspendLayout();
            // 
            // guests_box
            // 
            guests_box.BackColor = Color.LemonChiffon;
            guests_box.FormattingEnabled = true;
            guests_box.Items.AddRange(new object[] { "Number of Guests", "2", "3", "4", "5", "6" });
            guests_box.Location = new Point(287, 88);
            guests_box.Name = "guests_box";
            guests_box.Size = new Size(131, 23);
            guests_box.TabIndex = 0;
            guests_box.Text = "Number of Guests";
            // 
            // tables_box
            // 
            tables_box.BackColor = Color.LemonChiffon;
            tables_box.FormattingEnabled = true;
            tables_box.Items.AddRange(new object[] { "Number of Tables", "1", "2", "3" });
            tables_box.Location = new Point(453, 88);
            tables_box.Name = "tables_box";
            tables_box.Size = new Size(131, 23);
            tables_box.TabIndex = 2;
            tables_box.Text = "Number of Tables";
            // 
            // restaurant_box
            // 
            restaurant_box.BackColor = Color.LemonChiffon;
            restaurant_box.Items.AddRange(new object[] { "Restaurant", "Floret Restaurant and Bar", "Sense Hotel Rooftop", "La Branche" });
            restaurant_box.Location = new Point(119, 88);
            restaurant_box.Name = "restaurant_box";
            restaurant_box.Size = new Size(131, 23);
            restaurant_box.TabIndex = 3;
            restaurant_box.Text = "Restaurant";
            // 
            // data_grid
            // 
            data_grid.BackgroundColor = Color.Khaki;
            data_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_grid.Location = new Point(119, 143);
            data_grid.Name = "data_grid";
            data_grid.RowTemplate.Height = 25;
            data_grid.Size = new Size(465, 135);
            data_grid.TabIndex = 4;
            // 
            // search_btn
            // 
            search_btn.BackColor = Color.LemonChiffon;
            search_btn.Location = new Point(119, 293);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(105, 41);
            search_btn.TabIndex = 5;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += search_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.LemonChiffon;
            clear_btn.Location = new Point(263, 293);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(105, 41);
            clear_btn.TabIndex = 6;
            clear_btn.Text = "Clear Filters";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // book_btn
            // 
            book_btn.BackColor = Color.LemonChiffon;
            book_btn.Location = new Point(479, 293);
            book_btn.Name = "book_btn";
            book_btn.Size = new Size(105, 41);
            book_btn.TabIndex = 7;
            book_btn.Text = "Book";
            book_btn.UseVisualStyleBackColor = false;
            book_btn.Click += book_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cool_colors_colorful_digital_art_simple_background_wallpaper_preview;
            ClientSize = new Size(694, 417);
            Controls.Add(book_btn);
            Controls.Add(clear_btn);
            Controls.Add(search_btn);
            Controls.Add(data_grid);
            Controls.Add(restaurant_box);
            Controls.Add(tables_box);
            Controls.Add(guests_box);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)data_grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox guests_box;
        private ComboBox tables_box;
        private ComboBox restaurant_box;
        private DataGridView data_grid;
        private Button search_btn;
        private Button clear_btn;
        private Button book_btn;
    }
}