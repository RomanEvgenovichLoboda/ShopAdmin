
namespace ShopAdmin.GUI
{
    partial class GoodPanel
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.price_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.company_label = new System.Windows.Forms.Label();
            this.flash_label = new System.Windows.Forms.Label();
            this.processor_label = new System.Windows.Forms.Label();
            this.ssd_label = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxProessor = new System.Windows.Forms.TextBox();
            this.textBoxSSD = new System.Windows.Forms.TextBox();
            this.textBoxFlash = new System.Windows.Forms.TextBox();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonEdit.Location = new System.Drawing.Point(230, 270);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(154, 56);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(255, 27);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(130, 22);
            this.textBoxName.TabIndex = 18;
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_label.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.price_label.Location = new System.Drawing.Point(172, 220);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(95, 25);
            this.price_label.TabIndex = 14;
            this.price_label.Text = "Price (₴)";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.ForeColor = System.Drawing.Color.Blue;
            this.name_label.Location = new System.Drawing.Point(174, 32);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 17);
            this.name_label.TabIndex = 9;
            this.name_label.Text = "Name";
            // 
            // company_label
            // 
            this.company_label.AutoSize = true;
            this.company_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.company_label.ForeColor = System.Drawing.Color.Blue;
            this.company_label.Location = new System.Drawing.Point(174, 67);
            this.company_label.Name = "company_label";
            this.company_label.Size = new System.Drawing.Size(74, 17);
            this.company_label.TabIndex = 10;
            this.company_label.Text = "Company";
            // 
            // flash_label
            // 
            this.flash_label.AutoSize = true;
            this.flash_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flash_label.ForeColor = System.Drawing.Color.Blue;
            this.flash_label.Location = new System.Drawing.Point(174, 104);
            this.flash_label.Name = "flash_label";
            this.flash_label.Size = new System.Drawing.Size(85, 17);
            this.flash_label.TabIndex = 11;
            this.flash_label.Text = "Flash (Gb)";
            // 
            // processor_label
            // 
            this.processor_label.AutoSize = true;
            this.processor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.processor_label.ForeColor = System.Drawing.Color.Blue;
            this.processor_label.Location = new System.Drawing.Point(174, 170);
            this.processor_label.Name = "processor_label";
            this.processor_label.Size = new System.Drawing.Size(140, 17);
            this.processor_label.TabIndex = 13;
            this.processor_label.Text = "Processor (Cores)";
            // 
            // ssd_label
            // 
            this.ssd_label.AutoSize = true;
            this.ssd_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ssd_label.ForeColor = System.Drawing.Color.Blue;
            this.ssd_label.Location = new System.Drawing.Point(174, 138);
            this.ssd_label.Name = "ssd_label";
            this.ssd_label.Size = new System.Drawing.Size(77, 17);
            this.ssd_label.TabIndex = 12;
            this.ssd_label.Text = "SSD (Gb)";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(273, 224);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(111, 22);
            this.textBoxPrice.TabIndex = 29;
            // 
            // textBoxProessor
            // 
            this.textBoxProessor.Location = new System.Drawing.Point(320, 170);
            this.textBoxProessor.Name = "textBoxProessor";
            this.textBoxProessor.Size = new System.Drawing.Size(64, 22);
            this.textBoxProessor.TabIndex = 28;
            // 
            // textBoxSSD
            // 
            this.textBoxSSD.Location = new System.Drawing.Point(278, 133);
            this.textBoxSSD.Name = "textBoxSSD";
            this.textBoxSSD.Size = new System.Drawing.Size(107, 22);
            this.textBoxSSD.TabIndex = 27;
            // 
            // textBoxFlash
            // 
            this.textBoxFlash.Location = new System.Drawing.Point(278, 99);
            this.textBoxFlash.Name = "textBoxFlash";
            this.textBoxFlash.Size = new System.Drawing.Size(106, 22);
            this.textBoxFlash.TabIndex = 26;
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Location = new System.Drawing.Point(254, 62);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(130, 22);
            this.textBoxCompany.TabIndex = 25;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.ForeColor = System.Drawing.Color.Crimson;
            this.buttonRemove.Location = new System.Drawing.Point(8, 270);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(193, 56);
            this.buttonRemove.TabIndex = 30;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(8, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // GoodPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxProessor);
            this.Controls.Add(this.textBoxSSD);
            this.Controls.Add(this.textBoxFlash);
            this.Controls.Add(this.textBoxCompany);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.processor_label);
            this.Controls.Add(this.ssd_label);
            this.Controls.Add(this.flash_label);
            this.Controls.Add(this.company_label);
            this.Controls.Add(this.name_label);
            this.Name = "GoodPanel";
            this.Size = new System.Drawing.Size(396, 346);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label company_label;
        private System.Windows.Forms.Label flash_label;
        private System.Windows.Forms.Label processor_label;
        private System.Windows.Forms.Label ssd_label;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxProessor;
        private System.Windows.Forms.TextBox textBoxSSD;
        private System.Windows.Forms.TextBox textBoxFlash;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.Button buttonRemove;
    }
}
