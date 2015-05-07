namespace HtmlCssJsTemplate
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtCss = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHtml = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnIe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkJs = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCss
            // 
            this.txtCss.AcceptsReturn = true;
            this.txtCss.AcceptsTab = true;
            this.txtCss.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCss.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCss.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCss.Location = new System.Drawing.Point(12, 54);
            this.txtCss.Multiline = true;
            this.txtCss.Name = "txtCss";
            this.txtCss.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCss.Size = new System.Drawing.Size(590, 179);
            this.txtCss.TabIndex = 0;
            this.txtCss.Text = "p {color:red; }";
            this.txtCss.TextChanged += new System.EventHandler(this.txtCss_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "CSS:";
            // 
            // txtHtml
            // 
            this.txtHtml.AcceptsReturn = true;
            this.txtHtml.AcceptsTab = true;
            this.txtHtml.BackColor = System.Drawing.Color.LightCyan;
            this.txtHtml.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHtml.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHtml.Location = new System.Drawing.Point(12, 263);
            this.txtHtml.Multiline = true;
            this.txtHtml.Name = "txtHtml";
            this.txtHtml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHtml.Size = new System.Drawing.Size(590, 539);
            this.txtHtml.TabIndex = 2;
            this.txtHtml.Text = resources.GetString("txtHtml.Text");
            this.txtHtml.WordWrap = false;
            this.txtHtml.TextChanged += new System.EventHandler(this.txtHtml_TextChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(621, 263);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(586, 539);
            this.webBrowser1.TabIndex = 4;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(1132, 808);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "show HTML";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(979, 808);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(103, 23);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "copy to clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnIe
            // 
            this.btnIe.Location = new System.Drawing.Point(856, 808);
            this.btnIe.Name = "btnIe";
            this.btnIe.Size = new System.Drawing.Size(75, 23);
            this.btnIe.TabIndex = 8;
            this.btnIe.Text = "Open in IE";
            this.btnIe.UseVisualStyleBackColor = true;
            this.btnIe.Click += new System.EventHandler(this.btnIe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "HTML:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(625, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "WEB:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(399, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "HTML, JS/JQUERY AND CSS LIVE";
            // 
            // txtJs
            // 
            this.txtJs.AcceptsReturn = true;
            this.txtJs.AcceptsTab = true;
            this.txtJs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJs.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtJs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJs.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJs.Location = new System.Drawing.Point(621, 54);
            this.txtJs.Multiline = true;
            this.txtJs.Name = "txtJs";
            this.txtJs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtJs.Size = new System.Drawing.Size(590, 179);
            this.txtJs.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(623, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "JS / JQUERY:";
            // 
            // chkJs
            // 
            this.chkJs.AutoSize = true;
            this.chkJs.Location = new System.Drawing.Point(1128, 34);
            this.chkJs.Name = "chkJs";
            this.chkJs.Size = new System.Drawing.Size(71, 17);
            this.chkJs.TabIndex = 16;
            this.chkJs.Text = "Activated";
            this.chkJs.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1042, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Your IE version:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(1119, 244);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(29, 13);
            this.lblVersion.TabIndex = 22;
            this.lblVersion.Text = "label";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRun
            // 
            this.btnRun.Image = global::HtmlCssJsTemplate.Properties.Resources.ic_play_arrow_black_24dp;
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(729, 235);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(57, 25);
            this.btnRun.TabIndex = 20;
            this.btnRun.Text = "Run";
            this.btnRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::HtmlCssJsTemplate.Properties.Resources.ic_close_black_24dp;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.Location = new System.Drawing.Point(670, 235);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(55, 25);
            this.btnStop.TabIndex = 19;
            this.btnStop.Text = "Stop";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 838);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.chkJs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtJs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIe);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txtHtml);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCss);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1235, 876);
            this.MinimumSize = new System.Drawing.Size(1235, 876);
            this.Name = "frmMain";
            this.Text = "HTML TEMPLATE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHtml;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnIe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkJs;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVersion;
    }
}

