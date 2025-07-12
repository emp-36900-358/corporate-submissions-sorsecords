using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Player_statfanc
{

    private readonly Player_movefanc move;
    private readonly PmManager_otherfanc mng_of;
    private readonly Player Pacman;

    public Player_movefanc Move { get { return move; } }

    public Player_statfanc(Player player)
    {

        Pacman = player;
        move = new Player_movefanc(player);
        mng_of = GameObject.Find("Main Camera").GetComponent<PmManager_otherfanc>();
        if (mng_of == null)
        {
            Debug.LogError("PmManager_otherfanc が Main Camera にアタッチされていません。");
        }
    }
    
    public void FineStatMethod()
    {

        move.Move();
    
    }

    public void DeadStatMethod()
    {

        mng_of.PlayerEten();

    }

    public void RespawnStatMethod()
    {

        //Pacman.Playeranim.SetInteger("Action", 5);
        mng_of.PlayerEten();
        Debug.Log("PlayerEten()が呼び出されました。");

    }


}