using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Distance between the camera and the player
    public float distanceAway = 5f;
    //Camera with player's height
    public float distanceUp = 1.3f;
    // how smooth the camera movement is
    public float smooth = 2f;
    //follow target
    private Transform player;
    //private Vector3 offset = new Vector3(0, 5f, 0);
    private Vector3 TargetPosition;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        TargetPosition = player.position + Vector3.up * distanceUp - player.forward * distanceAway;

        transform.position = Vector3.Lerp(transform.position, TargetPosition, Time.deltaTime * smooth);

        transform.LookAt(player);
    }
}
