using UnityEngine;

public class MovingObstacle2D : MonoBehaviour
{
    public float speed = 2f;        // Hur snabbt den rör sig
    public float moveDistance = 3f; // Hur långt den rör sig

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float movement = Mathf.Sin(Time.time * speed) * moveDistance;
        transform.position = startPosition + new Vector3(movement, 0, 0);
    }
}