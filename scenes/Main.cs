using Godot;
using System;

public partial class Main : Node
{
	[Export]
	public PackedScene EnemyScene {get; set;}
	
	private int _score;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
