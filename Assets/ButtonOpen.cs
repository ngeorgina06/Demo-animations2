using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOpen : MonoBehaviour
{
    [SerializeReference] Animator chest;
 
 private void OnTriggerEnter(Collider other)
 {
        chest.SetBool("Buttonpressed", true);
 }

  private void OnTriggerExit(Collider other)
 {
        chest.SetBool("Buttonpressed", false);
    }
 }
