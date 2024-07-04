namespace _3D_Figure
{
	partial class Form1
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
			drawPicBox = new PictureBox();
			panel1 = new Panel();
			resetRotationButton = new Button();
			track3NumberLabel = new Label();
			track2NumberLabel = new Label();
			track1NumberLabel = new Label();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			ozTrackBar = new TrackBar();
			oyTrackBar = new TrackBar();
			oxTrackBar = new TrackBar();
			groupBox2 = new GroupBox();
			applyRotation = new Button();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			ozRotationTextBox = new TextBox();
			oyRotationTextBox = new TextBox();
			oxRotationTextBox = new TextBox();
			groupBox1 = new GroupBox();
			applyTranslationButton = new Button();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			ozTranslationTextBox = new TextBox();
			oyTranslationTextBox = new TextBox();
			oxTranslationTextBox = new TextBox();
			scaleTextBox = new TextBox();
			label10 = new Label();
			applyOzIsometricButton = new Button();
			paramButton = new Button();
			testRotationButton = new Button();
			((System.ComponentModel.ISupportInitialize)drawPicBox).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ozTrackBar).BeginInit();
			((System.ComponentModel.ISupportInitialize)oyTrackBar).BeginInit();
			((System.ComponentModel.ISupportInitialize)oxTrackBar).BeginInit();
			groupBox2.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// drawPicBox
			// 
			drawPicBox.BorderStyle = BorderStyle.FixedSingle;
			drawPicBox.Location = new Point(12, 12);
			drawPicBox.Name = "drawPicBox";
			drawPicBox.Size = new Size(985, 713);
			drawPicBox.TabIndex = 0;
			drawPicBox.TabStop = false;
			// 
			// panel1
			// 
			panel1.AutoScroll = true;
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(testRotationButton);
			panel1.Controls.Add(resetRotationButton);
			panel1.Controls.Add(track3NumberLabel);
			panel1.Controls.Add(track2NumberLabel);
			panel1.Controls.Add(track1NumberLabel);
			panel1.Controls.Add(label9);
			panel1.Controls.Add(label8);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(ozTrackBar);
			panel1.Controls.Add(oyTrackBar);
			panel1.Controls.Add(oxTrackBar);
			panel1.Controls.Add(groupBox2);
			panel1.Controls.Add(groupBox1);
			panel1.Location = new Point(1003, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(254, 713);
			panel1.TabIndex = 1;
			// 
			// resetRotationButton
			// 
			resetRotationButton.FlatStyle = FlatStyle.Flat;
			resetRotationButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			resetRotationButton.ForeColor = SystemColors.AppWorkspace;
			resetRotationButton.Location = new Point(3, 389);
			resetRotationButton.Name = "resetRotationButton";
			resetRotationButton.Size = new Size(237, 38);
			resetRotationButton.TabIndex = 7;
			resetRotationButton.Text = "Reset";
			resetRotationButton.TextAlign = ContentAlignment.TopCenter;
			resetRotationButton.UseVisualStyleBackColor = true;
			resetRotationButton.Click += resetRotationButton_Click;
			// 
			// track3NumberLabel
			// 
			track3NumberLabel.AutoSize = true;
			track3NumberLabel.ForeColor = SystemColors.AppWorkspace;
			track3NumberLabel.Location = new Point(240, 338);
			track3NumberLabel.Name = "track3NumberLabel";
			track3NumberLabel.Size = new Size(0, 15);
			track3NumberLabel.TabIndex = 16;
			// 
			// track2NumberLabel
			// 
			track2NumberLabel.AutoSize = true;
			track2NumberLabel.ForeColor = SystemColors.AppWorkspace;
			track2NumberLabel.Location = new Point(240, 287);
			track2NumberLabel.Name = "track2NumberLabel";
			track2NumberLabel.Size = new Size(0, 15);
			track2NumberLabel.TabIndex = 15;
			// 
			// track1NumberLabel
			// 
			track1NumberLabel.AutoSize = true;
			track1NumberLabel.ForeColor = SystemColors.AppWorkspace;
			track1NumberLabel.Location = new Point(240, 245);
			track1NumberLabel.Name = "track1NumberLabel";
			track1NumberLabel.Size = new Size(0, 15);
			track1NumberLabel.TabIndex = 14;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.ForeColor = SystemColors.AppWorkspace;
			label9.Location = new Point(3, 368);
			label9.Name = "label9";
			label9.Size = new Size(80, 15);
			label9.TabIndex = 13;
			label9.Text = "Front rotation";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.ForeColor = SystemColors.AppWorkspace;
			label8.Location = new Point(3, 317);
			label8.Name = "label8";
			label8.Size = new Size(90, 15);
			label8.TabIndex = 12;
			label8.Text = "Vertical rotation";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.ForeColor = SystemColors.AppWorkspace;
			label7.Location = new Point(3, 266);
			label7.Name = "label7";
			label7.Size = new Size(67, 15);
			label7.TabIndex = 11;
			label7.Text = "Ox rotation";
			// 
			// ozTrackBar
			// 
			ozTrackBar.BackColor = SystemColors.ActiveCaptionText;
			ozTrackBar.Location = new Point(3, 338);
			ozTrackBar.Maximum = 180;
			ozTrackBar.Minimum = -180;
			ozTrackBar.Name = "ozTrackBar";
			ozTrackBar.Size = new Size(236, 45);
			ozTrackBar.TabIndex = 10;
			ozTrackBar.TickFrequency = 10;
			ozTrackBar.Scroll += TrackBar_Scroll;
			// 
			// oyTrackBar
			// 
			oyTrackBar.BackColor = SystemColors.ActiveCaptionText;
			oyTrackBar.Location = new Point(3, 287);
			oyTrackBar.Maximum = 180;
			oyTrackBar.Minimum = -180;
			oyTrackBar.Name = "oyTrackBar";
			oyTrackBar.Size = new Size(236, 45);
			oyTrackBar.TabIndex = 9;
			oyTrackBar.TickFrequency = 10;
			oyTrackBar.Scroll += TrackBar_Scroll;
			// 
			// oxTrackBar
			// 
			oxTrackBar.BackColor = SystemColors.ActiveCaptionText;
			oxTrackBar.Location = new Point(3, 236);
			oxTrackBar.Maximum = 180;
			oxTrackBar.Minimum = -180;
			oxTrackBar.Name = "oxTrackBar";
			oxTrackBar.Size = new Size(236, 45);
			oxTrackBar.TabIndex = 8;
			oxTrackBar.TickFrequency = 10;
			oxTrackBar.Scroll += TrackBar_Scroll;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(applyRotation);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(label5);
			groupBox2.Controls.Add(label6);
			groupBox2.Controls.Add(ozRotationTextBox);
			groupBox2.Controls.Add(oyRotationTextBox);
			groupBox2.Controls.Add(oxRotationTextBox);
			groupBox2.ForeColor = SystemColors.ButtonHighlight;
			groupBox2.Location = new Point(3, 483);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(227, 225);
			groupBox2.TabIndex = 7;
			groupBox2.TabStop = false;
			groupBox2.Text = "Rotation";
			// 
			// applyRotation
			// 
			applyRotation.FlatStyle = FlatStyle.Flat;
			applyRotation.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			applyRotation.Location = new Point(9, 163);
			applyRotation.Name = "applyRotation";
			applyRotation.Size = new Size(195, 45);
			applyRotation.TabIndex = 6;
			applyRotation.Text = "Apply";
			applyRotation.UseVisualStyleBackColor = true;
			applyRotation.Click += applyRotation_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(21, 108);
			label4.Name = "label4";
			label4.Size = new Size(35, 25);
			label4.TabIndex = 5;
			label4.Text = "Oz";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(21, 69);
			label5.Name = "label5";
			label5.Size = new Size(35, 25);
			label5.TabIndex = 4;
			label5.Text = "Oy";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(21, 30);
			label6.Name = "label6";
			label6.Size = new Size(35, 25);
			label6.TabIndex = 3;
			label6.Text = "Ox";
			// 
			// ozRotationTextBox
			// 
			ozRotationTextBox.BackColor = SystemColors.InactiveCaptionText;
			ozRotationTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			ozRotationTextBox.ForeColor = SystemColors.Window;
			ozRotationTextBox.Location = new Point(104, 100);
			ozRotationTextBox.Name = "ozRotationTextBox";
			ozRotationTextBox.Size = new Size(100, 33);
			ozRotationTextBox.TabIndex = 2;
			ozRotationTextBox.Text = "0";
			ozRotationTextBox.TextAlign = HorizontalAlignment.Center;
			// 
			// oyRotationTextBox
			// 
			oyRotationTextBox.BackColor = SystemColors.InactiveCaptionText;
			oyRotationTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			oyRotationTextBox.ForeColor = SystemColors.Window;
			oyRotationTextBox.Location = new Point(104, 61);
			oyRotationTextBox.Name = "oyRotationTextBox";
			oyRotationTextBox.Size = new Size(100, 33);
			oyRotationTextBox.TabIndex = 1;
			oyRotationTextBox.Text = "0";
			oyRotationTextBox.TextAlign = HorizontalAlignment.Center;
			// 
			// oxRotationTextBox
			// 
			oxRotationTextBox.BackColor = SystemColors.InactiveCaptionText;
			oxRotationTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			oxRotationTextBox.ForeColor = SystemColors.Window;
			oxRotationTextBox.Location = new Point(104, 22);
			oxRotationTextBox.Name = "oxRotationTextBox";
			oxRotationTextBox.Size = new Size(100, 33);
			oxRotationTextBox.TabIndex = 0;
			oxRotationTextBox.Text = "0";
			oxRotationTextBox.TextAlign = HorizontalAlignment.Center;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(applyTranslationButton);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(ozTranslationTextBox);
			groupBox1.Controls.Add(oyTranslationTextBox);
			groupBox1.Controls.Add(oxTranslationTextBox);
			groupBox1.ForeColor = SystemColors.ButtonHighlight;
			groupBox1.Location = new Point(3, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(227, 225);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Translation offset";
			// 
			// applyTranslationButton
			// 
			applyTranslationButton.FlatStyle = FlatStyle.Flat;
			applyTranslationButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			applyTranslationButton.Location = new Point(9, 163);
			applyTranslationButton.Name = "applyTranslationButton";
			applyTranslationButton.Size = new Size(195, 45);
			applyTranslationButton.TabIndex = 6;
			applyTranslationButton.Text = "Apply";
			applyTranslationButton.UseVisualStyleBackColor = true;
			applyTranslationButton.Click += applyTranslationButton_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(21, 108);
			label3.Name = "label3";
			label3.Size = new Size(35, 25);
			label3.TabIndex = 5;
			label3.Text = "Oz";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(21, 69);
			label2.Name = "label2";
			label2.Size = new Size(35, 25);
			label2.TabIndex = 4;
			label2.Text = "Oy";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(21, 30);
			label1.Name = "label1";
			label1.Size = new Size(35, 25);
			label1.TabIndex = 3;
			label1.Text = "Ox";
			// 
			// ozTranslationTextBox
			// 
			ozTranslationTextBox.BackColor = SystemColors.InactiveCaptionText;
			ozTranslationTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			ozTranslationTextBox.ForeColor = SystemColors.Window;
			ozTranslationTextBox.Location = new Point(104, 100);
			ozTranslationTextBox.Name = "ozTranslationTextBox";
			ozTranslationTextBox.Size = new Size(100, 33);
			ozTranslationTextBox.TabIndex = 2;
			ozTranslationTextBox.Text = "0";
			ozTranslationTextBox.TextAlign = HorizontalAlignment.Center;
			// 
			// oyTranslationTextBox
			// 
			oyTranslationTextBox.BackColor = SystemColors.InactiveCaptionText;
			oyTranslationTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			oyTranslationTextBox.ForeColor = SystemColors.Window;
			oyTranslationTextBox.Location = new Point(104, 61);
			oyTranslationTextBox.Name = "oyTranslationTextBox";
			oyTranslationTextBox.Size = new Size(100, 33);
			oyTranslationTextBox.TabIndex = 1;
			oyTranslationTextBox.Text = "0";
			oyTranslationTextBox.TextAlign = HorizontalAlignment.Center;
			// 
			// oxTranslationTextBox
			// 
			oxTranslationTextBox.BackColor = SystemColors.InactiveCaptionText;
			oxTranslationTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			oxTranslationTextBox.ForeColor = SystemColors.Window;
			oxTranslationTextBox.Location = new Point(104, 22);
			oxTranslationTextBox.Name = "oxTranslationTextBox";
			oxTranslationTextBox.Size = new Size(100, 33);
			oxTranslationTextBox.TabIndex = 0;
			oxTranslationTextBox.Text = "0";
			oxTranslationTextBox.TextAlign = HorizontalAlignment.Center;
			// 
			// scaleTextBox
			// 
			scaleTextBox.BackColor = SystemColors.InactiveCaptionText;
			scaleTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			scaleTextBox.ForeColor = SystemColors.Window;
			scaleTextBox.Location = new Point(897, 688);
			scaleTextBox.Name = "scaleTextBox";
			scaleTextBox.Size = new Size(100, 33);
			scaleTextBox.TabIndex = 7;
			scaleTextBox.Text = "5";
			scaleTextBox.TextAlign = HorizontalAlignment.Center;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label10.ForeColor = SystemColors.ButtonFace;
			label10.Location = new Point(835, 691);
			label10.Name = "label10";
			label10.Size = new Size(56, 25);
			label10.TabIndex = 7;
			label10.Text = "Scale";
			// 
			// applyOzIsometricButton
			// 
			applyOzIsometricButton.FlatStyle = FlatStyle.Flat;
			applyOzIsometricButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			applyOzIsometricButton.ForeColor = SystemColors.ButtonHighlight;
			applyOzIsometricButton.Location = new Point(12, 691);
			applyOzIsometricButton.Name = "applyOzIsometricButton";
			applyOzIsometricButton.Size = new Size(195, 33);
			applyOzIsometricButton.TabIndex = 7;
			applyOzIsometricButton.Text = "Oz=0 isometria";
			applyOzIsometricButton.UseVisualStyleBackColor = true;
			applyOzIsometricButton.Click += applyOzIsometricButton_Click;
			// 
			// paramButton
			// 
			paramButton.FlatStyle = FlatStyle.Flat;
			paramButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			paramButton.ForeColor = SystemColors.ButtonHighlight;
			paramButton.Location = new Point(12, 652);
			paramButton.Name = "paramButton";
			paramButton.Size = new Size(195, 33);
			paramButton.TabIndex = 29;
			paramButton.Text = "Figure parametrs";
			paramButton.UseVisualStyleBackColor = true;
			paramButton.Click += paramButton_Click;
			// 
			// testRotationButton
			// 
			testRotationButton.FlatStyle = FlatStyle.Flat;
			testRotationButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			testRotationButton.ForeColor = SystemColors.AppWorkspace;
			testRotationButton.Location = new Point(2, 439);
			testRotationButton.Name = "testRotationButton";
			testRotationButton.Size = new Size(237, 38);
			testRotationButton.TabIndex = 17;
			testRotationButton.Text = "tst rt";
			testRotationButton.TextAlign = ContentAlignment.TopCenter;
			testRotationButton.UseVisualStyleBackColor = true;
			testRotationButton.Click += testRotationButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaptionText;
			ClientSize = new Size(1252, 737);
			Controls.Add(paramButton);
			Controls.Add(applyOzIsometricButton);
			Controls.Add(label10);
			Controls.Add(scaleTextBox);
			Controls.Add(panel1);
			Controls.Add(drawPicBox);
			Name = "Form1";
			Text = "_______3D_______";
			((System.ComponentModel.ISupportInitialize)drawPicBox).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ozTrackBar).EndInit();
			((System.ComponentModel.ISupportInitialize)oyTrackBar).EndInit();
			((System.ComponentModel.ISupportInitialize)oxTrackBar).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox drawPicBox;
		private Panel panel1;
		private GroupBox groupBox1;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox ozTranslationTextBox;
		private TextBox oyTranslationTextBox;
		private TextBox oxTranslationTextBox;
		private Button applyTranslationButton;
		private GroupBox groupBox2;
		private Button applyRotation;
		private Label label4;
		private Label label5;
		private Label label6;
		private TextBox ozRotationTextBox;
		private TextBox oyRotationTextBox;
		private TextBox oxRotationTextBox;
		private TrackBar ozTrackBar;
		private TrackBar oyTrackBar;
		private TrackBar oxTrackBar;
		private Label label7;
		private Button resetRotationButton;
		private Label track3NumberLabel;
		private Label track2NumberLabel;
		private Label track1NumberLabel;
		private Label label9;
		private Label label8;
		private TextBox scaleTextBox;
		private Label label10;
		private Button applyOzIsometricButton;
		private Button paramButton;
		private Button testRotationButton;
	}
}