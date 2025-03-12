namespace Activity2B
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
            this.components = new System.ComponentModel.Container();
            this.question = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.answer = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.Color.Lime;
            this.question.Font = new System.Drawing.Font("Wide Latin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.Location = new System.Drawing.Point(439, 367);
            this.question.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.question.MinimumSize = new System.Drawing.Size(150, 30);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(150, 30);
            this.question.TabIndex = 5;
            this.question.Click += new System.EventHandler(this.Click);
            this.question.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // answer
            // 
            this.answer.BackColor = System.Drawing.Color.Cyan;
            this.answer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(358, 22);
            this.answer.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.answer.MinimumSize = new System.Drawing.Size(500, 300);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(500, 300);
            this.answer.TabIndex = 2;
            this.answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answer.Click += new System.EventHandler(this.answer_Click);
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Red;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(24, 22);
            this.lbl1.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.lbl1.MinimumSize = new System.Drawing.Size(250, 250);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(309, 383);
            this.lbl1.TabIndex = 3;
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.question);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button button1;
    }
}

