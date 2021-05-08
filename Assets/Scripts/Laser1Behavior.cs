using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser1Behavior : MonoBehaviour
{
  Rigidbody2D rigidbody2D;
  float speed = 10;

  void Start()
  {
    rigidbody2D = GetComponent<Rigidbody2D>();
    rigidbody2D.velocity = transform.up * speed;
    StartCoroutine(SelfDestruct());
  }

  void Update()
  {

  }

  IEnumerator SelfDestruct()
  {
    yield return new WaitForSeconds(1f);
    Destroy(gameObject);
  }
}
