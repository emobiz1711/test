namespace Test1
{
    partial class frmMainForm
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
            this.checkBox_LaneAssdist = new System.Windows.Forms.CheckBox();
            this.checkBox_LED = new System.Windows.Forms.CheckBox();
            this.checkBox_RearView = new System.Windows.Forms.CheckBox();
            this.cbEngine = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.checkBox_ParkAssistant = new System.Windows.Forms.CheckBox();
            this.checkBox_AppConnect = new System.Windows.Forms.CheckBox();
            this.checkBox_Navigation = new System.Windows.Forms.CheckBox();
            this.finalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_LaneAssdist
            // 
            this.checkBox_LaneAssdist.AutoSize = true;
            this.checkBox_LaneAssdist.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_LaneAssdist.ForeColor = System.Drawing.Color.Black;
            this.checkBox_LaneAssdist.Location = new System.Drawing.Point(57, 98);
            this.checkBox_LaneAssdist.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_LaneAssdist.Name = "checkBox_LaneAssdist";
            this.checkBox_LaneAssdist.Size = new System.Drawing.Size(200, 17);
            this.checkBox_LaneAssdist.TabIndex = 8;
            this.checkBox_LaneAssdist.Tag = "9.74";
            this.checkBox_LaneAssdist.Text = "Lane Assist – added price per month ";
            this.checkBox_LaneAssdist.UseVisualStyleBackColor = false;
            this.checkBox_LaneAssdist.CheckedChanged += new System.EventHandler(this.checkBox_LaneAssdist_CheckedChanged);
            // 
            // checkBox_LED
            // 
            this.checkBox_LED.AutoSize = true;
            this.checkBox_LED.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_LED.ForeColor = System.Drawing.Color.Black;
            this.checkBox_LED.Location = new System.Drawing.Point(56, 142);
            this.checkBox_LED.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_LED.Name = "checkBox_LED";
            this.checkBox_LED.Size = new System.Drawing.Size(195, 17);
            this.checkBox_LED.TabIndex = 9;
            this.checkBox_LED.Tag = "28.06";
            this.checkBox_LED.Text = "LED Lights – added price per month";
            this.checkBox_LED.UseVisualStyleBackColor = false;
            this.checkBox_LED.CheckedChanged += new System.EventHandler(this.checkBox_LED_CheckedChanged);
            // 
            // checkBox_RearView
            // 
            this.checkBox_RearView.AutoSize = true;
            this.checkBox_RearView.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_RearView.ForeColor = System.Drawing.Color.Black;
            this.checkBox_RearView.Location = new System.Drawing.Point(56, 120);
            this.checkBox_RearView.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_RearView.Name = "checkBox_RearView";
            this.checkBox_RearView.Size = new System.Drawing.Size(195, 17);
            this.checkBox_RearView.TabIndex = 10;
            this.checkBox_RearView.Tag = "4.51";
            this.checkBox_RearView.Text = "Rear View – added price per month ";
            this.checkBox_RearView.UseVisualStyleBackColor = false;
            this.checkBox_RearView.CheckedChanged += new System.EventHandler(this.checkBox_RearView_CheckedChanged);
            // 
            // cbEngine
            // 
            this.cbEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEngine.FormattingEnabled = true;
            this.cbEngine.Items.AddRange(new object[] {
            "1.0 TSI BMT – 115 hp – added price per month #339",
            "1.5 TSI EVO BM – 130 hp – added price per month #359",
            "1.5 TSI EVO BMT – 150 hp – added price per month #362"});
            this.cbEngine.Location = new System.Drawing.Point(57, 23);
            this.cbEngine.Margin = new System.Windows.Forms.Padding(2);
            this.cbEngine.Name = "cbEngine";
            this.cbEngine.Size = new System.Drawing.Size(445, 21);
            this.cbEngine.TabIndex = 11;
            this.cbEngine.SelectedValueChanged += new System.EventHandler(this.cbEngine_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Engine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Color";
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Urano Grey – added price per month #0",
            "ornado Red – added price per month #2.51",
            "Lapiz Blue Metallic – added price per month #8.11",
            "Oryx White Perlmutteffect – added price per month #16.72",
            "aaaaaaaa #1111"});
            this.cbColor.Location = new System.Drawing.Point(57, 58);
            this.cbColor.Margin = new System.Windows.Forms.Padding(2);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(442, 21);
            this.cbColor.TabIndex = 13;
            this.cbColor.SelectedValueChanged += new System.EventHandler(this.cbColor_SelectedValueChanged);
            // 
            // checkBox_ParkAssistant
            // 
            this.checkBox_ParkAssistant.AutoSize = true;
            this.checkBox_ParkAssistant.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_ParkAssistant.ForeColor = System.Drawing.Color.Black;
            this.checkBox_ParkAssistant.Location = new System.Drawing.Point(57, 164);
            this.checkBox_ParkAssistant.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_ParkAssistant.Name = "checkBox_ParkAssistant";
            this.checkBox_ParkAssistant.Size = new System.Drawing.Size(210, 17);
            this.checkBox_ParkAssistant.TabIndex = 19;
            this.checkBox_ParkAssistant.Tag = "9.33";
            this.checkBox_ParkAssistant.Text = "Park Assistant – added price per month";
            this.checkBox_ParkAssistant.UseVisualStyleBackColor = false;
            this.checkBox_ParkAssistant.CheckedChanged += new System.EventHandler(this.checkBox_ParkAssistant_CheckedChanged);
            // 
            // checkBox_AppConnect
            // 
            this.checkBox_AppConnect.AutoSize = true;
            this.checkBox_AppConnect.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_AppConnect.ForeColor = System.Drawing.Color.Black;
            this.checkBox_AppConnect.Location = new System.Drawing.Point(296, 98);
            this.checkBox_AppConnect.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_AppConnect.Name = "checkBox_AppConnect";
            this.checkBox_AppConnect.Size = new System.Drawing.Size(208, 17);
            this.checkBox_AppConnect.TabIndex = 20;
            this.checkBox_AppConnect.Tag = "3.13";
            this.checkBox_AppConnect.Text = "App Connect – added price per month ";
            this.checkBox_AppConnect.UseVisualStyleBackColor = false;
            this.checkBox_AppConnect.CheckedChanged += new System.EventHandler(this.checkBox_AppConnect_CheckedChanged);
            // 
            // checkBox_Navigation
            // 
            this.checkBox_Navigation.AutoSize = true;
            this.checkBox_Navigation.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Navigation.ForeColor = System.Drawing.Color.Black;
            this.checkBox_Navigation.Location = new System.Drawing.Point(296, 120);
            this.checkBox_Navigation.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Navigation.Name = "checkBox_Navigation";
            this.checkBox_Navigation.Size = new System.Drawing.Size(242, 17);
            this.checkBox_Navigation.TabIndex = 21;
            this.checkBox_Navigation.Tag = "9.3";
            this.checkBox_Navigation.Text = "Navigational System – added price per month ";
            this.checkBox_Navigation.UseVisualStyleBackColor = false;
            this.checkBox_Navigation.CheckedChanged += new System.EventHandler(this.checkBox_Navigation_CheckedChanged);
            // 
            // finalPrice
            // 
            this.finalPrice.AutoSize = true;
            this.finalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalPrice.Location = new System.Drawing.Point(829, 657);
            this.finalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.finalPrice.Name = "finalPrice";
            this.finalPrice.Size = new System.Drawing.Size(95, 42);
            this.finalPrice.TabIndex = 22;
            this.finalPrice.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 657);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 37);
            this.label3.TabIndex = 24;
            this.label3.Text = "VW 2019 Arteon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(520, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 37);
            this.label4.TabIndex = 25;
            this.label4.Text = "VW Car Configurator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(605, 668);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 31);
            this.label5.TabIndex = 26;
            this.label5.Text = "Current Price";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Test1.Properties.Resources._667;
            this.pictureBox2.Location = new System.Drawing.Point(611, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 184);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Test1.Properties.Resources.car;
            this.pictureBox1.Location = new System.Drawing.Point(5, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(965, 468);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(980, 711);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.finalPrice);
            this.Controls.Add(this.checkBox_Navigation);
            this.Controls.Add(this.checkBox_AppConnect);
            this.Controls.Add(this.checkBox_ParkAssistant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEngine);
            this.Controls.Add(this.checkBox_RearView);
            this.Controls.Add(this.checkBox_LED);
            this.Controls.Add(this.checkBox_LaneAssdist);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainForm";
            this.Text = "VW Car Object Configurator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox_LaneAssdist;
        private System.Windows.Forms.CheckBox checkBox_LED;
        private System.Windows.Forms.CheckBox checkBox_RearView;
        private System.Windows.Forms.ComboBox cbEngine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.CheckBox checkBox_ParkAssistant;
        private System.Windows.Forms.CheckBox checkBox_AppConnect;
        private System.Windows.Forms.CheckBox checkBox_Navigation;
        private System.Windows.Forms.Label finalPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

