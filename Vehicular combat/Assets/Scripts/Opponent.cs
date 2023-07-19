using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using WaypointsFree;

public class Opponent : MonoBehaviour
{
    public List<GameObject> waypoints;
    public float speed;
    int index = 0;
    public bool isLoop = true;

    private void Start()
    {


    }
    private void Update()
    {
        Vector3 Destination = waypoints[index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, Destination, speed * Time.deltaTime);
        transform.position = newPos;

        float distance = Vector3.Distance(transform.position, Destination);
        if(distance <= 0.05)
        {
            if(index < waypoints.Count - 1)
            {
                index++;
                transform.LookAt(new Vector3(waypoints[index].transform.position.x, waypoints[index].transform.position.y, waypoints[index].transform.position.z));
            }

            else
            {
                if (isLoop)
                {
                    index = 0;
                }
            }
        }
        
    }

}
