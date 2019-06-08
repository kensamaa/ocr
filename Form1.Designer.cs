namespace test22
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_ocr = new System.Windows.Forms.Button();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // bt_ocr
            // 
            this.bt_ocr.Location = new System.Drawing.Point(78, 41);
            this.bt_ocr.Name = "bt_ocr";
            this.bt_ocr.Size = new System.Drawing.Size(191, 44);
            this.bt_ocr.TabIndex = 0;
            this.bt_ocr.Text = "parcourir image";
            this.bt_ocr.UseVisualStyleBackColor = true;
            this.bt_ocr.Click += new System.EventHandler(this.bt_ocr_Click);
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(53, 126);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(670, 244);
            this.txt_output.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.bt_ocr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_ocr;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

