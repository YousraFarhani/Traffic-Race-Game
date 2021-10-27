using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float[] spawningPos;
    public int randomIndex;
    public float zposition;
    public Transform[] car;
    public int lastindex = -1;
    // Start is called before the first frame update
    void Start()
    {
        chooseposition();
        chooseposition();
        chooseposition();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void chooseposition()
    {
      randomIndex = Random.Range(0,5);
      if(lastindex == randomIndex)
      {
        chooseposition();
      }
      else
      {
      zposition = spawningPos[randomIndex];
      lastindex = randomIndex;
      spawn();
      }
    }

    public void spawn()
   {
      Instantiate(car[Random.Range(0,5)], new Vector3(14, 3, zposition), Quaternion.Euler(0,180,0));
   }
}
