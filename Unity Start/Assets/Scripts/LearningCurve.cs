using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Integer variables
    private int currentAge = 30;
    public int addedAge = 1;
    
    //float ends with f
    public float pi = 3.14f;

    //string
    public string firstName = "Bob";

    //boolean
    public bool isAuthor = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(30 + 1);

        Debug.Log(currentAge + 1);
        ComputedAge();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function
    void ComputedAge(){
        Debug.Log(currentAge + addedAge);
    }
}
