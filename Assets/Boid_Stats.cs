using UnityEngine; 
using System.Collections;

public class Boid_Stats : MonoBehaviour
{
    public bool Flock = false;
    public bool Preditor = false;     
    
    public bool Cohesion  = false;
    public bool Seperation = false;
    public bool Allign = false;
    public bool Boxed = false;
    public bool Sphered = false;

    public float Velocity_Rng_Min = -5.0f;
    public float Velocity_Rng_Max = 5.0f;

    public Vector3 velocity;


    // Use this for initialization
    void Start()
    {
        if(Flock)
        velocity = new Vector3(Random.Range(Velocity_Rng_Min, Velocity_Rng_Max), Random.Range(Velocity_Rng_Min, Velocity_Rng_Max), Random.Range(Velocity_Rng_Min, Velocity_Rng_Max));
    }

    // Update is called once per frame
    void Update()
    {
        
        
           // print(gameObject.GetComponent<Transform>().localEulerAngles.x);

            //gameObject.GetComponent<Transform>().rotation = new Quaternion((velocity.normalized.y* -90), (velocity.normalized.z * -90), (velocity.normalized.x * -90), 90); //new Vector4(velocity.normalized.x * 90, (velocity.normalized.x * 90), (velocity.normalized.x * 90), 0); 
            gameObject.GetComponent<Transform>().position += velocity;
            gameObject.GetComponent<Boid_Stats>().velocity = (gameObject.GetComponent<Boid_Stats>().velocity.normalized * .15f);
        
    }


   
}
