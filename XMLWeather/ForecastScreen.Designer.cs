namespace XMLWeather
{
    partial class ForecastScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.min1 = new System.Windows.Forms.Label();
            this.max1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.min2 = new System.Windows.Forms.Label();
            this.max2 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.min3 = new System.Windows.Forms.Label();
            this.max3 = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.min4 = new System.Windows.Forms.Label();
            this.max4 = new System.Windows.Forms.Label();
            this.date4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.min5 = new System.Windows.Forms.Label();
            this.max5 = new System.Windows.Forms.Label();
            this.date5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.conditionOutput1 = new System.Windows.Forms.Label();
            this.conditionOutput2 = new System.Windows.Forms.Label();
            this.conditionOutput3 = new System.Windows.Forms.Label();
            this.conditionOutput4 = new System.Windows.Forms.Label();
            this.conditionOutput5 = new System.Windows.Forms.Label();
            this.citySearchInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.cityOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(462, 14);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "5 Day";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // min1
            // 
            this.min1.BackColor = System.Drawing.Color.White;
            this.min1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min1.Location = new System.Drawing.Point(39, 237);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(38, 20);
            this.min1.TabIndex = 48;
            this.min1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max1
            // 
            this.max1.BackColor = System.Drawing.Color.White;
            this.max1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max1.Location = new System.Drawing.Point(39, 200);
            this.max1.Name = "max1";
            this.max1.Size = new System.Drawing.Size(38, 20);
            this.max1.TabIndex = 45;
            this.max1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(446, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 63;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // date1
            // 
            this.date1.BackColor = System.Drawing.Color.Gray;
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.ForeColor = System.Drawing.Color.White;
            this.date1.Location = new System.Drawing.Point(7, 52);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(98, 26);
            this.date1.TabIndex = 64;
            this.date1.Text = "Date";
            this.date1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(7, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 217);
            this.label1.TabIndex = 75;
            // 
            // min2
            // 
            this.min2.BackColor = System.Drawing.Color.White;
            this.min2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min2.Location = new System.Drawing.Point(154, 237);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(38, 20);
            this.min2.TabIndex = 78;
            this.min2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max2
            // 
            this.max2.BackColor = System.Drawing.Color.White;
            this.max2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max2.Location = new System.Drawing.Point(154, 200);
            this.max2.Name = "max2";
            this.max2.Size = new System.Drawing.Size(38, 20);
            this.max2.TabIndex = 77;
            this.max2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date2
            // 
            this.date2.BackColor = System.Drawing.Color.Gray;
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.ForeColor = System.Drawing.Color.White;
            this.date2.Location = new System.Drawing.Point(122, 52);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(98, 26);
            this.date2.TabIndex = 79;
            this.date2.Text = "Date";
            this.date2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(122, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 217);
            this.label12.TabIndex = 80;
            // 
            // min3
            // 
            this.min3.BackColor = System.Drawing.Color.White;
            this.min3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min3.Location = new System.Drawing.Point(269, 237);
            this.min3.Name = "min3";
            this.min3.Size = new System.Drawing.Size(38, 20);
            this.min3.TabIndex = 83;
            this.min3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max3
            // 
            this.max3.BackColor = System.Drawing.Color.White;
            this.max3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max3.Location = new System.Drawing.Point(269, 200);
            this.max3.Name = "max3";
            this.max3.Size = new System.Drawing.Size(38, 20);
            this.max3.TabIndex = 82;
            this.max3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date3
            // 
            this.date3.BackColor = System.Drawing.Color.Gray;
            this.date3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date3.ForeColor = System.Drawing.Color.White;
            this.date3.Location = new System.Drawing.Point(237, 52);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(98, 26);
            this.date3.TabIndex = 84;
            this.date3.Text = "Date";
            this.date3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(237, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 217);
            this.label9.TabIndex = 85;
            // 
            // min4
            // 
            this.min4.BackColor = System.Drawing.Color.White;
            this.min4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min4.Location = new System.Drawing.Point(383, 237);
            this.min4.Name = "min4";
            this.min4.Size = new System.Drawing.Size(38, 20);
            this.min4.TabIndex = 88;
            this.min4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max4
            // 
            this.max4.BackColor = System.Drawing.Color.White;
            this.max4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max4.Location = new System.Drawing.Point(383, 200);
            this.max4.Name = "max4";
            this.max4.Size = new System.Drawing.Size(38, 20);
            this.max4.TabIndex = 87;
            this.max4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date4
            // 
            this.date4.BackColor = System.Drawing.Color.Gray;
            this.date4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date4.ForeColor = System.Drawing.Color.White;
            this.date4.Location = new System.Drawing.Point(351, 52);
            this.date4.Name = "date4";
            this.date4.Size = new System.Drawing.Size(98, 26);
            this.date4.TabIndex = 89;
            this.date4.Text = "Date";
            this.date4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(351, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 217);
            this.label11.TabIndex = 90;
            // 
            // min5
            // 
            this.min5.BackColor = System.Drawing.Color.White;
            this.min5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min5.Location = new System.Drawing.Point(495, 237);
            this.min5.Name = "min5";
            this.min5.Size = new System.Drawing.Size(38, 20);
            this.min5.TabIndex = 93;
            this.min5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max5
            // 
            this.max5.BackColor = System.Drawing.Color.White;
            this.max5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max5.Location = new System.Drawing.Point(495, 200);
            this.max5.Name = "max5";
            this.max5.Size = new System.Drawing.Size(38, 20);
            this.max5.TabIndex = 92;
            this.max5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date5
            // 
            this.date5.BackColor = System.Drawing.Color.Gray;
            this.date5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date5.ForeColor = System.Drawing.Color.White;
            this.date5.Location = new System.Drawing.Point(463, 52);
            this.date5.Name = "date5";
            this.date5.Size = new System.Drawing.Size(98, 26);
            this.date5.TabIndex = 94;
            this.date5.Text = "Date";
            this.date5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(463, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 217);
            this.label14.TabIndex = 95;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(27, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(141, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 97;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(258, 99);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 98;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(368, 99);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 99;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(482, 99);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(63, 62);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 100;
            this.pictureBox5.TabStop = false;
            // 
            // conditionOutput1
            // 
            this.conditionOutput1.BackColor = System.Drawing.Color.White;
            this.conditionOutput1.Location = new System.Drawing.Point(8, 164);
            this.conditionOutput1.Name = "conditionOutput1";
            this.conditionOutput1.Size = new System.Drawing.Size(98, 24);
            this.conditionOutput1.TabIndex = 101;
            this.conditionOutput1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conditionOutput2
            // 
            this.conditionOutput2.BackColor = System.Drawing.Color.White;
            this.conditionOutput2.Location = new System.Drawing.Point(122, 164);
            this.conditionOutput2.Name = "conditionOutput2";
            this.conditionOutput2.Size = new System.Drawing.Size(98, 24);
            this.conditionOutput2.TabIndex = 102;
            this.conditionOutput2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conditionOutput3
            // 
            this.conditionOutput3.BackColor = System.Drawing.Color.White;
            this.conditionOutput3.Location = new System.Drawing.Point(237, 164);
            this.conditionOutput3.Name = "conditionOutput3";
            this.conditionOutput3.Size = new System.Drawing.Size(98, 24);
            this.conditionOutput3.TabIndex = 103;
            this.conditionOutput3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conditionOutput4
            // 
            this.conditionOutput4.BackColor = System.Drawing.Color.White;
            this.conditionOutput4.Location = new System.Drawing.Point(352, 164);
            this.conditionOutput4.Name = "conditionOutput4";
            this.conditionOutput4.Size = new System.Drawing.Size(98, 24);
            this.conditionOutput4.TabIndex = 104;
            this.conditionOutput4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conditionOutput5
            // 
            this.conditionOutput5.BackColor = System.Drawing.Color.White;
            this.conditionOutput5.Location = new System.Drawing.Point(463, 164);
            this.conditionOutput5.Name = "conditionOutput5";
            this.conditionOutput5.Size = new System.Drawing.Size(98, 24);
            this.conditionOutput5.TabIndex = 105;
            this.conditionOutput5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // citySearchInput
            // 
            this.citySearchInput.Location = new System.Drawing.Point(237, 15);
            this.citySearchInput.Name = "citySearchInput";
            this.citySearchInput.Size = new System.Drawing.Size(130, 20);
            this.citySearchInput.TabIndex = 106;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(373, 14);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(77, 21);
            this.searchButton.TabIndex = 107;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cityOutput
            // 
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(111, 14);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(109, 28);
            this.cityOutput.TabIndex = 108;
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.citySearchInput);
            this.Controls.Add(this.conditionOutput5);
            this.Controls.Add(this.conditionOutput4);
            this.Controls.Add(this.conditionOutput3);
            this.Controls.Add(this.conditionOutput2);
            this.Controls.Add(this.conditionOutput1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.min5);
            this.Controls.Add(this.max5);
            this.Controls.Add(this.date5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.min4);
            this.Controls.Add(this.max4);
            this.Controls.Add(this.date4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.min3);
            this.Controls.Add(this.max3);
            this.Controls.Add(this.date3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.min2);
            this.Controls.Add(this.max2);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.max1);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(564, 279);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label min1;
        private System.Windows.Forms.Label max1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label min2;
        private System.Windows.Forms.Label max2;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label min3;
        private System.Windows.Forms.Label max3;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label min4;
        private System.Windows.Forms.Label max4;
        private System.Windows.Forms.Label date4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label min5;
        private System.Windows.Forms.Label max5;
        private System.Windows.Forms.Label date5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label conditionOutput1;
        private System.Windows.Forms.Label conditionOutput2;
        private System.Windows.Forms.Label conditionOutput3;
        private System.Windows.Forms.Label conditionOutput4;
        private System.Windows.Forms.Label conditionOutput5;
        private System.Windows.Forms.TextBox citySearchInput;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label cityOutput;
    }
}
