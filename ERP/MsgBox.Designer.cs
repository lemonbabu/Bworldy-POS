
namespace ERP
{
    partial class MsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.lblMsg1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnOk = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMsg3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMsg2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMsg1
            // 
            this.lblMsg1.AutoSize = true;
            this.lblMsg1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMsg1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMsg1.Location = new System.Drawing.Point(0, 0);
            this.lblMsg1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblMsg1.Name = "lblMsg1";
            this.lblMsg1.Size = new System.Drawing.Size(2, 15);
            this.lblMsg1.TabIndex = 3;
            this.lblMsg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            this.btnOk.AllowToggling = false;
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.AnimationSpeed = 200;
            this.btnOk.AutoGenerateColors = false;
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
            this.btnOk.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOk.ButtonText = "OK";
            this.btnOk.ButtonTextMarginLeft = 0;
            this.btnOk.ColorContrastOnClick = 45;
            this.btnOk.ColorContrastOnHover = 45;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnOk.CustomizableEdges = borderEdges1;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOk.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnOk.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOk.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOk.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.IconMarginLeft = 11;
            this.btnOk.IconPadding = 10;
            this.btnOk.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnOk.IdleBorderRadius = 3;
            this.btnOk.IdleBorderThickness = 1;
            this.btnOk.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnOk.IdleIconLeftImage = null;
            this.btnOk.IdleIconRightImage = null;
            this.btnOk.IndicateFocus = false;
            this.btnOk.Location = new System.Drawing.Point(73, 66);
            this.btnOk.Name = "btnOk";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnOk.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnOk.OnPressedState = stateProperties2;
            this.btnOk.Size = new System.Drawing.Size(40, 25);
            this.btnOk.TabIndex = 2;
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOk.TextMarginLeft = 0;
            this.btnOk.UseDefaultRadiusAndThickness = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMsg3);
            this.panel1.Controls.Add(this.lblMsg2);
            this.panel1.Controls.Add(this.lblMsg1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 49);
            this.panel1.TabIndex = 4;
            // 
            // lblMsg3
            // 
            this.lblMsg3.AutoSize = true;
            this.lblMsg3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMsg3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMsg3.Location = new System.Drawing.Point(0, 30);
            this.lblMsg3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblMsg3.Name = "lblMsg3";
            this.lblMsg3.Size = new System.Drawing.Size(2, 15);
            this.lblMsg3.TabIndex = 5;
            this.lblMsg3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMsg2
            // 
            this.lblMsg2.AutoSize = true;
            this.lblMsg2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMsg2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMsg2.Location = new System.Drawing.Point(0, 15);
            this.lblMsg2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblMsg2.Name = "lblMsg2";
            this.lblMsg2.Size = new System.Drawing.Size(2, 15);
            this.lblMsg2.TabIndex = 4;
            this.lblMsg2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(91)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(187, 93);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOk);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MsgBox";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblMsg1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOk;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMsg3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMsg2;
    }
}