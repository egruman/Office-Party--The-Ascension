using UnityEngine;
using System.Collections;

public class enemy_movement : MonoBehaviour
{

    Vector2 myVec = new Vector2(0, 0);
    public float speed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int i= Random.Range(0, 50);
        if (i==5) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
        else if (i == 1)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
            this.transform.GetChild(0).transform.rotation =
                Quaternion.AngleAxis(-90, Vector3.forward);
        }
        else if (i == 2)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
            this.transform.GetChild(0).transform.rotation =
                Quaternion.AngleAxis(90, Vector3.forward);
        }

        else if (i == 3)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
            this.transform.GetChild(0).transform.rotation =
                Quaternion.AngleAxis(180, Vector3.forward);
        }
        else if (i == 4)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
            this.transform.GetChild(0).transform.rotation =
                Quaternion.AngleAxis(0, Vector3.forward);
        }
    }

}
