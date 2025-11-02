using Godot;
using System;

public partial class Kot : CharacterBody2D
{
    public const float Speed = 300.0f;

    public override void _PhysicsProcess(double delta)
    {
        Vector2 velocity = Velocity;
        float direction = Input.GetActionStrength("ui_right") - Input.GetActionStrength("ui_left");
        velocity.X = direction * Speed;
        velocity.Y = 0;
        Velocity = velocity;
        MoveAndSlide();
    }
}
