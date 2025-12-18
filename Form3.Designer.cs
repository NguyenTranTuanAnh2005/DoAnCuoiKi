namespace QuanLyBanHang
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnOut = new System.Windows.Forms.Button();
            this.btnKKSL = new System.Windows.Forms.Button();
            this.btnQLK = new System.Windows.Forms.Button();
            this.btnAddItean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOut
            // 
            this.btnOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOut.BackgroundImage = global::QuanLyBanHang.Properties.Resources.c7dc6656fb6b112a043d0c74b5326084;
            this.btnOut.Image = global::QuanLyBanHang.Properties.Resources.istockphoto_878320722_2048x2048;
            this.btnOut.Location = new System.Drawing.Point(700, 300);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(300, 70);
            this.btnOut.TabIndex = 0;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            // 
            // btnKKSL
            // 
            this.btnKKSL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKKSL.Image = global::QuanLyBanHang.Properties.Resources.istockphoto_878320722_2048x2048;
            this.btnKKSL.Location = new System.Drawing.Point(255, 300);
            this.btnKKSL.Name = "btnKKSL";
            this.btnKKSL.Size = new System.Drawing.Size(300, 70);
            this.btnKKSL.TabIndex = 0;
            this.btnKKSL.Text = "Kiểm kê hàng hóa";
            this.btnKKSL.UseVisualStyleBackColor = true;
            // 
            // btnQLK
            // 
            this.btnQLK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQLK.Image = global::QuanLyBanHang.Properties.Resources.istockphoto_878320722_2048x2048;
            this.btnQLK.Location = new System.Drawing.Point(700, 155);
            this.btnQLK.Name = "btnQLK";
            this.btnQLK.Size = new System.Drawing.Size(300, 70);
            this.btnQLK.TabIndex = 0;
            this.btnQLK.Text = "Quản lý kho";
            this.btnQLK.UseVisualStyleBackColor = true;
            // 
            // btnAddItean
            // 
            this.btnAddItean.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddItean.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddItean.Image = global::QuanLyBanHang.Properties.Resources.istockphoto_878320722_2048x2048;
            this.btnAddItean.Location = new System.Drawing.Point(255, 155);
            this.btnAddItean.Name = "btnAddItean";
            this.btnAddItean.Size = new System.Drawing.Size(300, 70);
            this.btnAddItean.TabIndex = 0;
            this.btnAddItean.Text = "Nhập hàng";
            this.btnAddItean.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnKKSL);
            this.Controls.Add(this.btnQLK);
            this.Controls.Add(this.btnAddItean);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form3";
            this.Text = "Quản lý cửa hàng";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddItean;
        private System.Windows.Forms.Button btnQLK;
        private System.Windows.Forms.Button btnKKSL;
        private System.Windows.Forms.Button btnOut;
    }
}