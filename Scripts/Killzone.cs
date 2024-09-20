using Godot;
using System;


public partial class Killzone : Area2D
{

    private void OnBodyEntered(Node2D body) 
    {
        Timer timer = this.GetNode<Timer>("KillTimer");
        timer.Start();
        timer.Timeout += on_timeout;
    }

    void on_timeout()
    {
        GetTree().ReloadCurrentScene();
    }
}
