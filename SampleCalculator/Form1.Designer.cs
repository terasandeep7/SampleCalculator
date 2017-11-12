namespace SampleCalculator
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
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(37, 31);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(100, 22);
            this.txtFirstNumber.TabIndex = 0;
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Location = new System.Drawing.Point(37, 71);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(100, 22);
            this.txtSecondNumber.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(57, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(186, 96);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(46, 17);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.txtFirstNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblResult;
    }
}

