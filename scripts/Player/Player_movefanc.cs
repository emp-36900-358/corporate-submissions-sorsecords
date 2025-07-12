using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Player_movefanc
{

    public struct Direc
    {

        public enum Direction { none, up, down, left, right };
        public Direction direction;
        public int index;

    };

    public Direc direc;

    Player Pacman;

    public Player_movefanc(Player player)
    {

        Pacman = player;

    }


    public int DirecCheck()
    {

        int i = 0;

        if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {

            direc.index = 4;
            direc.direction = Direc.Direction.right;
            Pacman.Playeranim.SetInteger("Action", 4);
            i = direc.index;

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {

            direc.index = 3;
            direc.direction = Direc.Direction.left;
            Pacman.Playeranim.SetInteger("Action", 3);
            i = direc.index;

        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {

            direc.index = 1;
            direc.direction = Direc.Direction.up;
            Pacman.Playeranim.SetInteger("Action", 1);
            i = direc.index;


        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown((KeyCode.S)))
        {

            direc.index = 2;
            direc.direction = Direc.Direction.down;
            Pacman.Playeranim.SetInteger("Action", 2);
            i = direc.index;

        }

        DrawingRays();

        return i;

    }

    public void Move()
    {

        DirecCheck();
        if (Pacman != null && Pacman.p_rb != null)
        {

            switch (direc.direction)
            {
                case Direc.Direction.up:

                    Pacman.p_rb.velocity = new Vector2(0.0f, 2 * Pacman.speed);

                break;

                case Direc.Direction.down:

                    Pacman.p_rb.velocity = new Vector2(0.0f, -2 * Pacman.speed);

                break;

                case Direc.Direction.right:

                    Pacman.p_rb.velocity = new Vector2(2 * Pacman.speed, 0.0f);

                break;

                case Direc.Direction.left:

                    Pacman.p_rb.velocity = new Vector2(-2 * Pacman.speed, 0.0f);

                break;

            }

        }
        else
        {
            Debug.LogWarning("Player or its Rigidbody2D is not assigned.");
        }
    }

    public void DrawingRays()
    {

        Vector2 direction = Vector2.zero;


        switch (direc.direction)
        {

            case Direc.Direction.up:

                direction = Vector2.up;

            break;

            case Direc.Direction.down:

                direction = Vector2.down;

            break;

            case Direc.Direction.left:

                direction = Vector2.left;

            break;

            case Direc.Direction.right:

                direction = Vector2.right;

           break;

           case Direc.Direction.none:

                direction = Vector2.zero;

          break;

        }

        RaycastHit2D hit = Physics2D.Raycast(Pacman.transform.position, direction, 1.0f);

        // レイがオブジェクトにヒットした場合の処理
        if (hit.collider != null)
        {
            Debug.Log("Hit " + hit.collider.name);
        }

        // レイの可視化（デバッグ用）
        Debug.DrawRay(Pacman.transform.position, direction * 1.0f, Color.yellow);

    }

}
