namespace metodaElectre
{
    partial class Calificative
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
            this.components = new System.ComponentModel.Container();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matrice = new System.Windows.Forms.DataGridView();
            this.submit_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
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
            this.matrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.matrice.GridColor = System.Drawing.SystemColors.Control;
            this.matrice.Location = new System.Drawing.Point(-1, 0);
            this.matrice.Name = "matrice";
            this.matrice.RowHeadersVisible = false;
            this.matrice.ShowCellErrors = false;
            this.matrice.ShowCellToolTips = false;
            this.matrice.ShowEditingIcon = false;
            this.matrice.ShowRowErrors = false;
            this.matrice.Size = new System.Drawing.Size(503, 222);
            this.matrice.TabIndex = 0;
            // 
            // submit_button
            // 
            this.submit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submit_button.Location = new System.Drawing.Point(320, 296);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(75, 23);
            this.submit_button.TabIndex = 9;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // close_button
            // 
            this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.close_button.Location = new System.Drawing.Point(415, 296);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 8;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Calificative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 331);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.matrice);
            this.Name = "Calificative";
            this.ShowIcon = false;
            this.Text = "Calificative";
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource detailsBindingSource;
        private System.Windows.Forms.DataGridView matrice;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button close_button;
    }
}