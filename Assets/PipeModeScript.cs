using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeModeScript : MonoBehaviour
{
  public float moveSpeed = 5;
  public float deadZone = -30;
  public GameObject btmPipe;
  private bool btmPipeIsOpen = false;
  private bool btmPipeIsMoving = false;


  // Update is called once per frame
  void Update()
  {
    // * Time.deltaTime: ensure to multiplication happens the same, no matter of the frame rate
    transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    if (transform.position.x < deadZone)
    {
      Debug.Log("Pipe Deleted!");
      Destroy(gameObject);
    }

    if (btmPipeIsOpen)
    {
      // btmPipeIsMoving = true;
      Vector3 targetPosition = new Vector3(btmPipe.transform.position.x, btmPipe.transform.position.y - 21, btmPipe.transform.position.z);
      btmPipe.transform.position = Vector3.MoveTowards(btmPipe.transform.position, targetPosition, 10 * Time.deltaTime);
    }
  }

  public void openPipe()
  {
    btmPipeIsOpen = true;
    // Vector3 pos = btmPipe.transform.position;
    // pos.y = pos.y - 21;
    // btmPipe.transform.position = pos;

    // Vector3 targetPosition = new Vector3(btmPipe.transform.position.x, btmPipe.transform.position.y - 21, btmPipe.transform.position.z);
    // btmPipe.transform.position = Vector3.MoveTowards(btmPipe.transform.position, new Vector3(btmPipe.transform.position.x, btmPipe.transform.position.y - 21, btmPipe.transform.position.z), 2 * Time.deltaTime);
    // btmPipe.transform.position = new Vector3(btmPipe.transform.position.x, btmPipe.transform.position.y - 21,  btmPipe.transform.position.z);
  }
}
