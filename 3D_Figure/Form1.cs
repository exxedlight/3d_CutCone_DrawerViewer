using System.Numerics;
using Timer = System.Windows.Forms.Timer;

namespace _3D_Figure
{
	public partial class Form1 : Form
	{
		public Form1()
		{	//	ініціалізація головного вікна
			InitializeComponent();
			matrix.ApplyTest(-35, 30, -35);		//	застосувати матрицю з кутами, підібраними для ізометрії
			Reload();							//	створити фігуру
			Draw();								//	відмалювати
			animTimer.Tick += AnimTimer_Tick;	//	додати обробник до таймеру (логіка анімації)
			animTimer.Interval = 1;				//	інтервал оновлення 1мс
		}

		#region VARIABLES
		Matrixes3D matrix = new Matrixes3D();				//	матриця перетворень
		Figure fig;											//	фігура

		int currentXAngle = -35;							//	поточні кути обертів
		int currentYAngle = 30;								
		int currentZAngle = -35;

		int defaultAngle1 = -35;							//	стандартні кути обертів
		int defaultAngle2 = 30;								//	(ізометрія)
		int defaultAngle3 = -35;

		Timer animTimer = new Timer();						//	таймер анімації
		Vector3 rotationVector = new Vector3(1, 0, 0);		//	вектор оберту навколо осей (анімація)
		int currentRotateAxis = 0;							//	поточна вісь обертання (анімація)
		int testAngle = 1;                                  //	кут оберту для анімації (лічільник)
		#endregion

		#region DRAWING
		private void Reload()
		{	//	перестворити фігуру з останньою матрицею
			fig = new Figure(
				(float)Convert.ToDouble(scaleTextBox.Text),
				drawPicBox,
				matrix);
		}
		public void Draw()
		{	//	малювати у пікбоксі фігуру з осями
			using (Graphics g = drawPicBox.CreateGraphics())
			{
				g.DrawImage(fig.getFigure(), 0, 0);
			}
		}
		public void Draw(Matrixes3D matrix)
		{	//	малювання без зміни осей, застосувати окрему матрицю до точок фігури
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
		{   //	кнопка "RESET"
			//	скинути всі поля та кути до стандартних
			oxTrackBar.Value = oyTrackBar.Value = ozTrackBar.Value = 0;

			currentXAngle = defaultAngle1;
			currentYAngle = defaultAngle2;
			currentZAngle = defaultAngle3;

			oxRotationTextBox.Text = oyRotationTextBox.Text = ozRotationTextBox.Text = "0";
			
			Reload();	//	перестворити фігуру

			//	відмальовка через обробник скролу
			TrackBar_Scroll(null, new EventArgs());
		}
		private void TrackBar_Scroll(object sender, EventArgs e)
		{	//	обробник скролу
			currentXAngle = oxTrackBar.Value + defaultAngle1;	//	кути = значення з трекбарів + поправка на станартні
			currentYAngle = oyTrackBar.Value + defaultAngle2;	//	щоб кути 0 0 0 означали ізометрію
			currentZAngle = ozTrackBar.Value + defaultAngle3;
			matrix.ApplyTest(currentXAngle, currentYAngle, currentZAngle);	//	створити матрицю
			fig.ApplyMatrix(matrix);										//	застосувати матрицю для фігури

			//	оновити числові значення біля трекбарів
			track1NumberLabel.Text = oxTrackBar.Value.ToString();
			track2NumberLabel.Text = oyTrackBar.Value.ToString();
			track3NumberLabel.Text = ozTrackBar.Value.ToString();

			Draw();	//	перемалювати
		}

		private void applyRotation_Click(object sender, EventArgs e)
		{   //	кнопка застосування обертання
			try
			{
				//	поточні кути += введені значення
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
		{   //	кнопка застосування зміщення фігури
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
		{	//	кнопка застосування ізометрії z=0
			resetRotationButton.PerformClick();	//	скинути положення сцени та кути
			currentXAngle = currentYAngle = 0;	//	обнулити 1 та 2 кути обзору

			oxTrackBar.Value = -defaultAngle1;	//	оновити положення трекбарів
			oyTrackBar.Value = -defaultAngle2;

			//	застосувати оновлену матрицю та перемалювати
			matrix.ApplyTest(currentXAngle, currentYAngle, currentZAngle);
			Draw();
		}

		private void paramButton_Click(object sender, EventArgs e)
		{	//	кнопка відкриття параметрів точок фігурів
			ParamForm paramsWindow = new ParamForm(ref fig, this);
			paramsWindow.ShowDialog();	//	відкриває вікно параметрів
		}


		int h_dir = 10;
		private void AnimTimer_Tick(object? sender, EventArgs e)
		{   //	тік таймеру анімації

			if (testAngle >= 360)
			{	//	якщо поточний кут (лічільник) більший-рівний за повний оберт

				//	переключити вісь обертання (якщо була Z - зупинити таймер, кінецб анімації)
				if (currentRotateAxis == 0) rotationVector = new Vector3(0, 1, 0);
				if (currentRotateAxis == 1) rotationVector = new Vector3(0, 0, 1);
				if (currentRotateAxis == 2) { rotationVector = new Vector3(1, 0, 0); testRotationButton.Enabled = true; animTimer.Stop(); }
				currentRotateAxis++;
				testAngle = 0;	//	почати кут з 0
			}

			//	нова матриця застосовує обертання до фігури
			Matrixes3D figRotMatrix = new Matrixes3D();

			//	встановити матрицю та обертання
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

			testAngle += 10;	//	крокобертання в анімації
			Draw(figRotMatrix);	//	перемалювати
		}

		
		private void testRotationButton_Click(object sender, EventArgs e)
		{	//	початок анімації
			currentRotateAxis = 0;
			animTimer.Start();
			testRotationButton.Enabled = false;
		}
		#endregion
	}
}