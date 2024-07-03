using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuest
{
  public class package
  {
    protected readonly String __Path__ = @"..\..\Packages\";
    private string name;
    private String JSON;

    public package(String JsonString, string Name)
    {
      name = Name; 
      JSON = JsonString;
    }

    public void Send()
    {
      Task.Run(() => {
        var __currontPath__ = __Path__ + name + ".json";
        if (File.Exists(__currontPath__))
        {
          File.Delete(__currontPath__);
        }

        File.WriteAllText(__currontPath__, JSON);
      });
    }

    public async void SendAsync()
    {
      await Task.Run(() => {
        var __currontPath__ = __Path__ + name + ".json";
        if (File.Exists(__currontPath__))
        {
          File.Delete(__currontPath__);
        }

        File.WriteAllText(__currontPath__, JSON);
      });
    }
  }
}
