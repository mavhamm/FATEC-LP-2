namespace frmBegin
{
    partial class ex38
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
            this.txtBoxNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnCalcularH = new System.Windows.Forms.Button();
            this.lblMouseHover = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxNum
            // 
            this.txtBoxNum.Location = new System.Drawing.Point(68, 68);
            this.txtBoxNum.Name = "txtBoxNum";
            this.txtBoxNum.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNum.TabIndex = 0;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.Snow;
            this.lblNum.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(21, 3);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(203, 38);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "Digite um número positivo \r\ne maior que zero:";
            // 
            // btnCalcularH
            // 
            this.btnCalcularH.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCalcularH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcularH.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularH.Location = new System.Drawing.Point(68, 116);
            this.btnCalcularH.Name = "btnCalcularH";
            this.btnCalcularH.Size = new System.Drawing.Size(100, 82);
            this.btnCalcularH.TabIndex = 2;
            this.btnCalcularH.Text = "Calcular H";
            this.btnCalcularH.UseVisualStyleBackColor = false;
            this.btnCalcularH.Click += new System.EventHandler(this.btnCalcularH_Click);
            this.btnCalcularH.MouseLeave += new System.EventHandler(this.btnCalcularH_MouseLeave);
            this.btnCalcularH.MouseHover += new System.EventHandler(this.btnCalcularH_MouseHover);
            // 
            // lblMouseHover
            // 
            this.lblMouseHover.AutoSize = true;
            this.lblMouseHover.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblMouseHover.Location = new System.Drawing.Point(65, 204);
            this.lblMouseHover.Name = "lblMouseHover";
            this.lblMouseHover.Size = new System.Drawing.Size(0, 13);
            this.lblMouseHover.TabIndex = 3;
            this.lblMouseHover.Visible = false;
            // 
            // ex38
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(249, 222);
            this.Controls.Add(this.lblMouseHover);
            this.Controls.Add(this.btnCalcularH);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtBoxNum);
            this.KeyPreview = true;
            this.Name = "ex38";
            this.Padding = new System.Windows.Forms.Padding(33);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 38";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ex38_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnCalcularH;
        private System.Windows.Forms.Label lblMouseHover;
    }
}