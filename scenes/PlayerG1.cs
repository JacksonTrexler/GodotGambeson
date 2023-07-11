using Godot;
using System;

public partial class PlayerG1 : Area2D
{
	[Export]
	public int Speed {get; set;} = 100;
	
	public Vector2 ScreenSize;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		ScreenSize = GetViewportRect().Size;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
		
	}
	
	public override void _Input()
	{
		
	}
	
	public override void _PhysicsProcess(double delta)
	{
		//Velocity would be built in for applicable methods, but as I am not using the built in, I use lowercase and a node that does not have velocity built in
		var velocity = Vector2.Zero; //Player move vector
		
		//Old and broken way of moving
		/*
		if (Input.IsActionPressed("move_right"))
		{
			Velocity.X += 1;
			//set_real_velocity(get_velocity() + Vector2(1, 0));
		}
		if (Input.IsActionPressed("move_left"))
		{
			Velocity.X -= 1;
			//set_velocity(get_velocity() + Vector2(-1, 0));
		}
		if (Input.IsActionPressed("move_up"))
		{
			Velocity.Y -= 1;
			//set_velocity(get_velocity() + Vector2(-1, 0));
		}
		if (Input.IsActionPressed("move_down"))
		{
			Velocity.Y += 1;
			//set_velocity(get_velocity() + Vector2(1, 0));
		}
		*/
		
		//Get input
		Vector2 inputDir = Input.GetVector("move_left", "move_right", "move_up", "move_down");
		velocity = inputDir * Speed;
		
		var animatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		
		//Move player
		if(velocity.Length() > 0)
		{
			velocity = velocity.Normalized() * Speed;
			/*
			//set_velocity(get_velocity().Normalized() * Speed);
			//Position = Position + Velocity;
			//MoveAndSlide();
			*/
			
			Position += velocity * (float)delta;
			Position = new Vector2(x: Mathf.Clamp(Position.X, 0, ScreenSize.X),y: Mathf.Clamp(Position.Y, 0, ScreenSize.Y));
			animatedSprite2D.Play();
		}
		else
		{
			animatedSprite2D.Stop();
		}
	}
}
