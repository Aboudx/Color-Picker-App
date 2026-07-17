namespace Color_Picker_Project
{
    partial class frmColorPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColorPicker));
            this.lbRed = new System.Windows.Forms.Label();
            this.lbGreen = new System.Windows.Forms.Label();
            this.lbBlue = new System.Windows.Forms.Label();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.btnHex = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRed
            // 
            this.lbRed.AutoSize = true;
            this.lbRed.BackColor = System.Drawing.Color.Transparent;
            this.lbRed.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRed.ForeColor = System.Drawing.Color.Transparent;
            this.lbRed.Location = new System.Drawing.Point(163, 338);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(20, 22);
            this.lbRed.TabIndex = 0;
            this.lbRed.Text = "0";
            // 
            // lbGreen
            // 
            this.lbGreen.AutoSize = true;
            this.lbGreen.BackColor = System.Drawing.Color.Transparent;
            this.lbGreen.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGreen.ForeColor = System.Drawing.Color.Transparent;
            this.lbGreen.Location = new System.Drawing.Point(163, 383);
            this.lbGreen.Name = "lbGreen";
            this.lbGreen.Size = new System.Drawing.Size(20, 22);
            this.lbGreen.TabIndex = 1;
            this.lbGreen.Text = "0";
            // 
            // lbBlue
            // 
            this.lbBlue.AutoSize = true;
            this.lbBlue.BackColor = System.Drawing.Color.Transparent;
            this.lbBlue.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBlue.ForeColor = System.Drawing.Color.Transparent;
            this.lbBlue.Location = new System.Drawing.Point(163, 427);
            this.lbBlue.Name = "lbBlue";
            this.lbBlue.Size = new System.Drawing.Size(20, 22);
            this.lbBlue.TabIndex = 2;
            this.lbBlue.Text = "0";
            // 
            // tbRed
            // 
            this.tbRed.BackColor = System.Drawing.Color.Black;
            this.tbRed.LargeChange = 1;
            this.tbRed.Location = new System.Drawing.Point(330, 102);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(600, 56);
            this.tbRed.TabIndex = 3;
            this.tbRed.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // tbGreen
            // 
            this.tbGreen.BackColor = System.Drawing.Color.Black;
            this.tbGreen.LargeChange = 1;
            this.tbGreen.Location = new System.Drawing.Point(330, 234);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(600, 56);
            this.tbGreen.TabIndex = 4;
            this.tbGreen.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // tbBlue
            // 
            this.tbBlue.BackColor = System.Drawing.Color.Black;
            this.tbBlue.LargeChange = 1;
            this.tbBlue.Location = new System.Drawing.Point(330, 360);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(600, 56);
            this.tbBlue.TabIndex = 5;
            this.tbBlue.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // btnHex
            // 
            this.btnHex.AutoSize = true;
            this.btnHex.BackColor = System.Drawing.Color.Transparent;
            this.btnHex.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHex.ForeColor = System.Drawing.Color.Transparent;
            this.btnHex.Location = new System.Drawing.Point(102, 257);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(107, 23);
            this.btnHex.TabIndex = 6;
            this.btnHex.Text = "#000000";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(64, 85);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(182, 157);
            this.btnColor.TabIndex = 8;
            this.btnColor.UseVisualStyleBackColor = false;
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.Black;
            this.btnRandom.FlatAppearance.BorderSize = 0;
            this.btnRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Image = global::Color_Picker_Project.Properties.Resources.icons8_random_24;
            this.btnRandom.Location = new System.Drawing.Point(47, 253);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(30, 27);
            this.btnRandom.TabIndex = 9;
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.Black;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Image = global::Color_Picker_Project.Properties.Resources.icons8_copy_16;
            this.btnCopy.Location = new System.Drawing.Point(228, 256);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(24, 24);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // frmColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Color_Picker_Project.Properties.Resources.BackGround_ColorBickerProject;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(967, 513);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.lbBlue);
            this.Controls.Add(this.lbGreen);
            this.Controls.Add(this.lbRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmColorPicker";
            this.Text = "Color Picker";
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRed;
        private System.Windows.Forms.Label lbGreen;
        private System.Windows.Forms.Label lbBlue;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.Label btnHex;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnCopy;
    }
}

