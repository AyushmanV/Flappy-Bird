using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarOriginationAndMovement : MonoBehaviour
{

    private int count = 0;
    public GameObject pillar_prefab;
    public int rand;
    //public float dist = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //pillar_prefab.transform.Translate( -dist , 0 , 0);
        //pillar_prefab.velocity = new Vector2(-dist , 0);
        if(count == 240)
        {
            count = 0;
            rand = Random.Range(-2 , 4);
            Instantiate(pillar_prefab , new Vector2( 5 , rand) , Quaternion.identity);
            Destroy(pillar_prefab , 15);
        }
        else
        {
            count++;
        }
    }
}
