using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien1Behavior : MonoBehaviour
{
  Rigidbody2D rigidbody2D;
  public float speed = 0.05f;
  

  void Start()
  {
    // position me at the top of the screen 
    // position me at a random x position( random number between -9 and 9)
    float xPosition = Random.Range(-9.0f, 9.0f);
    this.transform.position = new Vector3(xPosition, 5f, 0f);

    rigidbody2D = GetComponent<Rigidbody2D>();
    rigidbody2D.velocity = -transform.up * speed;
  }

  void Update()
  {
    if (transform.position.y < -5)
    {
      Destroy(gameObject);
    }
  }
}
