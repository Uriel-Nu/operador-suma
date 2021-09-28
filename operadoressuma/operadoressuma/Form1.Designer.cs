
namespace operadoressuma
{
    partial class suma
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
            this.lblprimernumero = new System.Windows.Forms.Label();
            this.txtprimernumero = new System.Windows.Forms.TextBox();
            this.txtsumar = new System.Windows.Forms.TextBox();
            this.lblsegundonumero = new System.Windows.Forms.Label();
            this.txtsegundonumero = new System.Windows.Forms.TextBox();
            this.butigual = new System.Windows.Forms.Button();
            this.txtigual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblprimernumero
            // 
            this.lblprimernumero.AutoSize = true;
            this.lblprimernumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblprimernumero.Location = new System.Drawing.Point(36, 76);
            this.lblprimernumero.Name = "lblprimernumero";
            this.lblprimernumero.Size = new System.Drawing.Size(171, 21);
            this.lblprimernumero.TabIndex = 0;
            this.lblprimernumero.Text = "ingrese primer numero";
            // 
            // txtprimernumero
            // 
            this.txtprimernumero.Location = new System.Drawing.Point(36, 118);
            this.txtprimernumero.Name = "txtprimernumero";
            this.txtprimernumero.Size = new System.Drawing.Size(157, 23);
            this.txtprimernumero.TabIndex = 1;
            // 
            // txtsumar
            // 
            this.txtsumar.Location = new System.Drawing.Point(222, 102);
            this.txtsumar.Name = "txtsumar";
            this.txtsumar.Size = new System.Drawing.Size(64, 23);
            this.txtsumar.TabIndex = 2;
            // 
            // lblsegundonumero
            // 
            this.lblsegundonumero.AutoSize = true;
            this.lblsegundonumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblsegundonumero.Location = new System.Drawing.Point(298, 69);
            this.lblsegundonumero.Name = "lblsegundonumero";
            this.lblsegundonumero.Size = new System.Drawing.Size(184, 21);
            this.lblsegundonumero.TabIndex = 3;
            this.lblsegundonumero.Text = "ingrese segundo numero";
            // 
            // txtsegundonumero
            // 
            this.txtsegundonumero.Location = new System.Drawing.Point(298, 118);
            this.txtsegundonumero.Name = "txtsegundonumero";
            this.txtsegundonumero.Size = new System.Drawing.Size(176, 23);
            this.txtsegundonumero.TabIndex = 4;
            // 
            // butigual
            // 
            this.butigual.Location = new System.Drawing.Point(502, 91);
            this.butigual.Name = "butigual";
            this.butigual.Size = new System.Drawing.Size(61, 34);
            this.butigual.TabIndex = 5;
            this.butigual.Text = "=";
            this.butigual.UseVisualStyleBackColor = true;
            this.butigual.Click += new System.EventHandler(this.butigual_Click);
            // 
            // txtigual
            // 
            this.txtigual.Enabled = false;
            this.txtigual.Location = new System.Drawing.Point(606, 117);
            this.txtigual.Name = "txtigual";
            this.txtigual.Size = new System.Drawing.Size(100, 23);
            this.txtigual.TabIndex = 6;
            this.txtigual.TextChanged += new System.EventHandler(this.txtigual_TextChanged);
            // 
            // suma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtigual);
            this.Controls.Add(this.butigual);
            this.Controls.Add(this.txtsegundonumero);
            this.Controls.Add(this.lblsegundonumero);
            this.Controls.Add(this.txtsumar);
            this.Controls.Add(this.txtprimernumero);
            this.Controls.Add(this.lblprimernumero);
            this.Name = "suma";
            this.Text = "suma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprimernumero;
        private System.Windows.Forms.TextBox txtprimernumero;
        private System.Windows.Forms.TextBox txtsumar;
        private System.Windows.Forms.Label lblsegundonumero;
        private System.Windows.Forms.TextBox txtsegundonumero;
        private System.Windows.Forms.Button butigual;
        private System.Windows.Forms.TextBox txtigual;
    }
}

