using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ShaderLib;

namespace DyeHard.Shaders
{
	public class DyeHardShader : ModArmorShaderData
	{
		public override bool Autoload() => false;

		private string _name;
		public override string Name => _name;

		public DyeHardShader() { }

		public DyeHardShader(string name, string passName)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
		}

		public DyeHardShader(string name, string passName, Vector3 p)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			UseColor(p);
		}
		
		public DyeHardShader(string name, string passName, Vector3 p, float sat)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			UseColor(p);
			UseSaturation(sat);
		}
		
		public DyeHardShader(string name, string passName, Vector3 p, Vector3 s)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			UseColor(p);
			UseSecondaryColor(s);
		}
		
		public DyeHardShader(string name, string passName, Vector3 p, Vector3 s, float sat)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			UseColor(p);
			UseSecondaryColor(s);
			UseSaturation(sat);
		}
        public DyeHardShader(string name, string passName, Effect shader)
        {
            _name = name;
            PassName = passName;
            Shader = shader;
            UseImage("Images/Misc/noise");
        }
        public DyeHardShader(string name, string passName, Effect shader, Vector3 p)
        {
            _name = name;
            PassName = passName;
            Shader = shader;
            UseImage("Images/Misc/noise");
            UseColor(p);
        }
        public DyeHardShader(string name, string passName, Effect shader, Vector3 p, Vector3 s)
        {
            _name = name;
            PassName = passName;
            Shader = shader;
            UseImage("Images/Misc/noise");
            UseColor(p);
            UseSecondaryColor(s);
        }
    }
}