using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Blue.Pathfinding;

// by @Bullrich

namespace rts
{
    public class ClickManager : MonoBehaviour
    {
        public Unit unit;
        private void CheckClick()
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    unit.NavigateToPoint(unit.transform.position, hit.point);
                }
            }
        }

        private void Update()
        {
            CheckClick();
        }
    }
}
