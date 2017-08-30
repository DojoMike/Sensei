namespace Sensei
{
    partial class SettingsDialog
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
            this.Voice = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.NumericUpDown();
            this.Volume = new System.Windows.Forms.NumericUpDown();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // Voice
            // 
            this.Voice.AccessibleName = "Voice";
            this.Voice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Voice.FormattingEnabled = true;
            this.Voice.Location = new System.Drawing.Point(12, 31);
            this.Voice.Name = "Voice";
            this.Voice.Size = new System.Drawing.Size(260, 21);
            this.Voice.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(142, 126);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(62, 23);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "&OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.SetVoice);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Volume:";
            // 
            // Rate
            // 
            this.Rate.Location = new System.Drawing.Point(12, 86);
            this.Rate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Rate.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(40, 20);
            this.Rate.TabIndex = 1;
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(58, 86);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(50, 20);
            this.Volume.TabIndex = 2;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(210, 126);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(62, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.Voice);
            this.Name = "SettingsDialog";
            this.Text = "Voice Settings";
            ((System.ComponentModel.ISupportInitialize)(this.Rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Voice;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Rate;
        private System.Windows.Forms.NumericUpDown Volume;
        private System.Windows.Forms.Button Cancel;
    }
}

