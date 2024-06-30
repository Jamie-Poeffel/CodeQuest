using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeQuest
{
  public partial class App : Form
  {
    private bool s = true;
    public App()
    {
      InitializeComponent();
      init();
    }

    private void init()
    {
      PictureBox __PicBoxSettings__ = new PictureBox();
      __PicBoxSettings__.BorderStyle = BorderStyle.None;
      __PicBoxSettings__.Image = Image.FromFile(@"..\..\Resources\settings-outline.png");
      __PicBoxSettings__.SizeMode = PictureBoxSizeMode.Zoom;
      __PicBoxSettings__.Size = new Size(30, 30);
      __PicBoxSettings__.Location = new Point(this.Width - __PicBoxSettings__.Width - 30, 10);
      __PicBoxSettings__.Click += delegate
      {
        if (s == true)
        {
          __PicBoxSettings__.Image.Dispose();
          __PicBoxSettings__.Image = Image.FromFile(@"..\..\Resources\settings.png");
          s = false;
        }
        else
        {
          __PicBoxSettings__.Image.Dispose();
          __PicBoxSettings__.Image = Image.FromFile(@"..\..\Resources\settings-outline.png");
          s = true;
        }
      };

      this.Controls.Add(__PicBoxSettings__);
    }
  }
}
