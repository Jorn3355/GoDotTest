using Godot;
using System;

public partial class Coin : Area2D
{
	private void _on_body_entered(Godot.Area2D body) 
	{
		GD.Print("+1 Coin!");
	}
}
