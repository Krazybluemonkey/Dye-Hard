using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ShaderLib;
using Terraria;

namespace DyeHard.Shaders
{
	public class DyeHardOriginalShader : ModArmorShaderData
	{
        public override bool Autoload() => false;

		private string _name;
		public override string Name => _name;

		public DyeHardOriginalShader() { }

        public DyeHardOriginalShader(string name, string passName, Effect shader)
		{
			_name = name;
			PassName = passName;
            Shader = shader;
            UseImage("Images/Misc/noise");
		}
        public DyeHardOriginalShader(string name, string passName, Effect shader, Vector3 p)
        {
            _name = name;
            PassName = passName;
            Shader = shader;
            UseImage("Images/Misc/noise");
            UseColor(p);
        }
        public DyeHardOriginalShader(string name, string passName, Effect shader, Vector3 p, Vector3 s)
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