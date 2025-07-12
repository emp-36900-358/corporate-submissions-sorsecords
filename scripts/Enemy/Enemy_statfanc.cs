using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Enemy_statfanc

{

    public Enemy_movefanc emove { get; private set; }
    Enemy monster;
    PmManager_otherfanc otherFunc;

    public Enemy_movefanc Move { get { return emove; } }
    public Enemy Ghosts { get { return monster; } }

    public Enemy_statfanc(Enemy enemy)
    {

        monster = enemy;
        emove = new Enemy_movefanc(monster);

    }


    public void FineStatMethod()
    {

        emove.Move();

    }

    public void DeadStatMethod()
    {

        otherFunc.EnemyEten(monster);

    }

    public void IcpwiStatMethod()
    {

        emove.Move();

    }

    public void inHomeStatMethod()
    {

        //switch()

        emove.Move();

    }

}
