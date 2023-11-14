using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
  public float speed = 4;

  // Update is called once per frame
  void Update()
  {
    transform.position = transform.position + (Vector3.right * speed) * Time.deltaTime;
    if (transform.position.x > 27)
    {
      Destroy(gameObject);
    }
  }

  // 碰撞的发生必须两个都是rigidBody
  private void OnCollisionEnter2D(Collision2D collision)
  {
    Destroy(gameObject);
  }
}
