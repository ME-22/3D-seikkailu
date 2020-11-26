using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hahmoOhjain : MonoBehaviour
{
    public float juoksuNopeus = 3f;

    public float hiirenNopeus = 3f;

    public float painovoima = 10f;

    public float horisonttaalinenPyorinta = 0f;

    public float vertikaalinenPyorinta = 0f;

    public float maxKaannosAsteet = 60f;

    public CursorLockMode haluttuMoodi;

    private Vector3 liikesuunta = Vector3.zero;

    private CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = getComonent<CharacterController>();
        Cursor.lockState = haluttuMoodi;

        Cursor.visible = (CursorLockMode.Locked != haluttuMoodi);
    }

    // Update is called once per frame
    void Update()
    {
        horisonttaalinenPyorinta += Input.GetAxis("Mouse X") * hiirenNopeus;
        vertikaalinenPyorinta -= Input.GetAxis("Mouse Y") * hiirenNopeus;
       // Debug.Log($"asteet {horisonttaalinenPyorinta}");
       vertikaalinenPyorinta = Mathf.Clamp(vertikaalinenPyorinta,-maxKaannosAsteet, maxKaannosAsteet);
        Camera.main.transform.localRotation = Quaternion.Euler(vertikaalinenPyorinta,horisonttaalinenPyorinta,0);
      
        
    }
}
