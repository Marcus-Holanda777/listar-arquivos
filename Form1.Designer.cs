
namespace Lista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPasta = new System.Windows.Forms.TextBox();
            this.btnPasta = new System.Windows.Forms.Button();
            this.listPasta = new System.Windows.Forms.ListView();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.lbContar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPasta
            // 
            this.txtPasta.Enabled = false;
            this.txtPasta.Location = new System.Drawing.Point(36, 31);
            this.txtPasta.Name = "txtPasta";
            this.txtPasta.Size = new System.Drawing.Size(382, 23);
            this.txtPasta.TabIndex = 0;
            // 
            // btnPasta
            // 
            this.btnPasta.Location = new System.Drawing.Point(435, 31);
            this.btnPasta.Name = "btnPasta";
            this.btnPasta.Size = new System.Drawing.Size(54, 23);
            this.btnPasta.TabIndex = 1;
            this.btnPasta.Text = "...";
            this.btnPasta.UseVisualStyleBackColor = true;
            this.btnPasta.Click += new System.EventHandler(this.btnPasta_Click);
            // 
            // listPasta
            // 
            this.listPasta.FullRowSelect = true;
            this.listPasta.HideSelection = false;
            this.listPasta.Location = new System.Drawing.Point(36, 70);
            this.listPasta.Name = "listPasta";
            this.listPasta.Size = new System.Drawing.Size(453, 230);
            this.listPasta.TabIndex = 2;
            this.listPasta.UseCompatibleStateImageBehavior = false;
            this.listPasta.View = System.Windows.Forms.View.Details;
            // 
            // grpBox
            // 
            this.grpBox.BackColor = System.Drawing.Color.LightGray;
            this.grpBox.Controls.Add(this.lbContar);
            this.grpBox.Controls.Add(this.label3);
            this.grpBox.Controls.Add(this.lbTotal);
            this.grpBox.Controls.Add(this.label1);
            this.grpBox.Location = new System.Drawing.Point(36, 324);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(453, 121);
            this.grpBox.TabIndex = 3;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Info. Arquivos";
            // 
            // lbContar
            // 
            this.lbContar.AutoSize = true;
            this.lbContar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbContar.Location = new System.Drawing.Point(224, 72);
            this.lbContar.Name = "lbContar";
            this.lbContar.Size = new System.Drawing.Size(19, 21);
            this.lbContar.TabIndex = 3;
            this.lbContar.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total arquivos    -";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.Location = new System.Drawing.Point(224, 31);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(19, 21);
            this.lbTotal.TabIndex = 1;
            this.lbTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamanho pasta  -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(532, 460);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.listPasta);
            this.Controls.Add(this.btnPasta);
            this.Controls.Add(this.txtPasta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasta;
        private System.Windows.Forms.Button btnPasta;
        private System.Windows.Forms.ListView listPasta;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbContar;
        private System.Windows.Forms.Label label3;
    }
}

