namespace DCSL_TEST
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
            this.btnFrom = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCopy = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFrom
            // 
            this.btnFrom.Location = new System.Drawing.Point(137, 47);
            this.btnFrom.Name = "btnFrom";
            this.btnFrom.Size = new System.Drawing.Size(75, 23);
            this.btnFrom.TabIndex = 0;
            this.btnFrom.Text = "From";
            this.btnFrom.UseVisualStyleBackColor = true;
            this.btnFrom.Click += new System.EventHandler(this.btnFrom_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(104, 147);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnTo
            // 
            this.btnTo.Location = new System.Drawing.Point(137, 99);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(75, 23);
            this.btnTo.TabIndex = 4;
            this.btnTo.Text = "To";
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 229);
            this.Controls.Add(this.btnTo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFrom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnTo;
    }
}

