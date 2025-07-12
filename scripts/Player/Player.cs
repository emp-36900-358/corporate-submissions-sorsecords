using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Player_movefanc;

public partial class Player : MonoBehaviour
{

    public struct Pos
    {

        public float x;
        public float y;

    };
    public Pos pPos;

    public GameObject player;
    public Rigidbody2D p_rb;
    public Animator Playeranim;
    public CircleCollider2D playerCol;
    public float speed;
    public Vector3 respawnPos;

    Player_statfanc Playerfunc;
    Enemy[] enemyes;
    //Player_movefanc move;
    PmManager_otherfanc ohter;
    PmManager PmManager;

    public enum Status { Fine, Dead, respawn };
    public Status st;

    public Player_statfanc Statf { get { return Playerfunc; } }

    private void Awake()
    {
        enemyes = FindObjectsOfType<Enemy>();
        if (enemyes == null || enemyes.Length == 0)
        {
            Debug.LogError("エラー: シーン内に敵が存在しません！");
        }

        Playerfunc = new Player_statfanc(this);
        ohter = FindObjectOfType<PmManager_otherfanc>();
        if (ohter == null)
        {
            Debug.LogError("エラー: PmManager_otherfanc が見つかりません！");
        }

        Playeranim = GetComponent<Animator>();
        if (Playeranim == null)
        {
            Debug.LogError("エラー: Animator コンポーネントが見つかりません！");
        }

        playerCol = GetComponent<CircleCollider2D>();
        p_rb = GetComponent<Rigidbody2D>();

        PmManager = FindObjectOfType<PmManager>();
        if (PmManager == null)
        {
            Debug.LogError("エラー: PmManager がシーン内に見つかりません！");
        }
    }

    private void Start()
    {

        pPos.x = 0.039f;
        pPos.y = -2.35f;
        respawnPos = new Vector3(pPos.x, pPos.y, 0.0f); // プレイヤーの開始位置を設定
        transform.position = respawnPos;
        st = Status.Fine;
        this.enabled = true;

    }

    private void Update()
    {

        switch (st)
        {

            case Status.Fine:

                Playerfunc.FineStatMethod();

                break;

            case Status.Dead:

                if (!ohter.Mmg_mode.Mng.overflg && Input.anyKeyDown)
                {

                        transform.position = respawnPos;
                        Playeranim.SetInteger("Action", 0);
                        p_rb.velocity = Vector2.zero;
                        Playerfunc.Move.direc.direction = Direc.Direction.none;
                        Playerfunc.Move.direc.index = 0;
                        SetPlayerStatus(Status.Fine);
                        ohter.SetLife(3);

                }

                Debug.Log(st);

                break;

            case Status.respawn:

                Playerfunc.RespawnStatMethod();
                if(PmManager.life > 0)
                {

                    transform.position = respawnPos;
                    Playeranim.SetInteger("Action", 0);
                    p_rb.velocity = Vector2.zero;
                    Playerfunc.Move.direc.direction = Direc.Direction.none;
                    Playerfunc.Move.direc.index = 0;
                    SetPlayerStatus(Status.Fine);
                    ohter.SetLife(PmManager.life);

                }

            break;

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("enemy"))
        {
            Enemy hitEnemy = collision.gameObject.GetComponent<Enemy>();
            if (hitEnemy == null)
            {
                Debug.LogError("エラー: 衝突したオブジェクトが Enemy ではありません");
                return;
            }

            switch (hitEnemy.st)
            {
                case Enemy.Status.Fine:
                    Playeranim.SetInteger("Action", 5);

                    if (PmManager != null && PmManager.life > 0)
                    {
                        Playerfunc.RespawnStatMethod();
                        SetPlayerStatus(Status.respawn);
                        ohter.SetLife(PmManager.life - 1); // 残機を減らしすぎない
                    }
                    else
                    {
                        SetPlayerStatus(Status.Dead);
                        Playerfunc.DeadStatMethod();
                    }
                    break;

                case Enemy.Status.Icpwi:
                    if (ohter != null)
                    {
                        ohter.EnemyEten(hitEnemy);
                    }
                    else
                    {
                        Debug.LogError("エラー: ohter (PmManager_otherfanc) が null です");
                    }
                    break;

                case Enemy.Status.Dead:
                    hitEnemy.e_col.enabled = false;
                    break;
            }
        }

        if (collision.gameObject.layer == LayerMask.NameToLayer("Wall"))
        {
            p_rb.velocity = Vector2.zero;
            Playeranim.SetInteger("Action", 0);
        }
    }


    public void SetPlayerStatus(Status newst)
    {

        st = newst;

    }

    public void ResetStates()
    {

        player.SetActive(true);

    }

}