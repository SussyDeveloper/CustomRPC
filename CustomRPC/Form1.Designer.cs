namespace CustomRPC
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.FirstLineTextBox = new System.Windows.Forms.TextBox();
            this.secondline = new System.Windows.Forms.TextBox();
            this.updatebutton = new System.Windows.Forms.Button();
            this.clientid = new System.Windows.Forms.TextBox();
            this.startbutton = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.timebox = new System.Windows.Forms.CheckBox();
            this.imagebox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mont Demo Heavy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(281, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "CustomRPC";
            // 
            // FirstLineTextBox
            // 
            this.FirstLineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstLineTextBox.Location = new System.Drawing.Point(257, 189);
            this.FirstLineTextBox.Name = "FirstLineTextBox";
            this.FirstLineTextBox.Size = new System.Drawing.Size(298, 20);
            this.FirstLineTextBox.TabIndex = 1;
            this.FirstLineTextBox.Text = "FirstLine";
            // 
            // secondline
            // 
            this.secondline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondline.Location = new System.Drawing.Point(257, 238);
            this.secondline.Name = "secondline";
            this.secondline.Size = new System.Drawing.Size(298, 20);
            this.secondline.TabIndex = 2;
            this.secondline.Text = "SecondLine";
            // 
            // updatebutton
            // 
            this.updatebutton.Font = new System.Drawing.Font("Mont Demo Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updatebutton.Location = new System.Drawing.Point(278, 273);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(251, 63);
            this.updatebutton.TabIndex = 3;
            this.updatebutton.Text = "UPDATE";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // clientid
            // 
            this.clientid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientid.Location = new System.Drawing.Point(257, 127);
            this.clientid.Name = "clientid";
            this.clientid.Size = new System.Drawing.Size(298, 20);
            this.clientid.TabIndex = 4;
            this.clientid.Text = "Client ID";
            // 
            // startbutton
            // 
            this.startbutton.Font = new System.Drawing.Font("Mont Demo Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startbutton.Location = new System.Drawing.Point(257, 342);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(108, 35);
            this.startbutton.TabIndex = 5;
            this.startbutton.Text = "START";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // stopbutton
            // 
            this.stopbutton.Font = new System.Drawing.Font("Mont Demo Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopbutton.Location = new System.Drawing.Point(447, 342);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(108, 35);
            this.stopbutton.TabIndex = 6;
            this.stopbutton.Text = "STOP";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // timebox
            // 
            this.timebox.AutoSize = true;
            this.timebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timebox.ForeColor = System.Drawing.Color.White;
            this.timebox.Location = new System.Drawing.Point(12, 414);
            this.timebox.Name = "timebox";
            this.timebox.Size = new System.Drawing.Size(62, 24);
            this.timebox.TabIndex = 7;
            this.timebox.Text = "Time";
            this.timebox.UseVisualStyleBackColor = true;
            // 
            // imagebox
            // 
            this.imagebox.AutoSize = true;
            this.imagebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imagebox.ForeColor = System.Drawing.Color.White;
            this.imagebox.Location = new System.Drawing.Point(100, 414);
            this.imagebox.Name = "imagebox";
            this.imagebox.Size = new System.Drawing.Size(73, 24);
            this.imagebox.TabIndex = 8;
            this.imagebox.Text = "Image";
            this.imagebox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imagebox);
            this.Controls.Add(this.timebox);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.clientid);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.secondline);
            this.Controls.Add(this.FirstLineTextBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "CustomRPC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstLineTextBox;
        private System.Windows.Forms.TextBox secondline;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.TextBox clientid;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.CheckBox timebox;
        private System.Windows.Forms.CheckBox imagebox;
    }
}

