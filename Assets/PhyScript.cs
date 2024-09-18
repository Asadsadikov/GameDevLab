using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float inSpeed = 10f;
    public float speedUp = 0.2f;
    public Text playerText;
    public Text opponentText;
    private int hitCount;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("StartBall", 2f);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, inSpeed + (speedUp * hitCount));        
    }
    private void StartBall(){
        rb.velocity = new Vector2(-1, 0) * (inSpeed + speedUp * hitCount);
    }
}
