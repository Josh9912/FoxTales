using Godot;

namespace FoxTales.Scripts
{
	public class Player : KinematicBody2D
	{
		[Export]
		public int Speed = 100;

		public Vector2 Velocity;

		private const int Acceleration = 10;

		public void GetInput()
		{
			Velocity = new Vector2();

			if (Input.IsActionPressed("ui_right"))
				Velocity.x += 1;
			
			if (Input.IsActionPressed("ui_left"))
				Velocity.x -= 1;
			
			if (Input.IsActionPressed("ui_down"))
				Velocity.y += 1;
			
			if (Input.IsActionPressed("ui_up"))
				Velocity.y -= 1;

			Velocity = Velocity.Normalized() * Speed;
		}
		
		public override void _PhysicsProcess(float delta)
		{
			GetInput();
			Velocity = MoveAndSlide(Velocity * delta * Acceleration);
		}
	}
}
