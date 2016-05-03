using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IrisSkins;
using Sunisoft.IrisSkin;
namespace IrisSkins
{
    public class SkinsRepertories
    {
        public Dictionary<string, string> skins = new Dictionary<string, string>();
        public string strPath = AppDomain.CurrentDomain.BaseDirectory.Replace(@"OSMS_Emperor\bin\Debug\", @"IrisSkins\bin\Debug\Skins\");


        public bool InitSkins(SkinEngine skinEngine)
        {
            //skins.Add("普通", "office2007"); 
            skins.Add("浅蓝", "WaveColor2"); 
            skins.Add("祖母绿", "WaveColor1");
            skins.Add("深蓝", "wave");
            skinEngine.SkinFile = strPath + "" + skins["浅蓝"] + ".ssk";
            return true;
        }

        public bool ChangeSkins(SkinEngine skinEngine, string skinName)
        {
            skinEngine.SkinFile = strPath + "" + skinName + ".ssk";
            return true;
        }
    }
}
