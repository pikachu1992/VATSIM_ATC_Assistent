namespace VATSIM_ATC_Assistent
{
    partial class MainFrm
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabDepartures = new System.Windows.Forms.TabPage();
            this.gboxDepartures = new System.Windows.Forms.GroupBox();
            this.chkbox35 = new System.Windows.Forms.CheckBox();
            this.btnGenerateTaxi = new System.Windows.Forms.Button();
            this.layPanelTaxiways = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGenFIXALT = new System.Windows.Forms.Button();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.cboxTransferATC = new System.Windows.Forms.ComboBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.cboxPushStart = new System.Windows.Forms.ComboBox();
            this.btnPushAndStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAliasSendTaxi = new System.Windows.Forms.Button();
            this.btnAliasSendFIXALT = new System.Windows.Forms.Button();
            this.btnAliasSendTransferATC = new System.Windows.Forms.Button();
            this.btnAliasSendPushAndStart = new System.Windows.Forms.Button();
            this.btnAliasSendClearance = new System.Windows.Forms.Button();
            this.cboxSID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerateClearance = new System.Windows.Forms.Button();
            this.txtSquawk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFlightLevelIsValid = new System.Windows.Forms.Label();
            this.lblFlightLevel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRoute = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCallsign = new System.Windows.Forms.Label();
            this.lstDeparturePilots = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabArrivals = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboxRunways = new System.Windows.Forms.ComboBox();
            this.lblMetar = new System.Windows.Forms.Label();
            this.btnClearedTakeOff = new System.Windows.Forms.Button();
            this.lstArrivalPilots = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gboxArrivals = new System.Windows.Forms.GroupBox();
            this.lblARRTransfer = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnARRAliasTransferATC = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.lblArrARR = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblArrDEP = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblARRCallsign = new System.Windows.Forms.Label();
            this.cboxARRATCTRANSF = new System.Windows.Forms.ComboBox();
            this.genTransferATCARR = new System.Windows.Forms.Button();
            this.lblARRRoute = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabDepartures.SuspendLayout();
            this.gboxDepartures.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabArrivals.SuspendLayout();
            this.gboxArrivals.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabDepartures);
            this.tabMain.Controls.Add(this.tabArrivals);
            this.tabMain.Location = new System.Drawing.Point(13, 65);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1035, 545);
            this.tabMain.TabIndex = 0;
            // 
            // tabDepartures
            // 
            this.tabDepartures.Controls.Add(this.gboxDepartures);
            this.tabDepartures.Controls.Add(this.lstDeparturePilots);
            this.tabDepartures.Location = new System.Drawing.Point(4, 24);
            this.tabDepartures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabDepartures.Name = "tabDepartures";
            this.tabDepartures.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabDepartures.Size = new System.Drawing.Size(1027, 517);
            this.tabDepartures.TabIndex = 0;
            this.tabDepartures.Text = "Departures";
            this.tabDepartures.UseVisualStyleBackColor = true;
            // 
            // gboxDepartures
            // 
            this.gboxDepartures.Controls.Add(this.btnClearedTakeOff);
            this.gboxDepartures.Controls.Add(this.chkbox35);
            this.gboxDepartures.Controls.Add(this.btnGenerateTaxi);
            this.gboxDepartures.Controls.Add(this.layPanelTaxiways);
            this.gboxDepartures.Controls.Add(this.btnGenFIXALT);
            this.gboxDepartures.Controls.Add(this.lblTransfer);
            this.gboxDepartures.Controls.Add(this.cboxTransferATC);
            this.gboxDepartures.Controls.Add(this.btnTransfer);
            this.gboxDepartures.Controls.Add(this.cboxPushStart);
            this.gboxDepartures.Controls.Add(this.btnPushAndStart);
            this.gboxDepartures.Controls.Add(this.groupBox1);
            this.gboxDepartures.Controls.Add(this.cboxSID);
            this.gboxDepartures.Controls.Add(this.label6);
            this.gboxDepartures.Controls.Add(this.btnGenerateClearance);
            this.gboxDepartures.Controls.Add(this.txtSquawk);
            this.gboxDepartures.Controls.Add(this.label4);
            this.gboxDepartures.Controls.Add(this.lblDestination);
            this.gboxDepartures.Controls.Add(this.label5);
            this.gboxDepartures.Controls.Add(this.lblDeparture);
            this.gboxDepartures.Controls.Add(this.label3);
            this.gboxDepartures.Controls.Add(this.lblFlightLevelIsValid);
            this.gboxDepartures.Controls.Add(this.lblFlightLevel);
            this.gboxDepartures.Controls.Add(this.label2);
            this.gboxDepartures.Controls.Add(this.lblRoute);
            this.gboxDepartures.Controls.Add(this.label1);
            this.gboxDepartures.Controls.Add(this.lblCallsign);
            this.gboxDepartures.Location = new System.Drawing.Point(136, 7);
            this.gboxDepartures.Name = "gboxDepartures";
            this.gboxDepartures.Size = new System.Drawing.Size(884, 496);
            this.gboxDepartures.TabIndex = 18;
            this.gboxDepartures.TabStop = false;
            this.gboxDepartures.Text = "Aircraft Info ";
            this.gboxDepartures.Visible = false;
            // 
            // chkbox35
            // 
            this.chkbox35.AutoSize = true;
            this.chkbox35.Location = new System.Drawing.Point(343, 285);
            this.chkbox35.Name = "chkbox35";
            this.chkbox35.Size = new System.Drawing.Size(136, 19);
            this.chkbox35.TabIndex = 48;
            this.chkbox35.Text = "Cross Runway 35";
            this.chkbox35.UseVisualStyleBackColor = true;
            // 
            // btnGenerateTaxi
            // 
            this.btnGenerateTaxi.Location = new System.Drawing.Point(26, 295);
            this.btnGenerateTaxi.Name = "btnGenerateTaxi";
            this.btnGenerateTaxi.Size = new System.Drawing.Size(145, 23);
            this.btnGenerateTaxi.TabIndex = 47;
            this.btnGenerateTaxi.Text = "Generate Taxi";
            this.btnGenerateTaxi.UseVisualStyleBackColor = true;
            this.btnGenerateTaxi.Visible = false;
            this.btnGenerateTaxi.Click += new System.EventHandler(this.btnGenerateTaxi_Click);
            // 
            // layPanelTaxiways
            // 
            this.layPanelTaxiways.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.layPanelTaxiways.Location = new System.Drawing.Point(343, 207);
            this.layPanelTaxiways.Name = "layPanelTaxiways";
            this.layPanelTaxiways.Size = new System.Drawing.Size(367, 69);
            this.layPanelTaxiways.TabIndex = 46;
            // 
            // btnGenFIXALT
            // 
            this.btnGenFIXALT.Location = new System.Drawing.Point(303, 176);
            this.btnGenFIXALT.Name = "btnGenFIXALT";
            this.btnGenFIXALT.Size = new System.Drawing.Size(145, 23);
            this.btnGenFIXALT.TabIndex = 45;
            this.btnGenFIXALT.Text = "Gen Fix ALT";
            this.btnGenFIXALT.UseVisualStyleBackColor = true;
            this.btnGenFIXALT.Visible = false;
            this.btnGenFIXALT.Click += new System.EventHandler(this.btnGenFIXALT_Click);
            // 
            // lblTransfer
            // 
            this.lblTransfer.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTransfer.Location = new System.Drawing.Point(17, 361);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(848, 40);
            this.lblTransfer.TabIndex = 44;
            this.lblTransfer.Text = "label6";
            this.lblTransfer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTransfer.TextChanged += new System.EventHandler(this.lblTransfer_TextChanged);
            // 
            // cboxTransferATC
            // 
            this.cboxTransferATC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTransferATC.FormattingEnabled = true;
            this.cboxTransferATC.Items.AddRange(new object[] {
            "UNICOM"});
            this.cboxTransferATC.Location = new System.Drawing.Point(176, 235);
            this.cboxTransferATC.Name = "cboxTransferATC";
            this.cboxTransferATC.Size = new System.Drawing.Size(121, 23);
            this.cboxTransferATC.TabIndex = 42;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(25, 236);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(145, 23);
            this.btnTransfer.TabIndex = 41;
            this.btnTransfer.Text = "Gen Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // cboxPushStart
            // 
            this.cboxPushStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPushStart.FormattingEnabled = true;
            this.cboxPushStart.Items.AddRange(new object[] {
            "NORTH",
            "SOUTH",
            "EAST",
            "WEST"});
            this.cboxPushStart.Location = new System.Drawing.Point(176, 266);
            this.cboxPushStart.Name = "cboxPushStart";
            this.cboxPushStart.Size = new System.Drawing.Size(121, 23);
            this.cboxPushStart.TabIndex = 39;
            this.cboxPushStart.Visible = false;
            // 
            // btnPushAndStart
            // 
            this.btnPushAndStart.Location = new System.Drawing.Point(26, 265);
            this.btnPushAndStart.Name = "btnPushAndStart";
            this.btnPushAndStart.Size = new System.Drawing.Size(145, 23);
            this.btnPushAndStart.TabIndex = 38;
            this.btnPushAndStart.Text = "Generate Push/Start";
            this.btnPushAndStart.UseVisualStyleBackColor = true;
            this.btnPushAndStart.Visible = false;
            this.btnPushAndStart.Click += new System.EventHandler(this.btnPushStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAliasSendTaxi);
            this.groupBox1.Controls.Add(this.btnAliasSendFIXALT);
            this.groupBox1.Controls.Add(this.btnAliasSendTransferATC);
            this.groupBox1.Controls.Add(this.btnAliasSendPushAndStart);
            this.groupBox1.Controls.Add(this.btnAliasSendClearance);
            this.groupBox1.Location = new System.Drawing.Point(20, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 68);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EuroScope Alias";
            // 
            // btnAliasSendTaxi
            // 
            this.btnAliasSendTaxi.Enabled = false;
            this.btnAliasSendTaxi.Location = new System.Drawing.Point(308, 29);
            this.btnAliasSendTaxi.Name = "btnAliasSendTaxi";
            this.btnAliasSendTaxi.Size = new System.Drawing.Size(145, 23);
            this.btnAliasSendTaxi.TabIndex = 18;
            this.btnAliasSendTaxi.Text = "Send Taxi";
            this.btnAliasSendTaxi.UseVisualStyleBackColor = true;
            this.btnAliasSendTaxi.Visible = false;
            this.btnAliasSendTaxi.Click += new System.EventHandler(this.btnAliasSendTaxi_Click);
            // 
            // btnAliasSendFIXALT
            // 
            this.btnAliasSendFIXALT.Location = new System.Drawing.Point(542, 29);
            this.btnAliasSendFIXALT.Name = "btnAliasSendFIXALT";
            this.btnAliasSendFIXALT.Size = new System.Drawing.Size(145, 23);
            this.btnAliasSendFIXALT.TabIndex = 17;
            this.btnAliasSendFIXALT.Text = "Send FIX ALT";
            this.btnAliasSendFIXALT.UseVisualStyleBackColor = true;
            this.btnAliasSendFIXALT.Visible = false;
            this.btnAliasSendFIXALT.Click += new System.EventHandler(this.btnAliasSendFIXALT_Click);
            // 
            // btnAliasSendTransferATC
            // 
            this.btnAliasSendTransferATC.Enabled = false;
            this.btnAliasSendTransferATC.Location = new System.Drawing.Point(693, 29);
            this.btnAliasSendTransferATC.Name = "btnAliasSendTransferATC";
            this.btnAliasSendTransferATC.Size = new System.Drawing.Size(145, 23);
            this.btnAliasSendTransferATC.TabIndex = 16;
            this.btnAliasSendTransferATC.Text = "Transfer ATC";
            this.btnAliasSendTransferATC.UseVisualStyleBackColor = true;
            this.btnAliasSendTransferATC.Click += new System.EventHandler(this.btnAliasSendTransferATC_Click);
            // 
            // btnAliasSendPushAndStart
            // 
            this.btnAliasSendPushAndStart.Enabled = false;
            this.btnAliasSendPushAndStart.Location = new System.Drawing.Point(157, 29);
            this.btnAliasSendPushAndStart.Name = "btnAliasSendPushAndStart";
            this.btnAliasSendPushAndStart.Size = new System.Drawing.Size(145, 23);
            this.btnAliasSendPushAndStart.TabIndex = 15;
            this.btnAliasSendPushAndStart.Text = "Send Push/Start";
            this.btnAliasSendPushAndStart.UseVisualStyleBackColor = true;
            this.btnAliasSendPushAndStart.Visible = false;
            this.btnAliasSendPushAndStart.Click += new System.EventHandler(this.btnAliasSendPushAndStart_Click);
            // 
            // btnAliasSendClearance
            // 
            this.btnAliasSendClearance.Enabled = false;
            this.btnAliasSendClearance.Location = new System.Drawing.Point(6, 29);
            this.btnAliasSendClearance.Name = "btnAliasSendClearance";
            this.btnAliasSendClearance.Size = new System.Drawing.Size(145, 23);
            this.btnAliasSendClearance.TabIndex = 14;
            this.btnAliasSendClearance.Text = "Send Clearance";
            this.btnAliasSendClearance.UseVisualStyleBackColor = true;
            this.btnAliasSendClearance.Click += new System.EventHandler(this.btnAliasSendClearance_Click);
            // 
            // cboxSID
            // 
            this.cboxSID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSID.FormattingEnabled = true;
            this.cboxSID.Items.AddRange(new object[] {
            "NONE"});
            this.cboxSID.Location = new System.Drawing.Point(512, 177);
            this.cboxSID.Name = "cboxSID";
            this.cboxSID.Size = new System.Drawing.Size(121, 23);
            this.cboxSID.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "SID:";
            // 
            // btnGenerateClearance
            // 
            this.btnGenerateClearance.Location = new System.Drawing.Point(25, 207);
            this.btnGenerateClearance.Name = "btnGenerateClearance";
            this.btnGenerateClearance.Size = new System.Drawing.Size(145, 23);
            this.btnGenerateClearance.TabIndex = 33;
            this.btnGenerateClearance.Text = "Generate Clearance";
            this.btnGenerateClearance.UseVisualStyleBackColor = true;
            this.btnGenerateClearance.Click += new System.EventHandler(this.btnGenerateClearance_Click);
            // 
            // txtSquawk
            // 
            this.txtSquawk.Location = new System.Drawing.Point(716, 177);
            this.txtSquawk.MaxLength = 4;
            this.txtSquawk.Name = "txtSquawk";
            this.txtSquawk.Size = new System.Drawing.Size(100, 21);
            this.txtSquawk.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Squawk:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(267, 62);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(80, 15);
            this.lblDestination.TabIndex = 30;
            this.lblDestination.Text = "Destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Destination:";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(100, 62);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(71, 15);
            this.lblDeparture.TabIndex = 28;
            this.lblDeparture.Text = "Departure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Departure:";
            // 
            // lblFlightLevelIsValid
            // 
            this.lblFlightLevelIsValid.AutoSize = true;
            this.lblFlightLevelIsValid.Location = new System.Drawing.Point(166, 180);
            this.lblFlightLevelIsValid.Name = "lblFlightLevelIsValid";
            this.lblFlightLevelIsValid.Size = new System.Drawing.Size(39, 15);
            this.lblFlightLevelIsValid.TabIndex = 26;
            this.lblFlightLevelIsValid.Text = "Valid";
            // 
            // lblFlightLevel
            // 
            this.lblFlightLevel.AutoSize = true;
            this.lblFlightLevel.Location = new System.Drawing.Point(113, 180);
            this.lblFlightLevel.Name = "lblFlightLevel";
            this.lblFlightLevel.Size = new System.Drawing.Size(23, 15);
            this.lblFlightLevel.TabIndex = 25;
            this.lblFlightLevel.Text = "FL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Flight Level:";
            // 
            // lblRoute
            // 
            this.lblRoute.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblRoute.Location = new System.Drawing.Point(78, 89);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(800, 84);
            this.lblRoute.TabIndex = 23;
            this.lblRoute.Text = "DCT DCT DCT";
            this.lblRoute.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Route:";
            // 
            // lblCallsign
            // 
            this.lblCallsign.AutoSize = true;
            this.lblCallsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallsign.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCallsign.Location = new System.Drawing.Point(17, 33);
            this.lblCallsign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCallsign.Name = "lblCallsign";
            this.lblCallsign.Size = new System.Drawing.Size(52, 18);
            this.lblCallsign.TabIndex = 21;
            this.lblCallsign.Text = "label1";
            // 
            // lstDeparturePilots
            // 
            this.lstDeparturePilots.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstDeparturePilots.Location = new System.Drawing.Point(8, 7);
            this.lstDeparturePilots.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstDeparturePilots.Name = "lstDeparturePilots";
            this.lstDeparturePilots.Size = new System.Drawing.Size(121, 496);
            this.lstDeparturePilots.TabIndex = 0;
            this.lstDeparturePilots.UseCompatibleStateImageBehavior = false;
            this.lstDeparturePilots.View = System.Windows.Forms.View.Details;
            this.lstDeparturePilots.SelectedIndexChanged += new System.EventHandler(this.lstDeparturePilots_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Departures";
            // 
            // tabArrivals
            // 
            this.tabArrivals.Controls.Add(this.gboxArrivals);
            this.tabArrivals.Controls.Add(this.lstArrivalPilots);
            this.tabArrivals.Location = new System.Drawing.Point(4, 24);
            this.tabArrivals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabArrivals.Name = "tabArrivals";
            this.tabArrivals.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabArrivals.Size = new System.Drawing.Size(1027, 517);
            this.tabArrivals.TabIndex = 1;
            this.tabArrivals.Text = "Arrivals";
            this.tabArrivals.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(766, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "RWY in use:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(969, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboxRunways
            // 
            this.cboxRunways.FormattingEnabled = true;
            this.cboxRunways.Location = new System.Drawing.Point(856, 23);
            this.cboxRunways.Name = "cboxRunways";
            this.cboxRunways.Size = new System.Drawing.Size(107, 23);
            this.cboxRunways.TabIndex = 3;
            // 
            // lblMetar
            // 
            this.lblMetar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMetar.Location = new System.Drawing.Point(59, 9);
            this.lblMetar.Name = "lblMetar";
            this.lblMetar.Size = new System.Drawing.Size(701, 40);
            this.lblMetar.TabIndex = 4;
            this.lblMetar.Text = "Metar";
            // 
            // btnClearedTakeOff
            // 
            this.btnClearedTakeOff.Location = new System.Drawing.Point(26, 324);
            this.btnClearedTakeOff.Name = "btnClearedTakeOff";
            this.btnClearedTakeOff.Size = new System.Drawing.Size(144, 23);
            this.btnClearedTakeOff.TabIndex = 49;
            this.btnClearedTakeOff.Text = "Generate TakeOff";
            this.btnClearedTakeOff.UseVisualStyleBackColor = true;
            this.btnClearedTakeOff.Visible = false;
            // 
            // lstArrivalPilots
            // 
            this.lstArrivalPilots.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lstArrivalPilots.Location = new System.Drawing.Point(8, 6);
            this.lstArrivalPilots.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstArrivalPilots.Name = "lstArrivalPilots";
            this.lstArrivalPilots.Size = new System.Drawing.Size(121, 496);
            this.lstArrivalPilots.TabIndex = 1;
            this.lstArrivalPilots.UseCompatibleStateImageBehavior = false;
            this.lstArrivalPilots.View = System.Windows.Forms.View.Details;
            this.lstArrivalPilots.SelectedIndexChanged += new System.EventHandler(this.lstArrivalPilots_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Arrivals";
            // 
            // gboxArrivals
            // 
            this.gboxArrivals.Controls.Add(this.lblARRRoute);
            this.gboxArrivals.Controls.Add(this.cboxARRATCTRANSF);
            this.gboxArrivals.Controls.Add(this.genTransferATCARR);
            this.gboxArrivals.Controls.Add(this.lblARRTransfer);
            this.gboxArrivals.Controls.Add(this.groupBox3);
            this.gboxArrivals.Controls.Add(this.lblArrARR);
            this.gboxArrivals.Controls.Add(this.label12);
            this.gboxArrivals.Controls.Add(this.lblArrDEP);
            this.gboxArrivals.Controls.Add(this.label14);
            this.gboxArrivals.Controls.Add(this.label19);
            this.gboxArrivals.Controls.Add(this.lblARRCallsign);
            this.gboxArrivals.Location = new System.Drawing.Point(136, 6);
            this.gboxArrivals.Name = "gboxArrivals";
            this.gboxArrivals.Size = new System.Drawing.Size(884, 496);
            this.gboxArrivals.TabIndex = 19;
            this.gboxArrivals.TabStop = false;
            this.gboxArrivals.Text = "Aircraft Info ";
            this.gboxArrivals.Visible = false;
            // 
            // lblARRTransfer
            // 
            this.lblARRTransfer.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblARRTransfer.Location = new System.Drawing.Point(17, 361);
            this.lblARRTransfer.Name = "lblARRTransfer";
            this.lblARRTransfer.Size = new System.Drawing.Size(848, 40);
            this.lblARRTransfer.TabIndex = 44;
            this.lblARRTransfer.Text = "label6";
            this.lblARRTransfer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblARRTransfer.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnARRAliasTransferATC);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Location = new System.Drawing.Point(20, 422);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(845, 68);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "EuroScope Alias";
            // 
            // btnARRAliasTransferATC
            // 
            this.btnARRAliasTransferATC.Enabled = false;
            this.btnARRAliasTransferATC.Location = new System.Drawing.Point(693, 29);
            this.btnARRAliasTransferATC.Name = "btnARRAliasTransferATC";
            this.btnARRAliasTransferATC.Size = new System.Drawing.Size(145, 23);
            this.btnARRAliasTransferATC.TabIndex = 16;
            this.btnARRAliasTransferATC.Text = "Transfer ATC";
            this.btnARRAliasTransferATC.UseVisualStyleBackColor = true;
            this.btnARRAliasTransferATC.Click += new System.EventHandler(this.btnARRAliasTransferATC_Click);
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(6, 29);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(145, 23);
            this.button10.TabIndex = 14;
            this.button10.Text = "Send Clearance";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // lblArrARR
            // 
            this.lblArrARR.AutoSize = true;
            this.lblArrARR.Location = new System.Drawing.Point(267, 62);
            this.lblArrARR.Name = "lblArrARR";
            this.lblArrARR.Size = new System.Drawing.Size(80, 15);
            this.lblArrARR.TabIndex = 30;
            this.lblArrARR.Text = "Destination";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(177, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Destination:";
            // 
            // lblArrDEP
            // 
            this.lblArrDEP.AutoSize = true;
            this.lblArrDEP.Location = new System.Drawing.Point(100, 62);
            this.lblArrDEP.Name = "lblArrDEP";
            this.lblArrDEP.Size = new System.Drawing.Size(71, 15);
            this.lblArrDEP.TabIndex = 28;
            this.lblArrDEP.Text = "Departure";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "Departure:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 15);
            this.label19.TabIndex = 22;
            this.label19.Text = "Route:";
            // 
            // lblARRCallsign
            // 
            this.lblARRCallsign.AutoSize = true;
            this.lblARRCallsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblARRCallsign.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblARRCallsign.Location = new System.Drawing.Point(17, 33);
            this.lblARRCallsign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblARRCallsign.Name = "lblARRCallsign";
            this.lblARRCallsign.Size = new System.Drawing.Size(52, 18);
            this.lblARRCallsign.TabIndex = 21;
            this.lblARRCallsign.Text = "label1";
            // 
            // cboxARRATCTRANSF
            // 
            this.cboxARRATCTRANSF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxARRATCTRANSF.FormattingEnabled = true;
            this.cboxARRATCTRANSF.Items.AddRange(new object[] {
            "UNICOM"});
            this.cboxARRATCTRANSF.Location = new System.Drawing.Point(177, 287);
            this.cboxARRATCTRANSF.Name = "cboxARRATCTRANSF";
            this.cboxARRATCTRANSF.Size = new System.Drawing.Size(121, 23);
            this.cboxARRATCTRANSF.TabIndex = 46;
            // 
            // genTransferATCARR
            // 
            this.genTransferATCARR.Location = new System.Drawing.Point(26, 288);
            this.genTransferATCARR.Name = "genTransferATCARR";
            this.genTransferATCARR.Size = new System.Drawing.Size(145, 23);
            this.genTransferATCARR.TabIndex = 45;
            this.genTransferATCARR.Text = "Gen Transfer";
            this.genTransferATCARR.UseVisualStyleBackColor = true;
            this.genTransferATCARR.Click += new System.EventHandler(this.genTransferATCARR_Click);
            // 
            // lblARRRoute
            // 
            this.lblARRRoute.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblARRRoute.Location = new System.Drawing.Point(78, 89);
            this.lblARRRoute.Name = "lblARRRoute";
            this.lblARRRoute.Size = new System.Drawing.Size(800, 84);
            this.lblARRRoute.TabIndex = 47;
            this.lblARRRoute.Text = "DCT DCT DCT";
            this.lblARRRoute.UseCompatibleTextRendering = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 623);
            this.Controls.Add(this.lblMetar);
            this.Controls.Add(this.cboxRunways);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainFrm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.MainFrm_VisibleChanged);
            this.tabMain.ResumeLayout(false);
            this.tabDepartures.ResumeLayout(false);
            this.gboxDepartures.ResumeLayout(false);
            this.gboxDepartures.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabArrivals.ResumeLayout(false);
            this.gboxArrivals.ResumeLayout(false);
            this.gboxArrivals.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabDepartures;
        private System.Windows.Forms.ListView lstDeparturePilots;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox gboxDepartures;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAliasSendClearance;
        private System.Windows.Forms.ComboBox cboxSID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerateClearance;
        private System.Windows.Forms.TextBox txtSquawk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblFlightLevelIsValid;
        private System.Windows.Forms.Label lblFlightLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCallsign;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cboxPushStart;
        public System.Windows.Forms.Button btnPushAndStart;
        public System.Windows.Forms.Button btnAliasSendPushAndStart;
        public System.Windows.Forms.TabPage tabArrivals;
        public System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.Label lblTransfer;
        public System.Windows.Forms.ComboBox cboxTransferATC;
        private System.Windows.Forms.Button btnTransfer;
        public System.Windows.Forms.Button btnGenFIXALT;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnAliasSendTransferATC;
        public System.Windows.Forms.ComboBox cboxRunways;
        public System.Windows.Forms.Button btnAliasSendFIXALT;
        public System.Windows.Forms.FlowLayoutPanel layPanelTaxiways;
        public System.Windows.Forms.Button btnGenerateTaxi;
        private System.Windows.Forms.CheckBox chkbox35;
        public System.Windows.Forms.Button btnAliasSendTaxi;
        public System.Windows.Forms.Label lblMetar;
        public System.Windows.Forms.Button btnClearedTakeOff;
        private System.Windows.Forms.ListView lstArrivalPilots;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox gboxArrivals;
        public System.Windows.Forms.ComboBox cboxARRATCTRANSF;
        private System.Windows.Forms.Button genTransferATCARR;
        private System.Windows.Forms.Label lblARRTransfer;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button btnARRAliasTransferATC;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label lblArrARR;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblArrDEP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblARRCallsign;
        private System.Windows.Forms.Label lblARRRoute;
    }
}

