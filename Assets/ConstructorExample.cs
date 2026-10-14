using UnityEngine;

public class ConstructorExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Human Alice = new Human("alice", 23, 160);

        Debug.Log(Alice.name);
        Debug.Log(Alice.age);
        Debug.Log(Alice.height);

        Human John = new Human();
        
    }
    class Human

    // Update is called once per frame
    void Update()
    {
        
    }
}
