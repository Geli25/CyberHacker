using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerscript : MonoBehaviour
{
    public float movementSpeed;
    public GameObject particle;
    public static int Playerhealth;
    AudioSource damageSound;
    bool stagecleared;
    bool morecoming;

    void Start()
    {
        Playerhealth = 30;
        damageSound = GetComponent<AudioSource>();
    }


    void Update()
    {
        CharacterController playerMove = GetComponent<CharacterController>();
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        movement = transform.TransformDirection(movement * Time.deltaTime);
        movement.Normalize();
        movement = movement.normalized * movementSpeed;

        playerMove.Move(movement);

        if (playerMove.velocity == Vector3.zero)
        {
            particle.SetActive(false);
        }
        else
        {
            particle.SetActive(true);
        }

        if (this.transform.position.y > 1)
        {
            transform.position = new Vector3(this.transform.position.x, 0, this.transform.position.z);
        }

        if (Playerhealth < 1)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Enemy_stage1")
        {
            damageSound.Play();
            Playerhealth -= 1;
            print("hit! 1 damage");
            print(Playerhealth);
        }

        if (target.tag == "Enemy_stage2")
        {
            damageSound.Play();
            Playerhealth -= 1;
            print("hit! 1 damage");
            print(Playerhealth);
        }
        if (target.tag == "Enemy_stage3")
        {
            damageSound.Play();
            Playerhealth -= 1;
            print("hit! 1 damage");
            print(Playerhealth);
        }
        if (target.tag == "Enemy_stage4")
        {
            damageSound.Play();
            Playerhealth -= 1;
            print("hit! 1 damage");
            print(Playerhealth);
        }
        if (target.tag == "Enemy_stage5")
        {
            damageSound.Play();
            Playerhealth -= 1;
            print("hit! 1 damage");
            print(Playerhealth);
        }
        if (target.tag == "Enemy_stage6")
        {
            damageSound.Play();
            Playerhealth -= 1;
            print("hit! 1 damage");
            print(Playerhealth);
        }


        if (target.tag == "Enemy_shot")
        {
            damageSound.Play();
            Playerhealth -= 1;
            print("hit! 1 damage");
            print(Playerhealth);
        }

        if (target.tag=="Enemy_bomb")
        {
            damageSound.Play();
            Playerhealth -= 3;
            print("bomb hit player");
            print(Playerhealth);
        }
        if (target.tag == "spawntrigger")
        {
            Playerhealth = 30;
            print("healed");
        }
    }
}

