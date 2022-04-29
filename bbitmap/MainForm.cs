/*
 * Created by SharpDevelop.
 * User: Mahmud Can
 * Date: 18.04.2022
 * Time: 15:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace bbitmap
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			int width=1260;int height=720;
			Bitmap bitmap = new Bitmap(width,height);
			
			Random rand = new Random();
			
			for(int y=0;y<height;y++){
				for(int x=0;x<width;x++){
					bitmap.SetPixel(x,y,Color.FromArgb(rand.Next(256),rand.Next(256),rand.Next(256),rand.Next(256)));
				}
			}
			
			pictureBox1.Image=bitmap;
			
			bitmap.Save(@"bitmaps\bitmap.png");
			
		}
	}
}
