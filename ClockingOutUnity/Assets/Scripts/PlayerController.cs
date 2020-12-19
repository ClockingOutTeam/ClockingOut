using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rgb;
    //movement floats
    public float speed = .1f; //speed of walking
    public float jumpStrength = 0.05f;
    public float rotationSpeed = 360;
    //positions lol Logan misheard me, this is if we finish the game earlier then I expect
    public float xPause;
    public float yPause;
    public float zPause;

    public Timer timer;
    //last minute hot fix trash variables
    public int count;
    public int maxJumpTime = 100;
    //input axes
    private string moveInputAxis = "Vertical"; //this one will only control moving the player
    private string rotateInputAxis = "Horizontal"; //this one will only control rotation.
    private string jumpInputAxis = "Jump";

    // Update is called once per frame
    void Update()
    {
        float moveAxis = Input.GetAxis(moveInputAxis);
        float rotateAxis = Input.GetAxis(rotateInputAxis); //getting references to the unity axes
        float jumpAxis = Input.GetAxis(jumpInputAxis);
        ApplyInput(moveAxis, rotateAxis, jumpAxis); //this will update our position pretty easily, need to add jump but I want this working before I rewrite Logan's script
    }

    private void ApplyInput(float moveInput, float turnInput, float jumpInput) //just creating methods for all of this so it is easier to read
    {
        Move(moveInput);
        Turn(turnInput);
        Jump(jumpInput);
    }

    //movement method
    private void Move(float input)
    {
        transform.Translate(Vector3.forward*input*speed);
    }

    //rotate the player
    private void Turn(float input) 
    {
        transform.Rotate(0, input * rotationSpeed * Time.deltaTime, 0);
    }
    //if you are reviewing the code I have written lets just skip over this mess.
    private void Jump(float input) 
    {
        if (input > 0)
        {
            if (count<maxJumpTime)
            {
                transform.Translate(Vector3.up * (input * jumpStrength));
                count++;
            }
        }else if (count >= maxJumpTime) 
        {
            count++;
            if(count <= maxJumpTime*3)
            {
                count = 0;
            }
        }
    }
    //instant death method
    private void OnCollisionEnter(Collision other)
    {  
        //death
        if (other.gameObject.tag == "Damage")
        {
            Debug.Log("Hit Me!!!");
            SceneManager.LoadScene("DeathScene");
        }
        //win
        if(other.gameObject.tag == "Win") //win will probably be changed later depending on game designers
        {
            Debug.Log("I won 0-0");
            SceneManager.LoadScene("WinScene");
        }
    }
}
