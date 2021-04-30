using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRigidBody;
    [SerializeField] private float jumpForce;
    [SerializeField] private float movementSpeed;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private int score=0;
    [SerializeField] private Text scoreText;
    [SerializeField] private float timeDamper = 0.0009f;
    void Start() 
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   
        
        MoveForward();
        PushUp();
        
    }
    
    
    private void MoveForward()
    {
        movementSpeed += Time.deltaTime*timeDamper ;
        transform.Translate(Vector3.forward * (movementSpeed * Time.deltaTime));
    }

    private void PushUp()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            playerRigidBody.velocity =
                new Vector3(transform.position.x, jumpForce * Time.deltaTime, transform.position.z);
        }
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Time.timeScale = 0f;
            gameOverPanel.SetActive(true);
        }
        else if (other.gameObject.CompareTag("Coin"))
        {   
            Destroy(other.gameObject);
            score += 1;
            scoreText.text = score.ToString();
        }
    }
}
