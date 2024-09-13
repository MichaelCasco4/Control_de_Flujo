namespace Evaluacion_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumbers = new System.Windows.Forms.Label();
            this.tbNumbers = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.lbNumbers = new System.Windows.Forms.ListBox();
            this.lblSuma = new System.Windows.Forms.Label();
            this.gbNumbersSum = new System.Windows.Forms.GroupBox();
            this.gbNumbersSum.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(14, 65);
            this.lblNumbers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(88, 25);
            this.lblNumbers.TabIndex = 0;
            this.lblNumbers.Text = "Numero:";
            // 
            // tbNumbers
            // 
            this.tbNumbers.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumbers.Location = new System.Drawing.Point(134, 65);
            this.tbNumbers.Name = "tbNumbers";
            this.tbNumbers.Size = new System.Drawing.Size(139, 33);
            this.tbNumbers.TabIndex = 1;
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Image = global::Evaluacion_2.Properties.Resources.mas;
            this.btnSuma.Location = new System.Drawing.Point(309, 78);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(59, 53);
            this.btnSuma.TabIndex = 2;
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(368, 165);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 25);
            this.lblSum.TabIndex = 3;
            // 
            // lbNumbers
            // 
            this.lbNumbers.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumbers.FormattingEnabled = true;
            this.lbNumbers.ItemHeight = 25;
            this.lbNumbers.Location = new System.Drawing.Point(19, 165);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(233, 154);
            this.lbNumbers.TabIndex = 4;
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(323, 247);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(83, 25);
            this.lblSuma.TabIndex = 5;
            this.lblSuma.Text = "Suma: 0";
            // 
            // gbNumbersSum
            // 
            this.gbNumbersSum.Controls.Add(this.lblSuma);
            this.gbNumbersSum.Controls.Add(this.lbNumbers);
            this.gbNumbersSum.Controls.Add(this.lblSum);
            this.gbNumbersSum.Controls.Add(this.btnSuma);
            this.gbNumbersSum.Controls.Add(this.tbNumbers);
            this.gbNumbersSum.Controls.Add(this.lblNumbers);
            this.gbNumbersSum.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNumbersSum.Location = new System.Drawing.Point(52, 50);
            this.gbNumbersSum.Name = "gbNumbersSum";
            this.gbNumbersSum.Size = new System.Drawing.Size(681, 352);
            this.gbNumbersSum.TabIndex = 6;
            this.gbNumbersSum.TabStop = false;
            this.gbNumbersSum.Text = "Suma de Numeros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.gbNumbersSum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Sumar Numeros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbNumbersSum.ResumeLayout(false);
            this.gbNumbersSum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.TextBox tbNumbers;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.ListBox lbNumbers;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.GroupBox gbNumbersSum;
    }
}

