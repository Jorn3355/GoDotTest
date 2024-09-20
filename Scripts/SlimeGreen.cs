using Godot;
using System;
using System.Security.Cryptography.X509Certificates;

public partial class SlimeGreen : Node2D
{
	float direction = 1;
	float slimeSpeed = 30;
    public override void _Process(double delta)
	{
		RayCast2D rayRight = this.GetNode<RayCast2D>("RayRight");
		RayCast2D rayLeft = this.GetNode<RayCast2D>("RayLeft");
		if(rayRight.IsColliding())
		{
			direction = -1;
		}
		if(rayLeft.IsColliding())
		{
			direction = 1;
		}
		float currentVelo = direction*slimeSpeed*(float)delta;		
		this.Position += new Vector2(currentVelo, 0);
	}
}
