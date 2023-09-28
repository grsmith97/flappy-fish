using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;
    [SerializeField]
    private float randomOffset = 2f;
    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * Vector3.left * speed;
        if (transform.position.x <= -15) {
          float randomHeight = UnityEngine.Random.Range(-randomOffset, randomOffset);
          transform.position = new Vector3(10, randomHeight + 1f, transform.position.z);
        }
    }
}
