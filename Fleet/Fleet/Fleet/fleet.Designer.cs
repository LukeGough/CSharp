namespace Fleet
{
    partial class fleetForm
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
            this.grpVehicle = new System.Windows.Forms.GroupBox();
            this.grpAirplane = new System.Windows.Forms.GroupBox();
            this.grpBoat = new System.Windows.Forms.GroupBox();
            this.grpCar = new System.Windows.Forms.GroupBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.tbMake = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.lbMake = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.tbAirplaneNumEngines = new System.Windows.Forms.TextBox();
            this.tbAirplaneEngineType = new System.Windows.Forms.TextBox();
            this.btnAddAirplane = new System.Windows.Forms.Button();
            this.btnOverloadAirplane = new System.Windows.Forms.Button();
            this.lbNumEngines = new System.Windows.Forms.Label();
            this.lbEngineType = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.Label();
            this.btnHullType = new System.Windows.Forms.Label();
            this.lbBodyType = new System.Windows.Forms.Label();
            this.tbBoatLength = new System.Windows.Forms.TextBox();
            this.tbBoatHullType = new System.Windows.Forms.TextBox();
            this.btnAddBoat = new System.Windows.Forms.Button();
            this.btnOverloadBoat = new System.Windows.Forms.Button();
            this.tbCarBodyType = new System.Windows.Forms.TextBox();
            this.btnOverloadCar = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.grpVehicle.SuspendLayout();
            this.grpAirplane.SuspendLayout();
            this.grpBoat.SuspendLayout();
            this.grpCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVehicle
            // 
            this.grpVehicle.Controls.Add(this.lbYear);
            this.grpVehicle.Controls.Add(this.lbModel);
            this.grpVehicle.Controls.Add(this.lbMake);
            this.grpVehicle.Controls.Add(this.tbYear);
            this.grpVehicle.Controls.Add(this.tbModel);
            this.grpVehicle.Controls.Add(this.tbMake);
            this.grpVehicle.Location = new System.Drawing.Point(12, 12);
            this.grpVehicle.Name = "grpVehicle";
            this.grpVehicle.Size = new System.Drawing.Size(200, 100);
            this.grpVehicle.TabIndex = 0;
            this.grpVehicle.TabStop = false;
            this.grpVehicle.Text = "Vehicle (Base Type)";
            // 
            // grpAirplane
            // 
            this.grpAirplane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.grpAirplane.Controls.Add(this.lbEngineType);
            this.grpAirplane.Controls.Add(this.lbNumEngines);
            this.grpAirplane.Controls.Add(this.btnOverloadAirplane);
            this.grpAirplane.Controls.Add(this.btnAddAirplane);
            this.grpAirplane.Controls.Add(this.tbAirplaneEngineType);
            this.grpAirplane.Controls.Add(this.tbAirplaneNumEngines);
            this.grpAirplane.Location = new System.Drawing.Point(218, 12);
            this.grpAirplane.Name = "grpAirplane";
            this.grpAirplane.Size = new System.Drawing.Size(276, 100);
            this.grpAirplane.TabIndex = 1;
            this.grpAirplane.TabStop = false;
            this.grpAirplane.Text = "Airplane Details";
            // 
            // grpBoat
            // 
            this.grpBoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpBoat.Controls.Add(this.btnOverloadBoat);
            this.grpBoat.Controls.Add(this.btnAddBoat);
            this.grpBoat.Controls.Add(this.tbLength);
            this.grpBoat.Controls.Add(this.tbBoatHullType);
            this.grpBoat.Controls.Add(this.btnHullType);
            this.grpBoat.Controls.Add(this.tbBoatLength);
            this.grpBoat.Location = new System.Drawing.Point(218, 118);
            this.grpBoat.Name = "grpBoat";
            this.grpBoat.Size = new System.Drawing.Size(276, 100);
            this.grpBoat.TabIndex = 2;
            this.grpBoat.TabStop = false;
            this.grpBoat.Text = "Boat Details";
            // 
            // grpCar
            // 
            this.grpCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpCar.Controls.Add(this.btnAddCar);
            this.grpCar.Controls.Add(this.btnOverloadCar);
            this.grpCar.Controls.Add(this.lbBodyType);
            this.grpCar.Controls.Add(this.tbCarBodyType);
            this.grpCar.Location = new System.Drawing.Point(218, 224);
            this.grpCar.Name = "grpCar";
            this.grpCar.Size = new System.Drawing.Size(276, 100);
            this.grpCar.TabIndex = 3;
            this.grpCar.TabStop = false;
            this.grpCar.Text = "Car Details";
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(12, 118);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(200, 199);
            this.lstOutput.TabIndex = 4;
            // 
            // tbMake
            // 
            this.tbMake.Location = new System.Drawing.Point(60, 19);
            this.tbMake.Name = "tbMake";
            this.tbMake.Size = new System.Drawing.Size(100, 20);
            this.tbMake.TabIndex = 5;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(60, 45);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(100, 20);
            this.tbModel.TabIndex = 5;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(60, 71);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 20);
            this.tbYear.TabIndex = 5;
            // 
            // lbMake
            // 
            this.lbMake.AutoSize = true;
            this.lbMake.Location = new System.Drawing.Point(21, 22);
            this.lbMake.Name = "lbMake";
            this.lbMake.Size = new System.Drawing.Size(34, 13);
            this.lbMake.TabIndex = 5;
            this.lbMake.Text = "Make";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(19, 48);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(36, 13);
            this.lbModel.TabIndex = 5;
            this.lbModel.Text = "Model";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(26, 74);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(29, 13);
            this.lbYear.TabIndex = 5;
            this.lbYear.Text = "Year";
            // 
            // tbAirplaneNumEngines
            // 
            this.tbAirplaneNumEngines.Location = new System.Drawing.Point(82, 19);
            this.tbAirplaneNumEngines.Name = "tbAirplaneNumEngines";
            this.tbAirplaneNumEngines.Size = new System.Drawing.Size(100, 20);
            this.tbAirplaneNumEngines.TabIndex = 0;
            // 
            // tbAirplaneEngineType
            // 
            this.tbAirplaneEngineType.Location = new System.Drawing.Point(82, 45);
            this.tbAirplaneEngineType.Name = "tbAirplaneEngineType";
            this.tbAirplaneEngineType.Size = new System.Drawing.Size(100, 20);
            this.tbAirplaneEngineType.TabIndex = 1;
            // 
            // btnAddAirplane
            // 
            this.btnAddAirplane.Location = new System.Drawing.Point(188, 17);
            this.btnAddAirplane.Name = "btnAddAirplane";
            this.btnAddAirplane.Size = new System.Drawing.Size(75, 23);
            this.btnAddAirplane.TabIndex = 2;
            this.btnAddAirplane.Text = "Add Airplane";
            this.btnAddAirplane.UseVisualStyleBackColor = true;
            this.btnAddAirplane.Click += new System.EventHandler(this.btnAddAirplane_Click);
            // 
            // btnOverloadAirplane
            // 
            this.btnOverloadAirplane.Location = new System.Drawing.Point(188, 43);
            this.btnOverloadAirplane.Name = "btnOverloadAirplane";
            this.btnOverloadAirplane.Size = new System.Drawing.Size(75, 23);
            this.btnOverloadAirplane.TabIndex = 3;
            this.btnOverloadAirplane.Text = "Overload";
            this.btnOverloadAirplane.UseVisualStyleBackColor = true;
            this.btnOverloadAirplane.Click += new System.EventHandler(this.btnOverloadAirplane_Click);
            // 
            // lbNumEngines
            // 
            this.lbNumEngines.AutoSize = true;
            this.lbNumEngines.Location = new System.Drawing.Point(6, 22);
            this.lbNumEngines.Name = "lbNumEngines";
            this.lbNumEngines.Size = new System.Drawing.Size(70, 13);
            this.lbNumEngines.TabIndex = 4;
            this.lbNumEngines.Text = "Num Engines";
            // 
            // lbEngineType
            // 
            this.lbEngineType.AutoSize = true;
            this.lbEngineType.Location = new System.Drawing.Point(9, 48);
            this.lbEngineType.Name = "lbEngineType";
            this.lbEngineType.Size = new System.Drawing.Size(67, 13);
            this.lbEngineType.TabIndex = 5;
            this.lbEngineType.Text = "Engine Type";
            // 
            // tbLength
            // 
            this.tbLength.AutoSize = true;
            this.tbLength.Location = new System.Drawing.Point(36, 22);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(40, 13);
            this.tbLength.TabIndex = 0;
            this.tbLength.Text = "Length";
            // 
            // btnHullType
            // 
            this.btnHullType.AutoSize = true;
            this.btnHullType.Location = new System.Drawing.Point(24, 48);
            this.btnHullType.Name = "btnHullType";
            this.btnHullType.Size = new System.Drawing.Size(52, 13);
            this.btnHullType.TabIndex = 1;
            this.btnHullType.Text = "Hull Type";
            // 
            // lbBodyType
            // 
            this.lbBodyType.AutoSize = true;
            this.lbBodyType.Location = new System.Drawing.Point(18, 22);
            this.lbBodyType.Name = "lbBodyType";
            this.lbBodyType.Size = new System.Drawing.Size(58, 13);
            this.lbBodyType.TabIndex = 0;
            this.lbBodyType.Text = "Body Type";
            // 
            // tbBoatLength
            // 
            this.tbBoatLength.Location = new System.Drawing.Point(82, 19);
            this.tbBoatLength.Name = "tbBoatLength";
            this.tbBoatLength.Size = new System.Drawing.Size(100, 20);
            this.tbBoatLength.TabIndex = 0;
            // 
            // tbBoatHullType
            // 
            this.tbBoatHullType.Location = new System.Drawing.Point(82, 45);
            this.tbBoatHullType.Name = "tbBoatHullType";
            this.tbBoatHullType.Size = new System.Drawing.Size(100, 20);
            this.tbBoatHullType.TabIndex = 1;
            // 
            // btnAddBoat
            // 
            this.btnAddBoat.Location = new System.Drawing.Point(188, 17);
            this.btnAddBoat.Name = "btnAddBoat";
            this.btnAddBoat.Size = new System.Drawing.Size(75, 23);
            this.btnAddBoat.TabIndex = 2;
            this.btnAddBoat.Text = "Add Boat";
            this.btnAddBoat.UseVisualStyleBackColor = true;
            this.btnAddBoat.Click += new System.EventHandler(this.btnAddBoat_Click);
            // 
            // btnOverloadBoat
            // 
            this.btnOverloadBoat.Location = new System.Drawing.Point(188, 43);
            this.btnOverloadBoat.Name = "btnOverloadBoat";
            this.btnOverloadBoat.Size = new System.Drawing.Size(75, 23);
            this.btnOverloadBoat.TabIndex = 3;
            this.btnOverloadBoat.Text = "Overload";
            this.btnOverloadBoat.UseVisualStyleBackColor = true;
            this.btnOverloadBoat.Click += new System.EventHandler(this.btnOverloadBoat_Click);
            // 
            // tbCarBodyType
            // 
            this.tbCarBodyType.Location = new System.Drawing.Point(82, 19);
            this.tbCarBodyType.Name = "tbCarBodyType";
            this.tbCarBodyType.Size = new System.Drawing.Size(100, 20);
            this.tbCarBodyType.TabIndex = 0;
            // 
            // btnOverloadCar
            // 
            this.btnOverloadCar.Location = new System.Drawing.Point(188, 46);
            this.btnOverloadCar.Name = "btnOverloadCar";
            this.btnOverloadCar.Size = new System.Drawing.Size(75, 23);
            this.btnOverloadCar.TabIndex = 1;
            this.btnOverloadCar.Text = "Overload";
            this.btnOverloadCar.UseVisualStyleBackColor = true;
            this.btnOverloadCar.Click += new System.EventHandler(this.btnOverloadCar_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(188, 17);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(75, 23);
            this.btnAddCar.TabIndex = 2;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // fleetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 338);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.grpCar);
            this.Controls.Add(this.grpBoat);
            this.Controls.Add(this.grpAirplane);
            this.Controls.Add(this.grpVehicle);
            this.Name = "fleetForm";
            this.Text = "My Fleet";
            this.grpVehicle.ResumeLayout(false);
            this.grpVehicle.PerformLayout();
            this.grpAirplane.ResumeLayout(false);
            this.grpAirplane.PerformLayout();
            this.grpBoat.ResumeLayout(false);
            this.grpBoat.PerformLayout();
            this.grpCar.ResumeLayout(false);
            this.grpCar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVehicle;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbMake;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbMake;
        private System.Windows.Forms.GroupBox grpAirplane;
        private System.Windows.Forms.GroupBox grpBoat;
        private System.Windows.Forms.GroupBox grpCar;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Label lbEngineType;
        private System.Windows.Forms.Label lbNumEngines;
        private System.Windows.Forms.Button btnOverloadAirplane;
        private System.Windows.Forms.Button btnAddAirplane;
        private System.Windows.Forms.TextBox tbAirplaneEngineType;
        private System.Windows.Forms.TextBox tbAirplaneNumEngines;
        private System.Windows.Forms.Button btnOverloadBoat;
        private System.Windows.Forms.Button btnAddBoat;
        private System.Windows.Forms.Label tbLength;
        private System.Windows.Forms.TextBox tbBoatHullType;
        private System.Windows.Forms.Label btnHullType;
        private System.Windows.Forms.TextBox tbBoatLength;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnOverloadCar;
        private System.Windows.Forms.Label lbBodyType;
        private System.Windows.Forms.TextBox tbCarBodyType;
    }
}

