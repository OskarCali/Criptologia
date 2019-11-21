namespace Tent_Map
{
    partial class formHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            this.grpBxHenon = new System.Windows.Forms.GroupBox();
            this.btnChart = new System.Windows.Forms.Button();
            this.cmbBxMode = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblFilename = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.radBtnFile = new System.Windows.Forms.RadioButton();
            this.radBtnText = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolStripCont = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStLblAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStLblText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStLblCompact = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContSide = new System.Windows.Forms.SplitContainer();
            this.splitContInfo = new System.Windows.Forms.SplitContainer();
            this.richTxtBxSource = new System.Windows.Forms.RichTextBox();
            this.richTxtBxCompact = new System.Windows.Forms.RichTextBox();
            this.splitContExtra = new System.Windows.Forms.SplitContainer();
            this.richTxtBxBinText = new System.Windows.Forms.RichTextBox();
            this.richTxtBxBinKey = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grpBxHenon.SuspendLayout();
            this.toolStripCont.BottomToolStripPanel.SuspendLayout();
            this.toolStripCont.ContentPanel.SuspendLayout();
            this.toolStripCont.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContSide)).BeginInit();
            this.splitContSide.Panel1.SuspendLayout();
            this.splitContSide.Panel2.SuspendLayout();
            this.splitContSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContInfo)).BeginInit();
            this.splitContInfo.Panel1.SuspendLayout();
            this.splitContInfo.Panel2.SuspendLayout();
            this.splitContInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContExtra)).BeginInit();
            this.splitContExtra.Panel1.SuspendLayout();
            this.splitContExtra.Panel2.SuspendLayout();
            this.splitContExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxHenon
            // 
            this.grpBxHenon.Controls.Add(this.btnChart);
            this.grpBxHenon.Controls.Add(this.cmbBxMode);
            this.grpBxHenon.Controls.Add(this.btnShow);
            this.grpBxHenon.Controls.Add(this.btnProcess);
            this.grpBxHenon.Controls.Add(this.lblFilename);
            this.grpBxHenon.Controls.Add(this.btnFile);
            this.grpBxHenon.Controls.Add(this.radBtnFile);
            this.grpBxHenon.Controls.Add(this.radBtnText);
            this.grpBxHenon.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBxHenon.Location = new System.Drawing.Point(0, 70);
            this.grpBxHenon.Name = "grpBxHenon";
            this.grpBxHenon.Size = new System.Drawing.Size(1322, 90);
            this.grpBxHenon.TabIndex = 5;
            this.grpBxHenon.TabStop = false;
            this.grpBxHenon.Text = "Henon";
            // 
            // btnChart
            // 
            this.btnChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChart.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.Location = new System.Drawing.Point(851, 29);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(115, 40);
            this.btnChart.TabIndex = 7;
            this.btnChart.Text = "GRAFICA";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Visible = false;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // cmbBxMode
            // 
            this.cmbBxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxMode.FormattingEnabled = true;
            this.cmbBxMode.Items.AddRange(new object[] {
            "Encriptar",
            "Desencriptar"});
            this.cmbBxMode.Location = new System.Drawing.Point(228, 39);
            this.cmbBxMode.Name = "cmbBxMode";
            this.cmbBxMode.Size = new System.Drawing.Size(121, 24);
            this.cmbBxMode.TabIndex = 6;
            this.cmbBxMode.SelectedIndexChanged += new System.EventHandler(this.cmbBxMode_SelectedIndexChanged);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(1175, 29);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(115, 40);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "MOSTRAR";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(998, 29);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(145, 40);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "INICIO";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename.Location = new System.Drawing.Point(535, 40);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(114, 18);
            this.lblFilename.TabIndex = 3;
            this.lblFilename.Text = "Nombre archivo";
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Location = new System.Drawing.Point(414, 27);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(115, 40);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "ARCHIVO";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // radBtnFile
            // 
            this.radBtnFile.AutoSize = true;
            this.radBtnFile.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnFile.Location = new System.Drawing.Point(107, 39);
            this.radBtnFile.Name = "radBtnFile";
            this.radBtnFile.Size = new System.Drawing.Size(93, 27);
            this.radBtnFile.TabIndex = 1;
            this.radBtnFile.Text = "Archivo";
            this.radBtnFile.UseVisualStyleBackColor = true;
            this.radBtnFile.CheckedChanged += new System.EventHandler(this.RadBtnFile_CheckedChanged);
            // 
            // radBtnText
            // 
            this.radBtnText.AutoSize = true;
            this.radBtnText.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnText.Location = new System.Drawing.Point(12, 39);
            this.radBtnText.Name = "radBtnText";
            this.radBtnText.Size = new System.Drawing.Size(77, 27);
            this.radBtnText.TabIndex = 0;
            this.radBtnText.Text = "Texto";
            this.radBtnText.UseVisualStyleBackColor = true;
            this.radBtnText.CheckedChanged += new System.EventHandler(this.RadBtnText_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1322, 70);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "TENT MAP";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStripCont
            // 
            // 
            // toolStripCont.BottomToolStripPanel
            // 
            this.toolStripCont.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripCont.ContentPanel
            // 
            this.toolStripCont.ContentPanel.Controls.Add(this.splitContSide);
            this.toolStripCont.ContentPanel.Size = new System.Drawing.Size(1322, 484);
            this.toolStripCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripCont.Location = new System.Drawing.Point(0, 160);
            this.toolStripCont.Name = "toolStripCont";
            this.toolStripCont.Size = new System.Drawing.Size(1322, 513);
            this.toolStripCont.TabIndex = 6;
            this.toolStripCont.Text = "toolStripContainer1";
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStLblAuthor,
            this.toolStripStLblText,
            this.toolStripStLblCompact});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1322, 29);
            this.statusStrip.TabIndex = 1;
            // 
            // toolStripStLblAuthor
            // 
            this.toolStripStLblAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStLblAuthor.Name = "toolStripStLblAuthor";
            this.toolStripStLblAuthor.Size = new System.Drawing.Size(53, 23);
            this.toolStripStLblAuthor.Text = "Autor";
            this.toolStripStLblAuthor.Click += new System.EventHandler(this.ToolStripStLblAuthor_Click);
            // 
            // toolStripStLblText
            // 
            this.toolStripStLblText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStLblText.Name = "toolStripStLblText";
            this.toolStripStLblText.Size = new System.Drawing.Size(1164, 23);
            this.toolStripStLblText.Spring = true;
            this.toolStripStLblText.Text = "Cantidad texto";
            this.toolStripStLblText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStLblCompact
            // 
            this.toolStripStLblCompact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStLblCompact.Name = "toolStripStLblCompact";
            this.toolStripStLblCompact.Size = new System.Drawing.Size(90, 23);
            this.toolStripStLblCompact.Text = "Porcentaje";
            // 
            // splitContSide
            // 
            this.splitContSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContSide.Location = new System.Drawing.Point(0, 0);
            this.splitContSide.Name = "splitContSide";
            // 
            // splitContSide.Panel1
            // 
            this.splitContSide.Panel1.Controls.Add(this.splitContInfo);
            this.splitContSide.Panel1MinSize = 650;
            // 
            // splitContSide.Panel2
            // 
            this.splitContSide.Panel2.Controls.Add(this.splitContExtra);
            this.splitContSide.Panel2MinSize = 300;
            this.splitContSide.Size = new System.Drawing.Size(1322, 484);
            this.splitContSide.SplitterDistance = 761;
            this.splitContSide.SplitterWidth = 5;
            this.splitContSide.TabIndex = 0;
            // 
            // splitContInfo
            // 
            this.splitContInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContInfo.Location = new System.Drawing.Point(0, 0);
            this.splitContInfo.Name = "splitContInfo";
            this.splitContInfo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContInfo.Panel1
            // 
            this.splitContInfo.Panel1.Controls.Add(this.richTxtBxSource);
            this.splitContInfo.Panel1MinSize = 150;
            // 
            // splitContInfo.Panel2
            // 
            this.splitContInfo.Panel2.Controls.Add(this.richTxtBxCompact);
            this.splitContInfo.Size = new System.Drawing.Size(761, 484);
            this.splitContInfo.SplitterDistance = 160;
            this.splitContInfo.TabIndex = 0;
            // 
            // richTxtBxSource
            // 
            this.richTxtBxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBxSource.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBxSource.Location = new System.Drawing.Point(0, 0);
            this.richTxtBxSource.Name = "richTxtBxSource";
            this.richTxtBxSource.Size = new System.Drawing.Size(761, 160);
            this.richTxtBxSource.TabIndex = 0;
            this.richTxtBxSource.Text = "";
            this.richTxtBxSource.TextChanged += new System.EventHandler(this.RichTxtBxSource_TextChanged);
            // 
            // richTxtBxCompact
            // 
            this.richTxtBxCompact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBxCompact.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBxCompact.Location = new System.Drawing.Point(0, 0);
            this.richTxtBxCompact.Name = "richTxtBxCompact";
            this.richTxtBxCompact.ReadOnly = true;
            this.richTxtBxCompact.Size = new System.Drawing.Size(761, 320);
            this.richTxtBxCompact.TabIndex = 0;
            this.richTxtBxCompact.Text = "";
            // 
            // splitContExtra
            // 
            this.splitContExtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContExtra.Location = new System.Drawing.Point(0, 0);
            this.splitContExtra.Name = "splitContExtra";
            this.splitContExtra.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContExtra.Panel1
            // 
            this.splitContExtra.Panel1.Controls.Add(this.richTxtBxBinText);
            // 
            // splitContExtra.Panel2
            // 
            this.splitContExtra.Panel2.Controls.Add(this.richTxtBxBinKey);
            this.splitContExtra.Size = new System.Drawing.Size(556, 484);
            this.splitContExtra.SplitterDistance = 161;
            this.splitContExtra.TabIndex = 0;
            // 
            // richTxtBxBinText
            // 
            this.richTxtBxBinText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBxBinText.Font = new System.Drawing.Font("Lucida Console", 10.8F);
            this.richTxtBxBinText.Location = new System.Drawing.Point(0, 0);
            this.richTxtBxBinText.Name = "richTxtBxBinText";
            this.richTxtBxBinText.ReadOnly = true;
            this.richTxtBxBinText.Size = new System.Drawing.Size(556, 161);
            this.richTxtBxBinText.TabIndex = 0;
            this.richTxtBxBinText.Text = "";
            // 
            // richTxtBxBinKey
            // 
            this.richTxtBxBinKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBxBinKey.Font = new System.Drawing.Font("Lucida Console", 10.8F);
            this.richTxtBxBinKey.Location = new System.Drawing.Point(0, 0);
            this.richTxtBxBinKey.Name = "richTxtBxBinKey";
            this.richTxtBxBinKey.ReadOnly = true;
            this.richTxtBxBinKey.Size = new System.Drawing.Size(556, 319);
            this.richTxtBxBinKey.TabIndex = 0;
            this.richTxtBxBinKey.Text = "";
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 673);
            this.Controls.Add(this.toolStripCont);
            this.Controls.Add(this.grpBxHenon);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1340, 720);
            this.Name = "formHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.grpBxHenon.ResumeLayout(false);
            this.grpBxHenon.PerformLayout();
            this.toolStripCont.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripCont.BottomToolStripPanel.PerformLayout();
            this.toolStripCont.ContentPanel.ResumeLayout(false);
            this.toolStripCont.ResumeLayout(false);
            this.toolStripCont.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContSide.Panel1.ResumeLayout(false);
            this.splitContSide.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContSide)).EndInit();
            this.splitContSide.ResumeLayout(false);
            this.splitContInfo.Panel1.ResumeLayout(false);
            this.splitContInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContInfo)).EndInit();
            this.splitContInfo.ResumeLayout(false);
            this.splitContExtra.Panel1.ResumeLayout(false);
            this.splitContExtra.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContExtra)).EndInit();
            this.splitContExtra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxHenon;
        private System.Windows.Forms.ComboBox cmbBxMode;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.RadioButton radBtnFile;
        private System.Windows.Forms.RadioButton radBtnText;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripContainer toolStripCont;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStLblAuthor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStLblText;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStLblCompact;
        private System.Windows.Forms.SplitContainer splitContSide;
        private System.Windows.Forms.SplitContainer splitContInfo;
        private System.Windows.Forms.RichTextBox richTxtBxSource;
        private System.Windows.Forms.RichTextBox richTxtBxCompact;
        private System.Windows.Forms.SplitContainer splitContExtra;
        private System.Windows.Forms.RichTextBox richTxtBxBinText;
        private System.Windows.Forms.RichTextBox richTxtBxBinKey;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnChart;
    }
}

