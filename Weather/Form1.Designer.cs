namespace Weather
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.prognoz = new System.Windows.Forms.Button();
            this.city = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.осади = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.temp = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.cloudiness = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.radioButtonLight = new System.Windows.Forms.RadioButton();
            this.radioButtonDark = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // prognoz
            // 
            this.prognoz.Location = new System.Drawing.Point(145, 264);
            this.prognoz.Name = "prognoz";
            this.prognoz.Size = new System.Drawing.Size(125, 61);
            this.prognoz.TabIndex = 0;
            this.prognoz.Text = "Forecast";
            this.prognoz.UseVisualStyleBackColor = true;
            this.prognoz.Click += new System.EventHandler(this.prognoz_Click_1);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(120, 40);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(205, 20);
            this.city.TabIndex = 1;
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(190, 116);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(27, 13);
            this.min.TabIndex = 2;
            this.min.Text = "Min:";
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Location = new System.Drawing.Point(187, 139);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(33, 13);
            this.max.TabIndex = 3;
            this.max.Text = "Max: ";
            // 
            // осади
            // 
            this.осади.AutoSize = true;
            this.осади.Location = new System.Drawing.Point(190, 212);
            this.осади.Name = "осади";
            this.осади.Size = new System.Drawing.Size(32, 13);
            this.осади.TabIndex = 5;
            this.осади.Text = "Rain:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Location = new System.Drawing.Point(189, 94);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(37, 13);
            this.temp.TabIndex = 6;
            this.temp.Text = "Temp:";
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.Location = new System.Drawing.Point(187, 162);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(46, 13);
            this.humidity.TabIndex = 7;
            this.humidity.Text = "Humid.: ";
            // 
            // cloudiness
            // 
            this.cloudiness.AutoSize = true;
            this.cloudiness.Location = new System.Drawing.Point(187, 185);
            this.cloudiness.Name = "cloudiness";
            this.cloudiness.Size = new System.Drawing.Size(45, 13);
            this.cloudiness.TabIndex = 8;
            this.cloudiness.Text = "Clouds: ";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(185, 235);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 9;
            this.descriptionLabel.Text = "Description:";
            // 
            // radioButtonLight
            // 
            this.radioButtonLight.AutoSize = true;
            this.radioButtonLight.Location = new System.Drawing.Point(353, 161);
            this.radioButtonLight.Name = "radioButtonLight";
            this.radioButtonLight.Size = new System.Drawing.Size(80, 17);
            this.radioButtonLight.TabIndex = 10;
            this.radioButtonLight.TabStop = true;
            this.radioButtonLight.Text = "Light theme";
            this.radioButtonLight.UseVisualStyleBackColor = true;
            this.radioButtonLight.CheckedChanged += new System.EventHandler(this.radioButtonLight_CheckedChanged);
            // 
            // radioButtonDark
            // 
            this.radioButtonDark.AutoSize = true;
            this.radioButtonDark.Location = new System.Drawing.Point(353, 185);
            this.radioButtonDark.Name = "radioButtonDark";
            this.radioButtonDark.Size = new System.Drawing.Size(80, 17);
            this.radioButtonDark.TabIndex = 11;
            this.radioButtonDark.TabStop = true;
            this.radioButtonDark.Text = "Dark theme";
            this.radioButtonDark.UseVisualStyleBackColor = true;
            this.radioButtonDark.CheckedChanged += new System.EventHandler(this.radioButtonDark_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 416);
            this.Controls.Add(this.radioButtonDark);
            this.Controls.Add(this.radioButtonLight);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.cloudiness);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.осади);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.city);
            this.Controls.Add(this.prognoz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prognoz;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label осади;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label cloudiness;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RadioButton radioButtonLight;
        private System.Windows.Forms.RadioButton radioButtonDark;
    }
}

