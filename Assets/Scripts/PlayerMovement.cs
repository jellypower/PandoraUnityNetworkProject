using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMovement : NetworkBehaviour {

    private int maxHp;
    public int curHp;
    private float speed = 10;

    PlayerNetworkMovement PNM; //-----------------------------------------------

    private void Awake()
    {
        maxHp = 100;
        curHp = maxHp;
    }

    private void Start()
    {
        PNM = GameObject.Find("PlayerNetworkMovement").GetComponent<PlayerNetworkMovement>(); //------------------------------
    }

    private void Update()
    {
        if (!isLocalPlayer) return;
        
        if (Input.GetKey(KeyCode.W)) transform.position += Vector3.up * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A)) transform.position += Vector3.left * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S)) transform.position += Vector3.down * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D)) transform.position += Vector3.right * speed * Time.deltaTime;
        
    }

    public void BeAttacked(int decHp)
    {
        this.curHp -= decHp;
    }

}
