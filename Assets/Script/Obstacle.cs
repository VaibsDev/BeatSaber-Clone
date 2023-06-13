using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float minSpeed = 1f;
    [SerializeField] private float maxSpeed = 3f;
    [SerializeField] private ParticleSystem particle;
    public float delay = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
    }
    void MoveForward()
    {
        transform.position += Time.deltaTime * transform.forward * speed;
    }
    public void OnCOllide()
    {
        Debug.Log("Cube !!!");
        particle.Play();
        foreach (Transform child in transform)
        {
            MeshRenderer mesh = child.GetComponent<MeshRenderer>();
            if (mesh != null)
                mesh.enabled = false;
        }
        StartCoroutine(DestroyObject());
    }
    private IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }
}
