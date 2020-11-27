namespace Transport_mgmt
{
    partial class WELCOME
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
            this.pgb1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgb1
            // 
            this.pgb1.BackColor = System.Drawing.Color.Blue;
            this.pgb1.Location = new System.Drawing.Point(169, 162);
            this.pgb1.Name = "pgb1";
            this.pgb1.Size = new System.Drawing.Size(351, 23);
            this.pgb1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("AR JULIAN", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(27, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(567, 45);
            this.label17.TabIndex = 108;
            this.label17.Text = "Transport Management System";
            // 
            // WELCOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Transport_mgmt.Properties.Resources.road_ecw_logistics_verkleind;
            this.ClientSize = new System.Drawing.Size(949, 391);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pgb1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "WELCOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WELCOME";
            this.Load += new System.EventHandler(this.WELCOME_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgb1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label17;
    }
}