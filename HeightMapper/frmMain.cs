using System;
using System.Drawing;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace TerrainEditor {
	public partial class frmMain : Form {

		private LockBitmap heightMap;
		private int details, mousePressed = 0, brushSize = 64;
		private float height = 0.1f, delta, x, z, epsilon = 0.0001f, scale = 5.0f, aspect = 1.0f;
		private Vector3 a, b, c, d;
		private Vector3[,] verticies, normals;
		private bool mouseInsideEditor = false, mode = true;
		private Vector2 mousePos, prevMousePos;
		private float[,] brush;

		public frmMain() {
			InitializeComponent();
		}

		private void setDetails(int details) {
			this.details = details;
			delta = 1.0f / details;
			verticies = new Vector3[details + 1, details + 1];
			normals = new Vector3[details + 1, details + 1];
		}

		private void buildTerrain() {
			x = z = 0.0f;
			for (int i = 0; i < details; i++)
				for (int j = 0; j < details; j++)
					normals[i, j] = Vector3.Zero;
			for (int i = 0; i < details; i++) {
				for (int j = 0; j < details; j++) {
					setVector3(ref c, x + delta - 0.5f, billinear((i + 1.0f) / (float)details, (j + 1.0f) / (float)details) * height, -z - delta + 0.5f);
					if (i == 0 && j == 0) {
						setVector3(ref a, x - 0.5f, billinear(i / (float)details, j / (float)details) * height, -z + 0.5f);
						verticies[i, j] = a;
					}
					else
						a = verticies[i, j];
					if (i == 0) {
						setVector3(ref d, x - 0.5f, billinear(i / (float)details, (j + 1.0f) / (float)details) * height, -z - delta + 0.5f);
						verticies[i, j + 1] = d;
					}
					else
						d = verticies[i, j + 1];
					if (j == 0) {
						setVector3(ref b, x + delta - 0.5f, billinear((i + 1.0f) / (float)details, j / (float)details) * height, -z + 0.5f);
						verticies[i + 1, j] = b;
					}
					else
						b = verticies[i + 1, j];
					verticies[i + 1, j + 1] = c;
					z += delta;
					if (z > delta * details - epsilon)
						z = 0;
					normals[i, j] += Vector3.Cross(b - a, d - a);
					normals[i + 1, j] += Vector3.Cross(c - b, a - b);
					normals[i + 1, j + 1] += Vector3.Cross(d - c, b - c);
					normals[i, j + 1] += Vector3.Cross(a - d, c - d);
				}
				x += delta;
			}
			for (int i = 0; i <= details; i++)
				for (int j = 0; j <= details; j++)
					normals[i, j].Normalize();
		}

		private void newHeightMap(int size) {
			heightMap = new LockBitmap(new Bitmap(size, size));
			heightMap.LockBits();
			for (int i = 0; i < heightMap.Width; i++)
				for (int j = 0; j < heightMap.Height; j++)
					heightMap.SetPixel(i, j, Color.Black);
			heightMap.UnlockBits();
			pictureBoxHeightMap.Image = heightMap.source;
		}

		private void glControlTerrainPreview_Load(object sender, EventArgs e) {
			aspect = (float)glControlTerrainPreview.Width / glControlTerrainPreview.Height;
			GL.ClearColor(Color.SkyBlue);
			GL.DepthFunc(DepthFunction.Lequal);
			GL.Enable(EnableCap.DepthTest);
			GL.CullFace(CullFaceMode.Back);
			GL.Enable(EnableCap.CullFace);
			GL.CullFace(CullFaceMode.Back);
			GL.Color3(1.0f, 1.0f, 1.0f);
			GL.Enable(EnableCap.Lighting);
			GL.Enable(EnableCap.Light0);
			GL.Light(LightName.Light0, LightParameter.Ambient, new Vector4(0.0f, 0.0f, 0.0f, 1.0f));
			GL.Light(LightName.Light0, LightParameter.Diffuse, new Vector4(0.8f, 0.8f, 0.8f, 1.0f));
			GL.Light(LightName.Light0, LightParameter.Specular, new Vector4(0.5f, 0.5f, 0.5f, 1.0f));
			Vector3 lightDir = new Vector3(0.0f, 1.0f, 0.35f);
			lightDir.Normalize();
			GL.Light(LightName.Light0, LightParameter.Position, new Vector4(lightDir.X, lightDir.Y, lightDir.Z, 0.0f));
			newHeightMap(512);
			setDetails(trackBarDetails.Value);
			generateBrush(brushSize);
			heightMap.LockBits();
			buildTerrain();
			heightMap.UnlockBits();
		}

		private float billinear(float u, float v) {
			u *= heightMap.Width;
			v = 1.0f - v;
			v *= heightMap.Height;
			int x = (int)Math.Floor(u);
			int y = (int)Math.Floor(v);
			float u_ratio = u - x;
			float v_ratio = v - y;
			float u_opposite = 1 - u_ratio;
			float v_opposite = 1 - v_ratio;
			if (x >= heightMap.Width - 1)
				x = heightMap.Width - 2;
			if (y >= heightMap.Height - 1)
				y = heightMap.Height - 2;
			float result = (heightMap.GetPixel(x, y).R / 255.0f * u_opposite + heightMap.GetPixel(x + 1, y).R / 255.0f * u_ratio) * v_opposite +
				(heightMap.GetPixel(x, y + 1).R / 255.0f * u_opposite + heightMap.GetPixel(x + 1, y + 1).R / 255.0f * u_ratio) * v_ratio;
			return result;
		}

		private void setVector3(ref Vector3 vector, float x, float y, float z) {
			vector.X = x;
			vector.Y = y;
			vector.Z = z;
		}

		private void glControlTerrainPreview_Paint(object sender, PaintEventArgs e) {
			GL.MatrixMode(MatrixMode.Projection);
			Matrix4 persp = Matrix4.CreatePerspectiveFieldOfView((trackBarFOV.Maximum + trackBarFOV.Minimum - trackBarFOV.Value) / 57.2957549575f, aspect, 0.01f, 5.0f);
			GL.LoadMatrix(ref persp);
			GL.MatrixMode(MatrixMode.Modelview);
			GL.LoadIdentity();
			GL.Translate(0.0f, 0.0f, -2.5f);
			GL.Rotate(trackBarPitch.Value, Vector3d.UnitX);
			GL.Rotate(trackBarRotation.Value, Vector3d.UnitY);
			GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
			GL.Color3(1.0f, 1.0f, 1.0f);
			GL.Begin(BeginMode.Triangles);
			x = z = 0.0f;
			for (int i = 0; i < details; i++) {
				for (int j = 0; j < details; j++) {
					GL.Normal3(normals[i, j]);
					GL.Vertex3(verticies[i, j].X, verticies[i, j].Y, verticies[i, j].Z);
					GL.Normal3(normals[i + 1, j]);
					GL.Vertex3(verticies[i + 1, j].X, verticies[i + 1, j].Y, verticies[i + 1, j].Z);
					GL.Normal3(normals[i, j + 1]);
					GL.Vertex3(verticies[i, j + 1].X, verticies[i, j + 1].Y, verticies[i, j + 1].Z);
					GL.Normal3(normals[i + 1, j]);
					GL.Vertex3(verticies[i + 1, j].X, verticies[i + 1, j].Y, verticies[i + 1, j].Z);
					GL.Normal3(normals[i + 1, j + 1]);
					GL.Vertex3(verticies[i + 1, j + 1].X, verticies[i + 1, j + 1].Y, verticies[i + 1, j + 1].Z);
					GL.Normal3(normals[i, j + 1]);
					GL.Vertex3(verticies[i, j + 1].X, verticies[i, j + 1].Y, verticies[i, j + 1].Z);
					GL.Scale(scale, scale, scale);
					z += delta;
					if (z > delta * details - epsilon)
						z = 0;
				}
				x += delta;
			}
			GL.End();
			glControlTerrainPreview.SwapBuffers();
			toolStripStatusLabel.Text = (Math.Pow(details, 2) * 2).ToString() + " triangles";
		}

		private void glControlTerrainPreview_Resize(object sender, EventArgs e) {
			GL.Viewport(0, 0, glControlTerrainPreview.Width, glControlTerrainPreview.Height);
			aspect = (float)glControlTerrainPreview.Width / glControlTerrainPreview.Height;
		}

		private void trackBarHeight_Scroll(object sender, EventArgs e) {
			height = trackBarHeight.Value / 1000.0f;
			heightMap.LockBits();
			buildTerrain();
			heightMap.UnlockBits();
			glControlTerrainPreview.Invalidate();
		}

		private void trackBarRotation_Scroll(object sender, EventArgs e) {
			glControlTerrainPreview.Invalidate();
		}

		private void trackBarPitch_Scroll(object sender, EventArgs e) {
			glControlTerrainPreview.Invalidate();
		}

		private void trackBarFOV_Scroll(object sender, EventArgs e) {
			glControlTerrainPreview.Invalidate();
		}

		private void toolStripButtonNew_Click(object sender, EventArgs e) {
			frmNew newForm = new frmNew();
			if (newForm.ShowDialog() == DialogResult.OK && newForm.size > 0) {
				newHeightMap(newForm.size);
				heightMap.LockBits();
				buildTerrain();
				heightMap.UnlockBits();
				glControlTerrainPreview.Invalidate();
			}
		}

		private void toolStripButtonOpen_Click(object sender, EventArgs e) {
			openFileDialog.FileName = "";
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				Bitmap loading = new Bitmap(Image.FromFile(openFileDialog.FileName));
				heightMap.source = new Bitmap(Image.FromFile(openFileDialog.FileName));
				pictureBoxHeightMap.Image = heightMap.source;
				heightMap.LockBits();
				buildTerrain();
				heightMap.UnlockBits();
				glControlTerrainPreview.Invalidate();
			}
		}

		private void toolStripButtonSave_Click(object sender, EventArgs e) {
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
				heightMap.source.Save(saveFileDialog.FileName);
		}

		private void trackBarBrushSize_Scroll(object sender, EventArgs e) {
			generateBrush(trackBarBrushSize.Value);
		}

		private void toolStripButtonLiveMode_Click(object sender, EventArgs e) {
			toolStripButtonLiveMode.Checked = !toolStripButtonLiveMode.Checked;
		}

		private void toolStripButtonShading_Click(object sender, EventArgs e) {
			toolStripButtonShading.Checked = !toolStripButtonShading.Checked;
			if (toolStripButtonShading.Checked)
				GL.ShadeModel(ShadingModel.Smooth);
			else
				GL.ShadeModel(ShadingModel.Flat);
			glControlTerrainPreview.Invalidate();
		}

		private void toolStripButtonWireframe_Click(object sender, EventArgs e) {
			toolStripButtonWireframe.Checked = !toolStripButtonWireframe.Checked;
			if (toolStripButtonWireframe.Checked)
				GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Line);
			else
				GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
			glControlTerrainPreview.Invalidate();
		}

		private void toolStripButtonMode_Click(object sender, EventArgs e) {
			mode = !mode;
			if (mode)
				toolStripButtonMode.Text = "Paint";
			else
				toolStripButtonMode.Text = "Erase";
		}

		private void pictureBoxHeightMap_MouseEnter(object sender, EventArgs e) {
			mouseInsideEditor = true;
		}

		private void pictureBoxHeightMap_MouseLeave(object sender, EventArgs e) {
			mouseInsideEditor = false;
		}

		private void pictureBoxHeightMap_MouseUp(object sender, MouseEventArgs e) {
			mousePressed = 0;
			if (!toolStripButtonLiveMode.Checked) {
				heightMap.LockBits();
				buildTerrain();
				heightMap.UnlockBits();
				glControlTerrainPreview.Invalidate();
			}
		}

		private void pictureBoxHeightMap_MouseDown(object sender, MouseEventArgs e) {
			mousePos.X = e.Location.X;
			mousePos.Y = e.Location.Y;
			prevMousePos = mousePos;
			if (e.Button == MouseButtons.Left)
				mousePressed = 1;
			else if (e.Button == MouseButtons.Right)
				mousePressed = 2;
		}

		private void pictureBoxHeightMap_MouseMove(object sender, MouseEventArgs e) {
			mousePos.X = e.Location.X;
			mousePos.Y = e.Location.Y;
		}

		private void trackBarDetails_Scroll(object sender, EventArgs e) {
			setDetails(trackBarDetails.Value);
			heightMap.LockBits();
			buildTerrain();
			heightMap.UnlockBits();
			glControlTerrainPreview.Invalidate();
		}

		private float distance(float x1, float y1, float x2, float y2) {
			return (float)Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
		}

		private void generateBrush(int size) {
			brush = new float[size, size];
			brushSize = size;
			float hSize = size * 0.5f;
			for (int i = 0; i < size; i++)
				for (int j = 0; j < size; j++) {
					float d = distance(i, j, hSize, hSize);
					if (d > hSize)
						brush[i, j] = 0.0f;
					else
						brush[i, j] = 1.0f - d / hSize;
				}
		}

		private void blendPen(int x, int y, float alpha, bool mode) {
			int size = brushSize, hSize = size / 2;
			Color c = Color.White;
			float v = 255;
			int res;
			for (int i = 0; i < size; i++)
				for (int j = 0; j < size; j++) {
					int ax = x + i - hSize;
					int ay = y + j - hSize;
					if (ax >= 0 && ax < heightMap.Width && ay >= 0 && ay < heightMap.Height) {
						c = heightMap.GetPixel(ax, ay);
						v = c.R / 255.0f;
						if (mode)
							res = (int)((v + brush[i, j] * alpha * (1.0f - v)) * 255.0f);
						else
							res = (int)((v - brush[i, j] * alpha * (1.0f - v)) * 255.0f);
						if (res > 255)
							res = 255;
						else if (res < 0)
							res = 0;
						heightMap.SetPixel(ax, ay, Color.FromArgb(255, res, res, res));
					}
				}
		}

		private void tmrRender_Tick(object sender, EventArgs e) {
			heightMap.LockBits();
			if (mouseInsideEditor && mousePressed != 0) {
				bool mode = this.mode;
				if (mousePressed == 2)
					mode = !mode;
				int x1 = (int)prevMousePos.X, y1 = (int)prevMousePos.Y, x2 = (int)mousePos.X, y2 = (int)mousePos.Y;
				int deltaX = Math.Abs(x2 - x1);
				int deltaY = Math.Abs(y2 - y1);
				int signX = x1 < x2 ? 1 : -1;
				int signY = y1 < y2 ? 1 : -1;
				int error = deltaX - deltaY;
				float alpha = trackBarBrushStrength.Value * 0.001f;
				blendPen(x2, y2, alpha, mode);
				while (x1 != x2 || y1 != y2) {
					blendPen(x1, y1, alpha, mode);
					int error2 = error * 2;
					if (error2 > -deltaY) {
						error -= deltaY;
						x1 += signX;
					}
					if (error2 < deltaX) {
						error += deltaX;
						y1 += signY;
					}
				}
				prevMousePos = mousePos;
				if (toolStripButtonLiveMode.Checked) {
					buildTerrain();
					glControlTerrainPreview.Invalidate();
				}
			}
			heightMap.UnlockBits();
			pictureBoxHeightMap.Invalidate();
		}
	}
}
