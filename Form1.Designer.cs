namespace labirary
{
    partial class Form1
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ConditionIn = new System.Windows.Forms.TextBox();
            this.PName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PPhone = new System.Windows.Forms.TextBox();
            this.tab1 = new System.Windows.Forms.Label();
            this.ViewTable = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.ViewTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox3.Controls.Add(this.ConditionIn);
            this.groupBox3.Controls.Add(this.PName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.PPhone);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.groupBox3.Location = new System.Drawing.Point(-3, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 561);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Patient To time Table";
            // 
            // ConditionIn
            // 
            this.ConditionIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ConditionIn.Location = new System.Drawing.Point(130, 187);
            this.ConditionIn.Name = "ConditionIn";
            this.ConditionIn.Size = new System.Drawing.Size(264, 30);
            this.ConditionIn.TabIndex = 8;
            // 
            // PName
            // 
            this.PName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PName.Location = new System.Drawing.Point(130, 82);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(264, 30);
            this.PName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(17, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(228, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Patient";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(17, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(17, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Condition";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PPhone
            // 
            this.PPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PPhone.Location = new System.Drawing.Point(130, 134);
            this.PPhone.Name = "PPhone";
            this.PPhone.Size = new System.Drawing.Size(264, 30);
            this.PPhone.TabIndex = 4;
            // 
            // tab1
            // 
            this.tab1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tab1.AutoSize = true;
            this.tab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tab1.Location = new System.Drawing.Point(3, 0);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(64, 48);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Name";
            this.tab1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewTable
            // 
            this.ViewTable.AutoScroll = true;
            this.ViewTable.AutoSize = true;
            this.ViewTable.BackColor = System.Drawing.Color.OldLace;
            this.ViewTable.ColumnCount = 5;
            this.ViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.95793F));
            this.ViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.04207F));
            this.ViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.ViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.ViewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.ViewTable.Controls.Add(this.label6, 2, 0);
            this.ViewTable.Controls.Add(this.tab1, 0, 0);
            this.ViewTable.Controls.Add(this.label5, 1, 0);
            this.ViewTable.Controls.Add(this.label3, 1, 0);
            this.ViewTable.Location = new System.Drawing.Point(468, 45);
            this.ViewTable.Name = "ViewTable";
            this.ViewTable.RowCount = 1;
            this.ViewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.09091F));
            this.ViewTable.Size = new System.Drawing.Size(833, 48);
            this.ViewTable.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(538, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 48);
            this.label6.TabIndex = 2;
            this.label6.Text = "Condition";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(201, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 48);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(350, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "CodeID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(466, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "Patient Table";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1334, 561);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ViewTable);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Hospital Resapition";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ViewTable.ResumeLayout(false);
            this.ViewTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ViewTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tab1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ConditionIn;
        private System.Windows.Forms.TextBox PName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}

