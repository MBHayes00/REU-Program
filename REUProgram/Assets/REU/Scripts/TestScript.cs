using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public float speed;
    public Vector3 myVec;
    public Quaternion myRot;
    public GameObject myFriend;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.Euler(0.5f, 0, 0);

        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation *= Quaternion.Euler(-10, 0, 0);
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
            transform.rotation *= Quaternion.Euler(10, 0, 0);
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.rotation *= Quaternion.Inverse(transform.rotation);
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            if(gameObject.name == "OriginalCube")
                transform.position = myFriend.transform.position + new Vector3(2, 0, 0);
        }

    }


    private void FixedUpdate()
    {

    }

    private void LateUpdate()
    {
        
    }
}
