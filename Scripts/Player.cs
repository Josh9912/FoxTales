using Godot;

namespace FoxTales.Scripts
{
	public class Player : KinematicBody2D
	{
		public override void _PhysicsProcess(float delta)
		{
			GD.Print("Hello Godo!");
		}
	}
}
