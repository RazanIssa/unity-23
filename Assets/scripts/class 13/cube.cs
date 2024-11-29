using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace class14
{
    public class cube : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float xnew = Mathf.PingPong(Time.time * 20, 45) - 45;
            float ynew = Mathf.PingPong(Time.time * 20, 45) - 45;

            transform.rotation = Quaternion.Euler(new Vector3(xnew, ynew, 0));
        }
    }
}