
namespace ZadatakDA
{
    partial class FormAdmin
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
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.buttonProfConfirm = new System.Windows.Forms.Button();
            this.labelAdmin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(33, 47);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.RowHeadersWidth = 51;
            this.dataGridViewAdmin.RowTemplate.Height = 24;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(734, 300);
            this.dataGridViewAdmin.TabIndex = 0;
            // 
            // buttonProfConfirm
            // 
            this.buttonProfConfirm.Location = new System.Drawing.Point(318, 386);
            this.buttonProfConfirm.Name = "buttonProfConfirm";
            this.buttonProfConfirm.Size = new System.Drawing.Size(164, 32);
            this.buttonProfConfirm.TabIndex = 1;
            this.buttonProfConfirm.Text = "Potvrdi profesora";
            this.buttonProfConfirm.UseVisualStyleBackColor = true;
            this.buttonProfConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Location = new System.Drawing.Point(33, 24);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(267, 17);
            this.labelAdmin.TabIndex = 2;
            this.labelAdmin.Text = "Lista profesora koje je potrebno potvrditi:";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.buttonProfConfirm);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Name = "FormAdmin";
            this.Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Button buttonProfConfirm;
        private System.Windows.Forms.Label labelAdmin;
    }
}