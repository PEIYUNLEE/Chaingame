using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchthingManager: MonoBehaviour {
    int[] TT = new int[] { 1, 1, 2, 2, 2, 3, 3, 4, 4, 4, 5, 5 ,5};
    public GameObject[] Prefabs;
    protected GameObject gameobject;
    public float startposY;   //the posy to generate the catchthing

    // Use this for initialization
    public float minposx,maxposx;
    private int rand;

   
    void Start () { 
       StartCoroutine(SpawCoroutine());
    }
	
    IEnumerator SpawCoroutine()
    {
        while (true)
        {
            rand = Random.Range(0, 12);
            switch(TT[rand])
            {
                case 1:
                    gameobject = Prefabs[0];
                    break;
                case 2:
                    gameobject = Prefabs[1];
                    break;
                case 3:
                    gameobject = Prefabs[2];
                    break;
                case 4:
                    gameobject = Prefabs[3];
                    break;
                case 5:
                    gameobject = Prefabs[4];
                    break;
            }
            Instantiate(gameobject,
                new Vector2(Random.Range(minposx, maxposx), startposY),
                Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
}
