namespace SpeakerRecognitionAPI
{
    partial class SpeehToText
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
            this.btn_start = new System.Windows.Forms.Button();
            this.text_output = new System.Windows.Forms.TextBox();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.txt_region = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(367, 385);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // text_output
            // 
            this.text_output.Location = new System.Drawing.Point(12, 139);
            this.text_output.Multiline = true;
            this.text_output.Name = "text_output";
            this.text_output.Size = new System.Drawing.Size(776, 225);
            this.text_output.TabIndex = 1;
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(286, 27);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(244, 20);
            this.txt_key.TabIndex = 3;
            // 
            // txt_region
            // 
            this.txt_region.Location = new System.Drawing.Point(286, 73);
            this.txt_region.Name = "txt_region";
            this.txt_region.Size = new System.Drawing.Size(244, 20);
            this.txt_region.TabIndex = 4;
            this.txt_region.Text = "eastus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "API Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "API Region";
            // 
            // SpeehToText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_region);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.text_output);
            this.Controls.Add(this.btn_start);
            this.Name = "SpeehToText";
            this.Text = "SpeehToText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox text_output;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.TextBox txt_region;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}