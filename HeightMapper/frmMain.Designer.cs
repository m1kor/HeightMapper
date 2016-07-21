namespace TerrainEditor
{
    partial class frmMain
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
		this.glControlTerrainPreview = new OpenTK.GLControl();
		this.trackBarRotation = new System.Windows.Forms.TrackBar();
		this.trackBarPitch = new System.Windows.Forms.TrackBar();
		this.trackBarFOV = new System.Windows.Forms.TrackBar();
		this.panelEditor = new System.Windows.Forms.Panel();
		this.pictureBoxHeightMap = new System.Windows.Forms.PictureBox();
		this.tmrRender = new System.Windows.Forms.Timer(this.components);
		this.trackBarDetails = new System.Windows.Forms.TrackBar();
		this.trackBarHeight = new System.Windows.Forms.TrackBar();
		this.labelRotation = new System.Windows.Forms.Label();
		this.labelPitch = new System.Windows.Forms.Label();
		this.labelZoom = new System.Windows.Forms.Label();
		this.labelDetalization = new System.Windows.Forms.Label();
		this.labelHeight = new System.Windows.Forms.Label();
		this.panelControls = new System.Windows.Forms.Panel();
		this.labelBrushStrength = new System.Windows.Forms.Label();
		this.trackBarBrushStrength = new System.Windows.Forms.TrackBar();
		this.trackBarBrushSize = new System.Windows.Forms.TrackBar();
		this.labelBrushSize = new System.Windows.Forms.Label();
		this.statusStrip = new System.Windows.Forms.StatusStrip();
		this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
		this.toolStripMain = new System.Windows.Forms.ToolStrip();
		this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
		this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
		this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
		this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.toolStripButtonWireframe = new System.Windows.Forms.ToolStripButton();
		this.toolStripButtonShading = new System.Windows.Forms.ToolStripButton();
		this.toolStripButtonLiveMode = new System.Windows.Forms.ToolStripButton();
		this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
		this.toolStripLabelMode = new System.Windows.Forms.ToolStripLabel();
		this.toolStripButtonMode = new System.Windows.Forms.ToolStripButton();
		this.splitContainerWorkArea = new System.Windows.Forms.SplitContainer();
		this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
		this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
		((System.ComponentModel.ISupportInitialize)(this.trackBarRotation)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.trackBarFOV)).BeginInit();
		this.panelEditor.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeightMap)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.trackBarDetails)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.trackBarHeight)).BeginInit();
		this.panelControls.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.trackBarBrushStrength)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.trackBarBrushSize)).BeginInit();
		this.statusStrip.SuspendLayout();
		this.toolStripMain.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.splitContainerWorkArea)).BeginInit();
		this.splitContainerWorkArea.Panel1.SuspendLayout();
		this.splitContainerWorkArea.Panel2.SuspendLayout();
		this.splitContainerWorkArea.SuspendLayout();
		this.SuspendLayout();
		// 
		// glControlTerrainPreview
		// 
		this.glControlTerrainPreview.BackColor = System.Drawing.Color.Black;
		this.glControlTerrainPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.glControlTerrainPreview.Dock = System.Windows.Forms.DockStyle.Fill;
		this.glControlTerrainPreview.Location = new System.Drawing.Point(0, 0);
		this.glControlTerrainPreview.Name = "glControlTerrainPreview";
		this.glControlTerrainPreview.Size = new System.Drawing.Size(478, 501);
		this.glControlTerrainPreview.TabIndex = 0;
		this.glControlTerrainPreview.VSync = false;
		this.glControlTerrainPreview.Load += new System.EventHandler(this.glControlTerrainPreview_Load);
		this.glControlTerrainPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.glControlTerrainPreview_Paint);
		this.glControlTerrainPreview.Resize += new System.EventHandler(this.glControlTerrainPreview_Resize);
		// 
		// trackBarRotation
		// 
		this.trackBarRotation.Location = new System.Drawing.Point(37, 3);
		this.trackBarRotation.Maximum = 360;
		this.trackBarRotation.Name = "trackBarRotation";
		this.trackBarRotation.Size = new System.Drawing.Size(443, 45);
		this.trackBarRotation.TabIndex = 1;
		this.trackBarRotation.TickStyle = System.Windows.Forms.TickStyle.None;
		this.trackBarRotation.Scroll += new System.EventHandler(this.trackBarRotation_Scroll);
		// 
		// trackBarPitch
		// 
		this.trackBarPitch.Location = new System.Drawing.Point(40, 54);
		this.trackBarPitch.Maximum = 90;
		this.trackBarPitch.Name = "trackBarPitch";
		this.trackBarPitch.Size = new System.Drawing.Size(440, 45);
		this.trackBarPitch.TabIndex = 2;
		this.trackBarPitch.TickStyle = System.Windows.Forms.TickStyle.None;
		this.trackBarPitch.Value = 35;
		this.trackBarPitch.Scroll += new System.EventHandler(this.trackBarPitch_Scroll);
		// 
		// trackBarFOV
		// 
		this.trackBarFOV.Location = new System.Drawing.Point(43, 105);
		this.trackBarFOV.Maximum = 90;
		this.trackBarFOV.Minimum = 5;
		this.trackBarFOV.Name = "trackBarFOV";
		this.trackBarFOV.Size = new System.Drawing.Size(437, 45);
		this.trackBarFOV.TabIndex = 3;
		this.trackBarFOV.TickStyle = System.Windows.Forms.TickStyle.None;
		this.trackBarFOV.Value = 45;
		this.trackBarFOV.Scroll += new System.EventHandler(this.trackBarFOV_Scroll);
		// 
		// panelEditor
		// 
		this.panelEditor.AutoScroll = true;
		this.panelEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panelEditor.Controls.Add(this.pictureBoxHeightMap);
		this.panelEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panelEditor.Location = new System.Drawing.Point(0, 0);
		this.panelEditor.Name = "panelEditor";
		this.panelEditor.Size = new System.Drawing.Size(495, 501);
		this.panelEditor.TabIndex = 5;
		// 
		// pictureBoxHeightMap
		// 
		this.pictureBoxHeightMap.Cursor = System.Windows.Forms.Cursors.Cross;
		this.pictureBoxHeightMap.Location = new System.Drawing.Point(0, 0);
		this.pictureBoxHeightMap.Name = "pictureBoxHeightMap";
		this.pictureBoxHeightMap.Size = new System.Drawing.Size(67, 55);
		this.pictureBoxHeightMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.pictureBoxHeightMap.TabIndex = 1;
		this.pictureBoxHeightMap.TabStop = false;
		this.pictureBoxHeightMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxHeightMap_MouseDown);
		this.pictureBoxHeightMap.MouseEnter += new System.EventHandler(this.pictureBoxHeightMap_MouseEnter);
		this.pictureBoxHeightMap.MouseLeave += new System.EventHandler(this.pictureBoxHeightMap_MouseLeave);
		this.pictureBoxHeightMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxHeightMap_MouseMove);
		this.pictureBoxHeightMap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxHeightMap_MouseUp);
		// 
		// tmrRender
		// 
		this.tmrRender.Enabled = true;
		this.tmrRender.Interval = 15;
		this.tmrRender.Tick += new System.EventHandler(this.tmrRender_Tick);
		// 
		// trackBarDetails
		// 
		this.trackBarDetails.Location = new System.Drawing.Point(525, 54);
		this.trackBarDetails.Maximum = 512;
		this.trackBarDetails.Minimum = 1;
		this.trackBarDetails.Name = "trackBarDetails";
		this.trackBarDetails.Size = new System.Drawing.Size(442, 45);
		this.trackBarDetails.TabIndex = 7;
		this.trackBarDetails.TickStyle = System.Windows.Forms.TickStyle.None;
		this.trackBarDetails.Value = 8;
		this.trackBarDetails.Scroll += new System.EventHandler(this.trackBarDetails_Scroll);
		// 
		// trackBarHeight
		// 
		this.trackBarHeight.Location = new System.Drawing.Point(524, 91);
		this.trackBarHeight.Maximum = 300;
		this.trackBarHeight.Name = "trackBarHeight";
		this.trackBarHeight.Size = new System.Drawing.Size(443, 45);
		this.trackBarHeight.TabIndex = 9;
		this.trackBarHeight.TickStyle = System.Windows.Forms.TickStyle.None;
		this.trackBarHeight.Value = 100;
		this.trackBarHeight.Scroll += new System.EventHandler(this.trackBarHeight_Scroll);
		// 
		// labelRotation
		// 
		this.labelRotation.AutoSize = true;
		this.labelRotation.Location = new System.Drawing.Point(3, 3);
		this.labelRotation.Name = "labelRotation";
		this.labelRotation.Size = new System.Drawing.Size(28, 13);
		this.labelRotation.TabIndex = 10;
		this.labelRotation.Text = "< - >";
		// 
		// labelPitch
		// 
		this.labelPitch.AutoSize = true;
		this.labelPitch.Location = new System.Drawing.Point(3, 54);
		this.labelPitch.Name = "labelPitch";
		this.labelPitch.Size = new System.Drawing.Size(31, 13);
		this.labelPitch.TabIndex = 11;
		this.labelPitch.Text = "Pitch";
		// 
		// labelZoom
		// 
		this.labelZoom.AutoSize = true;
		this.labelZoom.Location = new System.Drawing.Point(3, 105);
		this.labelZoom.Name = "labelZoom";
		this.labelZoom.Size = new System.Drawing.Size(34, 13);
		this.labelZoom.TabIndex = 12;
		this.labelZoom.Text = "Zoom";
		// 
		// labelDetalization
		// 
		this.labelDetalization.AutoSize = true;
		this.labelDetalization.Location = new System.Drawing.Point(480, 54);
		this.labelDetalization.Name = "labelDetalization";
		this.labelDetalization.Size = new System.Drawing.Size(39, 13);
		this.labelDetalization.TabIndex = 13;
		this.labelDetalization.Text = "Details";
		// 
		// labelHeight
		// 
		this.labelHeight.AutoSize = true;
		this.labelHeight.Location = new System.Drawing.Point(480, 105);
		this.labelHeight.Name = "labelHeight";
		this.labelHeight.Size = new System.Drawing.Size(38, 13);
		this.labelHeight.TabIndex = 14;
		this.labelHeight.Text = "Height";
		// 
		// panelControls
		// 
		this.panelControls.Controls.Add(this.labelBrushStrength);
		this.panelControls.Controls.Add(this.trackBarBrushStrength);
		this.panelControls.Controls.Add(this.trackBarBrushSize);
		this.panelControls.Controls.Add(this.labelBrushSize);
		this.panelControls.Controls.Add(this.statusStrip);
		this.panelControls.Controls.Add(this.labelRotation);
		this.panelControls.Controls.Add(this.labelHeight);
		this.panelControls.Controls.Add(this.trackBarRotation);
		this.panelControls.Controls.Add(this.labelDetalization);
		this.panelControls.Controls.Add(this.trackBarHeight);
		this.panelControls.Controls.Add(this.trackBarPitch);
		this.panelControls.Controls.Add(this.trackBarDetails);
		this.panelControls.Controls.Add(this.labelZoom);
		this.panelControls.Controls.Add(this.trackBarFOV);
		this.panelControls.Controls.Add(this.labelPitch);
		this.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.panelControls.Location = new System.Drawing.Point(0, 526);
		this.panelControls.Name = "panelControls";
		this.panelControls.Size = new System.Drawing.Size(977, 167);
		this.panelControls.TabIndex = 15;
		// 
		// labelBrushStrength
		// 
		this.labelBrushStrength.AutoSize = true;
		this.labelBrushStrength.Location = new System.Drawing.Point(714, 7);
		this.labelBrushStrength.Name = "labelBrushStrength";
		this.labelBrushStrength.Size = new System.Drawing.Size(47, 13);
		this.labelBrushStrength.TabIndex = 19;
		this.labelBrushStrength.Text = "Strength";
		// 
		// trackBarBrushStrength
		// 
		this.trackBarBrushStrength.Location = new System.Drawing.Point(767, 7);
		this.trackBarBrushStrength.Maximum = 150;
		this.trackBarBrushStrength.Minimum = 10;
		this.trackBarBrushStrength.Name = "trackBarBrushStrength";
		this.trackBarBrushStrength.Size = new System.Drawing.Size(198, 45);
		this.trackBarBrushStrength.TabIndex = 18;
		this.trackBarBrushStrength.TickFrequency = 15;
		this.trackBarBrushStrength.Value = 100;
		// 
		// trackBarBrushSize
		// 
		this.trackBarBrushSize.Location = new System.Drawing.Point(541, 7);
		this.trackBarBrushSize.Maximum = 128;
		this.trackBarBrushSize.Minimum = 8;
		this.trackBarBrushSize.Name = "trackBarBrushSize";
		this.trackBarBrushSize.Size = new System.Drawing.Size(167, 45);
		this.trackBarBrushSize.TabIndex = 17;
		this.trackBarBrushSize.TickFrequency = 32;
		this.trackBarBrushSize.Value = 64;
		this.trackBarBrushSize.Scroll += new System.EventHandler(this.trackBarBrushSize_Scroll);
		// 
		// labelBrushSize
		// 
		this.labelBrushSize.AutoSize = true;
		this.labelBrushSize.Location = new System.Drawing.Point(480, 7);
		this.labelBrushSize.Name = "labelBrushSize";
		this.labelBrushSize.Size = new System.Drawing.Size(55, 13);
		this.labelBrushSize.TabIndex = 16;
		this.labelBrushSize.Text = "Brush size";
		// 
		// statusStrip
		// 
		this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
		this.toolStripStatusLabel});
		this.statusStrip.Location = new System.Drawing.Point(0, 145);
		this.statusStrip.Name = "statusStrip";
		this.statusStrip.Size = new System.Drawing.Size(977, 22);
		this.statusStrip.TabIndex = 15;
		// 
		// toolStripStatusLabel
		// 
		this.toolStripStatusLabel.Name = "toolStripStatusLabel";
		this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
		// 
		// toolStripMain
		// 
		this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
		this.toolStripButtonNew,
		this.toolStripButtonOpen,
		this.toolStripButtonSave,
		this.toolStripSeparator1,
		this.toolStripButtonWireframe,
		this.toolStripButtonShading,
		this.toolStripButtonLiveMode,
		this.toolStripSeparator2,
		this.toolStripLabelMode,
		this.toolStripButtonMode});
		this.toolStripMain.Location = new System.Drawing.Point(0, 0);
		this.toolStripMain.Name = "toolStripMain";
		this.toolStripMain.Size = new System.Drawing.Size(977, 25);
		this.toolStripMain.TabIndex = 16;
		this.toolStripMain.Text = "toolStrip1";
		// 
		// toolStripButtonNew
		// 
		this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
		this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButtonNew.Name = "toolStripButtonNew";
		this.toolStripButtonNew.Size = new System.Drawing.Size(62, 22);
		this.toolStripButtonNew.Text = "New map";
		this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
		// 
		// toolStripButtonOpen
		// 
		this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
		this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButtonOpen.Name = "toolStripButtonOpen";
		this.toolStripButtonOpen.Size = new System.Drawing.Size(40, 22);
		this.toolStripButtonOpen.Text = "Open";
		this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
		// 
		// toolStripButtonSave
		// 
		this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
		this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButtonSave.Name = "toolStripButtonSave";
		this.toolStripButtonSave.Size = new System.Drawing.Size(49, 22);
		this.toolStripButtonSave.Text = "Save as";
		this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
		// 
		// toolStripSeparator1
		// 
		this.toolStripSeparator1.Name = "toolStripSeparator1";
		this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
		// 
		// toolStripButtonWireframe
		// 
		this.toolStripButtonWireframe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.toolStripButtonWireframe.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonWireframe.Image")));
		this.toolStripButtonWireframe.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButtonWireframe.Name = "toolStripButtonWireframe";
		this.toolStripButtonWireframe.Size = new System.Drawing.Size(66, 22);
		this.toolStripButtonWireframe.Text = "Wireframe";
		this.toolStripButtonWireframe.Click += new System.EventHandler(this.toolStripButtonWireframe_Click);
		// 
		// toolStripButtonShading
		// 
		this.toolStripButtonShading.Checked = true;
		this.toolStripButtonShading.CheckState = System.Windows.Forms.CheckState.Checked;
		this.toolStripButtonShading.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.toolStripButtonShading.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShading.Image")));
		this.toolStripButtonShading.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButtonShading.Name = "toolStripButtonShading";
		this.toolStripButtonShading.Size = new System.Drawing.Size(98, 22);
		this.toolStripButtonShading.Text = "Smooth shading";
		this.toolStripButtonShading.Click += new System.EventHandler(this.toolStripButtonShading_Click);
		// 
		// toolStripButtonLiveMode
		// 
		this.toolStripButtonLiveMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.toolStripButtonLiveMode.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLiveMode.Image")));
		this.toolStripButtonLiveMode.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButtonLiveMode.Name = "toolStripButtonLiveMode";
		this.toolStripButtonLiveMode.Size = new System.Drawing.Size(125, 22);
		this.toolStripButtonLiveMode.Text = "Immediate rebuilding";
		this.toolStripButtonLiveMode.Click += new System.EventHandler(this.toolStripButtonLiveMode_Click);
		// 
		// toolStripSeparator2
		// 
		this.toolStripSeparator2.Name = "toolStripSeparator2";
		this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
		// 
		// toolStripLabelMode
		// 
		this.toolStripLabelMode.Name = "toolStripLabelMode";
		this.toolStripLabelMode.Size = new System.Drawing.Size(74, 22);
		this.toolStripLabelMode.Text = "Brush mode:";
		// 
		// toolStripButtonMode
		// 
		this.toolStripButtonMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.toolStripButtonMode.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMode.Image")));
		this.toolStripButtonMode.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButtonMode.Name = "toolStripButtonMode";
		this.toolStripButtonMode.Size = new System.Drawing.Size(38, 22);
		this.toolStripButtonMode.Text = "Paint";
		this.toolStripButtonMode.Click += new System.EventHandler(this.toolStripButtonMode_Click);
		// 
		// splitContainerWorkArea
		// 
		this.splitContainerWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
		this.splitContainerWorkArea.Location = new System.Drawing.Point(0, 25);
		this.splitContainerWorkArea.Name = "splitContainerWorkArea";
		// 
		// splitContainerWorkArea.Panel1
		// 
		this.splitContainerWorkArea.Panel1.Controls.Add(this.glControlTerrainPreview);
		// 
		// splitContainerWorkArea.Panel2
		// 
		this.splitContainerWorkArea.Panel2.Controls.Add(this.panelEditor);
		this.splitContainerWorkArea.Size = new System.Drawing.Size(977, 501);
		this.splitContainerWorkArea.SplitterDistance = 478;
		this.splitContainerWorkArea.TabIndex = 17;
		// 
		// openFileDialog
		// 
		this.openFileDialog.FileName = "openFileDialog";
		this.openFileDialog.Filter = resources.GetString("openFileDialog.Filter");
		this.openFileDialog.RestoreDirectory = true;
		// 
		// saveFileDialog
		// 
		this.saveFileDialog.Filter = "BMP Files: (*.BMP)|*.BMP;|JPEG Files: (*.JPG;*.JPEG)|*.JPG;*.JPEG;|GIF Files: (*." +
    "GIF)|*.GIF|TIFF Files: (*.TIF;*.TIFF)|*.TIF;*.TIFF|PNG Files: (*.PNG)|*.PNG";
		this.saveFileDialog.RestoreDirectory = true;
		// 
		// frmMain
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(977, 693);
		this.Controls.Add(this.splitContainerWorkArea);
		this.Controls.Add(this.toolStripMain);
		this.Controls.Add(this.panelControls);
		this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
		this.MinimumSize = new System.Drawing.Size(993, 512);
		this.Name = "frmMain";
		this.Text = "github.com/Atox/HeightMapper";
		((System.ComponentModel.ISupportInitialize)(this.trackBarRotation)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.trackBarFOV)).EndInit();
		this.panelEditor.ResumeLayout(false);
		this.panelEditor.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeightMap)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.trackBarDetails)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.trackBarHeight)).EndInit();
		this.panelControls.ResumeLayout(false);
		this.panelControls.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.trackBarBrushStrength)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.trackBarBrushSize)).EndInit();
		this.statusStrip.ResumeLayout(false);
		this.statusStrip.PerformLayout();
		this.toolStripMain.ResumeLayout(false);
		this.toolStripMain.PerformLayout();
		this.splitContainerWorkArea.Panel1.ResumeLayout(false);
		this.splitContainerWorkArea.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)(this.splitContainerWorkArea)).EndInit();
		this.splitContainerWorkArea.ResumeLayout(false);
		this.ResumeLayout(false);
		this.PerformLayout();

	  }

	  #endregion

	  private OpenTK.GLControl glControlTerrainPreview;
	  private System.Windows.Forms.PictureBox pictureBoxHeightMap;
	  private System.Windows.Forms.TrackBar trackBarRotation;
	  private System.Windows.Forms.TrackBar trackBarPitch;
	  private System.Windows.Forms.TrackBar trackBarFOV;
	  private System.Windows.Forms.Panel panelEditor;
	  private System.Windows.Forms.Timer tmrRender;
	  private System.Windows.Forms.TrackBar trackBarDetails;
	  private System.Windows.Forms.TrackBar trackBarHeight;
	  private System.Windows.Forms.Label labelRotation;
	  private System.Windows.Forms.Label labelPitch;
	  private System.Windows.Forms.Label labelZoom;
	  private System.Windows.Forms.Label labelDetalization;
	  private System.Windows.Forms.Label labelHeight;
	  private System.Windows.Forms.Panel panelControls;
	  private System.Windows.Forms.ToolStrip toolStripMain;
	  private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
	  private System.Windows.Forms.ToolStripButton toolStripButtonSave;
	  private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	  private System.Windows.Forms.ToolStripLabel toolStripLabelMode;
	  private System.Windows.Forms.ToolStripButton toolStripButtonMode;
	  private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	  private System.Windows.Forms.ToolStripButton toolStripButtonWireframe;
	  private System.Windows.Forms.ToolStripButton toolStripButtonShading;
	  private System.Windows.Forms.SplitContainer splitContainerWorkArea;
	  private System.Windows.Forms.StatusStrip statusStrip;
	  private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
	  private System.Windows.Forms.ToolStripButton toolStripButtonNew;
	  private System.Windows.Forms.ToolStripButton toolStripButtonLiveMode;
	  private System.Windows.Forms.OpenFileDialog openFileDialog;
	  private System.Windows.Forms.SaveFileDialog saveFileDialog;
	  private System.Windows.Forms.Label labelBrushSize;
	  private System.Windows.Forms.TrackBar trackBarBrushSize;
	  private System.Windows.Forms.Label labelBrushStrength;
	  private System.Windows.Forms.TrackBar trackBarBrushStrength;
    }
}

