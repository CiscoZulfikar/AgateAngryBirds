using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodyBird : Bird
{
    public bool _hasExplode = false;

    public void Explode()
    {
        if (State == BirdState.HitSomething && !_hasExplode)
        {
            transform.localScale = new Vector2(2.0f, 2.0f);
            _hasExplode = true;
        }
    }

    public override void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("BOOM");
        State = BirdState.HitSomething;
        Explode();
    }
}