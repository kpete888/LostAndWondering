using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public float playerSpeed = 2.0f;
    public bool didBumpIntoCube = false;

    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3; 

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed);
	}

    void OnTriggerEnter(Collider col)
    {
        didBumpIntoCube = true; 

        if (didBumpIntoCube)
        {
            Light1.SetActive(true);
            Light2.SetActive(true);
            Light3.SetActive(true);
        }
            
    }
}
