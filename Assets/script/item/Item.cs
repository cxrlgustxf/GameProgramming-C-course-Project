using UnityEngine;

public class Item : MonoBehaviour
{

    public int ItemID;
    void Start()
    {
        ItemID = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public int onItemPickup()
    {



        return ItemID;
    }

    
}
