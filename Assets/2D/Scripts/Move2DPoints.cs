using UnityEngine;

public class Move2DPoints : MonoBehaviour
{
    public Transform[] points;
    public float moveSpeed = 20;
    public int firstMoveToPoint = 0;
    
    private int moveActivePoint = 0;

    private void Start()
    {
        if (moveActivePoint != firstMoveToPoint) moveActivePoint = firstMoveToPoint;
    }

    private void Update()
    {
        Vector3 direction =  points[moveActivePoint].position - transform.position;
        float distanceToTarget = direction.magnitude;
        if (distanceToTarget < 0.1f)
        {
            moveActivePoint++;
            if (moveActivePoint == points.Length) moveActivePoint = 0;
        }
        else
        {
            transform.position += direction.normalized * (Time.deltaTime * moveSpeed);   
        }
    }
}
