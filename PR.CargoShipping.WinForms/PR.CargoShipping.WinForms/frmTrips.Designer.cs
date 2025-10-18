namespace PR.CargoShipping.WinForms
{
    partial class frmTrips
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
            label1 = new Label();
            label2 = new Label();
            txtTripNumber = new TextBox();
            listPorts = new ComboBox();
            btnSearchByPort = new Button();
            btnSearchByTripNumber = new Button();
            gvTrips = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gvTrips).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Ports";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "Trip Number";
            // 
            // txtTripNumber
            // 
            txtTripNumber.Location = new Point(116, 38);
            txtTripNumber.Name = "txtTripNumber";
            txtTripNumber.Size = new Size(121, 23);
            txtTripNumber.TabIndex = 3;
            // 
            // listPorts
            // 
            listPorts.FormattingEnabled = true;
            listPorts.Location = new Point(116, 6);
            listPorts.Name = "listPorts";
            listPorts.Size = new Size(121, 23);
            listPorts.TabIndex = 4;
            // 
            // btnSearchByPort
            // 
            btnSearchByPort.Location = new Point(261, 6);
            btnSearchByPort.Name = "btnSearchByPort";
            btnSearchByPort.Size = new Size(75, 23);
            btnSearchByPort.TabIndex = 5;
            btnSearchByPort.Text = "Search";
            btnSearchByPort.UseVisualStyleBackColor = true;
            btnSearchByPort.Click += btnSearchByPort_Click;
            // 
            // btnSearchByTripNumber
            // 
            btnSearchByTripNumber.Location = new Point(261, 38);
            btnSearchByTripNumber.Name = "btnSearchByTripNumber";
            btnSearchByTripNumber.Size = new Size(75, 23);
            btnSearchByTripNumber.TabIndex = 6;
            btnSearchByTripNumber.Text = "Search";
            btnSearchByTripNumber.UseVisualStyleBackColor = true;
            btnSearchByTripNumber.Click += btnSearchByTripNumber_Click;
            // 
            // gvTrips
            // 
            gvTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvTrips.Location = new Point(12, 89);
            gvTrips.Name = "gvTrips";
            gvTrips.Size = new Size(776, 252);
            gvTrips.TabIndex = 7;
            gvTrips.CellPainting += gvTrips_CellPainting;
            gvTrips.DataBindingComplete += gvTrips_DataBindingComplete;
            // 
            // frmTrips
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gvTrips);
            Controls.Add(btnSearchByTripNumber);
            Controls.Add(btnSearchByPort);
            Controls.Add(listPorts);
            Controls.Add(txtTripNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTrips";
            Text = "frmTrips";
            Load += frmTrips_Load;
            ((System.ComponentModel.ISupportInitialize)gvTrips).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTripNumber;
        private ComboBox listPorts;
        private Button btnSearchByPort;
        private Button btnSearchByTripNumber;
        private DataGridView gvTrips;
    }
}