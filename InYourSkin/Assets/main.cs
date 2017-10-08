using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour {

    public Texture2D texture1;
    public Texture2D texture2;
    public GameObject skin;
    int textureIndex;
    int filter = 0;
    string[] TextureName = { "black-male-young", "asian-male-young", "caucasian-male-young" };
    string[] AudioObjects = { "africa", "asian", "caucasian" };
    GameObject sound_chRoom;
    bool playFirstTime = true;
    static int condition = -1;


    // Use this for initialization
    void Start () {


        //controllerInput = Controllers.GetController(0);
        skin = GameObject.Find("MakeHuman_simpleascottkMesh");

    }

    
     

        
}
