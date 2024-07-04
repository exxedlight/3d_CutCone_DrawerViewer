namespace _3D_Figure
{
	partial class ParamForm
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
			paramGroupBox = new GroupBox();
			label2 = new Label();
			label1 = new Label();
			headYTextBox = new TextBox();
			applyParamButton = new Button();
			headXTextBox = new TextBox();
			headZTextBox = new TextBox();
			HTextBox = new TextBox();
			r1TextBox = new TextBox();
			r2TextBox = new TextBox();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			paramGroupBox.SuspendLayout();
			SuspendLayout();
			// 
			// paramGroupBox
			// 
			paramGroupBox.BackColor = Color.Transparent;
			paramGroupBox.Controls.Add(label5);
			paramGroupBox.Controls.Add(label4);
			paramGroupBox.Controls.Add(label3);
			paramGroupBox.Controls.Add(r2TextBox);
			paramGroupBox.Controls.Add(r1TextBox);
			paramGroupBox.Controls.Add(HTextBox);
			paramGroupBox.Controls.Add(label2);
			paramGroupBox.Controls.Add(label1);
			paramGroupBox.Controls.Add(headYTextBox);
			paramGroupBox.Controls.Add(applyParamButton);
			paramGroupBox.Controls.Add(headXTextBox);
			paramGroupBox.Controls.Add(headZTextBox);
			paramGroupBox.ForeColor = SystemColors.ButtonFace;
			paramGroupBox.Location = new Point(12, 12);
			paramGroupBox.Name = "paramGroupBox";
			paramGroupBox.Size = new Size(540, 386);
			paramGroupBox.TabIndex = 29;
			paramGroupBox.TabStop = false;
			paramGroupBox.Text = "Coords";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(263, 168);
			label2.Name = "label2";
			label2.Size = new Size(36, 15);
			label2.TabIndex = 29;
			label2.Text = "x, y, z";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(216, 121);
			label1.Name = "label1";
			label1.Size = new Size(132, 15);
			label1.TabIndex = 28;
			label1.Text = "Down base center point";
			// 
			// headYTextBox
			// 
			headYTextBox.BackColor = SystemColors.InactiveCaptionText;
			headYTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			headYTextBox.ForeColor = SystemColors.Window;
			headYTextBox.Location = new Point(258, 140);
			headYTextBox.Name = "headYTextBox";
			headYTextBox.Size = new Size(48, 25);
			headYTextBox.TabIndex = 8;
			headYTextBox.Text = "0";
			headYTextBox.TextAlign = HorizontalAlignment.Center;
			// 
			// applyParamButton
			// 
			applyParamButton.BackColor = Color.Black;
			applyParamButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
			applyParamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
			applyParamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
			applyParamButton.FlatStyle = FlatStyle.Flat;
			applyParamButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			applyParamButton.ForeColor = SystemColors.ButtonFace;
			applyParamButton.Location = new Point(175, 335);
			applyParamButton.Name = "applyParamButton";
			applyParamButton.Size = new Size(195, 45);
			applyParamButton.TabIndex = 7;
			applyParamButton.Text = "Apply";
			applyParamButton.UseVisualStyleBackColor = false;
			applyParamButton.Click += applyParamButton_Click;
			// 
			// headXTextBox
			// 
			headXTextBox.BackColor = SystemColors.InactiveCaptionText;
			headXTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			headXTextBox.ForeColor = SystemColors.Window;
			headXTextBox.Location = new Point(204, 140);
			headXTextBox.Name = "headXTextBox";
			headXTextBox.Size = new Size(48, 25);
			headXTextBox.TabIndex = 7;
			headXTextBox.Text = "0";
			headXTextBox.TextAlign = HorizontalAlignment.Center;
			// 
			// headZTextBox
			// 
			headZTextBox.BackColor = SystemColors.InactiveCaptionText;
			headZTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			headZTextBox.ForeColor = SystemColors.Window;
			headZTextBox.Location = new Point(312, 139);
			headZTextBox.Name = "headZTextBox";
			headZTextBox.Size = new Size(48, 25);
			headZTextBox.TabIndex = 9;
			headZTextBox.Text = "0";
			headZTextBox.TextAlign = HorizontalAlignment.Center;
			// 
			// HTextBox
			// 
			HTextBox.BackColor = SystemColors.InactiveCaptionText;
			HTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			HTextBox.ForeColor = SystemColors.Window;
			HTextBox.Location = new Point(105, 38);
			HTextBox.Name = "HTextBox";
			HTextBox.Size = new Size(48, 25);
			HTextBox.TabIndex = 30;
			HTextBox.Text = "0";
			HTextBox.TextAlign = HorizontalAlignment.Center;
			// 
			// r1TextBox
			// 
			r1TextBox.BackColor = SystemColors.InactiveCaptionText;
			r1TextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			r1TextBox.ForeColor = SystemColors.Window;
			r1TextBox.Location = new Point(385, 226);
			r1TextBox.Name = "r1TextBox";
			r1TextBox.Size = new Size(48, 25);
			r1TextBox.TabIndex = 31;
			r1TextBox.Text = "0";
			r1TextBox.TextAlign = HorizontalAlignment.Center;
			// 
			// r2TextBox
			// 
			r2TextBox.BackColor = SystemColors.InactiveCaptionText;
			r2TextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			r2TextBox.ForeColor = SystemColors.Window;
			r2TextBox.Location = new Point(385, 257);
			r2TextBox.Name = "r2TextBox";
			r2TextBox.Size = new Size(48, 25);
			r2TextBox.TabIndex = 32;
			r2TextBox.Text = "0";
			r2TextBox.TextAlign = HorizontalAlignment.Center;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(56, 48);
			label3.Name = "label3";
			label3.Size = new Size(43, 15);
			label3.TabIndex = 33;
			label3.Text = "Heigth";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(328, 236);
			label4.Name = "label4";
			label4.Size = new Size(51, 15);
			label4.TabIndex = 34;
			label4.Text = "Radius 1";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(328, 267);
			label5.Name = "label5";
			label5.Size = new Size(51, 15);
			label5.TabIndex = 35;
			label5.Text = "Radius 2";
			// 
			// ParamForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaptionText;
			ClientSize = new Size(568, 417);
			Controls.Add(paramGroupBox);
			Name = "ParamForm";
			Text = "ParamForm";
			paramGroupBox.ResumeLayout(false);
			paramGroupBox.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox paramGroupBox;
		private TextBox headYTextBox;
		private Button applyParamButton;
		private TextBox headXTextBox;
		private TextBox bottom4z;
		private TextBox headZTextBox;
		private TextBox bottom4y;
		private TextBox bottom2x;
		private TextBox bottom4x;
		private TextBox bottom2y;
		private TextBox bottom1z;
		private TextBox bottom2z;
		private TextBox bottom1y;
		private TextBox bottom3y;
		private TextBox bottom1x;
		private TextBox bottom3x;
		private TextBox bottom5z;
		private TextBox bottom3z;
		private TextBox bottom5y;
		private TextBox bottom6x;
		private TextBox bottom5x;
		private TextBox bottom6y;
		private TextBox bottom6z;
		private Label label3;
		private Label label2;
		private Label label1;
		private Label label5;
		private Label label4;
		private TextBox r2TextBox;
		private TextBox r1TextBox;
		private TextBox HTextBox;
	}
}