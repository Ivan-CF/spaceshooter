﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumMeteor : Meteors
{
    public override void InstanceMeteors()
    {
        Instantiate(meteorToInstanciate, this.transform.position, Quaternion.identity, null);
        Instantiate(meteorToInstanciate, this.transform.position, Quaternion.identity, null);
    }
  
   
}
