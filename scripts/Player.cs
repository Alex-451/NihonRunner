using Godot;
using System;

public class Player : KinematicBody
{
	[Export]
	public float Speed = 7.0F;
	
	[Export]
	public float Gravity = 50.0F;
	
	private Vector3 _velocity = Vector3.Down;


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	public override void _PhysicsProcess(float delta)
	{
		MoveAndCollide(new Vector3(-1, 0, 0));
	}
}
