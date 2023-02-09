namespace Power_Supply_Challenge
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
            this.setVoltage1 = new System.Windows.Forms.TextBox();
            this.setCurrent1 = new System.Windows.Forms.TextBox();
            this.powerOn1 = new System.Windows.Forms.Button();
            this.powerOff1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.actualCurrent1 = new System.Windows.Forms.TextBox();
            this.actualVoltage1 = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.changeVoltage1 = new System.Windows.Forms.Button();
            this.availableResources = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.connectionButton = new System.Windows.Forms.Button();
            this.connectionResource = new System.Windows.Forms.TextBox();
            this.changeCurrent1 = new System.Windows.Forms.Button();
            this.changeLimit = new System.Windows.Forms.Button();
            this.changeVoltage2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.actualCurrent2 = new System.Windows.Forms.TextBox();
            this.actualVoltage2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.powerOff2 = new System.Windows.Forms.Button();
            this.powerOn2 = new System.Windows.Forms.Button();
            this.setCurrent2 = new System.Windows.Forms.TextBox();
            this.setVoltage2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // setVoltage1
            // 
            this.setVoltage1.Location = new System.Drawing.Point(473, 147);
            this.setVoltage1.Name = "setVoltage1";
            this.setVoltage1.Size = new System.Drawing.Size(161, 26);
            this.setVoltage1.TabIndex = 0;
            // 
            // setCurrent1
            // 
            this.setCurrent1.Location = new System.Drawing.Point(473, 244);
            this.setCurrent1.Name = "setCurrent1";
            this.setCurrent1.Size = new System.Drawing.Size(161, 26);
            this.setCurrent1.TabIndex = 2;
            // 
            // powerOn1
            // 
            this.powerOn1.BackColor = System.Drawing.Color.Silver;
            this.powerOn1.Location = new System.Drawing.Point(476, 435);
            this.powerOn1.Name = "powerOn1";
            this.powerOn1.Size = new System.Drawing.Size(161, 37);
            this.powerOn1.TabIndex = 3;
            this.powerOn1.Text = "Power On";
            this.powerOn1.UseVisualStyleBackColor = false;
            this.powerOn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // powerOff1
            // 
            this.powerOff1.BackColor = System.Drawing.Color.Silver;
            this.powerOff1.Location = new System.Drawing.Point(476, 478);
            this.powerOff1.Name = "powerOff1";
            this.powerOff1.Size = new System.Drawing.Size(161, 37);
            this.powerOff1.TabIndex = 4;
            this.powerOff1.Text = "Power Off";
            this.powerOff1.UseVisualStyleBackColor = false;
            this.powerOff1.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Set Voltage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Set Current Limit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Actual Current";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Actual Voltage";
            // 
            // actualCurrent1
            // 
            this.actualCurrent1.Location = new System.Drawing.Point(476, 403);
            this.actualCurrent1.Name = "actualCurrent1";
            this.actualCurrent1.Size = new System.Drawing.Size(161, 26);
            this.actualCurrent1.TabIndex = 15;
            // 
            // actualVoltage1
            // 
            this.actualVoltage1.Location = new System.Drawing.Point(476, 347);
            this.actualVoltage1.Name = "actualVoltage1";
            this.actualVoltage1.Size = new System.Drawing.Size(161, 26);
            this.actualVoltage1.TabIndex = 14;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 765);
            this.splitter1.TabIndex = 29;
            this.splitter1.TabStop = false;
            // 
            // changeVoltage1
            // 
            this.changeVoltage1.Location = new System.Drawing.Point(473, 179);
            this.changeVoltage1.Name = "changeVoltage1";
            this.changeVoltage1.Size = new System.Drawing.Size(161, 29);
            this.changeVoltage1.TabIndex = 50;
            this.changeVoltage1.Text = "Change Voltage";
            this.changeVoltage1.UseVisualStyleBackColor = true;
            this.changeVoltage1.Click += new System.EventHandler(this.submitBtn1_Click);
            // 
            // availableResources
            // 
            this.availableResources.FormattingEnabled = true;
            this.availableResources.ItemHeight = 20;
            this.availableResources.Location = new System.Drawing.Point(78, 192);
            this.availableResources.Name = "availableResources";
            this.availableResources.Size = new System.Drawing.Size(151, 124);
            this.availableResources.TabIndex = 67;
            this.availableResources.DoubleClick += new System.EventHandler(this.availableResources_DoubleClick_1);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(74, 169);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(168, 20);
            this.label19.TabIndex = 68;
            this.label19.Text = "Connected Resources";
            // 
            // connectionButton
            // 
            this.connectionButton.Location = new System.Drawing.Point(56, 59);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(199, 41);
            this.connectionButton.TabIndex = 69;
            this.connectionButton.Text = "Open Connection";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            // 
            // connectionResource
            // 
            this.connectionResource.Location = new System.Drawing.Point(56, 106);
            this.connectionResource.Name = "connectionResource";
            this.connectionResource.Size = new System.Drawing.Size(199, 26);
            this.connectionResource.TabIndex = 70;
            // 
            // changeCurrent1
            // 
            this.changeCurrent1.Location = new System.Drawing.Point(473, 276);
            this.changeCurrent1.Name = "changeCurrent1";
            this.changeCurrent1.Size = new System.Drawing.Size(161, 29);
            this.changeCurrent1.TabIndex = 71;
            this.changeCurrent1.Text = " Change Limit";
            this.changeCurrent1.UseVisualStyleBackColor = true;
            this.changeCurrent1.Click += new System.EventHandler(this.changeCurrent1_Click);
            // 
            // changeLimit
            // 
            this.changeLimit.Location = new System.Drawing.Point(750, 276);
            this.changeLimit.Name = "changeLimit";
            this.changeLimit.Size = new System.Drawing.Size(161, 29);
            this.changeLimit.TabIndex = 84;
            this.changeLimit.Text = " Change Limit";
            this.changeLimit.UseVisualStyleBackColor = true;
            this.changeLimit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // changeVoltage2
            // 
            this.changeVoltage2.Location = new System.Drawing.Point(750, 179);
            this.changeVoltage2.Name = "changeVoltage2";
            this.changeVoltage2.Size = new System.Drawing.Size(161, 29);
            this.changeVoltage2.TabIndex = 83;
            this.changeVoltage2.Text = "Change Voltage";
            this.changeVoltage2.UseVisualStyleBackColor = true;
            this.changeVoltage2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(779, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "Actual Current";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(779, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 81;
            this.label7.Text = "Actual Voltage";
            // 
            // actualCurrent2
            // 
            this.actualCurrent2.Location = new System.Drawing.Point(753, 403);
            this.actualCurrent2.Name = "actualCurrent2";
            this.actualCurrent2.Size = new System.Drawing.Size(158, 26);
            this.actualCurrent2.TabIndex = 80;
            // 
            // actualVoltage2
            // 
            this.actualVoltage2.Location = new System.Drawing.Point(753, 347);
            this.actualVoltage2.Name = "actualVoltage2";
            this.actualVoltage2.Size = new System.Drawing.Size(158, 26);
            this.actualVoltage2.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(764, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 78;
            this.label8.Text = "Set Current Limit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(788, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 77;
            this.label9.Text = "Set Voltage";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(781, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 29);
            this.label10.TabIndex = 76;
            this.label10.Text = "Output 2";
            // 
            // powerOff2
            // 
            this.powerOff2.BackColor = System.Drawing.Color.Silver;
            this.powerOff2.Location = new System.Drawing.Point(750, 478);
            this.powerOff2.Name = "powerOff2";
            this.powerOff2.Size = new System.Drawing.Size(161, 37);
            this.powerOff2.TabIndex = 75;
            this.powerOff2.Text = "Power Off";
            this.powerOff2.UseVisualStyleBackColor = false;
            this.powerOff2.Click += new System.EventHandler(this.powerOff2_Click);
            // 
            // powerOn2
            // 
            this.powerOn2.BackColor = System.Drawing.Color.Silver;
            this.powerOn2.Location = new System.Drawing.Point(750, 435);
            this.powerOn2.Name = "powerOn2";
            this.powerOn2.Size = new System.Drawing.Size(161, 37);
            this.powerOn2.TabIndex = 74;
            this.powerOn2.Text = "Power On";
            this.powerOn2.UseVisualStyleBackColor = false;
            this.powerOn2.Click += new System.EventHandler(this.powerOn2_Click);
            // 
            // setCurrent2
            // 
            this.setCurrent2.Location = new System.Drawing.Point(750, 244);
            this.setCurrent2.Name = "setCurrent2";
            this.setCurrent2.Size = new System.Drawing.Size(161, 26);
            this.setCurrent2.TabIndex = 73;
            // 
            // setVoltage2
            // 
            this.setVoltage2.Location = new System.Drawing.Point(750, 147);
            this.setVoltage2.Name = "setVoltage2";
            this.setVoltage2.Size = new System.Drawing.Size(161, 26);
            this.setVoltage2.TabIndex = 72;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 765);
            this.Controls.Add(this.changeLimit);
            this.Controls.Add(this.changeVoltage2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.actualCurrent2);
            this.Controls.Add(this.actualVoltage2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.powerOff2);
            this.Controls.Add(this.powerOn2);
            this.Controls.Add(this.setCurrent2);
            this.Controls.Add(this.setVoltage2);
            this.Controls.Add(this.changeCurrent1);
            this.Controls.Add(this.connectionResource);
            this.Controls.Add(this.connectionButton);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.availableResources);
            this.Controls.Add(this.changeVoltage1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.actualCurrent1);
            this.Controls.Add(this.actualVoltage1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.powerOff1);
            this.Controls.Add(this.powerOn1);
            this.Controls.Add(this.setCurrent1);
            this.Controls.Add(this.setVoltage1);
            this.Name = "Form1";
            this.Text = " CPX400DP App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox setVoltage1;
        private System.Windows.Forms.TextBox setCurrent1;
        private System.Windows.Forms.Button powerOn1;
        private System.Windows.Forms.Button powerOff1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox actualCurrent1;
        private System.Windows.Forms.TextBox actualVoltage1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button changeVoltage1;
        private System.Windows.Forms.ListBox availableResources;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.TextBox connectionResource;
        private System.Windows.Forms.Button changeCurrent1;
        private System.Windows.Forms.Button changeLimit;
        private System.Windows.Forms.Button changeVoltage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox actualCurrent2;
        private System.Windows.Forms.TextBox actualVoltage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button powerOff2;
        private System.Windows.Forms.Button powerOn2;
        private System.Windows.Forms.TextBox setCurrent2;
        private System.Windows.Forms.TextBox setVoltage2;
    }
}

