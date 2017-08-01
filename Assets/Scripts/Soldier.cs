using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Blue.Pathfinding;

// by @Bullrich

namespace rts
{
    [RequireComponent(typeof(CharacterController))]
    public class Soldier : Unit
    {
        CharacterController _controller;
        private void Start()
        {
            _controller = GetComponent<CharacterController>();
        }

        public override void MoveTo(Vector3 targetPos)
        {
            Vector3 offset = targetPos - transform.position;
            offset = offset.normalized * speed;
            _controller.Move(offset * Time.deltaTime);
        }

    }
}
