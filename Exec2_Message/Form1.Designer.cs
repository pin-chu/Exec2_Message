namespace Exec2_Message
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Timebutton = new System.Windows.Forms.Button();
            this.Showlabel = new System.Windows.Forms.Label();
            this.Hibutton = new System.Windows.Forms.Button();
            this.Hilabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timebutton
            // 
            this.Timebutton.Location = new System.Drawing.Point(77, 94);
            this.Timebutton.Name = "Timebutton";
            this.Timebutton.Size = new System.Drawing.Size(92, 23);
            this.Timebutton.TabIndex = 0;
            this.Timebutton.Text = "顯示目前時間:";
            this.Timebutton.UseVisualStyleBackColor = true;
            this.Timebutton.Click += new System.EventHandler(this.Timebutton_Click);
            // 
            // Showlabel
            // 
            this.Showlabel.AutoSize = true;
            this.Showlabel.Location = new System.Drawing.Point(186, 99);
            this.Showlabel.Name = "Showlabel";
            this.Showlabel.Size = new System.Drawing.Size(54, 12);
            this.Showlabel.TabIndex = 1;
            this.Showlabel.Text = "Show now";
            // 
            // Hibutton
            // 
            this.Hibutton.Location = new System.Drawing.Point(77, 139);
            this.Hibutton.Name = "Hibutton";
            this.Hibutton.Size = new System.Drawing.Size(92, 23);
            this.Hibutton.TabIndex = 2;
            this.Hibutton.Text = "Hi now";
            this.Hibutton.UseVisualStyleBackColor = true;
            this.Hibutton.Click += new System.EventHandler(this.Hibutton_Click);
            // 
            // Hilabel
            // 
            this.Hilabel.AutoSize = true;
            this.Hilabel.Location = new System.Drawing.Point(186, 144);
            this.Hilabel.Name = "Hilabel";
            this.Hilabel.Size = new System.Drawing.Size(54, 12);
            this.Hilabel.TabIndex = 3;
            this.Hilabel.Text = "Show now";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 258);
            this.Controls.Add(this.Hilabel);
            this.Controls.Add(this.Hibutton);
            this.Controls.Add(this.Showlabel);
            this.Controls.Add(this.Timebutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Timebutton;
        private System.Windows.Forms.Label Showlabel;
        private System.Windows.Forms.Button Hibutton;
        private System.Windows.Forms.Label Hilabel;
    }
}

