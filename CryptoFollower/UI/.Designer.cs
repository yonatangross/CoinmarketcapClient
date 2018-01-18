namespace CryptoFollower.UI
{
    partial class Form1
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCurrencies = new System.Windows.Forms.ListBox();
            this.dataGridViewCryptoCurrencies = new System.Windows.Forms.DataGridView();
            this.buttonPopulateGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCryptoCurrencies)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the currencies \r\nyou would like to observe";
            // 
            // listBoxCurrencies
            // 
            this.listBoxCurrencies.FormattingEnabled = true;
            this.listBoxCurrencies.ItemHeight = 20;
            this.listBoxCurrencies.Location = new System.Drawing.Point(27, 81);
            this.listBoxCurrencies.Name = "listBoxCurrencies";
            this.listBoxCurrencies.Size = new System.Drawing.Size(213, 164);
            this.listBoxCurrencies.TabIndex = 1;
            // 
            // dataGridViewCryptoCurrencies
            // 
            this.dataGridViewCryptoCurrencies.AllowUserToOrderColumns = true;
            this.dataGridViewCryptoCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCryptoCurrencies.Location = new System.Drawing.Point(267, 81);
            this.dataGridViewCryptoCurrencies.Name = "dataGridViewCryptoCurrencies";
            this.dataGridViewCryptoCurrencies.RowTemplate.Height = 28;
            this.dataGridViewCryptoCurrencies.Size = new System.Drawing.Size(1246, 866);
            this.dataGridViewCryptoCurrencies.TabIndex = 2;
            // 
            // buttonPopulateGrid
            // 
            this.buttonPopulateGrid.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPopulateGrid.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonPopulateGrid.Location = new System.Drawing.Point(27, 251);
            this.buttonPopulateGrid.Name = "buttonPopulateGrid";
            this.buttonPopulateGrid.Size = new System.Drawing.Size(213, 56);
            this.buttonPopulateGrid.TabIndex = 3;
            this.buttonPopulateGrid.Text = "Populate Grid";
            this.buttonPopulateGrid.UseVisualStyleBackColor = false;
            this.buttonPopulateGrid.Click += new System.EventHandler(this.buttonPopulateGrid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 959);
            this.Controls.Add(this.buttonPopulateGrid);
            this.Controls.Add(this.dataGridViewCryptoCurrencies);
            this.Controls.Add(this.listBoxCurrencies);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCryptoCurrencies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCurrencies;
        private System.Windows.Forms.DataGridView dataGridViewCryptoCurrencies;
        private System.Windows.Forms.Button buttonPopulateGrid;
    }
}

