﻿using System;
using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEngine;

namespace Data {
    
    public interface IEnumValue 
{
         
        string GetEnumKey();
        void Initialize(IEnumType enumType);
}
}