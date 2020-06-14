namespace WindowsFormsPresentationLayerMyBike
{
    partial class Form1
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
            this.bikeType = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.button_mountainbike = new System.Windows.Forms.Button();
            this.textBoxSearchBike = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button_roadbike = new System.Windows.Forms.Button();
            this.button_DisplayAllBike = new System.Windows.Forms.Button();
            this.button_Read = new System.Windows.Forms.Button();
            this.button_Write = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.comboBoxSuspensionType = new System.Windows.Forms.ComboBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxSeatHeight = new System.Windows.Forms.TextBox();
            this.textBoxGears = new System.Windows.Forms.TextBox();
            this.textBoxGroundHeight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxWarrenty = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.textBoxSeialNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bikeType
            // 
            this.bikeType.FormattingEnabled = true;
            this.bikeType.Location = new System.Drawing.Point(136, 12);
            this.bikeType.Margin = new System.Windows.Forms.Padding(2);
            this.bikeType.Name = "bikeType";
            this.bikeType.Size = new System.Drawing.Size(147, 21);
            this.bikeType.TabIndex = 111;
            this.bikeType.SelectedIndexChanged += new System.EventHandler(this.bikeType_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 15);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 13);
            this.label23.TabIndex = 110;
            this.label23.Text = "Bike Type";
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.Location = new System.Drawing.Point(16, 305);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(1077, 134);
            this.listBoxDisplay.TabIndex = 101;
            // 
            // button_mountainbike
            // 
            this.button_mountainbike.Location = new System.Drawing.Point(662, 230);
            this.button_mountainbike.Name = "button_mountainbike";
            this.button_mountainbike.Size = new System.Drawing.Size(130, 23);
            this.button_mountainbike.TabIndex = 100;
            this.button_mountainbike.Text = "Display_MountainBike";
            this.button_mountainbike.UseVisualStyleBackColor = true;
            this.button_mountainbike.Click += new System.EventHandler(this.button_mountainbike_Click);
            // 
            // textBoxSearchBike
            // 
            this.textBoxSearchBike.Location = new System.Drawing.Point(403, 279);
            this.textBoxSearchBike.Name = "textBoxSearchBike";
            this.textBoxSearchBike.Size = new System.Drawing.Size(121, 20);
            this.textBoxSearchBike.TabIndex = 99;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(554, 276);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 98;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(276, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 97;
            this.label14.Text = "Bike SerialNumber";
            // 
            // button_roadbike
            // 
            this.button_roadbike.Location = new System.Drawing.Point(672, 259);
            this.button_roadbike.Name = "button_roadbike";
            this.button_roadbike.Size = new System.Drawing.Size(102, 23);
            this.button_roadbike.TabIndex = 96;
            this.button_roadbike.Text = "Dislpay RoadBike";
            this.button_roadbike.UseVisualStyleBackColor = true;
            this.button_roadbike.Click += new System.EventHandler(this.button_roadbike_Click);
            // 
            // button_DisplayAllBike
            // 
            this.button_DisplayAllBike.Location = new System.Drawing.Point(672, 197);
            this.button_DisplayAllBike.Name = "button_DisplayAllBike";
            this.button_DisplayAllBike.Size = new System.Drawing.Size(110, 23);
            this.button_DisplayAllBike.TabIndex = 95;
            this.button_DisplayAllBike.Text = "Display All Bike";
            this.button_DisplayAllBike.UseVisualStyleBackColor = true;
            this.button_DisplayAllBike.Click += new System.EventHandler(this.button_DisplayAllBike_Click);
            // 
            // button_Read
            // 
            this.button_Read.Location = new System.Drawing.Point(686, 162);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(88, 23);
            this.button_Read.TabIndex = 94;
            this.button_Read.Text = "Read From File";
            this.button_Read.UseVisualStyleBackColor = true;
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // button_Write
            // 
            this.button_Write.Location = new System.Drawing.Point(686, 129);
            this.button_Write.Name = "button_Write";
            this.button_Write.Size = new System.Drawing.Size(75, 23);
            this.button_Write.TabIndex = 93;
            this.button_Write.Text = "Write To File";
            this.button_Write.UseVisualStyleBackColor = true;
            this.button_Write.Click += new System.EventHandler(this.button_Write_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(15, 276);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 92;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(145, 276);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(75, 23);
            this.button_Reset.TabIndex = 91;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(686, 53);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(75, 23);
            this.button_Remove.TabIndex = 90;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(686, 92);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 89;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(686, 19);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 88;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // comboBoxSuspensionType
            // 
            this.comboBoxSuspensionType.FormattingEnabled = true;
            this.comboBoxSuspensionType.Location = new System.Drawing.Point(141, 69);
            this.comboBoxSuspensionType.Name = "comboBoxSuspensionType";
            this.comboBoxSuspensionType.Size = new System.Drawing.Size(111, 21);
            this.comboBoxSuspensionType.TabIndex = 87;
            this.comboBoxSuspensionType.Text = "Rear";
            this.comboBoxSuspensionType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSuspensionType_SelectedIndexChanged);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(93, 67);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(111, 20);
            this.textBoxWeight.TabIndex = 86;
            // 
            // textBoxSeatHeight
            // 
            this.textBoxSeatHeight.Location = new System.Drawing.Point(93, 21);
            this.textBoxSeatHeight.Name = "textBoxSeatHeight";
            this.textBoxSeatHeight.Size = new System.Drawing.Size(111, 20);
            this.textBoxSeatHeight.TabIndex = 85;
            // 
            // textBoxGears
            // 
            this.textBoxGears.Location = new System.Drawing.Point(141, 111);
            this.textBoxGears.Name = "textBoxGears";
            this.textBoxGears.Size = new System.Drawing.Size(111, 20);
            this.textBoxGears.TabIndex = 84;
            // 
            // textBoxGroundHeight
            // 
            this.textBoxGroundHeight.Location = new System.Drawing.Point(141, 30);
            this.textBoxGroundHeight.Name = "textBoxGroundHeight";
            this.textBoxGroundHeight.Size = new System.Drawing.Size(111, 20);
            this.textBoxGroundHeight.TabIndex = 83;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 82;
            this.label12.Text = "SeatHeight";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "BikeWeight";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(16, 114);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(89, 13);
            this.Number.TabIndex = 80;
            this.Number.Text = "Number Of Gears";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 79;
            this.label13.Text = "SuspensionType";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 78;
            this.label11.Text = "GroudHeight\r\n";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(136, 126);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(147, 21);
            this.comboBoxColor.TabIndex = 77;
            this.comboBoxColor.Text = "White";
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "/";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(136, 234);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(147, 20);
            this.textBoxPrice.TabIndex = 74;
            // 
            // textBoxWarrenty
            // 
            this.textBoxWarrenty.Location = new System.Drawing.Point(136, 199);
            this.textBoxWarrenty.Name = "textBoxWarrenty";
            this.textBoxWarrenty.Size = new System.Drawing.Size(147, 20);
            this.textBoxWarrenty.TabIndex = 73;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(277, 165);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(45, 20);
            this.textBoxYear.TabIndex = 72;
            this.textBoxYear.Text = "YYYY";
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(206, 165);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(50, 20);
            this.textBoxMonth.TabIndex = 71;
            this.textBoxMonth.Text = "MM";
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(136, 164);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(46, 20);
            this.textBoxDay.TabIndex = 70;
            this.textBoxDay.Text = "DD";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(136, 95);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(147, 20);
            this.textBoxSpeed.TabIndex = 69;
            // 
            // textBoxMake
            // 
            this.textBoxMake.Location = new System.Drawing.Point(136, 69);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.Size = new System.Drawing.Size(147, 20);
            this.textBoxMake.TabIndex = 68;
            // 
            // textBoxSeialNumber
            // 
            this.textBoxSeialNumber.Location = new System.Drawing.Point(136, 43);
            this.textBoxSeialNumber.Name = "textBoxSeialNumber";
            this.textBoxSeialNumber.Size = new System.Drawing.Size(147, 20);
            this.textBoxSeialNumber.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Warrenty ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Made_Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Make";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "SerialNumber";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxGears);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Number);
            this.groupBox1.Controls.Add(this.textBoxGroundHeight);
            this.groupBox1.Controls.Add(this.comboBoxSuspensionType);
            this.groupBox1.Location = new System.Drawing.Point(367, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 156);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MountainBike";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSeatHeight);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxWeight);
            this.groupBox2.Location = new System.Drawing.Point(390, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 100);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RoadBike";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bikeType);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.button_mountainbike);
            this.Controls.Add(this.textBoxSearchBike);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button_roadbike);
            this.Controls.Add(this.button_DisplayAllBike);
            this.Controls.Add(this.button_Read);
            this.Controls.Add(this.button_Write);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxWarrenty);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.textBoxMake);
            this.Controls.Add(this.textBoxSeialNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bikeType;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.Button button_mountainbike;
        private System.Windows.Forms.TextBox textBoxSearchBike;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button_roadbike;
        private System.Windows.Forms.Button button_DisplayAllBike;
        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.Button button_Write;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ComboBox comboBoxSuspensionType;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxSeatHeight;
        private System.Windows.Forms.TextBox textBoxGears;
        private System.Windows.Forms.TextBox textBoxGroundHeight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxWarrenty;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.TextBox textBoxSeialNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

