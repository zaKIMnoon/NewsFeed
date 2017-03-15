namespace NewsFeeder
{
    partial class frmMain
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
            this.dgvFeedsList = new System.Windows.Forms.DataGridView();
            this.btnFetchUrl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFeedsList
            // 
            this.dgvFeedsList.AllowUserToOrderColumns = true;
            this.dgvFeedsList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFeedsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFeedsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFeedsList.Location = new System.Drawing.Point(0, 48);
            this.dgvFeedsList.Name = "dgvFeedsList";
            this.dgvFeedsList.RowTemplate.Height = 24;
            this.dgvFeedsList.Size = new System.Drawing.Size(1015, 448);
            this.dgvFeedsList.TabIndex = 2;
            // 
            // btnFetchUrl
            // 
            this.btnFetchUrl.Location = new System.Drawing.Point(12, 13);
            this.btnFetchUrl.Name = "btnFetchUrl";
            this.btnFetchUrl.Size = new System.Drawing.Size(128, 29);
            this.btnFetchUrl.TabIndex = 1;
            this.btnFetchUrl.Text = "Fetch";
            this.btnFetchUrl.UseVisualStyleBackColor = true;
            this.btnFetchUrl.Click += new System.EventHandler(this.btnFetchUrl_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 496);
            this.Controls.Add(this.dgvFeedsList);
            this.Controls.Add(this.btnFetchUrl);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFeedsList;
        private System.Windows.Forms.Button btnFetchUrl;
    }
}

