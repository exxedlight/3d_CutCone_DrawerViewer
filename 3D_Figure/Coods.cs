using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Figure
{
	internal class Coord    //	КООРДИНАТНІ ОСІ
	{
		public Point Zero;          //	2д точка нуля
		public Vector3 Ox, Oy, Oz;  //	точки кінців осей

		public int Width;           //	ширина пікбокса
		public int Height;          //	висота
		public float Scale;         //	масштаб всіх елементів

		public Matrixes3D matrixes; //	основна матриця перетворення

		public Coord(float _scale, PictureBox box, Matrixes3D _matrix)
		{   //	створення осей

			Scale = _scale;                                     //	запам'ятати масштаб
			Zero = new Point(box.Width / 2, box.Height / 2);    //	встановити нуль-точку у центр екрану

			//	кінці осей через 100*масштаб пікселів по своїм координатам
			Ox = new Vector3((int)(100 * Scale), 0, 0);
			Oy = new Vector3(0, (int)(100 * Scale), 0);
			Oz = new Vector3(0, 0, (int)(100 * Scale));

			Width = box.Width; Height = box.Height;

			matrixes = _matrix; //	запам'ятати передану матрицю
		}

		public Point getWithTranslate(Vector3 point)
		{   //	повернути 2д точку з 3д точки, застосувавши основну матрицю
			Point _point = matrixes.getNewPoint(point);
			return new Point(Zero.X + _point.X, Zero.Y + _point.Y);
		}
		public Point getWithTranslate(Vector3 point, Matrixes3D matrix)
		{   //	перетворити 3д точку у 2д точку, застосувавши окрему матрицю
			Point _point = matrix.getNewPoint(point);
			return new Point(Zero.X + _point.X, Zero.Y + _point.Y);
		}

		public Bitmap getCoord()
		{   //	створити координатну площину
			Bitmap plane = new Bitmap(Width, Height);

			using (Graphics g = Graphics.FromImage(plane))
			{
				g.Clear(Color.Black);

				Pen p = new Pen(Color.White, 2);

				g.DrawLine(p, Zero, getWithTranslate(Ox));
				g.DrawLine(p, Zero, getWithTranslate(Oy));
				g.DrawLine(p, Zero, getWithTranslate(Oz));

				g.DrawString("X", new Font("Arial", 14), new SolidBrush(Color.Aqua), getWithTranslate(Ox));
				g.DrawString("Y", new Font("Arial", 14), new SolidBrush(Color.Aqua), getWithTranslate(Oy));
				g.DrawString("Z", new Font("Arial", 14), new SolidBrush(Color.Aqua), getWithTranslate(Oz));


			}

			return plane;
		}
	}
}
