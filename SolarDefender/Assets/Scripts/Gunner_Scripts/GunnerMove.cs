using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunnerMove : MonoBehaviour
{

 //   private Rigidbody2D rb;
 //   private float jumpForce = 40f;
 //   private bool engineIsOn;

 //   public Button JetpackButton;

 //   [SerializeField]
 //   //private GameObject fire;
    
	//void Start ()
 //   {
 //       engineIsOn = false;
 //       //fire.SetActive(false);
 //       rb = GetComponent<Rigidbody2D>();
 //       JetpackButton = GetComponent<Button>();
 //   }
	
 //   //Input
	//void Update ()
 //   {
 //       CheckThursters();
 //   }

 //   //actions
 //   void FixedUpdate()
 //   {
 //       //CheckThursters();

 //       switch (engineIsOn)
 //       {
 //           case true:
 //               rb.addForce(new Vector2(0f, jumpForce), ForceMethod2D.Force);
 //               break;
 //           case false:
 //               rb.addForce(new Vector2(0f, 0f), ForceMethod2D.Force);
 //               break;
 //       }
 //   }

 //   void CheckThursters()
 //   {
 //       if (Input.GetButtonDown("JetpackButton"))
 //       {
 //           engineIsOn = true;
 //       }
 //       if (Input.GetButtonUp("JetpackButton"))
 //       {
 //           engineIsOn = false;
 //       }
 //   }

    //void ActivateThursters()
    //{
    //    rb.addForce(new Vector2(0f, jumpForce), ForceMethod2D.Force);
    //}

    //void DeactivateThursters()
    //{
    //    rb.addForce(new Vector2(0f, 0f), ForceMethod2D.Force);
    //}
}
