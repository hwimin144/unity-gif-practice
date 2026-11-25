using UnityEngine;

public class people : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Human Alexis = new Adult("alexis", 23, 155);
        Adult adult_alexis = Alexis as Adult;

        if (adult_alexis     == null)
        {
            Debug.Log("Failure~!");
        }
        else
        {
            Debug.Log("success!!!");
        }


    }
}
class Adult : Human
{
    public Adult(string _name, int _age, float _height) : base(_name, _age, _height) { }
}
class Baby : Human
{
    public Baby(string _name, int _age, float _height) : base(_name, _age, _height) { }
}

    class Human
    {
        public string name;
        public float height;
        public int age;
        protected string address;


        public string Name
        {
            get { return name;}
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }

        }

       

        

        public Human(string _name, int _age, float _height)
        {
            name = _name;
            age = _age;
            height = _height;
        }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
