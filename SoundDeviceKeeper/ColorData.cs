using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundDeviceKeeper
{
    struct ColorDataElement
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public ColorDataElement(string name, Color color)
        {
            Name = name;
            Color = color;
        }
    }

    struct ColorData
    {
        public static ColorDataElement PowerON => new ColorDataElement("ON", Color.YellowGreen);
        public static ColorDataElement PowerOFF => new ColorDataElement("OFF", Color.Red);
    }
}
