
namespace CPU_ProcessCoordinationAlgorithm
{
    partial class FormFCFS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFCFS));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAnswer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.grbAnswer = new System.Windows.Forms.GroupBox();
            this.dgvOutput = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colOutputID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutputArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutputBrustTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutputWaitingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutputTurnAroundTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutputCompletionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAverageWaiting = new System.Windows.Forms.Label();
            this.lblAverageTurnAround = new System.Windows.Forms.Label();
            this.grbAddProcess = new System.Windows.Forms.GroupBox();
            this.txtProcess = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvInput = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colInputID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInputArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInputBurstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.nudArrivalTime = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudBurstTime = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.lblBurstTime = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnLang = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTitle.SuspendLayout();
            this.grbAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.grbAddProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArrivalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstTime)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(172)))), ((int)(((byte)(254)))));
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(480, 50);
            this.pnlTitle.TabIndex = 11;
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
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(430, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(165, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "FCFS Algorithm";
            // 
            // cboType
            // 
            this.cboType.BackColor = System.Drawing.Color.Transparent;
            this.cboType.BorderRadius = 10;
            this.cboType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboType.FocusedState.Parent = this.cboType;
            this.cboType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboType.HoverState.Parent = this.cboType;
            this.cboType.ItemHeight = 30;
            this.cboType.Items.AddRange(new object[] {
            "FCFS Non Arrival Time",
            "FCFS Arrival Time"});
            this.cboType.ItemsAppearance.Parent = this.cboType;
            this.cboType.Location = new System.Drawing.Point(170, 57);
            this.cboType.Name = "cboType";
            this.cboType.ShadowDecoration.Parent = this.cboType;
            this.cboType.Size = new System.Drawing.Size(214, 36);
            this.cboType.TabIndex = 29;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 6;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.DisabledState.Parent = this.btnClear;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(279, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.BorderRadius = 6;
            this.btnAnswer.CheckedState.Parent = this.btnAnswer;
            this.btnAnswer.CustomImages.Parent = this.btnAnswer;
            this.btnAnswer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnswer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnswer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnswer.DisabledState.Parent = this.btnAnswer;
            this.btnAnswer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.ForeColor = System.Drawing.Color.White;
            this.btnAnswer.HoverState.Parent = this.btnAnswer;
            this.btnAnswer.Location = new System.Drawing.Point(110, 295);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.ShadowDecoration.Parent = this.btnAnswer;
            this.btnAnswer.Size = new System.Drawing.Size(80, 30);
            this.btnAnswer.TabIndex = 28;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // grbAnswer
            // 
            this.grbAnswer.Controls.Add(this.dgvOutput);
            this.grbAnswer.Controls.Add(this.lblAverageWaiting);
            this.grbAnswer.Controls.Add(this.lblAverageTurnAround);
            this.grbAnswer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAnswer.Location = new System.Drawing.Point(13, 331);
            this.grbAnswer.Name = "grbAnswer";
            this.grbAnswer.Size = new System.Drawing.Size(455, 214);
            this.grbAnswer.TabIndex = 26;
            this.grbAnswer.TabStop = false;
            this.grbAnswer.Text = "Answer";
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvOutput.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvOutput.BackgroundColor = System.Drawing.Color.White;
            this.dgvOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOutput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOutput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOutput.ColumnHeadersHeight = 36;
            this.dgvOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOutputID,
            this.colOutputArrivalTime,
            this.colOutputBrustTime,
            this.colOutputWaitingTime,
            this.colOutputTurnAroundTime,
            this.colOutputCompletionTime});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOutput.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOutput.EnableHeadersVisualStyles = false;
            this.dgvOutput.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOutput.Location = new System.Drawing.Point(6, 24);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.RowHeadersVisible = false;
            this.dgvOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutput.Size = new System.Drawing.Size(443, 145);
            this.dgvOutput.TabIndex = 23;
            this.dgvOutput.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOutput.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOutput.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOutput.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOutput.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOutput.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvOutput.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOutput.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvOutput.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOutput.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOutput.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOutput.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOutput.ThemeStyle.HeaderStyle.Height = 36;
            this.dgvOutput.ThemeStyle.ReadOnly = true;
            this.dgvOutput.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOutput.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOutput.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOutput.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvOutput.ThemeStyle.RowsStyle.Height = 22;
            this.dgvOutput.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOutput.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colOutputID
            // 
            this.colOutputID.HeaderText = "ID";
            this.colOutputID.Name = "colOutputID";
            this.colOutputID.ReadOnly = true;
            this.colOutputID.Width = 43;
            // 
            // colOutputArrivalTime
            // 
            this.colOutputArrivalTime.HeaderText = "Arrival Time";
            this.colOutputArrivalTime.Name = "colOutputArrivalTime";
            this.colOutputArrivalTime.ReadOnly = true;
            this.colOutputArrivalTime.Width = 92;
            // 
            // colOutputBrustTime
            // 
            this.colOutputBrustTime.HeaderText = "Burst Time";
            this.colOutputBrustTime.Name = "colOutputBrustTime";
            this.colOutputBrustTime.ReadOnly = true;
            this.colOutputBrustTime.Width = 85;
            // 
            // colOutputWaitingTime
            // 
            this.colOutputWaitingTime.HeaderText = "Waiting Time";
            this.colOutputWaitingTime.Name = "colOutputWaitingTime";
            this.colOutputWaitingTime.ReadOnly = true;
            this.colOutputWaitingTime.Width = 97;
            // 
            // colOutputTurnAroundTime
            // 
            this.colOutputTurnAroundTime.HeaderText = "Turn Around Time";
            this.colOutputTurnAroundTime.Name = "colOutputTurnAroundTime";
            this.colOutputTurnAroundTime.ReadOnly = true;
            this.colOutputTurnAroundTime.Width = 124;
            // 
            // colOutputCompletionTime
            // 
            this.colOutputCompletionTime.HeaderText = "Completion Time";
            this.colOutputCompletionTime.Name = "colOutputCompletionTime";
            this.colOutputCompletionTime.ReadOnly = true;
            this.colOutputCompletionTime.Width = 119;
            // 
            // lblAverageWaiting
            // 
            this.lblAverageWaiting.AutoSize = true;
            this.lblAverageWaiting.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageWaiting.Location = new System.Drawing.Point(6, 172);
            this.lblAverageWaiting.Name = "lblAverageWaiting";
            this.lblAverageWaiting.Size = new System.Drawing.Size(161, 17);
            this.lblAverageWaiting.TabIndex = 8;
            this.lblAverageWaiting.Text = "Average waiting time: 0.00";
            // 
            // lblAverageTurnAround
            // 
            this.lblAverageTurnAround.AutoSize = true;
            this.lblAverageTurnAround.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageTurnAround.Location = new System.Drawing.Point(6, 191);
            this.lblAverageTurnAround.Name = "lblAverageTurnAround";
            this.lblAverageTurnAround.Size = new System.Drawing.Size(189, 17);
            this.lblAverageTurnAround.TabIndex = 8;
            this.lblAverageTurnAround.Text = "Average turn around time: 0.00";
            // 
            // grbAddProcess
            // 
            this.grbAddProcess.Controls.Add(this.txtProcess);
            this.grbAddProcess.Controls.Add(this.dgvInput);
            this.grbAddProcess.Controls.Add(this.btnEdit);
            this.grbAddProcess.Controls.Add(this.nudArrivalTime);
            this.grbAddProcess.Controls.Add(this.nudBurstTime);
            this.grbAddProcess.Controls.Add(this.btnAdd);
            this.grbAddProcess.Controls.Add(this.lblProcess);
            this.grbAddProcess.Controls.Add(this.lblArrivalTime);
            this.grbAddProcess.Controls.Add(this.lblBurstTime);
            this.grbAddProcess.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddProcess.Location = new System.Drawing.Point(11, 99);
            this.grbAddProcess.Name = "grbAddProcess";
            this.grbAddProcess.Size = new System.Drawing.Size(455, 190);
            this.grbAddProcess.TabIndex = 25;
            this.grbAddProcess.TabStop = false;
            this.grbAddProcess.Text = "Add process";
            // 
            // txtProcess
            // 
            this.txtProcess.BorderRadius = 10;
            this.txtProcess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProcess.DefaultText = "P1";
            this.txtProcess.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProcess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProcess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProcess.DisabledState.Parent = this.txtProcess;
            this.txtProcess.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProcess.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProcess.FocusedState.Parent = this.txtProcess;
            this.txtProcess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProcess.ForeColor = System.Drawing.Color.Black;
            this.txtProcess.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProcess.HoverState.Parent = this.txtProcess;
            this.txtProcess.Location = new System.Drawing.Point(111, 24);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.PasswordChar = '\0';
            this.txtProcess.PlaceholderText = "";
            this.txtProcess.ReadOnly = true;
            this.txtProcess.SelectedText = "";
            this.txtProcess.SelectionStart = 2;
            this.txtProcess.ShadowDecoration.Parent = this.txtProcess;
            this.txtProcess.Size = new System.Drawing.Size(67, 36);
            this.txtProcess.TabIndex = 30;
            // 
            // dgvInput
            // 
            this.dgvInput.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvInput.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvInput.BackgroundColor = System.Drawing.Color.White;
            this.dgvInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInput.ColumnHeadersHeight = 36;
            this.dgvInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInputID,
            this.colInputArrivalTime,
            this.colInputBurstTime});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInput.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInput.EnableHeadersVisualStyles = false;
            this.dgvInput.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInput.Location = new System.Drawing.Point(227, 24);
            this.dgvInput.Name = "dgvInput";
            this.dgvInput.ReadOnly = true;
            this.dgvInput.RowHeadersVisible = false;
            this.dgvInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInput.Size = new System.Drawing.Size(222, 156);
            this.dgvInput.TabIndex = 23;
            this.dgvInput.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInput.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvInput.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvInput.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvInput.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvInput.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvInput.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInput.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvInput.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInput.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInput.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInput.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvInput.ThemeStyle.HeaderStyle.Height = 36;
            this.dgvInput.ThemeStyle.ReadOnly = true;
            this.dgvInput.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInput.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInput.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInput.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvInput.ThemeStyle.RowsStyle.Height = 22;
            this.dgvInput.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInput.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvInput.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInput_CellClick);
            // 
            // colInputID
            // 
            this.colInputID.HeaderText = "ID";
            this.colInputID.Name = "colInputID";
            this.colInputID.ReadOnly = true;
            this.colInputID.Width = 43;
            // 
            // colInputArrivalTime
            // 
            this.colInputArrivalTime.HeaderText = "Arrival Time";
            this.colInputArrivalTime.Name = "colInputArrivalTime";
            this.colInputArrivalTime.ReadOnly = true;
            this.colInputArrivalTime.Width = 92;
            // 
            // colInputBurstTime
            // 
            this.colInputBurstTime.HeaderText = "Burst Time";
            this.colInputBurstTime.Name = "colInputBurstTime";
            this.colInputBurstTime.ReadOnly = true;
            this.colInputBurstTime.Width = 85;
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 6;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.DisabledState.Parent = this.btnEdit;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(99, 150);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // nudArrivalTime
            // 
            this.nudArrivalTime.BackColor = System.Drawing.Color.Transparent;
            this.nudArrivalTime.BorderRadius = 10;
            this.nudArrivalTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudArrivalTime.DisabledState.Parent = this.nudArrivalTime;
            this.nudArrivalTime.FocusedState.Parent = this.nudArrivalTime;
            this.nudArrivalTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudArrivalTime.ForeColor = System.Drawing.Color.Black;
            this.nudArrivalTime.Location = new System.Drawing.Point(111, 66);
            this.nudArrivalTime.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudArrivalTime.Name = "nudArrivalTime";
            this.nudArrivalTime.ShadowDecoration.Parent = this.nudArrivalTime;
            this.nudArrivalTime.Size = new System.Drawing.Size(67, 36);
            this.nudArrivalTime.TabIndex = 22;
            this.nudArrivalTime.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(255)))), ((int)(((byte)(117)))));
            // 
            // nudBurstTime
            // 
            this.nudBurstTime.BackColor = System.Drawing.Color.Transparent;
            this.nudBurstTime.BorderRadius = 10;
            this.nudBurstTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudBurstTime.DisabledState.Parent = this.nudBurstTime;
            this.nudBurstTime.FocusedState.Parent = this.nudBurstTime;
            this.nudBurstTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudBurstTime.ForeColor = System.Drawing.Color.Black;
            this.nudBurstTime.Location = new System.Drawing.Point(111, 108);
            this.nudBurstTime.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudBurstTime.Name = "nudBurstTime";
            this.nudBurstTime.ShadowDecoration.Parent = this.nudBurstTime;
            this.nudBurstTime.Size = new System.Drawing.Size(67, 36);
            this.nudBurstTime.TabIndex = 22;
            this.nudBurstTime.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(255)))), ((int)(((byte)(117)))));
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 6;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.DisabledState.Parent = this.btnAdd;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(10, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.Location = new System.Drawing.Point(9, 34);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(60, 17);
            this.lblProcess.TabIndex = 4;
            this.lblProcess.Text = "Process: ";
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalTime.Location = new System.Drawing.Point(9, 76);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(84, 17);
            this.lblArrivalTime.TabIndex = 4;
            this.lblArrivalTime.Text = "Arrival Time: ";
            // 
            // lblBurstTime
            // 
            this.lblBurstTime.AutoSize = true;
            this.lblBurstTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurstTime.Location = new System.Drawing.Point(9, 118);
            this.lblBurstTime.Name = "lblBurstTime";
            this.lblBurstTime.Size = new System.Drawing.Size(76, 17);
            this.lblBurstTime.TabIndex = 4;
            this.lblBurstTime.Text = "Burst Time: ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(119, 67);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(45, 17);
            this.lblType.TabIndex = 24;
            this.lblType.Text = "Type: ";
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.pnlTitle;
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 25;
            this.Elipse.TargetControl = this;
            // 
            // btnLang
            // 
            this.btnLang.BackgroundImage = global::CPU_ProcessCoordinationAlgorithm.Properties.Resources.US;
            this.btnLang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLang.CheckedState.Parent = this.btnLang;
            this.btnLang.CustomImages.Parent = this.btnLang;
            this.btnLang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLang.DisabledState.Parent = this.btnLang;
            this.btnLang.FillColor = System.Drawing.Color.Transparent;
            this.btnLang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLang.ForeColor = System.Drawing.Color.White;
            this.btnLang.HoverState.Parent = this.btnLang;
            this.btnLang.Location = new System.Drawing.Point(426, 56);
            this.btnLang.Name = "btnLang";
            this.btnLang.ShadowDecoration.Parent = this.btnLang;
            this.btnLang.Size = new System.Drawing.Size(40, 30);
            this.btnLang.TabIndex = 30;
            this.btnLang.Tag = "US";
            this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
            // 
            // FormFCFS
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(480, 565);
            this.Controls.Add(this.btnLang);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.grbAnswer);
            this.Controls.Add(this.grbAddProcess);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormFCFS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFCFS";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.grbAnswer.ResumeLayout(false);
            this.grbAnswer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.grbAddProcess.ResumeLayout(false);
            this.grbAddProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArrivalTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ComboBox cboType;
        private Guna.UI2.WinForms.Guna2GradientButton btnClear;
        private Guna.UI2.WinForms.Guna2GradientButton btnAnswer;
        private System.Windows.Forms.GroupBox grbAnswer;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOutput;
        private System.Windows.Forms.Label lblAverageWaiting;
        private System.Windows.Forms.Label lblAverageTurnAround;
        private System.Windows.Forms.GroupBox grbAddProcess;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInputID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInputArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInputBurstTime;
        private Guna.UI2.WinForms.Guna2GradientButton btnEdit;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudArrivalTime;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudBurstTime;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.Label lblBurstTime;
        private System.Windows.Forms.Label lblType;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutputID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutputArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutputBrustTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutputWaitingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutputTurnAroundTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutputCompletionTime;
        private Guna.UI2.WinForms.Guna2TextBox txtProcess;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2Button btnLang;
    }
}