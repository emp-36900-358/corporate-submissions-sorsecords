using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boardmovement : MonoBehaviour
{

    private Rigidbody2D boardrigidbody;
    public float boardspeed;
    public GameObject tcollider, bcollider;

    // Start is called before the first frame update
    void Start()
    {

        boardrigidbody = this.gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        wallActive();
        Vector2 boardforce = Vector2.zero;

        if (Input.GetKey(KeyCode.RightArrow))
        {

            boardforce = new Vector2(boardspeed, 0.0f);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            boardforce = new Vector2(-boardspeed, 0.0f);

        }

        boardrigidbody.MovePosition(boardrigidbody.position + boardforce * Time.fixedDeltaTime);

    }

    public void wallActive()
    {

        Vector3 boardpos = this.transform.position;

        if(boardpos.y < 0)
        {

            bcollider.SetActive(false);

        }

        if (boardpos.y > 0)
        {

            tcollider.SetActive(false);

        }

    }

}