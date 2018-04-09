using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (BoxCollider2D))]
public class RaycastCreator : MonoBehaviour {

    public int verticalRayCount = 3;
    private float verticalRaySpace;

    public bool isGrounded;
    public LayerMask collisionMask;
    BoxCollider2D collider;
    RaycastOrigins raycastOrigins;

    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        CalculateRaySpacing();
    }

    void Update()
    {
        UpdateRaycastOrigin();
    }

    public void checkGround()
    {
        for (int i = 0; i < verticalRayCount; i++)
        {
            Vector2 rayBegin = raycastOrigins.bottomLeft + Vector2.right * verticalRaySpace * i;
            RaycastHit2D hit = Physics2D.Raycast(rayBegin, Vector2.down, collider.bounds.extents.y, collisionMask);

            Debug.DrawRay(rayBegin, Vector2.up * -2, Color.cyan);

            if (hit)
            {
                isGrounded = true;
            }
            else
            {
                isGrounded = false;
            }
        }
    }

    public bool touchingFloor()
    {
        checkGround();
        return isGrounded;
    }

    void UpdateRaycastOrigin()
    {
        Bounds bounds = collider.bounds;

        raycastOrigins.bottomLeft = new Vector2(bounds.min.x, bounds.min.y);
        raycastOrigins.bottomRight = new Vector2(bounds.max.x, bounds.min.y);
    }

    void CalculateRaySpacing()
    {
        Bounds bounds = collider.bounds;
        verticalRaySpace = bounds.size.x / (verticalRayCount - 1);
    }

    struct RaycastOrigins
    {
        public Vector2 topLeft, topRight;
        public Vector2 bottomLeft, bottomRight;
    }
}
