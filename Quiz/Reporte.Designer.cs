
namespace Quiz
{
    partial class Reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte));
            this.ImgBanco = new System.Windows.Forms.PictureBox();
            this.LblReporte = new System.Windows.Forms.Label();
            this.RtxtReporte = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgBanco
            // 
            this.ImgBanco.BackColor = System.Drawing.Color.Transparent;
            this.ImgBanco.Image = ((System.Drawing.Image)(resources.GetObject("ImgBanco.Image")));
            this.ImgBanco.Location = new System.Drawing.Point(0, -3);
            this.ImgBanco.Name = "ImgBanco";
            this.ImgBanco.Size = new System.Drawing.Size(122, 131);
            this.ImgBanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBanco.TabIndex = 1;
            this.ImgBanco.TabStop = false;
            // 
            // LblReporte
            // 
            this.LblReporte.AutoSize = true;
            this.LblReporte.BackColor = System.Drawing.Color.Transparent;
            this.LblReporte.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReporte.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblReporte.Location = new System.Drawing.Point(452, 9);
            this.LblReporte.Name = "LblReporte";
            this.LblReporte.Size = new System.Drawing.Size(184, 41);
            this.LblReporte.TabIndex = 4;
            this.LblReporte.Text = "REPORTE";
            this.LblReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RtxtReporte
            // 
            this.RtxtReporte.BackColor = System.Drawing.Color.AliceBlue;
            this.RtxtReporte.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtReporte.Location = new System.Drawing.Point(319, 53);
            this.RtxtReporte.Name = "RtxtReporte";
            this.RtxtReporte.Size = new System.Drawing.Size(444, 583);
            this.RtxtReporte.TabIndex = 5;
            this.RtxtReporte.Text = "";
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(971, 648);
            this.Controls.Add(this.RtxtReporte);
            this.Controls.Add(this.LblReporte);
            this.Controls.Add(this.ImgBanco);
            this.Name = "Reporte";
            this.Text = "Reporte";
            ((System.ComponentModel.ISupportInitialize)(this.ImgBanco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ImgBanco;
        private System.Windows.Forms.Label LblReporte;
        private System.Windows.Forms.RichTextBox RtxtReporte;
    }
}