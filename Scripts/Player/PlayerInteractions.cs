using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("gunAmmo"))
        {
            GameManager.Instance.gunAmmo += other.gameObject.GetComponent<Ammobox>().ammo;
            Destroy(other.gameObject);
        }
    }
}
