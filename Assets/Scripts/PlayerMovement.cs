using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    private CharacterController m_charCont;

    float m_horizontal;
    float m_vertical;
    public float PlayerSpeed = 0.2f;


    public Vector3 playerVelocity;
    public bool groundedPlayer;
    private float jumpHeight = 2.0f;
    private float gravityValue = -9.81f;

    void Start () 
    {
       


    }

	void Update () {
        m_horizontal = Input.GetAxis("Horizontal");
        m_vertical = Input.GetAxis("Vertical");

        Vector3 m_playerMovement = new Vector3(m_horizontal, 0f, m_vertical) * PlayerSpeed;

        m_charCont.Move(m_playerMovement);
        //--------------
        groundedPlayer = m_charCont.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }


        if (m_playerMovement != Vector3.zero)
        {
            gameObject.transform.forward = m_playerMovement;
        }


        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
          
            playerVelocity.y += Mathf.Sqrt(jumpHeight* -3.0f * gravityValue);
        }
        if (m_charCont.transform.position.y >= 0)
        {

            playerVelocity.y += gravityValue * Time.deltaTime;
        }
        m_charCont.Move(playerVelocity * Time.deltaTime);
    }
}
