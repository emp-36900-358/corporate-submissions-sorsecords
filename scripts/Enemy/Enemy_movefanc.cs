using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public partial class Enemy_movefanc : EnemiesBeh
{

    public Vector2 initialDirection;
    public LayerMask obstacleLayer;

    public Vector2 direction { get; private set; }
    public Vector2 nextDirection { get; private set; }
    public Vector3 startingPosition { get; private set; }

    Enemy monster;
    Rode_seach _Seach;

    public Enemy_movefanc(Enemy monster)
    {
        this.monster = monster;
    }

    public void SetPosition(Vector3 position)
    {
        // Keep the z-position the same since it determines draw depth
        position.z = transform.position.z;
        transform.position = position;
    }

    public void SetDirection(Vector2 direction, bool forced = false)
    {
        // Only set the direction if the tile in that direction is available
        // otherwise we set it as the next direction so it'll automatically be
        // set when it does become available
        if (forced || !Occupied(direction))
        {
            this.direction = direction;
            nextDirection = Vector2.zero;
        }
        else
        {
            nextDirection = direction;
        }
    }

    public bool Occupied(Vector2 direction)
    {
        // If no collider is hit then there is no obstacle in that direction
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, Vector2.one * 0.75f, 0f, direction, 1.5f, obstacleLayer);
        return hit.collider != null;
    }

    public void Move()
    {

        SetDirection(initialDirection);

        if (direction == Vector2.up)
        {
            monster.e_rb.velocity = new Vector2(0.0f, 2 * monster.speed);
        }
        else if (direction == Vector2.down)
        {
            monster.e_rb.velocity = new Vector2(0.0f, -2 * monster.speed);
        }
        else if (direction == Vector2.left)
        {
            monster.e_rb.velocity = new Vector2(-2 * monster.speed, 0.0f);
        }
        else if (direction == Vector2.right)
        {
            monster.e_rb.velocity = new Vector2(2 * monster.speed, 0.0f);
        }
        else
        {
            monster.e_rb.velocity = Vector2.zero;
        }
    }

    
}
