using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMotion : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb;
    private Transform currentPoint;
    public float speed = 4f;
    private float horizontal;
    private bool isFacingRight = true;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform;
    }
    void Update() {
        horizontal = Input.GetAxis("Horizontal");
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == pointB.transform){
            rb.velocity = new Vector2(speed, 0);
        } else {
            rb.velocity = new Vector2(-speed, 0);
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform){
            Flip();
            currentPoint = pointA.transform;
        } else if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform){
            Flip();
            currentPoint = pointB.transform;
        }
    }
    private void OnDrawGizmos(){
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);
    }
    //Visualising
    private void Flip(){
        if (isFacingRight && (rb.velocity.x < 0f)){
            isFacingRight = false;
            transform.Rotate(0f, 180f, 0f);
        } else if (isFacingRight == false && (rb.velocity.x > 0f)){
            isFacingRight = true;
            transform.Rotate(0f, 180f, 0f);
        }
    }
}
