using CPU_ProcessCoordinationAlgorithm.lang;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CPU_ProcessCoordinationAlgorithm
{
    public partial class FormFCFS : Form
    {
        private List<Process> processes = new List<Process>();
        Guna2HtmlToolTip toolTip = new Guna2HtmlToolTip();

        public FormFCFS()
        {
            InitializeComponent();
            cboType.SelectedIndex = 0;
            SetToolTipEnglish();
        }

        #region Function
        private void SetToolTipEnglish()
        {
            toolTip.SetToolTip(btnLang, "English");
            toolTip.SetToolTip(nudArrivalTime, "Unit is milliseconds");
            toolTip.SetToolTip(nudBurstTime, "Unit is milliseconds");
        }

        private void SetToolTipVietnamese()
        {
            toolTip.SetToolTip(btnLang, "Tiếng việt");
            toolTip.SetToolTip(nudArrivalTime, "Đơn vị là mili giây");
            toolTip.SetToolTip(nudBurstTime, "Đơn vị là mili giây");
        }

        private void InputDataGridViewToArray()
        {
            processes = new List<Process>(dgvInput.RowCount);
            for (int i = 0; i < dgvInput.RowCount; i++)
            {
                int arrivalTime = (cboType.SelectedIndex == 0) ? 0 : Convert.ToInt32(dgvInput.Rows[i].Cells[1].Value);
                processes.Add(new Process(
                    dgvInput.Rows[i].Cells[0].Value.ToString(), // ID
                    arrivalTime, // Arrival time
                    Convert.ToInt32(dgvInput.Rows[i].Cells[2].Value)  // Burst Time
                ));
            }

        }

        private void PrintArrayToOutput()
        {
            dgvOutput.Rows.Clear();
            for (int i = 0; i < processes.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvOutput, new object[] { processes[i].ID, processes[i].ArrivalTime, processes[i].BurstTime, processes[i].WaitTime, processes[i].TurnAroundTime, processes[i].CompletionTime });
                dgvOutput.Rows.Add(row);
            }
        }

        private void AverageTime()
        {
            int waiting = 0, turnaround = 0;

            lblAverageWaiting.Text = (btnLang.Tag.ToString() == "US") ? English.lblAverageWaiting : Vietnamese.lblAverageWaiting;
            lblAverageTurnAround.Text = (btnLang.Tag.ToString() == "US") ? English.lblAverageTurnAround : Vietnamese.lblAverageTurnAround;

            for (int i = 0; i < processes.Count - 1; i++)
            {
                waiting += processes[i].WaitTime;
                turnaround += processes[i].TurnAroundTime;

                lblAverageWaiting.Text += processes[i].WaitTime + "+";
                lblAverageTurnAround.Text += processes[i].TurnAroundTime + "+";
            }

            waiting += processes[processes.Count - 1].WaitTime;
            turnaround += processes[processes.Count - 1].TurnAroundTime;

            lblAverageWaiting.Text += processes[processes.Count - 1].WaitTime + "=" + waiting + "/" + processes.Count + "=" + (1.0 * waiting / processes.Count);
            lblAverageTurnAround.Text += processes[processes.Count - 1].TurnAroundTime + "=" + turnaround + "/" + processes.Count + "=" + (1.0 * turnaround / processes.Count);
        }

        private string CreateID()
        {
            if (dgvInput.RowCount == 0)
                return "P1";
            string oldID = dgvInput.Rows[dgvInput.RowCount - 1].Cells[0].Value.ToString();
            oldID = oldID.Substring(1);
            return "P" + (Convert.ToInt32(oldID) + 1);
        }

        #endregion
        #region Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtProcess.Text = CreateID();
            DataGridViewRow row = new DataGridViewRow();
            if (cboType.SelectedIndex == 0)
                row.CreateCells(dgvInput, new object[] { txtProcess.Text, 0, nudBurstTime.Value });
            else
                row.CreateCells(dgvInput, new object[] { txtProcess.Text, nudArrivalTime.Value, nudBurstTime.Value });
            dgvInput.Rows.Add(row);
            txtProcess.Text = CreateID();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvInput.RowCount; i++)
                if (txtProcess.Text == dgvInput.Rows[i].Cells[0].Value.ToString())
                {
                    if (cboType.SelectedIndex == 0)
                        dgvInput.Rows[i].Cells[2].Value = Convert.ToInt32(nudBurstTime.Value);
                    else
                    {
                        dgvInput.Rows[i].Cells[1].Value = Convert.ToInt32(nudArrivalTime.Value);
                        dgvInput.Rows[i].Cells[2].Value = Convert.ToInt32(nudBurstTime.Value);
                    }
                }
            txtProcess.Text = CreateID();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            InputDataGridViewToArray();
            if (cboType.SelectedIndex == 0)
            {
                FCFSNonArrivalTime.processes = processes;
                FCFSNonArrivalTime.AlgorithmProcessing();
            }
            else if (cboType.SelectedIndex == 1)
            {
                FCFSArrivalTime.processes = processes;
                FCFSArrivalTime.AlgorithmProcessing();
            }
            PrintArrayToOutput();
            AverageTime();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvInput.Rows.Clear();
            txtProcess.Text = CreateID();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == 0)
            {
                lblArrivalTime.Visible = nudArrivalTime.Visible = false;
                colInputArrivalTime.Visible = false;
                colOutputArrivalTime.Visible = colOutputCompletionTime.Visible = false;
            }
            else
            {
                lblArrivalTime.Visible = nudArrivalTime.Visible = true;
                colInputArrivalTime.Visible = true;
                colOutputArrivalTime.Visible = colOutputCompletionTime.Visible = true;
            }
        }

        private void dgvInput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInput.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgvInput.SelectedRows[0];
                txtProcess.Text = row.Cells[0].Value.ToString();
                nudBurstTime.Value = Convert.ToInt32(row.Cells[2].Value);
                if (cboType.SelectedIndex == 1)
                    nudArrivalTime.Value = Convert.ToInt32(row.Cells[1].Value);
            }
        }

        private void btnLang_Click(object sender, EventArgs e)
        {
            if (btnLang.Tag.ToString() == "US")
            {
                // Form
                lblTitle.Text = Vietnamese.lblTitleFCFS;
                lblType.Text = Vietnamese.lblType;
                cboType.Items[0] = Vietnamese.cboTypeItem0FCFS;
                cboType.Items[1] = Vietnamese.cboTypeItem1FCFS;

                //Add process gruop
                grbAddProcess.Text = Vietnamese.grbAddProcess;
                lblProcess.Text = Vietnamese.lblProcess;
                lblArrivalTime.Text = Vietnamese.lblArrivalTime;
                lblBurstTime.Text = Vietnamese.lblBurstTime;
                btnAdd.Text = Vietnamese.btnAdd;
                btnEdit.Text = Vietnamese.btnEdit;
                dgvInput.Columns[0].HeaderText = Vietnamese.dgvColumns0Header;
                dgvInput.Columns[1].HeaderText = Vietnamese.dgvColumns1Header;
                dgvInput.Columns[2].HeaderText = Vietnamese.dgvColumns2Header;

                // Form
                btnAnswer.Text = Vietnamese.btnAnswer;
                btnClear.Text = Vietnamese.btnClear;

                //Answer gruop
                dgvOutput.Columns[0].HeaderText = Vietnamese.dgvColumns0Header;
                dgvOutput.Columns[1].HeaderText = Vietnamese.dgvColumns1Header;
                dgvOutput.Columns[2].HeaderText = Vietnamese.dgvColumns2Header;
                dgvOutput.Columns[3].HeaderText = Vietnamese.dgvColumns3Header;
                dgvOutput.Columns[4].HeaderText = Vietnamese.dgvColumns4Header;
                dgvOutput.Columns[5].HeaderText = Vietnamese.dgvColumns5Header;
                lblAverageWaiting.Text = Vietnamese.lblAverageWaiting + "0.00";
                lblAverageTurnAround.Text = Vietnamese.lblAverageTurnAround + "0.00";
                
                btnLang.Tag = "VN";
                btnLang.BackgroundImage = CPU_ProcessCoordinationAlgorithm.Properties.Resources.VN;
                SetToolTipVietnamese();
            }
            else
            {
                // Form
                lblTitle.Text = English.lblTitleFCFS;
                lblType.Text = English.lblType;
                cboType.Items[0] = English.cboTypeItem0FCFS;
                cboType.Items[1] = English.cboTypeItem1FCFS;

                //Add process gruop
                grbAddProcess.Text = English.grbAddProcess;
                lblProcess.Text = English.lblProcess;
                lblArrivalTime.Text = English.lblArrivalTime;
                lblBurstTime.Text = English.lblBurstTime;
                btnAdd.Text = English.btnAdd;
                btnEdit.Text = English.btnEdit;
                dgvInput.Columns[0].HeaderText = English.dgvColumns0Header;
                dgvInput.Columns[1].HeaderText = English.dgvColumns1Header;
                dgvInput.Columns[2].HeaderText = English.dgvColumns2Header;

                // Form
                btnAnswer.Text = English.btnAnswer;
                btnClear.Text = English.btnClear;

                //Answer gruop
                dgvOutput.Columns[0].HeaderText = English.dgvColumns0Header;
                dgvOutput.Columns[1].HeaderText = English.dgvColumns1Header;
                dgvOutput.Columns[2].HeaderText = English.dgvColumns2Header;
                dgvOutput.Columns[3].HeaderText = English.dgvColumns3Header;
                dgvOutput.Columns[4].HeaderText = English.dgvColumns4Header;
                dgvOutput.Columns[5].HeaderText = English.dgvColumns5Header;
                lblAverageWaiting.Text = English.lblAverageWaiting + "0.00";
                lblAverageTurnAround.Text = English.lblAverageTurnAround + "0.00";

                btnLang.Tag = "US";
                btnLang.BackgroundImage = CPU_ProcessCoordinationAlgorithm.Properties.Resources.US;
                SetToolTipEnglish();
            }
        }
    }
}
