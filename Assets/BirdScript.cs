using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
  public Rigidbody2D myRigidBody;
  public GameObject bullet;
  public float flapStrength = 10;
  public LogicScript logic;
  public bool birdIsAlive = true;


  // Start is called before the first frame update
  void Start()
  {
    logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

  }

  // Update is called once per frame
  void Update()
  {
    if (birdIsAlive)
    {
      // flap wings
      if (Input.GetKeyDown(KeyCode.Space))
      {
        myRigidBody.velocity = Vector2.up * flapStrength;
      }

      // emit bullet
      if (Input.GetKeyDown(KeyCode.RightArrow))
      {
        Instantiate(bullet, new Vector3(transform.position.x + 4, transform.position.y, transform.position.z), transform.rotation);
      }

      if (transform.position.y < -17)
      {
        overGame();
      }
    }

  }
  private void OnCollisionEnter2D(Collision2D collision)
  {
    overGame();
  }

  private void overGame()
  {
    logic.gameOver();
    birdIsAlive = false;
    logic.gameIsOver = true;
  }
}
