using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : Interactable
{
    [SerializeField]
    private GameObject pickup;
    private bool pick; 
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
        pick = !pick;
        pickup.GetComponent<Animator>().SetBool("isPickUp",pick);
    }
}
