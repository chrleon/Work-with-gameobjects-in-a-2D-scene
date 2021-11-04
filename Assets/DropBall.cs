using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBall : MonoBehaviour
{

  public GameObject prefab; // makes a picker in the Inspector to drag in a prefab
  Rigidbody2D rb;
  Vector2 coinPos, prevPos;
  // Start is called before the first frame update
  void Start()
  {

    rb = prefab.GetComponent<Rigidbody2D>();
    rb.mass = 0.0f;

  }

  // Update is called once per frame
  void Update()
  {
    if (rb.mass < 0.9)
    {
      rb.freezeRotation = true;
      coinPos = new Vector2(Mathf.Sin(Time.time) * 6, 4);
      transform.position = coinPos;
    }


    if (Input.GetButtonDown("Fire1"))
    {
      rb.mass = 1.0f;
      rb.freezeRotation = false;
      rb.velocity = rb.velocity / 10.0f;
      rb.angularVelocity = 0;
      print("pew pew");
    }
    if (Input.GetButtonDown("Fire2"))
    {
      rb.mass = 0.0f;
    }
  }
}
