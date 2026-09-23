using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public float speed = 0.01f;
    

    

    void Start()
    {
        //bool a = true;
        //bool b = false;
        //gameObject.SetActive(a || b);
        //Vector2 newPos = transform.position;
        //newPos.x = newPos.x + 5;
        //transform.position = newPos;


        transform.position = Vector3.one; //(1,1,1)


    }

    void Update()
    {
       if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0,speed,0);
        }
       if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0, -speed, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-speed, 0, 0);
        }
    }
}

