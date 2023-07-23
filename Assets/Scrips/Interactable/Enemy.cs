using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Interactable
{
    [SerializeField]
    private GameObject enemy;
    private bool deadEnemy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void Interact()
    {
        deadEnemy = !deadEnemy;
        enemy.GetComponent<Animator>().SetBool("isDead", deadEnemy);
    }
}
