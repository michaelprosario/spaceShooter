using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{

  public float shipSpeed = 5;
  public GameObject laser1;
  Rigidbody2D rigidbody2D;
  float fireRate = 0.25f;
  float lastShot = 0.0f;

  void Start()
  {
    rigidbody2D = GetComponent<Rigidbody2D>();
  }

  void Update()
  {
    if (Input.GetKey(KeyCode.RightArrow))
    {
      rigidbody2D.velocity = transform.right * shipSpeed;
    }

    if (Input.GetKey(KeyCode.LeftArrow))
    {
      rigidbody2D.velocity = -transform.right * shipSpeed;
    }

    if (Input.GetKey(KeyCode.UpArrow))
    {
      rigidbody2D.velocity = transform.up * shipSpeed;
    }

    if (Input.GetKey(KeyCode.DownArrow))
    {
      rigidbody2D.velocity = -transform.up * shipSpeed;
    }

    if (this.transform.position.x < -10)
    {
      rigidbody2D.velocity = transform.right * shipSpeed;
    }

    if (this.transform.position.x > 10)
    {
      rigidbody2D.velocity = -transform.right * shipSpeed;
    }

    if (this.transform.position.y < -4)
    {
      rigidbody2D.velocity = transform.up * shipSpeed;
    }

    if (this.transform.position.y > 4)
    {
      rigidbody2D.velocity = -transform.up * shipSpeed;
    }

    if (Input.GetKey(KeyCode.Space))
    {
      if (Time.time > fireRate + lastShot)
      {
        Instantiate(laser1, transform.position, Quaternion.identity);
        lastShot = Time.time;
      }
    }

  }
}
