using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Figure
{
	public class Matrixes3D
	{
		public Matrix4x4 matrix;	//	матриця

		//	кут у радіани
		public static float DegToRad(float deg) { return deg * (MathF.PI / 180.0f); }
		
		public Matrixes3D()
		{	//	стандартна матриця (хз шо це...)
			matrix = new Matrix4x4(
				1, 0, 0, 0,
				0, 1, 0, 0,
				0, 0, 0, 0,
				0, 0, 0, 1
				);
		}

		public void ApplyTest(float A, float B, float C)
		{	//	основна матриця з 3 кутами огляду
			A = DegToRad(A); B = DegToRad(B); C = DegToRad(C);

			matrix = new Matrix4x4(
				MathF.Cos(A) * MathF.Sin(C) + MathF.Sin(A) * MathF.Sin(B) * MathF.Cos(C), MathF.Cos(A) * MathF.Cos(C) - MathF.Sin(A) * MathF.Sin(B) * MathF.Sin(C), -MathF.Sin(A) * MathF.Cos(B), 0,
				MathF.Cos(B) * MathF.Cos(C), -MathF.Cos(B) * MathF.Sin(C), MathF.Sin(B), 0,
				MathF.Sin(A) * MathF.Sin(C) - MathF.Cos(A) * MathF.Sin(B) * MathF.Cos(C), MathF.Sin(A) * MathF.Cos(C) + MathF.Cos(A) * MathF.Sin(B) * MathF.Sin(C), MathF.Cos(A) * MathF.Cos(B), 0,
				0, 0, 0, 1
				);

		}

		public void applySpecificRotation(Vector3 axis, float angle, Matrixes3D mainMatrix)
		{	//	матриця оберту точки навколо всіх кординатних осей
			angle = DegToRad(angle);

			//	приймає кут оберту, основну матрицю, та одиничний вектор осі

			//	матриця оберту від будь-якої осі
			matrix = new Matrix4x4(
				MathF.Cos(angle) + (1 - MathF.Cos(angle))*MathF.Pow(axis.X,2), (1-MathF.Cos(angle))*axis.X*axis.Y - MathF.Sin(angle)*axis.Z, (1-MathF.Cos(angle))*axis.X*axis.Z + MathF.Sin(angle)*axis.Y, 0,
				(1-MathF.Cos(angle))*axis.Y*axis.X + MathF.Sin(angle)*axis.Z, MathF.Cos(angle) + (1 - MathF.Cos(angle))*MathF.Pow(axis.Y, 2), (1 - MathF.Cos(angle))*axis.Y*axis.Z - MathF.Sin(angle)*axis.X, 0,
				(1-MathF.Cos(angle))*axis.Z*axis.X - MathF.Sin(angle)*axis.Y, (1-MathF.Cos(angle))*axis.Z*axis.Y + MathF.Sin(angle)*axis.X, MathF.Cos(angle) + (1 - MathF.Cos(angle))*MathF.Pow(axis.Z, 2), 0,
				0,0,0,1
				);

			//	з поправкою на основну матрицю
			matrix = Matrix4x4.Multiply(matrix, mainMatrix.matrix);
		}

		public Point getNewPoint(Vector3 vector)
		{	//	перетворити задану 3д точку у 2д точку за допомогою матриці
			Vector4 calcVec = new Vector4(vector.X, vector.Y, vector.Z, 1);

			calcVec = Vector4.Transform(calcVec, matrix);

			return new Point(((int)calcVec.X), ((int)calcVec.Y));
		}
	}
}
