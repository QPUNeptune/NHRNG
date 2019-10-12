namespace RNG_but_i_couldt_care_less
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
            this.RNGesus = new System.Windows.Forms.Label();
            this.rng_only = new System.Windows.Forms.Button();
            this.open_only = new System.Windows.Forms.Button();
            this.rngopen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RNGesus
            // 
            this.RNGesus.Font = new System.Drawing.Font("OCR A Extended", 39F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RNGesus.Location = new System.Drawing.Point(12, 9);
            this.RNGesus.Name = "RNGesus";
            this.RNGesus.Size = new System.Drawing.Size(239, 57);
            this.RNGesus.TabIndex = 0;
            this.RNGesus.Text = "000000";
            this.RNGesus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rng_only
            // 
            this.rng_only.Font = new System.Drawing.Font("OCR A Extended", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rng_only.Location = new System.Drawing.Point(12, 69);
            this.rng_only.Name = "rng_only";
            this.rng_only.Size = new System.Drawing.Size(119, 44);
            this.rng_only.TabIndex = 1;
            this.rng_only.Text = "Generate";
            this.rng_only.UseVisualStyleBackColor = true;
            this.rng_only.Click += new System.EventHandler(this.rng_only_Click);
            // 
            // open_only
            // 
            this.open_only.Font = new System.Drawing.Font("OCR A Extended", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_only.Location = new System.Drawing.Point(137, 69);
            this.open_only.Name = "open_only";
            this.open_only.Size = new System.Drawing.Size(114, 44);
            this.open_only.TabIndex = 2;
            this.open_only.Text = "Open";
            this.open_only.UseVisualStyleBackColor = true;
            this.open_only.Click += new System.EventHandler(this.open_only_Click);
            // 
            // rngopen
            // 
            this.rngopen.Font = new System.Drawing.Font("OCR A Extended", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rngopen.Location = new System.Drawing.Point(12, 119);
            this.rngopen.Name = "rngopen";
            this.rngopen.Size = new System.Drawing.Size(239, 52);
            this.rngopen.TabIndex = 3;
            this.rngopen.Text = "Generate and Open";
            this.rngopen.UseVisualStyleBackColor = true;
            this.rngopen.Click += new System.EventHandler(this.rngopen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 180);
            this.Controls.Add(this.rngopen);
            this.Controls.Add(this.open_only);
            this.Controls.Add(this.rng_only);
            this.Controls.Add(this.RNGesus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RNG I guess";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label RNGesus;
        private System.Windows.Forms.Button rng_only;
        private System.Windows.Forms.Button open_only;
        private System.Windows.Forms.Button rngopen;
    }
}

