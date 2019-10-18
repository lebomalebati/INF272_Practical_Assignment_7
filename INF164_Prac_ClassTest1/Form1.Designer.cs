namespace INF164_Prac_ClassTest1
{
    partial class frmCount
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
            this.lblLearn = new System.Windows.Forms.Label();
            this.btnPractice = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLearn
            // 
            this.lblLearn.AutoSize = true;
            this.lblLearn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearn.Location = new System.Drawing.Point(35, 42);
            this.lblLearn.Name = "lblLearn";
            this.lblLearn.Size = new System.Drawing.Size(247, 50);
            this.lblLearn.TabIndex = 0;
            this.lblLearn.Text = "Learning how to count in\r\n     Sepedi and Spanish";
            // 
            // btnPractice
            // 
            this.btnPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPractice.Location = new System.Drawing.Point(92, 132);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(138, 27);
            this.btnPractice.TabIndex = 1;
            this.btnPractice.Text = "Practise";
            this.btnPractice.UseVisualStyleBackColor = true;
            this.btnPractice.Click += new System.EventHandler(this.btnPractice_Click);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(92, 180);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(138, 27);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // frmCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 258);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnPractice);
            this.Controls.Add(this.lblLearn);
            this.Name = "frmCount";
            this.Text = "Counting from 1 to 10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLearn;
        private System.Windows.Forms.Button btnPractice;
        private System.Windows.Forms.Button btnTest;
    }
}

