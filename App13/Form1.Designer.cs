namespace App13
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
            this.buttonLambda = new System.Windows.Forms.Button();
            this.buttonEmbded = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLambda
            // 
            this.buttonLambda.Location = new System.Drawing.Point(12, 12);
            this.buttonLambda.Name = "buttonLambda";
            this.buttonLambda.Size = new System.Drawing.Size(75, 23);
            this.buttonLambda.TabIndex = 0;
            this.buttonLambda.Text = "Lambda";
            this.buttonLambda.UseVisualStyleBackColor = true;
            this.buttonLambda.Click += new System.EventHandler(this.buttonLambda_Click);
            // 
            // buttonEmbded
            // 
            this.buttonEmbded.Location = new System.Drawing.Point(364, 12);
            this.buttonEmbded.Name = "buttonEmbded";
            this.buttonEmbded.Size = new System.Drawing.Size(139, 23);
            this.buttonEmbded.TabIndex = 1;
            this.buttonEmbded.Text = "Embede DB";
            this.buttonEmbded.UseVisualStyleBackColor = true;
            this.buttonEmbded.Click += new System.EventHandler(this.buttonEmbded_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(364, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 506);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEmbded);
            this.Controls.Add(this.buttonLambda);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLambda;
        private System.Windows.Forms.Button buttonEmbded;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

