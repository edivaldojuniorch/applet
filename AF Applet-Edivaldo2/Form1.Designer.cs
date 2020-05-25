namespace AF_Applet_Edivaldo2
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
            this.afDatabasePicker1 = new OSIsoft.AF.UI.AFDatabasePicker();
            this.afTreeView1 = new OSIsoft.AF.UI.AFTreeView();
            this.piSystemPicker1 = new OSIsoft.AF.UI.PISystemPicker();
            this.lbAttributes = new System.Windows.Forms.ListBox();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbValues = new System.Windows.Forms.ListBox();
            this.cbUOM = new System.Windows.Forms.ComboBox();
            this.cbDataMethod = new System.Windows.Forms.ComboBox();
            this.lbNotificationRules = new System.Windows.Forms.ListBox();
            this.lbNotificationInstances = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // afDatabasePicker1
            // 
            this.afDatabasePicker1.AccessibleDescription = "Database Picker";
            this.afDatabasePicker1.AccessibleName = "Database Picker";
            this.afDatabasePicker1.Location = new System.Drawing.Point(15, 40);
            this.afDatabasePicker1.Name = "afDatabasePicker1";
            this.afDatabasePicker1.ShowBegin = false;
            this.afDatabasePicker1.ShowDelete = false;
            this.afDatabasePicker1.ShowEnd = false;
            this.afDatabasePicker1.ShowFind = false;
            this.afDatabasePicker1.ShowList = false;
            this.afDatabasePicker1.ShowNavigation = false;
            this.afDatabasePicker1.ShowNew = false;
            this.afDatabasePicker1.ShowNext = false;
            this.afDatabasePicker1.ShowPrevious = false;
            this.afDatabasePicker1.ShowProperties = false;
            this.afDatabasePicker1.Size = new System.Drawing.Size(284, 22);
            this.afDatabasePicker1.TabIndex = 0;
            this.afDatabasePicker1.SelectionChange += new OSIsoft.AF.UI.SelectionChangeEventHandler(this.afDatabasePicker1_SelectionChange);
            // 
            // afTreeView1
            // 
            this.afTreeView1.HideSelection = false;
            this.afTreeView1.Location = new System.Drawing.Point(15, 68);
            this.afTreeView1.Name = "afTreeView1";
            this.afTreeView1.ShowNodeToolTips = true;
            this.afTreeView1.Size = new System.Drawing.Size(284, 428);
            this.afTreeView1.TabIndex = 1;
            this.afTreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.afTreeView1_AfterSelect);
            // 
            // piSystemPicker1
            // 
            this.piSystemPicker1.AccessibleDescription = "PI System Picker";
            this.piSystemPicker1.AccessibleName = "PI System Picker";
            this.piSystemPicker1.ConnectAutomatically = true;
            this.piSystemPicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.piSystemPicker1.Location = new System.Drawing.Point(15, 12);
            this.piSystemPicker1.LoginPromptSetting = OSIsoft.AF.UI.PISystemPicker.LoginPromptSettingOptions.Default;
            this.piSystemPicker1.Name = "piSystemPicker1";
            this.piSystemPicker1.ShowBegin = false;
            this.piSystemPicker1.ShowEnd = false;
            this.piSystemPicker1.ShowFind = false;
            this.piSystemPicker1.ShowNavigation = false;
            this.piSystemPicker1.ShowNext = false;
            this.piSystemPicker1.ShowPrevious = false;
            this.piSystemPicker1.Size = new System.Drawing.Size(284, 22);
            this.piSystemPicker1.TabIndex = 2;
            // 
            // lbAttributes
            // 
            this.lbAttributes.FormattingEnabled = true;
            this.lbAttributes.Location = new System.Drawing.Point(321, 12);
            this.lbAttributes.Name = "lbAttributes";
            this.lbAttributes.Size = new System.Drawing.Size(373, 121);
            this.lbAttributes.TabIndex = 3;
            this.lbAttributes.SelectedIndexChanged += new System.EventHandler(this.lbAttributes_SelectedIndexChanged);
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(321, 145);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(103, 20);
            this.tbStart.TabIndex = 4;
            this.tbStart.Text = "*-3d";
            this.tbStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEnd
            // 
            this.tbEnd.Location = new System.Drawing.Point(430, 145);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(85, 20);
            this.tbEnd.TabIndex = 5;
            this.tbEnd.Text = "*";
            this.tbEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Get Data!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGetData);
            // 
            // lbValues
            // 
            this.lbValues.FormattingEnabled = true;
            this.lbValues.Location = new System.Drawing.Point(321, 197);
            this.lbValues.Name = "lbValues";
            this.lbValues.Size = new System.Drawing.Size(373, 82);
            this.lbValues.TabIndex = 7;
            // 
            // cbUOM
            // 
            this.cbUOM.DisplayMember = "Abbreviation";
            this.cbUOM.FormattingEnabled = true;
            this.cbUOM.Location = new System.Drawing.Point(520, 144);
            this.cbUOM.Name = "cbUOM";
            this.cbUOM.Size = new System.Drawing.Size(93, 21);
            this.cbUOM.TabIndex = 8;
            this.cbUOM.SelectedIndexChanged += new System.EventHandler(this.cbUOM_SelectedIndexChanged);
            // 
            // cbDataMethod
            // 
            this.cbDataMethod.FormattingEnabled = true;
            this.cbDataMethod.Items.AddRange(new object[] {
            "Recorded Values",
            "Interpolated Values",
            "Plot Values"});
            this.cbDataMethod.Location = new System.Drawing.Point(321, 170);
            this.cbDataMethod.Name = "cbDataMethod";
            this.cbDataMethod.Size = new System.Drawing.Size(292, 21);
            this.cbDataMethod.TabIndex = 9;
            this.cbDataMethod.Text = "Recorded Values";
            // 
            // lbNotificationRules
            // 
            this.lbNotificationRules.FormattingEnabled = true;
            this.lbNotificationRules.Location = new System.Drawing.Point(321, 313);
            this.lbNotificationRules.Name = "lbNotificationRules";
            this.lbNotificationRules.Size = new System.Drawing.Size(373, 69);
            this.lbNotificationRules.TabIndex = 10;
            this.lbNotificationRules.SelectedIndexChanged += new System.EventHandler(this.lbNotificationRules_SelectedIndexChanged);
            // 
            // lbNotificationInstances
            // 
            this.lbNotificationInstances.FormattingEnabled = true;
            this.lbNotificationInstances.Location = new System.Drawing.Point(321, 411);
            this.lbNotificationInstances.Name = "lbNotificationInstances";
            this.lbNotificationInstances.Size = new System.Drawing.Size(373, 82);
            this.lbNotificationInstances.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Notification Instances";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Notification Rules";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 508);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNotificationInstances);
            this.Controls.Add(this.lbNotificationRules);
            this.Controls.Add(this.cbDataMethod);
            this.Controls.Add(this.cbUOM);
            this.Controls.Add(this.lbValues);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.tbStart);
            this.Controls.Add(this.lbAttributes);
            this.Controls.Add(this.piSystemPicker1);
            this.Controls.Add(this.afTreeView1);
            this.Controls.Add(this.afDatabasePicker1);
            this.Name = "Form1";
            this.Text = "Processing Asset Framework";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OSIsoft.AF.UI.AFDatabasePicker afDatabasePicker1;
        private OSIsoft.AF.UI.AFTreeView afTreeView1;
        private OSIsoft.AF.UI.PISystemPicker piSystemPicker1;
        private System.Windows.Forms.ListBox lbAttributes;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbValues;
        private System.Windows.Forms.ComboBox cbUOM;
        private System.Windows.Forms.ComboBox cbDataMethod;
        private System.Windows.Forms.ListBox lbNotificationRules;
        private System.Windows.Forms.ListBox lbNotificationInstances;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

