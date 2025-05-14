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
        // Keep existing resource manager code
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        
        // Define component variables
        // ... (keep existing variables)
        
        SuspendLayout();
        
        // Form properties
        this.BackColor = Color.FromArgb(45, 45, 48);
        this.ClientSize = new Size(350, 500);
        this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        this.Text = "Simple RayCulator";
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        
        // Result display area
        operation.BackColor = Color.FromArgb(30, 30, 30);
        operation.ForeColor = Color.White;
        operation.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
        operation.Location = new Point(12, 12);
        operation.Size = new Size(326, 60);
        operation.Padding = new Padding(5);
        operation.TextAlign = HorizontalAlignment.Right;
        operation.BorderStyle = BorderStyle.FixedSingle;
        
        // Common button styles
        void SetButtonStyle(Button btn, Color backColor, Color foreColor, Font font)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = backColor;
            btn.ForeColor = foreColor;
            btn.Font = font;
            btn.Margin = new Padding(4);
            btn.UseVisualStyleBackColor = false;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(backColor.R + 15, backColor.G + 15, backColor.B + 15);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(backColor.R + 30, backColor.G + 30, backColor.B + 30);
        }
        
        // Define colors
        Color numberColor = Color.FromArgb(60, 60, 65);
        Color operatorColor = Color.FromArgb(50, 100, 160);
        Color equalColor = Color.FromArgb(70, 130, 180);
        Color clearColor = Color.FromArgb(150, 70, 70);
        Color textColor = Color.White;
        Font buttonFont = new Font("Segoe UI", 14F, FontStyle.Bold);
        Font numberFont = new Font("Segoe UI", 14F, FontStyle.Regular);
        
        // Set button styles
        
        // Number buttons
        foreach (Button btn in new[] { bttn0, bttn1, bttn2, bttn3, bttn4, bttn5, bttn6, bttn7, bttn8, bttn9, bttnPN, btnnDot })
        {
            SetButtonStyle(btn, numberColor, textColor, numberFont);
        }
        
        // Operator buttons
        foreach (Button btn in new[] { bttnPlus, bttnMinus, bttnTimes, bttnDivide })
        {
            SetButtonStyle(btn, operatorColor, textColor, buttonFont);
        }
        
        // Equal button
        SetButtonStyle(bttnEqual, equalColor, textColor, buttonFont);
        
        // Clear buttons
        foreach (Button btn in new[] { bttnC, bttnCE, bttnErase })
        {
            SetButtonStyle(btn, clearColor, textColor, buttonFont);
        }
        
        // Button positions - use a grid layout with proper spacing
        int buttonWidth = 70;
        int buttonHeight = 60;
        int spacing = 8;
        int startX = 12;
        int startY = 90;
        
        // First row - operators
        bttnPlus.Location = new Point(startX, startY);
        bttnPlus.Size = new Size(buttonWidth, buttonHeight);
        
        bttnMinus.Location = new Point(startX + buttonWidth + spacing, startY);
        bttnMinus.Size = new Size(buttonWidth, buttonHeight);
        
        bttnTimes.Location = new Point(startX + (buttonWidth + spacing) * 2, startY);
        bttnTimes.Size = new Size(buttonWidth, buttonHeight);
        
        bttnDivide.Location = new Point(startX + (buttonWidth + spacing) * 3, startY);
        bttnDivide.Size = new Size(buttonWidth, buttonHeight);
        
        // Second row - 7, 8, 9
        bttn7.Location = new Point(startX, startY + buttonHeight + spacing);
        bttn7.Size = new Size(buttonWidth, buttonHeight);
        
        bttn8.Location = new Point(startX + buttonWidth + spacing, startY + buttonHeight + spacing);
        bttn8.Size = new Size(buttonWidth, buttonHeight);
        
        bttn9.Location = new Point(startX + (buttonWidth + spacing) * 2, startY + buttonHeight + spacing);
        bttn9.Size = new Size(buttonWidth, buttonHeight);
        
        // Third row - 4, 5, 6
        bttn4.Location = new Point(startX, startY + (buttonHeight + spacing) * 2);
        bttn4.Size = new Size(buttonWidth, buttonHeight);
        
        bttn5.Location = new Point(startX + buttonWidth + spacing, startY + (buttonHeight + spacing) * 2);
        bttn5.Size = new Size(buttonWidth, buttonHeight);
        
        bttn6.Location = new Point(startX + (buttonWidth + spacing) * 2, startY + (buttonHeight + spacing) * 2);
        bttn6.Size = new Size(buttonWidth, buttonHeight);
        
        // Fourth row - 1, 2, 3
        bttn1.Location = new Point(startX, startY + (buttonHeight + spacing) * 3);
        bttn1.Size = new Size(buttonWidth, buttonHeight);
        
        bttn2.Location = new Point(startX + buttonWidth + spacing, startY + (buttonHeight + spacing) * 3);
        bttn2.Size = new Size(buttonWidth, buttonHeight);
        
        bttn3.Location = new Point(startX + (buttonWidth + spacing) * 2, startY + (buttonHeight + spacing) * 3);
        bttn3.Size = new Size(buttonWidth, buttonHeight);
        
        // Fifth row - +/-, 0, .
        bttnPN.Location = new Point(startX, startY + (buttonHeight + spacing) * 4);
        bttnPN.Size = new Size(buttonWidth, buttonHeight);
        
        bttn0.Location = new Point(startX + buttonWidth + spacing, startY + (buttonHeight + spacing) * 4);
        bttn0.Size = new Size(buttonWidth, buttonHeight);
        
        btnnDot.Location = new Point(startX + (buttonWidth + spacing) * 2, startY + (buttonHeight + spacing) * 4);
        btnnDot.Size = new Size(buttonWidth, buttonHeight);
        
        // Sixth row - CE, C, Erase
        bttnCE.Location = new Point(startX, startY + (buttonHeight + spacing) * 5);
        bttnCE.Size = new Size(buttonWidth, buttonHeight);
        
        bttnC.Location = new Point(startX + buttonWidth + spacing, startY + (buttonHeight + spacing) * 5);
        bttnC.Size = new Size(buttonWidth, buttonHeight);
        
        bttnErase.Location = new Point(startX + (buttonWidth + spacing) * 2, startY + (buttonHeight + spacing) * 5);
        bttnErase.Size = new Size(buttonWidth, buttonHeight);
        
        // Equal button - takes up the height of the last 4 rows
        bttnEqual.Location = new Point(startX + (buttonWidth + spacing) * 3, startY + buttonHeight + spacing);
        bttnEqual.Size = new Size(buttonWidth, (buttonHeight * 4) + (spacing * 3));
        
        // Set up controls
        Controls.Add(operation);
        Controls.Add(bttnPlus);
        Controls.Add(bttnMinus);
        Controls.Add(bttnTimes);
        Controls.Add(bttnDivide);
        Controls.Add(bttn7);
        Controls.Add(bttn8);
        Controls.Add(bttn9);
        Controls.Add(bttn4);
        Controls.Add(bttn5);
        Controls.Add(bttn6);
        Controls.Add(bttn1);
        Controls.Add(bttn2);
        Controls.Add(bttn3);
        Controls.Add(bttnPN);
        Controls.Add(bttn0);
        Controls.Add(btnnDot);
        Controls.Add(bttnCE);
        Controls.Add(bttnC);
        Controls.Add(bttnErase);
        Controls.Add(bttnEqual);
        
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
