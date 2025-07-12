using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball1 : MonoBehaviour
{

    private Rigidbody2D ballrisidbody;
    public float vec_x, vec_y;
    public float ballspeed;
    public enum Status {Fine, Damaged, Dead ,Clear, Restart};
    Status bSt;
    instanceblocks.Status blSt;

    // Start is called before the first frame update
    void Start()
    {

        ballrisidbody = GetComponent<Rigidbody2D>();
        injectionball();

    }

    void FixedUpdate()
    {

        // ���t���[�����x�����ɕۂ�
        ballrisidbody.velocity = ballrisidbody.velocity.normalized * ballspeed;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("blocks"))
        {

            bbmanager bbmng = GameObject.Find("Main Camera").GetComponent<bbmanager>();

            if (bbmng != null) // bbmng �� null �łȂ����Ƃ��m�F
            {


                bbmng.Subblocklife(bbmanager.blocklife);

                block _block = collision.gameObject.GetComponent<block>();

                // �u���b�N���Ƃ̏����𕪊� 
                switch (_block.blockType)
                {

                    case block.BlockType.red:
                    case block.BlockType.blue:
                    case block.BlockType.green:
                    case block.BlockType.yellow:
                    case block.BlockType.purple:

                        bbmng.Addscore(100);

                        break;

                    case block.BlockType.barrier:

                        if (bbmanager.blocklife > 0)
                        {

                            bbmng.SetblockStatus(instanceblocks.Status.Damaged);

                        }

                        else
                        {

                            bbmng.Addscore(300);

                        }

                        break;

                    default:
                        break;

                }

                bbmng.Subblocklife(bbmanager.blocklife);
                Debug.Log("����{�[���𓖂Ă���u���b�N������H:" + bbmanager.blocklife);

                // �u���b�N�̔j��ƃC���X�^���X���̍X�V
                if (instanceblocks.instancecnt > 0)
                {

                    if (bbmanager.blocklife <= 0)
                    {

                        bbmng.OnBlockDestroyed();
                        Destroy(collision.gameObject);

                    }

                }

                bbmng.SetblockStatus(instanceblocks.Status.Dead);

                // �C���X�^���X����0�ȉ��̏ꍇ�A�{�[���̃X�e�[�^�X���N���A�ɕύX
                if (instanceblocks.instancecnt <= 0)
                {

                    bbmng.SetballStatus(Status.Clear);
                    Destroy(gameObject);

                }

            }

            else
            {

                Debug.LogError("bbmanager is not found!");

            }

        }

        if (collision.gameObject.CompareTag("wall"))
        {
            Vector2 normal = collision.contacts[0].normal;
            ballrisidbody.velocity = Vector2.Reflect(ballrisidbody.velocity, normal);

            // ���ˊp�������_���Ŕ�����
            float angleOffset = Random.Range(-5f, 5f);
            ballrisidbody.velocity = Quaternion.Euler(0, 0, angleOffset) * ballrisidbody.velocity;
        }

        // ���ˌv�Z
        Vector2 n = collision.contacts[0].normal;
        ballrisidbody.velocity = Vector2.Reflect(ballrisidbody.velocity, n);

        // ���������ɒ���
        ballrisidbody.velocity = ballrisidbody.velocity.normalized * ballspeed;

    }

    private void OnTriggerExit2D(Collider2D col)
    {

        if (col.gameObject.tag�@==�@"activearea")
        {

            bbmanager bbmng = GameObject.Find("Main Camera").GetComponent<bbmanager>();

            bbmng.Sublife(1);

            int life = bbmanager.nowlife;

            if (life < 1000 && life > 0)
            {

                bbmng.SetballStatus(Status.Damaged);
                Debug.Log(bSt);

            }
            else if (life <= 0)
            {
                bbmng.SetballStatus(Status.Dead);
            }

            Destroy(gameObject);
            
        }

    }

    public void injectionball()
    {

        ballrisidbody = this.gameObject.GetComponent<Rigidbody2D>();
        Vector2 ballforce = new Vector2(vec_x, vec_y);
        ballrisidbody.AddForce(ballforce); 

    }


}