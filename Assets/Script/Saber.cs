using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Hand
{
    Left,
    Right
}
public class Saber : MonoBehaviour
{
    [SerializeField] private Hand hand;
    // public LayerMask layer;
    // private Vector3 previousPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // RaycastHit hit;
        // if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        // {
        //     if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > 130)
        //     {
        //         Destroy(hit.transform.gameObject);
        //     }
        // }
        // previousPos = transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        if (hand == Hand.Left && other.gameObject.tag == "Blue")
        {
            other.GetComponent<Obstacle>()?.OnCOllide();
            Debug.Log("Blue Collided with LeftHand");
        }
        else if (hand == Hand.Right && other.gameObject.tag == "Red")
        {
            Debug.Log("Red Collided with RightHand");
            other.GetComponent<Obstacle>()?.OnCOllide();
        }
    }
}
