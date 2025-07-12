using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Enemy_coljudge : EnemiesBeh
{

    private void OnDisable()
    {
        ghost.search.Enable();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Seach_Node node = other.GetComponent<Seach_Node>();

        if (node != null )
        {
            // Pick a random available direction
            int index = Random.Range(0, node.availableDirections.Count);

            // Prefer not to go back the same direction so increment the index to
            // the next available direction
            if (node.availableDirections.Count > 1 && node.availableDirections[index] == -ghost.Enemyfunc.emove.direction)
            {
                index++;

                // Wrap the index back around if overflowed
                if (index >= node.availableDirections.Count)
                {
                    index = 0;
                }
            }

            ghost.Enemyfunc.emove.SetDirection(node.availableDirections[index]);
        }
    }
}