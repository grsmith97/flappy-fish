using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
  [SerializeField]
  private float jumpForce = 300f;
  private Rigidbody2D rb;

  private void Awake()
  {
    rb = GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetButtonDown("Fire1"))
    {
      rb.velocity = Vector2.zero;
      GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce);
    }
  }
}
