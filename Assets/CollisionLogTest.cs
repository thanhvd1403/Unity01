using UnityEngine;
using System.Collections;

public class CollisionLogTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // void OnCollisionEnter (Collision other)
    // {
    //     Debug.Log("Enter Collision");
    // }

    // void OnCollisionExit (Collision other)
    // {
    //     Debug.Log("Exit Collision");
    // }

    void OnTriggerEnter (Collider other)
    {
        // active question script here
        Debug.Log("Enter Trigger");
    }

    // void OnTriggerStay (Collider other)
    // {
    //     Debug.Log("Stay Trigger");
    // }

    // void OnTriggerExit (Collider other)
    // {
    //     Debug.Log("Exit Trigger");
    // }
}
