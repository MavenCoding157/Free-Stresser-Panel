namespace _123_DDoS_Panel
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button23);
            this.panel3.Controls.Add(this.button22);
            this.panel3.Controls.Add(this.button21);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 252);
            this.panel3.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Back to Attack Hub";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(25, 201);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(183, 31);
            this.button23.TabIndex = 13;
            this.button23.Text = "Exit";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(25, 138);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(183, 23);
            this.button22.TabIndex = 12;
            this.button22.Text = "Stop";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(25, 102);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(183, 23);
            this.button21.TabIndex = 11;
            this.button21.Text = "Play";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.GhostWhite;
            this.label18.Location = new System.Drawing.Point(87, 172);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 26);
            this.label18.TabIndex = 6;
            this.label18.Text = "Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Attack Hub";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.GhostWhite;
            this.label17.Location = new System.Drawing.Point(81, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 26);
            this.label17.TabIndex = 6;
            this.label17.Text = "Music";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(230, 249);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "The MONO Stresser | Settings |";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private Button button23;
        private Button button22;
        private Button button21;
        private Label label18;
        private Label label17;
        private Button button1;
        private Label label1;
    }
}