using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOpen : MonoBehaviour
{
    [SerializeReference] Animator chest;
    public void Open(){
        chest.SetBool("IsOpen",true);
    }
 }
