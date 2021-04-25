
namespace ERP
{
    partial class frmClearHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClearHistory));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlClearHistoryMain = new System.Windows.Forms.Panel();
            this.pnlConfirmationPassword = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteSales = new System.Windows.Forms.Button();
            this.btnDeleteStock = new System.Windows.Forms.Button();
            this.btnDeleteActivitys = new System.Windows.Forms.Button();
            this.btnDeleteSession = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.pnlClearHistoryMain.SuspendLayout();
            this.pnlConfirmationPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(550, 70);
            this.pnlTitle.TabIndex = 0;
            // 
            // pnlClearHistoryMain
            // 
            this.pnlClearHistoryMain.Controls.Add(this.btnClearAll);
            this.pnlClearHistoryMain.Controls.Add(this.btnDeleteActivitys);
            this.pnlClearHistoryMain.Controls.Add(this.btnDeleteSession);
            this.pnlClearHistoryMain.Controls.Add(this.btnDeleteSales);
            this.pnlClearHistoryMain.Controls.Add(this.btnDeleteStock);
            this.pnlClearHistoryMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClearHistoryMain.Location = new System.Drawing.Point(0, 70);
            this.pnlClearHistoryMain.Name = "pnlClearHistoryMain";
            this.pnlClearHistoryMain.Size = new System.Drawing.Size(550, 380);
            this.pnlClearHistoryMain.TabIndex = 1;
            // 
            // pnlConfirmationPassword
            // 
            this.pnlConfirmationPassword.Controls.Add(this.label2);
            this.pnlConfirmationPassword.Controls.Add(this.txtPassword);
            this.pnlConfirmationPassword.Controls.Add(this.btnOk);
            this.pnlConfirmationPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfirmationPassword.Location = new System.Drawing.Point(0, 70);
            this.pnlConfirmationPassword.Name = "pnlConfirmationPassword";
            this.pnlConfirmationPassword.Size = new System.Drawing.Size(550, 380);
            this.pnlConfirmationPassword.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(149, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLEAR HISTORY";
            // 
            // btnDeleteSales
            // 
            this.btnDeleteSales.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSales.Image = global::ERP.Properties.Resources.remove_25px;
            this.btnDeleteSales.Location = new System.Drawing.Point(300, 27);
            this.btnDeleteSales.Name = "btnDeleteSales";
            this.btnDeleteSales.Size = new System.Drawing.Size(117, 88);
            this.btnDeleteSales.TabIndex = 1;
            this.btnDeleteSales.Text = "DELETE SALES DATA";
            this.btnDeleteSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteSales.UseVisualStyleBackColor = true;
            this.btnDeleteSales.Click += new System.EventHandler(this.btnDeleteSales_Click);
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStock.Image = global::ERP.Properties.Resources.delete_25px;
            this.btnDeleteStock.Location = new System.Drawing.Point(122, 27);
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Size = new System.Drawing.Size(117, 88);
            this.btnDeleteStock.TabIndex = 0;
            this.btnDeleteStock.Text = "DELETE STOCK DATA";
            this.btnDeleteStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteStock.UseVisualStyleBackColor = true;
            this.btnDeleteStock.Click += new System.EventHandler(this.btnDeleteStock_Click);
            // 
            // btnDeleteActivitys
            // 
            this.btnDeleteActivitys.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteActivitys.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteActivitys.Image = global::ERP.Properties.Resources.remove_25px;
            this.btnDeleteActivitys.Location = new System.Drawing.Point(300, 153);
            this.btnDeleteActivitys.Name = "btnDeleteActivitys";
            this.btnDeleteActivitys.Size = new System.Drawing.Size(117, 88);
            this.btnDeleteActivitys.TabIndex = 3;
            this.btnDeleteActivitys.Text = "DELETE ACTIVITYS";
            this.btnDeleteActivitys.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteActivitys.UseVisualStyleBackColor = true;
            this.btnDeleteActivitys.Click += new System.EventHandler(this.btnDeleteActivitys_Click);
            // 
            // btnDeleteSession
            // 
            this.btnDeleteSession.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteSession.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSession.Image = global::ERP.Properties.Resources.delete_25px;
            this.btnDeleteSession.Location = new System.Drawing.Point(122, 153);
            this.btnDeleteSession.Name = "btnDeleteSession";
            this.btnDeleteSession.Size = new System.Drawing.Size(117, 88);
            this.btnDeleteSession.TabIndex = 2;
            this.btnDeleteSession.Text = "CLEAR SESSION";
            this.btnDeleteSession.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteSession.UseVisualStyleBackColor = true;
            this.btnDeleteSession.Click += new System.EventHandler(this.btnDeleteSession_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(217, 228);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(102, 44);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "CONFIRM";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.AnimationSpeed = 200;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPassword.BorderRadius = 1;
            this.txtPassword.BorderThickness = 1;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.White;
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = null;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.IconPadding = 10;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(168, 153);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtPassword.Modified = false;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPassword.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnIdleState = stateProperties8;
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPassword.PlaceholderText = "Enter text";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(200, 35);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextMarginBottom = 0;
            this.txtPassword.TextMarginLeft = 5;
            this.txtPassword.TextMarginTop = 0;
            this.txtPassword.TextPlaceholder = "Enter text";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WordWrap = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(163, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADMIN PASSWORD";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Image = global::ERP.Properties.Resources.remove_25px;
            this.btnClearAll.Location = new System.Drawing.Point(165, 275);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(203, 75);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "CLEAR ALL";
            this.btnClearAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // frmClearHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.pnlClearHistoryMain);
            this.Controls.Add(this.pnlConfirmationPassword);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClearHistory";
            this.Text = "frmClearHistory";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlClearHistoryMain.ResumeLayout(false);
            this.pnlConfirmationPassword.ResumeLayout(false);
            this.pnlConfirmationPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlClearHistoryMain;
        private System.Windows.Forms.Button btnDeleteStock;
        private System.Windows.Forms.Panel pnlConfirmationPassword;
        private System.Windows.Forms.Button btnDeleteSales;
        private System.Windows.Forms.Button btnDeleteActivitys;
        private System.Windows.Forms.Button btnDeleteSession;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtPassword;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClearAll;
    }
}