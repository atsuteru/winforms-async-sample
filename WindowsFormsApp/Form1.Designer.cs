namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Sleep1Button = new System.Windows.Forms.Button();
            this.Sleep2Button = new System.Windows.Forms.Button();
            this.Sleep3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sleep1Button
            // 
            this.Sleep1Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sleep1Button.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Sleep1Button.Location = new System.Drawing.Point(91, 45);
            this.Sleep1Button.Name = "Sleep1Button";
            this.Sleep1Button.Size = new System.Drawing.Size(435, 83);
            this.Sleep1Button.TabIndex = 0;
            this.Sleep1Button.Text = "Sleep3000";
            this.Sleep1Button.UseVisualStyleBackColor = true;
            this.Sleep1Button.Click += new System.EventHandler(this.Sleep1Button_Click);
            // 
            // Sleep2Button
            // 
            this.Sleep2Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sleep2Button.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Sleep2Button.Location = new System.Drawing.Point(91, 152);
            this.Sleep2Button.Name = "Sleep2Button";
            this.Sleep2Button.Size = new System.Drawing.Size(435, 83);
            this.Sleep2Button.TabIndex = 1;
            this.Sleep2Button.Text = "Sleep3000 BGWorker";
            this.Sleep2Button.UseVisualStyleBackColor = true;
            this.Sleep2Button.Click += new System.EventHandler(this.Sleep2Button_Click);
            // 
            // Sleep3Button
            // 
            this.Sleep3Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sleep3Button.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Sleep3Button.Location = new System.Drawing.Point(91, 257);
            this.Sleep3Button.Name = "Sleep3Button";
            this.Sleep3Button.Size = new System.Drawing.Size(435, 83);
            this.Sleep3Button.TabIndex = 2;
            this.Sleep3Button.Text = "Sleep3000 Async";
            this.Sleep3Button.UseVisualStyleBackColor = true;
            this.Sleep3Button.Click += new System.EventHandler(this.Sleep3Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 390);
            this.Controls.Add(this.Sleep3Button);
            this.Controls.Add(this.Sleep2Button);
            this.Controls.Add(this.Sleep1Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sleep1Button;
        private System.Windows.Forms.Button Sleep2Button;
        private System.Windows.Forms.Button Sleep3Button;
    }
}

