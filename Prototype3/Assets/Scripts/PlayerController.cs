/*
* (Jerod Lockhart)
* (Prototype 3)
* (File plays sound effects and makes the player move)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator playerAnimator;
    private Rigidbody rb;
    public float jumpForce;
    public ForceMode forceMode;
    public ForceMode JumpForceMode;


    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;

    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;
    public AudioClip crashSound;

    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        //Set reference Variable sto components
        rb = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();

        //Modify gravity
        //Physics.gravity *= gravityModifier;

        //,modify if not over 10
        if(Physics.gravity.y > -10)
        {
            Physics.gravity *= gravityModifier;
        }
        //start running
        playerAnimator.SetFloat("Speed_f", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            //set set Space to play jump
            rb.AddForce(Vector3.up * jumpForce, forceMode );
            isOnGround = false;

            //Set trigger for jump anim.
            playerAnimator.SetTrigger("Jump_trig");

            //stop dirt
            dirtParticle.Stop();

            //play jump sound
            playerAudio.PlayOneShot(jumpSound, 1.0f);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground") && !gameOver)
        {
            isOnGround = true;

            //play dirt
            dirtParticle.Play();
        }
        else if(collision.gameObject.CompareTag("Obstacle") && !gameOver)
        {
            Debug.Log("Game over");
            gameOver = true;

            //play death animation
            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", 1);

            //play explosion
            explosionParticle.Play();
            //play crash
            playerAudio.PlayOneShot(crashSound, 1.0f);
            //Stop playing dirty
            dirtParticle.Stop();    
        }
    }

    public void StopRunning()
    {
        playerAnimator.SetFloat("Speed_f", 0);
    }
}
