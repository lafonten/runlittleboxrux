using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instaiterControler : MonoBehaviour
{

    public playerControler player;
    public GameObject block;
    public float height;
    public float width;
    public float time;

    private void Start()
    {
        StartCoroutine(spawnerObject(time));   
    }
    


    public IEnumerator spawnerObject(float time)
    {
        while (!player.isDead)
        {
            

            Instantiate(block, new Vector3(Random.Range(-width, width), height, 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
        
    }
    
    
}
