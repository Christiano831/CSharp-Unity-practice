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

        //using a switch is very similar to an if-else just cleaner
        string characterAction = "Attack";
        switch(characterAction){
            case "Heal":
                Debug.Log("You have taken a potion.");
                break;
            case "Attack":
                Debug.Log("You have swung your sword");
                goto case "Hit";
                // break;
            case "Hit":
                Debug.Log("Slash!");
                break;
            default:
                Debug.Log("You brought up your shield");
                break;
        }

        //dictionaries are basically super lists (remind me of JSON)
        Dictionary<string, int> itemInventory = new Dictionary<string, int>() {
            {"Potion", 5},
            {"Antidote", 7},
            {"Super Potion", 1}
        };
        Debug.LogFormat("Items: {0}", itemInventory.Count);

        Character hero = new Character();
        Debug.LogFormat("Hero: {0} - {1} EXP", hero.name, hero.exp);
        Character heroine = new Character("Agatha");
        Debug.LogFormat("Hero: {0} - {1} EXP", heroine.name, heroine.exp);
        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        
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
