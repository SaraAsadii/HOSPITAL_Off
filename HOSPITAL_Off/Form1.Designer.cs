namespace HOSPITAL_Off
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button14 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Thistle;
            this.button14.Location = new System.Drawing.Point(292, 177);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(236, 208);
            this.button14.TabIndex = 19;
            this.button14.Text = " خروج از برنامه";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Thistle;
            this.button6.Location = new System.Drawing.Point(618, 177);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(236, 208);
            this.button6.TabIndex = 18;
            this.button6.Text = "ثبت مرخصی";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button6;
    }
}

