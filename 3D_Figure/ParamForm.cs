using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3D_Figure
{
	internal partial class ParamForm : Form
	{
		Figure fig;
		Form1 mainForm;

		public ParamForm(ref Figure _fig, Form1 _mainForm)
		{   //	створення форми параметрів фігури
			InitializeComponent();

			fig = _fig;             //	взяти посилання на фігуру
			mainForm = _mainForm;   //	та на основне вікно програми

			//	отримати значення точок фігури у текстбокси з фігури
			headXTextBox.Text = fig.downCenter.X.ToString();
			headYTextBox.Text = fig.downCenter.Y.ToString();
			headZTextBox.Text = fig.downCenter.Z.ToString();

			r1TextBox.Text = fig.rad1.ToString();
			r2TextBox.Text = fig.rad2.ToString();

			HTextBox.Text = fig.H.ToString();
		}

		private void applyParamButton_Click(object sender, EventArgs e)
		{   //	кнопка застосування

			//	зчитати нові дані з полів для всіх точок фігури
			try
			{
				fig.downCenter = new System.Numerics.Vector3(
					(float)Convert.ToDouble(headXTextBox.Text),
					(float)Convert.ToDouble(headYTextBox.Text),
					(float)Convert.ToDouble(headZTextBox.Text)
					);

				fig.rad1 = Convert.ToInt32(r1TextBox.Text);
				fig.rad2 = Convert.ToInt32(r2TextBox.Text);

				fig.H = Convert.ToInt32(HTextBox.Text);

				//	перемалювати пікбокс у основному вікні
				fig.reCreate();
				mainForm.Draw();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
