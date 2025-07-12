using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAvirity : MonoBehaviour
{

    [SerializeField] Items item;

    GameObject padle;

    public GameObject Padle { get { return padle; } }

    public GameObject ball, bullet;

    ball1 myball;

    private void Start()
    {
        padle = GameObject.Find("board");
    }

    public void Avirity()
    {

        switch (item.item)
        {

            case Items.Item.strege:

                Padle.transform.localScale = new Vector3(1.5f, 0.25f, 0.0f);
  
           break;

            case Items.Item.shrinc:

                Padle.transform.localScale = new Vector3(0.5f, 0.25f, 0.0f);

            break;

            case Items.Item.magnet:

                StartCoroutine(EnableMagnet());
                if (Input.GetKeyDown(KeyCode.Space)) myball.injectionball();

            break;

            case Items.Item.bomb:

                DestroyBlocksInRange(myball.transform.position, item.item);

           break;

            case Items.Item.misile:

                if(Input.GetKeyDown(KeyCode.UpArrow))
                {

                    if(Padle.transform.position.y < 0)
                    {

                        Instantiate(bullet, Padle.transform.position, Quaternion.Euler(0.0f, 0.0f, -90.0f));

                    }
                    else 
                    {

                        Instantiate(bullet, Padle.transform.position, Quaternion.Euler(0.0f, 0.0f, 90.0f));

                    }

                }

            break;

            case Items.Item.hammar:

                DestroyBlocksInRange(myball.transform.position, 2);

            break;

            case Items.Item.rotate90:

                transform.rotation = Quaternion.Euler(90, 0, 0); //

            break;

            case Items.Item.rotatem_90:

                transform.rotation = Quaternion.Euler(-90, 0, 0); //
                                                                 //
            break;

            case Items.Item.rotate180:

                transform.rotation = Quaternion.Euler(180, 0, 0); //

            break;

            case Items.Item.inversion:

                if (Padle.transform.position.y < 0) Padle.transform.position = new Vector3(0.0f, 3.14f, 0.0f);
                else Padle.transform.position = new Vector3(0.0f, -3.14f, 0.0f);

            break;

        }

    }

    IEnumerator EnableMagnet()
    {
        // ボールを探す
        ball = GameObject.FindWithTag("Ball");

        if (ball != null)
        {
            Rigidbody2D ballRb = ball.GetComponent<Rigidbody2D>();

            if (ballRb != null)
            {
                // 物理演算を止める
                ballRb.velocity = Vector2.zero;
                ballRb.isKinematic = true;

                // ボールをパドルの上に固定
                while (item.item == Items.Item.magnet)
                {
                    ball.transform.position = Padle.transform.position + new Vector3(0, 0.3f, 0);
                    yield return null;
                }

                // 解除されたら発射
                ballRb.isKinematic = false;
                ballRb.velocity = new Vector2(0, 5); // 上向きに発射
            }
        }
    }

    void DestroyBlocksInRange(Vector2 centerPosition, Items.Item itemType)
    {
        // 消す範囲を決める（デフォルトは 3x3 の爆風範囲）
        int range = 0;

        switch (itemType)
        {
            case Items.Item.bomb:
                range = 1;  // 3×3 の範囲
                break;
            case Items.Item.misile:
                range = 0;  // 5×5 の範囲（より広い範囲）
                break;
            case Items.Item.hammar:
                range = 0;  // 3×3
                break;
            case Items.Item.rotate90:
                range = 0;
                break;
            case Items.Item.rotatem_90:
                range = 0;
                break;
            case Items.Item.rotate180:
                range = 0;
                break;
            case Items.Item.inversion:
                range = 0;
                break;
        }

        Collider2D[] hitBlocks = Physics2D.OverlapBoxAll(centerPosition, new Vector2(range * 1.0f, range * 1.0f), 0f);

        foreach (Collider2D hit in hitBlocks)
        {
            if (hit.CompareTag("block")) // ブロックのタグが "Block" の場合のみ削除
            {
                Destroy(hit.gameObject);
            }
        }
    }

    void DestroyBlocksInRange(Vector2 centerPosition, int range)
    {
        // 2×2の範囲を消す
        Collider2D[] hitBlocks = Physics2D.OverlapBoxAll(centerPosition, new Vector2(range, range), 0f);

        foreach (Collider2D hit in hitBlocks)
        {
            if (hit.CompareTag("block")) // ブロックのタグが "Block" の場合のみ削除
            {
                Destroy(hit.gameObject);
            }
        }
    }
}
