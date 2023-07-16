using Godot;
using System;

public partial class ProjectileA : RigidBody2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var animatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		string[] animTypes = animatedSprite2D.SpriteFrames.GetAnimationNames();
		animatedSprite2D.Play("active");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	private void _on_visible_on_screen_notifier_2d_screen_exited()
	{
		QueueFree();
		// Replace with function body.
	}
}
