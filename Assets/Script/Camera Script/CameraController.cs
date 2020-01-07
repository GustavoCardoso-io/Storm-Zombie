using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player = null;

    public Vector3 velocity = Vector3.zero;

    float dampTime = 0.15f;
     
    public Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = player.transform.position - this.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        //this.transform.position = new Vector3(player.transform.position.x + offset.x, player.transform.position.y + offset.y, this.transform.position.z);
        Vector3 destination = new Vector3(player.transform.position.x, player.transform.position.y, this.transform.position.z);
        this.transform.position =  Vector3.SmoothDamp(this.transform.position, destination, ref velocity, dampTime);
    }
}
