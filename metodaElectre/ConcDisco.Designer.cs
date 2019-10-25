namespace metodaElectre
{
    partial class ConcDisco
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
            this.matrice = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.matrice)).BeginInit();
            this.SuspendLayout();
            // 
            // matrice
            // 
            this.matrice.AllowUserToAddRows = false;
            this.matrice.AllowUserToDeleteRows = false;
            this.matrice.AllowUserToResizeColumns = false;
            this.matrice.AllowUserToResizeRows = false;
            this.matrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrice.Location = new System.Drawing.Point(0, 0);
            this.matrice.Name = "matrice";
            this.matrice.RowHeadersVisible = false;
            this.matrice.ShowCellErrors = false;
            this.matrice.ShowCellToolTips = false;
            this.matrice.ShowEditingIcon = false;
            this.matrice.ShowRowErrors = false;
            this.matrice.Size = new System.Drawing.Size(935, 270);
            this.matrice.TabIndex = 0;
            // 
            // ConcDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 322);
            this.Controls.Add(this.matrice);
            this.Name = "ConcDisco";
            this.ShowIcon = false;
            this.Text = "Coeficienti de concordanta si discordanta";
            ((System.ComponentModel.ISupportInitialize)(this.matrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView matrice;
    }
}