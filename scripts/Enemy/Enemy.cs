using System.Collections.Generic;
using System;
using UnityEngine;

[DefaultExecutionOrder(-10)]
public partial class Enemy : MonoBehaviour
{

    public struct Pos
    {

        public float x;
        public float y;

    };
    public Pos ePos;

    public GameObject enemy1, enemy2, enemy3, enemy4;
    public enum EnemyType { red, cyan, pink, orange };
    public EnemyType color;
    public Rigidbody2D e_rb;
    public BoxCollider2D e_col;
    public Animator Enemyanim1, Enemyanim2, Enemyanim3, Enemyanim4;
    public Transform target, host;
    public float speed;
    public int eatenPt;
    public enum Status { Fine, Icpwi, Dead , in_Home};
    public Status st;

    public Enemy_statfanc Enemyfunc { get; private set; }
    public EnemyInHouse house { get; private set; }
    public Enemy_coljudge coljdg { get; private set; }
    public Rode_seach search { get; private set; }
    public EnemiesBeh initialBehavior;

    public LayerMask stlayer;

    private void Awake()
    {

        enemy1 = GameObject.Find("monster_atlas_0");
        enemy2 = GameObject.Find("monster_atlas_24");
        enemy3 = GameObject.Find("monster_atlas_15");
        enemy4 = GameObject.Find("monster_atlas_16");
        Enemyanim1 = GameObject.Find("monster_atlas_0").GetComponent<Animator>(); 
        Enemyanim2 = GameObject.Find("monster_atlas_24").GetComponent<Animator>(); 
        Enemyanim3 = GameObject.Find("monster_atlas_15").GetComponent<Animator>(); 
        Enemyanim4 = GameObject.Find("monster_atlas_16").GetComponent< Animator>(); 
        house = GetComponent<EnemyInHouse>();
        coljdg = GetComponent<Enemy_coljudge>();
        search = GetComponent<Rode_seach>();

    }

    private void Start()
    {
        ResetState();
    }

    public void ResetState()
    {

        enemy1.gameObject.SetActive(true);
        enemy2.gameObject.SetActive(true);
        enemy3.gameObject.SetActive(true);
        enemy4.gameObject.SetActive(true);

        Enemyfunc.emove.Disable();
        search.Disable();
        coljdg.Enable();

        if (house != initialBehavior)
        {
            house.Disable();
        }

        if (initialBehavior != null)
        {
            initialBehavior.Enable();
        }

        switch (color)
        {

            case EnemyType.red:

                Enemyanim1.SetInteger("action_e1", 3);

                break;


            case EnemyType.cyan:

                Enemyanim2.SetInteger("action_e2", 1);

                break;


            case EnemyType.orange:

                Enemyanim4.SetInteger("action_e4", 1);

                break;


            case EnemyType.pink:

                Enemyanim3.SetInteger("action_e3", 2);

                break;


        }

    }

    public void SetPosition(Vector3 position)
    {
        // Keep the z-position the same since it determines draw depth
        position.z = transform.position.z;
        transform.position = position;
    }


    private void Update()
    {
        
        switch(color)
        {

            case EnemyType.red:

                Enemyanim1.SetInteger("action_e1", 3);

            break;


            case EnemyType.cyan:

                Enemyanim2.SetInteger("action_e2", 1);

            break;


            case EnemyType.orange:

                Enemyanim4.SetInteger("action_e4", 1);

            break;


            case EnemyType.pink:

                Enemyanim3.SetInteger("action_e3", 2);

            break;


        }

    }

}
