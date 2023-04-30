using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchFood : MonoBehaviour
{
    public GameObject tray;
    public GameObject player;
    private float headOffset = 4.3f;
    Rigidbody rb;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == ("Player"))
        {
            Debug.Log(player);
            tray.transform.parent = (obj.gameObject.transform);
            tray.transform.localPosition = player.transform.position + Vector3.up * headOffset;
            rb.isKinematic = true;
            Debug.Log("Food caught");
        }
    }

}
