
namespace CPU_ProcessCoordinationAlgorithm
{
    partial class FormCPU
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCPU));
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnFCFS = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnSJF = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnRR = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnAbout = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.DisabledState.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(476, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.lblTitle.Location = new System.Drawing.Point(107, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(306, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Process Coordination Algorithms";
            // 
            // btnFCFS
            // 
            this.btnFCFS.BackColor = System.Drawing.Color.Transparent;
            this.btnFCFS.CheckedState.Parent = this.btnFCFS;
            this.btnFCFS.CustomImages.Parent = this.btnFCFS;
            this.btnFCFS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFCFS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFCFS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFCFS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFCFS.DisabledState.Parent = this.btnFCFS;
            this.btnFCFS.FillColor = System.Drawing.Color.White;
            this.btnFCFS.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFCFS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(155)))), ((int)(((byte)(244)))));
            this.btnFCFS.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(155)))), ((int)(((byte)(244)))));
            this.btnFCFS.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnFCFS.HoverState.Parent = this.btnFCFS;
            this.btnFCFS.Location = new System.Drawing.Point(25, 72);
            this.btnFCFS.Name = "btnFCFS";
            this.btnFCFS.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnFCFS.ShadowDecoration.Parent = this.btnFCFS;
            this.btnFCFS.Size = new System.Drawing.Size(100, 100);
            this.btnFCFS.TabIndex = 2;
            this.btnFCFS.Text = "FCFS";
            this.btnFCFS.Click += new System.EventHandler(this.btnFCFS_Click);
            // 
            // btnSJF
            // 
            this.btnSJF.BackColor = System.Drawing.Color.Transparent;
            this.btnSJF.CheckedState.Parent = this.btnSJF;
            this.btnSJF.CustomImages.Parent = this.btnSJF;
            this.btnSJF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSJF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSJF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSJF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSJF.DisabledState.Parent = this.btnSJF;
            this.btnSJF.FillColor = System.Drawing.Color.White;
            this.btnSJF.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSJF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(155)))), ((int)(((byte)(244)))));
            this.btnSJF.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(155)))), ((int)(((byte)(244)))));
            this.btnSJF.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSJF.HoverState.Parent = this.btnSJF;
            this.btnSJF.Location = new System.Drawing.Point(149, 72);
            this.btnSJF.Name = "btnSJF";
            this.btnSJF.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSJF.ShadowDecoration.Parent = this.btnSJF;
            this.btnSJF.Size = new System.Drawing.Size(100, 100);
            this.btnSJF.TabIndex = 2;
            this.btnSJF.Text = "SJF";
            this.btnSJF.Click += new System.EventHandler(this.btnSJF_Click);
            // 
            // btnRR
            // 
            this.btnRR.BackColor = System.Drawing.Color.Transparent;
            this.btnRR.CheckedState.Parent = this.btnRR;
            this.btnRR.CustomImages.Parent = this.btnRR;
            this.btnRR.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRR.DisabledState.Parent = this.btnRR;
            this.btnRR.FillColor = System.Drawing.Color.White;
            this.btnRR.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(155)))), ((int)(((byte)(244)))));
            this.btnRR.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(155)))), ((int)(((byte)(244)))));
            this.btnRR.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRR.HoverState.Parent = this.btnRR;
            this.btnRR.Location = new System.Drawing.Point(273, 72);
            this.btnRR.Name = "btnRR";
            this.btnRR.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRR.ShadowDecoration.Parent = this.btnRR;
            this.btnRR.Size = new System.Drawing.Size(100, 100);
            this.btnRR.TabIndex = 2;
            this.btnRR.Text = "RR";
            this.btnRR.Click += new System.EventHandler(this.btnRR_Click);
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 25;
            this.Elipse.TargetControl = this;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.CheckedState.Parent = this.btnAbout;
            this.btnAbout.CustomImages.Parent = this.btnAbout;
            this.btnAbout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAbout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAbout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAbout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAbout.DisabledState.Parent = this.btnAbout;
            this.btnAbout.FillColor = System.Drawing.Color.White;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(155)))), ((int)(((byte)(244)))));
            this.btnAbout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(155)))), ((int)(((byte)(244)))));
            this.btnAbout.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAbout.HoverState.Parent = this.btnAbout;
            this.btnAbout.Location = new System.Drawing.Point(397, 72);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAbout.ShadowDecoration.Parent = this.btnAbout;
            this.btnAbout.Size = new System.Drawing.Size(100, 100);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // FormCPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(527, 200);
            this.Controls.Add(this.btnRR);
            this.Controls.Add(this.btnSJF);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnFCFS);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCPU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCPU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2CircleButton btnRR;
        private Guna.UI2.WinForms.Guna2CircleButton btnSJF;
        private Guna.UI2.WinForms.Guna2CircleButton btnFCFS;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2CircleButton btnAbout;
    }
}