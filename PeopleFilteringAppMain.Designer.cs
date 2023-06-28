namespace PeopleFilteringApp
{
    partial class peopleFilteringAppMain
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
            this.gv_Data = new System.Windows.Forms.DataGridView();
            this.cbox_City = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_Country = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbox_Zip = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cbox_SearchField = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Data
            // 
            this.gv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Data.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Data.GridColor = System.Drawing.Color.White;
            this.gv_Data.Location = new System.Drawing.Point(22, 170);
            this.gv_Data.Name = "gv_Data";
            this.gv_Data.Size = new System.Drawing.Size(487, 193);
            this.gv_Data.TabIndex = 0;
            // 
            // cbox_City
            // 
            this.cbox_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_City.FormattingEnabled = true;
            this.cbox_City.ItemHeight = 20;
            this.cbox_City.Location = new System.Drawing.Point(22, 126);
            this.cbox_City.Name = "cbox_City";
            this.cbox_City.Size = new System.Drawing.Size(159, 28);
            this.cbox_City.TabIndex = 1;
            this.cbox_City.SelectedIndexChanged += new System.EventHandler(this.cbox_City_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "City";
            // 
            // cbox_Country
            // 
            this.cbox_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Country.FormattingEnabled = true;
            this.cbox_Country.ItemHeight = 20;
            this.cbox_Country.Location = new System.Drawing.Point(187, 126);
            this.cbox_Country.Name = "cbox_Country";
            this.cbox_Country.Size = new System.Drawing.Size(161, 28);
            this.cbox_Country.TabIndex = 3;
            this.cbox_Country.SelectedIndexChanged += new System.EventHandler(this.cbox_Country_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zip Code";
            // 
            // cbox_Zip
            // 
            this.cbox_Zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Zip.FormattingEnabled = true;
            this.cbox_Zip.ItemHeight = 20;
            this.cbox_Zip.Location = new System.Drawing.Point(354, 126);
            this.cbox_Zip.Name = "cbox_Zip";
            this.cbox_Zip.Size = new System.Drawing.Size(155, 28);
            this.cbox_Zip.TabIndex = 5;
            this.cbox_Zip.SelectedIndexChanged += new System.EventHandler(this.cbox_Zip_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Search By";
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(88, 373);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(152, 38);
            this.btn_Previous.TabIndex = 9;
            this.btn_Previous.Text = "Previous ";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(302, 373);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(152, 38);
            this.btn_Next.TabIndex = 10;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(22, 64);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(487, 29);
            this.txt_Search.TabIndex = 11;
            this.txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_KeyPress);
            // 
            // cbox_SearchField
            // 
            this.cbox_SearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_SearchField.FormattingEnabled = true;
            this.cbox_SearchField.Items.AddRange(new object[] {
            "Name",
            "City",
            "Country",
            "Zip"});
            this.cbox_SearchField.Location = new System.Drawing.Point(106, 19);
            this.cbox_SearchField.Name = "cbox_SearchField";
            this.cbox_SearchField.Size = new System.Drawing.Size(121, 32);
            this.cbox_SearchField.TabIndex = 12;
            // 
            // peopleFilteringAppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 422);
            this.Controls.Add(this.cbox_SearchField);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbox_Zip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbox_Country);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_City);
            this.Controls.Add(this.gv_Data);
            this.Name = "peopleFilteringAppMain";
            this.Text = "People Filtering App";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Data;
        private System.Windows.Forms.ComboBox cbox_City;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_Country;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbox_Zip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox cbox_SearchField;
    }
}

