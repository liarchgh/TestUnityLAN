using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;

public class Player_NetworkSetup : NetworkBehaviour
{

    [SeriallzeField] public Camera FPSCharacterCam;
    [SeriallzeField] public AudioListener audioListener;

    void Start()
    {
        if (isLocalPlayer)
        {
            GetComponent<CharacterController>().enabled = true;
            GetComponent<FirstPersonController>().enabled = true;
            FPSCharacterCam.enabled = true;
            audioListener.enabled = true;
        }
    }
}
