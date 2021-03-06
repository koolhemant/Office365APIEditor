﻿namespace Office365APIEditor
{
    partial class AcquireViewerTokenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcquireViewerTokenForm));
            this.textBox_ClientID = new System.Windows.Forms.TextBox();
            this.button_AcquireAccessToken = new System.Windows.Forms.Button();
            this.button1_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_UseBuiltInApp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_ClientID
            // 
            this.textBox_ClientID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Office365APIEditor.Properties.Settings.Default, "LastMailboxViewerClientID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_ClientID.Location = new System.Drawing.Point(110, 63);
            this.textBox_ClientID.Name = "textBox_ClientID";
            this.textBox_ClientID.Size = new System.Drawing.Size(224, 20);
            this.textBox_ClientID.TabIndex = 0;
            this.textBox_ClientID.Text = global::Office365APIEditor.Properties.Settings.Default.LastMailboxViewerClientID;
            // 
            // button_AcquireAccessToken
            // 
            this.button_AcquireAccessToken.Location = new System.Drawing.Point(489, 94);
            this.button_AcquireAccessToken.Name = "button_AcquireAccessToken";
            this.button_AcquireAccessToken.Size = new System.Drawing.Size(75, 23);
            this.button_AcquireAccessToken.TabIndex = 2;
            this.button_AcquireAccessToken.Text = "OK";
            this.button_AcquireAccessToken.UseVisualStyleBackColor = true;
            this.button_AcquireAccessToken.Click += new System.EventHandler(this.button_AcquireAccessToken_Click);
            // 
            // button1_Cancel
            // 
            this.button1_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1_Cancel.Location = new System.Drawing.Point(570, 94);
            this.button1_Cancel.Name = "button1_Cancel";
            this.button1_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button1_Cancel.TabIndex = 3;
            this.button1_Cancel.Text = "Cancel";
            this.button1_Cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Application ID : ";
            // 
            // button_UseBuiltInApp
            // 
            this.button_UseBuiltInApp.Location = new System.Drawing.Point(15, 94);
            this.button_UseBuiltInApp.Name = "button_UseBuiltInApp";
            this.button_UseBuiltInApp.Size = new System.Drawing.Size(171, 23);
            this.button_UseBuiltInApp.TabIndex = 1;
            this.button_UseBuiltInApp.Text = "Use the built-in application";
            this.button_UseBuiltInApp.UseVisualStyleBackColor = true;
            this.button_UseBuiltInApp.Click += new System.EventHandler(this.button_UseBuiltInApp_ClickAsync);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(537, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // AcquireViewerTokenForm
            // 
            this.AcceptButton = this.button_AcquireAccessToken;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1_Cancel;
            this.ClientSize = new System.Drawing.Size(657, 129);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_UseBuiltInApp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_Cancel);
            this.Controls.Add(this.button_AcquireAccessToken);
            this.Controls.Add(this.textBox_ClientID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AcquireViewerTokenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application ID Setting";
            this.Load += new System.EventHandler(this.AcquireViewerTokenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_ClientID;
        private System.Windows.Forms.Button button_AcquireAccessToken;
        private System.Windows.Forms.Button button1_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_UseBuiltInApp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}