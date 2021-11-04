using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBall : MonoBehaviour
{
    public GameObject prefab; // makes a picker in the Inspector to drag in a prefab
    Vector3 mousePos;
    Vector3 objectPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
        objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        objectPos.z = 0f;

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(prefab,objectPos,Quaternion.identity);
            Debug.Log(Input.mousePosition);
        }
    }
}
