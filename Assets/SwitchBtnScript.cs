using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBtnScript : MonoBehaviour
{
  public PipeModeScript pipeModeScript;
  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.layer == 6)
    {
      Debug.Log("Bullet hit the button!!");
      pipeModeScript.openPipe();
    }
  }
}
