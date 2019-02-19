namespace VATSIM_ATC_Assistent
{
    partial class ConnFrm
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
            this.cboxPosition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxESVersion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboxPosition
            // 
            this.cboxPosition.FormattingEnabled = true;
            this.cboxPosition.Items.AddRange(new object[] {
            "LPPT_DEL",
            "LPPT_GND"});
            this.cboxPosition.Location = new System.Drawing.Point(86, 41);
            this.cboxPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboxPosition.Name = "cboxPosition";
            this.cboxPosition.Size = new System.Drawing.Size(135, 23);
            this.cboxPosition.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Position: ";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(146, 93);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Conn";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "ES Version:";
            // 
            // cboxESVersion
            // 
            this.cboxESVersion.FormattingEnabled = true;
            this.cboxESVersion.Items.AddRange(new object[] {
            "EuroScope V3.1d",
            "EuroScope V3.2"});
            this.cboxESVersion.Location = new System.Drawing.Point(100, 12);
            this.cboxESVersion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboxESVersion.Name = "cboxESVersion";
            this.cboxESVersion.Size = new System.Drawing.Size(121, 23);
            this.cboxESVersion.TabIndex = 3;
            // 
            // ConnFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 139);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxESVersion);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxPosition);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ConnFrm";
            this.Text = "ConnFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnFrm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxESVersion;
    }
}