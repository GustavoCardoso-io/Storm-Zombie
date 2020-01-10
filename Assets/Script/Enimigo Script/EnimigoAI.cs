using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class EnimigoAI : MonoBehaviour
{
    public AIPath aIPath;
    private void Start()
    {
        aIPath = this.GetComponent<AIPath>();
    }
    // Update is called once per frame
    void Update()
    {
        if (aIPath.desiredVelocity.x >= 0.1f)
        {
            this.transform.localScale = new Vector3(4f, 4f, 1f);
        }
        else if (aIPath.desiredVelocity.x <= -0.1f)
        {
            this.transform.localScale = new Vector3(-4f, 4f, 1f);
        }
    }
}
