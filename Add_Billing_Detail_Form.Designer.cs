namespace Transport_mgmt
{
    partial class Add_Billing_Detail_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Party_ID = new System.Windows.Forms.ComboBox();
            this.Vehicle_ID = new System.Windows.Forms.ComboBox();
            this.DOL = new System.Windows.Forms.DateTimePicker();
            this.POU = new System.Windows.Forms.TextBox();
            this.POL = new System.Windows.Forms.TextBox();
            this.Bill_No = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Material_Desc = new System.Windows.Forms.TextBox();
            this.Bill_Status = new System.Windows.Forms.TextBox();
            this.Balance_Amount = new System.Windows.Forms.TextBox();
            this.Advance_Amount = new System.Windows.Forms.TextBox();
            this.Total_Amount = new System.Windows.Forms.TextBox();
            this.RPM = new System.Windows.Forms.TextBox();
            this.WIM = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SAVE = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.CANCEL = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label15 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill_No :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Party_ID);
            this.panel1.Controls.Add(this.Vehicle_ID);
            this.panel1.Controls.Add(this.DOL);
            this.panel1.Controls.Add(this.POU);
            this.panel1.Controls.Add(this.POL);
            this.panel1.Controls.Add(this.Bill_No);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(54, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 312);
            this.panel1.TabIndex = 1;
            // 
            // Party_ID
            // 
            this.Party_ID.FormattingEnabled = true;
            this.Party_ID.Location = new System.Drawing.Point(241, 106);
            this.Party_ID.Name = "Party_ID";
            this.Party_ID.Size = new System.Drawing.Size(121, 21);
            this.Party_ID.TabIndex = 13;
            // 
            // Vehicle_ID
            // 
            this.Vehicle_ID.FormattingEnabled = true;
            this.Vehicle_ID.Location = new System.Drawing.Point(241, 68);
            this.Vehicle_ID.Name = "Vehicle_ID";
            this.Vehicle_ID.Size = new System.Drawing.Size(121, 21);
            this.Vehicle_ID.TabIndex = 12;
            // 
            // DOL
            // 
            this.DOL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOL.Location = new System.Drawing.Point(212, 146);
            this.DOL.Name = "DOL";
            this.DOL.Size = new System.Drawing.Size(167, 22);
            this.DOL.TabIndex = 11;
            // 
            // POU
            // 
            this.POU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POU.Location = new System.Drawing.Point(241, 230);
            this.POU.Name = "POU";
            this.POU.Size = new System.Drawing.Size(107, 22);
            this.POU.TabIndex = 10;
            this.POU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.POU_KeyPress);
            // 
            // POL
            // 
            this.POL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POL.Location = new System.Drawing.Point(241, 187);
            this.POL.Name = "POL";
            this.POL.Size = new System.Drawing.Size(107, 22);
            this.POL.TabIndex = 9;
            this.POL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.POL_KeyPress);
            // 
            // Bill_No
            // 
            this.Bill_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_No.Location = new System.Drawing.Point(241, 23);
            this.Bill_No.Name = "Bill_No";
            this.Bill_No.ReadOnly = true;
            this.Bill_No.Size = new System.Drawing.Size(107, 22);
            this.Bill_No.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LemonChiffon;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Place_Of_Unloading :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LemonChiffon;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Place_Of_Loading :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LemonChiffon;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date_Of_Loading :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LemonChiffon;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Party_ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle_ID :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Material_Desc);
            this.panel2.Controls.Add(this.Bill_Status);
            this.panel2.Controls.Add(this.Balance_Amount);
            this.panel2.Controls.Add(this.Advance_Amount);
            this.panel2.Controls.Add(this.Total_Amount);
            this.panel2.Controls.Add(this.RPM);
            this.panel2.Controls.Add(this.WIM);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(478, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 325);
            this.panel2.TabIndex = 2;
            // 
            // Material_Desc
            // 
            this.Material_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Material_Desc.Location = new System.Drawing.Point(237, 265);
            this.Material_Desc.Multiline = true;
            this.Material_Desc.Name = "Material_Desc";
            this.Material_Desc.Size = new System.Drawing.Size(163, 43);
            this.Material_Desc.TabIndex = 18;
            // 
            // Bill_Status
            // 
            this.Bill_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Status.Location = new System.Drawing.Point(273, 230);
            this.Bill_Status.Name = "Bill_Status";
            this.Bill_Status.Size = new System.Drawing.Size(107, 22);
            this.Bill_Status.TabIndex = 17;
            this.Bill_Status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bill_Status_KeyPress);
            // 
            // Balance_Amount
            // 
            this.Balance_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance_Amount.Location = new System.Drawing.Point(273, 189);
            this.Balance_Amount.Name = "Balance_Amount";
            this.Balance_Amount.Size = new System.Drawing.Size(107, 22);
            this.Balance_Amount.TabIndex = 16;
            this.Balance_Amount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Balance_Amount_MouseClick);
            this.Balance_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Balance_Amount_KeyPress);
            // 
            // Advance_Amount
            // 
            this.Advance_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advance_Amount.Location = new System.Drawing.Point(273, 146);
            this.Advance_Amount.Name = "Advance_Amount";
            this.Advance_Amount.Size = new System.Drawing.Size(107, 22);
            this.Advance_Amount.TabIndex = 15;
            this.Advance_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Advance_Amount_KeyPress);
            // 
            // Total_Amount
            // 
            this.Total_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Amount.Location = new System.Drawing.Point(273, 104);
            this.Total_Amount.Name = "Total_Amount";
            this.Total_Amount.Size = new System.Drawing.Size(107, 22);
            this.Total_Amount.TabIndex = 14;
            this.Total_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Total_Amount_KeyPress);
            // 
            // RPM
            // 
            this.RPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPM.Location = new System.Drawing.Point(273, 66);
            this.RPM.Name = "RPM";
            this.RPM.Size = new System.Drawing.Size(107, 22);
            this.RPM.TabIndex = 13;
            this.RPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RPM_KeyPress);
            // 
            // WIM
            // 
            this.WIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WIM.Location = new System.Drawing.Point(273, 23);
            this.WIM.Name = "WIM";
            this.WIM.Size = new System.Drawing.Size(107, 22);
            this.WIM.TabIndex = 11;
            this.WIM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WIM_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LemonChiffon;
            this.label13.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "Material_Description :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LemonChiffon;
            this.label12.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Bill_Status :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LemonChiffon;
            this.label11.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Balance_Amount :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LemonChiffon;
            this.label10.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Advance_Amount :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LemonChiffon;
            this.label9.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total_Amount :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LemonChiffon;
            this.label8.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Rate_Per_Matrictone :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LemonChiffon;
            this.label7.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Weight_In_Matrictone :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.NavajoWhite;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(434, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 28);
            this.label14.TabIndex = 13;
            this.label14.Text = "Bill: ..-";
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SAVE.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVE.Location = new System.Drawing.Point(316, 428);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(93, 34);
            this.SAVE.TabIndex = 14;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CLEAR.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR.Location = new System.Drawing.Point(456, 428);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(93, 34);
            this.CLEAR.TabIndex = 15;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = false;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // CANCEL
            // 
            this.CANCEL.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CANCEL.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.Location = new System.Drawing.Point(590, 428);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(93, 34);
            this.CANCEL.TabIndex = 16;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = false;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(946, 502);
            this.shapeContainer1.TabIndex = 17;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 354;
            this.lineShape5.X2 = 620;
            this.lineShape5.Y1 = 60;
            this.lineShape5.Y2 = 60;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 62;
            this.lineShape4.X2 = 887;
            this.lineShape4.Y1 = 395;
            this.lineShape4.Y2 = 398;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 903;
            this.lineShape3.X2 = 905;
            this.lineShape3.Y1 = 94;
            this.lineShape3.Y2 = 360;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 469;
            this.lineShape2.X2 = 471;
            this.lineShape2.Y1 = 95;
            this.lineShape2.Y2 = 365;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 46;
            this.lineShape1.X2 = 46;
            this.lineShape1.Y1 = 88;
            this.lineShape1.Y2 = 365;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LemonChiffon;
            this.label15.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(648, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 19);
            this.label15.TabIndex = 18;
            this.label15.Text = "Date :";
            // 
            // Date
            // 
            this.Date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(717, 42);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(171, 22);
            this.Date.TabIndex = 19;
            // 
            // Add_Billing_Detail_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(946, 502);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Add_Billing_Detail_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Billing_Detail_Form";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.Load += new System.EventHandler(this.Add_Billing_Detail_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox POL;
        private System.Windows.Forms.TextBox Bill_No;
        private System.Windows.Forms.DateTimePicker DOL;
        private System.Windows.Forms.TextBox POU;
        private System.Windows.Forms.TextBox Material_Desc;
        private System.Windows.Forms.TextBox Bill_Status;
        private System.Windows.Forms.TextBox Balance_Amount;
        private System.Windows.Forms.TextBox Advance_Amount;
        private System.Windows.Forms.TextBox Total_Amount;
        private System.Windows.Forms.TextBox RPM;
        private System.Windows.Forms.TextBox WIM;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Button CANCEL;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.ComboBox Party_ID;
        private System.Windows.Forms.ComboBox Vehicle_ID;
    }
}