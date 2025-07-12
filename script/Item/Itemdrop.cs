using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static RandomChoise;

public class Itemdrop : MonoBehaviour
{

    public GameObject item1, item2, item3, item4, item5,
                      item6, item7, item8, item9, item10;
    public GameObject board;
    public float dropSpeed;

    int dropTrriger = 0000000000;
    //伸・縮・爆・磁・弾・回90・回-90・回180・反・叩

    Items item;
    DuplicationOnce random1;
    ItemAvirity aviritiies;

    private void Awake()
    {

        random1 = FindObjectOfType<DuplicationOnce>();

    }

    private void Start()
    {
        
        switch(bbmanager.nowlevel)
        {

            case 1:
            case 2:
            case 3:
            case 4:

                dropTrriger = 0000000000; 

           break;

           case 5:

               dropTrriger = 1111100000;

            break;

            case 6:

                dropTrriger = 1100011100;

            break;

            case 7:

                dropTrriger = 0001100011;

            break;

            default:

                dropTrriger = 1111111111;

            break;

        }


    }

    // Update is called once per frame
    void Update()
    {
        if(bbmanager.nowlevel > 4)
        {

            random1.GetRandomItem();

        }

        switch (item.item)
        {

            case Items.Item.strege:

                if(dropTrriger == 1000000000)
                {

                Instantiate(item1, transform.position, Quaternion.identity);

                    if (board.transform.position.y < 0)
                    {

                        item1.transform.Translate(0.0f, item1.transform.position.y * -dropSpeed, 0.0f);

                    }
                    else
                    {

                        item1.transform.Translate(0.0f, item1.transform.position.y * dropSpeed, 0.0f);


                    }

                }

            break;

            case Items.Item.shrinc:


                if(dropTrriger == 0100000000)
                {

                    Instantiate(item2, transform.position, Quaternion.identity);

                    if (board.transform.position.y < 0)
                    {

                        item2.transform.Translate(0.0f, item2.transform.position.y * -dropSpeed, 0.0f);

                    }
                    else
                    {

                        item2.transform.Translate(0.0f, item2.transform.position.y * dropSpeed, 0.0f);


                    }

                }

                break;

            case Items.Item.magnet:

                if (dropTrriger == 0010000000)
                {

                    Instantiate(item3, transform.position, Quaternion.identity);

                    if (board.transform.position.y < 0)
                    {

                        item3.transform.Translate(0.0f, item3.transform.position.y * -dropSpeed, 0.0f);

                    }
                    else
                    {

                        item2.transform.Translate(0.0f, item3.transform.position.y * dropSpeed, 0.0f); 


                    }

                }

                break;

            case Items.Item.bomb:

                if (dropTrriger == 0001000000)
                {

                    Instantiate(item4, transform.position, Quaternion.identity);

                    if (board.transform.position.y < 0)
                    {

                        item4.transform.Translate(0.0f, item4.transform.position.y * -dropSpeed, 0.0f);

                    }
                    else
                    {

                        item4.transform.Translate(0.0f, item4.transform.position.y * dropSpeed, 0.0f);


                    }

                }

                break;

            case Items.Item.misile:

                if (dropTrriger == 0000100000)
                {

                    Instantiate(item5, transform.position, Quaternion.identity);

                    if (board.transform.position.y < 0)
                    {

                        item5.transform.Translate(0.0f, item5.transform.position.y * -dropSpeed, 0.0f);

                    }
                    else
                    {

                        item5.transform.Translate(0.0f, item5.transform.position.y * dropSpeed, 0.0f);


                    }

                }

                break;

            case Items.Item.hammar:

                if (dropTrriger == 00000100000)
                {

                    Instantiate(item5, transform.position, Quaternion.identity);

                    if (board.transform.position.y < 0)
                    {

                        item6.transform.Translate(0.0f, item6.transform.position.y * -dropSpeed, 0.0f);

                    }
                    else
                    {

                        item6.transform.Translate(0.0f, item6.transform.position.y * dropSpeed, 0.0f);


                    }

                }

                break;

            case Items.Item.rotate90:

                if (dropTrriger == 0000001000)
                {

                    Instantiate(item6, transform.position, Quaternion.identity);

                    if (board.transform.position.y < 0)
                    {

                        item7.transform.Translate(0.0f, item4.transform.position.y - dropSpeed, 0.0f);

                    }
                    else
                    {

                        item7.transform.Translate(0.0f, item4.transform.position.y + dropSpeed, 0.0f);


                    }

                }

                break;

            case Items.Item.rotatem_90:

                if (dropTrriger == 00000000100)
                {

                    Instantiate(item8, transform.position, Quaternion.identity);

                    if (board.transform.position.y < 0)
                    {

                        item8.transform.Translate(0.0f, item8.transform.position.y - dropSpeed, 0.0f);

                    }
                    else
                    {

                        item8.transform.Translate(0.0f, item8.transform.position.y + dropSpeed, 0.0f);


                    }

                }

                break;

            case Items.Item.rotate180:

                if (dropTrriger == 00000000010)
                {

                    Instantiate(item9, transform.position, Quaternion.identity);

                    if (board.transform.position.y < 0)
                    {

                        item9.transform.Translate(0.0f, item9.transform.position.y - dropSpeed, 0.0f);

                    }
                    else
                    {

                        item9.transform.Translate(0.0f, item9.transform.position.y + dropSpeed, 0.0f);


                    }

                }

                break;

            case Items.Item.inversion:

                if (dropTrriger == 00000000001)
                {

                    Instantiate(item10, transform.position, Quaternion.identity);

                    if (board.transform.position.y < 0)
                    {

                        item10.transform.Translate(0.0f, item10.transform.position.y - dropSpeed, 0.0f);

                    }
                    else
                    {

                        item10.transform.Translate(0.0f, item10.transform.position.y + dropSpeed, 0.0f);


                    }

                }

                break;

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "board")
        {

            aviritiies.Avirity();
            Destroy(gameObject);

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "activearea")
        {

            Destroy(gameObject);

        }

    }

}
