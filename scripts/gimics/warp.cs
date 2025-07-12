using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warp : MonoBehaviour
{

    public GameObject pacman;
    public GameObject ghost1, ghost2, ghost3, ghost4;

    private void OnTriggerExit2D(Collider2D warpcol)
    {
        if (warpcol.gameObject.layer == LayerMask.NameToLayer("enemy") || warpcol.gameObject.layer == LayerMask.NameToLayer("PacMan"))
        {

            if(pacman.transform.position.x > 3.634f || ghost1.transform.position.x > 3.634f || ghost2.transform.position.x > 3.634f || ghost3.transform.position.x > 3.634f || ghost4.transform.position.x > 3.634f)
            {

                pacman.transform.position = new Vector3(-3.634f, pacman.transform.position.y, pacman.transform.position.z); 
                ghost1.transform.position = new Vector3(-3.634f,  ghost1.transform.position.y, ghost1.transform.position.z);
                ghost2.transform.position = new Vector3(-3.634f,  ghost2.transform.position.y, ghost2.transform.position.z);
                ghost3.transform.position = new Vector3(-3.634f,  ghost3.transform.position.y, ghost3.transform.position.z);
                ghost4.transform.position = new Vector3(-3.634f,  ghost4.transform.position.y, ghost4.transform.position.z);

            }

            else if (pacman.transform.position.x < -3.634f || ghost1.transform.position.x < -3.634f || ghost2.transform.position.x < -3.634f || ghost3.transform.position.x < -3.634f || ghost4.transform.position.x < -3.634f)
            {

                pacman.transform.position = new Vector3(3.634f, pacman.transform.position.y, pacman.transform.position.z); 
                ghost1.transform.position = new Vector3(3.634f, ghost1.transform.position.y, ghost1.transform.position.z);
                ghost2.transform.position = new Vector3(3.634f, ghost2.transform.position.y, ghost2.transform.position.z);
                ghost3.transform.position = new Vector3(3.634f, ghost3.transform.position.y, ghost3.transform.position.z);
                ghost4.transform.position = new Vector3(3.634f, ghost4.transform.position.y, ghost4.transform.position.z);

            }


        }

    }
    

}