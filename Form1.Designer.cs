namespace CurvedShaped
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
            this.customCurvedPanel21 = new CurvedShaped.CustomCurvedPanel2();
            this.customCurvedPanel1 = new CurvedShaped.CustomCurvedPanel();
            this.SuspendLayout();
            // 
            // customCurvedPanel21
            // 
            this.customCurvedPanel21.BackColor = System.Drawing.Color.Cyan;
            this.customCurvedPanel21.borderRadius = 1;
            this.customCurvedPanel21.Location = new System.Drawing.Point(35, 150);
            this.customCurvedPanel21.Name = "customCurvedPanel21";
            this.customCurvedPanel21.Size = new System.Drawing.Size(1169, 217);
            this.customCurvedPanel21.TabIndex = 1;
            this.customCurvedPanel21.TabStop = false;
            this.customCurvedPanel21.Text = "customCurvedPanel21";
            this.customCurvedPanel21.TitleBackColor = System.Drawing.Color.SteelBlue;
            this.customCurvedPanel21.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.customCurvedPanel21.TitleForeColor = System.Drawing.Color.White;
            // 
            // customCurvedPanel1
            // 
            this.customCurvedPanel1.BackColor = System.Drawing.Color.Chartreuse;
            this.customCurvedPanel1.borderRadius = 1;
            this.customCurvedPanel1.Location = new System.Drawing.Point(2, 3);
            this.customCurvedPanel1.Name = "customCurvedPanel1";
            this.customCurvedPanel1.Size = new System.Drawing.Size(797, 126);
            this.customCurvedPanel1.TabIndex = 0;
            this.customCurvedPanel1.TabStop = false;
            this.customCurvedPanel1.Text = "customCurvedPanel1";
            this.customCurvedPanel1.TitleBackColor = System.Drawing.Color.SteelBlue;
            this.customCurvedPanel1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.customCurvedPanel1.TitleForeColor = System.Drawing.Color.White;
            this.customCurvedPanel1.Enter += new System.EventHandler(this.customCurvedPanel1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 450);
            this.Controls.Add(this.customCurvedPanel21);
            this.Controls.Add(this.customCurvedPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomCurvedPanel customCurvedPanel1;
        private CustomCurvedPanel2 customCurvedPanel21;
    }
}

