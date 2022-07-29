namespace ChatApp_Project
{
    partial class MessageForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserFriendName = new System.Windows.Forms.Label();
            this.userImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSend = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.messages = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.lblUserFriendName);
            this.guna2Panel1.Controls.Add(this.userImage);
            this.guna2Panel1.Controls.Add(this.btnBack);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 0;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.guna2Panel1.ShadowDecoration.Depth = 100;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.guna2Panel1.Size = new System.Drawing.Size(531, 61);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(134, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Active Now";
            // 
            // lblUserFriendName
            // 
            this.lblUserFriendName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFriendName.ForeColor = System.Drawing.Color.Silver;
            this.lblUserFriendName.Location = new System.Drawing.Point(129, 7);
            this.lblUserFriendName.Name = "lblUserFriendName";
            this.lblUserFriendName.Size = new System.Drawing.Size(358, 27);
            this.lblUserFriendName.TabIndex = 4;
            this.lblUserFriendName.Text = "Messages";
            // 
            // userImage
            // 
            this.userImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.userImage.ImageRotate = 0F;
            this.userImage.Location = new System.Drawing.Point(71, 5);
            this.userImage.Name = "userImage";
            this.userImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userImage.Size = new System.Drawing.Size(52, 50);
            this.userImage.TabIndex = 3;
            this.userImage.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Location = new System.Drawing.Point(19, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBack.Size = new System.Drawing.Size(46, 40);
            this.btnBack.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.txtMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 563);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 86);
            this.panel1.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.IndicateFocus = true;
            this.btnSend.Location = new System.Drawing.Point(445, 19);
            this.btnSend.Name = "btnSend";
            this.btnSend.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSend.Size = new System.Drawing.Size(49, 49);
            this.btnSend.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtMessage.BorderRadius = 100;
            this.txtMessage.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtMessage.BorderThickness = 0;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.DefaultText = "";
            this.txtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.ForeColor = System.Drawing.Color.Silver;
            this.txtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Location = new System.Drawing.Point(36, 19);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.PlaceholderText = "Send a Message...";
            this.txtMessage.SelectedText = "";
            this.txtMessage.Size = new System.Drawing.Size(403, 49);
            this.txtMessage.TabIndex = 2;
            // 
            // messages
            // 
            this.messages.AutoScroll = true;
            this.messages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messages.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.messages.Location = new System.Drawing.Point(0, 61);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(531, 502);
            this.messages.TabIndex = 2;
            this.messages.WrapContents = false;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.messages);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "MessageForm";
            this.Size = new System.Drawing.Size(531, 649);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userImage;
        private Guna.UI2.WinForms.Guna2CircleButton btnBack;
        private System.Windows.Forms.Label lblUserFriendName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnSend;
        private Guna.UI2.WinForms.Guna2TextBox txtMessage;
        private System.Windows.Forms.FlowLayoutPanel messages;
    }
}
