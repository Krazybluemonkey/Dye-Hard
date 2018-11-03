using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria;
using ShaderLib;

namespace DyeHard.Shaders
{
	public class DyeHardReflectiveShader : ModArmorShaderData
	{
		bool isRainbow = false;
		public override bool Autoload() => false;

		private string _name;
		public override string Name => _name;

		public DyeHardReflectiveShader() { }

		public DyeHardReflectiveShader(string name, string passName, bool rain)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			isRainbow = rain;
		}
		
		public DyeHardReflectiveShader(string name, string passName, float sat, bool rain)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			UseSaturation(sat);
			isRainbow = rain;
		}
		
		public DyeHardReflectiveShader(string name, string passName, Vector3 p, bool rain)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			UseColor(p);
			isRainbow = rain;
		}
		
		public DyeHardReflectiveShader(string name, string passName, Vector3 p, float sat, bool rain)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			UseColor(p);
			UseSaturation(sat);
			isRainbow = rain;
		}
		
		public override void PreApply(Entity e, DrawData? drawData)
		{
			if (isRainbow)
			{
				Vector3 f = new Vector3(((float)Main.DiscoR / 255) + 0.3f, ((float)Main.DiscoG / 255) + 0.3f, ((float)Main.DiscoB / 255) + 0.3f);
				UseColor(f);
			}
		}
		
		public override void Apply(Entity entity, DrawData? drawData)
		{
			if (entity == null)
			{
				base.Shader.Parameters["uLightSource"].SetValue(Vector3.Zero);
			}
			else
			{
				float rotation = 0f;
				if (drawData.HasValue)
				{
					rotation = drawData.Value.rotation;
				}
				Vector2 position = entity.position;
				float width = (float)entity.width;
				float height = (float)entity.height;
				Vector2 source = position + new Vector2(width, height) * 0.1f;
				width *= 0.8f;
				height *= 0.8f;
				Vector3 subLight = Lighting.GetSubLight(source + new Vector2(width * 0.5f, 0f));
				Vector3 subLight2 = Lighting.GetSubLight(source + new Vector2(0f, height * 0.5f));
				Vector3 subLight3 = Lighting.GetSubLight(source + new Vector2(width, height * 0.5f));
				Vector3 subLight4 = Lighting.GetSubLight(source + new Vector2(width * 0.5f, height));
				float vec4 = subLight.X + subLight.Y + subLight.Z;
				float vec2 = subLight2.X + subLight2.Y + subLight2.Z;
				float vec1 = subLight3.X + subLight3.Y + subLight3.Z;
				float vec3 = subLight4.X + subLight4.Y + subLight4.Z;
				Vector2 vector = new Vector2(vec1 - vec2, vec3 - vec4);
				float length = vector.Length();
				if (length > 1f)
				{
					length = 1f;
					vector /= length;
				}
				if (entity.direction == -1)
				{
					vector.X *= -1f;
				}
				vector = vector.RotatedBy((double)(-(double)rotation), default(Vector2));
				Vector3 value = new Vector3(vector, 1f - (vector.X * vector.X + vector.Y * vector.Y));
				value.X *= 2f;
				value.Y -= 0.15f;
				value.Y *= 2f;
				value.Normalize();
				value.Z *= 0.6f;
				base.Shader.Parameters["uLightSource"].SetValue(value);
			}
			base.Apply(entity, drawData);
		}
	}
}