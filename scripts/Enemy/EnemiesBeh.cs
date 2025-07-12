using UnityEngine;

[RequireComponent(typeof(Enemy))]
public abstract class EnemiesBeh : MonoBehaviour
{
    public Enemy ghost { get; private set; }
    public float duration;

    private void Awake()
    {
        ghost = GetComponent<Enemy>();
    }

    public void Enable()
    {
        Enable(duration);
    }

    public virtual void Enable(float duration)
    {
        enabled = true;

        CancelInvoke();
        Invoke(nameof(Disable), duration);
    }

    public virtual void Disable()
    {
        enabled = false;

        CancelInvoke();
    }

}
