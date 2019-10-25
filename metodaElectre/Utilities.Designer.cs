namespace metodaElectre
{
    partial class Utilities
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
            this.close_button = new System.Windows.Forms.Button();
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
            this.matrice.Location = new System.Drawing.Point(-1, -1);
            this.matrice.Name = "matrice";
            this.matrice.RowHeadersVisible = false;
            this.matrice.ShowCellErrors = false;
            this.matrice.ShowCellToolTips = false;
            this.matrice.ShowEditingIcon = false;
            this.matrice.ShowRowErrors = false;
            this.matrice.Size = new System.Drawing.Size(503, 216);
            this.matrice.TabIndex = 0;
            // 
            // close_button
            // 
            this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.close_button.Location = new System.Drawing.Point(415, 296);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 9;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Utilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 331);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.matrice);
            this.Name = "Utilities";
            this.ShowIcon = false;
            this.Text = "Utilitati";
            ((System.ComponentModel.ISupportInitialize)(this.matrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView matrice;
        private System.Windows.Forms.Button close_button;
    }
}