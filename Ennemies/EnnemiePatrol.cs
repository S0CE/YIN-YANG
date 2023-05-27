using UnityEngine;

public class EnnemiePatrol : MonoBehaviour
{

    public float speed;

    public Transform[] waypoints;

    private Transform target;
    private int destPoint = 0;

    void Start() {
        target = waypoints[0];
    }

    void Update() {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) < 0.3f) {
            destPoint = (destPoint + 1) % waypoints.Length;
            target = waypoints[destPoint];
        }
    }
}
