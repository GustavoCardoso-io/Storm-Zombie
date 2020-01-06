using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnimigoAI : MonoBehaviour
{
    public GameObject player = null;
    public Transform goalPlayer =  null;
    float speed =  0.5f;
    float maxSpeed = 1.0f;
    float acceleration = 0.1f;
    float minSpeed = 0.2f;
    public float accuaracy =  2.8f;
    private void Start() {     
        player = GameObject.FindGameObjectWithTag("Player");
        goalPlayer =  player.GetComponent<Transform>();
    }
    // Update is called once per frame
    void LateUpdate()
    {
		  Vector3 lookAtGoal = goalPlayer.position;									
		  Vector3 direction = lookAtGoal - this.transform.position;
    
      if(direction.magnitude > accuaracy)
      {
	  	  speed =  Mathf.Clamp(speed + (acceleration * Time.deltaTime), minSpeed , maxSpeed);
		    this.transform.Translate(direction.x * speed  * Time.deltaTime ,direction.y * speed * Time.deltaTime,0);
      }
      //else
      //{
        // float positionRondomX = Random.Range(1.0f, 3.0f);
        //float positionRondomY = Random.Range(1.0f, 3.0f);

       // this.transform.Translate(positionRondomX * speed  * Time.deltaTime ,positionRondomY * speed * Time.deltaTime,0);
     // }
      if(direction.x >= 0 )
        {
         Vector3 temp = transform.localScale;
          temp.x = 4.0f;
         transform.localScale = temp;
        }else
        {
          Vector3 temp = transform.localScale;
          temp.x = -4.0f;
          transform.localScale = temp;
        }
    }
}
