using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 10f;
    private Transform target;
    private int wavepointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        target = Waypoints.points[0];
    }   

    // Update is called once per frame
    void Update()
    {
        /*
        Move object to the waypoint
        */
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        
    }
}
