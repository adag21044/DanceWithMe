using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timing : MonoBehaviour
{
    public bool isHit;
    
    private Rigidbody rb;
    public float ballVerticalVelocity = 1.0f;
    public float barSpeed = 1000.0f;
    float step;
    public GameObject[] prefabs;
    private Collider spawnArea;
    public CapsuleCollider col;
    int x;
    
    void Awake()
    {
        spawnArea = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine("spawnArrow");
    }

    // Update is called once per frame
    void Update()
    {   
        
        
    }

    void FixedUpdate()
    {
        isHit = false;

    }

    void OnCollisionEnter(Collision col)
    {
        
    }

    IEnumerator spawnArrow()
    {
        
        while(1 == 1)
        {
            
        x = Random.Range(0,4);
        // move sprite towards the target location
        
        GameObject clone = Instantiate(prefabs[x], new Vector3(-2.78f, 0.0f,-3.65f), Quaternion.identity);
        // move sprite towards the target location
        
    
        yield return new WaitForSeconds(5.0f);
        Destroy(clone);
        }
        
       
    }

    
}
