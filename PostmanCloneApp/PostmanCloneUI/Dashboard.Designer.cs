namespace PostmanCloneUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fhead = new Label();
            apiLabel = new Label();
            Apitext = new TextBox();
            CallAPI = new Button();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            httpVerbSelection = new ComboBox();
            callData = new TabControl();
            bodyTab = new TabPage();
            bodyText = new TextBox();
            outputTab = new TabPage();
            resultsText = new TextBox();
            statusStrip.SuspendLayout();
            callData.SuspendLayout();
            bodyTab.SuspendLayout();
            outputTab.SuspendLayout();
            SuspendLayout();
            // 
            // fhead
            // 
            fhead.AutoSize = true;
            fhead.BackColor = Color.Peru;
            fhead.Font = new Font("Sylfaen", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fhead.Location = new Point(290, 9);
            fhead.Name = "fhead";
            fhead.Size = new Size(258, 46);
            fhead.TabIndex = 0;
            fhead.Text = "Postman Clone";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.BackColor = Color.Peru;
            apiLabel.Font = new Font("Sylfaen", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            apiLabel.Location = new Point(28, 74);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(63, 31);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API:";
            apiLabel.Click += apiLabel_Click;
            // 
            // Apitext
            // 
            Apitext.BorderStyle = BorderStyle.FixedSingle;
            Apitext.Location = new Point(195, 71);
            Apitext.Name = "Apitext";
            Apitext.PlaceholderText = "insert your URL...";
            Apitext.Size = new Size(576, 39);
            Apitext.TabIndex = 2;
            Apitext.TextChanged += Apitext_TextChanged_1;
            // 
            // CallAPI
            // 
            CallAPI.Location = new Point(777, 71);
            CallAPI.Name = "CallAPI";
            CallAPI.Size = new Size(83, 39);
            CallAPI.TabIndex = 3;
            CallAPI.Text = "Apply";
            CallAPI.UseVisualStyleBackColor = true;
            CallAPI.Click += CallAPI_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 631);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(913, 26);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "System Status";
            // 
            // systemStatus
            // 
            systemStatus.BackColor = Color.Transparent;
            systemStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(53, 21);
            systemStatus.Text = "Ready";
            // 
            // httpVerbSelection
            // 
            httpVerbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            httpVerbSelection.FormattingEnabled = true;
            httpVerbSelection.Items.AddRange(new object[] { "GET", "POST", "PUT", "PATCH", "DELETE" });
            httpVerbSelection.Location = new Point(87, 70);
            httpVerbSelection.Name = "httpVerbSelection";
            httpVerbSelection.Size = new Size(102, 40);
            httpVerbSelection.TabIndex = 7;
            // 
            // callData
            // 
            callData.Controls.Add(bodyTab);
            callData.Controls.Add(outputTab);
            callData.Location = new Point(28, 133);
            callData.Name = "callData";
            callData.SelectedIndex = 0;
            callData.Size = new Size(873, 451);
            callData.TabIndex = 8;
            // 
            // bodyTab
            // 
            bodyTab.Controls.Add(bodyText);
            bodyTab.Location = new Point(4, 41);
            bodyTab.Name = "bodyTab";
            bodyTab.Padding = new Padding(3);
            bodyTab.Size = new Size(865, 406);
            bodyTab.TabIndex = 0;
            bodyTab.Text = "Body";
            bodyTab.UseVisualStyleBackColor = true;
            // 
            // bodyText
            // 
            bodyText.BackColor = Color.White;
            bodyText.BorderStyle = BorderStyle.FixedSingle;
            bodyText.Dock = DockStyle.Fill;
            bodyText.Location = new Point(3, 3);
            bodyText.Multiline = true;
            bodyText.Name = "bodyText";
            bodyText.ScrollBars = ScrollBars.Both;
            bodyText.Size = new Size(859, 400);
            bodyText.TabIndex = 5;
            // 
            // outputTab
            // 
            outputTab.Controls.Add(resultsText);
            outputTab.Location = new Point(4, 24);
            outputTab.Name = "outputTab";
            outputTab.Padding = new Padding(3);
            outputTab.Size = new Size(865, 423);
            outputTab.TabIndex = 1;
            outputTab.Text = "Results";
            outputTab.UseVisualStyleBackColor = true;
            // 
            // resultsText
            // 
            resultsText.BackColor = Color.White;
            resultsText.BorderStyle = BorderStyle.FixedSingle;
            resultsText.Dock = DockStyle.Fill;
            resultsText.Location = new Point(3, 3);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(859, 417);
            resultsText.TabIndex = 4;
            resultsText.TextChanged += resultsText_TextChanged;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(913, 657);
            Controls.Add(callData);
            Controls.Add(httpVerbSelection);
            Controls.Add(statusStrip);
            Controls.Add(CallAPI);
            Controls.Add(Apitext);
            Controls.Add(apiLabel);
            Controls.Add(fhead);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Postman Clone";
            Load += Dashboard_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            callData.ResumeLayout(false);
            bodyTab.ResumeLayout(false);
            bodyTab.PerformLayout();
            outputTab.ResumeLayout(false);
            outputTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fhead;
        private Label apiLabel;
        private TextBox Apitext;
        private Button CallAPI;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel systemStatus;
        private ComboBox httpVerbSelection;
        private TabControl callData;
        private TabPage bodyTab;
        private TabPage outputTab;
        private TextBox bodyText;
        private TextBox resultsText;
    }
}
