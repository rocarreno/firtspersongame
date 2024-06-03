using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwgrenade : MonoBehaviour
{
    public float throwforce = 500;

    public GameObject grenadePrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Throw();
        }
    }
    public void Throw()
    {
        GameObject newGrenade = Instantiate(grenadePrefab, transform.position, transform.rotation);

        newGrenade.GetComponent<Rigidbody>().AddForce(transform.forward * throwforce);
    }

}
