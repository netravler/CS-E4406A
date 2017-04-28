namespace E4406A
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
            this.tbFrequency = new System.Windows.Forms.TextBox();
            this.tbRawCommand = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbTimeDate = new System.Windows.Forms.TextBox();
            this.tbCurrentFrequency = new System.Windows.Forms.TextBox();
            this.tbBandWidth = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.btnDo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFrequency
            // 
            this.tbFrequency.Location = new System.Drawing.Point(137, 22);
            this.tbFrequency.Name = "tbFrequency";
            this.tbFrequency.Size = new System.Drawing.Size(398, 22);
            this.tbFrequency.TabIndex = 0;
            this.tbFrequency.TextChanged += new System.EventHandler(this.tbFrequency_TextChanged);
            this.tbFrequency.Leave += new System.EventHandler(this.tbFrequency_Leave);
            // 
            // tbRawCommand
            // 
            this.tbRawCommand.Location = new System.Drawing.Point(137, 50);
            this.tbRawCommand.Name = "tbRawCommand";
            this.tbRawCommand.Size = new System.Drawing.Size(398, 22);
            this.tbRawCommand.TabIndex = 1;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(54, 131);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(735, 247);
            this.tbOutput.TabIndex = 2;
            // 
            // tbTimeDate
            // 
            this.tbTimeDate.Location = new System.Drawing.Point(555, 35);
            this.tbTimeDate.Name = "tbTimeDate";
            this.tbTimeDate.ReadOnly = true;
            this.tbTimeDate.Size = new System.Drawing.Size(234, 22);
            this.tbTimeDate.TabIndex = 3;
            // 
            // tbCurrentFrequency
            // 
            this.tbCurrentFrequency.Location = new System.Drawing.Point(555, 63);
            this.tbCurrentFrequency.Name = "tbCurrentFrequency";
            this.tbCurrentFrequency.ReadOnly = true;
            this.tbCurrentFrequency.Size = new System.Drawing.Size(234, 22);
            this.tbCurrentFrequency.TabIndex = 4;
            // 
            // tbBandWidth
            // 
            this.tbBandWidth.Location = new System.Drawing.Point(555, 91);
            this.tbBandWidth.Name = "tbBandWidth";
            this.tbBandWidth.ReadOnly = true;
            this.tbBandWidth.Size = new System.Drawing.Size(234, 22);
            this.tbBandWidth.TabIndex = 5;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(555, 7);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(234, 22);
            this.tbStatus.TabIndex = 6;
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(54, 22);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(75, 23);
            this.btnDo.TabIndex = 7;
            this.btnDo.Text = "DO";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 405);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbBandWidth);
            this.Controls.Add(this.tbCurrentFrequency);
            this.Controls.Add(this.tbTimeDate);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbRawCommand);
            this.Controls.Add(this.tbFrequency);
            this.Name = "Form1";
            this.Text = "KeySight - E4406A";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFrequency;
        private System.Windows.Forms.TextBox tbRawCommand;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.TextBox tbTimeDate;
        private System.Windows.Forms.TextBox tbCurrentFrequency;
        private System.Windows.Forms.TextBox tbBandWidth;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Button btnDo;
    }
}

