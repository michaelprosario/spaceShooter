using System.Collections;
using UnityEngine;

public class Level1Sequencer : MonoBehaviour
{
  public GameObject alien1;
  public int waveNumber = 1;

  void Start()
  {
    // Execute wave of alien 1

    // Create 5 alien 1's
    
    //StartCoroutine(CreateAlien1Wave(10));
  }

  IEnumerator CreateAlien1Wave(int countOfEnemies)
  {
    waveNumber++;
    for (int i = 0; i < countOfEnemies; i++)
    {
      Instantiate(alien1, transform.position, Quaternion.identity);
      yield return new WaitForSeconds(1);
    }

    Debug.Log("Completed wave " + waveNumber);
    waveNumber++;
  }

  void Update()
  {
      switch(waveNumber) {
          case 1: 

            StartCoroutine(CreateAlien1Wave(10));
            break;
          case 2: 
            break;

          case 3: 
            StartCoroutine(CreateAlien1Wave(10));
            break;           
      }
  }
}
