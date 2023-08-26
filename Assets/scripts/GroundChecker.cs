using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    private Movement movement;
    private Collider2D playerCollider;
    private LayerMask groundLayer;
    [Header("Debug")]
    [SerializeField] private bool DebugGizmo;
    private void Awake()
    {
        playerCollider = GetComponent<Collider2D>();
        groundLayer = LayerMask.GetMask("Ground");
        movement = GetComponent<Movement>();
        playerCollider = GetComponent<Collider2D>();
    }
    private void FixedUpdate()
    {
        Vector2 boxSize = new Vector2(playerCollider.bounds.size.x, playerCollider.bounds.size.y);
        bool Result = Physics2D.OverlapBox(transform.position, boxSize, 0, groundLayer);
        movement.GroundCheck(Result);
    }
    private void OnDrawGizmos()
    {
        Vector2 boxSize = new Vector2(playerCollider.bounds.size.x, playerCollider.bounds.size.y);

        Gizmos.color = Color.red;
        if (DebugGizmo)Gizmos.DrawWireCube(transform.position, boxSize);
    }

}

