using UnityEngine;
using System.Collections;

public class Preditor_Con : MonoBehaviour
{
    public string up;
    public string down;
    public string left;
    public string right;
    public string forward;
    public string back;

   public float Con_Speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            gameObject.GetComponent<Boid_Stats>().velocity.y += Con_Speed;
        if (Input.GetKeyDown(KeyCode.S))
            gameObject.GetComponent<Boid_Stats>().velocity.y -= Con_Speed;
        if (Input.GetKeyDown(KeyCode.A))
            gameObject.GetComponent<Boid_Stats>().velocity.x -= Con_Speed;
        if (Input.GetKeyDown(KeyCode.D))
            gameObject.GetComponent<Boid_Stats>().velocity.x += Con_Speed;
        if (Input.GetKeyDown(KeyCode.I))
            gameObject.GetComponent<Boid_Stats>().velocity.z += Con_Speed;
        if (Input.GetKeyDown(KeyCode.K))
            gameObject.GetComponent<Boid_Stats>().velocity.z -= Con_Speed;
    }

    

}
