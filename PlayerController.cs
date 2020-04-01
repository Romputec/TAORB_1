using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject me;
    [SerializeField] private CharacterMoves identity;
    public int playerNum;
    private float movement;
    private float aimX;
    private float aimY;
    private bool jump;
    private bool crouch;
    private bool sprint;
    private bool primary;
    private bool secondary;
    private bool block;

    // Start is called before the first frame update
    public void Start()
    {
        if(me.transform.localPosition.x < 0)
        {
            playerNum = 1;
        } else
        {
            playerNum = 2;
        }
            
    }

    // Update is called once per frame
    public void Update()
    {
        //accepts inputs depending on variable playerNum
        if (playerNum == 1)
        {
            movement = Input.GetAxisRaw("Horizontal1");
            aimX = Input.GetAxisRaw("AimX1");
            aimY = Input.GetAxisRaw("AimY1");
            if (Input.GetAxisRaw("Vertical1") == 1)
            {
                jump = true;
            } else
            {
                jump = false;
            }
        }
        else if (playerNum == 2)
        {
            movement  = Input.GetAxisRaw("Horizontal2");
            aimX = Input.GetAxisRaw("AimX2");
            aimY = Input.GetAxisRaw("AimY2");
            if (Input.GetAxisRaw("Vertical2") == 1)
            {
                jump = true;
            }
            else
            {
                jump = false;
            }
        }
        


    }
    public void FixedUpdate()
    {
        identity.FrameAction(aimX, aimY, movement, jump);
    }



}
