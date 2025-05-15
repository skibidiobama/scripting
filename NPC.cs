using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //здоровье npc
    public int health = 5;

    //уровень npc
    public int level = 1;

    //скорость npc
    public float speed = 1.2f;
    
    void Start()
    {
        // повышает здоровье npc в зависимости от уровня npc
        health = health + level;
        print("health of npc = " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z = newPosition.z + speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
