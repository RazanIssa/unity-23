using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

namespace toy
{

    public class Toy : MonoBehaviour
    {

        public float hor = 1f;
        public float rot = 10f;

        public Vector3 scalefacetor = new Vector3(0.01f, 0.01f, 0.01f);
        void Start()
        {

        }

        void Update()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.localScale = transform.localScale + scalefacetor;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.localScale = transform.localScale - scalefacetor;
            }
            transform.rotation = Quaternion.Euler(new Vector3(0f, rot, 0f));
            transform.position = transform.position + new Vector3(hor, 0f, 0f);

        }
    }
}