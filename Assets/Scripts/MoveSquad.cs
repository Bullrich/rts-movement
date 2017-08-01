using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Blue.Pathfinding;

// by @Bullrich

namespace rts
{
    public class MoveSquad : MonoBehaviour
    {
        public Unit[] units;
        private Vector3[] offsets;

        void Start()
        {
            offsets = new Vector3[units.Length];
            for (int i = 0; i < units.Length; i++)
            {
                offsets[i] = units[i].transform.position - units[0].transform.position;
            }
        }

        public void MoveToPoint(Vector3 point)
        {
            for (int i = 0; i < units.Length; i++)
            {
                units[i].NavigateToPoint(units[i].transform.position, point + offsets[i]);
            }
        }

        private void CheckClick()
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    MoveToPoint(hit.point);
                }
            }
        }

        private void Update()
        {
            CheckClick();
        }
    }
}
