using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Figure
{
	internal class Figure : Coord		//	ФІГУРА (СПАДКУЮ КООРДИНАТНІ ОСІ)
	{
		public List<List<Vector3>> circles; //	lists of circles of cone
		public Vector3 downCenter;
		public int H;
		public int rad1, rad2;
		public int H_step;

		public List<Point> texture;
		public List<Vector3> figure;

		public void loadTexPoints()
		{
			StreamReader reader = new StreamReader("all_points.txt");
			texture = new List<Point>();

			while(reader.Peek() != -1)
			{
				string line = reader.ReadLine();
				texture.Add(new Point(
					Convert.ToInt32(line.Split(' ')[0]), 
					Convert.ToInt32(line.Split(' ')[1])));
			}
			reader.Close();

			figure = new List<Vector3>();

			List<float> list_u = new List<float>();
			List<float> list_v = new List<float>();

			foreach (var texPoint in texture)
			{
				float u = ((float)texPoint.X * (MathF.PI / 6)) / 10.0f;
				float v = ((float)texPoint.Y * (MathF.PI / 6)) / 10.0f;

				list_u.Add(u);
				list_v.Add(v);
			}

			foreach (var texPoint in texture)
			{
				float u = ((float)texPoint.X * (MathF.PI/6)) / 10.0f;
				float v = ((float)texPoint.Y * (MathF.PI/6)) / 10.0f;

				v *= 2;
				u *= 2;

				float atan2 = MathF.Atan2(list_v.Max() - list_v.Min(), list_u.Max() - list_u.Min()) * u;
				figure.Add(new Vector3(
					downCenter.X + (rad1 - ((rad1 - rad2) / H) * u) * MathF.Cos(DegToRad(v)) * MathF.Cos(DegToRad(atan2)),
					downCenter.Y + (rad1 - ((rad1 - rad2) / H) * u) * MathF.Sin(DegToRad(v)) * MathF.Cos(DegToRad(atan2)),
					downCenter.Z + (rad1 - ((rad1 - rad2) / H) * u) * MathF.Sin(DegToRad(atan2))
				));
			}
		}

		public Figure(float Scale, PictureBox box, Matrixes3D matrix) : base(Scale, box, matrix) 
		{	//	створення фігури через конструктор
			resetFigure();
		}

		public static float DegToRad(float deg) { return deg * (MathF.PI / 180.0f); }

		public void resetFigure()
		{   //	стандартні координати всіх точок

			circles = new List<List<Vector3>>();
			downCenter = new Vector3(20*Scale, 20*Scale, 0);
			H = (int)(40*Scale);
			H_step = (int)(2*Scale);
			rad1 = (int)(20*Scale);
			rad2 = (int)(6*Scale);

			int rad_step = (rad1 - rad2) / (H / H_step);
			int current_rad = rad1;
			int current_h = (int)downCenter.Z;

			for(int i = 0; i < H; i+=H_step)
			{
				circles.Add(new List<Vector3>(getCirclePoint(
					(int)downCenter.X,
					(int)downCenter.Y,
					current_h,
					current_rad
					)));

				current_h += H_step;
				current_rad -= rad_step;
			}
			loadTexPoints();
		}
		public void reCreate()
		{   //	стандартні координати всіх точок

			circles = new List<List<Vector3>>();

			int rad_step = (rad1 - rad2) / (H / H_step);
			int current_rad = rad1;
			int current_h = (int)downCenter.Z;

			for (int i = 0; i < H; i += H_step)
			{
				circles.Add(new List<Vector3>(getCirclePoint(
					(int)downCenter.X,
					(int)downCenter.Y,
					current_h,
					current_rad
					)));

				current_h += H_step;
				current_rad -= rad_step;
			}
			loadTexPoints();
		}

		public List<Vector3> getCirclePoint(int x, int y, int z, int R)
		{   //	приймає координати
			List<Vector3> points = new List<Vector3>();
			
			for (int i = 0; i <= 360; i++)
			{
				double gam = DegToRad(i);
				points.Add(new Vector3(
					Convert.ToInt32(R * Math.Cos(gam)) + x,
					Convert.ToInt32(R * Math.Sin(gam) + y),
					z
					));
			}

			return points;
		}

		public void Translate(int x, int y, int z)
		{   //	перенесення всіх точок НА задані координати
			downCenter = new Vector3(
				downCenter.X + x,
				downCenter.Y + y,
				downCenter.Z + z
				);
			for(int i = 0; i < figure.Count; i++)
			{
				figure[i] = new Vector3(
					figure[i].X + x,
					figure[i].Y + y,
					figure[i].Z + z
					);
			}
			reCreate();
		}
		
		public void ApplyMatrix(Matrixes3D _matrix)
		{	//	оновити матрицю перетворень без перестворення фігури
			matrixes = _matrix;
		}

		public Bitmap getFigure()
		{	//	намалювати осі та фігуру
			Bitmap bm = new Bitmap(Width, Height);

			using (Graphics g = Graphics.FromImage(bm))
			{
				g.DrawImage(getCoord(), new Point(0, 0));

				Pen pen = new Pen(Color.Aquamarine, 1);

				for(int i = 0; i < circles.Count; i++)
				{
					for(int j = 1; j < circles[i].Count; j++)
					{
						g.DrawLine(pen, getWithTranslate(circles[i][j]), getWithTranslate(circles[i][j - 1]));
					}
				}

				for(int i = 0; i < 20; i++)
				{
					g.DrawLine(
						pen, 
						getWithTranslate(circles[0][circles[0].Count/20 * i]), 
						getWithTranslate(circles[circles.Count-1][circles[circles.Count-1].Count/20 * i]
						));
				}

				pen = new Pen(Color.IndianRed);
				for (int i = 1; i < figure.Count; i++)
				{
					g.DrawLine(pen,
						getWithTranslate(figure[i]),
						getWithTranslate(figure[i-1])
						);
				}

			}

			return bm;
		}
		public Bitmap getNewFigure(Matrixes3D matrix)
		{	//	відмалювати лише фігуру, застосувавши до неї окрему матрицю
			Bitmap bm = new Bitmap(Width, Height);

			using (Graphics g = Graphics.FromImage(bm))
			{
				//g.DrawImage(getCoord(), new Point(0, 0));

				Pen pen = new Pen(Color.Aquamarine, 1);

				for (int i = 0; i < circles.Count; i++)
				{
					for (int j = 1; j < circles[i].Count; j++)
					{
						g.DrawLine(pen, getWithTranslate(circles[i][j], matrix), getWithTranslate(circles[i][j - 1], matrix));
					}
				}

				for (int i = 0; i < 20; i++)
				{
					g.DrawLine(
						pen,
						getWithTranslate(circles[0][circles[0].Count / 20 * i], matrix),
						getWithTranslate(circles[circles.Count - 1][circles[circles.Count - 1].Count / 20 * i], matrix
						));
				}

				pen = new Pen(Color.IndianRed);
				for (int i = 1; i < figure.Count; i++)
				{
					g.DrawLine(pen,
						getWithTranslate(figure[i], matrix),
						getWithTranslate(figure[i - 1], matrix)
						);
				}

			}

			return bm;
		}
	}
}
