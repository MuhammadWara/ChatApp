namespace Chatapp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.localport = new System.Windows.Forms.TextBox();
            this.localipp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.remoteport = new System.Windows.Forms.TextBox();
            this.remoteip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.Textmessage = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.listmessage = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.localport);
            this.groupBox1.Controls.Add(this.localipp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Me";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // localport
            // 
            this.localport.Location = new System.Drawing.Point(40, 39);
            this.localport.Name = "localport";
            this.localport.Size = new System.Drawing.Size(100, 20);
            this.localport.TabIndex = 8;
            // 
            // localipp
            // 
            this.localipp.Location = new System.Drawing.Point(40, 13);
            this.localipp.Name = "localipp";
            this.localipp.Size = new System.Drawing.Size(100, 20);
            this.localipp.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ip";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.remoteport);
            this.groupBox2.Controls.Add(this.remoteip);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(177, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Friend";
            // 
            // remoteport
            // 
            this.remoteport.Location = new System.Drawing.Point(38, 39);
            this.remoteport.Name = "remoteport";
            this.remoteport.Size = new System.Drawing.Size(100, 20);
            this.remoteport.TabIndex = 10;
            // 
            // remoteip
            // 
            this.remoteip.Location = new System.Drawing.Point(34, 13);
            this.remoteip.Name = "remoteip";
            this.remoteip.Size = new System.Drawing.Size(100, 20);
            this.remoteip.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ip";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(269, 172);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(70, 25);
            this.start.TabIndex = 2;
            this.start.Text = "Connect";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Textmessage
            // 
            this.Textmessage.Location = new System.Drawing.Point(19, 363);
            this.Textmessage.Name = "Textmessage";
            this.Textmessage.Size = new System.Drawing.Size(240, 20);
            this.Textmessage.TabIndex = 3;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(265, 363);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(74, 21);
            this.Send.TabIndex = 4;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // listmessage
            // 
            this.listmessage.FormattingEnabled = true;
            this.listmessage.Location = new System.Drawing.Point(19, 208);
            this.listmessage.Name = "listmessage";
            this.listmessage.Size = new System.Drawing.Size(320, 147);
            this.listmessage.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(93, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "ChatApp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(358, 396);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listmessage);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Textmessage);
            this.Controls.Add(this.start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Chat App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox localport;
        private System.Windows.Forms.TextBox localipp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox remoteport;
        private System.Windows.Forms.TextBox remoteip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox Textmessage;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.ListBox listmessage;
        private System.Windows.Forms.Label label5;
    }
}

