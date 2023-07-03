using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNTScriptExperimental : MonoBehaviour
{
    public GameObject explosionZone;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Arrow")
        {
            Destroy(collision.gameObject);
            explosionZone.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
