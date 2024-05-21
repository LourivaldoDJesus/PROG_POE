namespace PROG_POE
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFindingCallNumbers = new System.Windows.Forms.Button();
            this.btnIdentifyingAreas = new System.Windows.Forms.Button();
            this.btnReplacingBooks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(313, 319);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(174, 34);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFindingCallNumbers
            // 
            this.btnFindingCallNumbers.Location = new System.Drawing.Point(313, 268);
            this.btnFindingCallNumbers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFindingCallNumbers.Name = "btnFindingCallNumbers";
            this.btnFindingCallNumbers.Size = new System.Drawing.Size(174, 34);
            this.btnFindingCallNumbers.TabIndex = 8;
            this.btnFindingCallNumbers.Text = "Finding Call Numbers";
            this.btnFindingCallNumbers.UseVisualStyleBackColor = true;
            this.btnFindingCallNumbers.Click += new System.EventHandler(this.btnFindingCallNumbers_Click);
            // 
            // btnIdentifyingAreas
            // 
            this.btnIdentifyingAreas.Location = new System.Drawing.Point(313, 218);
            this.btnIdentifyingAreas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIdentifyingAreas.Name = "btnIdentifyingAreas";
            this.btnIdentifyingAreas.Size = new System.Drawing.Size(174, 34);
            this.btnIdentifyingAreas.TabIndex = 7;
            this.btnIdentifyingAreas.Text = "Identifying Areas";
            this.btnIdentifyingAreas.UseVisualStyleBackColor = true;
            this.btnIdentifyingAreas.Click += new System.EventHandler(this.btnIdentifyingAreas_Click);
            // 
            // btnReplacingBooks
            // 
            this.btnReplacingBooks.Location = new System.Drawing.Point(313, 162);
            this.btnReplacingBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReplacingBooks.Name = "btnReplacingBooks";
            this.btnReplacingBooks.Size = new System.Drawing.Size(174, 34);
            this.btnReplacingBooks.TabIndex = 6;
            this.btnReplacingBooks.Text = "Replacing Books";
            this.btnReplacingBooks.UseVisualStyleBackColor = true;
            this.btnReplacingBooks.Click += new System.EventHandler(this.btnReplacingBooks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::PROG_POE.Properties.Resources._659a2bc335f31700cacba5e1f2556b1f;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(291, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Learners\' Land";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROG_POE.Properties.Resources._659a2bc335f31700cacba5e1f2556b1f;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFindingCallNumbers);
            this.Controls.Add(this.btnIdentifyingAreas);
            this.Controls.Add(this.btnReplacingBooks);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learners\' Land";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFindingCallNumbers;
        private System.Windows.Forms.Button btnIdentifyingAreas;
        private System.Windows.Forms.Button btnReplacingBooks;
        private System.Windows.Forms.Label label1;
    }
}

