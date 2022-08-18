using Godot;

namespace FoxTales.Scripts
{
	public class World : Node2D
	{
		/// <summary>
		/// Called when the node enters the scene tree for the first time. 
		/// </summary>
		public override void _Ready()
		{
			GD.Print("Test");
		}

		/// <summary>
		/// Called every frame
		/// </summary>
		/// <param name="delta"> is the elapsed time since the previous frame</param>
		public override void _Process(float delta)
		{

		}
	}
}
