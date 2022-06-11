using UnityEngine;

public class GameManager : MonoBehaviour {

    // static field
    private static GameManager instanse;
    // public member
    public static GameManager Instanse
    {
        get
        {
            if(instanse == null)
            {
                instanse = new GameManager();
            }
            return instanse;
        }
    }
    // serialized field

    // private member

    
    private GameManager() { }

    public void Awake() 
	{
        
    }

    public void Start () 
	{
	    
	}
	

    public void Update () 
	{
	
	}

    public void FixedUpdate() 
	{
        
    }
}