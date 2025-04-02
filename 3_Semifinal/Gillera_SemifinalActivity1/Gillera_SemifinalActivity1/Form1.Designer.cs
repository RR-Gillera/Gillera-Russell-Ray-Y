namespace Gillera_SemifinalActivity1
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
            this.idTxt = new System.Windows.Forms.TextBox();
            this.fNameTxt = new System.Windows.Forms.TextBox();
            this.lNameTxt = new System.Windows.Forms.TextBox();
            this.mNameTxt = new System.Windows.Forms.TextBox();
            this.courseTxt = new System.Windows.Forms.TextBox();
            this.yrTxt = new System.Windows.Forms.TextBox();
            this.bdayTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(22, 48);
            this.idTxt.Multiline = true;
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(255, 31);
            this.idTxt.TabIndex = 0;
            this.idTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.idTxt.Enter += new System.EventHandler(this.idTxt_Enter);
            this.idTxt.Leave += new System.EventHandler(this.idTxt_Leave);
            // 
            // fNameTxt
            // 
            this.fNameTxt.Location = new System.Drawing.Point(22, 85);
            this.fNameTxt.Multiline = true;
            this.fNameTxt.Name = "fNameTxt";
            this.fNameTxt.Size = new System.Drawing.Size(255, 31);
            this.fNameTxt.TabIndex = 1;
            this.fNameTxt.Enter += new System.EventHandler(this.fNameTxt_Enter);
            this.fNameTxt.Leave += new System.EventHandler(this.fNameTxt_Leave);
            // 
            // lNameTxt
            // 
            this.lNameTxt.Location = new System.Drawing.Point(22, 122);
            this.lNameTxt.Multiline = true;
            this.lNameTxt.Name = "lNameTxt";
            this.lNameTxt.Size = new System.Drawing.Size(255, 31);
            this.lNameTxt.TabIndex = 2;
            this.lNameTxt.Enter += new System.EventHandler(this.lNameTxt_Enter);
            this.lNameTxt.Leave += new System.EventHandler(this.lNameTxt_Leave);
            // 
            // mNameTxt
            // 
            this.mNameTxt.Location = new System.Drawing.Point(22, 159);
            this.mNameTxt.Multiline = true;
            this.mNameTxt.Name = "mNameTxt";
            this.mNameTxt.Size = new System.Drawing.Size(255, 31);
            this.mNameTxt.TabIndex = 3;
            this.mNameTxt.Enter += new System.EventHandler(this.mNameTxt_Enter);
            this.mNameTxt.Leave += new System.EventHandler(this.mNameTxt_Leave);
            // 
            // courseTxt
            // 
            this.courseTxt.Location = new System.Drawing.Point(22, 196);
            this.courseTxt.Multiline = true;
            this.courseTxt.Name = "courseTxt";
            this.courseTxt.Size = new System.Drawing.Size(255, 31);
            this.courseTxt.TabIndex = 4;
            this.courseTxt.Enter += new System.EventHandler(this.courseTxt_Enter);
            this.courseTxt.Leave += new System.EventHandler(this.courseTxt_Leave);
            // 
            // yrTxt
            // 
            this.yrTxt.Location = new System.Drawing.Point(22, 233);
            this.yrTxt.Multiline = true;
            this.yrTxt.Name = "yrTxt";
            this.yrTxt.Size = new System.Drawing.Size(255, 31);
            this.yrTxt.TabIndex = 5;
            this.yrTxt.Enter += new System.EventHandler(this.yrTxt_Enter);
            this.yrTxt.Leave += new System.EventHandler(this.yrTxt_Leave);
            // 
            // bdayTxt
            // 
            this.bdayTxt.Location = new System.Drawing.Point(22, 270);
            this.bdayTxt.Multiline = true;
            this.bdayTxt.Name = "bdayTxt";
            this.bdayTxt.Size = new System.Drawing.Size(255, 31);
            this.bdayTxt.TabIndex = 6;
            this.bdayTxt.Enter += new System.EventHandler(this.bdayTxt_Enter);
            this.bdayTxt.Leave += new System.EventHandler(this.bdayTxt_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 414);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bdayTxt);
            this.Controls.Add(this.yrTxt);
            this.Controls.Add(this.courseTxt);
            this.Controls.Add(this.mNameTxt);
            this.Controls.Add(this.lNameTxt);
            this.Controls.Add(this.fNameTxt);
            this.Controls.Add(this.idTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox fNameTxt;
        private System.Windows.Forms.TextBox lNameTxt;
        private System.Windows.Forms.TextBox mNameTxt;
        private System.Windows.Forms.TextBox courseTxt;
        private System.Windows.Forms.TextBox yrTxt;
        private System.Windows.Forms.TextBox bdayTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

