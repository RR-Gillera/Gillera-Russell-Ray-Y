namespace GilleraMidtermSeatwork
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
            operation = new TextBox();
            bttnPlus = new Button();
            bttnDivide = new Button();
            bttnMinus = new Button();
            bttnTimes = new Button();
            bttn9 = new Button();
            bttn8 = new Button();
            bttn7 = new Button();
            bttn6 = new Button();
            bttn5 = new Button();
            bttn4 = new Button();
            bttnErase = new Button();
            bttnC = new Button();
            bttnCE = new Button();
            btnnDot = new Button();
            bttn0 = new Button();
            bttnPN = new Button();
            bttn3 = new Button();
            bttn2 = new Button();
            bttn1 = new Button();
            bttnEqual = new Button();
            SuspendLayout();
            // 
            // operation
            // 
            operation.Location = new Point(22, 24);
            operation.Multiline = true;
            operation.Name = "operation";
            operation.Size = new Size(289, 60);
            operation.TabIndex = 0;
            operation.TextChanged += operation_TextChanged;
            // 
            // bttnPlus
            // 
            bttnPlus.Font = new Font("Tahoma", 20.25F, FontStyle.Bold);
            bttnPlus.Location = new Point(23, 90);
            bttnPlus.Name = "bttnPlus";
            bttnPlus.Size = new Size(65, 55);
            bttnPlus.TabIndex = 4;
            bttnPlus.Text = "+";
            bttnPlus.UseVisualStyleBackColor = true;
            bttnPlus.Click += bttnPlus_Click;
            // 
            // bttnDivide
            // 
            bttnDivide.Font = new Font("Tahoma", 20.25F, FontStyle.Bold);
            bttnDivide.Location = new Point(245, 90);
            bttnDivide.Name = "bttnDivide";
            bttnDivide.Size = new Size(65, 55);
            bttnDivide.TabIndex = 5;
            bttnDivide.Text = "÷";
            bttnDivide.UseVisualStyleBackColor = true;
            bttnDivide.Click += bttnDivide_Click;
            // 
            // bttnMinus
            // 
            bttnMinus.Font = new Font("Tahoma", 20.25F, FontStyle.Bold);
            bttnMinus.Location = new Point(97, 90);
            bttnMinus.Name = "bttnMinus";
            bttnMinus.Size = new Size(65, 55);
            bttnMinus.TabIndex = 6;
            bttnMinus.Text = "-";
            bttnMinus.UseVisualStyleBackColor = true;
            bttnMinus.Click += bttnMinus_Click;
            // 
            // bttnTimes
            // 
            bttnTimes.Font = new Font("Tahoma", 20.25F, FontStyle.Bold);
            bttnTimes.Location = new Point(171, 90);
            bttnTimes.Name = "bttnTimes";
            bttnTimes.Size = new Size(65, 55);
            bttnTimes.TabIndex = 7;
            bttnTimes.Text = "×";
            bttnTimes.UseVisualStyleBackColor = true;
            bttnTimes.Click += bttnTimes_Click;
            // 
            // bttn9
            // 
            bttn9.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            bttn9.Location = new Point(171, 151);
            bttn9.Name = "bttn9";
            bttn9.Size = new Size(65, 55);
            bttn9.TabIndex = 11;
            bttn9.Text = "9";
            bttn9.UseVisualStyleBackColor = true;
            bttn9.Click += bttn9_Click;
            // 
            // bttn8
            // 
            bttn8.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            bttn8.Location = new Point(97, 151);
            bttn8.Name = "bttn8";
            bttn8.Size = new Size(65, 55);
            bttn8.TabIndex = 10;
            bttn8.Text = "8";
            bttn8.UseVisualStyleBackColor = true;
            bttn8.Click += bttn8_Click;
            // 
            // bttn7
            // 
            bttn7.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            bttn7.Location = new Point(23, 151);
            bttn7.Name = "bttn7";
            bttn7.Size = new Size(65, 55);
            bttn7.TabIndex = 8;
            bttn7.Text = "7";
            bttn7.UseVisualStyleBackColor = true;
            bttn7.Click += bttn7_Click;
            // 
            // bttn6
            // 
            bttn6.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            bttn6.Location = new Point(171, 212);
            bttn6.Name = "bttn6";
            bttn6.Size = new Size(65, 55);
            bttn6.TabIndex = 15;
            bttn6.Text = "6";
            bttn6.UseVisualStyleBackColor = true;
            bttn6.Click += bttn6_Click;
            // 
            // bttn5
            // 
            bttn5.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            bttn5.Location = new Point(97, 212);
            bttn5.Name = "bttn5";
            bttn5.Size = new Size(65, 55);
            bttn5.TabIndex = 14;
            bttn5.Text = "5";
            bttn5.UseVisualStyleBackColor = true;
            bttn5.Click += bttn5_Click;
            // 
            // bttn4
            // 
            bttn4.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            bttn4.Location = new Point(23, 212);
            bttn4.Name = "bttn4";
            bttn4.Size = new Size(65, 55);
            bttn4.TabIndex = 12;
            bttn4.Text = "4";
            bttn4.UseVisualStyleBackColor = true;
            bttn4.Click += bttn4_Click;
            // 
            // bttnErase
            // 
            bttnErase.BackgroundImage = (Image)resources.GetObject("bttnErase.BackgroundImage");
            bttnErase.BackgroundImageLayout = ImageLayout.Center;
            bttnErase.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            bttnErase.Location = new Point(171, 395);
            bttnErase.Name = "bttnErase";
            bttnErase.Size = new Size(65, 55);
            bttnErase.TabIndex = 27;
            bttnErase.UseVisualStyleBackColor = true;
            bttnErase.Click += bttnErase_Click;
            // 
            // bttnC
            // 
            bttnC.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            bttnC.Location = new Point(97, 395);
            bttnC.Name = "bttnC";
            bttnC.Size = new Size(65, 55);
            bttnC.TabIndex = 26;
            bttnC.Text = "C";
            bttnC.UseVisualStyleBackColor = true;
            bttnC.Click += bttnC_Click;
            // 
            // bttnCE
            // 
            bttnCE.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            bttnCE.Location = new Point(23, 395);
            bttnCE.Name = "bttnCE";
            bttnCE.Size = new Size(65, 55);
            bttnCE.TabIndex = 24;
            bttnCE.Text = "CE";
            bttnCE.UseVisualStyleBackColor = true;
            bttnCE.Click += bttnCE_Click;
            // 
            // btnnDot
            // 
            btnnDot.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnnDot.Location = new Point(171, 334);
            btnnDot.Name = "btnnDot";
            btnnDot.Size = new Size(65, 55);
            btnnDot.TabIndex = 23;
            btnnDot.Text = ".";
            btnnDot.UseVisualStyleBackColor = true;
            btnnDot.Click += btnnDot_Click;
            // 
            // bttn0
            // 
            bttn0.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            bttn0.Location = new Point(97, 334);
            bttn0.Name = "bttn0";
            bttn0.Size = new Size(65, 55);
            bttn0.TabIndex = 22;
            bttn0.Text = "0";
            bttn0.UseVisualStyleBackColor = true;
            bttn0.Click += bttn0_Click;
            // 
            // bttnPN
            // 
            bttnPN.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnPN.Location = new Point(23, 334);
            bttnPN.Name = "bttnPN";
            bttnPN.Size = new Size(65, 55);
            bttnPN.TabIndex = 20;
            bttnPN.Text = "+/-";
            bttnPN.UseVisualStyleBackColor = true;
            bttnPN.Click += bttnPN_Click;
            // 
            // bttn3
            // 
            bttn3.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            bttn3.Location = new Point(171, 273);
            bttn3.Name = "bttn3";
            bttn3.Size = new Size(65, 55);
            bttn3.TabIndex = 19;
            bttn3.Text = "3";
            bttn3.UseVisualStyleBackColor = true;
            bttn3.Click += bttn3_Click;
            // 
            // bttn2
            // 
            bttn2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            bttn2.Location = new Point(97, 273);
            bttn2.Name = "bttn2";
            bttn2.Size = new Size(65, 55);
            bttn2.TabIndex = 18;
            bttn2.Text = "2";
            bttn2.UseVisualStyleBackColor = true;
            bttn2.Click += bttn2_Click;
            // 
            // bttn1
            // 
            bttn1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            bttn1.Location = new Point(23, 273);
            bttn1.Name = "bttn1";
            bttn1.Size = new Size(65, 55);
            bttn1.TabIndex = 16;
            bttn1.Text = "1";
            bttn1.UseVisualStyleBackColor = true;
            bttn1.Click += bttn1_Click;
            // 
            // bttnEqual
            // 
            bttnEqual.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            bttnEqual.Image = (Image)resources.GetObject("bttnEqual.Image");
            bttnEqual.Location = new Point(245, 151);
            bttnEqual.Name = "bttnEqual";
            bttnEqual.Size = new Size(66, 299);
            bttnEqual.TabIndex = 28;
            bttnEqual.UseVisualStyleBackColor = true;
            bttnEqual.Click += bttnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 472);
            Controls.Add(bttnEqual);
            Controls.Add(bttnErase);
            Controls.Add(bttnC);
            Controls.Add(bttnCE);
            Controls.Add(btnnDot);
            Controls.Add(bttn0);
            Controls.Add(bttnPN);
            Controls.Add(bttn3);
            Controls.Add(bttn2);
            Controls.Add(bttn1);
            Controls.Add(bttn6);
            Controls.Add(bttn5);
            Controls.Add(bttn4);
            Controls.Add(bttn9);
            Controls.Add(bttn8);
            Controls.Add(bttn7);
            Controls.Add(bttnTimes);
            Controls.Add(bttnMinus);
            Controls.Add(bttnDivide);
            Controls.Add(bttnPlus);
            Controls.Add(operation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Simple RayCulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox operation;
        private Button bttnPlus;
        private Button bttnDivide;
        private Button bttnMinus;
        private Button bttnTimes;
        private Button bttn9;
        private Button bttn8;
        private Button bttn7;
        private Button bttn6;
        private Button bttn5;
        private Button bttn4;
        private Button bttnErase;
        private Button bttnC;
        private Button bttnCE;
        private Button btnnDot;
        private Button bttn0;
        private Button bttnPN;
        private Button bttn3;
        private Button bttn2;
        private Button bttn1;
        private Button bttnEqual;
    }
}
