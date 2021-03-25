
namespace DigitalClock
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timeLBL = new System.Windows.Forms.Label();
            this.secondLBL = new System.Windows.Forms.Label();
            this.dateLBL = new System.Windows.Forms.Label();
            this.dayLBL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timeLBL
            // 
            this.timeLBL.AutoSize = true;
            this.timeLBL.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.timeLBL.Location = new System.Drawing.Point(37, 24);
            this.timeLBL.Name = "timeLBL";
            this.timeLBL.Size = new System.Drawing.Size(182, 89);
            this.timeLBL.TabIndex = 0;
            this.timeLBL.Text = "0000";
            // 
            // secondLBL
            // 
            this.secondLBL.AutoSize = true;
            this.secondLBL.Font = new System.Drawing.Font("Segoe UI", 29.25F);
            this.secondLBL.Location = new System.Drawing.Point(225, 54);
            this.secondLBL.Name = "secondLBL";
            this.secondLBL.Size = new System.Drawing.Size(65, 52);
            this.secondLBL.TabIndex = 1;
            this.secondLBL.Text = "00";
            this.secondLBL.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateLBL
            // 
            this.dateLBL.AutoSize = true;
            this.dateLBL.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateLBL.Location = new System.Drawing.Point(44, 173);
            this.dateLBL.Name = "dateLBL";
            this.dateLBL.Size = new System.Drawing.Size(28, 37);
            this.dateLBL.TabIndex = 2;
            this.dateLBL.Text = "-";
            this.dateLBL.Click += new System.EventHandler(this.label3_Click);
            // 
            // dayLBL
            // 
            this.dayLBL.AutoSize = true;
            this.dayLBL.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dayLBL.Location = new System.Drawing.Point(223, 173);
            this.dayLBL.Name = "dayLBL";
            this.dayLBL.Size = new System.Drawing.Size(28, 37);
            this.dayLBL.TabIndex = 3;
            this.dayLBL.Text = "-";
            this.dayLBL.Click += new System.EventHandler(this.dayLBL_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(396, 253);
            this.Controls.Add(this.dayLBL);
            this.Controls.Add(this.dateLBL);
            this.Controls.Add(this.secondLBL);
            this.Controls.Add(this.timeLBL);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.85D;
            this.ShowIcon = false;
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLBL;
        private System.Windows.Forms.Label secondLBL;
        private System.Windows.Forms.Label dateLBL;
        private System.Windows.Forms.Label dayLBL;
        private System.Windows.Forms.Timer timer1;
    }
}

