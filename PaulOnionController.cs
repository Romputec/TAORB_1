using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaulOnionController : CharacterMoves
{
    [SerializeField] private PlayerController inputs;
    [SerializeField] private BoxCollider2D head;
    [SerializeField] private CircleCollider2D torso;
    [SerializeField] private Rigidbody2D mass;
    private bool onGround;
    private float DEX = 1;
    private float SPD = 10;
    // Start is called before the first frame update


    // Update is called once per frame


    public override void FrameAction(float aimX, float aimY, float move, bool jump)
    {

        if (System.Math.Abs((mass.velocity.x / System.Math.Abs(mass.velocity.x)) - move) == 2f)
        {
            mass.AddForce(new Vector2(move * (DEX * 250 - mass.velocity.x * 10f), 0));
        }
        else if (System.Math.Abs(mass.velocity.x) >= SPD)
        {
            mass.velocity.Set(SPD, mass.velocity.y);
        }
        else
        {
            mass.AddForce(new Vector2(move * DEX * 250, 0));
        }
        if (jump == true)
        {
            mass.AddForce(new Vector2(0, DEX * 500));
        }

    }
}

