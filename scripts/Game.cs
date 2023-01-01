using Godot;
using System;

public class Game : Spatial
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	private readonly PackedScene _streetFragment = (PackedScene)GD.Load("res://scenes/StreetFragment.tscn");

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

		float xCord = 12.596F;
		for (int i = 0; i < 15; i++)
		{
			xCord -= 12.596F;
			var streetFragment = (Spatial)_streetFragment.Instance();
			streetFragment.Name = i.ToString();
			streetFragment.Translation = new Vector3(xCord, 0, 0);

			AddChild(streetFragment);
		}


	}

	//  // Called every frame. 'delta' is the elapsed time since the previous frame.
	//  public override void _Process(float delta)
	//  {
	//      
	//  }
}
