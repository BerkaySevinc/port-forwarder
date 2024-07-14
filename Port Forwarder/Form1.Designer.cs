
namespace Port_Forwarder
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnDeleteForward = new System.Windows.Forms.Button();
            this.radioBtnTCP = new System.Windows.Forms.RadioButton();
            this.radioBtnUDP = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPort.Location = new System.Drawing.Point(176, 51);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(226, 39);
            this.txtPort.TabIndex = 0;
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnForward
            // 
            this.btnForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForward.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnForward.Location = new System.Drawing.Point(85, 192);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(170, 76);
            this.btnForward.TabIndex = 1;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnDeleteForward
            // 
            this.btnDeleteForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteForward.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteForward.Location = new System.Drawing.Point(320, 192);
            this.btnDeleteForward.Name = "btnDeleteForward";
            this.btnDeleteForward.Size = new System.Drawing.Size(170, 76);
            this.btnDeleteForward.TabIndex = 3;
            this.btnDeleteForward.Text = "Delete Forwarded";
            this.btnDeleteForward.UseVisualStyleBackColor = true;
            this.btnDeleteForward.Click += new System.EventHandler(this.btnDeleteForward_Click);
            // 
            // radioBtnTCP
            // 
            this.radioBtnTCP.AutoSize = true;
            this.radioBtnTCP.Checked = true;
            this.radioBtnTCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnTCP.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnTCP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioBtnTCP.Location = new System.Drawing.Point(202, 96);
            this.radioBtnTCP.Name = "radioBtnTCP";
            this.radioBtnTCP.Size = new System.Drawing.Size(67, 34);
            this.radioBtnTCP.TabIndex = 4;
            this.radioBtnTCP.TabStop = true;
            this.radioBtnTCP.Text = "TCP";
            this.radioBtnTCP.UseVisualStyleBackColor = true;
            // 
            // radioBtnUDP
            // 
            this.radioBtnUDP.AutoSize = true;
            this.radioBtnUDP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnUDP.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnUDP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioBtnUDP.Location = new System.Drawing.Point(302, 96);
            this.radioBtnUDP.Name = "radioBtnUDP";
            this.radioBtnUDP.Size = new System.Drawing.Size(73, 34);
            this.radioBtnUDP.TabIndex = 5;
            this.radioBtnUDP.Text = "UDP";
            this.radioBtnUDP.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(574, 328);
            this.Controls.Add(this.radioBtnUDP);
            this.Controls.Add(this.radioBtnTCP);
            this.Controls.Add(this.btnDeleteForward);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.txtPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Port Forwarder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnDeleteForward;
        private System.Windows.Forms.RadioButton radioBtnTCP;
        private System.Windows.Forms.RadioButton radioBtnUDP;
    }
}

