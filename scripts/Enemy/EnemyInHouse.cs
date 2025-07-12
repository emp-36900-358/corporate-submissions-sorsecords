using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class EnemyInHouse : EnemiesBeh
{

    public Transform inside;
    public Transform outside;

    private void OnEnable()
    {
        StopAllCoroutines();
    }

    private void OnDisable()
    {
        // Check for active self to prevent error when object is destroyed
        if (gameObject.activeInHierarchy)
        {
            StartCoroutine(ExitTransition());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Reverse direction everytime the ghost hits a wall to create the
        // effect of the ghost bouncing around the home
        if (enabled && collision.gameObject.layer == LayerMask.NameToLayer("Obstacle"))
        {
            ghost.Enemyfunc.emove.SetDirection(ghost.Enemyfunc.emove.direction);
        }
    }

    private IEnumerator ExitTransition()
    {
        // Turn off movement while we manually animate the position
        ghost.Enemyfunc.emove.SetDirection(Vector2.up, true);
        ghost.e_rb.isKinematic = true;
        ghost.Enemyfunc.emove.enabled = false;

        Vector3 position = transform.position;

        float duration = 0.5f;
        float elapsed = 0f;

        // Animate to the starting point
        while (elapsed < duration)
        {
            ghost.Enemyfunc.emove.SetPosition(Vector3.Lerp(position, inside.position, elapsed / duration));
            elapsed += Time.deltaTime;
            yield return null;
        }

        elapsed = 0f;

        // Animate exiting the ghost home
        while (elapsed < duration)
        {
            ghost.Enemyfunc.emove.SetPosition(Vector3.Lerp(inside.position, outside.position, elapsed / duration));
            elapsed += Time.deltaTime;
            yield return null;
        }

        // Pick a random direction left or right and re-enable movement
        ghost.Enemyfunc.emove.SetDirection(new Vector2(Random.value < 0.5f ? -1f : 1f, 0f), true);
        ghost.e_rb.isKinematic = false;
        ghost.Enemyfunc.emove.enabled = true;
    }

}