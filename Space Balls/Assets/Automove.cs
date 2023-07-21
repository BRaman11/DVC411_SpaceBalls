using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objPickup : MonoBehaviour
{
    public GameObject crosshair1, crosshair2;
    public Transform objTransform, cameraTrans;
    public bool interactable, pickedup;
    public Rigidbody objRigidbody;
    public float throwAmount;
    // Start is called before the first frame update
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            crosshair1.SetActive(false);
            crosshair2.SetActive(true);
            interactable = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if(pickedup == false)
            {
                crosshair1.SetActive(true);
                crosshair2.SetActive(false);
                interactable = false;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                objTransform.parent = cameraTrans;
                objRigidbody.useGravity = false;
                pickedup = true;
            }
            if (Input.GetMouseButtonUp(0))
            {
                objTransform.parent = null;
                objRigidbody.useGravity = true;
                pickedup = false;
            }
        }
    }
}
