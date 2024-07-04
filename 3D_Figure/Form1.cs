using System.Numerics;
using Timer = System.Windows.Forms.Timer;

namespace _3D_Figure
{
	public partial class Form1 : Form
	{
		public Form1()
		{	//	����������� ��������� ����
			InitializeComponent();
			matrix.ApplyTest(-35, 30, -35);		//	����������� ������� � ������, ��������� ��� �������
			Reload();							//	�������� ������
			Draw();								//	����������
			animTimer.Tick += AnimTimer_Tick;	//	������ �������� �� ������� (����� �������)
			animTimer.Interval = 1;				//	�������� ��������� 1��
		}

		#region VARIABLES
		Matrixes3D matrix = new Matrixes3D();				//	������� �����������
		Figure fig;											//	������

		int currentXAngle = -35;							//	������ ���� ������
		int currentYAngle = 30;								
		int currentZAngle = -35;

		int defaultAngle1 = -35;							//	��������� ���� ������
		int defaultAngle2 = 30;								//	(��������)
		int defaultAngle3 = -35;

		Timer animTimer = new Timer();						//	������ �������
		Vector3 rotationVector = new Vector3(1, 0, 0);		//	������ ������ ������� ���� (�������)
		int currentRotateAxis = 0;							//	������� ��� ��������� (�������)
		int testAngle = 1;                                  //	��� ������ ��� ������� (��������)
		#endregion

		#region DRAWING
		private void Reload()
		{	//	������������ ������ � ��������� ��������
			fig = new Figure(
				(float)Convert.ToDouble(scaleTextBox.Text),
				drawPicBox,
				matrix);
		}
		public void Draw()
		{	//	�������� � ������ ������ � �����
			using (Graphics g = drawPicBox.CreateGraphics())
			{
				g.DrawImage(fig.getFigure(), 0, 0);
			}
		}
		public void Draw(Matrixes3D matrix)
		{	//	��������� ��� ���� ����, ����������� ������ ������� �� ����� ������
			Bitmap cordBM = fig.getCoord();
			using (Graphics g = Graphics.FromImage(cordBM))
			{
				g.DrawImage(fig.getNewFigure(matrix), 0, 0);
			}
			using (Graphics g = drawPicBox.CreateGraphics())
			{
				g.DrawImage(cordBM, 0, 0);
			}
		}
		#endregion

		#region EVENTS
		private void resetRotationButton_Click(object sender, EventArgs e)
		{   //	������ "RESET"
			//	������� �� ���� �� ���� �� �����������
			oxTrackBar.Value = oyTrackBar.Value = ozTrackBar.Value = 0;

			currentXAngle = defaultAngle1;
			currentYAngle = defaultAngle2;
			currentZAngle = defaultAngle3;

			oxRotationTextBox.Text = oyRotationTextBox.Text = ozRotationTextBox.Text = "0";
			
			Reload();	//	������������ ������

			//	���������� ����� �������� ������
			TrackBar_Scroll(null, new EventArgs());
		}
		private void TrackBar_Scroll(object sender, EventArgs e)
		{	//	�������� ������
			currentXAngle = oxTrackBar.Value + defaultAngle1;	//	���� = �������� � �������� + �������� �� ��������
			currentYAngle = oyTrackBar.Value + defaultAngle2;	//	��� ���� 0 0 0 �������� ��������
			currentZAngle = ozTrackBar.Value + defaultAngle3;
			matrix.ApplyTest(currentXAngle, currentYAngle, currentZAngle);	//	�������� �������
			fig.ApplyMatrix(matrix);										//	����������� ������� ��� ������

			//	������� ������ �������� ��� ��������
			track1NumberLabel.Text = oxTrackBar.Value.ToString();
			track2NumberLabel.Text = oyTrackBar.Value.ToString();
			track3NumberLabel.Text = ozTrackBar.Value.ToString();

			Draw();	//	������������
		}

		private void applyRotation_Click(object sender, EventArgs e)
		{   //	������ ������������ ���������
			try
			{
				//	������ ���� += ������ ��������
				currentXAngle = ((int)Convert.ToDouble(oxRotationTextBox.Text)) + currentXAngle;
				currentYAngle = ((int)Convert.ToDouble(oyRotationTextBox.Text)) + currentYAngle;
				currentZAngle = ((int)Convert.ToDouble(ozRotationTextBox.Text)) + currentZAngle;

				matrix.ApplyTest(currentXAngle, currentYAngle, currentZAngle);
				fig.ApplyMatrix(matrix);

				Draw();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void applyTranslationButton_Click(object sender, EventArgs e)
		{   //	������ ������������ ������� ������
			try
			{
				fig.Translate(
					Convert.ToInt32(oxTranslationTextBox.Text),
					Convert.ToInt32(oyTranslationTextBox.Text),
					Convert.ToInt32(ozTranslationTextBox.Text)
					);
				Draw();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void applyOzIsometricButton_Click(object sender, EventArgs e)
		{	//	������ ������������ ������� z=0
			resetRotationButton.PerformClick();	//	������� ��������� ����� �� ����
			currentXAngle = currentYAngle = 0;	//	�������� 1 �� 2 ���� ������

			oxTrackBar.Value = -defaultAngle1;	//	������� ��������� ��������
			oyTrackBar.Value = -defaultAngle2;

			//	����������� �������� ������� �� ������������
			matrix.ApplyTest(currentXAngle, currentYAngle, currentZAngle);
			Draw();
		}

		private void paramButton_Click(object sender, EventArgs e)
		{	//	������ �������� ��������� ����� ������
			ParamForm paramsWindow = new ParamForm(ref fig, this);
			paramsWindow.ShowDialog();	//	������� ���� ���������
		}


		int h_dir = 10;
		private void AnimTimer_Tick(object? sender, EventArgs e)
		{   //	�� ������� �������

			if (testAngle >= 360)
			{	//	���� �������� ��� (��������) ������-����� �� ������ �����

				//	����������� ��� ��������� (���� ���� Z - �������� ������, ����� �������)
				if (currentRotateAxis == 0) rotationVector = new Vector3(0, 1, 0);
				if (currentRotateAxis == 1) rotationVector = new Vector3(0, 0, 1);
				if (currentRotateAxis == 2) { rotationVector = new Vector3(1, 0, 0); testRotationButton.Enabled = true; animTimer.Stop(); }
				currentRotateAxis++;
				testAngle = 0;	//	������ ��� � 0
			}

			//	���� ������� ��������� ��������� �� ������
			Matrixes3D figRotMatrix = new Matrixes3D();

			//	���������� ������� �� ���������
			figRotMatrix.applySpecificRotation(
				rotationVector,
				testAngle,
				matrix
				);

			if(currentRotateAxis == 0)
			{
				fig.H += h_dir;
				fig.rad1 += h_dir;
			}
			else if(currentRotateAxis == 1)
			{
				fig.H -= h_dir;
				fig.rad1 -= h_dir;
				fig.rad2 += h_dir;
			}
			else if(currentRotateAxis == 2)
			{
				fig.rad2 -= h_dir;
			}
			fig.reCreate();

			testAngle += 10;	//	������������� � �������
			Draw(figRotMatrix);	//	������������
		}

		
		private void testRotationButton_Click(object sender, EventArgs e)
		{	//	������� �������
			currentRotateAxis = 0;
			animTimer.Start();
			testRotationButton.Enabled = false;
		}
		#endregion
	}
}