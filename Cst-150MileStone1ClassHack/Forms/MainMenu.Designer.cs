namespace Cst_150MileStone1ClassHack
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnViewWeek = new System.Windows.Forms.Button();
            this.btnViewAssign = new System.Windows.Forms.Button();
            this.btnAddAssign = new System.Windows.Forms.Button();
            this.btnEditAssign = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewWeek
            // 
            this.btnViewWeek.BackColor = System.Drawing.Color.Turquoise;
            this.btnViewWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnViewWeek.ForeColor = System.Drawing.SystemColors.Control;
            this.btnViewWeek.Location = new System.Drawing.Point(131, 174);
            this.btnViewWeek.Name = "btnViewWeek";
            this.btnViewWeek.Size = new System.Drawing.Size(269, 154);
            this.btnViewWeek.TabIndex = 0;
            this.btnViewWeek.Text = "View Week Scheduale";
            this.btnViewWeek.UseVisualStyleBackColor = false;
            // 
            // btnViewAssign
            // 
            this.btnViewAssign.BackColor = System.Drawing.Color.Turquoise;
            this.btnViewAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnViewAssign.ForeColor = System.Drawing.SystemColors.Control;
            this.btnViewAssign.Location = new System.Drawing.Point(684, 174);
            this.btnViewAssign.Name = "btnViewAssign";
            this.btnViewAssign.Size = new System.Drawing.Size(269, 154);
            this.btnViewAssign.TabIndex = 1;
            this.btnViewAssign.Text = "View Assignments";
            this.btnViewAssign.UseVisualStyleBackColor = false;
            this.btnViewAssign.Click += new System.EventHandler(this.btnViewAssignmentsClickEvent);
            // 
            // btnAddAssign
            // 
            this.btnAddAssign.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnAddAssign.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddAssign.Location = new System.Drawing.Point(131, 479);
            this.btnAddAssign.Name = "btnAddAssign";
            this.btnAddAssign.Size = new System.Drawing.Size(269, 154);
            this.btnAddAssign.TabIndex = 2;
            this.btnAddAssign.Text = "Add a New Assignment";
            this.btnAddAssign.UseVisualStyleBackColor = false;
            this.btnAddAssign.Click += new System.EventHandler(this.btnAddNewAssignmentClickEvent);
            // 
            // btnEditAssign
            // 
            this.btnEditAssign.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnEditAssign.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditAssign.Location = new System.Drawing.Point(684, 479);
            this.btnEditAssign.Name = "btnEditAssign";
            this.btnEditAssign.Size = new System.Drawing.Size(269, 154);
            this.btnEditAssign.TabIndex = 3;
            this.btnEditAssign.Text = "Edit \r\nAssignments";
            this.btnEditAssign.UseVisualStyleBackColor = false;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Black;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnAbout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAbout.Location = new System.Drawing.Point(917, 2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(138, 96);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAboutClickEvent);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.BackColor = System.Drawing.Color.Black;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAbout.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAbout.Location = new System.Drawing.Point(305, 331);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(492, 145);
            this.lblAbout.TabIndex = 5;
            this.lblAbout.Text = resources.GetString("lblAbout.Text");
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.BackColor = System.Drawing.Color.DarkRed;
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTitle1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle1.Location = new System.Drawing.Point(394, 18);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(150, 58);
            this.lblTitle1.TabIndex = 7;
            this.lblTitle1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Turquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(550, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 58);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hack";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1057, 648);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnEditAssign);
            this.Controls.Add(this.btnAddAssign);
            this.Controls.Add(this.btnViewAssign);
            this.Controls.Add(this.btnViewWeek);
            this.Name = "MainMenu";
            this.Text = "MainMenuDes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewWeek;
        private System.Windows.Forms.Button btnViewAssign;
        private System.Windows.Forms.Button btnAddAssign;
        private System.Windows.Forms.Button btnEditAssign;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label label2;
    }
}

