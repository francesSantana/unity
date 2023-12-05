using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    int health = 8;
   

    int level = 2;


    float speed = 2;




    // Start is called before the first frame update
    void Start()
    {
        int paco = this.health + this.level;
      print ("la salud del jugador es:" + paco); 
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 newPosition = transform.position;

      newPosition.z += speed * Time.deltaTime;

      newPosition.x += speed * Time.deltaTime;

      transform.position  = newPosition;
    }
}
