using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeQuest
{
  public partial class App : Form
  {
    PictureBox[] BoxList;
    public static bool s = false;
    private bool b = true;
    public App()
    {
      BoxList = new PictureBox[3];
      InitializeComponent();
      init();
    }
    [STAThread]
    private void init()
    {
      BoxList[0] = new PictureBox();
      BoxList[0].Name = "box1";
      BoxList[0].BorderStyle = BorderStyle.None;
      BoxList[0].Image = Image.FromFile(@"..\..\Resources\settings-outline.png");
      BoxList[0].SizeMode = PictureBoxSizeMode.Zoom;
      BoxList[0].Size = new Size(35, 35);
      BoxList[0].Location = new Point(this.Width - BoxList[0].Width - 30, this.Height - this.Height + BoxList[0].Height + 80);
      BoxList[0].Click += new EventHandler(IconClick);

      BoxList[1] = new PictureBox();
      BoxList[1].Name = "box2";
      BoxList[1].BorderStyle = BorderStyle.None;
      BoxList[1].Image = Image.FromFile(@"..\..\Resources\home-outline_1.png");
      BoxList[1].SizeMode = PictureBoxSizeMode.Zoom;
      BoxList[1].Size = new Size(35, 35);
      BoxList[1].Location = new Point(this.Width - BoxList[1].Width - 30, this.Height - this.Height + BoxList[1].Height + 40);
      BoxList[1].Click += new EventHandler(IconClick);

      BoxList[2] = new PictureBox();
      BoxList[2].Name = "box3";
      BoxList[2].BorderStyle = BorderStyle.None;
      BoxList[2].Image = Image.FromFile(@"..\..\Resources\code-slash-outline.png");
      BoxList[2].SizeMode = PictureBoxSizeMode.Zoom;
      BoxList[2].Size = new Size(35, 35);
      BoxList[2].Location = new Point(this.Width - BoxList[2].Width - 30, this.Height - this.Height + BoxList[2].Height);
      BoxList[2].Click += new EventHandler(IconClick);


      this.Controls.Add(BoxList[0]);
      this.Controls.Add(BoxList[1]);
      this.Controls.Add(BoxList[2]);

    }
    [STAThread]
    private void IconClick(object sender, EventArgs e)
    {
      PictureBox box = sender as PictureBox;
      char[] setters = {
        'o',
        'f',
      };

      foreach (var item in BoxList)
      {
        item.Image.Dispose();
        item.Image = Setfile(setters[0], item);
      }
      b = true;

      if (b == true && box.Name == "box1")
      {
        BoxList[0].Image.Dispose();
        BoxList[0].Image = Image.FromFile(@"..\..\Resources\settings.png");
        b = false;
      }
      else if (b == false && box.Name == "box1")
      {
        BoxList[0].Image.Dispose();
        BoxList[0].Image = Image.FromFile(@"..\..\Resources\settings-outline.png");
        b = true;
      }
      else if (b == true && box.Name == "box2")
      {
        BoxList[1].Image.Dispose();
        BoxList[1].Image = Image.FromFile(@"..\..\Resources\home_1.png");
        b = false;
      }
      else if (b == false && box.Name == "box2")
      {
        BoxList[1].Image.Dispose();
        BoxList[1].Image = Image.FromFile(@"..\..\Resources\home-outline_1.png");
        b = true;
      }
      else if (b == true && box.Name == "box3")
      {
        BoxList[2].Image.Dispose();
        BoxList[2].Image = Image.FromFile(@"..\..\Resources\code-slash_1.png");
        b = false;
      }
      else
      {
        BoxList[2].Image.Dispose();
        BoxList[2].Image = Image.FromFile(@"..\..\Resources\code-slash-outline.png");
        b = true;
      }

    }
    [STAThread]
    private Image Setfile(char v, PictureBox item)
    {
      if (v == 'o')
        switch (item.Name)
        {
          case "box1": return Image.FromFile(@"..\..\Resources\settings-outline.png");
          case "box2": return Image.FromFile(@"..\..\Resources\home-outline_1.png"); ;
          case "box3": return Image.FromFile(@"..\..\Resources\code-slash-outline.png"); ;
          default: return null;
        }
      else
        switch (item.Name)
        {
          case "box1": return Image.FromFile(@"..\..\Resources\settings.png");
          case "box2": return Image.FromFile(@"..\..\Resources\home_1.png"); ;
          case "box3": return Image.FromFile(@"..\..\Resources\code-slash_1.png"); ;
          default: return null;
        }

    }
    [MTAThread]
    protected override void OnSizeChanged(EventArgs e)
    {
      base.OnSizeChanged(e);
      if (s == true)
      {
        BoxList[0].Location = new Point(this.Width - BoxList[0].Width - 30, this.Height - this.Height + BoxList[0].Height + 50);
        BoxList[1].Location = new Point(this.Width - BoxList[1].Width - 30, this.Height - this.Height + BoxList[1].Height + 50);
        BoxList[2].Location = new Point(this.Width - BoxList[2].Width - 30, this.Height - this.Height + BoxList[2].Height + 25);
      }
      s = true;
    }
  }
}
