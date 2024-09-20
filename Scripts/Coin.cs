using Godot;
using System;

public partial class Coin : Area2D
{
    void OnBodyEntered(Node2D body) 
    {
        GD.Print("+1 Coin");
        QueueFree();
    }
}

