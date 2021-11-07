
namespace wa_Client
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMex = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.Chat = new System.Windows.Forms.ListBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.pnlSwitch = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtMex
            // 
            this.txtMex.Location = new System.Drawing.Point(38, 324);
            this.txtMex.Margin = new System.Windows.Forms.Padding(4);
            this.txtMex.Name = "txtMex";
            this.txtMex.Size = new System.Drawing.Size(403, 25);
            this.txtMex.TabIndex = 17;
            this.txtMex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMex_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(448, 320);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 30);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Chat
            // 
            this.Chat.FormattingEnabled = true;
            this.Chat.ItemHeight = 17;
            this.Chat.Location = new System.Drawing.Point(38, 119);
            this.Chat.Margin = new System.Windows.Forms.Padding(4);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(507, 174);
            this.Chat.TabIndex = 15;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(224, 88);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(37, 19);
            this.lblPort.TabIndex = 12;
            this.lblPort.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(263, 85);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(46, 25);
            this.txtPort.TabIndex = 11;
            this.txtPort.Text = "8080";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(49, 88);
            this.lblHost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(41, 19);
            this.lblHost.TabIndex = 10;
            this.lblHost.Text = "Host:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(88, 85);
            this.txtHost.Margin = new System.Windows.Forms.Padding(4);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(99, 25);
            this.txtHost.TabIndex = 9;
            this.txtHost.Text = "192.168.1.130";
            // 
            // pnlSwitch
            // 
            this.pnlSwitch.BackColor = System.Drawing.Color.Red;
            this.pnlSwitch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSwitch.Location = new System.Drawing.Point(0, 374);
            this.pnlSwitch.Name = "pnlSwitch";
            this.pnlSwitch.Size = new System.Drawing.Size(592, 10);
            this.pnlSwitch.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(592, 384);
            this.Controls.Add(this.pnlSwitch);
            this.Controls.Add(this.txtMex);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.Chat);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.txtHost);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMex;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox Chat;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Panel pnlSwitch;
    }
}

