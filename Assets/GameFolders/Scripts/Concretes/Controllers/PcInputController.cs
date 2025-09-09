using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OopProject1.Controllers
{
    public class PcInputController
    {
        public bool LeftMouseClickDown => Input.GetMouseButtonDown(0);
        public bool RightMouseClickDown => Input.GetMouseButtonDown(1);
    }
}


